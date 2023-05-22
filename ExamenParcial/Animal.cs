using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenParcial
{
    public class Animal
    {
        string nombrePropio;
        string especie;
        string tipoDeAlimentación;
        float tiempoMaximoDeVida;

        public string NombrePropio { get => nombrePropio; set => nombrePropio = value; }
        public string Especie { get => especie; set => especie = value; }
        public string TipoDeAlimentación { get => tipoDeAlimentación; set => tipoDeAlimentación = value; }
        public float TiempoMaximoDeVida { get => tiempoMaximoDeVida; set => tiempoMaximoDeVida = value; }
    }
}