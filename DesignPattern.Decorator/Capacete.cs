using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
    public class Capacete : DecoratorArmadura
    {
        private MoldeArmadura _moldeArmadura;

        public Capacete(MoldeArmadura moldeArmadura)
        {
            _moldeArmadura = moldeArmadura;
        }

        public override string Descricao
        {
            get
            {
                return $"{_moldeArmadura.Descricao}Capacete, ";
            }
        }
    }
}
