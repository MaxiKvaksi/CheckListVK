using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckList_Konstruktor
{
    public class Subject
    {
        private List<int> checkListIndexes = new List<int>();
        private string name;

        public Subject()
        {
            this.Name = "";
            this.CheckListIndexes = new List<int>();
        }
        public Subject(string name)
        {
            this.Name = name;
            this.CheckListIndexes = new List<int>();
        }

        public Subject(string name, List<int> checkListIndexes)
        {
            this.Name = name;
            this.CheckListIndexes = checkListIndexes;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<int> CheckListIndexes
        {
            get { return checkListIndexes; }
            set { checkListIndexes = value; }
        }
    }
}
