using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Facade
{
    public class Facade
    {
        private SubSistemaUm _subSistemaUm;
        private SubSistemaDois _subSistemaDois;
        private SubSistemaTres _subSistemaTres;

        public Facade()
        {
            _subSistemaUm = new();
            _subSistemaDois = new();
            _subSistemaTres = new();
        }

        public string OperacaoA()
        {
            return $"{_subSistemaUm.Responsabilidade} - {_subSistemaDois.Responsabilidade}";
        }

        public string OperacaoB()
        {
            return $"{_subSistemaTres.Responsabilidade}";
        }
    }
}
