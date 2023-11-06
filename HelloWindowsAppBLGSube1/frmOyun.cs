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
        public frmOyun()
        {
            InitializeComponent();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            var rnd = new Random();
            button1.Location = new Point(rnd.Next(this.ClientSize.Width - button1.Width-pnlBilgi.Width), rnd.Next(this.ClientSize.Height - button1.Height));
            skor++;
            lblSkor.Text = skor.ToString(); 
        }

        private void frmOyun_SizeChanged(object sender, EventArgs e)
        {
            //pnlBilgi.Location = new Point(this.ClientSize.Width - pnlBilgi.Width, 0);
            //pnlBilgi.Height = this.ClientSize.Height;
        }
    }
}
