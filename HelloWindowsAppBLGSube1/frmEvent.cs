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
    public partial class frmEvent : Form
    {
        int sonuc = 0;
        public frmEvent()
        {
            InitializeComponent();
        }

        private void Topla(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            sonuc += int.Parse(btn.Text);            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"İşlemin Sonucu:{sonuc}");
        }
    }
}
