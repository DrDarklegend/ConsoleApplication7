namespace WindowsFormsApplication1
{
    partial class AddForm
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
            this.Ok = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.EmployeerOfSallaryComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HourEmployer = new System.Windows.Forms.GroupBox();
            this.HourWorkedTextBox = new System.Windows.Forms.TextBox();
            this.HourCostTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PaymentOfSalary = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ExperienceTextBox = new System.Windows.Forms.TextBox();
            this.RateTextBox = new System.Windows.Forms.TextBox();
            this.SalaryTextBox = new System.Windows.Forms.TextBox();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.HourEmployer.SuspendLayout();
            this.PaymentOfSalary.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(40, 289);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 23);
            this.Ok.TabIndex = 0;
            this.Ok.Text = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(40, 318);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // EmployeerOfSallaryComboBox
            // 
            this.EmployeerOfSallaryComboBox.FormattingEnabled = true;
            this.EmployeerOfSallaryComboBox.Items.AddRange(new object[] {
            "PaymentOfSalary",
            "HourEmployeer"});
            this.EmployeerOfSallaryComboBox.Location = new System.Drawing.Point(40, 56);
            this.EmployeerOfSallaryComboBox.Name = "EmployeerOfSallaryComboBox";
            this.EmployeerOfSallaryComboBox.Size = new System.Drawing.Size(121, 21);
            this.EmployeerOfSallaryComboBox.TabIndex = 2;
            this.EmployeerOfSallaryComboBox.SelectedIndexChanged += new System.EventHandler(this.Selectandemployee_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select an employee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Surname";
            // 
            // HourEmployer
            // 
            this.HourEmployer.Controls.Add(this.HourWorkedTextBox);
            this.HourEmployer.Controls.Add(this.HourCostTextBox);
            this.HourEmployer.Controls.Add(this.label6);
            this.HourEmployer.Controls.Add(this.label5);
            this.HourEmployer.Location = new System.Drawing.Point(205, 241);
            this.HourEmployer.Name = "HourEmployer";
            this.HourEmployer.Size = new System.Drawing.Size(275, 100);
            this.HourEmployer.TabIndex = 6;
            this.HourEmployer.TabStop = false;
            this.HourEmployer.Text = "HourEmployeer";
            // 
            // HourWorkedTextBox
            // 
            this.HourWorkedTextBox.Location = new System.Drawing.Point(168, 54);
            this.HourWorkedTextBox.Name = "HourWorkedTextBox";
            this.HourWorkedTextBox.Size = new System.Drawing.Size(100, 20);
            this.HourWorkedTextBox.TabIndex = 3;
            // 
            // HourCostTextBox
            // 
            this.HourCostTextBox.Location = new System.Drawing.Point(6, 54);
            this.HourCostTextBox.Name = "HourCostTextBox";
            this.HourCostTextBox.Size = new System.Drawing.Size(100, 20);
            this.HourCostTextBox.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Hour worked";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Hour cost";
            // 
            // PaymentOfSalary
            // 
            this.PaymentOfSalary.Controls.Add(this.label10);
            this.PaymentOfSalary.Controls.Add(this.label9);
            this.PaymentOfSalary.Controls.Add(this.label7);
            this.PaymentOfSalary.Controls.Add(this.ExperienceTextBox);
            this.PaymentOfSalary.Controls.Add(this.RateTextBox);
            this.PaymentOfSalary.Controls.Add(this.SalaryTextBox);
            this.PaymentOfSalary.Location = new System.Drawing.Point(205, 47);
            this.PaymentOfSalary.Name = "PaymentOfSalary";
            this.PaymentOfSalary.Size = new System.Drawing.Size(269, 172);
            this.PaymentOfSalary.TabIndex = 0;
            this.PaymentOfSalary.TabStop = false;
            this.PaymentOfSalary.Text = "PaymentOfSalary";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(149, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Experience";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Rate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Salary";
            // 
            // ExperienceTextBox
            // 
            this.ExperienceTextBox.Location = new System.Drawing.Point(138, 57);
            this.ExperienceTextBox.Name = "ExperienceTextBox";
            this.ExperienceTextBox.Size = new System.Drawing.Size(100, 20);
            this.ExperienceTextBox.TabIndex = 3;
            // 
            // RateTextBox
            // 
            this.RateTextBox.Location = new System.Drawing.Point(6, 119);
            this.RateTextBox.Name = "RateTextBox";
            this.RateTextBox.Size = new System.Drawing.Size(100, 20);
            this.RateTextBox.TabIndex = 2;
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Location = new System.Drawing.Point(3, 53);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.SalaryTextBox.TabIndex = 0;
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(40, 110);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(100, 20);
            this.NameTextbox.TabIndex = 7;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(40, 156);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.SurnameTextBox.TabIndex = 8;
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(40, 199);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(100, 20);
            this.AgeTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Age";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 395);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.PaymentOfSalary);
            this.Controls.Add(this.HourEmployer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmployeerOfSallaryComboBox);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Name = "AddForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.HourEmployer.ResumeLayout(false);
            this.HourEmployer.PerformLayout();
            this.PaymentOfSalary.ResumeLayout(false);
            this.PaymentOfSalary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ComboBox EmployeerOfSallaryComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox HourEmployer;
        private System.Windows.Forms.GroupBox PaymentOfSalary;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox HourWorkedTextBox;
        private System.Windows.Forms.TextBox HourCostTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ExperienceTextBox;
        private System.Windows.Forms.TextBox RateTextBox;
        private System.Windows.Forms.TextBox SalaryTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
    }
}