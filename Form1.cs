using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace symulator_procesora
{
    public partial class Form1 : Form
    {
        byte ah = 0, al = 0, bh = 0, bl = 0, ch = 0, cl = 0, dh = 0, dl = 0;
        int linia = 0;
        bool przypisanie, dodawanie, odejmowanie;
        string gdzie, co;

        public Form1()
        {
            InitializeComponent();

            rozkaz.Items.Add("MOV");
            rozkaz.Items.Add("ADD");
            rozkaz.Items.Add("SUB");
            adresowanie.Items.Add("Rejestrowe");
            adresowanie.Items.Add("Natychmiastowe");

            rejestr.Items.Add("AH");
            rejestr.Items.Add("AL");
            rejestr.Items.Add("BH");
            rejestr.Items.Add("BL");
            rejestr.Items.Add("CH");
            rejestr.Items.Add("CL");
            rejestr.Items.Add("DH");
            rejestr.Items.Add("DL");

            adres.Items.Add("AH");
            adres.Items.Add("AL");
            adres.Items.Add("BH");
            adres.Items.Add("BL");
            adres.Items.Add("CH");
            adres.Items.Add("CL");
            adres.Items.Add("DH");
            adres.Items.Add("DL");

            AH.Text = Convert.ToString(ah, 2).PadLeft(8, '0');
            BH.Text = Convert.ToString(bh, 2).PadLeft(8, '0');
            CH.Text = Convert.ToString(ch, 2).PadLeft(8, '0');
            DH.Text = Convert.ToString(dh, 2).PadLeft(8, '0');
            AL.Text = Convert.ToString(al, 2).PadLeft(8, '0');
            BL.Text = Convert.ToString(bl, 2).PadLeft(8, '0');
            CL.Text = Convert.ToString(cl, 2).PadLeft(8, '0');
            DL.Text = Convert.ToString(dl, 2).PadLeft(8, '0');

            adres.Enabled = false;
            wartosc.Enabled = false;
            rejestr.Enabled = false;
            adresowanie.Enabled = false;
            okButton.Enabled = false;
        }

        private void rozkaz_SelectedIndexChanged(object sender, EventArgs e)
        {
            wiersz.Text = wiersz.Text + rozkaz.SelectedItem + " ";
            sztuczka.Text = sztuczka.Text + rozkaz.SelectedItem + " ";

                rejestr.Enabled = true;
                rozkaz.Enabled = false;
                krokButton.Enabled = true;
        }
        //Do pola sztuczka zapisywana zawartość wybranego przez użytkownika rejestru 
        //zamiast jego nazw. Dzięki temu w dalszych krokach przyjmujemy do obliczeń jedynie liczby
        private void rejestr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rejestr.SelectedIndex == 0)
            {
                wiersz.Text = wiersz.Text + "AH ";
                sztuczka.Text = sztuczka.Text + "AH ";
            }
            if (rejestr.SelectedIndex == 1)
            {
                wiersz.Text = wiersz.Text + "AL ";
                sztuczka.Text = sztuczka.Text + "AL ";
            }
            if (rejestr.SelectedIndex == 2)
            {
                wiersz.Text = wiersz.Text + "BH ";
                sztuczka.Text = sztuczka.Text + "BH ";
            }
            if (rejestr.SelectedIndex == 3)
            {
                wiersz.Text = wiersz.Text + "BL ";
                sztuczka.Text = sztuczka.Text + "BL ";
            }
            if (rejestr.SelectedIndex == 4)
            {
                wiersz.Text = wiersz.Text + "CH ";
                sztuczka.Text = sztuczka.Text + "CH ";
            }
            if (rejestr.SelectedIndex == 5)
            {
                wiersz.Text = wiersz.Text + "CL ";
                sztuczka.Text = sztuczka.Text + "CL ";
            }
            if (rejestr.SelectedIndex == 6)
            {
                wiersz.Text = wiersz.Text + "DH ";
                sztuczka.Text = sztuczka.Text + "DH ";
            }
            if (rejestr.SelectedIndex == 7)
            {
                wiersz.Text = wiersz.Text + "DL ";
                sztuczka.Text = sztuczka.Text + "DL ";
            }
            else
            {
                adresowanie.Enabled = true;
                rejestr.Enabled = false;
            }
        }

     

        private void adresowanie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (adresowanie.SelectedIndex == 0)
            {
                adres.Enabled = true;
                wartosc.Enabled = false;
            }
            if (adresowanie.SelectedIndex == 1)
            {
                adres.Enabled = false;
                wartosc.Enabled = true;
                okButton.Enabled = true;
            }
            adresowanie.Enabled = false;
        }

        
        private void adres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (adres.SelectedIndex == 0)
            {
                wiersz.Text = wiersz.Text + "AH" + "\r\n";
                sztuczka.Text = sztuczka.Text + Convert.ToString(ah) + "\r\n";
            }
            if (adres.SelectedIndex == 1)
            {
                wiersz.Text = wiersz.Text + "AL" + "\r\n";
                sztuczka.Text = sztuczka.Text + Convert.ToString(al) + "\r\n";
            }
            if (adres.SelectedIndex == 2)
            {
                wiersz.Text = wiersz.Text + "BH" + "\r\n";
                sztuczka.Text = sztuczka.Text + Convert.ToString(bh) + "\r\n";
            }
            if (adres.SelectedIndex == 3)
            {
                wiersz.Text = wiersz.Text + "BL" + "\r\n";
                sztuczka.Text = sztuczka.Text + Convert.ToString(bl) + "\r\n";
            }
            if (adres.SelectedIndex == 4)
            {
                wiersz.Text = wiersz.Text + "CH" + "\r\n";
                sztuczka.Text = sztuczka.Text + Convert.ToString(ch) + "\r\n";
            }
            if (adres.SelectedIndex == 5)
            {
                wiersz.Text = wiersz.Text + "CL" + "\r\n";
                sztuczka.Text = sztuczka.Text + Convert.ToString(cl) + "\r\n";
            }
            if (adres.SelectedIndex == 6)
            {
                wiersz.Text = wiersz.Text + "DH" + "\r\n";
                sztuczka.Text = sztuczka.Text + Convert.ToString(dh) + "\r\n";
            }
            if (adres.SelectedIndex == 7)
            {
                wiersz.Text = wiersz.Text + "DL" + "\r\n";
                sztuczka.Text = sztuczka.Text + Convert.ToString(dl) + "\r\n";
            }
            adres.Enabled = false;
            rozkaz.Enabled = true;
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(wartosc.Text) >= 0 && Convert.ToInt32(wartosc.Text) <= 255)
            {
                wiersz.Text = wiersz.Text + wartosc.Text + "\r\n";
                sztuczka.Text = sztuczka.Text + wartosc.Text + "\r\n";
            }
            else
            {
                wiersz.Text = wiersz.Text + "0\r\n";
                sztuczka.Text = sztuczka.Text + "0\r\n";
                MessageBox.Show("Wpisz liczbę dodatnią");
            }
            okButton.Enabled = false;
            rozkaz.Enabled = true;
            wartosc.Clear();
        }

        //Wykonanie całego programu za pomocą pętli for
        private void praca_Click(object sender, EventArgs e)
        {
            krokButton.Enabled = false;
            for (linia = 0; linia < wiersz.Lines.Length - 1; linia++)
            {
                wykonajLinie();
            }
            krokButton.Enabled = false;
            wiersz.Clear();
            sztuczka.Clear();
        }


        private void wykonajLinie()
        {
            if (wiersz.Lines.Length > 0)
            {
                przypisanie = wiersz.Lines[linia].Contains("MOV");
                dodawanie = wiersz.Lines[linia].Contains("ADD");
                odejmowanie = wiersz.Lines[linia].Contains("SUB");
               
                if (przypisanie)
                {
                    gdzie = wiersz.Lines[linia].Split(' ')[1];
                    co = sztuczka.Lines[linia].Split(' ')[2];

                    //wartość odczytana przechowywana w zmiennej "gdzie" i wartość liczbowa przechowana w zmiennej "co"
                    if (gdzie == "AH")
                    {
                        ah = Convert.ToByte(co);
                    }
                    if (gdzie == "AL")
                    {
                        al = Convert.ToByte(co);
                    }
                    if (gdzie == "BH")
                    {
                        bh = Convert.ToByte(co);
                    }
                    if (gdzie == "BL")
                    {
                        bl = Convert.ToByte(co);
                    }
                    if (gdzie == "CH")
                    {
                        ch = Convert.ToByte(co);
                    }
                    if (gdzie == "CL")
                    {
                        cl = Convert.ToByte(co);
                    }
                    if (gdzie == "DH")
                    {
                        dh = Convert.ToByte(co);
                    }
                    if (gdzie == "DL")
                    {
                        dl = Convert.ToByte(co);
                    }

                }
                else if (dodawanie)
                {
                    gdzie = wiersz.Lines[linia].Split(' ')[1];
                    co = sztuczka.Lines[linia].Split(' ')[2];

                    if (gdzie == "AH")
                    {
                        ah += Convert.ToByte(co);
                    }
                    if (gdzie == "AL")
                    {
                        al += Convert.ToByte(co);
                    }
                    if (gdzie == "BH")
                    {
                        bh += Convert.ToByte(co);
                    }
                    if (gdzie == "BL")
                    {
                        bl += Convert.ToByte(co);
                    }
                    if (gdzie == "CH")
                    {
                        ch += Convert.ToByte(co);
                    }
                    if (gdzie == "CL")
                    {
                        cl += Convert.ToByte(co);
                    }
                    if (gdzie == "DH")
                    {
                        dh += Convert.ToByte(co);
                    }
                    if (gdzie == "DL")
                    {
                        dl += Convert.ToByte(co);
                    }

                }
                else if (odejmowanie)
                {
                    gdzie = wiersz.Lines[linia].Split(' ')[1];
                    co = wiersz.Lines[linia].Split(' ')[2];

                    if (gdzie == "AH")
                    {
                        ah -= Convert.ToByte(co);
                    }
                    if (gdzie == "AL")
                    {
                        al -= Convert.ToByte(co);
                    }
                    if (gdzie == "BH")
                    {
                        bh -= Convert.ToByte(co);
                    }
                    if (gdzie == "BL")
                    {
                        bl -= Convert.ToByte(co);
                    }
                    if (gdzie == "CH")
                    {
                        ch -= Convert.ToByte(co);
                    }
                    if (gdzie == "CL")
                    {
                        cl -= Convert.ToByte(co);
                    }
                    if (gdzie == "DH")
                    {
                        dh -= Convert.ToByte(co);
                    }
                    if (gdzie == "DL")
                    {
                        dl -= Convert.ToByte(co);
                    }
                }
            }
            //konwersja z typu Byte na string, aby był możliwe wyświeltnie ich jako string 
            AH.Text = Convert.ToString(ah, 2).PadLeft(8, '0');
            BH.Text = Convert.ToString(bh, 2).PadLeft(8, '0');
            CH.Text = Convert.ToString(ch, 2).PadLeft(8, '0');
            DH.Text = Convert.ToString(dh, 2).PadLeft(8, '0');
            AL.Text = Convert.ToString(al, 2).PadLeft(8, '0');
            BL.Text = Convert.ToString(bl, 2).PadLeft(8, '0');
            CL.Text = Convert.ToString(cl, 2).PadLeft(8, '0');
            DL.Text = Convert.ToString(dl, 2).PadLeft(8, '0');
        }

        //wykonywaniu kolejno po jednej linii kodu po każdym kliknięciu przycisku przez użytkownika za pomocą licznika,
        // którym jest linia,  zostaje zwiększony po każdym przyciśnięciu klawisza „KROK” co pozwala na przechodzenie do następnych linii kodu. 
        private void krokowa_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;

            if (wiersz.Lines.Length > 0 && linia < wiersz.Lines.Length - 1)
            {
                wykonajLinie();
            }

            if (linia > wiersz.Lines.Length - 1)
            {
                krokButton.Enabled = false;
                startButton.Enabled = true;
            }
            linia++;
        }

        //Przycisk „Reset” czyści nam zawartość rejestrów i ustawia widoczność (Enabled) komponentów interfejsu w stan początkowy.
        private void resetButton_Click(object sender, EventArgs e)
        {
            wiersz.Clear();
            rozkaz.Enabled = true;
            adres.Enabled = false;
            wartosc.Enabled = false;
            rejestr.Enabled = false;
            adresowanie.Enabled = false;
            okButton.Enabled = false;
            sztuczka.Enabled = false;
            sztuczka.Clear();
            startButton.Enabled = true;
            krokButton.Enabled = true;

            linia = 0;
            ah = 0;
            al = 0;
            bh = 0;
            bl = 0;
            ch = 0;
            cl = 0;
            dh = 0;
            dl = 0;

            AH.Text = Convert.ToString(ah, 2).PadLeft(8, '0');
            BH.Text = Convert.ToString(bh, 2).PadLeft(8, '0');
            CH.Text = Convert.ToString(ch, 2).PadLeft(8, '0');
            DH.Text = Convert.ToString(dh, 2).PadLeft(8, '0');
            AL.Text = Convert.ToString(al, 2).PadLeft(8, '0');
            BL.Text = Convert.ToString(bl, 2).PadLeft(8, '0');
            CL.Text = Convert.ToString(cl, 2).PadLeft(8, '0');
            DL.Text = Convert.ToString(dl, 2).PadLeft(8, '0');
        }

        //zapis i odczyt do pliku 
        private void saveButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = File.CreateText(@"C:\Users\olakr\OneDrive\Pulpit\projekt5_procesor_MA\zapis_odczyt.txt"))
            {
                for (linia = 0; linia < wiersz.Lines.Length; linia++)
                {
                    sw.WriteLine(wiersz.Lines[linia]);
                    
                }
               sw.Close();
            }

        }

        private void readButton_Click(object sender, EventArgs e)
        {
            StreamReader s = new StreamReader(@"C:\Users\olakr\OneDrive\Pulpit\projekt5_procesor_MA\zapis_odczyt.txt");
            sztuczka.Text = sztuczka.Text + s.ReadToEnd();
            wiersz.Text = sztuczka.Text;
            s.Close();
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
