using System;

namespace DesignPattern.AbstractFactory
{
    public class FabricaBaseZerg : IFabricaBases
    {
        public string CriarBase()
        {
            RevestimentoBaseZerg revestimentoBaseZerg = new RevestimentoBaseZerg();
            var revestimento = revestimentoBaseZerg.Composicao();

            EnergiaBaseZerg energiaBaseZerg = new EnergiaBaseZerg();
            var energia = energiaBaseZerg.Composicao();

            if (revestimento == "Base revestida pela cor vermelha" && energia == "Energia de sustentasão da base pela terra")
                return "Base zerg criada com sucesso";
            else
                return String.Empty;
        }
    }
}
