using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        enum sistemaNum {Decimal, Binario, Hexa}
        
        public Form1()
        {
            InitializeComponent();
        }

        //Método que hace operaciones
        int Operacion(int a, int b, char operador)
        {
            switch (operador)
            {
                case '+': return a + b;
                case '-': return a - b;
                case 'X': return a * b;
                case '÷': return b != 0 ? a / b : 0;
                case '%': return b != 0 ? a % b : 0;
                case '√': return (int)Math.Sqrt(a + b);

                default: return 0;
            }
        }

        //Método para detectar sistema numérico
        sistemaNum DetectaSistema(string n)
        {
            if(n.StartsWith("0b"))
                return sistemaNum.Binario;
            if(n.StartsWith("0x"))
                return sistemaNum.Hexa;

            //Por si no pone el 0x
            foreach (char c in n)
               if(char.IsLetter(c))
                    return sistemaNum.Hexa;

            return sistemaNum.Decimal;
        }

        //Método para ver que el caracter sea válido según lo puesto al principio
        bool EsValido(string n)
        {
            sistemaNum s = DetectaSistema(n);
            string quitaPre = n.Replace("0b", "").Replace("0x", "");

            foreach (char c in quitaPre)
            {
                if(s == sistemaNum.Decimal && char.IsLetter(c))
                    return false;
                if(s == sistemaNum.Binario && c != '0' && c != '1')
                    return false;
                if (s == sistemaNum.Hexa && (c < 'A' || c > 'F') && !char.IsDigit(c))
                   return false;
            }
            return true;
        }

        //Método para convertir todo a sistema decimal
        int ConvertirADecimal(string n)
        {
            if (n.StartsWith("0b"))
                return Convert.ToInt32(n.Substring(2), 2); //El substring(2) quita el 0b, base 2
            if (n.StartsWith("0x"))
                return Convert.ToInt32(n.Substring(2), 16); //El substring(2) quita el 0x, base 16
            //Por si no pone el 0x e identifica una letra, lo hace hexa
            if (n.Any(char.IsLetter))
                return Convert.ToInt32(n, 16);

            //Si no tiene letras ni los prefijos, regresa el decimal normal
            return int.Parse(n);
        }

        //Método para procesar operación
        void ProcesarOp()
        {
            string expresion = txtOperacion.Text;
            char[] operador = { '+', '-', 'X', '÷', '%', '√' };

            foreach (char op in operador)
            {
                if(expresion.Contains(op))
                {
                    string[] p = expresion.Split(op);
                    if (p.Length != 2)
                        return;
                    if (!EsValido(p[0]) || !EsValido(p[1]))
                        return;

                    int a = ConvertirADecimal(p[0]);
                    int b = ConvertirADecimal(p[1]);

                    txtRes.Text = Operacion(a, b, op).ToString();
                }
            }

        }


        private void botonB_Click(object sender, EventArgs e)
        {

        }

        private void botonC_Click(object sender, EventArgs e)
        {

        }

        private void b7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bMult_Click(object sender, EventArgs e)
        {

        }
    }
}
