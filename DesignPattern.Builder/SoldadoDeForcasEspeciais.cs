namespace DesignPattern.Builder
{
    public class SoldadoDeForcasEspeciais : Soldado
    {
        public override void EscolherArma(string arma)
        {
            Arma = arma;
        }

        public override void EscolherFoco(string foco)
        {
            Foco = foco;
        }

        public override void EscolherTransporte(string transporte)
        {
            Transporte = transporte;
        }
    }
}
