using FinancialWeb.Api.Controllers;
using FinancialWeb.Api.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace FinancialWeb.Test
{
    public class UsuariosController_Test
    {
        [Fact]
        public async void GerarListaUsuarios_Falha()
        {
            //Padr�o AAA:
            //Arrange
            //Act
            var usuarioController = new UsuariosController();                       
            Func<Task> act = () => usuarioController.GerarListaAsync();

            //Assert
            await Assert.ThrowsAsync<NullReferenceException>(act);

        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public  void GerarListaUsuarios_Sucesso()
        {
            //Padr�o AAA:
            //Arrange

            //Act
            var usuarioController = new UsuariosController();
            var lista =  usuarioController.GerarListaAsync().IsCompleted;
            
            //Assert
            Assert.True(lista);
        }

        //[Theory]
        //public void Test2()
        //{
        //    //Padr�o AAA:

        //    //Arrange

        //    //Act

        //    //Assert

        //}
    }
}
