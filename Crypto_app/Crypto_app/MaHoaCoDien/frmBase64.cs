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
using System.IO;

namespace Crypto_app.MaHoaCoDien
{
    public partial class frmBase64 : DevExpress.XtraEditors.XtraUserControl
    {
        public frmBase64()
        {
            InitializeComponent();
        }
        char[] encoding_table = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H',
                                'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P',
                                'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X',
                                'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f',
                                'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n',
                                'o', 'p', 'q', 'r', 's', 't', 'u', 'v',
                                'w', 'x', 'y', 'z', '0', '1', '2', '3',
                                '4', '5', '6', '7', '8', '9', '+', '/'};
        public static string ChuyenASCsangNhiPhan(string BanRo)
        {

            FileStream file = new FileStream("ASCtoNhiPhan", FileMode.Open, FileAccess.Read, FileShare.None);

            StreamReader doc = new StreamReader(file);

            //đọc từng dòng một
            string Temp = "", NhiPhan = "", ASC = "";

            string[] MangNhiPhan = new string[BanRo.Length];

            Temp = doc.ReadLine();
            int t = 0;

            while (Temp != null)
            {

                NhiPhan = Temp.Substring(0, 8).ToString();
                ASC = Temp.Substring(16, 1);

                for (int i = 0; i < BanRo.Length; i++)
                {
                    if (ASC == BanRo[i].ToString())
                    {
                        MangNhiPhan[i] = NhiPhan;
                        t++;
                    }
                }

                if (t == BanRo.Length) break;

                Temp = doc.ReadLine();
            }

            string ChuoiNhiPhan = "";

            for (int i = 0; i < BanRo.Length; i++)
            {
                ChuoiNhiPhan += MangNhiPhan[i];
            }

            doc.Close();
            file.Close();
            return ChuoiNhiPhan;
        }
        static int Bin2Dec(string input)
        {
            char[] array = input.ToCharArray();
            Array.Reverse(array);
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '1')
                {
                    // Method uses raising 2 to the power of the index. 
                    if (i == 0)
                    {
                        sum += 1;
                    }
                    else
                    {
                        sum += (int)Math.Pow(2, i);
                    }
                }

            }
            return sum;
        }
        public string encode_base(string str, string temp, string result)
        {
            string text = ChuyenASCsangNhiPhan(str);
            int mod = str.Length % 3;
            //thêm 1||2 byte0 cuối cùng
            if (mod == 1)
            {
                for (int i = 1; i <= 16; i++)
                {
                    text += '0';
                }
            }
            if (mod == 2)
            {
                for (int i = 1; i <= 8; i++)
                {
                    text += '0';
                }
            }
            //chuyển từ nhị phân sang thập phân
            int len = text.Length;
            for (int i = 0; i < len; i++)
            {
                temp += text[i];
                if (temp.Length == 6)
                {
                    if (i == len - 6 - 1 || i == len - 1)
                    {
                        if (temp == "000000")
                        {
                            result += "=";
                            temp = "";
                        }
                        else
                        {
                            int x = Bin2Dec(temp);
                            result += encoding_table[x];
                            temp = "";
                        }
                    }
                    else
                    {
                        int x = Bin2Dec(temp);
                        result += encoding_table[x];
                        temp = "";
                    }
                }
            }
            return result;
        }
        public string decode_base(string str, string binary, string temp, string result)
        {
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < encoding_table.Length; j++)
                {
                    if (str[i] == encoding_table[j])
                    {
                        //chuyển từ thập phân sang nhị phân
                        temp = Convert.ToString(j, 2);
                        //thêm bit 0 vào đầu để đủ 6 bit
                        int n = temp.Length;
                        for (int p = 1; p <= 6 - n; p++)
                        {
                            temp = '0' + temp;
                        }
                        binary += temp;
                        temp = "";
                    }
                }
            }
            int len = binary.Length;
            for (int i = 0; i < len; i++)
            {
                temp += binary[i];
                if (temp.Length == 8)
                {
                    int x = Bin2Dec(temp);
                    result += (char)x;
                    temp = "";
                }
            }
            return result;
        }
        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(plainText.Text) == true)
            {
                MessageBox.Show("Điền chuỗi ký tự cần mã hóa");
            }
            else
            {
                txbEncode.Text = encode_base(plainText.Text, "", "");
                txbDecode.Text = decode_base(txbEncode.Text, "", "", "");
            }
        }
    }
}
