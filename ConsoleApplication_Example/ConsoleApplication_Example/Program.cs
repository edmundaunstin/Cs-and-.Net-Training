﻿using System;
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
            /*string newvalue = "India Pvt. Ltd.";
            Console.Write("ENTER YOUR COMPANY NAME :");
            String comname = Console.ReadLine();
            Console.WriteLine("NAME OF YOUR COMPANY :"+comname);  // concatination method
            Console.WriteLine("NAME OF YOUR COMPANY :{0} {1}", comname,newvalue);  //Placehold
            

            GetValues o1 = new GetValues();
            o1.name = Console.ReadLine();
            o1.id = Convert.ToInt32(Console.ReadLine());
            Console.Write("NAME OF YOUR COMPANY :{0} {1}", o1.name, o1.id);
            
            int[] a = new int[] { 1, 2, 3, 4 };*/




            DelegateClass de = new DelegateClass();
            string type = Console.ReadLine();
            int s = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(de.operationType(type).Invoke(s, d));

            Console.Read();

        }
    }
    public class GetValues
    {

        public string name; 
        public int id;
    }
    
}
