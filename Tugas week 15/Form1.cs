using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_week_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void input_Click(object sender, EventArgs e)
        {
            if ( boxitem.Text == "")
            {
                MessageBox.Show("Input Makanan");
            }
            else if (radiomakanan.Checked == false && radiominuman.Checked == false )
            {
                MessageBox.Show("Pilih Kategori");
            }
            else if (radiomakanan.Checked == true)
            {
                makanan[0] =" Mie Instan" ;
                makanan[1] = "Telor";
                makanan[2] = "Roti";
                makanan[3] = "Keju";
                makanan[4] = "Daging Giling";
                for (int i = 0; i<=a; i++)
                {
                    if (boxitem.Text == makanan [i])
                    {
                        c++;
                    }
                }

                if (c == 0)
                {
                    a++;
                    makanan [a] = boxitem.Text;
                    listBoxKiri.Items.Add(makanan[a]);
                    radiomakanan.Checked = false;
                    radiominuman.Checked = false;
                    boxitem.Text = ""; 
                }
                else
                {
                    MessageBox.Show("Makanan Telah Di Input");
                    radiomakanan.Checked = false;
                    radiominuman.Checked = false;
                    boxitem.Text = "";
                    c = 0;
                }

            }
            else if (radiominuman.Checked == true)
            {
                minuman[0] = "Susu Sapi";
                minuman[1] = "Kopi";
                minuman[2] = "Teh";
                minuman[3] = "Bir";

                for (int i = 0; i <= b; i++)
                {
                    if (boxitem.Text == makanan[i])
                    {
                        c++;
                    }
                }

                if (c == 0)
                {
                    b++;
                    makanan[a] = boxitem.Text;
                    listBoxKanan.Items.Add(minuman[b]);
                    radiomakanan.Checked = false;
                    radiominuman.Checked = false;
                    boxitem.Text = "";
                }
                else
                {
                    MessageBox.Show("Minuman Telah Di Input");
                    radiomakanan.Checked = false;
                    radiominuman.Checked = false;
                    boxitem.Text = "";
                    c = 0;
                }

            }
        }

        public string[] makanan = new String[99];
        public string[] minuman = new string[99];
        public string[] inputan = new string[99];
        public int a = 4;
        public int b = 3;
        public int c = 0;
        public int d = 0;

        private void boxitem_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxKiri_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void inputKanan_Click(object sender, EventArgs e)
        {
            c = 0;
            for (int i = 0; i < listBoxKanan.Items.Count;i++)
            {
                if (inputan[i] == Convert.ToString(listBoxKiri.SelectedItem))
                {
                    c++;
                }
            }
            
            if (c == 0)
            {
                inputan[d] = Convert.ToString(listBoxKiri.SelectedItem) ;
                listBoxKanan.Items.Add(inputan[d]);
                d++;
            }
            if (c!=0)
            {
                inputan[d] = "x";
            }
        }

        private void checkMakanan_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMakanan.Checked == true)
            {
                for (int i= 0; i<=a;i++)
                {
                    
                }
            }
        }

        private void hapusKanan_Click(object sender, EventArgs e)
        {
            listBoxKanan.Items.RemoveAt(listBoxKanan.SelectedIndex);
            for (int i = 0; i <= d; i++)
            {
                if (inputan[i] == Convert.ToString(listBoxKanan.SelectedItem))
                {
                    inputan[i] = "x";
                }
            }
            d--;
        }
    }
}
