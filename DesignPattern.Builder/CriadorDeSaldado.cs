namespace DesignPattern.Builder
{
    public abstract class CriadorDeSaldado
    {
        protected Soldado _soldado;

        public Soldado ObterSoldado()
        {
            return _soldado;
        }

        public abstract void Arma();
        public abstract void Transporte();
        public abstract void Foco();

    }
}
