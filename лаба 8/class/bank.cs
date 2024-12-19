using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_8.@class
{
    internal class Bank : IDisposable
    {
        private uint id;
        private static uint idgen;
        public double balance;
        private accType? accType1 = null;
        //dz 8
        private Queue<BankTransaction>? tran;
        private bool disposed = false;
        public StreamWriter? text;
        //
        // dz 8
        //
        public Bank() { this.id = IdGen(); }
        public Bank(double balance)
        {
            this.balance = balance;
            this.id = IdGen();
        }
        public Bank(accType acc)
        {
            accType1 = acc;
            this.id = IdGen();
        }
        public Bank(double balance, accType accType1)
        {
            this.id = IdGen();
            this.balance = balance;
            this.accType1 = accType1;
        }
        //
        private uint IdGen()
        {
            idgen++;
            return idgen;
        }
        //daz 8 
        public void Snyat(double a)
        {
            if (tran == null)
            {
                tran = new Queue<BankTransaction>();
            }
            if (a < balance && a > 0)
            {
                balance -= a;
                BankTransaction operate = new BankTransaction(a);
                tran.Enqueue(operate);
            }
        }
        public void Vnesty(double a)
        {
            if (tran == null)
            {
                tran = new Queue<BankTransaction>();
            }
            if (a > 0)
            {
                balance += a;
                BankTransaction operate = new BankTransaction(a);
                this.tran.Enqueue(operate);
            }
        }
        // дз 7
        //
        public bool Perevod(Bank bank, double summa)
        {
            try
            {
                this.Snyat(summa);
                bank.Vnesty(summa);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        // 
        public void Dispose()
        {
            Dispose(true);//дает команду что нужно освободить ресурс
            GC.SuppressFinalize(this); // предотвращает вызов финализатора для этого объекта. если ресурсы уже освобождены
                                       // , нет смысла вызывать финализатор, который может пытаться освободить те же ресурсы.
        }
        //записывает инфу о переводах в файл 
        public void Write()
        {
            using (StreamWriter writer = new StreamWriter("file.txt", true))
            {
                if (tran == null)
                {
                    tran = new Queue<BankTransaction>();
                }
                while (tran.Count > 0)
                {
                    var transaction = tran.Dequeue();
                    writer.WriteLine($"{transaction.date}: {transaction.sum}");
                }
            }
        }
        // я не до конца поняла зачем это, но он нужен , а еще сам как то должен работать
        protected virtual void Dispose(bool d)
        {
            if (!d)//проверка освобожден ли ресурс
            {
                if (d) // если нет то освобождаем
                {
                    Write();
                }
                d = true;//объект был освобожден
            }
        }
        //
        public void Print()
        {
            Console.WriteLine($"id:{id},\n баланс:{balance} ,тип счета :{accType1}");
        }
    }
}

