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
    public partial class Form4 : Form
    {

        public Form4()
        {

            InitializeComponent();
            CargarAlumnos();
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

        private void CargarAlumnos()
        {
            string[] alumnos = File.ReadAllLines("alumnos.txt");
            comboBox1.Items.Clear();
            foreach (var alumno in alumnos)
            {
                string[] datos = alumno.Split('|');
                comboBox1.Items.Add(datos[0]);
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string nucsel = comboBox1.SelectedItem.ToString();
                MDataAlumn(nucsel);
            }
        }

        private void MDataAlumn (string nuc)
        {
            string[] alumnos = File.ReadAllLines("alumnos.txt");
            foreach (var alumno in alumnos)
            {
                string[] datos = alumno.Split('|');
                if (datos.Length >= 10 && datos[0] == nuc)
                {
                    textBox1.Text = datos[0];
                    textBox2.Text = datos[1];
                    textBox3.Text = datos[2];
                    textBox4.Text = datos[3];
                    textBox5.Text = datos[4];
                    textBox6.Text = datos[5];
                    textBox7.Text = datos[6];
                    textBox8.Text = datos[7];
                    textBox9.Text = datos[8];
                    textBox10.Text = datos[9];
                }
            }
        }
    }
}
