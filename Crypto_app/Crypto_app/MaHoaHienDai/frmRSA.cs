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

namespace Crypto_app.MaHoaHienDai
{
    public partial class frmRSA : DevExpress.XtraEditors.XtraUserControl
    {
        public frmRSA()
        {
            InitializeComponent();
        }
        private void txtRSAP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtRSAQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        public int gcd(int a, int b)
        {
            if (a == 0)
                return b;
            return gcd(b % a, a);
        }

        private void btnRSAKey_Click(object sender, EventArgs e)
        {
            int P = Convert.ToInt32(txtRSAP.Text);
            int Q = Convert.ToInt32(txtRSAQ.Text);
            int E = 2;
            int N = P * Q;
            double D = 1;
            double phi = (P - 1) * (Q - 1);
            while (E < phi)
            {
                if (gcd((int)E, (int)phi) == 1)
                    break;
                else
                    E++;
            }

            for (int i = 1; i < 100; i++)
            {

                if ((i * phi + 1) % E == 0)
                {
                    D = (i * phi + 1) / E;

                    break;

                }

            }
            txtRSA.Text = "-----------QUÁ TRÌNH SINH KHOÁ-----------\r\n";
            txtRSA.Text += "\r\nBước 1: N = P * Q = " + P.ToString() + " * " + Q.ToString() + " = " + N.ToString();
            txtRSA.Text += "\r\nBước 2: phi = (P - 1) * (Q - 1) = " + "(" + P.ToString() + " - 1)" + " * " + "(" + Q.ToString() + " - 1) = " + phi.ToString();
            txtRSA.Text += "\r\nBước 3: Chọn E để gcd(E,phi) = 1 & 1 < E <phi";
            txtRSA.Text += "\r\n\t\t=> Chọn E = " + E.ToString();
            txtRSA.Text += "\r\nBước 3: D = (E^-1) mod (phi) = " + D.ToString() + "\r\n\r\n";

            txtRSAKeyPublic.Text = E.ToString();
            txtRSAKeyPrivate.Text = D.ToString();
        }

        private void btnRSAEn_Click(object sender, EventArgs e)
        {
            int P = Convert.ToInt32(txtRSAP.Text);
            int Q = Convert.ToInt32(txtRSAQ.Text);

            txtRSAOutput.Text = modulo(Convert.ToInt32(txtRSAInput.Text), Convert.ToInt32(txtRSAKeyPublic.Text), P * Q).ToString();
            txtRSA.Text += "\r\nMã hoá: C = P^E mod (N) = " + txtRSAInput.Text + "^" + txtRSAKeyPublic.Text + " mod (" + (P * Q).ToString() + ") = " + txtRSAOutput.Text + "\r\n";
        }
        int modulo(int a, int n, int m)
        {
            int res = 1;
            for (int i = 1; i <= n; i++)
            {
                res = res * a % m;
            }
            return res;
        }
        private void btnRSADe_Click(object sender, EventArgs e)
        {
            int P = Convert.ToInt32(txtRSAP.Text);
            int Q = Convert.ToInt32(txtRSAQ.Text);

            int output = modulo(Convert.ToInt32(txtRSAInput.Text), Convert.ToInt32(txtRSAKeyPrivate.Text), P * Q);
            txtRSAOutput.Text = output.ToString();

            txtRSA.Text += "\r\nGiải mã: P = C^D mod (N) = " + txtRSAInput.Text + "^" + txtRSAKeyPrivate.Text + " mod (" + (P * Q).ToString() + ") = " + txtRSAOutput.Text + "\r\n";
        }

        private void btnRSA_Click(object sender, EventArgs e)
        {
            txtRSA.Text = "";
        }
    }
}
