using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto_app.MaHoaCoDien
{
    class Hill
    {
        private int[,] keyMatrix;
        private int n;

        public int[,] KeyMatrix { get => keyMatrix; set => keyMatrix = value; }
        public int N { get => n; set => n = value; }

        public Hill()
        {

        }
        //khởi tạo ma trận Khoá từ chuỗi khoá
        public int[,] initKey(string key)
        {
            int[,] temp = new int[N, N];
            int k = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    temp[j, i] = (key[k]) - 65;
                    k++;
                }
            }
            return temp;
        }
        //khởi tạo ma trận thông điệp
        public int[,] initMessage(string message, int m)
        {
            int[,] temp = new int[N, m];
            int k = 0;
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < N; i++)
                {
                    temp[i, j] = (message[k]) - 65;
                    k++;
                }
            }
            return temp;
        }

        // Mã hoá & giải mã (1 phần của thông điệp có chiều dài = khoá)

        public void encrypt(int[,] output, int[,] input, int[,] Key)
        {
            int x, i, j;
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < 1; j++)
                {
                    output[i, j] = 0;

                    for (x = 0; x < N; x++)
                    {
                        output[i, j] += Key[i, x] * input[x, j];
                    }

                    output[i, j] = output[i, j] % 26;
                }
            }
        }
        // chia thông điệp ra để mã hoá nhiều lần
        //m là số lần 
        public string encrypt1(int m, int[,] messageVector, int[,] Key)
        {
            String CipherText = "";
            for (int i = 0; i < m; i++)
            {
                int[,] mesTemp = new int[N, 1];
                int[,] cipherMatrix = new int[N, 1];
                for (int j = 0; j < n; j++)
                {
                    mesTemp[j, 0] = messageVector[j, i];
                }
                encrypt(cipherMatrix, mesTemp, Key);
                for (int k = 0; k < n; k++)
                    CipherText += (char)(cipherMatrix[k, 0] + 65);
            }
            return CipherText;
        }

        // Mã hoá bằng Hill với đầu vào string
        public string HillCipher(int[,] messageVector, int m)
        {
            //khởi tạo ma trận Khoá
            if (DinhThuc(KeyMatrix, N) == 0)
            {
                Console.WriteLine("Ma trận không khả nghịch");
                return null;
            }
            else
            {
                return encrypt1(m, messageVector, KeyMatrix);
            }
        }
        //giải mã với đầu vào string
        public string HillDecrypt(int[,] messageVector, int m)
        {
            //ma trận khoá nghịch đảo
            int[,] inv = new int[N, N];
            inverse(keyMatrix, inv);

            return encrypt1(m, messageVector, inv);
        }



        public void getCofactor(int[,] A, int[,] temp, int p, int q)
        {
            int i = 0, j = 0;

            // Looping for each element of the matrix 
            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    // Copying into temporary matrix only those element 
                    // which are not in given row and column 
                    if (row != p && col != q)
                    {
                        temp[i, j++] = A[row, col];

                        // Row is filled, so increase row index and 
                        // reset col index 
                        if (j == n - 1)
                        {
                            j = 0;
                            i++;
                        }
                    }
                }
            }
        }
        //tính định thức
        public int DinhThuc(int[,] A, int nn)
        {
            int D = 0;
            if (nn == 1)
                return A[0, 0];

            int[,] temp = new int[nn, nn]; // To store cofactors 

            int sign = 1; // To store sign multiplier 

            // Iterate for each element of first row 
            for (int f = 0; f < nn; f++)
            {
                // Getting Cofactor of A[0,f] 
                getCofactor(A, temp, 0, f);
                D += sign * A[0, f] * DinhThuc(temp, nn - 1);

                // terms are to be added with alternate sign 
                sign = -sign;
            }
            return D;
        }

        // Function to get adjoint of A[N,N] in adj[N,N]. 
        public void adjoint(int[,] A, int[,] adj)
        {
            if (n == 1)
            {
                adj[0, 0] = 1;
                return;
            }

            // temp is used to store cofactors of [,]A 
            int sign = 1;
            int[,] temp = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // Get cofactor of A[i,j] 
                    getCofactor(A, temp, i, j);

                    // sign of adj[j,i] positive if sum of row 
                    // and column indexes is even. 
                    sign = ((i + j) % 2 == 0) ? 1 : -1;

                    // Interchanging rows and columns to get the 
                    // transpose of the cofactor matrix
                    adj[j, i] = sign * (DinhThuc(temp, n - 1));
                    if (adj[j, i] < 0)
                        adj[j, i] = 26 + adj[j, i] % 26;

                }
            }
        }
        public int DongDu(int a, int m)
        {
            a = a % m;
            for (int x = 1; x < m; x++)
                if ((a * x) % m == 1)
                    return x;
            return 1;
        }
        //tính ma trận nghịch đảo
        public bool inverse(int[,] A, int[,] inverse)
        {
            // Find DinhThuc of [,]A 
            int det = DinhThuc(A, n);
            if (det == 0)
            {
                Console.Write("Singular matrix, can't find its inverse");
                return false;
            }

            // Find adjoint 
            int[,] adj = new int[n, n];
            adjoint(A, adj);

            // Find Inverse using formula "inverse(A) = adj(A)/det(A)" 
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    inverse[i, j] = adj[i, j] * DongDu(det, 26);

            return true;
        }
    }
}
