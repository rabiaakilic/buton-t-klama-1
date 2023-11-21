using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buton_tıklama_1__1359
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string aranan = txtAranan.Text;
            int sayaç = 0;

            for (int i = 0; i < lbAdlar.Items.Count; i++)

                if (aranan == lbAdlar.Items[i].ToString())
                    sayaç++;
            if (sayaç > 0)
            {
                MessageBox.Show(sayaç + "tane var");
            }
            else
            {
                MessageBox.Show(sayaç + "kişi yok");





            }
            

            
        }
    }
}
