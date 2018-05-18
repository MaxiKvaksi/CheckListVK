using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckList
{
    class CheckList
    {
        string name;//название чек листа
        List<Task> tasks;//список всех тасков
        
        public CheckList()
        {
            Tasks = new List<Task>();
        }

        public void AddTask(Task task)
        {
            Tasks.Add(task);
        }

        public List<Task> Tasks { get => tasks; set => tasks = value; }
    }   
}
