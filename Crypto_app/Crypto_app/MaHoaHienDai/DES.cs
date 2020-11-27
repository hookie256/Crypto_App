using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypto_app.MaHoaHienDai
{
    class Method
    {
        public static string ChinhDoDai64(string s)//thêm bit 0 để độ dài chuỗi plaintext === 64
        {
            int Mod = s.Length % 64;
            int dodai = s.Length;
            if (Mod != 0)
            {
                int thieu = (64 - Mod) / 8;// số bit thiếu cần bổ sung để chuỗi có độ dài là bội của 64
                for (int i = 0; i < thieu; i++)
                    s += "00000000";
            }
            string chieudaithuc = Method.Thap_Nhi(dodai, 64);
            s += chieudaithuc;
            return s;
        }
        public static string XOR(string a, string b)//xor 2 chuỗi bit
        {
            if (a.Length != b.Length)
                return null;
            string ans = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == b[i])
                {
                    ans += "0";
                }
                else
                {
                    ans += "1";
                }
            }
            return ans;
        }
        //public static string shift_left(string k, int shifts)//phép dịch bit sang trái shifts lần
        //{
        //    string s = "";
        //    for (int i = 0; i < shifts; i++)
        //    {
        //        for (int j = 1; j < k.Length; j++)
        //        {
        //            s += k[j];
        //        }
        //        s += k[0];
        //        k = s;
        //        s = "";
        //    }
        //    return k;
        //}
        public static string Chuoi_Nhi(string data)// string sang kiểu nhị phân
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in data.ToCharArray())
            {
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }
        public static string Nhi_Chuoi(string data)// từ nhị phân sang string
        {
            List<Byte> byteList = new List<Byte>();

            for (int i = 0; i < data.Length; i += 8)
            {
                byteList.Add(Convert.ToByte(data.Substring(i, 8), 2));
            }
            return Encoding.ASCII.GetString(byteList.ToArray());
        }

        public static int Nhi_Thap(string data)//chuyển hệ nhị phân sang hệ 10
        {
            int KQ = 0;
            for (int i = data.Length - 1; i >= 0; i--)
            {
                KQ += int.Parse(data[i].ToString()) * (int)Math.Pow(2, data.Length - i - 1);
            }
            return KQ;
        }
        public static string Thap_Nhi(int SoInput, int dodai)//chuyển hệ 10 sang hệ nhị phân
        {
            string ChuoiKQ = "";
            int i = dodai - 1;
            int[] temp = new int[dodai];
            while (SoInput > 0)
            {
                temp[i] = SoInput % 2;
                SoInput = SoInput / 2;
                i--;
            }
            for (int j = 0; j < dodai; j++)
            {
                ChuoiKQ += temp[j].ToString();
            }
            return ChuoiKQ;
        }

        public static string ThapLuc_Nhi(string hexvalue)//từ kiểu hex sang nhị phân
        {
            return String.Join(String.Empty, hexvalue.Select(c => Convert.ToString(Convert.ToUInt32(c.ToString(), 16), 2).PadLeft(4, '0')));
        }

        public static string HoanVi(string k, int[] arr)//hoán vị
        {
            string per = "";
            for (int i = 0; i < arr.Length; i++)
            {
                per += k[arr[i] - 1];
            }
            return per;
        }
        public static string[] TachChuoi(string s)// tách thành các chuỗi con 64bit
        {
            int SoLuong = s.Length / 64;
            string[] KQ = new string[SoLuong];
            for (int i = 0; i < SoLuong; i++)
            {
                KQ[i] = s.Substring(i * 64, 64);
            }
            return (KQ);
        }
        public static string Thap_Nhi1(int n)
        {
            string strNhiPhan = "";

            Stack<int> np = new Stack<int>();

            while (n != 0)
            {
                np.Push(n % 2);
                n /= 2;
            }

            while (np.Count > 0)
            {
                strNhiPhan += np.Pop().ToString();
            }


            while (strNhiPhan.Length < 8)
                strNhiPhan = "0" + strNhiPhan;

            return strNhiPhan;
        }
        public static string CatDuLieu64(string data)//lấy phần dữ liệu đầu vào của plaintext trước khi thêm bit 0
        {
            string KQ = "";
            try
            {
                string ChuoiChieuDai = data.Substring(data.Length - 64, 64);// lấy 64 bit cuối
                int d = Nhi_Thap(ChuoiChieuDai); // chuyển sang số
                KQ = data.Substring(0, data.Length - 64); // chỉ lấy số bit tương ứng vs chiefu dài
                if (d < 0 || d > KQ.Length)
                    return null;
                KQ = KQ.Substring(0, d);
            }
            catch (Exception e)
            {
                MessageBox.Show("Đoạn mã không hợp lệ");
            }
            return KQ;
        }
    }
    class RoundKey
    {

        public string KhoaChinh; //khoá chính 64bit
        public static string[] KhoaPhu { get; private set; }//mảng 16 khoá con

        //hoán vị Key
        private static readonly int[] keyp = { 57, 49, 41, 33, 25, 17, 9,
                                             1, 58, 50, 42, 34, 26, 18,
                                             10, 2, 59, 51, 43, 35, 27,
                                             19, 11, 3, 60, 52, 44, 36,
                                             63, 55, 47, 39, 31, 23, 15,
                                             7, 62, 54, 46, 38, 30, 22,
                                             14, 6, 61, 53, 45, 37, 29,
                                             21, 13, 5, 28, 20, 12, 4 };
        //số bit hoán vị theo từng vòng
        private static readonly int[] shift_table = new int[] { 1, 1, 2, 2,
                                                                2, 2, 2, 2,
                                                                1, 2, 2, 2,
                                                                2, 2, 2, 1 };
        //hoán vị lặp lại lần cuối
        private static readonly int[] key_comp = { 14, 17, 11, 24, 1, 5,
                                                     3, 28, 15, 6, 21, 10,
                                                     23, 19, 12, 4, 26, 8,
                                                     16, 7, 27, 20, 13, 2,
                                                     41, 52, 31, 37, 47, 55,
                                                     30, 40, 51, 45, 33, 48,
                                                     44, 49, 39, 56, 34, 53,
                                                     46, 42, 50, 36, 29, 32 };
        //chuyển bản rõ sang nhị phân
        public static string ChuyenASCsangNhiPhan(string BanRo)
        {

            FileStream file = new FileStream("ASCtoNhiPhan", FileMode.Open, FileAccess.Read, FileShare.None);

            StreamReader doc = new StreamReader(file);

            //đọc từng dòng một
            string Temp = "", NhiPhan = "", ThapPhan = "", Hex = "", ASC = "";

            string[] MangNhiPhan = new string[BanRo.Length];

            Temp = doc.ReadLine();
            int t = 0;

            while (Temp != null)
            {

                NhiPhan = Temp.Substring(0, 8).ToString();
                ThapPhan = Temp.Substring(9, 3).ToString().Trim();
                Hex = Temp.Substring(13, 2).ToString();
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
        //loại bỏ bit kiểm tra chẵn lẻ
        public static string boBitPanity(string K)
        {
            string str = "";

            int stat = 0;

            for (int i = 0; i < 8; i++)
            {
                str += K.Substring(stat, 7);
                stat += 8;
            }

            return str;
        }
        //hoán vị khóa 
        //public static string HoanVi(string k, int[] arr)
        //{
        //    string per = "";
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        per += k[arr[i] - 1];
        //    }
        //    return per;
        //}
        public static string DichTrai(string k, int shifts)//phép dịch bit sang trái shifts lần
        {
            string s = "";
            for (int i = 0; i < shifts; i++)
            {
                for (int j = 1; j < k.Length; j++)
                {
                    s += k[j];
                }
                s += k[0];
                k = s;
                s = "";
            }
            return k;
        }
        public static void SinhKhoaCon(string keyASC)
        {
            KhoaPhu = new string[16];// mảng khoá phụ cho 16 round
                                     //chuyển khóa sang nhị phân
            string KhoaChinh = ChuyenASCsangNhiPhan(keyASC);
            string K = KhoaChinh;
            //loại bỏ bit thừa thành 56bit
            KhoaChinh = boBitPanity(KhoaChinh);
            //hoán vị 
            string KeySauPC1 = Method.HoanVi(K, keyp);// đưa qua hộp hoán vị nén Pbox

            //chia thành 2 nửa trái phải
            string left = KeySauPC1.Substring(0, 28);
            string right = KeySauPC1.Substring(28, 28);

            for (int i = 0; i < 16; i++)
            {
                //dịch trái theo bảng dịch
                left = DichTrai(left, shift_table[i]);
                right = DichTrai(right, shift_table[i]);

                string combine = left + right;//Gộp lại

                KhoaPhu[i] = Method.HoanVi(combine, key_comp);//Đưa qua hộp nén lần 2 rồi lưu vào mảng
            }
        }
    }
    class F_function
    {
        //bảng hoán vị mở rộng Expand 32->48bit 
        private static readonly int[] exp_d ={ 32, 1, 2, 3, 4, 5, 4, 5, 6, 7, 8, 9, 8,
                                            9, 10, 11, 12, 13, 12, 13, 14, 15, 16,
                                            17, 16, 17, 18, 19, 20, 21, 20, 21, 22,
                                            23, 24, 25, 24, 25, 26, 27, 28, 29, 28,
                                            29, 30, 31, 32, 1 };
        //Các hộp Sbox từ 48->32bit
        private static readonly int[,] sBox1 ={ { 14, 4, 13, 1, 2, 15, 11, 8, 3, 10, 6, 12, 5, 9, 0, 7 },
                                        { 0, 15, 7, 4, 14, 2, 13, 1, 10, 6, 12, 11, 9, 5, 3, 8 },
                                        { 4, 1, 14, 8, 13, 6, 2, 11, 15, 12, 9, 7, 3, 10, 5, 0 },
                                        { 15, 12, 8, 2, 4, 9, 1, 7, 5, 11, 3, 14, 10, 0, 6, 13 } };
        private static readonly int[,] sBox2 ={ { 15, 1, 8, 14, 6, 11, 3, 4, 9, 7, 2, 13, 12, 0, 5, 10 },
                                        { 3, 13, 4, 7, 15, 2, 8, 14, 12, 0, 1, 10, 6, 9, 11, 5 },
                                        { 0, 14, 7, 11, 10, 4, 13, 1, 5, 8, 12, 6, 9, 3, 2, 15 },
                                        { 13, 8, 10, 1, 3, 15, 4, 2, 11, 6, 7, 12, 0, 5, 14, 9 } };
        private static readonly int[,] sBox3 ={ { 10, 0, 9, 14, 6, 3, 15, 5, 1, 13, 12, 7, 11, 4, 2, 8 },
                                        { 13, 7, 0, 9, 3, 4, 6, 10, 2, 8, 5, 14, 12, 11, 15, 1 },
                                        { 13, 6, 4, 9, 8, 15, 3, 0, 11, 1, 2, 12, 5, 10, 14, 7 },
                                        { 1, 10, 13, 0, 6, 9, 8, 7, 4, 15, 14, 3, 11, 5, 2, 12 } };
        private static readonly int[,] sBox4 ={ { 7, 13, 14, 3, 0, 6, 9, 10, 1, 2, 8, 5, 11, 12, 4, 15 },
                                        { 13, 8, 11, 5, 6, 15, 0, 3, 4, 7, 2, 12, 1, 10, 14, 9 },
                                        { 10, 6, 9, 0, 12, 11, 7, 13, 15, 1, 3, 14, 5, 2, 8, 4 },
                                        { 3, 15, 0, 6, 10, 1, 13, 8, 9, 4, 5, 11, 12, 7, 2, 14 } };
        private static readonly int[,] sBox5 ={ { 2, 12, 4, 1, 7, 10, 11, 6, 8, 5, 3, 15, 13, 0, 14, 9 },
                                        { 14, 11, 2, 12, 4, 7, 13, 1, 5, 0, 15, 10, 3, 9, 8, 6 },
                                        { 4, 2, 1, 11, 10, 13, 7, 8, 15, 9, 12, 5, 6, 3, 0, 14 },
                                        { 11, 8, 12, 7, 1, 14, 2, 13, 6, 15, 0, 9, 10, 4, 5, 3 } };
        private static readonly int[,] sBox6 ={ { 12, 1, 10, 15, 9, 2, 6, 8, 0, 13, 3, 4, 14, 7, 5, 11 },
                                        { 10, 15, 4, 2, 7, 12, 9, 5, 6, 1, 13, 14, 0, 11, 3, 8 },
                                        { 9, 14, 15, 5, 2, 8, 12, 3, 7, 0, 4, 10, 1, 13, 11, 6 },
                                        { 4, 3, 2, 12, 9, 5, 15, 10, 11, 14, 1, 7, 6, 0, 8, 13 } };
        private static readonly int[,] sBox7 ={ { 4, 11, 2, 14, 15, 0, 8, 13, 3, 12, 9, 7, 5, 10, 6, 1 },
                                        { 13, 0, 11, 7, 4, 9, 1, 10, 14, 3, 5, 12, 2, 15, 8, 6 },
                                        { 1, 4, 11, 13, 12, 3, 7, 14, 10, 15, 6, 8, 0, 5, 9, 2 },
                                        { 6, 11, 13, 8, 1, 4, 10, 7, 9, 5, 0, 15, 14, 2, 3, 12 } };
        private static readonly int[,] sBox8 ={ { 13, 2, 8, 4, 6, 15, 11, 1, 10, 9, 3, 14, 5, 0, 12, 7 },
                                        { 1, 15, 13, 8, 10, 3, 7, 4, 12, 5, 6, 11, 0, 14, 9, 2 },
                                        { 7, 11, 4, 1, 9, 12, 14, 2, 0, 6, 10, 13, 15, 3, 5, 8 },
                                        { 2, 1, 14, 7, 4, 10, 8, 13, 15, 12, 9, 0, 3, 5, 6, 11 } };

        //Hộp Pbox hoán vị 32bit
        private static readonly int[] per ={ 16, 7, 20, 21, 29, 12, 28, 17, 1, 15, 23,
                                        26, 5, 18, 31, 10, 2, 8, 24, 14, 32,
                                        27, 3, 9, 19, 13, 30, 6, 22, 11, 4, 25 };


        //hàm thực hiện mã hoá

        private static string Tinh1SBox(string chuoiVao, int[,] sBox)//đưa 6 bit qua Sbox thu được 4bit
        {
            // giá trị hàng = giá trị hệ 10 của hai bit đầu và cuối
            // giá trị cột= giá trị hệ 10 của 4 bit còn lại
            string B0B5 = "" + chuoiVao[0] + chuoiVao[5];
            int Hang = Method.Nhi_Thap(B0B5);
            string B1B2B3B4 = chuoiVao.Substring(1, 4);
            int Cot = Method.Nhi_Thap(B1B2B3B4);

            int GiaTriSbox = sBox[Hang, Cot];
            return (Method.Thap_Nhi(GiaTriSbox, 4));// chuyển giá trị tại sbox sang nhị phân
        }
        public static string TinhSBox(string chuoiVao)//khi đưa cả 48bit qua Sbox
        {
            string chuoiKQ = "";
            string[] ChuoiBiChia = new string[8];
            for (int i = 0; i < 8; i++)
            {
                ChuoiBiChia[i] = chuoiVao.Substring(i * 6, 6);
            }
            chuoiKQ = Tinh1SBox(ChuoiBiChia[0], sBox1);
            chuoiKQ += Tinh1SBox(ChuoiBiChia[1], sBox2);
            chuoiKQ += Tinh1SBox(ChuoiBiChia[2], sBox3);
            chuoiKQ += Tinh1SBox(ChuoiBiChia[3], sBox4);
            chuoiKQ += Tinh1SBox(ChuoiBiChia[4], sBox5);
            chuoiKQ += Tinh1SBox(ChuoiBiChia[5], sBox6);
            chuoiKQ += Tinh1SBox(ChuoiBiChia[6], sBox7);
            chuoiKQ += Tinh1SBox(ChuoiBiChia[7], sBox8);
            return chuoiKQ;
        }
        public string HamF(string ChuoiVao, string KhoaCon)//Hàm tìm F
        {
            string KQ = Method.HoanVi(ChuoiVao, exp_d); // đưa qua hộp mở rộng Expand 32->48bit
            KQ = Method.XOR(KQ, KhoaCon);// xor với khoá
            KQ = TinhSBox(KQ); // tính hộp s-box
            KQ = Method.HoanVi(KQ, per); // tính P là ok
            return KQ;
        }
    }

    class DES_process
    {
        F_function f = new F_function();
        //bảng hoán vị trước khi bắt đầu
        private static readonly int[] initial_perm ={ 58, 50, 42, 34, 26, 18, 10, 2, 60, 52,
                                                    44, 36, 28, 20, 12, 4, 62, 54, 46, 38,
                                                    30, 22, 14, 6, 64, 56, 48, 40, 32, 24,
                                                    16, 8, 57, 49, 41, 33, 25, 17, 9, 1,
                                                    59, 51, 43, 35, 27, 19, 11, 3, 61, 53,
                                                    45, 37, 29, 21, 13, 5, 63, 55, 47, 39,
                                                    31, 23, 15, 7 };
        //bảng hoán vị sau khi kết thúc
        private static readonly int[] final_perm ={ 40, 8, 48, 16, 56, 24, 64, 32, 39, 7,
                                                    47, 15, 55, 23, 63, 31, 38, 6, 46, 14,
                                                    54, 22, 62, 30, 37, 5, 45, 13, 53, 21,
                                                    61, 29, 36, 4, 44, 12, 52, 20, 60, 28,
                                                    35, 3, 43, 11, 51, 19, 59, 27, 34, 2,
                                                    42, 10, 50, 18, 58, 26, 33, 1, 41, 9,
                                                    49, 17, 57, 25 };
        //thực hiện mã hoá
        public string MaHoa(string plaintext, string keyDES, int chose, TextBox tb)//chose=1 mã hoá, chose=-1 giải m
        {
            RoundKey.SinhKhoaCon(keyDES);//chạy hàm tạo khoá con cho các round
            string plainText;
            if (chose == 1)//nếu là mã hoá
            {
                plainText = Method.Chuoi_Nhi(plaintext);//chuyển chuỗi sang nhị phân
                plainText = Method.ChinhDoDai64(plainText);//thêm bit 0 để số bit là bội của 64
            }
            else
            {
                plainText = plaintext;
            }
            tb.Text = "Chuoi ma hoa la: " + plainText + "\r\n\r\n";
            string[] pt = Method.TachChuoi(plainText);//chia thành mảng các chuỗi 64bit để xly

            string SauIP, left, right, F;

            string CipherText = "";

            for (int i = 0; i < pt.Length; i++)//xử lý từng khối 64bit 
            {
                tb.Text = tb.Text + "Xử lý chuỗi thứ " + (i + 1).ToString() + ": " + pt[i] + " \r\n";
                string temp = "";
                SauIP = Method.HoanVi(pt[i], initial_perm);//đưa qua hộp hoán vị đầu vào
                                                           //chia đôi chuỗi
                left = SauIP.Substring(0, 32);
                right = SauIP.Substring(32, 32);

                for (int j = 0; j < 16; j++)//16 round của DES
                {
                    F = f.HamF(right, RoundKey.KhoaPhu[chose == 1 ? j : 15 - j]);//tìm hàm F 
                    left = Method.XOR(left, F);//xor left với F
                                               //hoán vị
                    temp = left;
                    left = right;
                    right = temp;
                    int iTemp = (chose == 1 ? j : 15 - j) + 1;
                    string strTemp = left + right;
                    tb.Text = tb.Text + "Round " + iTemp.ToString() + ": " + "\r\n" +
                        "\tC = " + strTemp + "\r\n" + "\tK = " + RoundKey.KhoaPhu[chose == 1 ? j : 15 - j]
                        + "\r\n";
                }
                string temp1 = "";

                //hoán vị 2 chuỗi
                temp1 += right;
                temp1 += left;

                CipherText += Method.HoanVi(temp1, final_perm);//đưa qua hộp hvi đầu ra
                tb.Text = tb.Text + "Hoán vị: " + CipherText + "\r\n\r\n";
            }
            //CipherText = Method.Binary2String(CipherText);
            if (chose == -1)
            {
                CipherText = Method.CatDuLieu64(CipherText);//loại bỏ các bit đã thêm
                if (CipherText != null)
                {
                    CipherText = Method.Nhi_Chuoi(CipherText);//đưa về kiểu string để hiển thị
                }
                else
                {
                    MessageBox.Show("Không thể giải mã");
                    return null;
                }
            }
            return CipherText;
        }
    }
}