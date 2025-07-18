using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PruebaSD.Datos;
using PruebaSD.Entidades;

namespace PruebaSD.Negocio
{
    public class UsuarioService
    {
        private readonly UsuarioRepository _repo;

        public UsuarioService(string connectionString)
        {
            _repo = new UsuarioRepository(connectionString);
        }

        public List<Usuario> ListarUsuarios()
        {
            return _repo.ObtenerUsuarios();
        }
    }
}
