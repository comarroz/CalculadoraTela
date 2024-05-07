using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraTela
{
    public partial class Form1 : Form
    {
        Model modelo;
        public Form1()
        {
            InitializeComponent();
            modelo = new Model();

        }//fim do contrutor 

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Nmero1_TextChanged(object sender, EventArgs e)
        {

        }//fim do input de numeroUm

        private void Numero2_TextChanged(object sender, EventArgs e)
        {

        }//fim do input numeroDois

        private void Somar_Click(object sender, EventArgs e)

        {
            if(Nmero1.Text =="" || Numero2.Text == "")
            {
                Resultado.Text = "Preencha os campos numéricos";
            }
            else
            {
                int num1 = Convert.ToInt32(Nmero1.Text);
                int num2 = Convert.ToInt32(Numero2.Text);
                Resultado.Text = "" + modelo.Somar(num1, num2);

            }
          

        }// fim do imput Somar

        private void Subtrair_Click(object sender, EventArgs e)
        {

            if (Nmero1.Text == "" || Numero2.Text == "")
            {
                Resultado.Text = "Preencha os campos numéricos";
            }
            else
            {
                int num1 = Convert.ToInt32(Nmero1.Text);
                int num2 = Convert.ToInt32(Numero2.Text);
                Resultado.Text = "" + modelo.Subtrair(num1, num2);


            }
          



        }//fim do input Subtrair

        private void Dividir_Click(object sender, EventArgs e)
        {
            if (Nmero1.Text == "" || Numero2.Text == "")
            {
                Resultado.Text = "Preencha os campos numéricos";
            }
            else
            {

                int num1 = Convert.ToInt32(Nmero1.Text);
                int num2 = Convert.ToInt32(Numero2.Text);
                if (modelo.Dividir(num1, num2) == -1)
                {
                    Resultado.Text = "Impossivél Dividir";
                }
                else
                {
                    Resultado.Text = "" + modelo.Dividir(num1, num2);
                }

            }
        }//fim do input Dividir 

        private void Multiplicar_Click(object sender, EventArgs e)
        {
            if (Nmero1.Text == "" || Numero2.Text == "")
            {
                Resultado.Text = "Preencha os campos numéricos";
            }
            else
            {
                int num1 = Convert.ToInt32(Nmero1.Text);
                int num2 = Convert.ToInt32(Numero2.Text);
                Resultado.Text = "" + modelo.Multiplicar(num1, num2);
            }
        }//fim di input Multiplicar 

        private void Limpar_Click(object sender, EventArgs e)
        {
            if (Nmero1.Text == "" || Numero2.Text == "")
            {
                Resultado.Text = "Preencha os campos numéricos";
            }
            else
            {
                Nmero1.Text = "";
                Numero2.Text = "";
                Resultado.Text = "";
            }

        }//Fim do input Limpar

        private void Resultado_TextChanged(object sender, EventArgs e)
        {

        }// fim do input resultado
    }//fim da Classe
}//fim do projeto
