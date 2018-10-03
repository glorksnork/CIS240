using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account1[] accounts =
                {
                new Account1("gLORK",500),
                new Account1("sNORK", 340),
                new Account1("bORK")
                };

            foreach (Account1 acct in accounts)
                Console.WriteLine(acct);
            }
        }
    }

