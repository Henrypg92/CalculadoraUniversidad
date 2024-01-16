using System.Linq;
using System.Windows.Forms;
using System.IO;
using System;
using System.Collections.Generic;

namespace WF_PRINCIPAL
{

    public partial class WF_PRINCIPAL : Form
    {
        private List<string> history;

        public WF_PRINCIPAL()
        {
            InitializeComponent();
            history = new List<string>();
            TXT_PANTALLA.Text = "0";
            TXT_PANTALLA.KeyPress += new KeyPressEventHandler(TXT_PANTALLA_KeyPress);
        }

        double a = 0;
        double b = 0;
        string c = "";

        private void TXT_PANTALLA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '+' && e.KeyChar != '-' &&
                e.KeyChar != '*' && e.KeyChar != '/' && e.KeyChar != '.' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && TXT_PANTALLA.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void BTN_1_Click(object sender, EventArgs e)
        {
            if (TXT_PANTALLA.Text == "0")
            {
                TXT_PANTALLA.Text = string.Empty;
            }

            TXT_PANTALLA.Text = TXT_PANTALLA.Text + "1";
        }

        private void BTN_2_Click(object sender, EventArgs e)
        {
            if (TXT_PANTALLA.Text == "0")
            {
                TXT_PANTALLA.Text = string.Empty;
            }

            TXT_PANTALLA.Text = TXT_PANTALLA.Text + "2";
        }

        private void BTN_3_Click(object sender, EventArgs e)
        {
            if (TXT_PANTALLA.Text == "0")
            {
                TXT_PANTALLA.Text = string.Empty;
            }

            TXT_PANTALLA.Text = TXT_PANTALLA.Text + "3";
        }

        private void BTN_4_Click(object sender, EventArgs e)
        {
            if (TXT_PANTALLA.Text == "0")
            {
                TXT_PANTALLA.Text = string.Empty;
            }

            TXT_PANTALLA.Text = TXT_PANTALLA.Text + "4";
        }

        private void BTN_5_Click(object sender, EventArgs e)
        {
            if (TXT_PANTALLA.Text == "0")
            {
                TXT_PANTALLA.Text = string.Empty;
            }

            TXT_PANTALLA.Text = TXT_PANTALLA.Text + "5";
        }

        private void BTN_6_Click(object sender, EventArgs e)
        {
            if (TXT_PANTALLA.Text == "0")
            {
                TXT_PANTALLA.Text = string.Empty;
            }

            TXT_PANTALLA.Text = TXT_PANTALLA.Text + "6";
        }

        private void BTN_7_Click(object sender, EventArgs e)
        {
            if (TXT_PANTALLA.Text == "0")
            {
                TXT_PANTALLA.Text = string.Empty;
            }

            TXT_PANTALLA.Text = TXT_PANTALLA.Text + "7";
        }

        private void BTN_8_Click(object sender, EventArgs e)
        {
            if (TXT_PANTALLA.Text == "0")
            {
                TXT_PANTALLA.Text = string.Empty;
            }

            TXT_PANTALLA.Text = TXT_PANTALLA.Text + "8";
        }

        private void BTN_9_Click(object sender, EventArgs e)
        {
            if (TXT_PANTALLA.Text == "0")
            {
                TXT_PANTALLA.Text = string.Empty;
            }

            TXT_PANTALLA.Text = TXT_PANTALLA.Text + "9";
        }

        private void BTN_0_Click(object sender, EventArgs e)
        {
            if (TXT_PANTALLA.Text == "0")
            {
                TXT_PANTALLA.Text = string.Empty;
            }

            TXT_PANTALLA.Text = TXT_PANTALLA.Text + "0";
        }

        private void BTN_DIVI_Click(object sender, EventArgs e)
        {
            if (TXT_PANTALLA.Text == "")
            {
                TXT_PANTALLA.Text = "0";
            }

            a = Convert.ToDouble(this.TXT_PANTALLA.Text);
            c = "/";
            this.TXT_PANTALLA.Clear();
            this.TXT_PANTALLA.Focus();
            TXT_PANTALLA.Text = "0";
        }

        private void BTN_MULTI_Click(object sender, EventArgs e)
        {
            if (TXT_PANTALLA.Text == "")
            {
                TXT_PANTALLA.Text = "0";
            }

            a = Convert.ToDouble(this.TXT_PANTALLA.Text);
            c = "*";
            this.TXT_PANTALLA.Clear();
            this.TXT_PANTALLA.Focus();
            TXT_PANTALLA.Text = "0";
        }

        private void BTN_RESTA_Click(object sender, EventArgs e)
        {
            if (TXT_PANTALLA.Text == "")
            {
                TXT_PANTALLA.Text = "0";
            }

            a = Convert.ToDouble(this.TXT_PANTALLA.Text);
            c = "-";
            this.TXT_PANTALLA.Clear();
            this.TXT_PANTALLA.Focus();
            TXT_PANTALLA.Text = "0";
        }

        private void BTN_SUMA_Click(object sender, EventArgs e)
        {
            if (TXT_PANTALLA.Text == "")
            {
                TXT_PANTALLA.Text = "0";
            }

            a = Convert.ToDouble(this.TXT_PANTALLA.Text);
            c = "+";
            this.TXT_PANTALLA.Clear();
            this.TXT_PANTALLA.Focus();
            TXT_PANTALLA.Text = "0";
        }

        private void BTN_PUNTO_Click(object sender, EventArgs e)
        {
            if (TXT_PANTALLA.Text == "")
            {
                TXT_PANTALLA.Text = "0";
            }

            if (this.TXT_PANTALLA.Text.Contains('.') == false)
            {
                this.TXT_PANTALLA.Text = this.TXT_PANTALLA.Text + ".";
            }
        }

        private void BTN_IGUAL_Click(object sender, EventArgs e)
        {
            if (TXT_PANTALLA.Text == "")
            {
                TXT_PANTALLA.Text = "0";
            }

            b = Convert.ToDouble(this.TXT_PANTALLA.Text);
            string operation = $"{a} {c} {b} = ";

            switch (c)
            {
                case "+":
                    this.TXT_PANTALLA.Text = Convert.ToString(a + b);
                    break;

                case "-":
                    this.TXT_PANTALLA.Text = Convert.ToString(a - b);
                    break;

                case "*":
                    this.TXT_PANTALLA.Text = Convert.ToString(a * b);
                    break;

                case "/":
                    if (b != 0)
                    {
                        this.TXT_PANTALLA.Text = Convert.ToString(a / b);
                    }
                    else
                    {
                        MessageBox.Show("Cannot divide by zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
            }
            operation += this.TXT_PANTALLA.Text;
            history.Add(operation);
        }

        private void BTN_IMPRIMIR_Click(object sender, EventArgs e)
        {
            using (StreamWriter archivo = new StreamWriter("Historial.txt"))
            {
                foreach (string entry in history)
                {
                    archivo.WriteLine(entry);
                }
            }

            System.Diagnostics.Process.Start("Historial.txt");
        }

        private void BTN_LIMPIAR_Click(object sender, EventArgs e)
        {
            a = 0;
            b = 0;
            c = "";
            this.TXT_PANTALLA.Text = "0";
        }
    }
}
