using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace CheckList
{
    class MainHandler
    {
        public static List<CheckList> checkLists = new List<CheckList>();
        public static void LoadCheckList()
        {
            checkLists.Add(new CheckList());
            using (StreamReader sr = new StreamReader("test.txt", System.Text.Encoding.Default))
            {
                string line;
                string[] splitedLine;
                while ((line = sr.ReadLine()) != null)
                {
                    splitedLine = line.Split(';');
                    checkLists[0].Tasks.Add(new Task(splitedLine[0], splitedLine[1]));
                }
            }
        }
    }
}
