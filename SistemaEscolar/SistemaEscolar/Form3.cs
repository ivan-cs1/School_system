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
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
            CarEsp();

            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label15.Visible = false;
            textBox1.Visible = false;

            textBox29.Text = "0";
            textBox30.Text = "0";
            textBox31.Text = "0";
            textBox32.Text = "0";
            textBox33.Text = "0";
            textBox34.Text = "0";
            textBox62.Text = "0";
            textBox63.Text = "0";
            textBox34.Text = "0";
            textBox64.Text = "0";
            textBox65.Text = "0";
            textBox66.Text = "0";
            textBox67.Text = "0";
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            if (comboBox1.SelectedIndex == 0)
            {
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label14.Visible = false;
                label15.Visible = false;

                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label14.Visible = true;
                label15.Visible = true;

                label2.Text = "Lengua y comunicacion I:";
                label3.Text = "Ingles I:";
                label4.Text = "Pensamiento matematico I:";
                label5.Text = "Cultura digital I:";
                label6.Text = "La materia y sus interacciones:";
                label7.Text = "Humanidades I:";
                label8.Text = "Ciencias sociales I:";
                label9.Text = "Recursos socioemocionales I:";
                label10.Text = "Tutoria:";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label14.Visible = false;
                label15.Visible = false;

                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label14.Visible = true;
                label15.Visible = true;
                

                label2.Text = "Lengua y comunicacion II:";
                label3.Text = "Ingles II:";
                label4.Text = "Pensamiento matematico II:";
                label5.Text = "Cultura digital II:";
                label6.Text = "La conservacion de la energia:";
                label7.Text = "Ciencias sociales II:";
                label8.Text = "Recursos socioemocionales II:";
                label9.Text = "Tutoria:";
                label10.Text = "Diseña software:";
                label11.Text = "Codifica software:";
                label12.Text = "Implementa software:";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label14.Visible = false;
                label15.Visible = false;

                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label14.Visible = true;
                label15.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                textBox10.Visible = true;
                textBox11.Visible = true;
                textBox12.Visible = true;
                textBox13.Visible = true;
                textBox14.Visible = true;
                textBox15.Visible = true;
                textBox16.Visible = true;
                textBox17.Visible = true;
                textBox18.Visible = true;
                textBox19.Visible = true;
                textBox20.Visible = true;
                textBox21.Visible = true;
                textBox22.Visible = true;
                textBox23.Visible = true;

                label2.Text = "Lengua y comunicacion III:";
                label3.Text = "Ingles III:";
                label4.Text = "Pensamiento matematico III:";
                label5.Text = "Ecosistemas:";
                label6.Text = "Humanidades:";
                label7.Text = "Recursos socioemocionales III:";
                label8.Text = "Taller de emprendedores I:";
                label9.Text = "Activacion fisica:";
                label10.Text = "Tutoria:";
                label11.Text = "Emplea frameworks:";
                label12.Text = "Aplica metodologias agiles:";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mat1, mat2, mat3, mat4, mat5, mat6, mat7, mat8, mat9, mat10, mat11;

            string nuc = textBox1.Text;
            string cal1 = textBox2.Text;
            string cal2 = textBox3.Text;
            string cal3 = textBox4.Text;
            string cal4 = textBox5.Text;
            string cal5 = textBox6.Text;
            string cal6 = textBox7.Text;
            string cal7 = textBox8.Text;
            string cal8 = textBox9.Text;
            string cal9 = textBox10.Text;
            string cal10 = textBox11.Text;
            string cal11 = textBox12.Text;
            string cal12 = textBox13.Text;
            string cal13 = textBox14.Text;
            string cal14 = textBox15.Text;
            string cal15 = textBox16.Text;
            string cal16 = textBox17.Text;
            string cal17 = textBox18.Text;
            string cal18 = textBox19.Text;
            string cal19 = textBox20.Text;
            string cal20 = textBox21.Text;
            string cal21 = textBox22.Text;
            string cal22 = textBox23.Text;
            string cal23 = textBox24.Text;
            string cal24 = textBox25.Text;
            string cal25 = textBox26.Text;
            string cal26 = textBox27.Text;
            string cal27 = textBox28.Text;
            string cal28 = textBox29.Text;
            string cal29 = textBox30.Text;
            string cal30 = textBox31.Text;
            string cal31 = textBox32.Text;
            string cal32 = textBox33.Text;
            string cal33 = textBox34.Text;
            string asi1 = textBox35.Text;
            string asi2 = textBox36.Text;
            string asi3 = textBox37.Text;
            string asi4 = textBox38.Text;
            string asi5 = textBox39.Text;
            string asi6 = textBox40.Text;
            string asi7 = textBox41.Text;
            string asi8 = textBox42.Text;
            string asi9 = textBox43.Text;
            string asi10 = textBox44.Text;
            string asi11 = textBox45.Text;
            string asi12 = textBox46.Text;
            string asi13 = textBox47.Text;
            string asi14 = textBox48.Text;
            string asi15 = textBox49.Text;
            string asi16 = textBox50.Text;
            string asi17 = textBox51.Text;
            string asi18 = textBox52.Text;
            string asi19 = textBox53.Text;
            string asi20 = textBox54.Text;
            string asi21 = textBox55.Text;
            string asi22 = textBox56.Text;
            string asi23 = textBox57.Text;
            string asi24 = textBox58.Text;
            string asi25 = textBox59.Text;
            string asi26 = textBox60.Text;
            string asi27 = textBox61.Text;
            string asi28 = textBox62.Text;
            string asi29 = textBox63.Text;
            string asi30 = textBox64.Text;
            string asi31 = textBox65.Text;
            string asi32 = textBox66.Text;
            string asi33 = textBox67.Text;

            float calf1 = float.Parse(cal1);
            float calf2 = float.Parse(cal2);
            float calf3 = float.Parse(cal3);
            float   calf4 = float.Parse(cal4);
            float calf5 = float.Parse(cal5);
            float calf6 = float.Parse(cal6);
            float calf7 = float.Parse(cal7);    
            float calf8 = float.Parse(cal8);
            float calf9 = float.Parse(cal9);
            float calf10 = float.Parse(cal10);
            float calf11 = float.Parse(cal11);
            float calf12 = float.Parse(cal12);
            float calf13 = float.Parse(cal13);
            float calf14 = float.Parse(cal14);
            float calf15 = float.Parse(cal15);
            float calf16 = float.Parse(cal16);  
            float calf17 = float.Parse(cal17);
            float calf18 = float.Parse(cal18);
            float calf19 = float.Parse(cal19);
            float calf20 = float.Parse(cal20);
            float calf21 = float.Parse(cal21);
            float calf22 = float.Parse(cal22);
            float calf23 = float.Parse(cal23);
            float calf24 = float.Parse(cal24);
            float calf25 = float.Parse(cal25);
            float calf26 = float.Parse(cal26);
            float calf27 = float.Parse(cal27);
            float calf28 = float.Parse(cal28);
            float calf29 = float.Parse(cal29);
            float calf30 = float.Parse(cal30);
            float calf31 = float.Parse(cal31);
            float calf32 = float.Parse(cal32);
            float calf33 = float.Parse(cal33);

            float prom1 = (calf1 + calf2 + calf3) / 3;
            float prom2 = (calf4 + calf5 + calf6) / 3;
            float prom3 = (calf7 + calf8 + calf9) / 3;
            float prom4 = (calf10 + calf11 + calf12) / 3;
            float prom5 = (calf13 + calf14 + calf15) / 3;
            float prom6 = (calf16 + calf17 + calf18) / 3;
            float prom7 = (calf19 + calf20 + calf21) / 3;
            float prom8 = (calf22 + calf23 + calf24) / 3;
            float prom9 = (calf25 + calf26 + calf27) / 3;
            float prom10 = (calf28 + calf29 + calf30) / 3;
            float prom11 = (calf31 + calf32 + calf33) / 3;

            if (comboBox1.SelectedIndex == 0)
            {
                //29-34, 62,67

                

                mat1 = "Lengua y comunicacion I";
                mat2 = "Ingles I";
                mat3 = "Pensamiento matematico I";
                mat4 = "Cultura digital I";
                mat5 = "La materia y sus interacciones";
                mat6 = "Humanidades I";
                mat7 = "Ciencias sociales I";
                mat8 = "Recursos socioemocionales I";
                mat9 = "Tutoria I";

                string dataprom = mat1 + ":" + prom1 + "|" + mat2 + ":" + prom2 + "|" + mat3 + ":" + prom3 + "|" + mat4 + ":" + prom4 + "|" + mat5 + ":" + prom5 + "|" + mat6 + ":" + prom6 + "|" + mat7 + ":" + prom7 + "|" + mat8 + ":" + prom8 + "|" + mat9 + ":" + prom9;
                File.AppendAllText("promedios.txt", dataprom + Environment.NewLine);
                string databajexc = nuc + "|" + prom1 + "|" + prom2 + "|" + prom3 + "|" + prom4 + "|" + prom5 + "|" + prom6 + "|" + prom7 + "|" + prom8 + "|" + prom9;
                File.AppendAllText("bajas y excelencia.txt", dataprom + Environment.NewLine);

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                mat1= "Lengua y comunicacion II";
                mat2 = "Ingles II";
                mat3 = "Pensamiento matematico II";
                mat4 = "Cultura digital II";
                mat5 = "La conservacion de la energia";
                mat6 = "Ciencias sociales II";
                mat7 = "Recursos socioemocionales II";
                mat8 = "Tutoria II";
                mat9 = "Diseña software";
                mat10 = "Codifica software";
                mat11 = "Implementa software";

                string dataprom = mat1 + ":" + prom1 + "|" + mat2 + ":" + prom2 + "|" + mat3 + ":" + prom3 + "|" + mat4 + ":" + prom4 + "|" + mat5 + ":" + prom5 + "|" + mat6 + ":" + prom6 + "|" + mat7 + ":" + prom7 + "|" + mat8 + ":" + prom8 + "|" + mat9 + ":" + prom9 + "|" + mat10 + ":" + prom10 + "|" + mat11 + ":" + prom11;
                File.AppendAllText("promedios.txt", dataprom + Environment.NewLine);

                string databajexc = nuc + "|" + prom1 + "|" + prom2 + "|" + prom3 + "|" + prom4 + "|" + prom5 + "|" + prom6 + "|" + prom7 + "|" + prom8 + "|" + prom9 + "|" + prom10 + "|" + prom11;
                File.AppendAllText("bajas y excelencia.txt", databajexc + Environment.NewLine);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                mat1 = "Lengua y comunicacion III";
                mat2 = "Ingles III";
                mat3 = "Pensamiento matematico III";
                mat4 = "Ecosistemas";
                mat5 = "Humanidades II";
                mat6 = "Recursos socioemocionales III";
                mat7 = "Taller de emprendedores I";
                mat8 = "Activacion fisica";
                mat9 = "Tutoria III";
                mat10 = "Emplea frameworks";
                mat11 = "Aplica metodologias agiles";

                string dataprom = mat1 + ":" + prom1 + "|" + mat2 + ":" + prom2 + "|" + mat3 + ":" + prom3 + "|" + mat4 + ":" + prom4 + "|" + mat5 + ":" + prom5 + "|" + mat6 + ":" + prom6 + "|" + mat7 + ":" + prom7 + "|" + mat8 + ":" + prom8 + "|" + mat9 + ":" + prom9 + "|" + mat10 + ":" + prom10 + "|" + mat11 + ":" + prom11;
                File.AppendAllText("promedios.txt", dataprom + Environment.NewLine);
                string databajexc = nuc + "|" + prom1 + "|" + prom2 + "|" + prom3 + "|" + prom4 + "|" + prom5 + "|" + prom6 + "|" + prom7 + "|" + prom8 + "|" + prom9 + "|" + prom10 + "|" + prom11;
                File.AppendAllText("bajas y excelencia.txt", databajexc + Environment.NewLine);
            }

            string datacalfs = nuc + "|" + cal1 + "|" + cal2 + "|" + cal3 + "|" + cal4 + "|" + cal5 + "|" + cal6 + "|" + cal7 + "|" + cal8 + "|" + cal9 + "|" + cal10 + "|" + cal11 + "|" + cal12 + "|" + cal13 + "|" + cal14 + "|" + cal15 + "|" + cal16 + "|" + cal17 + "|" + cal18 + "|" + cal19 + "|" + cal20 + "|" + cal21 + "|" + cal22 + "|" + cal23 + "|" + cal24 + "|" + cal25 + "|" + cal26 + "|" + cal27 + "|" + cal28 + "|" + cal29 + "|" + cal30 + "|" + cal31 + "|" + cal32 + "|" + cal33;
            File.AppendAllText("calificaciones.txt", datacalfs + Environment.NewLine);  
            string dataasis = nuc + "|" + asi1 + "|" + asi2 + "|" + asi3 + "|" + asi4 + "|" + asi5 + "|" + asi6 + "|" + asi7 + "|" + asi8 + "|" + asi9 + "|" + asi10 + "|" + asi11 + "|" + asi12 + "|" + asi13 + "|" + asi14 + "|" + asi15 + "|" + asi16 + "|" + asi17 + "|" + asi18 + "|" + asi19 + "|" + asi20 + "|" + asi21 + "|" + asi22 + "|" + asi23 + "|" + asi24 + "|" + asi25 + "|" + asi26 + "|" + asi27 + "|" + asi28 + "|" + asi29 + "|" + asi30 + "|" + asi31 + "|" + asi32 + "|" + asi33;
            File.AppendAllText("asistencias.txt", dataasis + Environment.NewLine);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = string.Empty;
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
            textBox11.Text = string.Empty;
            textBox12.Text = string.Empty;
            textBox13.Text = string.Empty;
            textBox14.Text = string.Empty;
            textBox15.Text = string.Empty;
            textBox16.Text = string.Empty;
            textBox17.Text = string.Empty;
            textBox18.Text = string.Empty;
            textBox19.Text = string.Empty;
            textBox20.Text = string.Empty;
            textBox21.Text = string.Empty;  
            textBox22.Text = string.Empty;
            textBox23.Text = string.Empty;
            textBox24.Text = string.Empty;
            textBox25.Text = string.Empty;
            textBox26.Text = string.Empty;
            textBox27.Text = string.Empty;
            textBox28.Text = string.Empty;
            textBox29.Text = string.Empty;
            textBox30.Text = string.Empty;
            textBox31.Text = string.Empty;
            textBox32.Text = string.Empty;
            textBox33.Text = string.Empty;
            textBox34.Text = string.Empty;
            textBox35.Text = string.Empty;
            textBox36.Text = string.Empty;
            textBox37.Text = string.Empty;
            textBox38.Text = string.Empty;
            textBox39.Text = string.Empty;
            textBox40.Text = string.Empty;
            textBox41.Text = string.Empty;
            textBox42.Text = string.Empty;
            textBox43.Text = string.Empty;
            textBox44.Text = string.Empty;
            textBox45.Text = string.Empty;
            textBox46.Text = string.Empty;
            textBox47.Text = string.Empty;
            textBox48.Text = string.Empty;
            textBox49.Text = string.Empty;
            textBox50.Text = string.Empty;
            textBox51.Text = string.Empty;
            textBox52.Text = string.Empty;
            textBox53.Text = string.Empty;
            textBox54.Text = string.Empty;
            textBox55.Text = string.Empty;
            textBox56.Text = string.Empty;
            textBox57.Text = string.Empty;
            textBox60.Text = string.Empty;
            textBox61.Text = string.Empty;
            textBox62.Text = string.Empty;
            textBox63.Text = string.Empty;
            textBox64.Text = string.Empty;
            textBox65.Text = string.Empty;
            textBox66.Text = string.Empty;
            textBox67.Text = string.Empty;


            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label15.Visible = false;
            textBox1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
