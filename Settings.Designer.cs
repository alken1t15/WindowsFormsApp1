namespace WindowsFormsApp1
{
    partial class Settings
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
            this.button_Clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(28, 107);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(269, 41);
            this.button_Clear.TabIndex = 0;
            this.button_Clear.Text = "Сбросить результаты";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 31);
            this.label1.TabIndex = 21;
            this.label1.Text = "Настройки";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 449);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(269, 41);
            this.button2.TabIndex = 23;
            this.button2.Text = "Удалить пользователя";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(81, 496);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 45);
            this.button6.TabIndex = 24;
            this.button6.Text = "Домой";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonTest
            // 
            this.buttonTest.BackColor = System.Drawing.SystemColors.Control;
            this.buttonTest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonTest.Location = new System.Drawing.Point(171, 496);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 45);
            this.buttonTest.TabIndex = 25;
            this.buttonTest.Text = "Тесты";
            this.buttonTest.UseVisualStyleBackColor = false;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 563);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Clear);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonTest;
    }
}