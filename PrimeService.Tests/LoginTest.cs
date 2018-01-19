using Xunit;
using Prime.Services;
using Cotizaciones.Models;
using Cotizaciones.Controllers;
using Cotizaciones.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Moq;

///Clase donde se testeara los metodos del controlador home para el inicio de sesion de usuario
namespace Prime.UnitTests.Services
{
    public class LoginTest
    {
        ///private readonly Usuario _usuario;
        ///private CotizacionesContext _context;
        public LoginTest(){
            
        }

        /// se testea la creacion de un usuario
        [Fact]
        private List<Usuario> GetTestSessions()
        {
            var sessions = new List<Usuario>();
            sessions.Add(new Usuario()
            {
                NombreUsuario = "Rodrigo",
                UsuarioID = 1,
                Password = "12345"
            });
            sessions.Add(new Usuario()
            {
                NombreUsuario = "Alejandro",
                UsuarioID = 2,
                Password = "12345"
            });
            return sessions;
        }

        /// se intenta testear las vistas del homeController
        ///[Fact]
        ///public async Task Index_ReturnsAViewResult_WithAListOfBrainstormSessions()
        ///{
            // Arrange
            
         ///   var controller = new HomeController(this._context);

            // Act
         ///   var result = controller.Index();

            // Assert
        ///    var viewResult = Assert.IsType<ViewResult>(result);
         ///   var model = Assert.IsAssignableFrom<IEnumerable<Cotizaciones.Models.Usuario>>(
        ///        viewResult.ViewData.Model);
        ///    Assert.Equal(2, model.Count());
        ///}
    }    

        
}