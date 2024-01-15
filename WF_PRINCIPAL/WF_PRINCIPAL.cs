using System.Linq;
using System.Windows.Forms;
using System.IO;
using System;

namespace WF_PRINCIPAL
{
    /// <summary>
    /// Clase principal del formulario.
    /// </summary>
    public partial class WF_PRINCIPAL : Form
    {
        // Constructor de la clase
        public WF_PRINCIPAL()
        {
            InitializeComponent();
        }

        // Variables para almacenar operandos y operador
        double a = 0;
        double b = 0;
        string c = "";

        // Evento para el botón "1"
        /// <summary>
        /// Maneja el clic en el botón "1" y actualiza la pantalla.
        /// </summary>
        private void BTN_1_Click(object sender, EventArgs e)
        {
            TXT_PANTALLA.Text = TXT_PANTALLA.Text + "1";
        }

        // Evento para el botón "2"
        /// <summary>
        /// Maneja el clic en el botón "2" y actualiza la pantalla.
        /// </summary>
        private void BTN_2_Click(object sender, EventArgs e)
        {
            TXT_PANTALLA.Text = TXT_PANTALLA.Text + "2";
        }

        // Evento para el botón "3"
        /// <summary>
        /// Maneja el clic en el botón "3" y actualiza la pantalla.
        /// </summary>
        private void BTN_3_Click(object sender, EventArgs e)
        {
            if (TXT_PANTALLA.Text == "")
            {
                TXT_PANTALLA.Text = "3";
            }
            else
            {
                TXT_PANTALLA.Text = TXT_PANTALLA.Text + "3";
            }
        }

        // Evento para el botón "4"
        /// <summary>
        /// Maneja el clic en el botón "4" y actualiza la pantalla.
        /// </summary>
        private void BTN_4_Click(object sender, EventArgs e)
        {
            if (TXT_PANTALLA.Text == "")
            {
                TXT_PANTALLA.Text = "4";
            }
            else
            {
                TXT_PANTALLA.Text = TXT_PANTALLA.Text + "4";
            }
        }

        // Evento para el botón "5"
        /// <summary>
        /// Maneja el clic en el botón "5" y actualiza la pantalla.
        /// </summary>
        private void BTN_5_Click(object sender, EventArgs e)
        {
            if (TXT_PANTALLA.Text == "")
            {
                TXT_PANTALLA.Text = "5";
            }
            else
            {
                TXT_PANTALLA.Text = TXT_PANTALLA.Text + "5";
            }
        }

        // Evento para el botón "6"
        /// <summary>
        /// Maneja el clic en el botón "6" y actualiza la pantalla.
        /// </summary>
        private void BTN_6_Click(object sender, EventArgs e)
        {
            if (TXT_PANTALLA.Text == "")
            {
                TXT_PANTALLA.Text = "6";
            }
            else
            {
                TXT_PANTALLA.Text = TXT_PANTALLA.Text + "6";
            }
        }

        // Evento para el botón "7"
        /// <summary>
        /// Maneja el clic en el botón "7" y actualiza la pantalla.
        /// </summary>
        private void BTN_7_Click(object sender, EventArgs e)
        {
            if (TXT_PANTALLA.Text == "")
            {
                TXT_PANTALLA.Text = "7";
            }
            else
            {
                TXT_PANTALLA.Text = TXT_PANTALLA.Text + "7";
            }
        }

        // Evento para el botón "8"
        /// <summary>
        /// Maneja el clic en el botón "8" y actualiza la pantalla.
        /// </summary>
        private void BTN_8_Click(object sender, EventArgs e)
        {
            if (TXT_PANTALLA.Text == "")
            {
                TXT_PANTALLA.Text = "8";
            }
            else
            {
                TXT_PANTALLA.Text = TXT_PANTALLA.Text + "8";
            }
        }

        // Evento para el botón "9"
        /// <summary>
        /// Maneja el clic en el botón "9" y actualiza la pantalla.
        /// </summary>
        private void BTN_9_Click(object sender, EventArgs e)
        {
            if (TXT_PANTALLA.Text == "")
            {
                TXT_PANTALLA.Text = "9";
            }
            else
            {
                TXT_PANTALLA.Text = TXT_PANTALLA.Text + "9";
            }
        }

        // Evento para el botón "0"
        /// <summary>
        /// Maneja el clic en el botón "0" y actualiza la pantalla.
        /// </summary>
        private void BTN_0_Click(object sender, EventArgs e)
        {
            if (TXT_PANTALLA.Text == "")
            {
                TXT_PANTALLA.Text = "0";
            }
            else
            {
                TXT_PANTALLA.Text = TXT_PANTALLA.Text + "0";
            }
        }

        // Evento para el botón de división "/"
        /// <summary>
        /// Almacena el primer operando, establece el operador, limpia la pantalla y establece el foco.
        /// </summary>
        private void BTN_DIVI_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.TXT_PANTALLA.Text);
            c = "/";
            this.TXT_PANTALLA.Clear();
            this.TXT_PANTALLA.Focus();
        }

        // Evento para el botón de multiplicación "*"
        /// <summary>
        /// Almacena el primer operando, establece el operador, limpia la pantalla y establece el foco.
        /// </summary>
        private void BTN_MULTI_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.TXT_PANTALLA.Text);
            c = "*";
            this.TXT_PANTALLA.Clear();
            this.TXT_PANTALLA.Focus();
        }

        // Evento para el botón de resta "-"
        /// <summary>
        /// Almacena el primer operando, establece el operador, limpia la pantalla y establece el foco.
        /// </summary>
        private void BTN_RESTA_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.TXT_PANTALLA.Text);
            c = "-";
            this.TXT_PANTALLA.Clear();
            this.TXT_PANTALLA.Focus();
        }

        // Evento para el botón de suma "+"
        /// <summary>
        /// Almacena el primer operando, establece el operador y limpia la pantalla.
        /// </summary>
        private void BTN_SUMA_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.TXT_PANTALLA.Text);
            c = "+";
            this.TXT_PANTALLA.Clear();
        }

        // Evento para el botón de punto decimal "."
        /// <summary>
        /// Agrega un punto decimal a la pantalla si aún no está presente.
        /// </summary>
        private void BTN_PUNTO_Click(object sender, EventArgs e)
        {
            if (this.TXT_PANTALLA.Text.Contains('.') == false)
            {
                this.TXT_PANTALLA.Text = this.TXT_PANTALLA.Text + ".";
            }
        }

        // Evento para el botón de igual "="
        /// <summary>
        /// Realiza la operación aritmética según el operador almacenado.
        /// </summary>
        private void BTN_IGUAL_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(this.TXT_PANTALLA.Text);
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
                    this.TXT_PANTALLA.Text = Convert.ToString(a / b);
                    break;
            }
        }

        // Evento para el botón de imprimir
        /// <summary>
        /// Escribe la última operación en un archivo de texto y lo abre.
        /// </summary>
        private void BTN_IMPRIMIR_Click(object sender, EventArgs e)
        {
            StreamWriter Archivo = new StreamWriter("Historial.txt");
            Archivo.WriteLine("Última Operación: " + a + c + b + "=" + this.TXT_PANTALLA.Text);
            Archivo.Close();
            System.Diagnostics.Process.Start("Historial.txt");
        }

        // Evento para el botón de limpiar
        /// <summary>
        /// Reinicia los operandos y limpia la pantalla.
        /// </summary>
        private void BTN_LIMPIAR_Click(object sender, EventArgs e)
        {
            a = 0;
            b = 0;
            c = "";
            this.TXT_PANTALLA.Text = "";
        }
    }
}
