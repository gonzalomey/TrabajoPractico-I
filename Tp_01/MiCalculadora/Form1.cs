using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnConvBin.Enabled = false;
            btnConvDec.Enabled = false;
        }

        private void BtnOperar_Click(object sender, EventArgs e)
        {
            lblResult.Text = (Form1.Operar(txtNum1.Text, txtNum2.Text, cmbSigno.Text).ToString());
            btnConvBin.Enabled = true;
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }  

        private void BtnConvBin_Click(object sender, EventArgs e)
        {
            string resultado;

            resultado = Numero.DecimalBinario(lblResult.Text);

            if (resultado == "")
            {
                resultado = "Valor invalido";
                btnConvDec.Enabled = false;//Cancelo las opciones convertir
                btnConvBin.Enabled = false;
            }

            if (resultado == "Valor inválido")
            {
                resultado = "Valor invalido";
                btnConvDec.Enabled = false;//Cancelo las opciones convertir
                btnConvBin.Enabled = false;
            }

            btnConvDec.Enabled = true;
            btnConvBin.Enabled = false;

            lblResult.Text = resultado;
        }

        private void BtnConvDec_Click(object sender, EventArgs e)
        {
            string resultado;

            if (lblResult.Text == "Valor invalido")
            {
                btnConvBin.Enabled = false;
                lblResult.Text = "Valor invalido";
                btnConvDec.Enabled = false;
            }

            else
            {
                resultado = Numero.BinarioDecimal(lblResult.Text);
                lblResult.Text = resultado;
                btnConvDec.Enabled = false;
                btnConvBin.Enabled = true;
            }
        }
        
        #region "Metodos"
        private static double Operar(string numero1, string numero2 , string operador)
        {
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);
            return Calculadora.Operar(num1, num2, operador);
        }

        private void Limpiar()
        {

            txtNum1.Clear();
            txtNum2.Clear();
            cmbSigno.ResetText();
            lblResult.ResetText();
            btnConvBin.Enabled = false;
            btnConvDec.Enabled = false;
        }
        #endregion
    }
}
