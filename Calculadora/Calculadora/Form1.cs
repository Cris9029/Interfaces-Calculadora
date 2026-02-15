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

        int acum = 0;
        char operadorSig = ' ';
        bool nuevoNum = true;
        
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
            n = n.Trim();
            if(String.IsNullOrEmpty(n))
                return true; //Si el string está vacío, no hay nada inválido

            sistemaNum s = DetectaSistema(n);
            string quitaPre = n.Replace("0b", "").Replace("0x", "").Replace(" ", "");

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
            n = n.Trim();
            
            if(String.IsNullOrEmpty(n))
                return 0;
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

        //Método para controlar todos los botones (menos CRL Y borrar) porque todos hacen "lo mismo", escribir algo en el textbox
        private void ClickGeneral(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            
            bool esOperador = b.Text == "+" || b.Text == "-" || b.Text == "X" || b.Text == "÷" || b.Text == "%" || b.Text == "√";

            if (!esOperador)
            {
                if(nuevoNum)
                {
                    textBoxOperacion.Text = "";
                    nuevoNum = false;
                }

                string intento;

                if (b.Text == "x")
                {
                    if (!textBoxOperacion.Text.EndsWith("0"))
                        intento = textBoxOperacion.Text + "0x"; //Se escribe 0x y se "activa" el sistema binario
                    else
                        intento = textBoxOperacion.Text + "x";
                }
                else if (b.Text == "b")
                {
                    if (!textBoxOperacion.Text.EndsWith("0"))
                        intento = textBoxOperacion.Text + "0b"; //Se escribe 0b y se "activa" el sistema binario
                    else
                        intento = textBoxOperacion.Text + "b";
                }
                else
                    intento = textBoxOperacion.Text + b.Text; //Si no es operador, se añade el número o letra directamente

                if (!EsValido(intento))
                    return;

                textBoxOperacion.Text = intento;
                return;
            }

            //Si sí es operador:
            if (textBoxOperacion.Text == "")
                return;

            int numActual = ConvertirADecimal(textBoxOperacion.Text);

            if(operadorSig == ' ')
                acum = numActual;
            else
                acum = Operacion(acum, numActual, operadorSig);

            //Mostrar resultado parcial
            textBoxOperacion.Text = acum.ToString();

            //Para mostrar el proceso arriba
            textBoxProceso.Text = acum + " " + b.Text + " ";

            operadorSig = b.Text[0];
            nuevoNum = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Método para borrar todo
        private void bClean_Click(object sender, EventArgs e)
        {
            acum = 0;
            operadorSig = ' ';
            nuevoNum = true;
            
            textBoxProceso.Text = "";
            textBoxOperacion.Text = "0";
        }

        //Método para borrar el último caracter
        private void bBorrar_Click(object sender, EventArgs e)
        {
            if(!nuevoNum && textBoxProceso.Text.Length > 0)
                textBoxProceso.Text = textBoxProceso.Text.Substring(0, textBoxProceso.Text.Length - 1);
            if (textBoxOperacion.Text == "")
                textBoxOperacion.Text = "0";
        }

        //Método para mostrar resultado en el textBoxOperacion
        private void bRes_Click(object sender, EventArgs e)
        {
            if (operadorSig == ' ')
                return;

            int numAtual = ConvertirADecimal(textBoxOperacion.Text);

            acum = Operacion(acum, numAtual, operadorSig);

            textBoxOperacion.Text = acum.ToString();
            textBoxProceso.Text = "";

            operadorSig = ' ';
            nuevoNum = true;
        }
    }
}
