using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace bt_20._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[50, 50];
            Console.WriteLine("Nhap kich thuoc cua ma tran 1 (<5): ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap cac phan tu ma tran 1: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    arr1[i, j] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("In ma tran 1");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.WriteLine(arr1[i, j]);
            }

            int sum = 0;
            for (int i = 0; i <n; i++)
            {
                sum += arr1[i, i];
            }
            Console.WriteLine(sum);
        }
    }
}
