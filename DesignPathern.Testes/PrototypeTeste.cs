using DesignPattern.Prototype;
using Xunit;

namespace DesignPattern.Testes
{
    public class PrototypeTeste
    {
        [Fact]
        public void CriandoPrototipo()
        {
            GerenciadorNuvens gerenciadorNuvens = new GerenciadorNuvens();

            gerenciadorNuvens["padrão"] = new NuvemConcreta("branco", "azul");
            gerenciadorNuvens["personalizada"] = new NuvemConcreta("branco", "laranja");

            var um = gerenciadorNuvens["padrão"].Clone() as NuvemConcreta;
            Assert.Equal("branco", um.CorPreenchimento);
            Assert.Equal("azul", um.CorContorno);

            var dois = gerenciadorNuvens["padrão"].Clone() as NuvemConcreta;
            Assert.Equal("branco", dois.CorPreenchimento);
            Assert.Equal("azul", dois.CorContorno);

            var tres = gerenciadorNuvens["personalizada"].Clone() as NuvemConcreta;
            Assert.Equal("branco", tres.CorPreenchimento);
            Assert.Equal("laranja", tres.CorContorno);
        }
    }
}
