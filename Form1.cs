using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_C
{
    public partial class Form1 : Form
    {
        private double valor1;
        private double valor2;
        private double resultado;
        private int operacion;
        public Form1()
        {
            InitializeComponent();
        }

        private void Num0_Click(object sender, EventArgs e)
        {
            Texto.Text = Texto.Text + "0";
        }

        private void Num1_Click(object sender, EventArgs e)
        {
            Texto.Text = Texto.Text + "1";
        }

        private void Num2_Click(object sender, EventArgs e)
        {
            Texto.Text = Texto.Text + "2";
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            Texto.Text = Texto.Text + "3";
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            Texto.Text = Texto.Text + "4";
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            Texto.Text = Texto.Text + "5";
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            Texto.Text = Texto.Text + "6";
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            Texto.Text = Texto.Text + "7";
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            Texto.Text = Texto.Text + "8";
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            Texto.Text = Texto.Text + "9";
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            Texto.Text = "";
        }

        private void Igual_Click(object sender, EventArgs e)
        {
            valor2 = Convert.ToDouble(Texto.Text);

            switch (operacion)
            {
                case 1:
                    resultado = valor1 + valor2;
                    break;
                case 2:
                    resultado = valor1 - valor2;
                    break;
                case 3:
                    resultado = valor1 * valor2;
                    break;
                case 4:
                    resultado = valor1 / valor2;
                    break;
            }

            Texto.Text = resultado.ToString();

        }

        private void Suma_Click(object sender, EventArgs e)
        {
            operacion = 1;
            valor1 = Convert.ToDouble(Texto.Text);
            Texto.Text = "";
        }

        private void Resta_Click(object sender, EventArgs e)
        {
            operacion = 2;
            valor1 = Convert.ToDouble(Texto.Text);
            Texto.Text = "";
        }

        private void Multiplicacion_Click(object sender, EventArgs e)
        {
            operacion = 3;
            valor1 = Convert.ToDouble(Texto.Text);
            Texto.Text = "";
        }

        private void Division_Click(object sender, EventArgs e)
        {
            operacion = 4;
            valor1 = Convert.ToDouble(Texto.Text);
            Texto.Text = "";
        }

        private void Punto_Click(object sender, EventArgs e)
        {
            Texto.Text = Texto.Text + ".";
        }
    }
}
