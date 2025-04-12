namespace CountDownTimer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Lbl_Time = new Label();
            Lbl_Minute = new Label();
            Lbl_Second = new Label();
            Btn_Min1Up = new Button();
            Btn_Min1Dwn = new Button();
            Btn_1SecUP = new Button();
            Btn_1SecDwn = new Button();
            SuspendLayout();
            // 
            // Lbl_Time
            // 
            Lbl_Time.Font = new Font("Yu Gothic UI", 80F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_Time.Location = new Point(26, 22);
            Lbl_Time.Name = "Lbl_Time";
            Lbl_Time.Size = new Size(325, 127);
            Lbl_Time.TabIndex = 0;
            Lbl_Time.Text = "0:00";
            Lbl_Time.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Lbl_Minute
            // 
            Lbl_Minute.AutoSize = true;
            Lbl_Minute.Font = new Font("Yu Gothic UI", 14F);
            Lbl_Minute.Location = new Point(48, 291);
            Lbl_Minute.Name = "Lbl_Minute";
            Lbl_Minute.Size = new Size(31, 25);
            Lbl_Minute.TabIndex = 1;
            Lbl_Minute.Text = "分";
            // 
            // Lbl_Second
            // 
            Lbl_Second.AutoSize = true;
            Lbl_Second.Font = new Font("Yu Gothic UI", 14F);
            Lbl_Second.Location = new Point(299, 291);
            Lbl_Second.Name = "Lbl_Second";
            Lbl_Second.Size = new Size(31, 25);
            Lbl_Second.TabIndex = 2;
            Lbl_Second.Text = "秒";
            // 
            // Btn_Min1Up
            // 
            Btn_Min1Up.Location = new Point(26, 250);
            Btn_Min1Up.Name = "Btn_Min1Up";
            Btn_Min1Up.Size = new Size(75, 23);
            Btn_Min1Up.TabIndex = 3;
            Btn_Min1Up.Text = "+1";
            Btn_Min1Up.UseVisualStyleBackColor = true;
            // 
            // Btn_Min1Dwn
            // 
            Btn_Min1Dwn.Location = new Point(26, 328);
            Btn_Min1Dwn.Name = "Btn_Min1Dwn";
            Btn_Min1Dwn.Size = new Size(75, 23);
            Btn_Min1Dwn.TabIndex = 4;
            Btn_Min1Dwn.Text = "-1";
            Btn_Min1Dwn.UseVisualStyleBackColor = true;
            // 
            // Btn_1SecUP
            // 
            Btn_1SecUP.Location = new Point(276, 250);
            Btn_1SecUP.Name = "Btn_1SecUP";
            Btn_1SecUP.Size = new Size(75, 23);
            Btn_1SecUP.TabIndex = 5;
            Btn_1SecUP.Text = "+1";
            Btn_1SecUP.UseVisualStyleBackColor = true;
            // 
            // Btn_1SecDwn
            // 
            Btn_1SecDwn.Location = new Point(276, 328);
            Btn_1SecDwn.Name = "Btn_1SecDwn";
            Btn_1SecDwn.Size = new Size(75, 23);
            Btn_1SecDwn.TabIndex = 6;
            Btn_1SecDwn.Text = "-1";
            Btn_1SecDwn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 385);
            Controls.Add(Btn_1SecDwn);
            Controls.Add(Btn_1SecUP);
            Controls.Add(Btn_Min1Dwn);
            Controls.Add(Btn_Min1Up);
            Controls.Add(Lbl_Second);
            Controls.Add(Lbl_Minute);
            Controls.Add(Lbl_Time);
            Name = "MainForm";
            Text = "CountDownTimer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_Time;
        private Label Lbl_Minute;
        private Label Lbl_Second;
        private Button Btn_Min1Up;
        private Button Btn_Min1Dwn;
        private Button Btn_1SecUP;
        private Button Btn_1SecDwn;
    }
}
