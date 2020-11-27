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
    public partial class frmDES : DevExpress.XtraEditors.XtraUserControl
    {
        public frmDES()
        {
            InitializeComponent();
        }
        DES_process des;
        private void btnDESEn_Click(object sender, EventArgs e)
        {

            des = new DES_process();
            if (txtDESKey.Text.Length == 8)
            {
                txtDESOutput.Text = "";
                txtDES.Text = "";
                string cipher = des.MaHoa(txtDESInput.Text, txtDESKey.Text, 1, txtDES);
                txtDESOutput.Text = cipher;
            }
            else
                MessageBox.Show("Khoá không hợp lệ");
        }

        private void btnDESDe_Click(object sender, EventArgs e)
        {
            des = new DES_process();
            if (txtDESKey.Text.Length == 8)
            {
                txtDESOutput.Text = "";
                txtDES.Text = "";
                string cipher = des.MaHoa(txtDESInput.Text, txtDESKey.Text, -1, txtDES);
                txtDESOutput.Text = cipher;
            }
            else
                MessageBox.Show("Khoá không hợp lệ");
        }
    }
}
