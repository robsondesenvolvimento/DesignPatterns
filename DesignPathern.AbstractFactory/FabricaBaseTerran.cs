using System;

namespace DesignPattern.AbstractFactory
{
    public class FabricaBaseTerran : IFabricaBases
    {
        public FabricaBaseTerran()
        {
            CriarBase();
        }

        public string CriarBase()
        {
            RevestimentoBaseTerran revestimentoBaseTerran = new RevestimentoBaseTerran();
            var revestimento = revestimentoBaseTerran.Composicao();

            EnergiaBaseTerran energiaBaseTerran = new EnergiaBaseTerran();
            var energia = energiaBaseTerran.Composicao();

            if (revestimento == "Base revestida pela cor verde" && energia == "Energia de sustentação da base mecânica")
                return "Base Terran criada com sucesso";
            else
                return String.Empty;
        }
    }
}
