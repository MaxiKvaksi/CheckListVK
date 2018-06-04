using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using CheckList_Konstruktor;
using CheckList;
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

        public static void SaveResult()
        {
            String sourcePath;
            try
            {
                StreamReader sr = new StreamReader("ServerPath.txt");
                sourcePath = sr.ReadLine() + "Marks.marks";
                sr.Close();
                if (!File.Exists(sourcePath))
                {
                    File.Create(sourcePath);
                }
                Result result = new Result(session.Subject.Name, session.CheckList.Inform.Name,
                    session.Platoon.PlatNum.ToString(), session.Student.Fio);
                string data = JsonConvert.SerializeObject(result);
                File.AppendAllText(sourcePath, data);
            }
            catch (Exception e)
            {

            }
        }
    }
}
