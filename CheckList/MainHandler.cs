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

        public static List<CheckListClass> checkLists = new List<CheckListClass>();

        public static void LoadInfo()
        { 
            DataCheckList.LoadEncrypt();
            DataCheckList.LoadSaveTrack(false);
            platoons = Platoons.LoadPlatList(false);
            subjects = Subjects.LoadSubList(false);
        }

        public static void MoveDerictory()
        {
            String sourcePath;
            try
            {
                StreamReader sr = new StreamReader("ServerPath.txt");
                sourcePath = sr.ReadLine();
                sr.Close();
                if (Directory.Exists(Directory.GetCurrentDirectory() + "\\CheckList") && Directory.Exists(sourcePath))
                {
                    Directory.Delete(Directory.GetCurrentDirectory() + "\\CheckList", true);
                }
                foreach (string dirPath in Directory.GetDirectories(sourcePath, "*",
                    SearchOption.AllDirectories))
                    Directory.CreateDirectory(dirPath.Replace(sourcePath, Directory.GetCurrentDirectory()
                        + "\\CheckList"));

                foreach (string newPath in Directory.GetFiles(sourcePath, "*.*",
                    SearchOption.AllDirectories))
                    File.Copy(newPath, newPath.Replace(sourcePath, Directory.GetCurrentDirectory()
                        + "\\CheckList"), true);
            }
            catch (IOException e)
            {
                MessageBox.Show("Не удалось открыть файлы с тестами...");
                if (!Directory.Exists("CheckList"))
                {
                    Directory.CreateDirectory("CheckList");
                    Directory.CreateDirectory("CheckList/Inform");
                    File.Create("CheckList//Inform//Platoons.plat").Close();
                    File.Create("CheckList//Inform//subjects.sub").Close();
                    Directory.CreateDirectory("CheckList/Pictures");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        public static void LoadCheckList(List<string> dirs)
        {
            checkLists.Clear();
            //string[] dirs = Directory.GetFiles("CheckList\\", "*.test");
            foreach (var item in dirs)
            {
                var json = File.ReadAllText("CheckList\\" + item);
                CheckListClass tmp = JsonConvert.DeserializeObject<CheckListClass>(json);
                checkLists.Add(tmp);
            }
        }

        public static void CreateSession(Platoon platoon, Student student, CheckListClass checkList, Subject subject, bool isTest)
        {
            session = new Session(platoon, subject, checkList, student, isTest);
        }
    }
}
