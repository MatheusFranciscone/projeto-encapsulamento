using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_encapsulamento
{
    class Calculo
    {
        private double porcentagem1 = 5; //variavel decladara privada para não se alterar
        private double porcentagem2 = 10; 
        private double porcentagem3 = 20;
        private double porcentagem4 = 25;
        private double porcentagem5 = 30;


        //metodo publico com retorno e dois parametros
        public double CalculaPrecoFinal(double precoInicial, double tipoProduto)
        {
            double precoFinal = 0;
            switch (tipoProduto)
            {
                case 1:
                    precoFinal = precoInicial + ((precoInicial) * (porcentagem1 / 100));
                    break;

                case 2:
                    precoFinal = precoInicial + ((precoInicial) * (porcentagem2 / 100));
                    break;

                case 3:
                    precoFinal = precoInicial + ((precoInicial) * (porcentagem3 / 100));
                    break;

                case 4:
                    precoFinal = precoInicial + ((precoInicial) * (porcentagem4 / 100));
                    break;

                case 5:
                    precoFinal = precoInicial + ((precoInicial) * (porcentagem5 / 100));
                    break;
            }

            return precoFinal;
        }

    }
}
