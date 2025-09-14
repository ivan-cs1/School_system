using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;


namespace SistemaEscolar
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            CarEsp();
        }

        private void CarEsp()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.KeyPress += TextBox_KeyPress;
                }
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nuc = textBox1.Text;
            string matr = textBox2.Text;
            int matrint = int.Parse(matr);

            if (matrint < 4)
            {
                string datarins = nuc + "|" + matr;
                File.AppendAllText("reinscripciones.txt", datarins + Environment.NewLine);
                label4.Text = "Reinscripcion realizada";
            }
            else
            {
                label4.Text = "No se puede reinscribir";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            label4.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
