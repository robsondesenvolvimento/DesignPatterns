using Xunit;
using Factory = DesignPattern.AbstractFactory;

namespace DesignPattern.Testes
{
    public class AbstractFactoryTeste
    {
        [Theory]
        [InlineData("Protoss", "Base protoss criada com sucesso")]
        [InlineData("Zergs", "Base zerg criada com sucesso")]
        [InlineData("Terranos", "Base Terran criada com sucesso")]
        public void CriarBase(string nomePersonagem, string mensagemRetorno)
        {
            Factory.AbstractFactory abstractFactory = new Factory.AbstractFactory();
            Factory.IFabricaBases fabricaBases = abstractFactory.EscolherPersonagem(nomePersonagem);
            Assert.Equal(mensagemRetorno, fabricaBases.CriarBase());

        }
    }
}
