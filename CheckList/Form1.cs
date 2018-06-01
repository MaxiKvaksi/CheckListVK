using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CheckList_Konstruktor;

namespace CheckListNM
{
    public partial class MainForm : Form
    {
        bool[] comboBoxes = { false, false, false, false };

        private static List<CheckListClass> temporaryCheckListsForComboBox = new List<CheckListClass>();//костылина

        public MainForm()
        {
            MainHandler.MoveDerictory();
            MainHandler.LoadInfo();
            MainHandler.MainForm = this;
            InitializeComponent();          
            InitComboBoxes();
        }

        private void InitComboBoxes()
        {
            try
            {
                foreach (var item in MainHandler.platoons.PlatList)
                {
                    comboBoxPlatoon.Items.Add(item.PlatNum);
                }
            }
            catch (Exception) { }
            try
            {
                foreach (var item in MainHandler.subjects.SubList)
                {
                    comboBoxSubject.Items.Add(item.Name);
                }
            }
            catch (Exception e) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartTest(false);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {     
            StartTest(true);      
        }

        void StartTest(bool isTest)
        {
            if (comboBoxSubject.SelectedIndex == -1 || comboBoxPlatoon.SelectedIndex == -1
                || comboBoxStudent.SelectedIndex == -1 || comboBoxCheck.SelectedIndex == -1)
            {
                MessageBox.Show("Установлены не все параметры!");
                return;
            }
            else
            {
                MainHandler.CreateSession(
                   platoon: MainHandler.platoons.PlatList[comboBoxPlatoon.SelectedIndex],
                   student: MainHandler.platoons.PlatList[comboBoxPlatoon.SelectedIndex].Students[comboBoxStudent.SelectedIndex],
                   checkList: temporaryCheckListsForComboBox[comboBoxCheck.SelectedIndex],
                   subject: MainHandler.subjects.SubList[comboBoxSubject.SelectedIndex], 
                   isTest: isTest);
            }
            (MainHandler.TestForm = new TestForm()).Show();
            Visible = false;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)//установка студентов в combobox
        {
            comboBoxStudent.Text = "";
            comboBoxStudent.Items.Clear();
            foreach (var item in MainHandler.platoons.PlatList[comboBoxPlatoon.SelectedIndex].Students)
            {
                comboBoxStudent.Items.Add(item.Fio);
            }
        }

        private void comboBoxSubject_SelectedIndexChanged(object sender, EventArgs e)//устнвка чеклистов в combobox
        {
            comboBoxCheck.Text = "";
            comboBoxCheck.Items.Clear();
            temporaryCheckListsForComboBox.Clear();
            MainHandler.LoadCheckList(MainHandler.subjects.SubList[comboBoxSubject.SelectedIndex].CheckListIndexes);
            foreach (var item in MainHandler.checkLists)
            {
                comboBoxCheck.Items.Add(item.Inform.Name);
                temporaryCheckListsForComboBox.Add(item);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
