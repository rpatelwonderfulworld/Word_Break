using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            wordBreak("AmazonKindle");
            Console.ReadLine();
        }

        public static void wordBreak(string strInput)
        {
            if (strInput == null)
                Console.WriteLine("error");

            if (strInput.Length == 0)
                Console.WriteLine("error");

            char[] arr = strInput.ToCharArray();
 
            StringBuilder sb = new StringBuilder("");

            for (int i = 0; i < arr.Length; i++)
            {
                sb.Append(arr[i]);

                if (wordDict(sb) == true )
                {
                    sb.Append(" ");
                    Console.WriteLine(sb);
                }
            }

        }
        public static Boolean wordDict(StringBuilder sb)
        {
            string[] strArry = {"Amazon","Kindle","Roshni","Patel"};

            string[] inputStr = sb.ToString().Split(' ');

            foreach (string str in inputStr)
            {
                return strArry.Contains(sb.ToString()); 
            }

            return false;
    
        }
    }
}
