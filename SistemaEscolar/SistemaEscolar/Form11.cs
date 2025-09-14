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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaEscolar
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
            CargarReins();
        }

        private void CargarReins()
        {
            string[] reinscritos = File.ReadAllLines("reinscripciones.txt");
            comboBox1.Items.Clear();
            foreach (var reinscrito in reinscritos)
            {
                string[] datos = reinscrito.Split('|');
                comboBox1.Items.Add(datos[0]);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string nucsel = comboBox1.SelectedItem.ToString();
                MDataReins(nucsel);
            }
        }

        private void MDataReins(string nuc)
        {
            string[] reinscritos = File.ReadAllLines("reinscripciones.txt");
            foreach (var reinscrito in reinscritos)
            {
                string[] datos = reinscrito.Split('|');
                if (datos.Length >= 2 && datos[0] == nuc)
                {
                    textBox1.Text = datos[0];
                    textBox2.Text = datos[1];
                }
            }
        }

    }
}
