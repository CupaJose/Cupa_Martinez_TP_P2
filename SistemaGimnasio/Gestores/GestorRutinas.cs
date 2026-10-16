using SistemaGimnasio.Modelos;

namespace SistemaGimnasio.Gestores
{
    public class GestorRutinas
    {
        private List<Rutina> _rutinas;

        public GestorRutinas()
        {
            _rutinas = new List<Rutina>();
        }
        
        public void CrearRutina(string nombre, int duracion)
        {
            _rutinas.Add(new Rutina(nombre, duracion));
        }

        public Rutina BuscarRutina(string nombre)
        {
            return _rutinas.FirstOrDefault(r => r.Nombre == nombre);
        }
    }
}
