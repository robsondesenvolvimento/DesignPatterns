using Xunit;
using Factory = DesignPattern.FactoryMethod;

namespace DesignPattern.Testes
{
    public class FactoryMethodTeste
    {
        [Theory]
        [InlineData("Liu Kang")]
        [InlineData("Scorpion")]
        [InlineData("SubZero")]
        public void CriarPersonagens(string nomePersonagem)
        {
            Factory.FactoryMethod factoryMethod = new Factory.FactoryMethod();
            Factory.IPersonagem personagem = factoryMethod.EscoherPersonagem(nomePersonagem);
            Assert.Equal(nomePersonagem, personagem.Escolhido());
        }
    }
}
