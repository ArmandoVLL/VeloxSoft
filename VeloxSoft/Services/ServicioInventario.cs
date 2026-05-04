using Npgsql;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using VeloxSoft.Config;
using VeloxSoft.Models;

namespace VeloxSoft.Services
{
    public class ServicioInventario
    {
        private readonly DatabaseConfig _dbConfig;

        public ServicioInventario(DatabaseConfig dbConfig)
        {
            _dbConfig = dbConfig;
        }


        public List<Producto> Ver_Productos(out String errorMessage)
        {
            errorMessage = "null";
            try
            {
                var conn = new NpgsqlConnection(_dbConfig.GetConnection(Program.RolActual));
                conn.Open();
                using var cmd = new NpgsqlCommand(
                    @"SELECT p.id_producto, p.nombre, p.cantidad, p.precio, p.estado, c.nom_cat AS categoria
                      FROM tbl_producto p
                      INNER JOIN tbl_categoria c ON p.id_categoria = c.id_categoria
                      WHERE p.estado = true", conn);//CONSULTA SQL PARA OBTENER LOS PRODUCTOS ACTIVOS JUNTO CON SU CATEGORIA, SE UNE LA TABLA DE PRODUCTOS CON LA DE CATEGORIAS PARA OBTENER EL NOMBRE DE LA CATEGORIA
                //SI ESTA EN FALSE NO SE MUESTRA EN LA CONSULTA, SOLO LOS QUE ESTAN EN TRUE

                using var reader = cmd.ExecuteReader();//EJECUTA LA CONSULTA Y OBTIENE UN READER PARA LEER LOS RESULTADOS

                var lista_producto = new List<Producto>();//CREA UNA LISTA PARA ALMACENAR LOS PRODUCTOS OBTENIDOS DE LA CONSULTA


                while (reader.Read()) //LEE CADA REGISTRO OBTENIDO DE LA CONSULTA Y LO AGREGA A LA LISTA DE PRODUCTOS UNO POR UNO, SE OBTIENEN LOS CAMPOS DE LA CONSULTA Y SE ASIGNAN A LAS PROPIEDADES DEL OBJETO PRODUCTO
                {
                    lista_producto.Add(new Producto
                    {
                        IdProducto = reader.GetString(0), //EL ID DEL PRODUCTO SE OBTIENE DEL PRIMER CAMPO DE LA CONSULTA (INDEX 0)
                        Nombre = reader.GetString(1), //EL NOMBRE DEL PRODUCTO SE OBTIENE DEL SEGUNDO CAMPO DE LA CONSULTA (INDEX 1)
                        Cantidad = reader.GetDecimal(2), //LA CANTIDAD DEL PRODUCTO SE OBTIENE DEL TERCER CAMPO DE LA CONSULTA (INDEX 2)
                        Precio = reader.GetDecimal(3), //EL PRECIO DEL PRODUCTO SE OBTIENE DEL CUARTO CAMPO DE LA CONSULTA (INDEX 3)
                        Estado = reader.GetBoolean(4), //EL ESTADO DEL PRODUCTO SE OBTIENE DEL QUINTO CAMPO DE LA CONSULTA (INDEX 4), SI ESTA EN TRUE SE MUESTRA EN LA CONSULTA, SI ESTA EN FALSE NO SE MUESTRA 
                        IdCategoria = reader.GetString(5) //EL NOMBRE DE LA CATEGORIA SE OBTIENE
                    });

                }
                return lista_producto; // RETORNA LA LISTA DE PRODUCTOS OBTENIDOS DE LA CONSULTA
            }
            catch (PostgresException e) //SI OCURRE UN ERROR DE POSTGRESQL, SE CAPTURA LA EXCEPCION Y SE ASIGNA UN MENSAJE DE ERROR GENERICO A LA VARIABLE errorMessage, Y SE RETORNA UNA LISTA VACIA DE PRODUCTOS
            {
                errorMessage = "Error inesperado"; //SE ASIGNA UN MENSAJE DE ERROR GENERICO A LA VARIABLE errorMessage, SE PODRIA MEJORAR ESTE MENSAJE PARA QUE SEA MAS ESPECIFICO DEPENDIENDO DEL CODIGO DE ERROR DE POSTGRESQL
                return new List<Producto>(); //SE RETORNA UNA LISTA VACIA DE PRODUCTOS, SE PODRIA RETORNAR NULL O UNA EXCEPCION PERSONALIZADA DEPENDIENDO DE LA LOGICA DE NEGOCIO DE LA APLICACION
            }
            catch (Exception e) //SI OCURRE CUALQUIER OTRO TIPO DE EXCEPCION, SE CAPTURA Y SE ASIGNA UN MENSAJE DE ERROR GENERICO A LA VARIABLE errorMessage, Y SE RETORNA UNA LISTA VACIA DE PRODUCTOS
            {
                errorMessage = "Error inesperado"; //SE ASIGNA UN MENSAJE DE ERROR GENERICO A LA VARIABLE errorMessage, SE PODRIA MEJORAR ESTE MENSAJE PARA QUE SEA MAS ESPECIFICO DEPENDIENDO DEL CODIGO DE ERROR DE POSTGRESQL
                return new List<Producto>(); //SE RETORNA UNA LISTA VACIA DE PRODUCTOS, SE PODRIA RETORNAR NULL O UNA EXCEPCION PERSONALIZADA DEPENDIENDO DE LA LOGICA DE NEGOCIO DE LA APLICACION
            }

        
        }
    }
}
