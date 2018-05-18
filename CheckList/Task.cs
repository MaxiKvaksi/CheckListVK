using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckList
{
    class Task
    {
        string name;       //имя пункта
        string description;//полное описание пункта
        Bitmap image;      //фото для пункта

        public Task(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
    }
}
