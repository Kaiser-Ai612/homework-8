using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using дз_8_1;
using дз_8_1.@class;


namespace dz8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee timur = new Employee("Тимур"); // Гендиректор
            Employee rashid = new Employee("Рашид", timur); // Финдиректор
            Employee ilham = new Employee("О Ильхам", timur); // Директор по автоматизации

            Employee lukas = new Employee("Лукас", rashid); // Главбух

            // информационные технологии
            Employee orkadiy = new Employee("Оркадий", ilham); // Начальник 
            Employee volodya = new Employee("Володя", ilham); // Зам.начальника 

            //системщики
            Employee ilshat = new Employee("Ильшат", orkadiy); // Главный системщик
            Employee ivanych = new Employee("Иваныч", ilshat); // Зам.системщика
            Employee ilya = new Employee("Илья", ilshat); // Системщик
            Employee vitya = new Employee("Витя", ilshat); // Системщик
            Employee zhenya = new Employee("Женя", ilshat); // Системщик

            //разрабы
            Employee sergey = new Employee("Сергей", orkadiy); // Главный разраб
            Employee laysan = new Employee("Ляйсан", sergey); // Зам.разраб
            Employee marat = new Employee("Марат", sergey); // Разраб
            Employee dina = new Employee("Дина", sergey); // Разраб
            Employee ildar = new Employee("Ильдар", sergey); // Разраб
            Employee anton = new Employee("Антон", sergey); // Разраб

            // Создание проекта
            Project project = new Project("Разработка ПО", DateTime.Now.AddMonths(3), timur, ilham);

            // Создание задач
            Task1 task1 = new Task1("Анализ требований", DateTime.Now.AddDays(12), timur);
            Task1 task2 = new Task1("Проектирование системы", DateTime.Now.AddDays(13), timur);
            Task1 task3 = new Task1("Разработка функционала", DateTime.Now.AddDays(14), timur);
            Task1 task4 = new Task1("Тестирование системы", DateTime.Now.AddDays(15), timur);
            Task1 task5 = new Task1("Подготовка документации", DateTime.Now.AddDays(16), timur);

            // Добавление задач в проект
            project.AddTask(task1);
            project.AddTask(task2);
            project.AddTask(task3);
            project.AddTask(task4);
            project.AddTask(task5);

            // Перевод проекта в статус "Исполнение"
            project.StartProject();

            // Назначение задач сотрудникам
            rashid.AcceptTask(task1); 
            ilham.AcceptTask(task2); 
            sergey.AcceptTask(task3); 
            ilshat.AcceptTask(task4); 
            laysan.AcceptTask(task5);

            //
            if (rashid.DelegateTo(task1, lukas))
            {
                Console.WriteLine($"задача передана нижестоящему {rashid.Name} передал {lukas.Name}");
                lukas.AcceptTask(task1);
                Report report1 = new Report("Задача 1 выполнена", DateTime.Now, lukas);
                task1.Complete();
                report1.Odobrenie = true;
                
            }
            else
            {
                Console.WriteLine("задачу передать невозможно");
                Report report1 = new Report("Задача 1 выполнена", DateTime.Now, rashid);
                task1.Complete();
                report1.Odobrenie = true;
            }

            // Выполнение задач            
            ilham.AcceptTask(task2);
            sergey.AcceptTask(task3);
            ilshat.AcceptTask(task4);
            laysan.AcceptTask(task5);

            // Завершение задач
            task2.Complete();
            task3.Complete();
            task4.Complete();
            task5.Complete();

            // Создание отчетов
            Report report2 = new Report("Задача 2 выполнена", DateTime.Now, ilham);
            Report report3 = new Report("Задача 3 выполнена", DateTime.Now, sergey);
            Report report4 = new Report("Задача 4 выполнена", DateTime.Now, ilshat);
            Report report5 = new Report("Задача 5 выполнена", DateTime.Now, laysan);

            // Утверждение отчетов
            report2.Odobrenie = true;
            report3.Odobrenie = true;
            report4.Odobrenie = true;
            report5.Odobrenie = true;

            if (project.IsCompleted())
            {
                project.Status = ProjectStatus.Done;
                Console.WriteLine("Проект завершен!");
            }
            else
            {
                Console.WriteLine("Проект не завершен.");
            }
        }
    }
}