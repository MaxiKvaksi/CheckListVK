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
        public static bool isCrypto = true;

        public static List<CheckListClass> checkLists = new List<CheckListClass>();

        public static void LoadInfo()
        { 
            platoons = Platoons.LoadPlatList();
            subjects = Subjects.LoadSubList();
        }

        public static void MoveDirectory()
        {
            String sourcePath;
            try
            {
                StreamReader sr = new StreamReader("ServerPath.txt");
                sourcePath = sr.ReadLine();
                sr.Close();
                if (Directory.Exists(Directory.GetCurrentDirectory() + @"\CheckList") && Directory.Exists(sourcePath))
                {
                    Directory.Delete(Directory.GetCurrentDirectory() + @"\CheckList", true);
                }
                foreach (string dirPath in Directory.GetDirectories(sourcePath, "*",
                    SearchOption.AllDirectories))
                    Directory.CreateDirectory(dirPath.Replace(sourcePath, Directory.GetCurrentDirectory()
                        + @"\CheckList"));

                foreach (string newPath in Directory.GetFiles(sourcePath, "*.*",
                    SearchOption.AllDirectories))
                    File.Copy(newPath, newPath.Replace(sourcePath, Directory.GetCurrentDirectory()
                        + @"\CheckList"), true);
            }
            catch (IOException e)
            {
                MessageBox.Show("Не удалось открыть файлы с тестами...");
                if (!Directory.Exists("CheckList"))
                {
                    Directory.CreateDirectory("CheckList");
                    Directory.CreateDirectory("CheckList/Inform");
                    File.Create(@"CheckList/Inform/Platoons.plat").Close();
                    File.Create(@"CheckList/Inform/subjects.sub").Close();
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
            foreach (string item in dirs)
            {
                var jsonCryp = File.ReadAllText(@"CheckList\\" + item);
                if (isCrypto)
                {
                    jsonCryp = Sini4ka.Landing(jsonCryp, "синяя синичка");
                }
                CheckListClass tmp = JsonConvert.DeserializeObject<CheckListClass>(jsonCryp);
                checkLists.Add(tmp);
            }
        }

        public static void CreateSession(Platoon platoon, Student student, CheckListClass checkList, Subject subject, bool isTest)
        {
            session = new Session(platoon, subject, checkList, student, isTest);
        }

        public static void SaveResult(string mark, bool isTest)
        {
            String sourcePath;
            try
            {
                StreamReader sr = new StreamReader("ServerPath.txt");
                string srs = sr.ReadLine();
                sourcePath = srs + "\\Results\\" + "Marks.marks";
                sr.Close();
                if(!Directory.Exists(srs + @"\\Results"))
                {
                    Directory.CreateDirectory(srs + @"\\Results");
                }
                Result result = new Result(session.Subject.Name, session.CheckList.Inform.Name,
                    session.Platoon.PlatNum.ToString(), session.Student.Fio, mark, isTest, DateTime.Now);
                
                string data = JsonConvert.SerializeObject(result);
                if (isCrypto)
                {
                    if (File.Exists(sourcePath))
                    {
                        string buffer = File.ReadAllText(sourcePath);
                        string uncript = Sini4ka.Landing(buffer, "синяя синичка");
                        data = (uncript += "#" + data);
                    }
                    string cryptoS = Sini4ka.Flying(data, "синяя синичка");
                    File.WriteAllText(sourcePath, cryptoS);
                }
                else
                {
                    File.WriteAllText(sourcePath, data);
                }
            }
            catch (Exception e)
            {

            }
        }
    }
}
