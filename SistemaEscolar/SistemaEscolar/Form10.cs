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

namespace SistemaEscolar
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
            CargarIns();
        }

        private void CargarIns()
        {
            string[] inscritos = File.ReadAllLines("inscripciones.txt");
            comboBox1.Items.Clear();
            foreach (var inscrito in inscritos)
            {
                string[] datos = inscrito.Split('|');
                comboBox1.Items.Add(datos[0]);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string nomsel = comboBox1.SelectedItem.ToString();
                MDataIns(nomsel);
            }
        }

        private void MDataIns(string nom)
        {
            string[] inscritos = File.ReadAllLines("inscripciones.txt");
            foreach (var inscrito in inscritos)
            {
                string[] datos = inscrito.Split('|');
                if (datos.Length >= 11 && datos[0] == nom)
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
                    textBox11.Text = datos[10];
                }
            }
        }
    }
}
