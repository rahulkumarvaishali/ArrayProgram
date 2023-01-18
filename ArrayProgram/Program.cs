using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Sise of array :");
            int x=Convert.ToInt32(Console.ReadLine());
            int[]arr=new int[x];
            for(int y = 0; y < x; y++) 
            {
                Console.Write("Enter the " + y + " Element : ");
                arr[y] = Convert.ToInt32(Console.ReadLine());
            }
            for(int z=0;z<arr.Length;z++) 
            {
                Console.Write(arr[z]+" ");
            }
            Console.ReadLine();
        }
    }
}
