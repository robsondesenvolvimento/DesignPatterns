using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Design = DesignPattern.Decorator;

namespace DesignPattern.Testes
{
    public class DecoratorTeste
    {
        [Fact]
        public void CriarArmaduraESeusItens()
        {
            Design.MoldeArmadura armadura = new Design.ArmaduraPadrao();
            Assert.Equal("Proteção simples, ", armadura.Descricao);

            armadura = new Design.Capacete(armadura);
            armadura = new Design.Espada(armadura);

            Assert.Equal("Proteção simples, Capacete, Espada Ultra Forte, ", armadura.Descricao);
        }
    }
}
