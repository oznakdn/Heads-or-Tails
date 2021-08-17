using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heads_or_Tails
{
    public partial class FrmHeadsorTails : Form
    {
        public FrmHeadsorTails()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            

        }
        public class Oyuncu
        {
            public string Oyuncu_1;
            public string Oyuncu_2;
            public int OyunSayisi;

        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            try
            {
                Oyuncu oyuncu = new Oyuncu();
                oyuncu.Oyuncu_1 = txtOyuncu_1.Text;
                oyuncu.Oyuncu_2 = txtOyuncu_2.Text;
                oyuncu.OyunSayisi = Convert.ToInt32(txtOyunSayisi.Text);

                FrmOyun frmOyun = new FrmOyun();
                frmOyun.Show();
                frmOyun.lblOyuncu_1.Text = txtOyuncu_1.Text;
                frmOyun.lblOyuncu_2.Text = txtOyuncu_2.Text;
                frmOyun.lblOyun.Text = txtOyunSayisi.Text;

                this.Hide();

            }
            catch
            {

                MessageBox.Show("Alanları doldurunuz");
            }

           

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
