using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenParcial
{
    public class Aves : Animal
    {
        string siVuelaONoVuela;
        float periodoDeIncubacion;
        List<Animal> animales;

        public string SiVuelaONoVuela { get => siVuelaONoVuela; set => siVuelaONoVuela = value; }
        public float PeriodoDeIncubacion { get => periodoDeIncubacion; set => periodoDeIncubacion = value; }
        public List<Animal> Animales { get => animales; set => animales = value; }

        public Aves()
        {
            Animales = new List<Animal>();
        }
    }
}