namespace DesignPattern.AbstractFactory
{
    public class AbstractFactory
    {
        public IFabricaBases EscolherPersonagem(string nomePersonagem)
        {
            switch (nomePersonagem)
            {
                case "Protoss": return new FabricaBaseProtoss();
                case "Zergs": return new FabricaBaseZerg();
                case "Terranos": return new FabricaBaseTerran();
                default: return null;
            }
        }
    }
}
