using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3yaziliortalamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int not1, not2, not3, sonuc;
            not1 = Convert.ToInt32(txtNot1.Text);
            not2 = Convert.ToInt32(txtNot2.Text);
            not3 = Convert.ToInt32(txtNot3.Text);

            sonuc = (not1 + not2 + not3) / 3; //ondalikli olabilir

            lblOrtalama.Text = sonuc.ToString();
        }
    }
}
