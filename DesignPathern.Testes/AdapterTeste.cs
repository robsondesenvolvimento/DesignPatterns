using DesignPattern.Adapter;
using Xunit;

namespace DesignPattern.Testes
{
    public class AdapterTeste
    {
        [Fact]
        public void CriarPersonagem()
        {
            Personagem personagem = new Personagem();
            Aviao aviao = new Aviao();

            IAcao adaptador = new AdapterAviao(aviao);

            Assert.Equal("Atirou no jogo", personagem.Atirar());
            Assert.Equal("Robson andou para frente", personagem.Andar("Robson"));

            Assert.Equal("Soltou um missil no jogo", adaptador.Atirar());
            Assert.Equal("Robson voou para frente", adaptador.Andar("Robson"));
        }
    }
}
