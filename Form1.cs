using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Aula2
{
    public partial class CALCULADORA : Form
    {
        string operacao = "";
        string numeroUm = "", numeroDois = "";
        double resultado, num1, num2;
        bool result = false;
        public CALCULADORA()
        {
            InitializeComponent();
        }
        private void Numeros_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (result == false)
            {
                if (btn.Text == "0" && txt_tela.Text == "")
                {
                    txt_tela.Text = "";
                }
                else
                {
                    if (btn.Text == "." && txt_tela.Text == "")
                    {
                       
                        txt_tela.Text = "0.";
                    }
                    if(btn.Text != ".")
                    txt_tela.Text += btn.Text;
                }
            }
            else
            {
                txt_tela.Clear();
                //calculo.Text = "";
                txt_tela.Text += btn.Text;
                result = false;
            }
        }
        private void Btn_limpar_Click(object sender, EventArgs e)
        {
            txt_tela.Clear();
            calculo.Text = "";
            numeroUm = "";
            numeroDois = "";
        }
        private void Operacao_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            operacao = btn.Text;
            if (numeroUm == "")
            {
                numeroUm = txt_tela.Text;
                calculo.Text = numeroUm + operacao;
                txt_tela.Text = "";
            }
            else
            {
                numeroDois = txt_tela.Text;
                calculo.Text = numeroUm + operacao + numeroDois + "=";
                Calculo_Resultado(numeroUm,numeroDois);
                txt_tela.Text = resultado.ToString("###,###,###"); 
            }
        }
        private void Btn_igual_Click(object sender, EventArgs e)
        {
            Calculo_Resultado(numeroUm, numeroDois);
        }
        private void Calculo_Resultado(string NumeroUm,string NumeroDois)
        {
            if (numeroUm != "")
            {
                numeroDois = txt_tela.Text;
                txt_tela.Text = "";
            }
            if (numeroUm != "" && numeroDois != "")
            {
                num1 = double.Parse(numeroUm);
                num2 = double.Parse(numeroDois);
            }
            else
            {
                txt_tela.Text = "";
            }
            switch (operacao)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "x":
                    resultado = num1 * num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;
            }
            calculo.Text = numeroUm + operacao + numeroDois + "=";
            txt_tela.Text = resultado.ToString("###,###,###");
            result = true;
            numeroUm = "";
            numeroDois = "";
        }
    }
}
