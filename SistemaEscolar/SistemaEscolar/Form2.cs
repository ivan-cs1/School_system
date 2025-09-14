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
    public partial class Form2 : Form
    {
        public Form2()
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
            string curp = textBox2.Text;
            string nom = textBox3.Text;
            string app = textBox4.Text;
            string apm = textBox5.Text;
            string sem = textBox6.Text;
            string grp = textBox7.Text;
            string car = comboBox1.SelectedItem.ToString();
            string tur = comboBox2.SelectedItem.ToString();
            string mod = comboBox3.SelectedItem.ToString();

            string dataalumn = nuc + "|" + curp + "|" + nom + "|" + app + "|" + apm + "|" + sem + "|" + grp + "|" + car + "|" + tur + "|" + mod;
            File.AppendAllText("alumnos.txt", dataalumn + Environment.NewLine);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
            comboBox1.Text = string.Empty;
            comboBox2.Text = string.Empty;
            comboBox3.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
