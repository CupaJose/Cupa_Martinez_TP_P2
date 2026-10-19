using SistemaGimnasio.Modelos;
using SistemaGimnasio.Servicios;
using SistemaGimnasio.Gestores;

GestorEntrenadores gestorEntrenador = new GestorEntrenadores();
GestorUsuarios gestorUsuarios = new GestorUsuarios();
GestorRutinas gestorRutinas = new GestorRutinas();

Console.WriteLine("Sistema de gestion de gimnasio");

//Usuario
Console.WriteLine("Nombre del usuario:");
string nombreUsuario = Console.ReadLine()??"";
Console.WriteLine("Edad del usuario");
int edad = int.Parse(Console.ReadLine()??"");
Console.WriteLine("Ingrese objetivo");
string objetivo = Console.ReadLine() ?? "";
gestorUsuarios.RegistrarUsuario(nombreUsuario, edad, objetivo);
Console.WriteLine("Usuario agregado");

//Entrenador
Console.WriteLine("Nombre del entrenador:");
string nombreEntrenador = Console.ReadLine() ?? "";
Console.WriteLine("Ingrese especialidad");
string especialidad = Console.ReadLine() ?? "";
gestorEntrenador.AgregarEntrenador(nombreEntrenador, especialidad);
Console.WriteLine("Entrenador agregado");

//Asignar usuario a entrenador
AsignadorRutinas asignador = new AsignadorRutinas();
asignador.AsignarUsuarioAEntrenador(gestorUsuarios.BuscarUsuario(nombreUsuario), gestorEntrenador.BuscarEntrenador(nombreEntrenador));

//Rutina
Console.WriteLine("Nombre de la rutina");
string nombreRutina = Console.ReadLine() ?? "";
Console.WriteLine("Duracion");
int duracion = int.Parse(Console.ReadLine() ?? "");
gestorRutinas.CrearRutina(nombreRutina, duracion);
Console.WriteLine("Rutina creada");

//Ejercicios
Console.WriteLine("Cuantos ejercicios tiene la rutina");
for (int i = 0; i < int.Parse(Console.ReadLine()??""); i++)
{
    Console.WriteLine("Nombre del ejercicio");
    string nombreEjercicio = Console.ReadLine() ?? "";
    Console.WriteLine("Repeticiones");
    int repeticiones = int.Parse(Console.ReadLine() ?? "");
    Console.WriteLine("Series");
    int series = int.Parse(Console.ReadLine() ?? "");
    Console.WriteLine("Tiempo de descanso");
    int descanso = int.Parse(Console.ReadLine() ?? "");
    gestorRutinas.BuscarRutina(nombreRutina).AgregarEjercicio(new Ejercicio(nombreEjercicio, repeticiones, series, descanso));
    Console.WriteLine("Ejercicio agregado");
}

//Asignar rutina a usuario
asignador.AsignarRutinaUsuario(gestorUsuarios.BuscarUsuario(nombreUsuario), gestorRutinas.BuscarRutina(nombreRutina));

//Resumen
Console.WriteLine($"El entrenador {gestorEntrenador.BuscarEntrenador(nombreEntrenador).Nombre} tiene como usuarios a:\n" +
    $"{gestorEntrenador.BuscarEntrenador(nombreEntrenador).ObtenerUsuariosAsignados()}");
Console.WriteLine($"El usuario {gestorUsuarios.BuscarUsuario(nombreUsuario).Nombre} tiene la rutina :" +
    $"{gestorUsuarios.BuscarUsuario(nombreUsuario).RutinaAsignada}");
Console.WriteLine($"La rutina {gestorRutinas.BuscarRutina(nombreRutina).Nombre} tiene una duración de: {gestorRutinas.BuscarRutina(nombreRutina).Duracion}");
Console.WriteLine($"Sus ejercicios son {gestorRutinas.BuscarRutina(nombreRutina).ObtenerEjercicios}");