using Xunit;
using Prime.Services;
using Cotizaciones.Models;

namespace Prime.UnitTests.Services
{
    ///Clase donde se testeara los metodos de la clase Persona
    public class Cotizacion_Creacion
    {
        ///se crea el objeto cotizacion y persona que estara enlazada a la cotizacion
        /// readonly equivale a final en java
        private readonly Persona _persona;
        private readonly Cotizacion _cotizacion;

        /// se le asigna un objeto persona para cotizacion
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

        
        /// se testea que el nombre de la cotizacion y su descripcion sea nulo, vacio un string
        /// todo esto se puede lograr a travez del metodo "Theory"
        [Theory]
        [InlineData(null)]
        [InlineData("cotizacion")] 
        [InlineData()]
        public void CrearCotizacion(string value)
        {
            _cotizacion.Nombre = value;
            _cotizacion.Fecha ="3 de enero 2018";
            _cotizacion.Servicios ="Diseño, Marketing, Grabacion, Espectaculo";
            _cotizacion.ValorCotizado = 100000;
            _cotizacion.Descripcion = value;
            _cotizacion.Rut = 17654966;
            _cotizacion.Persona = this._persona;

        }
    }
}