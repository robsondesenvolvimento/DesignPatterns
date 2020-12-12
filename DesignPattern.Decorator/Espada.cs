using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
    public class Espada : DecoratorArmadura
    {
        private MoldeArmadura _moldeArmadura;

        public Espada(MoldeArmadura moldeArmadura)
        {
            _moldeArmadura = moldeArmadura;
        }

        public override string Descricao
        {
            get
            {
                return $"{_moldeArmadura.Descricao}Espada Ultra Forte, ";
            }
        }
    }
}
