using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demSoLanXuatHienKyTu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập chuỗi: ");
            string str = Console.ReadLine();
            Console.WriteLine("Nhập ký tự cần đếm: ");
            char cha = Console.ReadKey().KeyChar;
            int count = Dem (str, cha);
            Console.WriteLine($"\nSố lần xuất hiện của '{cha}' trong chuỗi '{str}' là: ");
        }

    
        public static int Dem (string chuoi, char kyTu)
        {
            int dem = 0;
            for (int i = 0; i < chuoi.Length; i++)
            {
                if (chuoi[i] == kyTu)
                {
                    dem++;
                }
            }
            return dem;
        }

    }
}
