using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OneClick(object sender, EventArgs e)
        {
            MathOutput.Text += "1";
        }

        private void TwoClick(object sender, EventArgs e)
        {
            MathOutput.Text += "2";
        }

        private void ThreeClick(object sender, EventArgs e)
        {
            MathOutput.Text += "3";
        }

        private void FourClick(object sender, EventArgs e)
        {
            MathOutput.Text += "4";
        }
        private void FiveClick(object sender, EventArgs e)
        {
            MathOutput.Text += "5";
        }

        private void SixClick(object sender, EventArgs e)
        {
            MathOutput.Text += "6";
        }
        private void SevenClick(object sender, EventArgs e)
        {
            MathOutput.Text += "7";
        }

        private void EightClick(object sender, EventArgs e)
        {
            MathOutput.Text += "8";
        }
        private void NineClick(object sender, EventArgs e)
        {
            MathOutput.Text += "9";
        }

        private void ZeroClick(object sender, EventArgs e)
        {
            MathOutput.Text += "0";
        }
        private void PlusClick(object sender, EventArgs e)
        {
            MathOutput.Text += "+";
        }

        private void MinusClick(object sender, EventArgs e)
        {
            MathOutput.Text += "-";
        }
        private void MultiplyClick(object sender, EventArgs e)
        {
            MathOutput.Text += "*";
        }

        private void DivideClick(object sender, EventArgs e)
        {
            MathOutput.Text += "/";
        }
        private void ModClick(object sender, EventArgs e)
        {
            MathOutput.Text += "%";
        }

        private void DotClick(object sender, EventArgs e)
        {
            MathOutput.Text += ".";
        }
        private void ClearClick(object sender, EventArgs e)
        {
            MathOutput.Text = "";
        }

        private void BackspaceClick(object sender, EventArgs e)
        {
            MathOutput.Text = MathOutput.Text.Substring(0, MathOutput.Text.Length - 1);
        }

        private void GoClick(object sender, EventArgs e)
        {
            DataTable evaluator = new DataTable();
            MathOutput.Text = evaluator.Compute(MathOutput.Text, "").ToString();
        }

        private void TypeEquation(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar)
            {
                //'Backspace'
                case '\b':
                    MathOutput.Text = MathOutput.Text.Substring(0, MathOutput.Text.Length - 1);
                    break;

                //'Escape': Clear Equation
                case (char)27:
                    MathOutput.Text = "";
                    break;

                //'Enter': Run Calculation
                case '\r':
                    DataTable evaluator = new DataTable();
                    MathOutput.Text = evaluator.Compute(MathOutput.Text, "").ToString();
                    break;

                case '.':
                    MathOutput.Text += ".";
                    break;

                case '+':
                    MathOutput.Text += "+";
                    break;

                case '-':
                    MathOutput.Text += "-";
                    break;

                case '/':
                    MathOutput.Text += "/";
                    break;

                case '*':
                    MathOutput.Text += '*';
                    break;

                case '%':
                    MathOutput.Text += '%';
                    break;
                case char n when (int)n >= 48 && (int)n <= 57:
                    MathOutput.Text += (char)n;
                    break;
                
            }
        }
    }
}