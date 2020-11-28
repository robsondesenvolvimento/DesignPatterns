using DesignPattern.Builder;
using Xunit;
using Soldado = DesignPattern.Builder;

namespace DesignPattern.Testes
{
    public class BuilderTeste
    {
        [Fact]
        public void CriarSoldado()
        {
            var exercito = new Soldado.Exercito();
            Soldado.Soldado soldado;
            Soldado.CriadorDeSaldado criadorDeSaldado;

            criadorDeSaldado = new CriadorForcasEspeciais();
            exercito.ConstruirSoldado(criadorDeSaldado);
            soldado = criadorDeSaldado.ObterSoldado();

            Assert.Equal("Fuzil", soldado.Arma);
            Assert.Equal("Carro de operações especiais", soldado.Transporte);
            Assert.Equal("Combate em solo", soldado.Foco);


            criadorDeSaldado = new CriadorDeInfantariaLeve();
            exercito.ConstruirSoldado(criadorDeSaldado);
            soldado = criadorDeSaldado.ObterSoldado();

            Assert.Equal("Ataque aereo", soldado.Arma);
            Assert.Equal("Helicoptero de ataque do Exercito", soldado.Transporte);
            Assert.Equal("Resposta rapida aerea", soldado.Foco);


        }
    }
}
