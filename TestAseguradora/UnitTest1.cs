using Aseguradora.Context;
using Aseguradora.Controllers;
using Aseguradora.Model;

namespace TestAseguradora
{
    public class UnitTest1
    {
        [Fact]
        public void ObtenerPolizas_Test()
        {
            AseguradoraContext context;

            var poliza = new PolizaController();
             //Arrange
            //List<Poliza> polizas = new List<Poliza>();

            //Act
            var result = poliza.GetPoliza();


            //Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void ObtenerPolizasIdentificacion_Test()
        {
            AseguradoraContext context;

            var poliza = new PolizaController();
            //Arrange
            //List<Poliza> polizas = new List<Poliza>();

            //Act
            var result = poliza.GetPolizaCliente(19876567);


            //Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void ObtenerPolizaNumero_Test()
        {
            AseguradoraContext context;

            var poliza = new PolizaController();
            //Arrange
            //List<Poliza> polizas = new List<Poliza>();

            //Act
            var result = poliza.GetPolizaCliente(2);


            //Assert
            Assert.NotNull(result);
        }
    }
}