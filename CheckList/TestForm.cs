using System;
using System.Drawing;
using System.Windows.Forms;
using CheckList;
using CheckList_Konstruktor;

namespace CheckListNM
{
    public partial class TestForm : Form
    {
        private int timer;//для отсчёта времени с начала запуска теста
        private int doneCount = 0;

        public TestForm()
        {
            InitializeComponent();
            InitCheckList();
            if (MainHandler.session.IsTest)
            {
                InitTimer();
            }
        }

        private void InitTimer()
        {
            timer1.Start();
            labelTime.Visible = true;
        }

        void InitCheckList()
        {
            int count = 0;
            int text = 0;
            Image image;
            InitHeader();
            labelProgress.Text = $"Выполнено {doneCount} из {MainHandler.session.CheckList.CountTasks()}";
            for (int i = 1; i < MainHandler.session.CheckList.Tasks.Count + 1; i++)
            {
                try
                {
                    image = MainHandler.session.CheckList.Tasks[i - 1] != null ? Image.FromFile(
                    "CheckList\\Pictures\\" + MainHandler.session.CheckList.Tasks[i - 1].Image) : null;//MainHandler.checkLists[0].Tasks[i - 1].Image
                }
                catch (Exception)
                {
                    image = null;
                }
                panelCheckList.Controls.Add(NewRTB(0,
                panelCheckList.Controls[panelCheckList.Controls.Count - 5].Height
                + panelCheckList.Controls[panelCheckList.Controls.Count - 5].Location.Y + 1,
                panelCheckList.Controls[panelCheckList.Controls.Count - 5].Width,
                desc: i.ToString()));
                panelCheckList.Controls.Add(//richTextBox
                    NewRTB(panelCheckList.Controls[panelCheckList.Controls.Count - 1].Location.X
                    + panelCheckList.Controls[panelCheckList.Controls.Count - 1].Width,
                    panelCheckList.Controls[panelCheckList.Controls.Count - 4].Height
                    + panelCheckList.Controls[panelCheckList.Controls.Count - 5].Location.Y + 1,
                    panelCheckList.Controls[panelCheckList.Controls.Count - 5].Width,
                    desc: MainHandler.session.CheckList.Tasks[i - 1].Name));
                panelCheckList.Controls.Add(//richTextBox
                    NewRTB(panelCheckList.Controls[panelCheckList.Controls.Count - 1].Location.X
                    + panelCheckList.Controls[panelCheckList.Controls.Count - 1].Width,
                    panelCheckList.Controls[panelCheckList.Controls.Count - 5].Height
                    + panelCheckList.Controls[panelCheckList.Controls.Count - 5].Location.Y + 1,
                    panelCheckList.Controls[panelCheckList.Controls.Count - 5].Width,
                    desc: MainHandler.session.CheckList.Tasks[i - 1].Description));
                panelCheckList.Controls.Add(//pictureBox
                    NewPB(panelCheckList.Controls[panelCheckList.Controls.Count - 1].Location.X
                    + panelCheckList.Controls[panelCheckList.Controls.Count - 1].Width,
                    panelCheckList.Controls[panelCheckList.Controls.Count - 5].Height
                    + panelCheckList.Controls[panelCheckList.Controls.Count - 5].Location.Y + 1,
                    panelCheckList.Controls[panelCheckList.Controls.Count - 5].Width
                    , img: image));
                panelCheckList.Controls.Add(//checkBox
                    NewChB(panelCheckList.Controls[panelCheckList.Controls.Count - 1].Location.X
                    + panelCheckList.Controls[panelCheckList.Controls.Count - 1].Width,
                    panelCheckList.Controls[panelCheckList.Controls.Count - 5].Height
                    + panelCheckList.Controls[panelCheckList.Controls.Count - 5].Location.Y + 1,
                    panelCheckList.Controls[panelCheckList.Controls.Count - 5].Width));
                count++;
            }

            RichTextBox NewRTB(int posX, int posY, int width, int height = 96,
                string desc = "", bool color = false)
            {
                text++;
                Color c = color ? Color.Gray : Color.White;
                return new RichTextBox
                {
                    Location = new System.Drawing
                    .Point(posX, posY),
                    Name = "LabelTF" + text + 1,
                    Size = new System.Drawing.Size(width, height),
                    TabIndex = 0,
                    ReadOnly = true,
                    Text = desc,
                    BackColor = c,
                    BorderStyle = BorderStyle.FixedSingle,
                    Font = new Font(Font.OriginalFontName, 10, FontStyle.Regular)
                };
            }
            Label NewLB(int posX, int posY, int width, int height = 96,
                string desc = "", bool isCenter = false)
            {
                text++;
                Label label = new Label
                {
                    Location = new System.Drawing
                    .Point(posX, posY),
                    Name = "LabelTF" + text + 1,
                    Size = new System.Drawing.Size(width, height),
                    TabIndex = 0,
                    Text = desc,
                    BorderStyle = BorderStyle.None,
                    Font = new Font(Font.OriginalFontName, 13, FontStyle.Regular),
                    AutoSize = true
                };
                return label;
            }

            PictureBox NewPB(int posX, int posY, int width, int height = 96,
                string desc = "", bool color = false, Image img = null)
            {
                text++;
                Color c = color ? Color.Black : Color.White;
                PictureBox pictureBox = new PictureBox
                {
                    Location = new System.Drawing
                    .Point(posX, posY),
                    Name = "PictureBoxTF" + text + 1,
                    Size = new System.Drawing.Size(width, height),
                    TabIndex = 0,
                    Text = desc,
                    BackColor = c,
                    Image = img,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Cursor = Cursors.Hand
                };
                pictureBox.Click += Click;
                void Click(object sender, EventArgs e)
                {
                    new BigImage(img).Show();
                }
                return pictureBox;
            }

            Panel NewChB(int posX, int posY, int width, int height = 96,
                string desc = "")
            {
                text++;
                Panel panel = new Panel
                {
                    Location = new System.Drawing
                    .Point(posX, posY),
                    Name = "PanelTF" + text + 1,
                    Size = new System.Drawing.Size(width, height),
                    TabIndex = 0,
                    Text = desc,
                    Enabled = true,
                    BackColor = Color.White
                };

                CheckBox checkBox = new CheckBox();
                checkBox.Location = new System.Drawing.Point(2, 2);
                checkBox.Name = "CheckBoxTF" + text + 1;
                checkBox.Margin = new Padding(40);
                checkBox.CheckedChanged += CheckedChangedD;
                panel.Controls.Add(checkBox);
                return panel;

                void CheckedChangedD(object sender, EventArgs e)
                {
                    CheckBox cb = (CheckBox)sender;
                    if (cb.Checked) doneCount++;
                    else doneCount--;
                    labelProgress.Text = $"Выполнено {doneCount} из {MainHandler.session.CheckList.CountTasks()}";
                }
            }

            void InitHeader()
            {
                Panel panel = new Panel
                {
                    Location = new System.Drawing
                    .Point(0, 0),
                    Name = "PanelTF" + text + 1,
                    Size = new System.Drawing.Size(980, 300),
                    TabIndex = 0,
                    Enabled = true,
                    BackColor = Color.White
                };
                panelCheckList.Controls.Add(panel);
                panel.Controls.Add(NewLB(10, 0, 900, height: 20, desc: MainHandler.session.CheckList.Inform.Course));
                panel.Controls.Add(NewLB(10, panel.Controls[panel.Controls.Count - 1].Location.Y
                    + panel.Controls[panel.Controls.Count - 1].Height + 5,
                    100, height: 20, desc: $"Занятие №{MainHandler.session.CheckList.Inform.ClassNum}"));
                panel.Controls.Add(NewLB(10, panel.Controls[panel.Controls.Count - 1].Location.Y
                    + panel.Controls[panel.Controls.Count - 1].Height + 5,
                    100, height: 20, desc: "КАРТОЧКА ЗАДАНИЯ"));
                panel.Controls.Add(NewLB(10, panel.Controls[panel.Controls.Count - 1].Location.Y
                    + panel.Controls[panel.Controls.Count - 1].Height + 5,
                    100, height: 20, desc: MainHandler.session.CheckList.Inform.Name));
                panel.Controls.Add(NewLB(10, panel.Controls[panel.Controls.Count - 1].Location.Y
                    + panel.Controls[panel.Controls.Count - 1].Height + 5,
                    100, height: 20, desc: MainHandler.session.CheckList.Inform.Purpose));
                panel.Controls.Add(NewLB(10, panel.Controls[panel.Controls.Count - 1].Location.Y
                    + panel.Controls[panel.Controls.Count - 1].Height + 5,
                    100, height: 20, desc: MainHandler.session.CheckList.Inform.Time.ToString()));
                panel.Controls.Add(NewLB(10, panel.Controls[panel.Controls.Count - 1].Location.Y
                    + panel.Controls[panel.Controls.Count - 1].Height + 5,
                    100, height: 20, desc: MainHandler.session.CheckList.Inform.Place));
                panel.Controls.Add(NewLB(10, panel.Controls[panel.Controls.Count - 1].Location.Y
                    + panel.Controls[panel.Controls.Count - 1].Height + 5,
                    100, height: 20, desc: MainHandler.session.CheckList.Inform.Material));
                panel.Controls.Add(NewLB(10, panel.Controls[panel.Controls.Count - 1].Location.Y
                    + panel.Controls[panel.Controls.Count - 1].Height + 5,
                    100, height: 20, desc: MainHandler.session.CheckList.Inform.Literature));
                panel.Controls.Add(NewLB(10, panel.Controls[panel.Controls.Count - 1].Location.Y
                    + panel.Controls[panel.Controls.Count - 1].Height + 5,
                    100, height: 20, desc: $"Отлично:{MainHandler.session.CheckList.Notes.Excellent.ToString()}; " +
                    $"Хорошо:{ MainHandler.session.CheckList.Notes.Good}; Удовлетворительно:{MainHandler.session.CheckList.Notes.Satisfactory}"));
                panel.Controls.Add(NewLB(10, panel.Controls[panel.Controls.Count - 1].Location.Y
                    + panel.Controls[panel.Controls.Count - 1].Height + 5,
                    100, height: 20, desc: MainHandler.session.CheckList.Inform.Decreace));


                panelCheckList.Controls.Add(NewRTB(0,
                    panelCheckList.Controls[panelCheckList.Controls.Count - 1].Location.Y
                    + panelCheckList.Controls[panelCheckList.Controls.Count - 1].Height + 20,
                    100, height: 30, desc: "№ действия", color: true));
                panelCheckList.Controls.Add(
                    NewRTB(panelCheckList.Controls[panelCheckList.Controls.Count - 1].Location.X
                    + panelCheckList.Controls[panelCheckList.Controls.Count - 1].Width,
                    panelCheckList.Controls[panelCheckList.Controls.Count - 1].Location.Y,
                    200, height: 30, desc: "Название действия", color: true));
                panelCheckList.Controls.Add(
                    NewRTB(panelCheckList.Controls[panelCheckList.Controls.Count - 1].Location.X
                    + panelCheckList.Controls[panelCheckList.Controls.Count - 1].Width,
                    panelCheckList.Controls[panelCheckList.Controls.Count - 1].Location.Y,
                    350, height: 30, desc: "Порядок выполнения", color: true));
                panelCheckList.Controls.Add(
                    NewRTB(panelCheckList.Controls[panelCheckList.Controls.Count - 1].Location.X
                    + panelCheckList.Controls[panelCheckList.Controls.Count - 1].Width,
                    panelCheckList.Controls[panelCheckList.Controls.Count - 1].Location.Y,
                    240, height: 30, desc: "Контроль", color: true));
                panelCheckList.Controls.Add(
                    NewRTB(panelCheckList.Controls[panelCheckList.Controls.Count - 1].Location.X
                    + panelCheckList.Controls[panelCheckList.Controls.Count - 1].Width,
                    panelCheckList.Controls[panelCheckList.Controls.Count - 1].Location.Y,
                    90, height: 30, desc: "Выполнено", color: true));
                count++;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer++;
            labelTime.Text = $"Время:{timer / 60}:{(timer % 60 / 10 == 0 ? "0" : "")}{timer % 60}";
        }

        private void TestForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void buttonCkeckTest_Click(object sender, EventArgs e)
        {
            MainHandler.session.countOfChecks = doneCount;
            if (MainHandler.session.IsTest)
            {
                MainHandler.timeResult = timer;
                timer1.Stop();
            }
            FormResult testForm = MainHandler.session.IsTest ? new FormResult(true) : new FormResult(false);
            MainHandler.TestForm = testForm;
            testForm.Show();
            this.Close();
        }
    }
}
