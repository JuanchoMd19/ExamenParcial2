using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenParcial
{
    public class Serpiente : Animal
    {
        string siEsVenenosaONo;
        string longitudMaxima;
        List<Animal> animales;

        public string SiEsVenenosaONo { get => siEsVenenosaONo; set => siEsVenenosaONo = value; }
        public string LongitudMaxima { get => longitudMaxima; set => longitudMaxima = value; }
        public List<Animal> Animales { get => animales; set => animales = value; }

        public Serpiente()
        {
            Animales = new List<Animal>();
        }
    }
}