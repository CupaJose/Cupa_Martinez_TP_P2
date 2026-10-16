using SistemaGimnasio.Modelos;

namespace SistemaGimnasio.Gestores
{
    public class GestorUsuarios
    {
        private List<Usuario> _usuarios;

        public GestorUsuarios()
        {
            _usuarios = new List<Usuario>();
        }

        public void RegistrarUsuario(string nombre, int edad, string objetivo)
        {
            _usuarios.Add(new Usuario(nombre, edad, objetivo));
        }

        public Usuario BuscarUsuario(string nombre)
        {
            return _usuarios.FirstOrDefault(u => u.Nombre == nombre);
        }
    }
}
