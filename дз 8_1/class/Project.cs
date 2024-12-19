using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace дз_8_1.@class
{
    internal class Project
    {
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public Employee Initiator { get; set; }
        public Employee ProjectLeader { get; set; }
        public List<Task1> Tasks { get; set; }
        public ProjectStatus Status { get; set; }

        public Project(string description, DateTime deadline, Employee initiator, Employee projectLeader)
        {
            Description = description;
            Deadline = deadline;
            Initiator = initiator;
            ProjectLeader = projectLeader;
            Tasks = new List<Task1>();
            Status = ProjectStatus.Project;
        }

        public void AddTask(Task1 task)
        {
            if (Status == ProjectStatus.Project)
            {
                Tasks.Add(task);
            }
        }
        // если уже есть задачи и статус проекта стоит ПРОЕКТ
        public void StartProject()
        {
            if (Tasks.Count > 0 && Status == ProjectStatus.Project)  
            {
                Status = ProjectStatus.VProcesse;//переключаем статус на ВПРОЦЕССЕ
            }
        }
        // проверка выполнена ли каждая задача, для этого статус проекта должнн быть DONE
        public bool IsCompleted()
        {
            foreach (var task in Tasks)
            {
                if (task.Status != TaskStat.Done )
                {
                    return false;
                }
            }
            return true;
        }
    }
}
