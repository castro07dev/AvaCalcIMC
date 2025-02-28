using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void btnResul_Click(object sender, EventArgs e)
        {
            double pesoC = Convert.ToDouble(txtPeso.Text);
            double altura = Convert.ToDouble(txtAltura.Text);
            double resultado = pesoC / (altura * 2);
            txtResult.Text = resultado.ToString();

            //calculos para chegar no resultado do imc

            if (resultado < 19.1)
            {
                lblSituacao.Text = "Abaixo do peso";
            }
            else if ((resultado >= 19.1) && (resultado < 25.8))
            {
                lblSituacao.Text = "Peso ideal";
            }
            else if ((resultado >= 25.8) && (resultado < 32.3))
            {
                lblSituacao.Text = "Acima do peso";
            }
            else 
            {
                lblSituacao.Text = "Obeso";
            }

            //aparece a situação do paciente
        }

      

        private void txtPeso_Enter(object sender, EventArgs e)
        {
            txtPeso.Tag = true;
            txtAltura.Tag = false;
           
            
        }

        private void txtAltura_Enter(object sender, EventArgs e)
        {
           txtAltura.Tag = true;
           txtPeso.Tag = false;
            
        }

        

        private void numeros(object sender, EventArgs e)
        {
            Button numeros = sender as Button;
            
            if (numeros != null)


            }
            else
            {
                txtPeso.Text += numeros.Text;
              
            }
        }


        private void colorReturn(object sender, EventArgs e)
        {
            txtAltura.BackColor = Color.White;
            
        }

        private void colorPeso1(object sender, EventArgs e)
        {
            txtPeso.BackColor = Color.White;
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtPeso.Clear();
            txtAltura.Clear();
        }
    }
}
