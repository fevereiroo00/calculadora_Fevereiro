using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fevereiro_calculadora
{
    public partial class System_Calculator_Fevereiro : Form
    {
        static double parte1 = 0, parte2, calc, aux = 0;
        public System_Calculator_Fevereiro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            switch (aux)
            {
                case 1:
                    parte2 = Convert.ToDouble(l_resultados.Text);
                    calc = parte1 + parte2;
                    l_resultados.Text = calc.ToString();
                    break;

                case 2:
                    parte2 = Convert.ToDouble(l_resultados.Text);
                    calc = parte1 - parte2;
                    l_resultados.Text = calc.ToString();
                    break;
                case 3:
                    parte2 = Convert.ToDouble(l_resultados.Text);
                    calc = parte1 * parte2;
                    l_resultados.Text = calc.ToString();
                    break;
                case 4:
                    parte2 = Convert.ToDouble(l_resultados.Text);
                    calc = parte1 / parte2;
                    l_resultados.Text = calc.ToString();
                    break;
                default:
                    break;
            }
        }

        private void l_resultados_Click(object sender, EventArgs e)
        {
             
        }

        private void b_0_Click(object sender, EventArgs e)
        {
            l_resultados.Text += 0;
        }

        private void b_1_Click(object sender, EventArgs e)
        {
            l_resultados.Text += 1;
        }

        private void b_2_Click(object sender, EventArgs e)
        {
            l_resultados.Text += 2;
        }

        private void b_3_Click(object sender, EventArgs e)
        {
            l_resultados.Text += 3;
        }

        private void b_4_Click(object sender, EventArgs e)
        {
            l_resultados.Text += 4;
        }

        private void b_5_Click(object sender, EventArgs e)
        {
            l_resultados.Text += 5;
        }

        private void b_6_Click(object sender, EventArgs e)
        {
            l_resultados.Text += 6;
        }

        private void b_7_Click(object sender, EventArgs e)
        {
            l_resultados.Text += 7;
        }

        private void b_8_Click(object sender, EventArgs e)
        {
            l_resultados.Text += 8;
        }

        private void b_dividir_Click(object sender, EventArgs e)
        {
            parte1 = double.Parse(l_resultados.Text);
            l_resultados.Text.ToString();
            l_resultados.Text = "";


            aux = 4;
        }

        private void b_mais_Click(object sender, EventArgs e)
        {
            parte1 = double.Parse(l_resultados.Text);
            l_resultados.Text.ToString();
            l_resultados.Text = "";


            aux = 1;
        }

        private void b_subtrair_Click(object sender, EventArgs e)
        {
            parte1 = double.Parse(l_resultados.Text);
            l_resultados.Text.ToString();
            l_resultados.Text = "";
            aux = 2;
        }

        private void b_expoente_Click(object sender, EventArgs e)
        {
            parte1 = double.Parse(l_resultados.Text);
            l_resultados.Text = Math.Pow(parte1, 2).ToString();
        }

        private void b_raiz_Click(object sender, EventArgs e)
        {
            parte1 = double.Parse(l_resultados.Text);
            calc = (double)Math.Sqrt(parte1);
            l_resultados.Text = calc.ToString();
        }

        private void b_shift_Click(object sender, EventArgs e)
        {

        }

        private void b_on_Click(object sender, EventArgs e)
        {
            
        }

        private void b_virgula_Click(object sender, EventArgs e)
        {
            l_resultados.Text += ",";
        }

        private void b_9_Click(object sender, EventArgs e)
        {
            l_resultados.Text += 9;
        }

        private void b_off_Click(object sender, EventArgs e)
        {
            l_resultados.Text = "";
        }

        private void b_x_Click(object sender, EventArgs e)
        {
            parte1 = double.Parse(l_resultados.Text);
            l_resultados.Text.ToString();
            l_resultados.Text = "";
            aux = 3;
        }
    }
}
