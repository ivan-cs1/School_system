using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;


namespace SistemaEscolar
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
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
            if (comboBox1.SelectedIndex == 0)
            {
                string datos = File.ReadAllText("promedios.txt");
                string[] MatYProm = datos.Split('|');
                float ac = 0, ac2 = 0, ac3 = 0, ac4 = 0, ac5 = 0, ac6 = 0, ac7 = 0, ac8 = 0, ac9 = 0, re = 0, re2 = 0, re3 = 0, re4 = 0, re5 = 0, re6 = 0, re7 = 0, re8 = 0, re9 = 0;
                foreach (string grupo in MatYProm)
                {
                    string[] partes = grupo.Split(':');
                    string mat = partes[0].Trim();
                    string prom = partes[1].Trim();

                    if (mat == "Lengua y comunicacion I")
                    {
                        if (prom == "6" || prom == "7" || prom == "8" || prom == "9" || prom == "10")
                        {
                            ac++;
                        }
                        else if (prom == "5" || prom == "4" || prom == "3" || prom == "2" || prom == "1" || prom == "0")
                        {
                            re++;
                        }

                    }
                    else if (mat == "Ingles I")
                    {
                        if (prom == "6" || prom == "7" || prom == "8" || prom == "9" || prom == "10")
                        {
                            ac2++;
                        }
                        else if (prom == "5" || prom == "4" || prom == "3" || prom == "2" || prom == "1" || prom == "0")
                        {
                            re2++;
                        }

                    }
                    else if (mat == "Pensamiento matematico I")
                    {
                        if (prom == "6" || prom == "7" || prom == "8" || prom == "9" || prom == "10")
                        {
                            ac3++;
                        }
                        else if (prom == "5" || prom == "4" || prom == "3" || prom == "2" || prom == "1" || prom == "0")
                        {
                            re3++;
                        }

                    }
                    else if (mat == "Cultura digital I")
                    {
                        if (prom == "6" || prom == "7" || prom == "8" || prom == "9" || prom == "10")
                        {
                            ac4++;
                        }
                        else if (prom == "5" || prom == "4" || prom == "3" || prom == "2" || prom == "1" || prom == "0")
                        {
                            re4++;
                        }

                    }
                    else if (mat == "La materia y sus interacciones")
                    {
                        if (prom == "6" || prom == "7" || prom == "8" || prom == "9" || prom == "10")
                        {
                            ac5++;
                        }
                        else if (prom == "5" || prom == "4" || prom == "3" || prom == "2" || prom == "1" || prom == "0")
                        {
                            re5++;
                        }

                    }
                    else if (mat == "Humanidades I")
                    {
                        if (prom == "6" || prom == "7" || prom == "8" || prom == "9" || prom == "10")
                        {
                            ac6++;
                        }
                        else if (prom == "5" || prom == "4" || prom == "3" || prom == "2" || prom == "1" || prom == "0")
                        {
                            re6++;
                        }

                    }
                    else if (mat == "Ciencias sociales I")
                    {
                        if (prom == "6" || prom == "7" || prom == "8" || prom == "9" || prom == "10")
                        {
                            ac7++;
                        }
                        else if (prom == "5" || prom == "4" || prom == "3" || prom == "2" || prom == "1" || prom == "0")
                        {
                            re7++;
                        }

                    }
                    else if (mat == "Recursos socioemocionales I")
                    {
                        if (prom == "6" || prom == "7" || prom == "8" || prom == "9" || prom == "10")
                        {
                            ac8++;
                        }
                        else if (prom == "5" || prom == "4" || prom == "3" || prom == "2" || prom == "1" || prom == "0")
                        {
                            re8++;
                        }

                    }
                    else if (mat == "Tutoria I")
                    {
                        if (prom == "6" || prom == "7" || prom == "8" || prom == "9" || prom == "10")
                        {
                            ac9++;
                        }
                        else if (prom == "5" || prom == "4" || prom == "3" || prom == "2" || prom == "1" || prom == "0")
                        {
                            re9++;
                        }

                    }
                    label15.Text = ac.ToString();
                    label27.Text = re.ToString();
                    label16.Text = ac2.ToString();
                    label28.Text = re2.ToString();
                    label17.Text = ac3.ToString();
                    label29.Text = re3.ToString();
                    label18.Text = ac4.ToString();
                    label30.Text = re4.ToString();
                    label19.Text = ac5.ToString();
                    label31.Text = re5.ToString();
                    label20.Text = ac6.ToString();
                    label32.Text = re6.ToString();
                    label21.Text = ac7.ToString();
                    label33.Text = re7.ToString();
                    label22.Text = ac8.ToString();
                    label34.Text = re8.ToString();
                    label23.Text = ac9.ToString();
                    label35.Text = re9.ToString();
                }


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
                label13.Visible = false;
                label24.Visible = false;
                label25.Visible = false;
                label36.Visible = false;
                label37.Visible = false;

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

                label3.Text = "Lengua y comunicacion I:";
                label4.Text = "Ingles I:";
                label5.Text = "Pensamiento matematico I:";
                label6.Text = "Cultura digital I:";
                label7.Text = "La materia y sus interacciones:";
                label8.Text = "Humanidades I:";
                label9.Text = "Ciencias sociales I:";
                label10.Text = "Recursos socioemocionales I:";
                label11.Text = "Tutoria:";

                float tot1 = 0, tot2 = 0, tot3 = 0, tot4 = 0, tot5 = 0, tot6 = 0, tot7 = 0, tot8 = 0, tot9 = 0;

                ac = float.Parse(label15.Text);
                re = float.Parse(label27.Text);
                ac2 = float.Parse(label16.Text);
                re2 = float.Parse(label28.Text);
                ac3 = float.Parse(label17.Text);
                re3 = float.Parse(label29.Text);
                ac4 = float.Parse(label18.Text);
                re4 = float.Parse(label30.Text);
                ac5 = float.Parse(label19.Text);
                re5 = float.Parse(label31.Text);
                ac6 = float.Parse(label20.Text);
                re6 = float.Parse(label32.Text);
                ac7 = float.Parse(label21.Text);
                re7 = float.Parse(label33.Text);
                ac8 = float.Parse(label22.Text);
                re8 = float.Parse(label34.Text);
                ac9 = float.Parse(label23.Text);
                re9 = float.Parse(label35.Text);

                tot1 = ac + re; tot2 = ac2 + re2; tot3 = ac3 + re3; tot4 = ac4 + re4; tot5 = ac5 + re5; tot6 = ac6 + re6; tot7 = ac7 + re7; tot8 = ac8 + re8; tot9 = ac9 + re9;
                float porac1 = ac / tot1 * 100;
                float porac2 = ac2 / tot2 * 100;
                float porac3 = ac3 / tot3 * 100;
                float porac4 = ac4 / tot4 * 100;
                float porac5 = ac5 / tot5 * 100;
                float porac6 = ac6 / tot6 * 100;
                float porac7 = ac7 / tot7 * 100;
                float porac8 = ac8 / tot8 * 100;
                float porac9 = ac9 / tot9 * 100;
                float porre1 = re / tot1 * 100;
                float porre2 = re2 / tot2 * 100;
                float porre3 = re3 / tot3 * 100;
                float porre4 = re4 / tot4 * 100;
                float porre5 = re5 / tot5 * 100;
                float porre6 = re6 / tot6 * 100;
                float porre7 = re7 / tot7 * 100;
                float porre8 = re8 / tot8 * 100;
                float porre9 = re9 / tot9 * 100;

                label39.Text = porac1.ToString();
                label40.Text = porac2.ToString();
                label41.Text = porac3.ToString();
                label42.Text = porac4.ToString();
                label43.Text = porac5.ToString();
                label44.Text = porac6.ToString();
                label45.Text = porac7.ToString();
                label46.Text = porac8.ToString();
                label47.Text = porac9.ToString();
                label51.Text = porre1.ToString();
                label52.Text = porre2.ToString();
                label53.Text = porre3.ToString();
                label54.Text = porre4.ToString();
                label55.Text = porre5.ToString();
                label56.Text = porre6.ToString();
                label57.Text = porre7.ToString();
                label58.Text = porre8.ToString();
                label59.Text = porre9.ToString();
            }
            else if (comboBox1.SelectedIndex == 1)
            {

                string datos = File.ReadAllText("promedios.txt");
                string[] MatYProm = datos.Split('|');
                float ac = 0, ac2 = 0, ac3 = 0, ac4 = 0, ac5 = 0, ac6 = 0, ac7 = 0, ac8 = 0, ac9 = 0, ac10 = 0, ac11 = 0, re = 0, re2 = 0, re3 = 0, re4 = 0, re5 = 0, re6 = 0, re7 = 0, re8 = 0, re9 = 0, re10 = 0, re11 = 0;
                foreach (string grupo in MatYProm)
                {
                    string[] partes = grupo.Split(':');
                    string mat = partes[0].Trim();
                    string prom = partes[1].Trim();

                    if (mat == "Lengua y comunicacion II")
                    {
                        if (prom == "6" || prom == "7" || prom == "8" || prom == "9" || prom == "10")
                        {
                            ac++;
                        }
                        else if (prom == "5" || prom == "4" || prom == "3" || prom == "2" || prom == "1" || prom == "0")
                        {
                            re++;
                        }

                    }
                    else if (mat == "Ingles II")
                    {
                        if (prom == "6" || prom == "7" || prom == "8" || prom == "9" || prom == "10")
                        {
                            ac2++;
                        }
                        else if (prom == "5" || prom == "4" || prom == "3" || prom == "2" || prom == "1" || prom == "0")
                        {
                            re2++;
                        }

                    }
                    else if (mat == "Pensamiento matematico II")
                    {
                        if (prom == "6" || prom == "7" || prom == "8" || prom == "9" || prom == "10")
                        {
                            ac3++;
                        }
                        else if (prom == "5" || prom == "4" || prom == "3" || prom == "2" || prom == "1" || prom == "0")
                        {
                            re3++;
                        }

                    }
                    else if (mat == "Cultura digital II")
                    {
                        if (prom == "6" || prom == "7" || prom == "8" || prom == "9" || prom == "10")
                        {
                            ac4++;
                        }
                        else if (prom == "5" || prom == "4" || prom == "3" || prom == "2" || prom == "1" || prom == "0")
                        {
                            re4++;
                        }

                    }
                    else if (mat == "La conservacion de la energia")
                    {
                        if (prom == "6" || prom == "7" || prom == "8" || prom == "9" || prom == "10")
                        {
                            ac5++;
                        }
                        else if (prom == "5" || prom == "4" || prom == "3" || prom == "2" || prom == "1" || prom == "0")
                        {
                            re5++;
                        }

                    }
                    else if (mat == "Ciencias sociales II")
                    {
                        if (prom == "6" || prom == "7" || prom == "8" || prom == "9" || prom == "10")
                        {
                            ac6++;
                        }
                        else if (prom == "5" || prom == "4" || prom == "3" || prom == "2" || prom == "1" || prom == "0")
                        {
                            re6++;
                        }

                    }
                    else if (mat == "Recursos socioemocionales II")
                    {
                        if (prom == "6" || prom == "7" || prom == "8" || prom == "9" || prom == "10")
                        {
                            ac7++;
                        }
                        else if (prom == "5" || prom == "4" || prom == "3" || prom == "2" || prom == "1" || prom == "0")
                        {
                            re7++;
                        }

                    }
                    else if (mat == "Tutoria II")
                    {
                        if (prom == "6" || prom == "7" || prom == "8" || prom == "9" || prom == "10")
                        {
                            ac8++;
                        }
                        else if (prom == "5" || prom == "4" || prom == "3" || prom == "2" || prom == "1" || prom == "0")
                        {
                            re8++;
                        }

                    }
                    else if (mat == "Diseña software")
                    {
                        if (prom == "6" || prom == "7" || prom == "8" || prom == "9" || prom == "10")
                        {
                            ac9++;
                        }
                        else if (prom == "5" || prom == "4" || prom == "3" || prom == "2" || prom == "1" || prom == "0")
                        {
                            re9++;
                        }

                    }
                    else if (mat == "Codifica software")
                    {
                        if (prom == "6" || prom == "7" || prom == "8" || prom == "9" || prom == "10")
                        {
                            ac10++;
                        }
                        else if (prom == "5" || prom == "4" || prom == "3" || prom == "2" || prom == "1" || prom == "0")
                        {
                            re10++;
                        }

                    }
                    else if (mat == "Implementa software")
                    {
                        if (prom == "6" || prom == "7" || prom == "8" || prom == "9" || prom == "10")
                        {
                            ac11++;
                        }
                        else if (prom == "5" || prom == "4" || prom == "3" || prom == "2" || prom == "1" || prom == "0")
                        {
                            re11++;
                        }

                    }

                    label15.Text = ac.ToString();
                    label27.Text = re.ToString();
                    label16.Text = ac2.ToString();
                    label28.Text = re2.ToString();
                    label17.Text = ac3.ToString();
                    label29.Text = re3.ToString();
                    label18.Text = ac4.ToString();
                    label30.Text = re4.ToString();
                    label19.Text = ac5.ToString();
                    label31.Text = re5.ToString();
                    label20.Text = ac6.ToString();
                    label32.Text = re6.ToString();
                    label21.Text = ac7.ToString();
                    label33.Text = re7.ToString();
                    label22.Text = ac8.ToString();
                    label34.Text = re8.ToString();
                    label23.Text = ac9.ToString();
                    label35.Text = re9.ToString();
                    label24.Text = ac10.ToString();
                    label36.Text = re10.ToString();
                    label25.Text = ac11.ToString();
                    label37.Text = re11.ToString();

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
                    label13.Visible = true;
                    label24.Visible = true;
                    label25.Visible = true;
                    label36.Visible = true;
                    label37.Visible = true;


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

                    float tot1 = 0, tot2 = 0, tot3 = 0, tot4 = 0, tot5 = 0, tot6 = 0, tot7 = 0, tot8 = 0, tot9 = 0, tot10 = 0, tot11 = 0;

                    ac = float.Parse(label15.Text);
                    re = float.Parse(label27.Text);
                    ac2 = float.Parse(label16.Text);
                    re2 = float.Parse(label28.Text);
                    ac3 = float.Parse(label17.Text);
                    re3 = float.Parse(label29.Text);
                    ac4 = float.Parse(label18.Text);
                    re4 = float.Parse(label30.Text);
                    ac5 = float.Parse(label19.Text);
                    re5 = float.Parse(label31.Text);
                    ac6 = float.Parse(label20.Text);
                    re6 = float.Parse(label32.Text);
                    ac7 = float.Parse(label21.Text);
                    re7 = float.Parse(label33.Text);
                    ac8 = float.Parse(label22.Text);
                    re8 = float.Parse(label34.Text);
                    ac9 = float.Parse(label23.Text);
                    re9 = float.Parse(label35.Text);
                    ac10 = float.Parse(label24.Text);
                    re10 = float.Parse(label36.Text);
                    ac11 = float.Parse(label25.Text);
                    re11 = float.Parse(label37.Text);

                    tot1 = ac + re; tot2 = ac2 + re2; tot3 = ac3 + re3; tot4 = ac4 + re4; tot5 = ac5 + re5; tot6 = ac6 + re6; tot7 = ac7 + re7; tot8 = ac8 + re8; tot9 = ac9 + re9; tot10 = ac10 + re10; tot11 = ac11 + re11;
                    float porac1 = ac / tot1 * 100;
                    float porac2 = ac2 / tot2 * 100;
                    float porac3 = ac3 / tot3 * 100;
                    float porac4 = ac4 / tot4 * 100;
                    float porac5 = ac5 / tot5 * 100;
                    float porac6 = ac6 / tot6 * 100;
                    float porac7 = ac7 / tot7 * 100;
                    float porac8 = ac8 / tot8 * 100;
                    float porac9 = ac9 / tot9 * 100;
                    float porac10 = ac10 / tot10 * 100;
                    float porac11 = ac11 / tot11 * 100;
                    float porre1 = re / tot1 * 100;
                    float porre2 = re2 / tot2 * 100;
                    float porre3 = re3 / tot3 * 100;
                    float porre4 = re4 / tot4 * 100;
                    float porre5 = re5 / tot5 * 100;
                    float porre6 = re6 / tot6 * 100;
                    float porre7 = re7 / tot7 * 100;
                    float porre8 = re8 / tot8 * 100;
                    float porre9 = re9 / tot9 * 100;
                    float porre10 = re10 / tot10 * 100;
                    float porre11 = re11 / tot11 * 100;

                    label39.Text = porac1.ToString();
                    label40.Text = porac2.ToString();
                    label41.Text = porac3.ToString();
                    label42.Text = porac4.ToString();
                    label43.Text = porac5.ToString();
                    label44.Text = porac6.ToString();
                    label45.Text = porac7.ToString();
                    label46.Text = porac8.ToString();
                    label47.Text = porac9.ToString();
                    label48.Text = porac10.ToString();
                    label49.Text = porac11.ToString();
                    label51.Text = porre1.ToString();
                    label52.Text = porre2.ToString();
                    label53.Text = porre3.ToString();
                    label54.Text = porre4.ToString();
                    label55.Text = porre5.ToString();
                    label56.Text = porre6.ToString();
                    label57.Text = porre7.ToString();
                    label58.Text = porre8.ToString();
                    label59.Text = porre9.ToString();
                    label60.Text = porre10.ToString();
                    label61.Text = porre11.ToString();
                }
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                string datos = File.ReadAllText("promedios.txt");
                string[] MatYProm = datos.Split('|');
                float ac = 0, ac2 = 0, ac3 = 0, ac4 = 0, ac5 = 0, ac6 = 0, ac7 = 0, ac8 = 0, ac9 = 0, ac10 = 0, ac11 = 0, re = 0, re2 = 0, re3 = 0, re4 = 0, re5 = 0, re6 = 0, re7 = 0, re8 = 0, re9 = 0, re10 = 0, re11 = 0;
                foreach (string grupo in MatYProm)
                {
                    string[] partes = grupo.Split(':');
                    string mat = partes[0].Trim();
                    string prom = partes[1].Trim();

                    if (mat == "Lengua y comunicacion III")
                    {
                        if (prom == "6" || prom == "7" || prom == "8" || prom == "9" || prom == "10")
                        {
                            ac++;
                        }
                        else if (prom == "5" || prom == "4" || prom == "3" || prom == "2" || prom == "1" || prom == "0")
                        {
                            re++;
                        }

                    }
                    else if (mat == "Ingles III")
                    {
                        if (prom == "6" || prom == "7" || prom == "8" || prom == "9" || prom == "10")
                        {
                            ac2++;
                        }
                        else if (prom == "5" || prom == "4" || prom == "3" || prom == "2" || prom == "1" || prom == "0")
                        {
                            re2++;
                        }

                    }
                    else if (mat == "Pensamiento matematico III")
                    {
                        if (prom == "6" || prom == "7" || prom == "8" || prom == "9" || prom == "10")
                        {
                            ac3++;
                        }
                        else if (prom == "5" || prom == "4" || prom == "3" || prom == "2" || prom == "1" || prom == "0")
                        {
                            re3++;
                        }

                    }
                    else if (mat == "Ecosistemas")
                    {
                        if (prom == "6" || prom == "7" || prom == "8" || prom == "9" || prom == "10")
                        {
                            ac4++;
                        }
                        else if (prom == "5" || prom == "4" || prom == "3" || prom == "2" || prom == "1" || prom == "0")
                        {
                            re4++;
                        }

                    }
                    else if (mat == "Humanidades II")
                    {
                        if (prom == "6" || prom == "7" || prom == "8" || prom == "9" || prom == "10")
                        {
                            ac5++;
                        }
                        else if (prom == "5" || prom == "4" || prom == "3" || prom == "2" || prom == "1" || prom == "0")
                        {
                            re5++;
                        }

                    }
                    else if (mat == "Recursos socioemocionales III")
                    {
                        if (prom == "6" || prom == "7" || prom == "8" || prom == "9" || prom == "10")
                        {
                            ac6++;
                        }
                        else if (prom == "5" || prom == "4" || prom == "3" || prom == "2" || prom == "1" || prom == "0")
                        {
                            re6++;
                        }

                    }
                    else if (mat == "Taller de emprendedores I")
                    {
                        if (prom == "6" || prom == "7" || prom == "8" || prom == "9" || prom == "10")
                        {
                            ac7++;
                        }
                        else if (prom == "5" || prom == "4" || prom == "3" || prom == "2" || prom == "1" || prom == "0")
                        {
                            re7++;
                        }

                    }
                    else if (mat == "Activacion fisica")
                    {
                        if (prom == "6" || prom == "7" || prom == "8" || prom == "9" || prom == "10")
                        {
                            ac8++;
                        }
                        else if (prom == "5" || prom == "4" || prom == "3" || prom == "2" || prom == "1" || prom == "0")
                        {
                            re8++;
                        }

                    }
                    else if (mat == "Tutoria III")
                    {
                        if (prom == "6" || prom == "7" || prom == "8" || prom == "9" || prom == "10")
                        {
                            ac9++;
                        }
                        else if (prom == "5" || prom == "4" || prom == "3" || prom == "2" || prom == "1" || prom == "0")
                        {
                            re9++;
                        }

                    }
                    else if (mat == "Emplea frameworks")
                    {
                        if (prom == "6" || prom == "7" || prom == "8" || prom == "9" || prom == "10")
                        {
                            ac10++;
                        }
                        else if (prom == "5" || prom == "4" || prom == "3" || prom == "2" || prom == "1" || prom == "0")
                        {
                            re10++;
                        }

                    }
                    else if (mat == "Aplica metodologias agiles")
                    {
                        if (prom == "6" || prom == "7" || prom == "8" || prom == "9" || prom == "10")
                        {
                            ac11++;
                        }
                        else if (prom == "5" || prom == "4" || prom == "3" || prom == "2" || prom == "1" || prom == "0")
                        {
                            re11++;
                        }

                    }

                    label15.Text = ac.ToString();
                    label27.Text = re.ToString();
                    label16.Text = ac2.ToString();
                    label28.Text = re2.ToString();
                    label17.Text = ac3.ToString();
                    label29.Text = re3.ToString();
                    label18.Text = ac4.ToString();
                    label30.Text = re4.ToString();
                    label19.Text = ac5.ToString();
                    label31.Text = re5.ToString();
                    label20.Text = ac6.ToString();
                    label32.Text = re6.ToString();
                    label21.Text = ac7.ToString();
                    label33.Text = re7.ToString();
                    label22.Text = ac8.ToString();
                    label34.Text = re8.ToString();
                    label23.Text = ac9.ToString();
                    label35.Text = re9.ToString();
                    label24.Text = ac10.ToString();
                    label36.Text = re10.ToString();
                    label25.Text = ac11.ToString();
                    label37.Text = re11.ToString();
                }

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
                label13.Visible = true;
                label24.Visible = true;
                label25.Visible = true;
                label36.Visible = true;
                label37.Visible = true;

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

                float tot1 = 0, tot2 = 0, tot3 = 0, tot4 = 0, tot5 = 0, tot6 = 0, tot7 = 0, tot8 = 0, tot9 = 0, tot10 = 0, tot11 = 0;

                ac = float.Parse(label15.Text);
                re = float.Parse(label27.Text);
                ac2 = float.Parse(label16.Text);
                re2 = float.Parse(label28.Text);
                ac3 = float.Parse(label17.Text);
                re3 = float.Parse(label29.Text);
                ac4 = float.Parse(label18.Text);
                re4 = float.Parse(label30.Text);
                ac5 = float.Parse(label19.Text);
                re5 = float.Parse(label31.Text);
                ac6 = float.Parse(label20.Text);
                re6 = float.Parse(label32.Text);
                ac7 = float.Parse(label21.Text);
                re7 = float.Parse(label33.Text);
                ac8 = float.Parse(label22.Text);
                re8 = float.Parse(label34.Text);
                ac9 = float.Parse(label23.Text);
                re9 = float.Parse(label35.Text);
                ac10 = float.Parse(label24.Text);
                re10 = float.Parse(label36.Text);
                ac11 = float.Parse(label25.Text);
                re11 = float.Parse(label37.Text);

                tot1 = ac + re; tot2 = ac2 + re2; tot3 = ac3 + re3; tot4 = ac4 + re4; tot5 = ac5 + re5; tot6 = ac6 + re6; tot7 = ac7 + re7; tot8 = ac8 + re8; tot9 = ac9 + re9; tot10 = ac10 + re10; tot11 = ac11 + re11;
                float porac1 = ac / tot1 * 100;
                float porac2 = ac2 / tot2 * 100;
                float porac3 = ac3 / tot3 * 100;
                float porac4 = ac4 / tot4 * 100;
                float porac5 = ac5 / tot5 * 100;
                float porac6 = ac6 / tot6 * 100;
                float porac7 = ac7 / tot7 * 100;
                float porac8 = ac8 / tot8 * 100;
                float porac9 = ac9 / tot9 * 100;
                float porac10 = ac10 / tot10 * 100;
                float porac11 = ac11 / tot11 * 100;
                float porre1 = re / tot1 * 100;
                float porre2 = re2 / tot2 * 100;
                float porre3 = re3 / tot3 * 100;
                float porre4 = re4 / tot4 * 100;
                float porre5 = re5 / tot5 * 100;
                float porre6 = re6 / tot6 * 100;
                float porre7 = re7 / tot7 * 100;
                float porre8 = re8 / tot8 * 100;
                float porre9 = re9 / tot9 * 100;
                float porre10 = re10 / tot10 * 100;
                float porre11 = re11 / tot11 * 100;

                label39.Text = porac1.ToString();
                label40.Text = porac2.ToString();
                label41.Text = porac3.ToString();
                label42.Text = porac4.ToString();
                label43.Text = porac5.ToString();
                label44.Text = porac6.ToString();
                label45.Text = porac7.ToString();
                label46.Text = porac8.ToString();
                label47.Text = porac9.ToString();
                label48.Text = porac10.ToString();
                label49.Text = porac11.ToString();
                label51.Text = porre1.ToString();
                label52.Text = porre2.ToString();
                label53.Text = porre3.ToString();
                label54.Text = porre4.ToString();
                label55.Text = porre5.ToString();
                label56.Text = porre6.ToString();
                label57.Text = porre7.ToString();
                label58.Text = porre8.ToString();
                label59.Text = porre9.ToString();
                label60.Text = porre10.ToString();
                label61.Text = porre11.ToString();
            }            
        }
    }
}
