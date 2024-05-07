using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTela
{
     class Model
    {
        public  Model()
        {

        }//fim do contrutor 

        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }//Fim do somar

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }//Fim do Subtrair 

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }//Fim do Multipliocar 

        public int Dividir(int num1, int num2)
        {
            if (num2 == 0)
            {
                return -1;
            }
            else
            {
                return num1/ num2;

            }//Fim do Dividir

        }//Fim do Multipliocar 
    }//Fim da Classe
}//Fim do proje
