namespace CheckListNM
{
    partial class TestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelCheckList = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelProgress = new System.Windows.Forms.Label();
            this.buttonCkeckTest = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCheckList
            // 
            this.panelCheckList.AutoScroll = true;
            this.panelCheckList.Location = new System.Drawing.Point(6, 12);
            this.panelCheckList.Name = "panelCheckList";
            this.panelCheckList.Size = new System.Drawing.Size(1006, 609);
            this.panelCheckList.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Controls.Add(this.labelTime);
            this.panel2.Controls.Add(this.labelProgress);
            this.panel2.Controls.Add(this.buttonCkeckTest);
            this.panel2.Location = new System.Drawing.Point(6, 627);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(991, 39);
            this.panel2.TabIndex = 2;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(141, 11);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(54, 17);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "Время:";
            this.labelTime.Visible = false;
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProgress.Location = new System.Drawing.Point(3, 11);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(126, 17);
            this.labelProgress.TabIndex = 1;
            this.labelProgress.Text = "Выполнено 0 из 0";
            // 
            // buttonCkeckTest
            // 
            this.buttonCkeckTest.Location = new System.Drawing.Point(870, 3);
            this.buttonCkeckTest.Name = "buttonCkeckTest";
            this.buttonCkeckTest.Size = new System.Drawing.Size(118, 33);
            this.buttonCkeckTest.TabIndex = 0;
            this.buttonCkeckTest.Text = "Готово";
            this.buttonCkeckTest.UseVisualStyleBackColor = true;
            this.buttonCkeckTest.Click += new System.EventHandler(this.buttonCkeckTest_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1018, 675);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelCheckList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TestForm_FormClosed);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelCheckList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.Button buttonCkeckTest;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTime;
    }
}