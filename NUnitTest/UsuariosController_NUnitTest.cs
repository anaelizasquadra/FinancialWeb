using FinancialWeb.Api;
using FinancialWeb.Api.Controllers;
using FinancialWeb.Api.Models;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System.Collections.Generic;

namespace FinancialWeb.NUnitTest
{
    [TestFixture]
    public class UsuariosController_NUnitTest
    {
        private UsuariosController usuariosController;

        private readonly FinancialContext _context;

        [SetUp]
        public void Setup()
        {
            usuariosController = new UsuariosController(_context);
        }

        [TestCase(1)]
        public void GetUsuarioById_Passe(int id)
        {
            //Padrão AAA:
            //Arrange
            var resultado = usuariosController.GetUsuario(id).GetAwaiter().GetResult();

            //Act
            var nome = resultado.Value.NomeCompleto;

            //Assert
            Assert.IsTrue(nome.Length > 0);
        }

        [Test]
        public void GetUsuarios()
        {
            //Padrão AAA:
            //Arrange
            var resultado = usuariosController.GetUsuario().Result;
            //Act
            var nome = resultado.Result.;

            //Assert
            Assert.IsTrue(nome.Length > 0);
        }
    }
}