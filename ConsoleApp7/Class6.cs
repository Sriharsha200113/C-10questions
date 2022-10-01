using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{ //problem 6
    internal class Class6
    {
        static void Main()
        { 
                string file;
                
                File.Copy("C:\\day\\file.txt", "C:\\day\\file2.txt");
                file = File.ReadAllText("C:\\day\\file1.txt");
                Console.WriteLine(file);
            
            
            
        }
    }
}
