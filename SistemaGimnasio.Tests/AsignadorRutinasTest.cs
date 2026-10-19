using Xunit;
using SistemaGimnasio.Modelos;
using SistemaGimnasio.Servicios;

namespace SistemaGimnasio.Tests
{
    public class AsignadorRutinasTest
    {
        [Fact]
        public void AsignarRutinaAUsuario_DebeAsignarCorrectamente()
        {
            //Arrange
            var usuario = new Usuario("Gael", 20, "Definir");
            var rutina = new Rutina("YoPuedo", 120);
            var asignador = new AsignadorRutinas();

            //Act
            asignador.AsignarRutinaUsuario(usuario, rutina);

            //Assert
            Assert.Equal(rutina, usuario.RutinaAsignada);
        }

        [Fact]
        public void AsignarUsuarioAEntrenador_DebeIncluirUsuario()
        {
            //Arrange
            var usuario = new Usuario("Gael", 20, "Definir");
            var entrenador = new Entrenador("Pepe", "LicuadosProteicos");
            var asignador = new AsignadorRutinas();

            //Act
            asignador.AsignarUsuarioAEntrenador(usuario, entrenador);

            //Assert
            Assert.Contains(usuario, entrenador.ObtenerUsuariosAsignados());
        }
    }
}
