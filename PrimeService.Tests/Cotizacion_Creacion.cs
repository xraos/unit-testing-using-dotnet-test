using Xunit;
using Prime.Services;
using Cotizaciones.Models;

namespace Prime.UnitTests.Services
{
    public class Cotizacion_Creacion
    {
        
        private readonly Persona _persona;
        private readonly Cotizacion _cotizacion;

        public Cotizacion_Creacion()
        {
            _persona = new Persona();
            _persona.Nombre = "Rodrigo";
            _persona.Paterno = "Oyarzun";
            _persona.Materno = "Saire";
            _persona.Rut = "176549661";
            _persona.PersonaId = 001;
            _cotizacion = new Cotizacion();
        }

        [Fact]
        public void CrearCotizacion()
        {
            _cotizacion.Nombre ="Cotizacion 1";
            _cotizacion.Fecha ="3 de enero 2018";
            _cotizacion.Servicios ="Diseño, Marketing, Grabacion, Espectaculo";
            _cotizacion.ValorCotizado = 100000;
            _cotizacion.Descripcion = "Cotizacion 1";
            _cotizacion.Rut = 17654966;
            _cotizacion.Persona = this._persona;

        }
    }
}