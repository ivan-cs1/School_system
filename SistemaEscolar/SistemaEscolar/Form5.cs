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
using Microsoft.Win32;
using System.Xml.Schema;
using System.Text.RegularExpressions;


namespace SistemaEscolar
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            CargarCalificaciones();
            CargarAsistencias();
            CarEsp();
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
                        label15.Text = "Primer semestre";
                        label17.Text = "Lengua y comunicacion I:";
                        label18.Text = "Ingles I:";
                        label19.Text = "Pensamiento matematico I:";
                        label20.Text = "Cultura digital I:";
                        label21.Text = "La materia y sus interacciones:";
                        label22.Text = "Humanidades I:";
                        label23.Text = "Ciencias sociales I:";
                        label24.Text = "Recursos socioemocionales I:";
                        label25.Text = "Tutoria:";
                    }
                    else if (datos.Contains("segundo") || datos.Contains("Segundo") || datos.Contains("2"))
                    {
                        label15.Text = "Segundo semestre:";
                        label17.Text = "Lengua y comunicacion II:";
                        label18.Text = "Ingles II:";
                        label19.Text = "Pensamiento matematico II:";
                        label20.Text = "Cultura digital II:";
                        label21.Text = "La conservacion de la energia:";
                        label22.Text = "Ciencias sociales II:";
                        label23.Text = "Recursos socioemocionales II:";
                        label24.Text = "Tutoria:";
                        label25.Text = "Diseña software:";
                        label26.Text = "Codifica software:";
                        label27.Text = "Implementa software:";
                    }
                    else if (datos.Contains("tercero") || datos.Contains("Tercero") || datos.Contains("3"))
                    {
                        label15.Text = "Tercer semestre:";
                        label17.Text = "Lengua y comunicacion III:";
                        label18.Text = "Ingles III:";
                        label19.Text = "Pensamiento matematico III:";
                        label20.Text = "Ecosistemas:";
                        label21.Text = "Humanidades:";
                        label22.Text = "Recursos socioemocionales III:";
                        label23.Text = "Taller de emprendedores I:";
                        label24.Text = "Activacion fisica:";
                        label25.Text = "Tutoria:";
                        label26.Text = "Emplea frameworks:";
                        label27.Text = "Aplica metodologias agiles:";
                    }
                }
            }
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

        private void Promedios()
        {
            float cal1 = float.Parse(textBox1.Text);
            float cal2 = float.Parse(textBox2.Text);
            float cal3 = float.Parse(textBox3.Text);
            float cal4 = float.Parse(textBox4.Text);
            float cal5 = float.Parse(textBox5.Text);
            float cal6 = float.Parse(textBox6.Text);
            float cal7 = float.Parse(textBox7.Text);
            float cal8 = float.Parse(textBox8.Text);
            float cal9 = float.Parse(textBox9.Text);
            float cal10 = float.Parse(textBox10.Text);
            float cal11 = float.Parse(textBox11.Text);
            float cal12 = float.Parse(textBox12.Text);
            float cal13 = float.Parse(textBox13.Text);
            float cal14 = float.Parse(textBox14.Text);
            float cal15 = float.Parse(textBox15.Text);
            float cal16 = float.Parse(textBox16.Text);
            float cal17 = float.Parse(textBox17.Text);
            float cal18 = float.Parse(textBox18.Text);
            float cal19 = float.Parse(textBox19.Text);
            float cal20 = float.Parse(textBox20.Text);
            float cal21 = float.Parse(textBox21.Text);
            float cal22 = float.Parse(textBox22.Text);
            float cal24 = float.Parse(textBox24.Text);
            float cal25 = float.Parse(textBox25.Text);
            float cal26 = float.Parse(textBox26.Text);
            float cal27 = float.Parse(textBox27.Text);
            float cal28 = float.Parse(textBox28.Text);
            
            textBox68.Text = ((cal1 + cal2 + cal3) / 3).ToString();
            textBox70.Text = ((cal4 + cal5 + cal6) / 3).ToString();
            textBox72.Text = ((cal7 + cal8 + cal9) / 3).ToString();
            textBox74.Text = ((cal10 + cal11 + cal12) / 3).ToString();
            textBox76.Text = ((cal13 + cal14 + cal15) / 3).ToString();
            textBox78.Text = ((cal16 + cal17 + cal18) / 3).ToString();
            textBox80.Text = ((cal19 + cal20 + cal21) / 3).ToString();
            textBox82.Text = ((cal22 + cal24 + cal25) / 3).ToString();
            textBox84.Text = ((cal26 + cal27 + cal28) / 3).ToString();
        }

        private void Promedios2()
        {
            float cal29 = float.Parse(textBox29.Text);
            float cal30 = float.Parse(textBox30.Text);
            float cal31 = float.Parse(textBox31.Text);
            float cal32 = float.Parse(textBox32.Text);
            float cal33 = float.Parse(textBox33.Text);
            float cal34 = float.Parse(textBox34.Text);

            textBox86.Text = ((cal29 + cal30 + cal31) / 3).ToString();
            textBox88.Text = ((cal32 + cal33 + cal34) / 3).ToString();
        }

        private void TotAsis()
        {
            float asis1 = float.Parse(textBox35.Text);
            float asis2 = float.Parse(textBox36.Text);
            float asis3 = float.Parse(textBox37.Text);
            float asis4 = float.Parse(textBox38.Text);
            float asis5 = float.Parse(textBox39.Text);
            float asis6 = float.Parse(textBox40.Text);
            float asis7 = float.Parse(textBox41.Text);
            float asis8 = float.Parse(textBox42.Text);
            float asis9 = float.Parse(textBox43.Text);
            float asis10 = float.Parse(textBox44.Text);
            float asis11 = float.Parse(textBox45.Text);
            float asis12 = float.Parse(textBox46.Text);
            float asis13 = float.Parse(textBox47.Text);
            float asis14 = float.Parse(textBox48.Text);
            float asis15 = float.Parse(textBox49.Text);
            float asis16 = float.Parse(textBox50.Text);
            float asis17 = float.Parse(textBox51.Text);
            float asis18 = float.Parse(textBox52.Text);
            float asis19 = float.Parse(textBox53.Text);
            float asis20 = float.Parse(textBox54.Text);
            float asis21 = float.Parse(textBox55.Text);
            float asis22 = float.Parse(textBox56.Text);
            float asis23 = float.Parse(textBox57.Text);
            float asis24 = float.Parse(textBox58.Text);
            float asis25 = float.Parse(textBox59.Text);
            float asis26 = float.Parse(textBox60.Text);
            float asis27 = float.Parse(textBox61.Text);

            textBox69.Text = (asis1 + asis2 + asis3).ToString();
            textBox71.Text = (asis4 + asis5 + asis6).ToString();
            textBox73.Text = (asis7 + asis8 + asis9).ToString();
            textBox75.Text = (asis10 + asis11 + asis12).ToString();
            textBox77.Text = (asis13 + asis14 + asis15).ToString();
            textBox79.Text = (asis16 + asis17 + asis18).ToString();
            textBox81.Text = (asis19 + asis20 + asis21).ToString();
            textBox83.Text = (asis22 + asis23 + asis24).ToString();
            textBox85.Text = (asis25 + asis26 + asis27).ToString();

        }

        private void TotAsis2()
        {
            float asis28 = float.Parse(textBox62.Text);
            float asis29 = float.Parse(textBox63.Text);
            float asis30 = float.Parse(textBox64.Text);
            float asis31 = float.Parse(textBox65.Text);
            float asis32 = float.Parse(textBox66.Text);
            float asis33 = float.Parse(textBox67.Text);
            
            textBox87.Text = (asis28 + asis29 + asis30).ToString();
            textBox89.Text = (asis31 + asis32 + asis33).ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                label15.Text = string.Empty;
                label17.Text = string.Empty;
                label18.Text = string.Empty;
                label19.Text = string.Empty;
                label20.Text = string.Empty;
                label21.Text = string.Empty;
                label22.Text = string.Empty;
                label23.Text = string.Empty;
                label24.Text = string.Empty;
                label25.Text = string.Empty;
                label26.Text = string.Empty;
                label27.Text = string.Empty;
                textBox29.Text = string.Empty;
                textBox30.Text = string.Empty;
                textBox31.Text = string.Empty;
                textBox32.Text = string.Empty;
                textBox33.Text = string.Empty;
                textBox34.Text = string.Empty;
                textBox62.Text = string.Empty;
                textBox63.Text = string.Empty;
                textBox64.Text = string.Empty;
                textBox65.Text = string.Empty;
                textBox66.Text = string.Empty;
                textBox67.Text = string.Empty;
                textBox86.Text = string.Empty;
                textBox87.Text = string.Empty;
                textBox88.Text = string.Empty;
                textBox89.Text = string.Empty;
                //29-34, 62-67, 86-89

                string nucsel = comboBox1.SelectedItem.ToString();

                CargarMaterias(nucsel);
                MDataCalfs(nucsel);
                MDataAsis(nucsel);
                Promedios();
                Promedios2();
                TotAsis();
                TotAsis2();
                Acreditados();
                Acreditados2();

            }
        }

        private void Acreditados()
        {
            if (float.Parse(textBox68.Text) >= 6 || textBox68.Text == "Acreditado" || textBox68.Text == "acreditado")
            {
                label28.Text = "Acreditado";
            }
            else
            {
                label28.Text = "No acreditado";
            }

            if (float.Parse(textBox70.Text) >= 6 || textBox70.Text == "Acreditado" || textBox70.Text == "acreditado")
            {
                label29.Text = "Acreditado";
            }
            else
            {
                label29.Text = "No acreditado";
            }

            if (float.Parse(textBox72.Text) >= 6 || textBox72.Text == "Acreditado" || textBox72.Text == "acreditado")
            {
                label30.Text = "Acreditado";
            }
            else
            {
                label30.Text = "No acreditado";
            }

            if (float.Parse(textBox74.Text) >= 6 || textBox74.Text == "Acreditado" || textBox74.Text == "acreditado")
            {
                label31.Text = "Acreditado";
            }
            else
            {
                label31.Text = "No acreditado";
            }

            if (float.Parse(textBox76.Text) >= 6 || textBox76.Text == "Acreditado" || textBox76.Text == "acreditado")
            {
                label32.Text = "Acreditado";
            }
            else
            {
                label32.Text = "No acreditado";
            }

            if (float.Parse(textBox78.Text) >= 6 || textBox78.Text == "Acreditado" || textBox78.Text == "acreditado")
            {
                label33.Text = "Acreditado";
            }
            else
            {
                label33.Text = "No acreditado";
            }

            if (float.Parse(textBox80.Text) >= 6 || textBox80.Text == "Acreditado" || textBox80.Text == "acreditado")
            {
                label34.Text = "Acreditado";
            }
            else
            {
                label34.Text = "No acreditado";
            }

            if (float.Parse(textBox82.Text) >= 6 || textBox82.Text == "Acreditado" || textBox82.Text == "acreditado")
            {
                label35.Text = "Acreditado";
            }
            else
            {
                label35.Text = "No acreditado";
            }

            if (float.Parse(textBox84.Text) >= 6 || textBox84.Text == "Acreditado" || textBox84.Text == "acreditado")
            {
                label36.Text = "Acreditado";
            }
            else
            {
                label36.Text = "No acreditado";
            }


        }

        private void Acreditados2()
        {
            if (float.Parse(textBox86.Text) >= 6 || textBox86.Text == "Acreditado" || textBox86.Text == "acreditado")
            {
                label37.Text = "Acreditado";
            }
            else
            {
                label37.Text = "No acreditado";
            }

            if (float.Parse(textBox88.Text) >= 6 || textBox88.Text == "Acreditado" || textBox88.Text == "acreditado")
            {
                label38.Text = "Acreditado";
            }
            else
            {
                label38.Text = "No acreditado";
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
                    textBox23.Text = datos[0];
                    textBox1.Text = datos[1];
                    textBox2.Text = datos[2];
                    textBox3.Text = datos[3];
                    textBox4.Text = datos[4];
                    textBox5.Text = datos[5];
                    textBox6.Text = datos[6];
                    textBox7.Text = datos[7];
                    textBox8.Text = datos[8];
                    textBox9.Text = datos[9];
                    textBox10.Text = datos[10];
                    textBox11.Text = datos[11];
                    textBox12.Text = datos[12];
                    textBox13.Text = datos[13];
                    textBox14.Text = datos[14];
                    textBox15.Text = datos[15];
                    textBox16.Text = datos[16];
                    textBox17.Text = datos[17];
                    textBox18.Text = datos[18];
                    textBox19.Text = datos[19];
                    textBox20.Text = datos[20];
                    textBox21.Text = datos[21];
                    textBox22.Text = datos[22];
                    textBox24.Text = datos[23];
                    textBox25.Text = datos[24];
                    textBox26.Text = datos[25];
                    textBox27.Text = datos[26];
                    textBox28.Text = datos[27];
                    textBox29.Text = datos[28];
                    textBox30.Text = datos[29];
                    textBox31.Text = datos[30];
                    textBox32.Text = datos[31];
                    textBox33.Text = datos[32];
                    textBox34.Text = datos[33];
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

                    textBox35.Text = datos[1];
                    textBox36.Text = datos[2];
                    textBox37.Text = datos[3];
                    textBox38.Text = datos[4];
                    textBox39.Text = datos[5];
                    textBox40.Text = datos[6];
                    textBox41.Text = datos[7];
                    textBox42.Text = datos[8];
                    textBox43.Text = datos[9];
                    textBox44.Text = datos[10];
                    textBox45.Text = datos[11];
                    textBox46.Text = datos[12];
                    textBox47.Text = datos[13];
                    textBox48.Text = datos[14];
                    textBox49.Text = datos[15];
                    textBox50.Text = datos[16];
                    textBox51.Text = datos[17];
                    textBox52.Text = datos[18];
                    textBox53.Text = datos[19];
                    textBox54.Text = datos[20];
                    textBox55.Text = datos[21];
                    textBox56.Text = datos[22];
                    textBox57.Text = datos[23];
                    textBox58.Text = datos[24];
                    textBox59.Text = datos[25];
                    textBox60.Text = datos[26];
                    textBox61.Text = datos[27];
                    textBox62.Text = datos[28];
                    textBox63.Text = datos[29];
                    textBox64.Text = datos[30];
                    textBox65.Text = datos[31];
                    textBox66.Text = datos[32];
                    textBox67.Text = datos[33];
                }

            }
        }
    }
}