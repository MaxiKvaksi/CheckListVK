using System.Drawing;
using System.Windows.Forms;


namespace CheckListNM
{
    public partial class FormResult : Form
    {
        string mark;
        public FormResult(bool isTest)
        {
            InitializeComponent();
            label6.Text = $"{MainHandler.session.countOfChecks} из {MainHandler.session.CheckList.CountTasks()}";
            if (!isTest)
            {
                label8.Visible = false;
                labelTimeResult.Visible = false;
                label3.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                groupBox2.Visible = false;
            }
            else
            {
                labelTimeResult.Text = $"{MainHandler.timeResult / 60} мин. {MainHandler.timeResult % 60} c.";
            }
            labelCurrentCourse.Text = MainHandler.session.CheckList.Inform.Course;
            labelTestName.Text = MainHandler.session.CheckList.Inform.Name;
            labelVzvodName.Text = MainHandler.session.Platoon.PlatNum.ToString();//TODO to object
            labelFIOName.Text = MainHandler.session.Student.Fio;
            SetMark(isTest);
            MainHandler.SaveResult(mark, isTest);
        }

        private void buttonCloseTest_Click(object sender, System.EventArgs e)
        {
            this.Close();
            MainHandler.MainForm.Visible = true;
        }

        void SetMark(bool isTest)
        {
            if (!isTest)
            {
                labelFinalMark.ForeColor = Color.Green;
                mark = labelFinalMark.Text = "Пройдено";
            }
            else
            {
                if (MainHandler.session.countOfChecks < MainHandler.session.CheckList.CountTasks())
                {
                    mark = labelFinalMark.Text = "Неудовлетворительно."+ "\r\n" + "Выполнено не всё!";
                }
                else
                {
                    int time = MainHandler.timeResult;
                    if (time < MainHandler.session.CheckList.Notes.Excellent)
                    {
                        mark = labelFinalMark.Text = "Отлично.";
                    }
                    else if (time < MainHandler.session.CheckList.Notes.Good)
                    {
                        mark = labelFinalMark.Text = "Хорошо.";
                    }
                    else if (time < MainHandler.session.CheckList.Notes.Satisfactory)
                    {
                        mark = labelFinalMark.Text = "Удовлетворительно.";
                    }
                    else
                    {
                        mark = labelFinalMark.Text = "Неудовлетворительно.";
                    }

                }
            }
        }

        private void FormResult_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainHandler.MainForm.Visible = true;
        }
    }
}
