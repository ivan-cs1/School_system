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
    public partial class Form8 : Form
    {
        public Form8()
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
            string nom = textBox1.Text;
            string app = textBox2.Text;
            string apm = textBox3.Text;
            string curp = textBox4.Text;
            string dom = textBox5.Text;
            string fec = textBox6.Text;
            string edad = textBox7.Text;
            string sex = textBox8.Text;
            string sec = textBox9.Text;
            string pro = textBox10.Text;
            string nuc = textBox11.Text;

            string datains = nom + "|" + app + "|" + apm + "|" + curp + "|" + dom + "|" + fec + "|" + edad + "|" + sex + "|" + sec + "|" + pro + "|" + nuc;
            File.AppendAllText("inscripciones.txt", datains + Environment.NewLine);

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
            textBox8.Text = string.Empty;
            textBox9.Text = string.Empty;
            textBox10.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
