using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Crypto_app.MaHoaCoDien
{
    public partial class frmAffine : DevExpress.XtraEditors.XtraUserControl
    {
        public frmAffine()
        {
            InitializeComponent();
        }

        private void btnAffineEn_Click(object sender, EventArgs e)
        {
            try
            {
                int keya = Convert.ToInt32(txtAffineKeyA.Text);
                int keyb = Convert.ToInt32(txtAffineKeyB.Text);
                if (keya >= 26 || keyb >= 26 || keya < 0 || keyb < 0)
                {
                    MessageBox.Show("Giá trị khóa không được vượt quá không gian Z(26)", "Error =.=!");
                    txtAffineKeyA.Text = "";
                    txtAffineKeyB.Text = "";
                }

                int usc = Affine.USCLN(keya, Affine.P.Length);
                if (usc != 1)
                {
                    MessageBox.Show("Hệ số a= " + keya + " không phù hợp.\nNhập khóa a sao cho USCLN(a,26)=1", "Error =.=!");
                    txtAffineKeyA.Text = "";
                    txtAffineKeyB.Text = "";
                }

                txtAffineOutput.Text = Affine.Mahoa(txtAffineInput.Text, keya, keyb);

            }
            catch (Exception)
            {
                MessageBox.Show("Nhập lại khóa(Nhập số nguyên)!", "Error =.=! ");
                txtAffineInput.Text = "";
                txtAffineKeyA.Text = "";
                txtAffineKeyB.Text = "";
            }
        }

        private void btnAffineDe_Click(object sender, EventArgs e)
        {
            try
            {
                int keya = Convert.ToInt32(txtAffineKeyA.Text);
                int keyb = Convert.ToInt32(txtAffineKeyB.Text);
                if (keya >= 26 || keyb >= 26 || keya < 0 || keyb < 0)
                {
                    MessageBox.Show("Giá trị khóa không được vượt quá không gian Z(26)", "Error =.=!");
                    txtAffineKeyA.Text = "";
                    txtAffineKeyB.Text = "";
                }

                int usc = Affine.USCLN(keya, Affine.P.Length);
                if (usc != 1)
                {
                    MessageBox.Show("Hệ số a= " + keya + " không phù hợp.\nNhập khóa a sao cho USCLN(a,26)=1", "Error =.=!");
                    txtAffineKeyA.Text = "";
                    txtAffineKeyB.Text = "";
                }

                txtAffineOutput.Text = Affine.Giaima(txtAffineInput.Text, keya, keyb);

            }
            catch (Exception)
            {
                MessageBox.Show("Nhập lại khóa(Nhập số nguyên)!", "Error =.=! ");
                txtAffineInput.Text = "";
                txtAffineKeyA.Text = "";
                txtAffineKeyB.Text = "";
            }
        }
    }
    
}
