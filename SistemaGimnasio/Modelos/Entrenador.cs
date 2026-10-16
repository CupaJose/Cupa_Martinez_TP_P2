namespace SistemaGimnasio.Modelos
{
    public class Entrenador
    {
        public string Nombre { get; set; }
        public string Especialidad { get; set; }
        private List<Usuario> _usuariosAsignados;

        public Entrenador (string nombre, string especialidad)
        {
            Nombre = nombre;
            Especialidad = especialidad;
            _usuariosAsignados = new List<Usuario> ();
        }

        public void AsignarUsuario(Usuario usuario)
        {
            _usuariosAsignados.Add(usuario);
        }

        public List<Usuario> ObtenerUsuariosAsignados()
        {
            return _usuariosAsignados;
        }
    }
}
