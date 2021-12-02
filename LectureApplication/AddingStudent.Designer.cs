namespace LectureApplication
{
    partial class AddingStudent
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
            this.button1 = new System.Windows.Forms.Button();
            this.AddressGB = new System.Windows.Forms.GroupBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.textBoxRegion = new System.Windows.Forms.TextBox();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.InitialsGB = new System.Windows.Forms.GroupBox();
            this.comboBoxTeacher = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxGrade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddressGB.SuspendLayout();
            this.InitialsGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(3, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 49);
            this.button1.TabIndex = 12;
            this.button1.Text = "Добавить студента";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddressGB
            // 
            this.AddressGB.Controls.Add(this.textBoxCity);
            this.AddressGB.Controls.Add(this.textBoxStreet);
            this.AddressGB.Controls.Add(this.textBoxRegion);
            this.AddressGB.Controls.Add(this.textBoxCountry);
            this.AddressGB.Controls.Add(this.label5);
            this.AddressGB.Controls.Add(this.label6);
            this.AddressGB.Controls.Add(this.label7);
            this.AddressGB.Controls.Add(this.label8);
            this.AddressGB.Location = new System.Drawing.Point(3, 179);
            this.AddressGB.Name = "AddressGB";
            this.AddressGB.Size = new System.Drawing.Size(253, 117);
            this.AddressGB.TabIndex = 11;
            this.AddressGB.TabStop = false;
            this.AddressGB.Text = "Место проживания";
            this.AddressGB.Enter += new System.EventHandler(this.AddressGB_Enter);
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(67, 81);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(181, 20);
            this.textBoxCity.TabIndex = 7;
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(67, 60);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(181, 20);
            this.textBoxStreet.TabIndex = 6;
            // 
            // textBoxRegion
            // 
            this.textBoxRegion.Location = new System.Drawing.Point(67, 39);
            this.textBoxRegion.Name = "textBoxRegion";
            this.textBoxRegion.Size = new System.Drawing.Size(181, 20);
            this.textBoxRegion.TabIndex = 5;
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(67, 17);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(181, 20);
            this.textBoxCountry.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Город - ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Улица - ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Регион - ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Страна - ";
            // 
            // InitialsGB
            // 
            this.InitialsGB.Controls.Add(this.comboBoxTeacher);
            this.InitialsGB.Controls.Add(this.label10);
            this.InitialsGB.Controls.Add(this.textBoxGrade);
            this.InitialsGB.Controls.Add(this.label9);
            this.InitialsGB.Controls.Add(this.textBoxID);
            this.InitialsGB.Controls.Add(this.textBoxAge);
            this.InitialsGB.Controls.Add(this.textBoxSurname);
            this.InitialsGB.Controls.Add(this.textBoxName);
            this.InitialsGB.Controls.Add(this.label4);
            this.InitialsGB.Controls.Add(this.label3);
            this.InitialsGB.Controls.Add(this.label2);
            this.InitialsGB.Controls.Add(this.label1);
            this.InitialsGB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.InitialsGB.Location = new System.Drawing.Point(3, 3);
            this.InitialsGB.Name = "InitialsGB";
            this.InitialsGB.Size = new System.Drawing.Size(253, 159);
            this.InitialsGB.TabIndex = 10;
            this.InitialsGB.TabStop = false;
            this.InitialsGB.Text = "Информация";
            // 
            // comboBoxTeacher
            // 
            this.comboBoxTeacher.FormattingEnabled = true;
            this.comboBoxTeacher.Location = new System.Drawing.Point(67, 130);
            this.comboBoxTeacher.Name = "comboBoxTeacher";
            this.comboBoxTeacher.Size = new System.Drawing.Size(181, 21);
            this.comboBoxTeacher.TabIndex = 11;
            this.comboBoxTeacher.Click += new System.EventHandler(this.comboBoxTeacher_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Учитель - ";
            // 
            // textBoxGrade
            // 
            this.textBoxGrade.Location = new System.Drawing.Point(67, 105);
            this.textBoxGrade.Name = "textBoxGrade";
            this.textBoxGrade.Size = new System.Drawing.Size(181, 20);
            this.textBoxGrade.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Оценка - ";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(67, 81);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(181, 20);
            this.textBoxID.TabIndex = 7;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(67, 60);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(181, 20);
            this.textBoxAge.TabIndex = 6;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(67, 39);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(181, 20);
            this.textBoxSurname.TabIndex = 5;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(67, 17);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(181, 20);
            this.textBoxName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID - ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Возраст - ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия - ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя - ";
            // 
            // AddingStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 350);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddressGB);
            this.Controls.Add(this.InitialsGB);
            this.Name = "AddingStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление нового студента";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            this.AddressGB.ResumeLayout(false);
            this.AddressGB.PerformLayout();
            this.InitialsGB.ResumeLayout(false);
            this.InitialsGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox AddressGB;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.TextBox textBoxRegion;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox InitialsGB;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTeacher;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxGrade;
        private System.Windows.Forms.Label label9;
    }
}