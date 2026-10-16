using SistemaGimnasio.Modelos;
using SistemaGimnasio.Servicios;
using SistemaGimnasio.Gestores;

GestorEntrenadores gestorEntrenador = new GestorEntrenadores();
GestorUsuarios gestorUsuarios = new GestorUsuarios();
GestorRutinas gestorRutinas = new GestorRutinas();

Console.WriteLine("Sistema de gestion de gimnasio");
Console.WriteLine("Nombre del usuario:");
string usuario = Console.ReadLine()??"";
Console.WriteLine("Edad del usuario");
int edad = int.Parse(Console.ReadLine()??"");