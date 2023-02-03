using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteIMC
{
    public static class operacoesIMC
    {
        public static double CalcularIMC(double peso, double altura)
        {
            return Math.Round(peso / (altura * altura), 2);
        }

        public static string ClassificarIMC(double imc)
        {
            if (imc < 18.5)
            {
                return "Abaixo do Peso";
            }

            if (imc < 25)
            {
                return "Peso Normal";
            }

            if (imc < 30)
            {
                return "Sobrepeso";
            }

            if (imc < 35)
            {
                return "Obesidade Grau I";
            }

            if (imc < 40)
            {
                return "Obesidade Grau II";
            }

            return "Obesidade Grau III";
        }
    }
}
