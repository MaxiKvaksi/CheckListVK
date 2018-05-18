namespace CheckList
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
            this.nameCheckList = new System.Windows.Forms.Label();
            this.panelCheckList = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelProgress = new System.Windows.Forms.Label();
            this.buttonCkeckTest = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameCheckList
            // 
            this.nameCheckList.AutoSize = true;
            this.nameCheckList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameCheckList.Location = new System.Drawing.Point(12, 9);
            this.nameCheckList.Name = "nameCheckList";
            this.nameCheckList.Size = new System.Drawing.Size(180, 20);
            this.nameCheckList.TabIndex = 0;
            this.nameCheckList.Text = "Название ЧекЛиста";
            // 
            // panelCheckList
            // 
            this.panelCheckList.AutoScroll = true;
            this.panelCheckList.Location = new System.Drawing.Point(13, 33);
            this.panelCheckList.Name = "panelCheckList";
            this.panelCheckList.Size = new System.Drawing.Size(775, 362);
            this.panelCheckList.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelProgress);
            this.panel2.Controls.Add(this.buttonCkeckTest);
            this.panel2.Location = new System.Drawing.Point(15, 405);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(772, 39);
            this.panel2.TabIndex = 2;
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
            this.buttonCkeckTest.Location = new System.Drawing.Point(651, 3);
            this.buttonCkeckTest.Name = "buttonCkeckTest";
            this.buttonCkeckTest.Size = new System.Drawing.Size(118, 33);
            this.buttonCkeckTest.TabIndex = 0;
            this.buttonCkeckTest.Text = "Готово";
            this.buttonCkeckTest.UseVisualStyleBackColor = true;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelCheckList);
            this.Controls.Add(this.nameCheckList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameCheckList;
        private System.Windows.Forms.Panel panelCheckList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.Button buttonCkeckTest;
    }
}