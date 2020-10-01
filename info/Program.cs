using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace info
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Directory.GetLastWriteTime(@"C:\Users\Lenovo\Desktop\Folder"));
        }
    }
}
