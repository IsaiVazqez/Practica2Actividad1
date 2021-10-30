using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Resistencias.Services
{
    public class Colores
    {
        public string CalcularResistencia(string bandita1, string bandita2, string bandita3, string bandita4)
        {
            bandita1 = bandita1.ToLower();
            bandita2 = bandita2.ToLower();
            bandita3 = bandita3.ToLower();
            bandita4 = bandita4.ToLower();

            double valorBandita1 = 0;
            double valorBandita2 = 0;
            double valorBandita3 = 0;
            double valorBandita4 = 0;
            double tole = 0;
            double tolePorcentaje = 0;

            switch (bandita1)
            {
                case "negro":
                    valorBandita1 = 0;
                    break;
                case "cafe":
                    valorBandita1 = 1;
                    break;
                case "rojo":
                    valorBandita1 = 2;
                    break;
                case "naranja":
                    valorBandita1 = 3;
                    break;
                case "amarillo":
                    valorBandita1 = 4;
                    break;
                case "verde":
                    valorBandita1 = 5;
                    break;
                case "azul":
                    valorBandita1 = 6;
                    break;
                case "violeta":
                    valorBandita1 = 7;
                    break;
                case "gris":
                    valorBandita1 = 8;
                    break;
                case "blanco":
                    valorBandita1 = 9;
                    break;
            }
            switch (bandita2)
            {
                case "negro":
                    valorBandita2 = 0;
                    break;
                case "cafe":
                    valorBandita2 = 1;
                    break;
                case "rojo":
                    valorBandita2 = 2;
                    break;
                case "naranja":
                    valorBandita2 = 3;
                    break;
                case "amarillo":
                    valorBandita2 = 4;
                    break;
                case "verde":
                    valorBandita2 = 5;
                    break;
                case "azul":
                    valorBandita2 = 6;
                    break;
                case "violeta":
                    valorBandita2 = 7;
                    break;
                case "gris":
                    valorBandita2 = 8;
                    break;
                case "blanco":
                    valorBandita2 = 9;
                    break;
            }
            switch (bandita3)
            {
                case "negro":
                    valorBandita3 = 1;
                    break;
                case "cafe":
                    valorBandita3 = 10;
                    break;
                case "rojo":
                    valorBandita3 = 100;
                    break;
                case "naranja":
                    valorBandita3 = 1000;
                    break;
                case "amarillo":
                    valorBandita3 = 10000;
                    break;
                case "verde":
                    valorBandita3 = 100000;
                    break;
                case "azul":
                    valorBandita3 = 1000000;
                    break;
                case "violeta":
                    valorBandita3 = 10000000;
                    break;
                case "gris":
                    valorBandita3 = 100000000;
                    break;
                case "blanco":
                    valorBandita3 = 1000000000;
                    break;
            }

            switch (bandita4)
            {
                case "rojo":
                    valorBandita4 = 2;
                    tole = 0.2;
                    tolePorcentaje = 2;
                    break;
                case "dorado":
                    valorBandita4 = 5;
                    tole = 0.5;
                    tolePorcentaje = 5;
                    break;
                case "plata":
                    valorBandita4 = 10;
                    tole = .10;
                    tolePorcentaje = 10;
                    break;
            }

            double resistencia = (double.Parse(valorBandita1.ToString() + valorBandita2.ToString())) * valorBandita3;
            double valorTolerancia = resistencia * tole;

            string resultado = $"Colores ingresados: {bandita1}, {bandita2}, {bandita3}, {bandita4}. Resistencia: {resistencia} ohmios. Tolerancia de {tolePorcentaje}%: {valorTolerancia} ohmios";

            return resultado;
        }
    }
}
