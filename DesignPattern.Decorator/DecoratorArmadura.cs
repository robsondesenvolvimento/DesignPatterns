using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
    public class DecoratorArmadura : MoldeArmadura
    {
        public override string Descricao { get; } = "Decorator Abstrato da Armadura do Personagem";
    }
}
