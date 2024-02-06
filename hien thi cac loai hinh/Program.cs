using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hien_thi_cac_loai_hinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choise = -1;
            choise = int.Parse(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    int n, m;
                    Console.WriteLine("Nhap chieu dai: ");
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap chieu rong: ");
                    m = int.Parse(Console.ReadLine());
                    for(int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    Console.WriteLine("Nhap chieu cao: ");
                    int h = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= h; i++)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 3:
                    Console.WriteLine("Nhap chieu cao: ");
                    int h1 = int.Parse(Console.ReadLine());
                    for (int i = h1; i >0; i--)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }    
                    break;
            }
        }
    }
}
