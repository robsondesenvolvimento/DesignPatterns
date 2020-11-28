using System;

namespace DesignPattern.AbstractFactory
{
    public class FabricaBaseProtoss : IFabricaBases
    {
        public string CriarBase()
        {
            RevestimentoBaseProtoss revestimentoBaseProtoss = new RevestimentoBaseProtoss();
            var revestimento = revestimentoBaseProtoss.Composicao();

            EnergiaBaseProtoss energiaBaseProtoss = new EnergiaBaseProtoss();
            var energia = energiaBaseProtoss.Composicao();

            if (revestimento == "Base revestida pela cor amarela" && energia == "Energia de sustentação da base com cristais")
                return "Base protoss criada com sucesso";
            else
                return String.Empty;
        }
    }
}
