using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_8.@class
{
    internal class BankTransaction
    {
        public DateTime date { get; }
        public double sum { get; }

        public BankTransaction() { }
        public BankTransaction(double money)
        {
            this.sum = money;
            this.date = DateTime.Now;
        }
        public void Print()
        {
            Console.WriteLine($"сумма:{sum} \n время:{date}");
        }
    }
}
