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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            VArch();
            Form2 form2 = new Form2
            {
                Enabled = false,
            };
            Form3 form3 = new Form3
            {
                Enabled = false,
            };
            Form4 form4 = new Form4
            {
                Enabled = false,
            };
            Form5 form5 = new Form5
            {
                Enabled = false,
            };
            Form6 form6 = new Form6
            {
                Enabled = false,
            };
            Form7 form7 = new Form7
            {
                Enabled = false,
            };
            Form8 form8 = new Form8
            {
                Enabled = false,
            };
            Form9 form9 = new Form9
            {
                Enabled = false,
            };
            Form10 form10 = new Form10
            {
                Enabled = false,
            };
            Form11 form11 = new Form11
            {
                Enabled = false,
            };
            Form12 form12 = new Form12
            {
                Enabled = false,
            };
        }

        private void VArch()
        {
            if (!File.Exists("alumnos.txt"))
            {
                using (StreamWriter sw = new StreamWriter("alumnos.txt"))
                {
                    sw.WriteLine("123456789|curp123456789|Lionel Andres|Messi|Cuccitini|3|AVP|Programacion|vespertino|NoseXD");
                }
            }

            if (!File.Exists("calificaciones.txt"))
            {
                using (StreamWriter sw = new StreamWriter("calificaciones.txt"))
                {
                    sw.WriteLine("123456789|10|10|10|10|10|10|10|10|10|10|10|10|10|10|10|10|10|10|10|10|10|10|10|10|10|10|10|10|10|10|10|10|10");
                }
            }

            if (!File.Exists("asistencias.txt"))
            {
                using (StreamWriter sw = new StreamWriter("asistencias.txt"))
                {
                    sw.WriteLine("123456789|10|10|10|10|10|10|10|10|10|10|10|10|10|10|10|10|10|10|10|10|10|10|10|10|10|10|10|10|10|10|10|10|10");
                }
            }

            if (!File.Exists("inscripciones.txt"))
            {
                using (StreamWriter sw = new StreamWriter("inscripciones.txt"))
                {
                    sw.WriteLine("Nombre|Apellido1|Apellido2|CURP1234|Domicilio|Fecha de nacimiento|Edad|Sexo|Secundaria|10|12345");
                }
            }

            if (!File.Exists("reinscripciones.txt"))
            {
                using (StreamWriter sw = new StreamWriter("reinscripciones.txt"))
                {
                    sw.WriteLine("123456|0");
                }

            }

            if (!File.Exists("promedios.txt"))
            {
                using (StreamWriter sw = new StreamWriter("promedios.txt"))
                {
                    sw.WriteLine("Lengua y comunicacion III:10|Ingles III:10|Pensamiento matematico III:10|Ecosistemas:10|Humanidades:10|Recursos socioemocionales III:10|Taller de emprendedores I:10|Activacion fisica:10|Tutoria:10|Emplea frameworks:10|Aplica metodologias agiles:10");
                }

            }

            if (!File.Exists("bajas y excelencia.txt"))
            {
                using (StreamWriter sw = new StreamWriter("bajas y excelencia.txt"))
                {
                    sw.WriteLine("123456789|10|10|10|10|10|10|10|10|10|10|10");
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Form2 form2 = new Form2
                {
                    Enabled = true,
                };
                form2.Show();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                Form3 form3 = new Form3
                {
                    Enabled = true,
                };
                form3.Show();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                Form4 form4 = new Form4
                {
                    Enabled = true,
                };
                form4.Show();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                Form5 form5 = new Form5
                {
                    Enabled = true,
                };
                form5.Show();
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                Form6 form6 = new Form6
                {
                    Enabled = true,
                };
                form6.Show();
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                Form7 form7 = new Form7
                {
                    Enabled = true,
                };
                form7.Show();
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                Form8 form8 = new Form8
                {
                    Enabled = true,
                };
                form8.Show();
            }
            else if (comboBox1.SelectedIndex == 7)
            {
                Form9 form9 = new Form9
                {
                    Enabled = true,
                };
                form9.Show();
            }
            else if (comboBox1.SelectedIndex == 8)
            {
                Form10 form10 = new Form10
                {
                    Enabled = true,
                };
                form10.Show();
            }

            else if (comboBox1.SelectedIndex == 9)
            {
                Form11 form11 = new Form11
                {
                    Enabled = true,
                };
                form11.Show();
            }

            else if (comboBox1.SelectedIndex == 10)
            {
                Form12 form12 = new Form12
                {
                    Enabled = true,
                };
                form12.Show();
            }
        }
            
    }
}
