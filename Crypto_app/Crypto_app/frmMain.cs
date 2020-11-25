using Crypto_app.MaHoaCoDien;
using Crypto_app.MaHoaHienDai;
using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Crypto_app
{
    public partial class frmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Hill_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmHill a = new frmHill();
            panel.Controls.Add(a);
        }

        private void Affine_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmAffine a = new frmAffine();
            panel.Controls.Add(a);
        }

        private void Base64_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmBase64 a = new frmBase64();
            panel.Controls.Add(a);
        }

        private void DES_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmDES a = new frmDES();
            panel.Controls.Add(a);
        }

        private void RSA_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmRSA a = new frmRSA();
            panel.Controls.Add(a);
        }
    }
}
