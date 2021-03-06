﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CheckListNM;

namespace CheckList_Konstruktor
{
    /// статичный класс данных чек листа для связи между формами
    public static class DataCheckList
    {
        private static CheckListClass check = null; //хранит чек листы
        private static Subjects cource = null; //хранит предметы
        private static Platoons platoons = null; //хранит взвода
        private static string saveTrack = ""; //хранит путь сохранения
        private static bool encrypt = false; //проверяет, шифровать или нет

        public static CheckListClass Check
        {
            get { return DataCheckList.check; }
            set { DataCheckList.check = value; }
        }

        public static Subjects Cource
        {
            get { return DataCheckList.cource; }
            set { DataCheckList.cource = value; }
        }

        internal static Platoons Platoons
        {
            get { return DataCheckList.platoons; }
            set { DataCheckList.platoons = value; }
        }

        public static string SaveTrack
        {
            get { return DataCheckList.saveTrack; }
            set { DataCheckList.saveTrack = value; }
        }

        public static bool Encrypt
        {
            get { return DataCheckList.encrypt; }
            set { DataCheckList.encrypt = value; }
        }

        public static void LoadSaveTrack(bool encrypt) //загружает путь сохранения
        {
            try
            {
                SaveTrack = File.ReadAllText(Application.StartupPath + @"\SaveTrack.tra");
                if (encrypt) SaveTrack = Sini4ka.Landing(SaveTrack, "синяя синичка");
            }
            catch (Exception e)
            {
                SaveTrack = "";
                MessageBox.Show(e.Message);
            }
        }
        public static void SaveSaveTrack(bool encrypt) //сохраняет суть сохранения
        {
            if (encrypt) SaveTrack = Sini4ka.Flying(SaveTrack, "синяя синичка");
            try
            {
                File.WriteAllText(Application.StartupPath + @"\SaveTrack.tra", SaveTrack);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            if (encrypt) SaveTrack = Sini4ka.Landing(SaveTrack, "синяя синичка");
        }

        public static void LoadEncrypt() //загружает параметр шифровки
        {
            string En = "";
            try
            {
                En = File.ReadAllText(Application.StartupPath + @"\Encr.ypt");
                if (En == "True")
                {
                    Encrypt = true;
                }
                else
                {
                    Encrypt = false;
                }
            }
            catch (Exception e)
            {
                Encrypt = false;
                MessageBox.Show(e.Message);
            }
        }
        public static void SaveEncrypt() //сохраняет параметр шифровки
        {
            try
            {
                File.WriteAllText(Application.StartupPath + @"\Encr.ypt", Encrypt.ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
