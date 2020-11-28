namespace DesignPattern.Builder
{
    public class CriadorDeInfantariaLeve : CriadorDeSaldado
    {
        public CriadorDeInfantariaLeve()
        {
            _soldado = new SoldadoDeInfantariaLeve();
        }

        public override void Arma()
        {
            _soldado.EscolherArma("Ataque aereo");
        }

        public override void Foco()
        {
            _soldado.EscolherFoco("Resposta rapida aerea");
        }

        public override void Transporte()
        {
            _soldado.EscolherTransporte("Helicoptero de ataque do Exercito");
        }
    }
}
