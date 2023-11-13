using OyunLib;
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
{//Enum yapıları sabitlerden oluşur.Aynı zamanda veri tipi olarak kullanılır.
   

    public partial class frmOyun : Form
    {
        int skor = 0;
        int sure = 20;
        public frmOyun(GameInfo bilgi)
        {
            InitializeComponent();
            lblKullanici.Text = $"Hoşgeldin, {bilgi.Ad} {bilgi.Soyad}";
            switch (bilgi.Seviye)
            {
                case Level.Kolay:
                    this.Size = new Size(300, 300);
                    this.sure = 30;
                    break;
                case Level.Orta:
                    this.Size = new Size(500, 500);
                    this.sure = 20;
                    break;
                case Level.Zor:
                    this.Size = new Size(800, 800);
                    this.sure = 10;
                    break;
                default:
                    break;
            }
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;

            if (!tmrSure.Enabled)
            {
                tmrSure.Start();
            }
            var rnd = new Random();
            b.Location = new Point(rnd.Next(this.ClientSize.Width - b.Width - pnlBilgi.Width), rnd.Next(this.ClientSize.Height - b.Height));
            if (b.Name == "btnYakala")
            {
                skor++;
            }
            else
            {
                skor -= 5;
            }
            lblSkor.Text = skor.ToString();
            if (skor % 10 == 0)
            {
                var btn = new Button();
                btn.BackColor = Color.Red;
                btn.Size = new Size(50, 50);
                btn.Location = new Point(rnd.Next(this.ClientSize.Width - btnYakala.Width - pnlBilgi.Width), rnd.Next(this.ClientSize.Height - btnYakala.Height));
                btn.MouseMove += button1_MouseMove;
                this.Controls.Add(btn);
            }
        }

        private void Btn_MouseMove(object sender, MouseEventArgs e)
        {
            skor -= 5;
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
            if (sure == 0)
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



    class Bilgisayar
    {
        public Bilgisayar(string marka)
        {
            this.Marka = marka;
        }
        public string Marka { get; set; }
    }
}
