﻿namespace DesignPattern.Adapter
{
    public class Personagem : IAcao
    {
        public string Andar(string jogador)
        {
            return $"{jogador} andou para frente";
        }

        public string Atirar()
        {
            return "Atirou no jogo";
        }
    }
}
