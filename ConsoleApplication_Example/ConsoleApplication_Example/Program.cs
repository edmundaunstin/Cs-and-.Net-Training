using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string newvalue = "India Pvt. Ltd.";
            Console.Write("ENTER YOUR COMPANY NAME :");
            String comname = Console.ReadLine();
            Console.WriteLine("NAME OF YOUR COMPANY :"+comname);  // concatination method
            Console.WriteLine("NAME OF YOUR COMPANY :{0} {1}", comname,newvalue);  //Placehold
            

            GetValues o1 = new GetValues();
            o1.name = Console.ReadLine();
            o1.id = Convert.ToInt32(Console.ReadLine());
            Console.Write("NAME OF YOUR COMPANY :{0} {1}", o1.name, o1.id);
            Console.Read();
            int[] a = new int[] { 1, 2, 3, 4 };
            
            
        }
    }
    public class GetValues
    {

        public string name; 
        public int id;
    }
    
}
