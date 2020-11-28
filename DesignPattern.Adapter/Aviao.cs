﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Adapter
{
    public class Aviao
    {
        public string Voar(string personagem)
        {
            return $"{personagem} voou para frente";
        }

        public string SoltouMissil()
        {
            return "Soltou um missil no jogo";
        }
    }
}
