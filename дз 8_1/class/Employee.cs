using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_8_1.@class
{
    internal class Employee
    {
        public string Name { get; set; }
        public Employee Supervisor { get; set; }
        public List<Employee> Subordinates { get; set; }
        public List<Task1> AssignedTasks { get; set; }

        public Employee(string name, Employee supervisor = null)
        {
            Name = name;
            Supervisor = supervisor;
            Subordinates = new List<Employee>();
            AssignedTasks = new List<Task1>();
            if (supervisor != null)
            {
                supervisor.AddSubordinate(this);
            }
        }

        public void AddSubordinate(Employee subordinate)
        {
            Subordinates.Add(subordinate);
        }

        public bool AcceptTask(Task1 task)
        {
            // Логика принятия задачи
            // только начальство или конкретные сотрудники могут принимать задачи
            if (task.AssignedTo == null || task.AssignedTo == this)
            {
                AssignedTasks.Add(task);
                task.AssignTo(this);
                return true;
            }
            return false;
        }
        public bool DelegateTo(Task1 task, Employee newAssignee)
        {
                // Проверяем, что новый исполнитель является подчиненным
            if (Subordinates.Contains(newAssignee))
            {
                    // меняем исполнителя
                task.AssignTo(newAssignee);
                return true; 
            }
            return false; 
        }
        //public bool DelegateTask(Task1 task, Employee employee)
        //{
        //    if (Subordinates.Contains(employee))
        //    {
        //        task.AssignTo(employee);
        //        return true;
        //    }
        //    return false;
        //}
        public bool RejectTask(Task1 task)
        {
            if (AssignedTasks.Contains(task))
            {
                AssignedTasks.Remove(task);
                task.AssignTo(null);
                return true;
            }
            return false;
        }
    }
}
