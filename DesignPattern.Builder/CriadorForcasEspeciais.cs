namespace DesignPattern.Builder
{
    public class CriadorForcasEspeciais : CriadorDeSaldado
    {
        public CriadorForcasEspeciais()
        {
            _soldado = new SoldadoDeForcasEspeciais();
        }

        public override void Arma()
        {
            _soldado.EscolherArma("Fuzil");
        }

        public override void Foco()
        {
            _soldado.EscolherFoco("Combate em solo");
        }

        public override void Transporte()
        {
            _soldado.EscolherTransporte("Carro de operações especiais");
        }
    }
}
