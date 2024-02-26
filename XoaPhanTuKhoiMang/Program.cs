using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XoaPhanTuKhoiMang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Khai báo và khởi tạo mảng số nguyên
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Nhập X là phần tử cần xóa
            Console.WriteLine("Nhập phần tử cần xóa:");
            int x = int.Parse(Console.ReadLine());

            // Tìm X xem có xuất hiện trong mảng không
            int index_del = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == x)
                {
                    index_del = i;
                    break;
                }
            }

            // Nếu X không có trong mảng, thông báo và kết thúc
            if (index_del == -1)
            {
                Console.WriteLine("Phần tử {0} không tồn tại trong mảng!", x);
                return;
            }

            // Xóa phần tử X khỏi mảng
            for (int i = index_del; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            // Cập nhật số lượng phần tử trong mảng
            Array.Resize(ref array, array.Length - 1);

            // In ra mảng sau khi xóa
            Console.WriteLine("Mảng sau khi xóa:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
