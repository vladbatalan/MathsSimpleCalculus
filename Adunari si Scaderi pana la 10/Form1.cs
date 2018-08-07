using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Adunari_si_Scaderi_pana_la_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rand = new Random();
        int a, b, semn, gameon = 0, mod = 1, t = 60;
        double r_corecte = 0, total_rasp = 0;

        private void Start_Click(object sender, EventArgs e)
        {
            R0.Enabled = true;
            R1.Enabled = true;
            R2.Enabled = true;
            R3.Enabled = true;
            R4.Enabled = true;
            R5.Enabled = true;
            R6.Enabled = true;
            R7.Enabled = true;
            R8.Enabled = true;
            R9.Enabled = true;
            R10.Enabled = true;
            t = 60;
            Intrebare.Visible = true;
            r_corecte = 0;
            total_rasp = 0;
            RCorecte.Text = "Raspunsuri corecte : " + 0;
            Nota_Finala.Visible = false;
            gameon = 1;
            a = rand.Next(0, 11);
            semn = rand.Next(1, 3);
            if (semn == 1)
            {
                b = rand.Next(0, 11 - a);
                Operatie.Text = "+";
            }
            else
            {
                if(semn==2)
                {
                    b = rand.Next(0, a);
                    Operatie.Text = "-";
                }
            }
            Primul_Numar.Text=""+a;
            Al_Doilea_Numar.Text=""+b;
            Primul_Numar.Visible=true;
            Al_Doilea_Numar.Visible=true;
            Operatie.Visible = true;
            Egalitate.Visible = true;
            if (mod == 2)
            {
                timer1.Enabled = true;
            }
        }
        private void R10_Click(object sender, EventArgs e)
        {
            if (gameon == 1)
            {
                Nota_Finala.Visible = false;
                total_rasp++;
                if (semn == 1)
                {
                    if (a + b == 10)
                    {
                        a = rand.Next(0, 11);
                        semn = rand.Next(1, 3);
                        if (semn == 1)
                        {
                            b = rand.Next(0, 11 - a);
                            Operatie.Text = "+";
                        }
                        else
                        {
                            if (semn == 2)
                            {
                                b = rand.Next(0, a);
                                Operatie.Text = "-";
                            }
                        }
                        Primul_Numar.Text = "" + a;
                        Al_Doilea_Numar.Text = "" + b;
                        Bara.ForeColor = Color.LimeGreen;
                        Bara.Text = "Corect!";
                        r_corecte++;
                        RCorecte.Text = "Raspunsuri corecte : " + r_corecte;

                    }
                    else
                    {
                        a = rand.Next(0, 11);
                        semn = rand.Next(1, 3);
                        if (semn == 1)
                        {
                            b = rand.Next(0, 11 - a);
                            Operatie.Text = "+";
                        }
                        else
                        {
                            if (semn == 2)
                            {
                                b = rand.Next(0, a);
                                Operatie.Text = "-";
                            }
                        }
                        Primul_Numar.Text = "" + a;
                        Al_Doilea_Numar.Text = "" + b;
                        Bara.ForeColor = Color.Red;
                        Bara.Text = "Gresit!";

                    }
                }
                else
                {
                    if (semn == 2)
                    {
                        if (a - b == 10)
                        {
                            a = rand.Next(0, 11);
                            semn = rand.Next(1, 3);
                            if (semn == 1)
                            {
                                b = rand.Next(0, 11 - a);
                                Operatie.Text = "+";
                            }
                            else
                            {
                                if (semn == 2)
                                {
                                    b = rand.Next(0, a);
                                    Operatie.Text = "-";
                                }
                            }
                            Primul_Numar.Text = "" + a;
                            Al_Doilea_Numar.Text = "" + b;
                            Bara.ForeColor = Color.LimeGreen;
                            Bara.Text = "Corect!";
                            r_corecte++;
                            RCorecte.Text = "Raspunsuri corecte : " + r_corecte;

                        }
                        else
                        {
                            a = rand.Next(0, 11);
                            semn = rand.Next(1, 3);
                            if (semn == 1)
                            {
                                b = rand.Next(0, 11 - a);
                                Operatie.Text = "+";
                            }
                            else
                            {
                                if (semn == 2)
                                {
                                    b = rand.Next(0, a);
                                    Operatie.Text = "-";
                                }
                            }
                            Primul_Numar.Text = "" + a;
                            Al_Doilea_Numar.Text = "" + b;
                            Bara.ForeColor = Color.Red;
                            Bara.Text = "Gresit!";

                        }
                    }
                }
            }
        }

        private void R9_Click(object sender, EventArgs e)
        {
            if (gameon == 1)
            {
                total_rasp++;
                Nota_Finala.Visible = false;
                if (semn == 1)
                {
                    if (a + b == 9)
                    {
                        a = rand.Next(0, 11);
                        semn = rand.Next(1, 3);
                        if (semn == 1)
                        {
                            b = rand.Next(0, 11 - a);
                            Operatie.Text = "+";
                        }
                        else
                        {
                            if (semn == 2)
                            {
                                b = rand.Next(0, a);
                                Operatie.Text = "-";
                            }
                        }
                        Primul_Numar.Text = "" + a;
                        Al_Doilea_Numar.Text = "" + b;
                        Bara.ForeColor = Color.LimeGreen;
                        Bara.Text = "Corect!";
                        r_corecte++;
                        RCorecte.Text = "Raspunsuri corecte : " + r_corecte;

                    }
                    else
                    {
                        a = rand.Next(0, 11);
                        semn = rand.Next(1, 3);
                        if (semn == 1)
                        {
                            b = rand.Next(0, 11 - a);
                            Operatie.Text = "+";
                        }
                        else
                        {
                            if (semn == 2)
                            {
                                b = rand.Next(0, a);
                                Operatie.Text = "-";
                            }
                        }
                        Primul_Numar.Text = "" + a;
                        Al_Doilea_Numar.Text = "" + b;
                        Bara.ForeColor = Color.Red;
                        Bara.Text = "Gresit!";

                    }
                }
                else
                {
                    if (semn == 2)
                    {
                        if (a - b == 9)
                        {
                            a = rand.Next(0, 11);
                            semn = rand.Next(1, 3);
                            if (semn == 1)
                            {
                                b = rand.Next(0, 11 - a);
                                Operatie.Text = "+";
                            }
                            else
                            {
                                if (semn == 2)
                                {
                                    b = rand.Next(0, a);
                                    Operatie.Text = "-";
                                }
                            }
                            Primul_Numar.Text = "" + a;
                            Al_Doilea_Numar.Text = "" + b;
                            Bara.ForeColor = Color.LimeGreen;
                            Bara.Text = "Corect!";
                            r_corecte++;
                            RCorecte.Text = "Raspunsuri corecte : " + r_corecte;

                        }
                        else
                        {
                            a = rand.Next(0, 11);
                            semn = rand.Next(1, 3);
                            if (semn == 1)
                            {
                                b = rand.Next(0, 11 - a);
                                Operatie.Text = "+";
                            }
                            else
                            {
                                if (semn == 2)
                                {
                                    b = rand.Next(0, a);
                                    Operatie.Text = "-";
                                }
                            }
                            Primul_Numar.Text = "" + a;
                            Al_Doilea_Numar.Text = "" + b;
                            Bara.ForeColor = Color.Red;
                            Bara.Text = "Gresit!";

                        }
                    }
                }
            }
        }

        private void R8_Click(object sender, EventArgs e)
        {
            if (gameon == 1)
            {
                total_rasp++;
                Nota_Finala.Visible = false;
                if (semn == 1)
                {
                    if (a + b == 8)
                    {
                        a = rand.Next(0, 11);
                        semn = rand.Next(1, 3);
                        if (semn == 1)
                        {
                            b = rand.Next(0, 11 - a);
                            Operatie.Text = "+";
                        }
                        else
                        {
                            if (semn == 2)
                            {
                                b = rand.Next(0, a);
                                Operatie.Text = "-";
                            }
                        }
                        Primul_Numar.Text = "" + a;
                        Al_Doilea_Numar.Text = "" + b;
                        Bara.ForeColor = Color.LimeGreen;
                        Bara.Text = "Corect!";
                        r_corecte++;
                        RCorecte.Text = "Raspunsuri corecte : " + r_corecte;

                    }
                    else
                    {
                        a = rand.Next(0, 11);
                        semn = rand.Next(1, 3);
                        if (semn == 1)
                        {
                            b = rand.Next(0, 11 - a);
                            Operatie.Text = "+";
                        }
                        else
                        {
                            if (semn == 2)
                            {
                                b = rand.Next(0, a);
                                Operatie.Text = "-";
                            }
                        }
                        Primul_Numar.Text = "" + a;
                        Al_Doilea_Numar.Text = "" + b;
                        Bara.ForeColor = Color.Red;
                        Bara.Text = "Gresit!";

                    }
                }
                else
                {
                    if (semn == 2)
                    {
                        if (a - b == 8)
                        {
                            a = rand.Next(0, 11);
                            semn = rand.Next(1, 3);
                            if (semn == 1)
                            {
                                b = rand.Next(0, 11 - a);
                                Operatie.Text = "+";
                            }
                            else
                            {
                                if (semn == 2)
                                {
                                    b = rand.Next(0, a);
                                    Operatie.Text = "-";
                                }
                            }
                            Primul_Numar.Text = "" + a;
                            Al_Doilea_Numar.Text = "" + b;
                            Bara.ForeColor = Color.LimeGreen;
                            Bara.Text = "Corect!";
                            r_corecte++;
                            RCorecte.Text = "Raspunsuri corecte : " + r_corecte;

                        }
                        else
                        {
                            a = rand.Next(0, 11);
                            semn = rand.Next(1, 3);
                            if (semn == 1)
                            {
                                b = rand.Next(0, 11 - a);
                                Operatie.Text = "+";
                            }
                            else
                            {
                                if (semn == 2)
                                {
                                    b = rand.Next(0, a);
                                    Operatie.Text = "-";
                                }
                            }
                            Primul_Numar.Text = "" + a;
                            Al_Doilea_Numar.Text = "" + b;
                            Bara.ForeColor = Color.Red;
                            Bara.Text = "Gresit!";

                        }
                    }
                }
            }
        }

        private void R7_Click(object sender, EventArgs e)
        {
            if (gameon == 1)
            {
                total_rasp++;
                Nota_Finala.Visible = false;
                if (semn == 1)
                {
                    if (a + b == 7)
                    {
                        a = rand.Next(0, 11);
                        semn = rand.Next(1, 3);
                        if (semn == 1)
                        {
                            b = rand.Next(0, 11 - a);
                            Operatie.Text = "+";
                        }
                        else
                        {
                            if (semn == 2)
                            {
                                b = rand.Next(0, a);
                                Operatie.Text = "-";
                            }
                        }
                        Primul_Numar.Text = "" + a;
                        Al_Doilea_Numar.Text = "" + b;
                        Bara.ForeColor = Color.LimeGreen;
                        Bara.Text = "Corect!";
                        r_corecte++;
                        RCorecte.Text = "Raspunsuri corecte : " + r_corecte;

                    }
                    else
                    {
                        a = rand.Next(0, 11);
                        semn = rand.Next(1, 3);
                        if (semn == 1)
                        {
                            b = rand.Next(0, 11 - a);
                            Operatie.Text = "+";
                        }
                        else
                        {
                            if (semn == 2)
                            {
                                b = rand.Next(0, a);
                                Operatie.Text = "-";
                            }
                        }
                        Primul_Numar.Text = "" + a;
                        Al_Doilea_Numar.Text = "" + b;
                        Bara.ForeColor = Color.Red;
                        Bara.Text = "Gresit!";

                    }
                }
                else
                {
                    if (semn == 2)
                    {
                        if (a - b == 7)
                        {
                            a = rand.Next(0, 11);
                            semn = rand.Next(1, 3);
                            if (semn == 1)
                            {
                                b = rand.Next(0, 11 - a);
                                Operatie.Text = "+";
                            }
                            else
                            {
                                if (semn == 2)
                                {
                                    b = rand.Next(0, a);
                                    Operatie.Text = "-";
                                }
                            }
                            Primul_Numar.Text = "" + a;
                            Al_Doilea_Numar.Text = "" + b;
                            Bara.ForeColor = Color.LimeGreen;
                            Bara.Text = "Corect!";
                            r_corecte++;
                            RCorecte.Text = "Raspunsuri corecte : " + r_corecte;

                        }
                        else
                        {
                            a = rand.Next(0, 11);
                            semn = rand.Next(1, 3);
                            if (semn == 1)
                            {
                                b = rand.Next(0, 11 - a);
                                Operatie.Text = "+";
                            }
                            else
                            {
                                if (semn == 2)
                                {
                                    b = rand.Next(0, a);
                                    Operatie.Text = "-";
                                }
                            }
                            Primul_Numar.Text = "" + a;
                            Al_Doilea_Numar.Text = "" + b;
                            Bara.ForeColor = Color.Red;
                            Bara.Text = "Gresit!";

                        }
                    }
                }
            }
        }

        private void R6_Click(object sender, EventArgs e)
        {
            if (gameon == 1)
            {
                total_rasp++;
                Nota_Finala.Visible = false;
                if (semn == 1)
                {
                    if (a + b == 6)
                    {
                        a = rand.Next(0, 11);
                        semn = rand.Next(1, 3);
                        if (semn == 1)
                        {
                            b = rand.Next(0, 11 - a);
                            Operatie.Text = "+";
                        }
                        else
                        {
                            if (semn == 2)
                            {
                                b = rand.Next(0, a);
                                Operatie.Text = "-";
                            }
                        }
                        Primul_Numar.Text = "" + a;
                        Al_Doilea_Numar.Text = "" + b;
                        Bara.ForeColor = Color.LimeGreen;
                        Bara.Text = "Corect!";
                        r_corecte++;
                        RCorecte.Text = "Raspunsuri corecte : " + r_corecte;

                    }
                    else
                    {
                        a = rand.Next(0, 11);
                        semn = rand.Next(1, 3);
                        if (semn == 1)
                        {
                            b = rand.Next(0, 11 - a);
                            Operatie.Text = "+";
                        }
                        else
                        {
                            if (semn == 2)
                            {
                                b = rand.Next(0, a);
                                Operatie.Text = "-";
                            }
                        }
                        Primul_Numar.Text = "" + a;
                        Al_Doilea_Numar.Text = "" + b;
                        Bara.ForeColor = Color.Red;
                        Bara.Text = "Gresit!";

                    }
                }
                else
                {
                    if (semn == 2)
                    {
                        if (a - b == 6)
                        {
                            a = rand.Next(0, 11);
                            semn = rand.Next(1, 3);
                            if (semn == 1)
                            {
                                b = rand.Next(0, 11 - a);
                                Operatie.Text = "+";
                            }
                            else
                            {
                                if (semn == 2)
                                {
                                    b = rand.Next(0, a);
                                    Operatie.Text = "-";
                                }
                            }
                            Primul_Numar.Text = "" + a;
                            Al_Doilea_Numar.Text = "" + b;
                            Bara.ForeColor = Color.LimeGreen;
                            Bara.Text = "Corect!";
                            r_corecte++;
                            RCorecte.Text = "Raspunsuri corecte : " + r_corecte;

                        }
                        else
                        {
                            a = rand.Next(0, 11);
                            semn = rand.Next(1, 3);
                            if (semn == 1)
                            {
                                b = rand.Next(0, 11 - a);
                                Operatie.Text = "+";
                            }
                            else
                            {
                                if (semn == 2)
                                {
                                    b = rand.Next(0, a);
                                    Operatie.Text = "-";
                                }
                            }
                            Primul_Numar.Text = "" + a;
                            Al_Doilea_Numar.Text = "" + b;
                            Bara.ForeColor = Color.Red;
                            Bara.Text = "Gresit!";

                        }
                    }
                }
            }
        }

        private void R5_Click(object sender, EventArgs e)
        {
            if (gameon == 1)
            {
                total_rasp++;
                Nota_Finala.Visible = false;
                if (semn == 1)
                {
                    if (a + b == 5)
                    {
                        a = rand.Next(0, 11);
                        semn = rand.Next(1, 3);
                        if (semn == 1)
                        {
                            b = rand.Next(0, 11 - a);
                            Operatie.Text = "+";
                        }
                        else
                        {
                            if (semn == 2)
                            {
                                b = rand.Next(0, a);
                                Operatie.Text = "-";
                            }
                        }
                        Primul_Numar.Text = "" + a;
                        Al_Doilea_Numar.Text = "" + b;
                        Bara.ForeColor = Color.LimeGreen;
                        Bara.Text = "Corect!";
                        r_corecte++;
                        RCorecte.Text = "Raspunsuri corecte : " + r_corecte;

                    }
                    else
                    {
                        a = rand.Next(0, 11);
                        semn = rand.Next(1, 3);
                        if (semn == 1)
                        {
                            b = rand.Next(0, 11 - a);
                            Operatie.Text = "+";
                        }
                        else
                        {
                            if (semn == 2)
                            {
                                b = rand.Next(0, a);
                                Operatie.Text = "-";
                            }
                        }
                        Primul_Numar.Text = "" + a;
                        Al_Doilea_Numar.Text = "" + b;
                        Bara.ForeColor = Color.Red;
                        Bara.Text = "Gresit!";

                    }
                }
                else
                {
                    if (semn == 2)
                    {
                        if (a - b == 5)
                        {
                            a = rand.Next(0, 11);
                            semn = rand.Next(1, 3);
                            if (semn == 1)
                            {
                                b = rand.Next(0, 11 - a);
                                Operatie.Text = "+";
                            }
                            else
                            {
                                if (semn == 2)
                                {
                                    b = rand.Next(0, a);
                                    Operatie.Text = "-";
                                }
                            }
                            Primul_Numar.Text = "" + a;
                            Al_Doilea_Numar.Text = "" + b;
                            Bara.ForeColor = Color.LimeGreen;
                            Bara.Text = "Corect!";
                            r_corecte++;
                            RCorecte.Text = "Raspunsuri corecte : " + r_corecte;

                        }
                        else
                        {
                            a = rand.Next(0, 11);
                            semn = rand.Next(1, 3);
                            if (semn == 1)
                            {
                                b = rand.Next(0, 11 - a);
                                Operatie.Text = "+";
                            }
                            else
                            {
                                if (semn == 2)
                                {
                                    b = rand.Next(0, a);
                                    Operatie.Text = "-";
                                }
                            }
                            Primul_Numar.Text = "" + a;
                            Al_Doilea_Numar.Text = "" + b;
                            Bara.ForeColor = Color.Red;
                            Bara.Text = "Gresit!";

                        }
                    }
                }
            }
        }

        private void R4_Click(object sender, EventArgs e)
        {
            if (gameon == 1)
            {
                total_rasp++;
                Nota_Finala.Visible = false;
                if (semn == 1)
                {
                    if (a + b == 4)
                    {
                        a = rand.Next(0, 11);
                        semn = rand.Next(1, 3);
                        if (semn == 1)
                        {
                            b = rand.Next(0, 11 - a);
                            Operatie.Text = "+";
                        }
                        else
                        {
                            if (semn == 2)
                            {
                                b = rand.Next(0, a);
                                Operatie.Text = "-";
                            }
                        }
                        Primul_Numar.Text = "" + a;
                        Al_Doilea_Numar.Text = "" + b;
                        Bara.ForeColor = Color.LimeGreen;
                        Bara.Text = "Corect!";
                        r_corecte++;
                        RCorecte.Text = "Raspunsuri corecte : " + r_corecte;

                    }
                    else
                    {
                        a = rand.Next(0, 11);
                        semn = rand.Next(1, 3);
                        if (semn == 1)
                        {
                            b = rand.Next(0, 11 - a);
                            Operatie.Text = "+";
                        }
                        else
                        {
                            if (semn == 2)
                            {
                                b = rand.Next(0, a);
                                Operatie.Text = "-";
                            }
                        }
                        Primul_Numar.Text = "" + a;
                        Al_Doilea_Numar.Text = "" + b;
                        Bara.ForeColor = Color.Red;
                        Bara.Text = "Gresit!";

                    }
                }
                else
                {
                    if (semn == 2)
                    {
                        if (a - b == 4)
                        {
                            a = rand.Next(0, 11);
                            semn = rand.Next(1, 3);
                            if (semn == 1)
                            {
                                b = rand.Next(0, 11 - a);
                                Operatie.Text = "+";
                            }
                            else
                            {
                                if (semn == 2)
                                {
                                    b = rand.Next(0, a);
                                    Operatie.Text = "-";
                                }
                            }
                            Primul_Numar.Text = "" + a;
                            Al_Doilea_Numar.Text = "" + b;
                            Bara.ForeColor = Color.LimeGreen;
                            Bara.Text = "Corect!";
                            r_corecte++;
                            RCorecte.Text = "Raspunsuri corecte : " + r_corecte;

                        }
                        else
                        {
                            a = rand.Next(0, 11);
                            semn = rand.Next(1, 3);
                            if (semn == 1)
                            {
                                b = rand.Next(0, 11 - a);
                                Operatie.Text = "+";
                            }
                            else
                            {
                                if (semn == 2)
                                {
                                    b = rand.Next(0, a);
                                    Operatie.Text = "-";
                                }
                            }
                            Primul_Numar.Text = "" + a;
                            Al_Doilea_Numar.Text = "" + b;
                            Bara.ForeColor = Color.Red;
                            Bara.Text = "Gresit!";

                        }
                    }
                }
            }
        }

        private void R3_Click(object sender, EventArgs e)
        {
            if (gameon == 1)
            {
                total_rasp++;
                Nota_Finala.Visible = false;
                if (semn == 1)
                {
                    if (a + b == 3)
                    {
                        a = rand.Next(0, 11);
                        semn = rand.Next(1, 3);
                        if (semn == 1)
                        {
                            b = rand.Next(0, 11 - a);
                            Operatie.Text = "+";
                        }
                        else
                        {
                            if (semn == 2)
                            {
                                b = rand.Next(0, a);
                                Operatie.Text = "-";
                            }
                        }
                        Primul_Numar.Text = "" + a;
                        Al_Doilea_Numar.Text = "" + b;
                        Bara.ForeColor = Color.LimeGreen;
                        Bara.Text = "Corect!";
                        r_corecte++;
                        RCorecte.Text = "Raspunsuri corecte : " + r_corecte;

                    }
                    else
                    {
                        a = rand.Next(0, 11);
                        semn = rand.Next(1, 3);
                        if (semn == 1)
                        {
                            b = rand.Next(0, 11 - a);
                            Operatie.Text = "+";
                        }
                        else
                        {
                            if (semn == 2)
                            {
                                b = rand.Next(0, a);
                                Operatie.Text = "-";
                            }
                        }
                        Primul_Numar.Text = "" + a;
                        Al_Doilea_Numar.Text = "" + b;
                        Bara.ForeColor = Color.Red;
                        Bara.Text = "Gresit!";

                    }
                }
                else
                {
                    if (semn == 2)
                    {
                        if (a - b == 3)
                        {
                            a = rand.Next(0, 11);
                            semn = rand.Next(1, 3);
                            if (semn == 1)
                            {
                                b = rand.Next(0, 11 - a);
                                Operatie.Text = "+";
                            }
                            else
                            {
                                if (semn == 2)
                                {
                                    b = rand.Next(0, a);
                                    Operatie.Text = "-";
                                }
                            }
                            Primul_Numar.Text = "" + a;
                            Al_Doilea_Numar.Text = "" + b;
                            Bara.ForeColor = Color.LimeGreen;
                            Bara.Text = "Corect!";
                            r_corecte++;
                            RCorecte.Text = "Raspunsuri corecte : " + r_corecte;

                        }
                        else
                        {
                            a = rand.Next(0, 11);
                            semn = rand.Next(1, 3);
                            if (semn == 1)
                            {
                                b = rand.Next(0, 11 - a);
                                Operatie.Text = "+";
                            }
                            else
                            {
                                if (semn == 2)
                                {
                                    b = rand.Next(0, a);
                                    Operatie.Text = "-";
                                }
                            }
                            Primul_Numar.Text = "" + a;
                            Al_Doilea_Numar.Text = "" + b;
                            Bara.ForeColor = Color.Red;
                            Bara.Text = "Gresit!";

                        }
                    }
                }
            }
        }

        private void R2_Click(object sender, EventArgs e)
        {
            if (gameon == 1)
            {
                total_rasp++;
                Nota_Finala.Visible = false;
                if (semn == 1)
                {
                    if (a + b == 2)
                    {
                        a = rand.Next(0, 11);
                        semn = rand.Next(1, 3);
                        if (semn == 1)
                        {
                            b = rand.Next(0, 11 - a);
                            Operatie.Text = "+";
                        }
                        else
                        {
                            if (semn == 2)
                            {
                                b = rand.Next(0, a);
                                Operatie.Text = "-";
                            }
                        }
                        Primul_Numar.Text = "" + a;
                        Al_Doilea_Numar.Text = "" + b;
                        Bara.ForeColor = Color.LimeGreen;
                        Bara.Text = "Corect!";
                        r_corecte++;
                        RCorecte.Text = "Raspunsuri corecte : " + r_corecte;

                    }
                    else
                    {
                        a = rand.Next(0, 11);
                        semn = rand.Next(1, 3);
                        if (semn == 1)
                        {
                            b = rand.Next(0, 11 - a);
                            Operatie.Text = "+";
                        }
                        else
                        {
                            if (semn == 2)
                            {
                                b = rand.Next(0, a);
                                Operatie.Text = "-";
                            }
                        }
                        Primul_Numar.Text = "" + a;
                        Al_Doilea_Numar.Text = "" + b;
                        Bara.ForeColor = Color.Red;
                        Bara.Text = "Gresit!";

                    }
                }
                else
                {
                    if (semn == 2)
                    {
                        if (a - b == 2)
                        {
                            a = rand.Next(0, 11);
                            semn = rand.Next(1, 3);
                            if (semn == 1)
                            {
                                b = rand.Next(0, 11 - a);
                                Operatie.Text = "+";
                            }
                            else
                            {
                                if (semn == 2)
                                {
                                    b = rand.Next(0, a);
                                    Operatie.Text = "-";
                                }
                            }
                            Primul_Numar.Text = "" + a;
                            Al_Doilea_Numar.Text = "" + b;
                            Bara.ForeColor = Color.LimeGreen;
                            Bara.Text = "Corect!";
                            r_corecte++;
                            RCorecte.Text = "Raspunsuri corecte : " + r_corecte;

                        }
                        else
                        {
                            a = rand.Next(0, 11);
                            semn = rand.Next(1, 3);
                            if (semn == 1)
                            {
                                b = rand.Next(0, 11 - a);
                                Operatie.Text = "+";
                            }
                            else
                            {
                                if (semn == 2)
                                {
                                    b = rand.Next(0, a);
                                    Operatie.Text = "-";
                                }
                            }
                            Primul_Numar.Text = "" + a;
                            Al_Doilea_Numar.Text = "" + b;
                            Bara.ForeColor = Color.Red;
                            Bara.Text = "Gresit!";

                        }
                    }
                }
            }
        }

        private void R1_Click(object sender, EventArgs e)
        {
            if (gameon == 1)
            {
                total_rasp++;
                Nota_Finala.Visible = false;
                if (semn == 1)
                {
                    if (a + b == 1)
                    {
                        a = rand.Next(0, 11);
                        semn = rand.Next(1, 3);
                        if (semn == 1)
                        {
                            b = rand.Next(0, 11 - a);
                            Operatie.Text = "+";
                        }
                        else
                        {
                            if (semn == 2)
                            {
                                b = rand.Next(0, a);
                                Operatie.Text = "-";
                            }
                        }
                        Primul_Numar.Text = "" + a;
                        Al_Doilea_Numar.Text = "" + b;
                        Bara.ForeColor = Color.LimeGreen;
                        Bara.Text = "Corect!";
                        r_corecte++;
                        RCorecte.Text = "Raspunsuri corecte : " + r_corecte;

                    }
                    else
                    {
                        a = rand.Next(0, 11);
                        semn = rand.Next(1, 3);
                        if (semn == 1)
                        {
                            b = rand.Next(0, 11 - a);
                            Operatie.Text = "+";
                        }
                        else
                        {
                            if (semn == 2)
                            {
                                b = rand.Next(0, a);
                                Operatie.Text = "-";
                            }
                        }
                        Primul_Numar.Text = "" + a;
                        Al_Doilea_Numar.Text = "" + b;
                        Bara.ForeColor = Color.Red;
                        Bara.Text = "Gresit!";

                    }
                }
                else
                {
                    if (semn == 2)
                    {
                        if (a - b == 1)
                        {
                            a = rand.Next(0, 11);
                            semn = rand.Next(1, 3);
                            if (semn == 1)
                            {
                                b = rand.Next(0, 11 - a);
                                Operatie.Text = "+";
                            }
                            else
                            {
                                if (semn == 2)
                                {
                                    b = rand.Next(0, a);
                                    Operatie.Text = "-";
                                }
                            }
                            Primul_Numar.Text = "" + a;
                            Al_Doilea_Numar.Text = "" + b;
                            Bara.ForeColor = Color.LimeGreen;
                            Bara.Text = "Corect!";
                            r_corecte++;
                            RCorecte.Text = "Raspunsuri corecte : " + r_corecte;

                        }
                        else
                        {
                            a = rand.Next(0, 11);
                            semn = rand.Next(1, 3);
                            if (semn == 1)
                            {
                                b = rand.Next(0, 11 - a);
                                Operatie.Text = "+";
                            }
                            else
                            {
                                if (semn == 2)
                                {
                                    b = rand.Next(0, a);
                                    Operatie.Text = "-";
                                }
                            }
                            Primul_Numar.Text = "" + a;
                            Al_Doilea_Numar.Text = "" + b;
                            Bara.ForeColor = Color.Red;
                            Bara.Text = "Gresit!";

                        }
                    }
                }
            }
        }
        private void R0_Click(object sender, EventArgs e)
        {
            if (gameon == 1)
            {
                total_rasp++;
                Nota_Finala.Visible = false;
                if (semn == 1)
                {
                    if (a + b == 0)
                    {
                        a = rand.Next(0, 11);
                        semn = rand.Next(1, 3);
                        if (semn == 1)
                        {
                            b = rand.Next(0, 11 - a);
                            Operatie.Text = "+";
                        }
                        else
                        {
                            if (semn == 2)
                            {
                                b = rand.Next(0, a);
                                Operatie.Text = "-";
                            }
                        }
                        Primul_Numar.Text = "" + a;
                        Al_Doilea_Numar.Text = "" + b;
                        Bara.ForeColor = Color.LimeGreen;
                        Bara.Text = "Corect!";
                        r_corecte++;
                        RCorecte.Text = "Raspunsuri corecte : " + r_corecte;

                    }
                    else
                    {
                        a = rand.Next(0, 11);
                        semn = rand.Next(1, 3);
                        if (semn == 1)
                        {
                            b = rand.Next(0, 11 - a);
                            Operatie.Text = "+";
                        }
                        else
                        {
                            if (semn == 2)
                            {
                                b = rand.Next(0, a);
                                Operatie.Text = "-";
                            }
                        }
                        Primul_Numar.Text = "" + a;
                        Al_Doilea_Numar.Text = "" + b;
                        Bara.ForeColor = Color.Red;
                        Bara.Text = "Gresit!";

                    }
                }
                else
                {
                    if (semn == 2)
                    {
                        if (a - b == 0)
                        {
                            a = rand.Next(0, 11);
                            semn = rand.Next(1, 3);
                            if (semn == 1)
                            {
                                b = rand.Next(0, 11 - a);
                                Operatie.Text = "+";
                            }
                            else
                            {
                                if (semn == 2)
                                {
                                    b = rand.Next(0, a);
                                    Operatie.Text = "-";
                                }
                            }
                            Primul_Numar.Text = "" + a;
                            Al_Doilea_Numar.Text = "" + b;
                            Bara.ForeColor = Color.LimeGreen;
                            Bara.Text = "Corect!";
                            r_corecte++;
                            RCorecte.Text = "Raspunsuri corecte : " + r_corecte;

                        }
                        else
                        {
                            a = rand.Next(0, 11);
                            semn = rand.Next(1, 3);
                            if (semn == 1)
                            {
                                b = rand.Next(0, 11 - a);
                                Operatie.Text = "+";
                            }
                            else
                            {
                                if (semn == 2)
                                {
                                    b = rand.Next(0, a);
                                    Operatie.Text = "-";
                                }
                            }
                            Primul_Numar.Text = "" + a;
                            Al_Doilea_Numar.Text = "" + b;
                            Bara.ForeColor = Color.Red;
                            Bara.Text = "Gresit!";

                        }
                    }
                }
            }
        }

        private void Nota_Click(object sender, EventArgs e)
        {
            if (total_rasp != 0)
            {
                double c;
                c = ((r_corecte * 100) / total_rasp / 10) - (int)((r_corecte * 100) / total_rasp / 10);
                if (c < 0.5)
                {
                    c = (int)((r_corecte * 100) / total_rasp / 10);
                }
                else
                {
                    if (c >= 0.5)
                    {
                        c = (int)((r_corecte * 100) / total_rasp / 10)+1;
                    }
                }
                Nota_Finala.Text = "Nota : " + c;
                Nota_Finala.Visible = true;
            }
        }

        private void Mod_Change_Click(object sender, EventArgs e)
        {
            if (mod == 1)
            {
                mod = 2;
                Mod_Change.Text = "Mod Clasic";
                Nota.Text = "Timp Rămas : 60";
                Nota.Enabled = false;
                Intrebare.Visible = true;
                r_corecte = 0;
                total_rasp = 0;
                RCorecte.Text = "Raspunsuri corecte : " + 0;
                t = 60;
                Nota_Finala.Visible = false;
                gameon = 1;
                a = rand.Next(0, 11);
                semn = rand.Next(1, 3);
                if (semn == 1)
                {
                    b = rand.Next(0, 11 - a);
                    Operatie.Text = "+";
                }
                else
                {
                    if (semn == 2)
                    {
                        b = rand.Next(0, a);
                        Operatie.Text = "-";
                    }
                }
                Primul_Numar.Text = "" + a;
                Al_Doilea_Numar.Text = "" + b;
                Primul_Numar.Visible = true;
                Al_Doilea_Numar.Visible = true;
                Operatie.Visible = true;
                Egalitate.Visible = true;
                timer1.Enabled = true;
            }
            else
            {
                if (mod == 2)
                {
                    R0.Enabled = true;
                    R1.Enabled = true;
                    R2.Enabled = true;
                    R3.Enabled = true;
                    R4.Enabled = true;
                    R5.Enabled = true;
                    R6.Enabled = true;
                    R7.Enabled = true;
                    R8.Enabled = true;
                    R9.Enabled = true;
                    R10.Enabled = true;
                    timer1.Enabled = false;
                    mod = 1;
                    Mod_Change.Text = "Mod Examen";
                    Nota.Text = "Vreau să-mi văd nota";
                    Nota.Enabled = true;
                    Intrebare.Visible = true;
                    r_corecte = 0;
                    total_rasp = 0;
                    RCorecte.Text = "Raspunsuri corecte : " + 0;
                    t = 60;
                    Nota_Finala.Visible = false;
                    gameon = 1;
                    a = rand.Next(0, 11);
                    semn = rand.Next(1, 3);
                    if (semn == 1)
                    {
                        b = rand.Next(0, 11 - a);
                        Operatie.Text = "+";
                    }
                    else
                    {
                        if (semn == 2)
                        {
                            b = rand.Next(0, a);
                            Operatie.Text = "-";
                        }
                    }
                    Primul_Numar.Text = "" + a;
                    Al_Doilea_Numar.Text = "" + b;
                    Primul_Numar.Visible = true;
                    Al_Doilea_Numar.Visible = true;
                    Operatie.Visible = true;
                    Egalitate.Visible = true;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t--;
            Nota.Text = "Timp Rămas : " + t;
            if (t == 0)
            {
                R0.Enabled = false;
                R1.Enabled = false;
                R2.Enabled = false;
                R3.Enabled = false;
                R4.Enabled = false;
                R5.Enabled = false;
                R6.Enabled = false;
                R7.Enabled = false;
                R8.Enabled = false;
                R9.Enabled = false;
                R10.Enabled = false;
                timer1.Enabled = false;
                if (total_rasp != 0)
                {
                    double c;
                    c = ((r_corecte * 100) / total_rasp / 10) - (int)((r_corecte * 100) / total_rasp / 10);
                    if (c < 0.5)
                    {
                        c = (int)((r_corecte * 100) / total_rasp / 10);
                    }
                    else
                    {
                        if (c >= 0.5)
                        {
                            c = (int)((r_corecte * 100) / total_rasp / 10) + 1;
                        }
                    }
                    if (c == 0)
                    {
                        c = 1;
                    }
                    Nota_Finala.Text = "Nota : " + c;
                    Nota_Finala.Visible = true;
                }
                else
                {
                    if (total_rasp == 0)
                    {
                        Nota_Finala.Text = "Nota : " + 0;
                        Nota_Finala.Visible = true;
                    }
                }
            }
        }

       


        

        
    }
}
