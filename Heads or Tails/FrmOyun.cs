using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Heads_or_Tails.FrmHeadsorTails;

namespace Heads_or_Tails
{
    public partial class FrmOyun : Form
    {
        public FrmOyun()
        {
            InitializeComponent();
        }

        FrmHeadsorTails frm;
        Random rdm;
        Oyuncu oyuncu;
        int Skor_1 = 0;
        int Skor_2 = 0;
        int toplamOyun = 0;


        private void FrmOyun_Load(object sender, EventArgs e)
        {
            frm = new FrmHeadsorTails();
            oyuncu = new Oyuncu();
            rdm = new Random();


        }

        private void btnOyna_1_Click(object sender, EventArgs e)
        {
            btnOyna_1.Enabled = false;
            btnOyna_2.Enabled = true;

            

            int yazi_tura = rdm.Next(0, 2);
            if (yazi_tura == 0)
            {
                pbxTura.Visible = true;
                pbxYazi.Visible = false;
            }
            else
            {
                pbxYazi.Visible = true;
                pbxTura.Visible = false;
            }


            if (pbxTura_1.Visible is true && pbxTura.Visible is true)
            {
                Skor_1 += 1;
                toplamOyun += 1;
            }
            if (pbxTura_1.Visible is true && pbxYazi.Visible is true)
            {
                Skor_2 += 1;
                toplamOyun += 1;

            }

            if (pbxYazi_1.Visible is true && pbxYazi.Visible is true)
            {
                Skor_1 += 1;
                toplamOyun += 1;

            }

            if (pbxYazi_1.Visible is true && pbxTura.Visible is true)
            {
                Skor_2 += 1;
                toplamOyun += 1;

            }


            lblSkor_1.Text = Skor_1.ToString();
            lblSkor_2.Text = Skor_2.ToString();

            lblOyunSayisi.Text = toplamOyun.ToString();

            pbxTura_1.Visible = true;
            pbxYazi_1.Visible = true;
            pbxTura_2.Visible = true;
            pbxYazi_2.Visible = true;

            if (lblOyun.Text == lblOyunSayisi.Text)
            {
                MessageBox.Show("Oyun Bitti");
                if (Skor_1 > Skor_2)
                {
                    MessageBox.Show($"({Skor_1} - {Skor_2}) {lblOyuncu_1.Text} Oyunu Kazandı");
                }
                if (Skor_1 < Skor_2)
                {
                    MessageBox.Show($"({Skor_1} - {Skor_2}) {lblOyuncu_2.Text} Oyunu Kazandı");

                }
                if (Skor_1 == Skor_2)
                {
                    MessageBox.Show($"({Skor_1} - {Skor_2}) Berabere");

                }
            }

        }


        private void pbxTura_1_Click(object sender, EventArgs e)
        {
            pbxYazi_1.Visible = false;
            pbxYazi_2.Visible = true;
            pbxTura_2.Visible = false;

            btnOyna_2.Enabled = false;

        }

        private void pbxYazi_1_Click(object sender, EventArgs e)
        {
            pbxTura_1.Visible = false;
            pbxYazi_2.Visible = false;
            pbxTura_2.Visible = true;

            btnOyna_2.Enabled = false;

        }
        private void pbxTura_2_Click(object sender, EventArgs e)
        {
            pbxYazi_1.Visible = true;
            pbxYazi_2.Visible = false;
            pbxTura_2.Visible = true;

            btnOyna_1.Enabled = false;
        }

        private void pbxYazi_2_Click(object sender, EventArgs e)
        {
            pbxTura_1.Visible = true;
            pbxYazi_1.Visible = false;
            pbxTura_2.Visible = false;

            btnOyna_1.Enabled = false;

        }

        private void btnOyna_2_Click(object sender, EventArgs e)
        {
            btnOyna_2.Enabled = false;
            btnOyna_1.Enabled = true;

            

            int yazi_tura = rdm.Next(0, 2);
            if (yazi_tura == 0)
            {
                pbxTura.Visible = true;
                pbxYazi.Visible = false;
            }
            else
            {
                pbxYazi.Visible = true;
                pbxTura.Visible = false;
            }


            if (pbxTura_2.Visible is true && pbxTura.Visible is true)
            {
                Skor_2 += 1;
                toplamOyun += 1;
            }
            if (pbxTura_2.Visible is true && pbxYazi.Visible is true)
            {

                Skor_1 += 1;
                toplamOyun += 1;


            }

            if (pbxYazi_2.Visible is true && pbxYazi.Visible is true)
            {
                Skor_2 += 1;
                toplamOyun += 1;

            }
            if (pbxYazi_2.Visible is true && pbxTura.Visible is true)
            {
                Skor_1 += 1;
                toplamOyun += 1;

            }

            lblSkor_1.Text = Skor_1.ToString();
            lblSkor_2.Text = Skor_2.ToString();

            lblOyunSayisi.Text = toplamOyun.ToString();


            pbxTura_1.Visible = true;
            pbxYazi_1.Visible = true;
            pbxTura_2.Visible = true;
            pbxYazi_2.Visible = true;

            if (lblOyun.Text == lblOyunSayisi.Text)
            {
                MessageBox.Show("Oyun Bitti");
                if (Skor_1 > Skor_2)
                {
                    MessageBox.Show($"({Skor_1} - {Skor_2}) {lblOyuncu_1.Text} Oyunu Kazandı");
                }
                if (Skor_1 < Skor_2)
                {
                    MessageBox.Show($"({Skor_1} - {Skor_2}) {lblOyuncu_2.Text} Oyunu Kazandı");

                }
                if (Skor_1 == Skor_2)
                {
                    MessageBox.Show($"({Skor_1} - {Skor_2}) Berabere");

                }
            }


        }

        
        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            FrmHeadsorTails frmHeadsorTails = new FrmHeadsorTails();
            frmHeadsorTails.Show();
            this.Hide();
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
