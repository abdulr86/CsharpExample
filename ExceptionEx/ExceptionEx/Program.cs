using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionEx
{
    internal class Program
    {
        //demo
        public static void chekcarray()
        {
            int[] myNumbers = { 1, 2, 3 };
            Console.WriteLine(myNumbers[10]);
        }
        static void Main(string[] args)
        {

            try
            {
                chekcarray();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }            
            finally
            {
                Console.WriteLine("File running..");
            }
        }
    }
}
