using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemKyTu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Xin chào, thế giới!";

            // Nhập ký tự cần đếm
            Console.WriteLine("Nhập ký tự cần đếm:");
            char c = char.Parse(Console.ReadLine());

            // Khai báo biến đếm
            int count = 0;

            // Duyệt từng ký tự trong chuỗi
            for (int i = 0; i < str.Length; i++)
            {
                // So sánh ký tự trong chuỗi với ký tự nhập vào
                if (str[i] == c)
                {
                    // Tăng biến đếm lên 1
                    count++;
                }
            }

            // In ra số lần xuất hiện
            Console.WriteLine("Số lần xuất hiện của '{0}' trong chuỗi là: {1}", c, count);
        }
    }
}
