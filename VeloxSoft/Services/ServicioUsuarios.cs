using Npgsql;
using VeloxSoft.Config;
using VeloxSoft.Models;

namespace VeloxSoft.Services
{
    public class ServicioUsuarios
    {
        private readonly DatabaseConfig _dbConfig;

        public ServicioUsuarios(DatabaseConfig dbConfig)
        {
            _dbConfig = dbConfig;
        }

        public List<Usuario> Ver_Usuarios(out String errorMessage)
        {
            errorMessage = null;
            try
            {
                var conn = new NpgsqlConnection(_dbConfig.GetConnection(Program.RolActual));
                conn.Open();
                using var cmd = new NpgsqlCommand(
                    @"SELECT * FROM tbl_usuario WHERE estado = true", conn);
                using var reader = cmd.ExecuteReader();
                var lista_usuario = new List<Usuario>();
                while (reader.Read()) 
                {
                    lista_usuario.Add(new Usuario
                    {
                        Id = reader.GetInt64(0), 
                        Nombre = reader.GetString(1), 
                        Password = reader.GetString(2), 
                        Rol = reader.GetString(3), 
                        Secion = reader.GetBoolean(4), 
                        Estado = reader.GetBoolean(5) 
                    });

                }
                return lista_usuario;
            }
            catch (Exception ex)
            {
                errorMessage = "Error Inesperado";
                return new List<Usuario>();
            }
        }
    }
}