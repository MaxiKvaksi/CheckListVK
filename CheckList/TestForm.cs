using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckList
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
            InitCheckList();
        }

        void InitCheckList()
        {
            int count = 0;
            int text = 0;
            MainHandler.LoadCheckList();
            InitHeader();
            for (int i = 1; i < MainHandler.checkLists[0].Tasks.Count + 1; i++)
            {
                panelCheckList.Controls.Add(NewRTB(0, 
                    panelCheckList.Controls[panelCheckList.Controls.Count - 5].Height 
                    + panelCheckList.Controls[panelCheckList.Controls.Count - 5].Location.Y + 1, 30, 
                    desc:i.ToString()));
                panelCheckList.Controls.Add(
                    NewRTB(panelCheckList.Controls[panelCheckList.Controls.Count - 1].Location.X 
                    + panelCheckList.Controls[panelCheckList.Controls.Count - 1].Width,
                    panelCheckList.Controls[panelCheckList.Controls.Count - 4].Height 
                    + panelCheckList.Controls[panelCheckList.Controls.Count - 5].Location.Y + 1, 150,
                    desc: MainHandler.checkLists[0].Tasks[i - 1].Name));
                panelCheckList.Controls.Add(
                    NewRTB(panelCheckList.Controls[panelCheckList.Controls.Count - 1].Location.X
                    + panelCheckList.Controls[panelCheckList.Controls.Count - 1].Width,
                    panelCheckList.Controls[panelCheckList.Controls.Count - 5].Height
                    + panelCheckList.Controls[panelCheckList.Controls.Count - 5].Location.Y + 1, 250,
                    desc: MainHandler.checkLists[0].Tasks[i - 1].Description));
                panelCheckList.Controls.Add(
                    NewPB(panelCheckList.Controls[panelCheckList.Controls.Count - 1].Location.X
                    + panelCheckList.Controls[panelCheckList.Controls.Count - 1].Width,
                    panelCheckList.Controls[panelCheckList.Controls.Count - 5].Height
                    + panelCheckList.Controls[panelCheckList.Controls.Count - 5].Location.Y + 1, 250));
                panelCheckList.Controls.Add(
                    NewChB(panelCheckList.Controls[panelCheckList.Controls.Count - 1].Location.X
                    + panelCheckList.Controls[panelCheckList.Controls.Count - 1].Width,
                    panelCheckList.Controls[panelCheckList.Controls.Count - 5].Height
                    + panelCheckList.Controls[panelCheckList.Controls.Count - 5].Location.Y + 1, 50));
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
                    Text = desc,
                    ReadOnly = true,
                    BackColor = c,
                    BorderStyle = BorderStyle.FixedSingle
                };
            }

            PictureBox NewPB(int posX, int posY, int width, int height = 96,
                string desc = "", bool color = false)
            {
                text++;
                Color c = color ? Color.Black : Color.White;
                return new PictureBox
                {
                    Location = new System.Drawing
                    .Point(posX, posY),
                    Name = "PictureBoxTF" + text + 1,
                    Size = new System.Drawing.Size(width, height),
                    TabIndex = 0,
                    Text = desc,
                    Enabled = true,
                    BackColor = c
                };
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
                panel.Controls.Add(new CheckBox {
                    Location = new System.Drawing
                    .Point(2, 2),
                    Name = "CheckBoxTF" + text + 1,
                });
                return panel;
            }

            void InitHeader()
            {
                panelCheckList.Controls.Add(NewRTB(0, 16, 30, height: 20, desc: "№", color: true));
                panelCheckList.Controls.Add(
                    NewRTB(panelCheckList.Controls[panelCheckList.Controls.Count - 1].Location.X
                    + panelCheckList.Controls[panelCheckList.Controls.Count - 1].Width,
                    16, 150,height: 20, desc: "Название действия", color: true));
                panelCheckList.Controls.Add(
                    NewRTB(panelCheckList.Controls[panelCheckList.Controls.Count - 1].Location.X
                    + panelCheckList.Controls[panelCheckList.Controls.Count - 1].Width,
                    16, 250, height: 20, desc: "Описание", color: true));
                panelCheckList.Controls.Add(
                    NewRTB(panelCheckList.Controls[panelCheckList.Controls.Count - 1].Location.X
                    + panelCheckList.Controls[panelCheckList.Controls.Count - 1].Width,
                    16, 250, height: 20, desc: "Пример", color: true));
                panelCheckList.Controls.Add(
                    NewRTB(panelCheckList.Controls[panelCheckList.Controls.Count - 1].Location.X
                    + panelCheckList.Controls[panelCheckList.Controls.Count - 1].Width,
                    16, 50, height: 20, desc: "Ok", color: true));
                count++;
            }
        }
    }
}
