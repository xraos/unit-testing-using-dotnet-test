using Xunit;
using Prime.Services;
using Cotizaciones.Models;

namespace Prime.UnitTests.Services
{
    public class Persona_Creacion
    {
        
        private readonly Persona _persona;

        public Persona_Creacion()
        {
            _persona = new Persona();
        }

        [Fact]
        public void CrearPersona()
        {
            _persona.Nombre = "Rodrigo";
            _persona.Paterno = "Oyarzun";
            _persona.Materno = "Saire";
            _persona.Rut = "176549661";
            _persona.PersonaId = 001;

            
        }
    }
}