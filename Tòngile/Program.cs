using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tòngile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FileStream fs = new FileStream("C:\\Users\\ADMIN\\Documents\\TextDemo.txt", FileMode.Open);
                FileInfo file = new FileInfo(args[0]);
                if (file.Exists)
                {
                    
                }
            }
            catch 
            { 

            }

        }
    }
}
