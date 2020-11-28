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
    public partial class frmHill : DevExpress.XtraEditors.XtraUserControl
    {
        public frmHill()
        {
            InitializeComponent();
        }
        static Hill hill = new Hill();
        //đẩy data từ mảng vào gridview
        public void ArrayToGridview(DataGridView dgv, int[,] arr)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    dgv.Rows[row.Index].Cells[col.Index].Value = arr[row.Index, col.Index];
                }
            }
        }
        //đẩy data từ gridview vào mảng
        public bool GridViewToArray(DataGridView dgv, int[,] arr)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    int a;
                    if (int.TryParse((string)dgv.Rows[row.Index].Cells[col.Index].Value, out a))
                    {
                        arr[row.Index, col.Index] = a;
                    }
                    else
                        return false;
                }
            }
            return true;
        }

        private void btnMaHoa_Click(object sender, EventArgs e)
        {
            if(hill.KeyMatrix!=null)
            {
                //m là số cột = số lần mã hoá do mỗi lần mã hoá 1 cột
                int m = txtBanRo.Text.Length / hill.N;

                //chuyển thông điệp từ text sang ma trận
                int[,] messageVector = new int[hill.N, m];
                messageVector = hill.initMessage(txtBanRo.Text, m);

                //tạo view ma trận bản rõ
                dataGridViewBanRo.Rows.Clear();
                dataGridViewBanRo.RowCount = hill.N;
                dataGridViewBanRo.ColumnCount = m;
                dataGridViewBanRo.AutoResizeRows();
                ArrayToGridview(dataGridViewBanRo, messageVector);

                //gọi hàm mã hoá
                txtBanMa.Text = hill.HillCipher(messageVector, m);

                //tạo view ma trận bản mã
                dataGridViewBanMa.Rows.Clear();
                dataGridViewBanMa.RowCount = hill.N;
                dataGridViewBanMa.ColumnCount = m;
                dataGridViewBanMa.AutoResizeRows();
                ArrayToGridview(dataGridViewBanMa, hill.initMessage(txtBanMa.Text, m));

            }
            else
            {
                MessageBox.Show("Bạn chưa tạo ma trận khoá");
            }

        }

        private void btnGiaiMa_Click(object sender, EventArgs e)
        {
            if(hill.KeyMatrix != null)
            {
                //m là số cột = số lần mã hoá do mỗi lần mã hoá 1 cột
                int m = txtBanMa.Text.Length / hill.N;

                //chuyển thông điệp từ text sang ma trận
                int[,] messageVector = new int[hill.N, m];
                messageVector = hill.initMessage(txtBanMa.Text, m);

                //tạo view ma trận bản mã
                dataGridViewBanMa.Rows.Clear();
                dataGridViewBanMa.RowCount = hill.N;
                dataGridViewBanMa.ColumnCount = m;
                dataGridViewBanMa.AutoResizeRows();
                ArrayToGridview(dataGridViewBanMa, messageVector);

                //gọi hàm giải mã
                txtBanRo.Text = hill.HillDecrypt(messageVector, m);

                //tạo view ma trận bản rõ
                dataGridViewBanRo.Rows.Clear();
                dataGridViewBanRo.RowCount = hill.N;
                dataGridViewBanRo.ColumnCount = m;
                dataGridViewBanRo.AutoResizeRows();
                ArrayToGridview(dataGridViewBanRo, hill.initMessage(txtBanRo.Text, m));
            }
            else
            {
                MessageBox.Show("Bạn chưa tạo ma trận khoá");
            }

        }

        //hàm toạ ma trận khoá từ ô text nhập khoá
        private void txtKhoa_Validated(object sender, EventArgs e)
        {
            //n là bậc của ma trận khoá
            int n;
            if (!int.TryParse(Math.Sqrt(txtKhoa.Text.Length).ToString(), out n) && txtKhoa.Text != "")//n phải là số nguyên
            {
                MessageBox.Show("Khoá không tạo thành ma trận vuông!");
                txtKhoa.Focus();
            }
            else if (txtKhoa.Text == "")
            {
                txtCapMaTran.Focus();
            }
            else
            {
                hill.N = n;
                if (hill.N >= 5)
                {
                    MessageBox.Show("Không gian khoá vượt quá");
                    txtKhoa.Focus();
                }
                else
                {
                    //tạo ma trận từ text
                    int[,] temp = new int[n, n];
                    temp = hill.initKey(txtKhoa.Text);
                    if (hill.DinhThuc(temp, n) == 0)//kiểm tra khả nghịch ma trận
                    {
                        MessageBox.Show("Ma Trận khoá không tồn tại khả nghịch");
                        txtKhoa.Focus();
                    }
                    else
                    {
                        hill.KeyMatrix = temp;//gán ma trận khoá

                        //tạo view ma trận khoá và nghịch đảo
                        dataGridViewKhoa.Rows.Clear();
                        dataGridViewKhoa1.Rows.Clear();
                        dataGridViewKhoa.RowCount = dataGridViewKhoa.ColumnCount = n;
                        dataGridViewKhoa1.RowCount = dataGridViewKhoa1.ColumnCount = n;
                        dataGridViewKhoa.AutoResizeRows();
                        dataGridViewKhoa1.AutoResizeRows();
                        ArrayToGridview(dataGridViewKhoa, temp);

                        int[,] inv = new int[n, n];
                        hill.inverse(temp, inv);
                        ArrayToGridview(dataGridViewKhoa1, inv);
                    }
                }
            }
        }

        //Tạo ma trận để nhập khoá
        private void btnTaoGRV_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(txtCapMaTran.Text, out n))
            {
                dataGridViewKhoa.Rows.Clear();
                dataGridViewKhoa.RowCount = dataGridViewKhoa.ColumnCount = n;
                dataGridViewKhoa.AutoResizeRows();
                hill.N = n;
                btnTaoMatrix.Enabled = true;
            }
            else
            {
                MessageBox.Show("Kích cỡ không hợp lệ!");
                txtCapMaTran.Focus();
                btnTaoMatrix.Enabled = false;
            }
        }
        //Gán ma trận vừa nhập vào khoá
        private void btnTaoMatrix_Click(object sender, EventArgs e)
        {
            hill.KeyMatrix = new int[hill.N, hill.N];
            if (GridViewToArray(dataGridViewKhoa, hill.KeyMatrix))
            {
                if(hill.DinhThuc(hill.KeyMatrix, hill.N) != 0)
                {
                    dataGridViewKhoa1.Rows.Clear();
                    dataGridViewKhoa1.RowCount = dataGridViewKhoa1.ColumnCount = hill.N;
                    dataGridViewKhoa1.AutoResizeRows();
                    int[,] inv = new int[hill.N, hill.N];
                    hill.inverse(hill.KeyMatrix, inv);
                    ArrayToGridview(dataGridViewKhoa1, inv);
                }   
                else
                {
                    MessageBox.Show("Ma trận khoá không khả nghịch");
                    hill.KeyMatrix = null;
                }    

            }
            else
            {
                MessageBox.Show("Ma trận khoá không hợp lệ");
                hill.KeyMatrix = null;
            }    
        }
    }
}
