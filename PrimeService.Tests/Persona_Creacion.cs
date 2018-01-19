using Xunit;
using Prime.Services;
using Cotizaciones.Models;
///Clase donde se testeara los metodos de la clase Persona
namespace Prime.UnitTests.Services
{
    public class Persona_Creacion
    {
        ///se crea el objeto persona, readonly equivale a final en java
        private readonly Persona _persona;

        public Persona_Creacion()
        {
            _persona = new Persona();
        }

        /// se testea multiples valores para que el rut sea un string, nulo o vacio
        /// todo esto se puede lograr a travez del metodo "Theory" 
        [Theory]
        [InlineData(null)]
        [InlineData(176549661)]
        [InlineData()]
        public void CrearPersona(string value)
        {
            _persona.Nombre = "Rodrigo";
            _persona.Paterno = "Oyarzun";
            _persona.Materno = "Saire";
            _persona.Rut = value;
            _persona.PersonaId = 001;

            
        }
    }
}