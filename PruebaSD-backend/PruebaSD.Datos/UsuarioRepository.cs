using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PruebaSD.Entidades;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace PruebaSD.Datos
{
    public class UsuarioRepository
    {
        private readonly string _connectionString;

        public UsuarioRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Usuario> ObtenerUsuarios()
        {
            var lista = new List<Usuario>();

            using var conn = new SqlConnection(_connectionString);
            conn.Open();

            var cmd = new SqlCommand("SELECT usuID, nombre, apellido FROM Usuario", conn);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new Usuario
                {
                    usuID = reader.GetDecimal(0),
                    nombre = reader.IsDBNull(1) ? null : reader.GetString(1),
                    apellido = reader.IsDBNull(2) ? null : reader.GetString(2)
                });
            }

            return lista;
        }
    }
}