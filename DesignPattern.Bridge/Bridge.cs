namespace DesignPattern.Bridge
{
    public class Bridge
    {
        public IForma FormaSolicitada { get; set; }

        public string ExibeQualFormaEstaDescendoNaTela()
        {
            return FormaSolicitada.Descer();
        }
    }
}
