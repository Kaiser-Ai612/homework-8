using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using лаба_8.@class;

namespace laba8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Song mySong = new Song();
            Task4();
        }
        static void Task1()
        /*Упражнение 9.1 В классе банковский счет, созданном в предыдущих упражнениях, удалить
методы заполнения полей. Вместо этих методов создать конструкторы. Переопределить
конструктор по умолчанию, создать конструктор для заполнения поля баланс, конструктор
для заполнения поля тип банковского счета, конструктор для заполнения баланса и типа
банковского счета. Каждый конструктор должен вызывать метод, генерирующий номер
счета.
         */
        {
            Console.WriteLine("Упражнение 9.1");
            Bank bank = new Bank();
            Bank bank1 = new Bank(434352.5525);
            Bank bank2 = new Bank(accType.credit);
            Bank bank3 = new Bank(2458452374.2342, accType.credit);

            bank.Print();
            bank1.Print();
            bank2.Print();
            bank3.Print();

            bank.Vnesty(3522);
            //if (bank.Perevod(bank1, 42425.475))
            //{
            //    bank.Print();
            //    bank1.Print();
            //}
        }
        static void Task2()
        /*Упражнение 9.2 Создать новый класс BankTransaction, который будет хранить информацию
о всех банковских операциях. При изменении баланса счета создается новый объект класса
BankTransaction, который содержит текущую дату и время, добавленную или снятую со
счета сумму. Поля класса должны быть только для чтения (readonly). Конструктору класса
передается один параметр – сумма. В классе банковский счет добавить закрытое поле типа
System.Collections.Queue, которое будет хранить объекты класса BankTransaction для
данного банковского счета; изменить методы снятия со счета и добавления на счет так,
чтобы в них создавался объект класса BankTransaction и каждый объект добавлялся в
переменную типа System.Collections.Queue.
         */
        {
            Console.WriteLine("Упражнение 9.2");
            Bank bank = new Bank(4654646);
            Bank bank1 = new Bank(55562);

            bank.Print();
            bank1.Print();

            for (int i = 0; i < 3; i++)
            {
                if (bank.Perevod(bank1, 42425.475))
                {
                    bank.Print();
                    bank1.Print();
                }
            }
        }
        static void Task3()
        /*Упражнение 9.3 В классе банковский счет создать метод Dispose, который данные о
проводках из очереди запишет в файл. Не забудьте внутри метода Dispose вызвать метод
GC.SuppressFinalize, который сообщает системе, что она не должна вызывать метод
завершения для указанного объекта.
         */
        {
            Console.WriteLine("Упражнение 9.3");
            using (Bank acc = new Bank())
            {
                acc.Vnesty(100);
                acc.Snyat(50);
                acc.Vnesty(200);
                acc.Print();
            }
        }
        static void Task4()
        /*Домашнее задание 9.1 В класс Song (из домашнего задания 8.2) добавить следующие
конструкторы:
1) параметры конструктора – название и автор песни, указатель на предыдущую песню
инициализировать null.
2) параметры конструктора – название, автор песни, предыдущая песня. В методе Main
создать объект mySong. Возникнет ли ошибка при инициализации объекта mySong
следующим образом: Song mySong = new Song(); ?
Исправьте ошибку, создав необходимый конструктор.
         */
        {
            Console.WriteLine("Упражнение 9.1");
        }
    }
}