--
-- PostgreSQL database dump
--

\restrict yrjaiKDFevBcgMZL45VQgpzQFhKbMqq04891quXwiqQyF3rKnSqZfMmnJ121bey

-- Dumped from database version 18.3
-- Dumped by pg_dump version 18.3

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET transaction_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- Name: rol; Type: TYPE; Schema: public; Owner: postgres
--

CREATE TYPE public.rol AS ENUM (
    '0',
    '1',
    '2',
    '3'
);


ALTER TYPE public.rol OWNER TO postgres;

--
-- Name: actualizar_producto(character varying, character varying, numeric, numeric, character varying, boolean); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.actualizar_producto(id_producto_p character varying, nombre_p character varying, cantidad_p numeric, precio_p numeric, id_categoria_p character varying, estado_p boolean) RETURNS text
    LANGUAGE plpgsql
    AS $$
BEGIN
    -- Validar si el producto existe
    IF NOT EXISTS (
        SELECT 1
        FROM TBL_PRODUCTO t
        WHERE t.id_producto = id_producto_p
    ) THEN
        RETURN 'ERROR|El producto no existe';
    END IF;

    -- Actualizar producto
    UPDATE TBL_PRODUCTO
    SET
        nombre       = nombre_p,
        cantidad     = cantidad_p,
        precio       = precio_p,
        id_categoria = id_categoria_p,
        estado       = estado_p
    WHERE id_producto = id_producto_p;

    RETURN 'OK|Producto actualizado correctamente';
END;
$$;


ALTER FUNCTION public.actualizar_producto(id_producto_p character varying, nombre_p character varying, cantidad_p numeric, precio_p numeric, id_categoria_p character varying, estado_p boolean) OWNER TO postgres;

--
-- Name: actualizar_usuario(bigint, character varying, character varying, public.rol, boolean); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.actualizar_usuario(id_p bigint, nombre_p character varying, password_p character varying, tipo_p public.rol, estado_p boolean) RETURNS text
    LANGUAGE plpgsql
    AS $$
BEGIN
    -- Validar si el usuario existe
    IF NOT EXISTS (
        SELECT 1
        FROM TBL_USUARIO u
        WHERE u.id = id_p
    ) THEN
        RETURN 'ERROR|El usuario no existe';
    END IF;

    -- Validar si el usuario tiene sesión activa
    IF EXISTS (
        SELECT 1
        FROM TBL_USUARIO u
        WHERE u.id = id_p
          AND u.secion = TRUE
    ) THEN
        RETURN 'ERROR|No se puede modificar un usuario con sesión activa';
    END IF;

    -- Actualizar usuario (secion no se modifica)
    UPDATE TBL_USUARIO
    SET
        nombre   = nombre_p,
        password = password_p,
        tipo     = tipo_p,
        estado   = estado_p
    WHERE id = id_p;

    RETURN 'OK|Usuario actualizado correctamente';
END;
$$;


ALTER FUNCTION public.actualizar_usuario(id_p bigint, nombre_p character varying, password_p character varying, tipo_p public.rol, estado_p boolean) OWNER TO postgres;

--
-- Name: comp_usuario(bigint); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.comp_usuario(id_usuario bigint) RETURNS text
    LANGUAGE plpgsql
    AS $$
DECLARE
    v_password        TEXT;
    v_estado          BOOLEAN;
    v_secion          BOOLEAN;
    v_ultima_actividad TIMESTAMP;
BEGIN
    SELECT password, estado, secion, ultima_actividad
    INTO v_password, v_estado, v_secion, v_ultima_actividad
    FROM tbl_usuario
    WHERE id = id_usuario;

    IF v_password IS NULL THEN
        RETURN 'ERROR|Credenciales Invalidas';
    END IF;

    IF v_estado = FALSE THEN
        RETURN 'ERROR|Credenciales Invalidas';
    END IF;

    -- Si hay sesión activa verificar si expiró
    IF v_secion = TRUE THEN
        IF v_ultima_actividad < NOW() - INTERVAL '6 minutes' THEN
            -- Sesión expirada, limpiarla y permitir login
            UPDATE tbl_usuario SET secion = FALSE WHERE id = id_usuario;
        ELSE
            -- Sesión real activa
            RETURN 'ERROR|La sesión está activa';
        END IF;
    END IF;

    RETURN 'OK|' || v_password;
END;
$$;


ALTER FUNCTION public.comp_usuario(id_usuario bigint) OWNER TO postgres;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: tbl_usuario; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_usuario (
    id bigint NOT NULL,
    nombre character varying(50) NOT NULL,
    password character varying(250) NOT NULL,
    tipo public.rol NOT NULL,
    secion boolean NOT NULL,
    estado boolean NOT NULL,
    ultima_actividad timestamp without time zone
);


ALTER TABLE public.tbl_usuario OWNER TO postgres;

--
-- Name: inc_usuario(bigint); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.inc_usuario(id_usuario bigint) RETURNS SETOF public.tbl_usuario
    LANGUAGE plpgsql
    AS $$
BEGIN
    UPDATE TBL_USUARIO
    SET secion = TRUE,
        ultima_actividad = NOW() -- Registra cuando inició sesión
    WHERE id = id_usuario;

    RETURN QUERY
    SELECT * FROM TBL_USUARIO WHERE id = id_usuario;
END;
$$;


ALTER FUNCTION public.inc_usuario(id_usuario bigint) OWNER TO postgres;

--
-- Name: insertar_producto(character varying, character varying, numeric, numeric, character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.insertar_producto(id_producto_p character varying, nombre_p character varying, cantidad_p numeric, precio_p numeric, id_categoria_p character varying) RETURNS text
    LANGUAGE plpgsql
    AS $$
BEGIN
    -- Validar si el producto ya existe y está ACTIVO
    IF EXISTS (
        SELECT 1 
        FROM TBL_PRODUCTO t
        WHERE t.id_producto = id_producto_p
          AND t.estado = TRUE
    ) THEN
        RETURN 'ERROR|El producto ya existe y está activo';
    END IF;

    -- Validar si el producto existe pero está DADO DE BAJA
    IF EXISTS (
        SELECT 1 
        FROM TBL_PRODUCTO t
        WHERE t.id_producto = id_producto_p
          AND t.estado = FALSE
    ) THEN
        RETURN 'ERROR|El producto ya existe pero está dado de baja';
    END IF;

    -- Validar si la categoría existe
    IF NOT EXISTS (
        SELECT 1 
        FROM TBL_CATEGORIA c
        WHERE c.id_categoria = id_categoria_p
    ) THEN
        RETURN 'ERROR|La categoría no existe';
    END IF;

    -- Insertar producto con estado = TRUE por defecto
    INSERT INTO TBL_PRODUCTO (
        id_producto,
        nombre,
        cantidad,
        precio,
        estado,
        id_categoria
    )
    VALUES (
        id_producto_p,
        nombre_p,
        cantidad_p,
        precio_p,
        TRUE,
        id_categoria_p
    );

    RETURN 'OK|Producto agregado correctamente';

EXCEPTION
    WHEN OTHERS THEN
        RETURN 'ERROR|' || SQLERRM;
END;
$$;


ALTER FUNCTION public.insertar_producto(id_producto_p character varying, nombre_p character varying, cantidad_p numeric, precio_p numeric, id_categoria_p character varying) OWNER TO postgres;

--
-- Name: insertar_usuario(bigint, character varying, character varying, public.rol, boolean); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.insertar_usuario(id_p bigint, nombre_p character varying, password_p character varying, tipo_p public.rol, estado_p boolean) RETURNS text
    LANGUAGE plpgsql
    AS $$
BEGIN
    -- Validar si el usuario ya existe
    IF EXISTS (
        SELECT 1
        FROM TBL_USUARIO u
        WHERE u.id = id_p
    ) THEN
        RETURN 'ERROR|El usuario ya existe';
    END IF;

    -- Insertar usuario con secion = FALSE por defecto
    INSERT INTO TBL_USUARIO (
        id,
        nombre,
        password,
        tipo,
        secion,
        estado
    )
    VALUES (
        id_p,
        nombre_p,
        password_p,
        tipo_p,
        FALSE,
        estado_p
    );

    RETURN 'OK|Usuario agregado correctamente';
END;
$$;


ALTER FUNCTION public.insertar_usuario(id_p bigint, nombre_p character varying, password_p character varying, tipo_p public.rol, estado_p boolean) OWNER TO postgres;

--
-- Name: tbl_categoria; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_categoria (
    id_categoria character varying(4) NOT NULL,
    nom_cat character varying(50) NOT NULL
);


ALTER TABLE public.tbl_categoria OWNER TO postgres;

--
-- Name: tbl_cliente; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_cliente (
    id_cel bigint NOT NULL,
    nombre character varying(50) NOT NULL,
    apellido character varying(50) NOT NULL,
    apodo character varying(30),
    direccion_c integer
);


ALTER TABLE public.tbl_cliente OWNER TO postgres;

--
-- Name: tbl_colonia; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_colonia (
    idcolonia integer NOT NULL,
    colonia character varying(100) NOT NULL
);


ALTER TABLE public.tbl_colonia OWNER TO postgres;

--
-- Name: tbl_colonia_idcolonia_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.tbl_colonia ALTER COLUMN idcolonia ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public.tbl_colonia_idcolonia_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: tbl_corte; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_corte (
    id_corte bigint NOT NULL,
    fecha date NOT NULL,
    total_ventas numeric(10,4) NOT NULL,
    total_gasto numeric(10,4) NOT NULL,
    ganancia numeric(10,4) NOT NULL
);


ALTER TABLE public.tbl_corte OWNER TO postgres;

--
-- Name: tbl_corte_id_corte_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.tbl_corte ALTER COLUMN id_corte ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public.tbl_corte_id_corte_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: tbl_det_gasto; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_det_gasto (
    id_gasto_d bigint NOT NULL,
    monto numeric(10,4) NOT NULL,
    fecha date NOT NULL,
    id_gasto bigint NOT NULL,
    id_corte bigint
);


ALTER TABLE public.tbl_det_gasto OWNER TO postgres;

--
-- Name: tbl_det_gasto_id_gasto_d_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.tbl_det_gasto ALTER COLUMN id_gasto_d ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public.tbl_det_gasto_id_gasto_d_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: tbl_detalle_ventas; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_detalle_ventas (
    id_detalle_venta integer NOT NULL,
    cantidad integer NOT NULL,
    importe_p numeric(10,4) NOT NULL,
    nventa bigint,
    idprod character varying(30)
);


ALTER TABLE public.tbl_detalle_ventas OWNER TO postgres;

--
-- Name: tbl_detalle_ventas_id_detalle_venta_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_detalle_ventas_id_detalle_venta_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_detalle_ventas_id_detalle_venta_seq OWNER TO postgres;

--
-- Name: tbl_detalle_ventas_id_detalle_venta_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_detalle_ventas_id_detalle_venta_seq OWNED BY public.tbl_detalle_ventas.id_detalle_venta;


--
-- Name: tbl_direccion; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_direccion (
    id_direc integer NOT NULL,
    num_casa character varying(45),
    calle character varying(45) NOT NULL,
    cruzamientos character varying(45) NOT NULL,
    referencia character varying(200) NOT NULL,
    colonia_d integer NOT NULL
);


ALTER TABLE public.tbl_direccion OWNER TO postgres;

--
-- Name: tbl_direccion_id_direc_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.tbl_direccion ALTER COLUMN id_direc ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public.tbl_direccion_id_direc_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: tbl_estado; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_estado (
    id_estado character varying(10) NOT NULL,
    tipo_estado character varying(45) NOT NULL
);


ALTER TABLE public.tbl_estado OWNER TO postgres;

--
-- Name: tbl_fecha; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_fecha (
    id_fecha date NOT NULL,
    dia character varying(2) NOT NULL,
    mes character varying(2) NOT NULL,
    anio character varying(4) NOT NULL
);


ALTER TABLE public.tbl_fecha OWNER TO postgres;

--
-- Name: tbl_gasto; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_gasto (
    id_gasto bigint NOT NULL,
    descripcion character varying(255) NOT NULL
);


ALTER TABLE public.tbl_gasto OWNER TO postgres;

--
-- Name: tbl_gasto_id_gasto_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.tbl_gasto ALTER COLUMN id_gasto ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public.tbl_gasto_id_gasto_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: tbl_pago; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_pago (
    id_pago character varying(2) NOT NULL,
    tipo_pago character varying(45) NOT NULL
);


ALTER TABLE public.tbl_pago OWNER TO postgres;

--
-- Name: tbl_producto; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_producto (
    id_producto character varying(30) NOT NULL,
    nombre character varying(100) NOT NULL,
    cantidad numeric(10,4) NOT NULL,
    precio numeric(10,4) NOT NULL,
    estado boolean DEFAULT true,
    id_categoria character varying(4)
);


ALTER TABLE public.tbl_producto OWNER TO postgres;

--
-- Name: tbl_venta; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_venta (
    id_venta bigint NOT NULL,
    cantidad numeric(10,4) NOT NULL,
    importe_g numeric(10,4) NOT NULL,
    fecha date,
    num_cel bigint,
    tipo_pago character varying(2),
    tipo_estado character varying(10),
    id_corte bigint,
    id_usuario bigint NOT NULL
);


ALTER TABLE public.tbl_venta OWNER TO postgres;

--
-- Name: tbl_venta_id_venta_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.tbl_venta ALTER COLUMN id_venta ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public.tbl_venta_id_venta_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: tbl_detalle_ventas id_detalle_venta; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_detalle_ventas ALTER COLUMN id_detalle_venta SET DEFAULT nextval('public.tbl_detalle_ventas_id_detalle_venta_seq'::regclass);


--
-- Data for Name: tbl_categoria; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tbl_categoria (id_categoria, nom_cat) FROM stdin;
KL	Kilo
PZ	Pieza
\.


--
-- Data for Name: tbl_cliente; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tbl_cliente (id_cel, nombre, apellido, apodo, direccion_c) FROM stdin;
\.


--
-- Data for Name: tbl_colonia; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tbl_colonia (idcolonia, colonia) FROM stdin;
\.


--
-- Data for Name: tbl_corte; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tbl_corte (id_corte, fecha, total_ventas, total_gasto, ganancia) FROM stdin;
\.


--
-- Data for Name: tbl_det_gasto; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tbl_det_gasto (id_gasto_d, monto, fecha, id_gasto, id_corte) FROM stdin;
\.


--
-- Data for Name: tbl_detalle_ventas; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tbl_detalle_ventas (id_detalle_venta, cantidad, importe_p, nventa, idprod) FROM stdin;
\.


--
-- Data for Name: tbl_direccion; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tbl_direccion (id_direc, num_casa, calle, cruzamientos, referencia, colonia_d) FROM stdin;
\.


--
-- Data for Name: tbl_estado; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tbl_estado (id_estado, tipo_estado) FROM stdin;
\.


--
-- Data for Name: tbl_fecha; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tbl_fecha (id_fecha, dia, mes, anio) FROM stdin;
\.


--
-- Data for Name: tbl_gasto; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tbl_gasto (id_gasto, descripcion) FROM stdin;
\.


--
-- Data for Name: tbl_pago; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tbl_pago (id_pago, tipo_pago) FROM stdin;
\.


--
-- Data for Name: tbl_producto; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tbl_producto (id_producto, nombre, cantidad, precio, estado, id_categoria) FROM stdin;
4235	Aguacate Hash Malla	10.0000	50.0000	t	PZ
4085	Champiñon blanco	14.0000	80.0000	t	KL
4094	Zanahoria	23.0000	45.0000	t	KL
4198	Manzana Golden	30.0000	40.0000	t	KL
4225	Aguacate Hash	4.0000	3.0000	f	PZ
4959	Mango Paraiso	6.0000	50.0000	f	KL
4011	Platano Chiapas	5.0000	10.0000	f	KL
22222	hola	12.0000	12.0000	f	PZ
112	Coca Cola 200ml	10.0000	22.0000	f	PZ
1111	Funciona	0.0000	0.0000	f	PZ
4083	PapaBlanca	0.0000	0.0000	f	PZ
4048	Limón SS	0.0000	0.0000	f	PZ
\.


--
-- Data for Name: tbl_usuario; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tbl_usuario (id, nombre, password, tipo, secion, estado, ultima_actividad) FROM stdin;
9993546646	Gilbert	65Ds5l0q21EdKtg2LOlS1wgFLegdWGwkyVQJLzv508AyGS/nPheQcUB1/nW0zosl	1	f	t	\N
\.


--
-- Data for Name: tbl_venta; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tbl_venta (id_venta, cantidad, importe_g, fecha, num_cel, tipo_pago, tipo_estado, id_corte, id_usuario) FROM stdin;
\.


--
-- Name: tbl_colonia_idcolonia_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_colonia_idcolonia_seq', 1, false);


--
-- Name: tbl_corte_id_corte_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_corte_id_corte_seq', 1, false);


--
-- Name: tbl_det_gasto_id_gasto_d_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_det_gasto_id_gasto_d_seq', 1, false);


--
-- Name: tbl_detalle_ventas_id_detalle_venta_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_detalle_ventas_id_detalle_venta_seq', 1, false);


--
-- Name: tbl_direccion_id_direc_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_direccion_id_direc_seq', 1, false);


--
-- Name: tbl_gasto_id_gasto_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_gasto_id_gasto_seq', 1, false);


--
-- Name: tbl_venta_id_venta_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tbl_venta_id_venta_seq', 1, false);


--
-- Name: tbl_categoria tbl_categoria_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_categoria
    ADD CONSTRAINT tbl_categoria_pkey PRIMARY KEY (id_categoria);


--
-- Name: tbl_cliente tbl_cliente_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_cliente
    ADD CONSTRAINT tbl_cliente_pkey PRIMARY KEY (id_cel);


--
-- Name: tbl_colonia tbl_colonia_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_colonia
    ADD CONSTRAINT tbl_colonia_pkey PRIMARY KEY (idcolonia);


--
-- Name: tbl_corte tbl_corte_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_corte
    ADD CONSTRAINT tbl_corte_pkey PRIMARY KEY (id_corte);


--
-- Name: tbl_det_gasto tbl_det_gasto_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_det_gasto
    ADD CONSTRAINT tbl_det_gasto_pkey PRIMARY KEY (id_gasto_d);


--
-- Name: tbl_detalle_ventas tbl_detalle_ventas_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_detalle_ventas
    ADD CONSTRAINT tbl_detalle_ventas_pkey PRIMARY KEY (id_detalle_venta);


--
-- Name: tbl_direccion tbl_direccion_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_direccion
    ADD CONSTRAINT tbl_direccion_pkey PRIMARY KEY (id_direc);


--
-- Name: tbl_estado tbl_estado_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_estado
    ADD CONSTRAINT tbl_estado_pkey PRIMARY KEY (id_estado);


--
-- Name: tbl_fecha tbl_fecha_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_fecha
    ADD CONSTRAINT tbl_fecha_pkey PRIMARY KEY (id_fecha);


--
-- Name: tbl_gasto tbl_gasto_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_gasto
    ADD CONSTRAINT tbl_gasto_pkey PRIMARY KEY (id_gasto);


--
-- Name: tbl_pago tbl_pago_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_pago
    ADD CONSTRAINT tbl_pago_pkey PRIMARY KEY (id_pago);


--
-- Name: tbl_producto tbl_producto_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_producto
    ADD CONSTRAINT tbl_producto_pkey PRIMARY KEY (id_producto);


--
-- Name: tbl_usuario tbl_usuario_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_usuario
    ADD CONSTRAINT tbl_usuario_pkey PRIMARY KEY (id);


--
-- Name: tbl_venta tbl_venta_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_venta
    ADD CONSTRAINT tbl_venta_pkey PRIMARY KEY (id_venta);


--
-- Name: tbl_producto fk_categoria; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_producto
    ADD CONSTRAINT fk_categoria FOREIGN KEY (id_categoria) REFERENCES public.tbl_categoria(id_categoria);


--
-- Name: tbl_cliente tbl_cliente_direccion_c_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_cliente
    ADD CONSTRAINT tbl_cliente_direccion_c_fkey FOREIGN KEY (direccion_c) REFERENCES public.tbl_direccion(id_direc);


--
-- Name: tbl_det_gasto tbl_det_gasto_id_corte_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_det_gasto
    ADD CONSTRAINT tbl_det_gasto_id_corte_fkey FOREIGN KEY (id_corte) REFERENCES public.tbl_corte(id_corte);


--
-- Name: tbl_det_gasto tbl_det_gasto_id_gasto_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_det_gasto
    ADD CONSTRAINT tbl_det_gasto_id_gasto_fkey FOREIGN KEY (id_gasto) REFERENCES public.tbl_gasto(id_gasto);


--
-- Name: tbl_detalle_ventas tbl_detalle_ventas_idprod_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_detalle_ventas
    ADD CONSTRAINT tbl_detalle_ventas_idprod_fkey FOREIGN KEY (idprod) REFERENCES public.tbl_producto(id_producto);


--
-- Name: tbl_detalle_ventas tbl_detalle_ventas_nventa_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_detalle_ventas
    ADD CONSTRAINT tbl_detalle_ventas_nventa_fkey FOREIGN KEY (nventa) REFERENCES public.tbl_venta(id_venta);


--
-- Name: tbl_direccion tbl_direccion_colonia_d_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_direccion
    ADD CONSTRAINT tbl_direccion_colonia_d_fkey FOREIGN KEY (colonia_d) REFERENCES public.tbl_colonia(idcolonia);


--
-- Name: tbl_venta tbl_venta_fecha_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_venta
    ADD CONSTRAINT tbl_venta_fecha_fkey FOREIGN KEY (fecha) REFERENCES public.tbl_fecha(id_fecha);


--
-- Name: tbl_venta tbl_venta_id_corte_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_venta
    ADD CONSTRAINT tbl_venta_id_corte_fkey FOREIGN KEY (id_corte) REFERENCES public.tbl_corte(id_corte);


--
-- Name: tbl_venta tbl_venta_id_usuario_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_venta
    ADD CONSTRAINT tbl_venta_id_usuario_fkey FOREIGN KEY (id_usuario) REFERENCES public.tbl_usuario(id);


--
-- Name: tbl_venta tbl_venta_num_cel_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_venta
    ADD CONSTRAINT tbl_venta_num_cel_fkey FOREIGN KEY (num_cel) REFERENCES public.tbl_cliente(id_cel);


--
-- Name: tbl_venta tbl_venta_tipo_estado_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_venta
    ADD CONSTRAINT tbl_venta_tipo_estado_fkey FOREIGN KEY (tipo_estado) REFERENCES public.tbl_estado(id_estado);


--
-- Name: tbl_venta tbl_venta_tipo_pago_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_venta
    ADD CONSTRAINT tbl_venta_tipo_pago_fkey FOREIGN KEY (tipo_pago) REFERENCES public.tbl_pago(id_pago);


--
-- Name: SCHEMA public; Type: ACL; Schema: -; Owner: pg_database_owner
--

GRANT USAGE ON SCHEMA public TO lectura;
GRANT USAGE ON SCHEMA public TO admin;
GRANT USAGE ON SCHEMA public TO crud;


--
-- Name: TABLE tbl_usuario; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE public.tbl_usuario TO lectura;
GRANT SELECT,INSERT,DELETE,UPDATE ON TABLE public.tbl_usuario TO admin;
GRANT SELECT,INSERT,UPDATE ON TABLE public.tbl_usuario TO crud;


--
-- Name: TABLE tbl_categoria; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE public.tbl_categoria TO lectura;
GRANT SELECT,INSERT,DELETE,UPDATE ON TABLE public.tbl_categoria TO admin;
GRANT SELECT,INSERT,UPDATE ON TABLE public.tbl_categoria TO crud;


--
-- Name: TABLE tbl_cliente; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE public.tbl_cliente TO lectura;
GRANT SELECT,INSERT,DELETE,UPDATE ON TABLE public.tbl_cliente TO admin;
GRANT SELECT,INSERT,UPDATE ON TABLE public.tbl_cliente TO crud;


--
-- Name: TABLE tbl_colonia; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE public.tbl_colonia TO lectura;
GRANT SELECT,INSERT,DELETE,UPDATE ON TABLE public.tbl_colonia TO admin;
GRANT SELECT,INSERT,UPDATE ON TABLE public.tbl_colonia TO crud;


--
-- Name: SEQUENCE tbl_colonia_idcolonia_seq; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON SEQUENCE public.tbl_colonia_idcolonia_seq TO lectura;
GRANT ALL ON SEQUENCE public.tbl_colonia_idcolonia_seq TO admin;
GRANT USAGE ON SEQUENCE public.tbl_colonia_idcolonia_seq TO crud;


--
-- Name: TABLE tbl_corte; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE public.tbl_corte TO lectura;
GRANT SELECT,INSERT,DELETE,UPDATE ON TABLE public.tbl_corte TO admin;
GRANT SELECT,INSERT,UPDATE ON TABLE public.tbl_corte TO crud;


--
-- Name: SEQUENCE tbl_corte_id_corte_seq; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON SEQUENCE public.tbl_corte_id_corte_seq TO lectura;
GRANT ALL ON SEQUENCE public.tbl_corte_id_corte_seq TO admin;
GRANT USAGE ON SEQUENCE public.tbl_corte_id_corte_seq TO crud;


--
-- Name: TABLE tbl_det_gasto; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE public.tbl_det_gasto TO lectura;
GRANT SELECT,INSERT,DELETE,UPDATE ON TABLE public.tbl_det_gasto TO admin;
GRANT SELECT,INSERT,UPDATE ON TABLE public.tbl_det_gasto TO crud;


--
-- Name: SEQUENCE tbl_det_gasto_id_gasto_d_seq; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON SEQUENCE public.tbl_det_gasto_id_gasto_d_seq TO lectura;
GRANT ALL ON SEQUENCE public.tbl_det_gasto_id_gasto_d_seq TO admin;
GRANT USAGE ON SEQUENCE public.tbl_det_gasto_id_gasto_d_seq TO crud;


--
-- Name: TABLE tbl_detalle_ventas; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE public.tbl_detalle_ventas TO lectura;
GRANT SELECT,INSERT,DELETE,UPDATE ON TABLE public.tbl_detalle_ventas TO admin;
GRANT SELECT,INSERT,UPDATE ON TABLE public.tbl_detalle_ventas TO crud;


--
-- Name: SEQUENCE tbl_detalle_ventas_id_detalle_venta_seq; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON SEQUENCE public.tbl_detalle_ventas_id_detalle_venta_seq TO lectura;
GRANT ALL ON SEQUENCE public.tbl_detalle_ventas_id_detalle_venta_seq TO admin;
GRANT USAGE ON SEQUENCE public.tbl_detalle_ventas_id_detalle_venta_seq TO crud;


--
-- Name: TABLE tbl_direccion; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE public.tbl_direccion TO lectura;
GRANT SELECT,INSERT,DELETE,UPDATE ON TABLE public.tbl_direccion TO admin;
GRANT SELECT,INSERT,UPDATE ON TABLE public.tbl_direccion TO crud;


--
-- Name: SEQUENCE tbl_direccion_id_direc_seq; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON SEQUENCE public.tbl_direccion_id_direc_seq TO lectura;
GRANT ALL ON SEQUENCE public.tbl_direccion_id_direc_seq TO admin;
GRANT USAGE ON SEQUENCE public.tbl_direccion_id_direc_seq TO crud;


--
-- Name: TABLE tbl_estado; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE public.tbl_estado TO lectura;
GRANT SELECT,INSERT,DELETE,UPDATE ON TABLE public.tbl_estado TO admin;
GRANT SELECT,INSERT,UPDATE ON TABLE public.tbl_estado TO crud;


--
-- Name: TABLE tbl_fecha; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE public.tbl_fecha TO lectura;
GRANT SELECT,INSERT,DELETE,UPDATE ON TABLE public.tbl_fecha TO admin;
GRANT SELECT,INSERT,UPDATE ON TABLE public.tbl_fecha TO crud;


--
-- Name: TABLE tbl_gasto; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE public.tbl_gasto TO lectura;
GRANT SELECT,INSERT,DELETE,UPDATE ON TABLE public.tbl_gasto TO admin;
GRANT SELECT,INSERT,UPDATE ON TABLE public.tbl_gasto TO crud;


--
-- Name: SEQUENCE tbl_gasto_id_gasto_seq; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON SEQUENCE public.tbl_gasto_id_gasto_seq TO lectura;
GRANT ALL ON SEQUENCE public.tbl_gasto_id_gasto_seq TO admin;
GRANT USAGE ON SEQUENCE public.tbl_gasto_id_gasto_seq TO crud;


--
-- Name: TABLE tbl_pago; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE public.tbl_pago TO lectura;
GRANT SELECT,INSERT,DELETE,UPDATE ON TABLE public.tbl_pago TO admin;
GRANT SELECT,INSERT,UPDATE ON TABLE public.tbl_pago TO crud;


--
-- Name: TABLE tbl_producto; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE public.tbl_producto TO lectura;
GRANT SELECT,INSERT,DELETE,UPDATE ON TABLE public.tbl_producto TO admin;
GRANT SELECT,INSERT,UPDATE ON TABLE public.tbl_producto TO crud;


--
-- Name: TABLE tbl_venta; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON TABLE public.tbl_venta TO lectura;
GRANT SELECT,INSERT,DELETE,UPDATE ON TABLE public.tbl_venta TO admin;
GRANT SELECT,INSERT,UPDATE ON TABLE public.tbl_venta TO crud;


--
-- Name: SEQUENCE tbl_venta_id_venta_seq; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT ON SEQUENCE public.tbl_venta_id_venta_seq TO lectura;
GRANT ALL ON SEQUENCE public.tbl_venta_id_venta_seq TO admin;
GRANT USAGE ON SEQUENCE public.tbl_venta_id_venta_seq TO crud;


--
-- Name: DEFAULT PRIVILEGES FOR SEQUENCES; Type: DEFAULT ACL; Schema: public; Owner: postgres
--

ALTER DEFAULT PRIVILEGES FOR ROLE postgres IN SCHEMA public GRANT ALL ON SEQUENCES TO admin;
ALTER DEFAULT PRIVILEGES FOR ROLE postgres IN SCHEMA public GRANT USAGE ON SEQUENCES TO crud;


--
-- Name: DEFAULT PRIVILEGES FOR TABLES; Type: DEFAULT ACL; Schema: public; Owner: postgres
--

ALTER DEFAULT PRIVILEGES FOR ROLE postgres IN SCHEMA public GRANT SELECT ON TABLES TO lectura;
ALTER DEFAULT PRIVILEGES FOR ROLE postgres IN SCHEMA public GRANT SELECT,INSERT,DELETE,UPDATE ON TABLES TO admin;
ALTER DEFAULT PRIVILEGES FOR ROLE postgres IN SCHEMA public GRANT SELECT,INSERT,UPDATE ON TABLES TO crud;


--
-- PostgreSQL database dump complete
--

\unrestrict yrjaiKDFevBcgMZL45VQgpzQFhKbMqq04891quXwiqQyF3rKnSqZfMmnJ121bey

