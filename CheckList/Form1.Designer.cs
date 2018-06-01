namespace CheckListNM
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StartLearning = new System.Windows.Forms.Button();
            this.startTesting = new System.Windows.Forms.Button();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.comboBoxCheck = new System.Windows.Forms.ComboBox();
            this.comboBoxPlatoon = new System.Windows.Forms.ComboBox();
            this.comboBoxStudent = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartLearning
            // 
            this.StartLearning.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartLearning.Location = new System.Drawing.Point(334, 261);
            this.StartLearning.Name = "StartLearning";
            this.StartLearning.Size = new System.Drawing.Size(180, 50);
            this.StartLearning.TabIndex = 0;
            this.StartLearning.Text = "Начать обучение";
            this.StartLearning.UseVisualStyleBackColor = true;
            this.StartLearning.Click += new System.EventHandler(this.button1_Click);
            // 
            // startTesting
            // 
            this.startTesting.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startTesting.Location = new System.Drawing.Point(334, 317);
            this.startTesting.Name = "startTesting";
            this.startTesting.Size = new System.Drawing.Size(180, 58);
            this.startTesting.TabIndex = 1;
            this.startTesting.Text = "Начать тестирование";
            this.startTesting.UseVisualStyleBackColor = true;
            this.startTesting.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(18, 53);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(184, 21);
            this.comboBoxSubject.TabIndex = 2;
            this.comboBoxSubject.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubject_SelectedIndexChanged);
            // 
            // comboBoxCheck
            // 
            this.comboBoxCheck.FormattingEnabled = true;
            this.comboBoxCheck.Location = new System.Drawing.Point(212, 53);
            this.comboBoxCheck.Name = "comboBoxCheck";
            this.comboBoxCheck.Size = new System.Drawing.Size(180, 21);
            this.comboBoxCheck.TabIndex = 3;
            // 
            // comboBoxPlatoon
            // 
            this.comboBoxPlatoon.FormattingEnabled = true;
            this.comboBoxPlatoon.Location = new System.Drawing.Point(398, 53);
            this.comboBoxPlatoon.Name = "comboBoxPlatoon";
            this.comboBoxPlatoon.Size = new System.Drawing.Size(186, 21);
            this.comboBoxPlatoon.TabIndex = 4;
            this.comboBoxPlatoon.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBoxStudent
            // 
            this.comboBoxStudent.FormattingEnabled = true;
            this.comboBoxStudent.Location = new System.Drawing.Point(590, 53);
            this.comboBoxStudent.Name = "comboBoxStudent";
            this.comboBoxStudent.Size = new System.Drawing.Size(184, 21);
            this.comboBoxStudent.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Выберите предмет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(208, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Выберите карточку";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(394, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Выберите взвод";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(586, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Выберите студента";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(133, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(582, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "Тестирование знаний \"Карточка задания\"";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxSubject);
            this.panel1.Controls.Add(this.comboBoxCheck);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBoxPlatoon);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBoxStudent);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 113);
            this.panel1.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 447);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.startTesting);
            this.Controls.Add(this.StartLearning);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "Карточка задание";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartLearning;
        private System.Windows.Forms.Button startTesting;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.ComboBox comboBoxCheck;
        private System.Windows.Forms.ComboBox comboBoxPlatoon;
        private System.Windows.Forms.ComboBox comboBoxStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
    }
}

