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
    public partial class frmOyun : Form
    {
        int skor = 0;
        int sure = 3;
        public frmOyun(string ad,string soyad)
        {
            InitializeComponent();
            lblKullanici.Text = $"Hoşgeldin, {ad} {soyad}";
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!tmrSure.Enabled)
            {
                tmrSure.Start();
            }


            var rnd = new Random();
            btnYakala.Location = new Point(rnd.Next(this.ClientSize.Width - btnYakala.Width - pnlBilgi.Width), rnd.Next(this.ClientSize.Height - btnYakala.Height));
            skor++;
            lblSkor.Text = skor.ToString();
        }

        private void frmOyun_SizeChanged(object sender, EventArgs e)
        {
            //pnlBilgi.Location = new Point(this.ClientSize.Width - pnlBilgi.Width, 0);
            //pnlBilgi.Height = this.ClientSize.Height;
        }

        private void tmrSure_Tick(object sender, EventArgs e)
        {
            lblSure.Text = sure.ToString();            
            if (sure==0)
            {
                tmrSure.Stop();
                btnYakala.Enabled = false;
                MessageBox.Show($"Süreniz doldu!Skorunuz:{skor}");
            }
            sure--;
        }

        private void frmOyun_Load(object sender, EventArgs e)
        {

        }
    }
}
