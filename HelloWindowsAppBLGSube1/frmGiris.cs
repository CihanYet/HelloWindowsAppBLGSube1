using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWindowsAppBLGSube1
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == String.Empty || txtSoyad.Text == String.Empty)
            {
                MessageBox.Show("Ad ve soyad zorunludur.");
            }
            else
            {
                string seviye;
                if (rdKolay.Checked)
                {
                    seviye = "Kolay";
                }
                else if (rdOrta.Checked)
                {
                    seviye = "Orta";
                }
                else if (rdZor.Checked)
                {
                    seviye = "Zor";
                }
                else
                {
                    MessageBox.Show("Seviye seçiniz!");
                    return;
                }
                var frm = new frmOyun(txtAd.Text, txtSoyad.Text,seviye);                
                frm.ShowDialog();
            }

        }
    }
}
