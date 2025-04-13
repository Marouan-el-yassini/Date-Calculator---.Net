namespace DateNaissance
{
    partial class Form1
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
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            ClientDate = new Label();
            label2 = new Label();
            label3 = new Label();
            SubmitBtn = new Button();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd-mmm-yyy";
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(366, 251);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(292, 31);
            dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd-mmm-yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(366, 144);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(292, 31);
            dateTimePicker2.TabIndex = 1;
            // 
            // ClientDate
            // 
            ClientDate.AutoSize = true;
            ClientDate.Font = new Font("Segoe UI Emoji", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClientDate.ForeColor = Color.MidnightBlue;
            ClientDate.Location = new Point(120, 134);
            ClientDate.Name = "ClientDate";
            ClientDate.Size = new Size(229, 43);
            ClientDate.TabIndex = 2;
            ClientDate.Text = "Date of Birth :";
            ClientDate.Click += ClientDate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(120, 237);
            label2.Name = "label2";
            label2.Size = new Size(231, 45);
            label2.TabIndex = 3;
            label2.Text = "Current Date :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(174, 9);
            label3.Name = "label3";
            label3.Size = new Size(402, 70);
            label3.TabIndex = 4;
            label3.Text = "Age  Calculator";
            label3.Click += label3_Click;
            // 
            // SubmitBtn
            // 
            SubmitBtn.BackColor = Color.White;
            SubmitBtn.Font = new Font("Arial Unicode MS", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubmitBtn.Location = new Point(105, 337);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(563, 88);
            SubmitBtn.TabIndex = 5;
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = false;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(777, 495);
            Controls.Add(SubmitBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ClientDate);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            ForeColor = Color.MidnightBlue;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label ClientDate;
        private Label label2;
        private Label label3;
        private Button SubmitBtn;
    }
}
