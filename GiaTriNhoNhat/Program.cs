using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaTriNhoNhat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            Console.WriteLine("Nhap chieu dai n cua mang: ");
            int n = int.Parse(Console.ReadLine());
            NhapMang(arr, n);
            Min(arr, n);


        }

         static void NhapMang(int[] arr,int n)
        {
            for (int i = 0; i < n; i++) 
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        static void Min(int[] arr,int n)
        {
            int min = arr[0];
            for (int i = 1; i < n; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }
            Console.WriteLine("Phan tu nho nhat: " + min);
        }
    }
}
