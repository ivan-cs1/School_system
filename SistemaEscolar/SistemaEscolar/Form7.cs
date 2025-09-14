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
using System.Linq;

namespace SistemaEscolar
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] DataAlm = File.ReadAllLines("bajas y excelencia.txt");
            int almbaj = 0, almexc = 0;

            foreach (string data in DataAlm)
            {
                string[] alm = data.Split('|');
                float[] prom = alm.Skip(1).Select(float.Parse).ToArray();

                int matrep = ContarReprobadas(prom);

                if (matrep >= 3)
                {
                    almbaj++;
                }

                if (Excelencia(prom))
                {
                    almexc++;
                }
            }

            if (comboBox1.SelectedIndex == 0)
            {

                label2.Text = "La cantidad de alumnos que son baja por reglamento es: " + almbaj.ToString();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                label2.Text = "La cantidad de alumnos que tienen excelencia academica es: " + almexc.ToString();

            }

        }

        private int ContarReprobadas(float[] promedios)
        {
            int count = 0;
            foreach (float prom in promedios)
            {
                if (prom < 6)
                {
                    count++;
                }
            }
            return count;
        }

        private bool Excelencia(float[] promedios)
        {
            float promedioGeneral = promedios.Average();
            return promedioGeneral >= 9.5;
        }
    }
}
