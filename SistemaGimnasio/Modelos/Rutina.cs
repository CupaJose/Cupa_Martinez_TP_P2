namespace SistemaGimnasio.Modelos
{
    public class Rutina
    {
        public string Nombre { get; set; }
        public int Duracion { get; set; }
        private List<Ejercicio> _ejercicios;

        public Rutina(string nombre, int duracion)
        {
            Nombre = nombre;
            Duracion = duracion;
            _ejercicios = new List<Ejercicio>();
        }

        public void AgregarEjercicio(Ejercicio ejercicio)
        {
            _ejercicios.Add(ejercicio);
        }

        public List<Ejercicio> ObtenerEjercicios()
        {
            return _ejercicios;
        }
    }
}
