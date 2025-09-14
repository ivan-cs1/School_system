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
using Microsoft.VisualBasic.PowerPacks.Printing;

namespace SistemaEscolar
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
            CargarCalificaciones();
            CargarAsistencias();
        }

        private void CargarCalificaciones()
        {
            string[] calfs = File.ReadAllLines("calificaciones.txt");

            comboBox1.Items.Clear();
            foreach (var registro in calfs)
            {
                string[] datos = registro.Split('|');
                if (datos.Length > 0 && !comboBox1.Items.Contains(datos[0]))
                {
                    comboBox1.Items.Add(datos[0]);
                }
            }
        }

        private void CargarAsistencias()
        {
            string[] asis = File.ReadAllLines("asistencias.txt");

            comboBox1.Items.Clear();
            foreach (var registro in asis)
            {
                string[] datos = registro.Split('|');
                if (datos.Length > 0 && !comboBox1.Items.Contains(datos[0]))
                {
                    comboBox1.Items.Add(datos[0]);
                }
            }
        }

        private void CargarMaterias(string nuc)
        {
            string[] alumnos = File.ReadAllLines("alumnos.txt");

            foreach (var registro in alumnos)
            {
                string[] datos = registro.Split('|');
                if (datos.Length >= 1 && datos[0] == nuc)
                {

                    if (datos.Contains("primero") || datos.Contains("Primero") || datos.Contains("1"))
                    {
                        label3.Text = "Lengua y comunicacion I:";
                        label4.Text = "Ingles I:";
                        label5.Text = "Pensamiento matematico I:";
                        label6.Text = "Cultura digital I:";
                        label7.Text = "La materia y sus interacciones:";
                        label8.Text = "Humanidades I:";
                        label9.Text = "Ciencias sociales I:";
                        label10.Text = "Recursos socioemocionales I:";
                        label11.Text = "Tutoria:";
                    }
                    else if (datos.Contains("segundo") || datos.Contains("Segundo") || datos.Contains("2"))
                    {
                        label3.Text = "Lengua y comunicacion II:";
                        label4.Text = "Ingles II:";
                        label5.Text = "Pensamiento matematico II:";
                        label6.Text = "Cultura digital II:";
                        label7.Text = "La conservacion de la energia:";
                        label8.Text = "Ciencias sociales II:";
                        label9.Text = "Recursos socioemocionales II:";
                        label10.Text = "Tutoria:";
                        label11.Text = "Diseña software:";
                        label12.Text = "Codifica software:";
                        label13.Text = "Implementa software:";
                    }
                    else if (datos.Contains("tercero") || datos.Contains("Tercero") || datos.Contains("3"))
                    {
                        label3.Text = "Lengua y comunicacion III:";
                        label4.Text = "Ingles III:";
                        label5.Text = "Pensamiento matematico III:";
                        label6.Text = "Ecosistemas:";
                        label7.Text = "Humanidades:";
                        label8.Text = "Recursos socioemocionales III:";
                        label9.Text = "Taller de emprendedores I:";
                        label10.Text = "Activacion fisica:";
                        label11.Text = "Tutoria:";
                        label12.Text = "Emplea frameworks:";
                        label13.Text = "Aplica metodologias agiles:";
                    }
                }
            }
        }

        private void MDataCalfs(string nuc)
        {
            string[] registroscals = File.ReadAllLines("calificaciones.txt");
            foreach (var registrocal in registroscals)
            {
                string[] datos = registrocal.Split('|');
                if (datos.Length >= 34 && datos[0] == nuc)
                {

                    if (comboBox2.SelectedIndex == 0)
                    {
                        label15.Text = datos[1];
                        label16.Text = datos[4];
                        label17.Text = datos[7];
                        label18.Text = datos[10];
                        label19.Text = datos[13];
                        label20.Text = datos[16];
                        label21.Text = datos[19];
                        label22.Text = datos[22];
                        label23.Text = datos[25];
                        label24.Text = datos[28];
                        label25.Text = datos[31];
                    }
                    else if (comboBox2.SelectedIndex == 1)
                    {
                        label15.Text = datos[2];
                        label16.Text = datos[5];
                        label17.Text = datos[8];
                        label18.Text = datos[11];
                        label19.Text = datos[14];
                        label20.Text = datos[17];
                        label21.Text = datos[20];
                        label22.Text = datos[23];
                        label23.Text = datos[26];
                        label24.Text = datos[29];
                        label25.Text = datos[32];
                    }
                    else if (comboBox2.SelectedIndex == 2)
                    {
                        label15.Text = datos[3];
                        label16.Text = datos[6];
                        label17.Text = datos[9];
                        label18.Text = datos[12];
                        label19.Text = datos[15];
                        label20.Text = datos[18];
                        label21.Text = datos[21];
                        label22.Text = datos[24];
                        label23.Text = datos[27];
                        label24.Text = datos[30];
                        label25.Text = datos[33];
                    }
                }



            }

        }

        private void MDataAsis(string nuc)
        {
            string[] registrosasis = File.ReadAllLines("asistencias.txt");
            foreach (var registroasis in registrosasis)
            {
                string[] datos = registroasis.Split('|');
                if (datos.Length >= 34 && datos[0] == nuc)
                {
                    if (comboBox2.SelectedIndex == 0)
                    {
                        label27.Text = datos[1];
                        label28.Text = datos[4];
                        label29.Text = datos[7];
                        label30.Text = datos[10];
                        label31.Text = datos[13];
                        label32.Text = datos[16];
                        label33.Text = datos[19];
                        label34.Text = datos[22];
                        label35.Text = datos[25];
                        label36.Text = datos[28];
                        label37.Text = datos[31];
                    }
                    else if (comboBox2.SelectedIndex == 1)
                    {
                        label27.Text = datos[2];
                        label28.Text = datos[5];
                        label29.Text = datos[8];
                        label30.Text = datos[11];
                        label31.Text = datos[14];
                        label32.Text = datos[17];
                        label33.Text = datos[20];
                        label34.Text = datos[23];
                        label35.Text = datos[26];
                        label36.Text = datos[29];
                        label37.Text = datos[32];
                    }
                    else if (comboBox2.SelectedIndex == 2)
                    {
                        label27.Text = datos[3];
                        label28.Text = datos[6];
                        label29.Text = datos[9];
                        label30.Text = datos[12];
                        label31.Text = datos[15];
                        label32.Text = datos[18];
                        label33.Text = datos[21];
                        label34.Text = datos[24];
                        label35.Text = datos[27];
                        label36.Text = datos[30];
                        label37.Text = datos[33];
                    }
                }

            }
        }

        private void MDataAlumn(string nuc)
        {
            string[] alumnos = File.ReadAllLines("alumnos.txt");
            foreach (var alumno in alumnos)
            {
                string[] datos = alumno.Split('|');
                if (datos.Length >= 10 && datos[0] == nuc)
                {
                    label49.Text = datos[0];
                    label50.Text = datos[1];
                    label51.Text = datos[2];
                    label52.Text = datos[3];
                    label53.Text = datos[4];
                    label54.Text = datos[5];
                    label55.Text = datos[6];
                    label56.Text = datos[7];
                    label57.Text = datos[8];
                    label58.Text = datos[9];
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                label3.Text = string.Empty;
                label4.Text = string.Empty;
                label5.Text = string.Empty;
                label6.Text = string.Empty;
                label7.Text = string.Empty;
                label8.Text = string.Empty;
                label9.Text = string.Empty;
                label10.Text = string.Empty;
                label11.Text = string.Empty;
                label12.Text = string.Empty;
                label13.Text = string.Empty;
                label15.Text = string.Empty;
                label16.Text = string.Empty;
                label17.Text = string.Empty;
                label18.Text = string.Empty;
                label19.Text = string.Empty;
                label20.Text = string.Empty;
                label21.Text = string.Empty;
                label22.Text = string.Empty;
                label23.Text = string.Empty;
                label24.Text = string.Empty;
                label25.Text = string.Empty;
                label27.Text = string.Empty;
                label28.Text = string.Empty;
                label29.Text = string.Empty;
                label30.Text = string.Empty;
                label31.Text = string.Empty;
                label32.Text = string.Empty;
                label33.Text = string.Empty;
                label34.Text = string.Empty;
                label35.Text = string.Empty;
                label36.Text = string.Empty;
                label37.Text = string.Empty;


                string nucsel = comboBox1.SelectedItem.ToString();

                CargarMaterias(nucsel);
                MDataAlumn(nucsel);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nucsel = comboBox1.SelectedItem.ToString();
            MDataCalfs(nucsel);
            MDataAsis(nucsel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintForm printform = new PrintForm();
            printform.Form=this;
            printform. PrinterSettings.DefaultPageSettings.Landscape = true;
            printform.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            printform.Print(this, PrintForm.PrintOption.FullWindow);
        }
    }
}
