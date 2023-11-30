using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otobüs_Bilet_Buton
{
    public partial class BusTicket : Form
    { 
        bool[] seciliMi = new bool[9];
        
        
        public BusTicket()
        {
            InitializeComponent();
        }
        private void KoltukButton_Click(object sender, EventArgs e)
        {
            Button koltukSecim = (Button)sender;
                //hangi butona tıklandıysa o ismi verir
            int koltukNo=Convert.ToInt32(koltukSecim.Text);

            int sıraNo = koltukNo - 1; 
           

            if (seciliMi[sıraNo]) // if (seciliMi[sıraNo] == true)
                {
                Koltuk1Button.BackColor = Color.Linen;
                seciliMi[sıraNo] = false;
            }
            else
            {
                koltukSecim.BackColor = Color.DarkRed;
               
                seciliMi[sıraNo] = true;
               
            }
            
            
        }

        private void ödemeButton_Click(object sender, EventArgs e)
        {
            int fiyat;
            int toplamKoltuk = 0;
            for(int i = 0; i < 9; i++) { 
            if (seciliMi[i]) {
                toplamKoltuk++; 
            }
            }
            fiyat = toplamKoltuk * 150;
            MessageBox.Show("Ödemeniz: " + fiyat + "TL'dir.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BusTicket_Load(object sender, EventArgs e)
        {

        }
    }
}
