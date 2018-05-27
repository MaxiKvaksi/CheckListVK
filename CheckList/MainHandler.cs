using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using CheckList_Konstruktor;

namespace CheckListNM
{
    class MainHandler
    {
        public static Form MainForm;
        public static Form TestForm;
        public static int timeResult = 0;
        public static Subjects subjects = new Subjects();
        public static Platoons platoons = new Platoons();
        public static Session session;
        public static List<CheckList> checkLists = new List<CheckList>();   

        public static void LoadInfo()
        {
            DataCheckList.LoadEncrypt();
            DataCheckList.LoadSaveTrack(false);
            platoons = Platoons.LoadPlatList(false);
            subjects = Subjects.LoadSubList(false);
            LoadCheckList();
        }

        static void LoadCheckList()
        {
            checkLists.Clear();
            string path = Directory.GetCurrentDirectory();
            string[] dirs = Directory.GetFiles(path + "\\CheckList\\", "*.test");
            foreach (var item in dirs)
            {
                var json = File.ReadAllText(item);
                CheckList tmp = JsonConvert.DeserializeObject<CheckList>(json);
                checkLists.Add(tmp);
            }
        }

        public static void CreateSession(Platoon platoon, Student student, CheckList checkList, Subject subject, bool isTest)
        {
            session = new Session(platoon, subject, checkList, student, isTest);
        }
    }
}
