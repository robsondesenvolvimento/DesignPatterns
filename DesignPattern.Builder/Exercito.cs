namespace DesignPattern.Builder
{
    public class Exercito
    {
        public void ConstruirSoldado(CriadorDeSaldado criadorDeSaldado)
        {
            criadorDeSaldado.Arma();
            criadorDeSaldado.Transporte();
            criadorDeSaldado.Foco();
        }
    }
}
