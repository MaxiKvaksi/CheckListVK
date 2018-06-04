using System.Drawing;
using System.Windows.Forms;


namespace CheckListNM
{
    public partial class FormResult : Form
    {
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
            MainHandler.SaveResult();
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
                labelFinalMark.Text = "Пройдено";
            }
            else
            {
                if (MainHandler.session.countOfChecks < MainHandler.session.CheckList.CountTasks())
                {
                    labelFinalMark.Text = "Неудовлетворительно.";
                }
                else
                {
                    int time = MainHandler.timeResult;
                    if (time < MainHandler.session.CheckList.Notes.Excellent)
                    {
                        labelFinalMark.Text = "Отлично.";
                    }
                    else if (time < MainHandler.session.CheckList.Notes.Good)
                    {
                        labelFinalMark.Text = "Хорошо.";
                    }
                    else if (time < MainHandler.session.CheckList.Notes.Satisfactory)
                    {
                        labelFinalMark.Text = "Удовлетворительно.";
                    }else
                    {
                        labelFinalMark.Text = "Неудовлетворительно.";
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
