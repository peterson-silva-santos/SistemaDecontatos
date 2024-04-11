using Moq;
using SistemaDecontatos.Models;
using SistemaDecontatos.Repositorios;

namespace TestDoCliente
{
    public class UnitTest1
    {
        private readonly Mock<ICliente> _mock= new Mock<ICliente>();
        [Fact]
        public async void Test1()
        {
            ClienteModel novoCliente = new ClienteModel
            {
                Nome = "João",
                Telefone = "123456789",
                Valor = "1000",
                CPF = "123.456.789-00"
            };

            //_mock.Setup(x => x.Cadastra(It.IsAny<ClienteModel>())).ReturnsAsync(true);
            var reposi= _mock.Object;
            var resp = await reposi.Cadastra(novoCliente);


            Assert.True(resp);

        }
    }
}