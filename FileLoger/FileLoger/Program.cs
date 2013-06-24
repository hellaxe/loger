using System;

namespace FileLoger
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("FileLoger v. 1.0 ");
                Console.WriteLine("Please enter the folder full path");
                var path = Console.ReadLine();
              
                var loger = new Loger(path);
                loger.GetLog();
                loger.SaveLog();
                Console.WriteLine("Press Enter to continue");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
