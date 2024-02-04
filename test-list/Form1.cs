using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_list
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void btnListele1_Click(object sender, EventArgs e)
        {
            List<string> Karakterler = new List<string>();
            Karakterler.Add("Ali");
            Karakterler.Add("Mehmet");
            Karakterler.Add("Ayşe");
            Karakterler.Add("Leyla");
            Karakterler.Add("Mecnun");
            Karakterler.Add("Emir");

            foreach( string k in Karakterler)
            {
                listBox1.Items.Add(k);
            }
        }

        private void btnListele2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            int sayi;
            sayi = Convert.ToInt32(textBox1.Text);

            List<int> Sayılar = new List<int>();
            Sayılar.Add(5);
            Sayılar.Add(12);
            Sayılar.Add(15);
            Sayılar.Add(49);
            Sayılar.Add(985);
           
            
            foreach(int S in Sayılar)
            {
                if(S%5 == 0)
                {
                    listBox2.Items.Add(S);
                }
            }

            if (Sayılar.Contains(sayi))
            {
                MessageBox.Show(" Bu sayı var = "+sayi);
            }
            else
            {
                MessageBox.Show(" Bu sayı yok = "+sayi);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btnListele2.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnListele2.Enabled = false;
        }

        private void btnListele3_Click(object sender, EventArgs e)
        {
            List<Kisiler> Kisi = new List<Kisiler>();

            Kisi.Add(new Kisiler()
            {
                AD = "Veli ",
                SOYAD = "Çınar",
                MESLEK = "Öğretmen"
            });
            
            foreach(Kisiler k in Kisi)
            {
                listBox3.Items.Add(k.AD + " " + k.SOYAD + " " + k.MESLEK);
            }
        }

        private void btnListele4_Click(object sender, EventArgs e)
        {
            List<Araba> Arac = new List<Araba>();

            Arac.Add(new Araba()
            {
                MODEL = "Mercedes",
                YİL = 2019,
                MAXH = 280,
                paket = "Full paket",
                VITES = "Otomatik Vites"

            });
            foreach(Araba a in Arac)
            {
                listBox4.Items.Add(a.MODEL + "-" + a.YİL + "-" + a.MAXH + "-" + a.paket + "-" + a.VITES);
            }
    }
    }
}
