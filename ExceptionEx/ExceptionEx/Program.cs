using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExceptionEx
{
    class MyCustomClass:Exception
    {
        public MyCustomClass(String msg):base(msg) 
        {
            throw new Exception(msg);     
        }
    }
    
    internal class Program
    {
        //demo
        public static void ChekcValue(int x,int y)
        {
            try
            {
                //int[] myNumbers = { 1, 2, 3 };
                //Console.WriteLine(myNumbers[10]);
                if (y==0)
                {
                    throw new DivideByZeroException();
                }
                if(x>50)
                {
                    throw new MyCustomClass("This is Custorm Exception");
                }
                Console.WriteLine(x/y);
            }
            catch
            {
                throw;
            }
        }
        static void Main(string[] args)
        {
            
            try
            {
                int a = 12;
                int b = 12;
                ChekcValue(a,b);
            }
            catch (Exception e)
            {
                //File.WriteAllText("D:/Myfile.txt", $"{DateTime.Now} => Error message : {e.Message} \n Stacktrace : {e.StackTrace.ToString()}");
                Console.WriteLine(e.Message);
            }            
            finally
            {
                Console.WriteLine("File running..");
            }
        }
    }
}
