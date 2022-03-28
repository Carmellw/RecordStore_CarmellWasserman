
namespace RecordStore_CarmellWasserman.UI
{
    partial class Form_Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Employee));
            this.label_DateToday = new System.Windows.Forms.Label();
            this.label_StoreName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox_Filter = new System.Windows.Forms.GroupBox();
            this.textBox_PhoneNumberFilter = new System.Windows.Forms.TextBox();
            this.label_IdFilter = new System.Windows.Forms.Label();
            this.textBox_FirstNameFilter = new System.Windows.Forms.TextBox();
            this.label_FirstNameFilter = new System.Windows.Forms.Label();
            this.label_LastNameFilter = new System.Windows.Forms.Label();
            this.label_PhoneNumerFilter = new System.Windows.Forms.Label();
            this.textBox_LastNameFilter = new System.Windows.Forms.TextBox();
            this.button_ClearFilter = new System.Windows.Forms.Button();
            this.textBox_IdFilter = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_Username = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.textBox_HourlyWage = new System.Windows.Forms.TextBox();
            this.textBox_PhoneNumber = new System.Windows.Forms.TextBox();
            this.label_IdName = new System.Windows.Forms.Label();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.label_LastName = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_HourlyWage = new System.Windows.Forms.Label();
            this.label_PhoneNumber = new System.Windows.Forms.Label();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_Id = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.listBox_Employees = new System.Windows.Forms.ListBox();
            this.button_EmployeeReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox_Filter.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_DateToday
            // 
            this.label_DateToday.AutoSize = true;
            this.label_DateToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DateToday.Location = new System.Drawing.Point(566, 73);
            this.label_DateToday.Name = "label_DateToday";
            this.label_DateToday.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_DateToday.Size = new System.Drawing.Size(220, 31);
            this.label_DateToday.TabIndex = 32;
            this.label_DateToday.Text = "label_DateToday";
            this.label_DateToday.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_StoreName
            // 
            this.label_StoreName.AutoSize = true;
            this.label_StoreName.Font = new System.Drawing.Font("Aharoni", 30F, System.Drawing.FontStyle.Bold);
            this.label_StoreName.Location = new System.Drawing.Point(129, 40);
            this.label_StoreName.Name = "label_StoreName";
            this.label_StoreName.Size = new System.Drawing.Size(441, 79);
            this.label_StoreName.TabIndex = 31;
            this.label_StoreName.Text = "Employees";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RecordStore_CarmellWasserman.Properties.Resources.recordplayer;
            this.pictureBox1.Location = new System.Drawing.Point(4, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox_Filter
            // 
            this.groupBox_Filter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox_Filter.Controls.Add(this.textBox_PhoneNumberFilter);
            this.groupBox_Filter.Controls.Add(this.label_IdFilter);
            this.groupBox_Filter.Controls.Add(this.textBox_FirstNameFilter);
            this.groupBox_Filter.Controls.Add(this.label_FirstNameFilter);
            this.groupBox_Filter.Controls.Add(this.label_LastNameFilter);
            this.groupBox_Filter.Controls.Add(this.label_PhoneNumerFilter);
            this.groupBox_Filter.Controls.Add(this.textBox_LastNameFilter);
            this.groupBox_Filter.Controls.Add(this.button_ClearFilter);
            this.groupBox_Filter.Controls.Add(this.textBox_IdFilter);
            this.groupBox_Filter.Location = new System.Drawing.Point(38, 131);
            this.groupBox_Filter.Name = "groupBox_Filter";
            this.groupBox_Filter.Size = new System.Drawing.Size(513, 336);
            this.groupBox_Filter.TabIndex = 29;
            this.groupBox_Filter.TabStop = false;
            this.groupBox_Filter.Text = "Filter";
            // 
            // textBox_PhoneNumberFilter
            // 
            this.textBox_PhoneNumberFilter.Location = new System.Drawing.Point(267, 208);
            this.textBox_PhoneNumberFilter.MaxLength = 10;
            this.textBox_PhoneNumberFilter.Name = "textBox_PhoneNumberFilter";
            this.textBox_PhoneNumberFilter.Size = new System.Drawing.Size(214, 31);
            this.textBox_PhoneNumberFilter.TabIndex = 4;
            this.textBox_PhoneNumberFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            this.textBox_PhoneNumberFilter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
            // 
            // label_IdFilter
            // 
            this.label_IdFilter.AutoSize = true;
            this.label_IdFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_IdFilter.Location = new System.Drawing.Point(18, 34);
            this.label_IdFilter.Name = "label_IdFilter";
            this.label_IdFilter.Size = new System.Drawing.Size(43, 37);
            this.label_IdFilter.TabIndex = 20;
            this.label_IdFilter.Text = "Id";
            // 
            // textBox_FirstNameFilter
            // 
            this.textBox_FirstNameFilter.Location = new System.Drawing.Point(267, 95);
            this.textBox_FirstNameFilter.MaxLength = 4000;
            this.textBox_FirstNameFilter.Name = "textBox_FirstNameFilter";
            this.textBox_FirstNameFilter.Size = new System.Drawing.Size(214, 31);
            this.textBox_FirstNameFilter.TabIndex = 2;
            this.textBox_FirstNameFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Heb_KeyPress);
            this.textBox_FirstNameFilter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
            // 
            // label_FirstNameFilter
            // 
            this.label_FirstNameFilter.AutoSize = true;
            this.label_FirstNameFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_FirstNameFilter.Location = new System.Drawing.Point(8, 89);
            this.label_FirstNameFilter.Name = "label_FirstNameFilter";
            this.label_FirstNameFilter.Size = new System.Drawing.Size(184, 37);
            this.label_FirstNameFilter.TabIndex = 1;
            this.label_FirstNameFilter.Text = " First Name";
            // 
            // label_LastNameFilter
            // 
            this.label_LastNameFilter.AutoSize = true;
            this.label_LastNameFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_LastNameFilter.Location = new System.Drawing.Point(8, 147);
            this.label_LastNameFilter.Name = "label_LastNameFilter";
            this.label_LastNameFilter.Size = new System.Drawing.Size(182, 37);
            this.label_LastNameFilter.TabIndex = 2;
            this.label_LastNameFilter.Text = " Last Name";
            // 
            // label_PhoneNumerFilter
            // 
            this.label_PhoneNumerFilter.AutoSize = true;
            this.label_PhoneNumerFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_PhoneNumerFilter.Location = new System.Drawing.Point(18, 202);
            this.label_PhoneNumerFilter.Name = "label_PhoneNumerFilter";
            this.label_PhoneNumerFilter.Size = new System.Drawing.Size(233, 37);
            this.label_PhoneNumerFilter.TabIndex = 3;
            this.label_PhoneNumerFilter.Text = "Phone Number";
            // 
            // textBox_LastNameFilter
            // 
            this.textBox_LastNameFilter.Location = new System.Drawing.Point(267, 153);
            this.textBox_LastNameFilter.Name = "textBox_LastNameFilter";
            this.textBox_LastNameFilter.Size = new System.Drawing.Size(214, 31);
            this.textBox_LastNameFilter.TabIndex = 3;
            this.textBox_LastNameFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Heb_KeyPress);
            this.textBox_LastNameFilter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
            // 
            // button_ClearFilter
            // 
            this.button_ClearFilter.Location = new System.Drawing.Point(387, 265);
            this.button_ClearFilter.Name = "button_ClearFilter";
            this.button_ClearFilter.Size = new System.Drawing.Size(94, 47);
            this.button_ClearFilter.TabIndex = 5;
            this.button_ClearFilter.Text = "clear";
            this.button_ClearFilter.UseVisualStyleBackColor = true;
            this.button_ClearFilter.Click += new System.EventHandler(this.clearFilter_Click);
            // 
            // textBox_IdFilter
            // 
            this.textBox_IdFilter.Location = new System.Drawing.Point(267, 40);
            this.textBox_IdFilter.Name = "textBox_IdFilter";
            this.textBox_IdFilter.Size = new System.Drawing.Size(214, 31);
            this.textBox_IdFilter.TabIndex = 1;
            this.textBox_IdFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            this.textBox_IdFilter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.label_Username);
            this.groupBox2.Controls.Add(this.textBox_Password);
            this.groupBox2.Controls.Add(this.textBox_Username);
            this.groupBox2.Controls.Add(this.textBox_HourlyWage);
            this.groupBox2.Controls.Add(this.textBox_PhoneNumber);
            this.groupBox2.Controls.Add(this.label_IdName);
            this.groupBox2.Controls.Add(this.textBox_FirstName);
            this.groupBox2.Controls.Add(this.label_FirstName);
            this.groupBox2.Controls.Add(this.label_LastName);
            this.groupBox2.Controls.Add(this.label_Password);
            this.groupBox2.Controls.Add(this.label_HourlyWage);
            this.groupBox2.Controls.Add(this.label_PhoneNumber);
            this.groupBox2.Controls.Add(this.textBox_LastName);
            this.groupBox2.Controls.Add(this.delete);
            this.groupBox2.Controls.Add(this.textBox_Email);
            this.groupBox2.Controls.Add(this.clear);
            this.groupBox2.Controls.Add(this.label_Email);
            this.groupBox2.Controls.Add(this.label_Id);
            this.groupBox2.Controls.Add(this.save);
            this.groupBox2.Location = new System.Drawing.Point(38, 499);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 563);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add/Update";
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_Username.Location = new System.Drawing.Point(8, 378);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(173, 37);
            this.label_Username.TabIndex = 23;
            this.label_Username.Text = " Username";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(267, 436);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(214, 31);
            this.textBox_Password.TabIndex = 22;
            this.textBox_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_All_KeyPress);
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(267, 378);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(214, 31);
            this.textBox_Username.TabIndex = 22;
            this.textBox_Username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_All_KeyPress);
            // 
            // textBox_HourlyWage
            // 
            this.textBox_HourlyWage.Location = new System.Drawing.Point(267, 322);
            this.textBox_HourlyWage.Name = "textBox_HourlyWage";
            this.textBox_HourlyWage.Size = new System.Drawing.Size(214, 31);
            this.textBox_HourlyWage.TabIndex = 21;
            this.textBox_HourlyWage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            // 
            // textBox_PhoneNumber
            // 
            this.textBox_PhoneNumber.Location = new System.Drawing.Point(267, 208);
            this.textBox_PhoneNumber.MaxLength = 10;
            this.textBox_PhoneNumber.Name = "textBox_PhoneNumber";
            this.textBox_PhoneNumber.Size = new System.Drawing.Size(214, 31);
            this.textBox_PhoneNumber.TabIndex = 8;
            this.textBox_PhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            // 
            // label_IdName
            // 
            this.label_IdName.AutoSize = true;
            this.label_IdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_IdName.Location = new System.Drawing.Point(18, 34);
            this.label_IdName.Name = "label_IdName";
            this.label_IdName.Size = new System.Drawing.Size(43, 37);
            this.label_IdName.TabIndex = 20;
            this.label_IdName.Text = "Id";
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(267, 95);
            this.textBox_FirstName.MaxLength = 4000;
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(214, 31);
            this.textBox_FirstName.TabIndex = 6;
            this.textBox_FirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Heb_KeyPress);
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_FirstName.Location = new System.Drawing.Point(8, 89);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(184, 37);
            this.label_FirstName.TabIndex = 1;
            this.label_FirstName.Text = " First Name";
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_LastName.Location = new System.Drawing.Point(8, 147);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(182, 37);
            this.label_LastName.TabIndex = 2;
            this.label_LastName.Text = " Last Name";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_Password.Location = new System.Drawing.Point(18, 436);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(158, 37);
            this.label_Password.TabIndex = 16;
            this.label_Password.Text = "Password";
            // 
            // label_HourlyWage
            // 
            this.label_HourlyWage.AutoSize = true;
            this.label_HourlyWage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_HourlyWage.Location = new System.Drawing.Point(18, 316);
            this.label_HourlyWage.Name = "label_HourlyWage";
            this.label_HourlyWage.Size = new System.Drawing.Size(202, 37);
            this.label_HourlyWage.TabIndex = 16;
            this.label_HourlyWage.Text = "Hourly Wage";
            // 
            // label_PhoneNumber
            // 
            this.label_PhoneNumber.AutoSize = true;
            this.label_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_PhoneNumber.Location = new System.Drawing.Point(18, 202);
            this.label_PhoneNumber.Name = "label_PhoneNumber";
            this.label_PhoneNumber.Size = new System.Drawing.Size(233, 37);
            this.label_PhoneNumber.TabIndex = 3;
            this.label_PhoneNumber.Text = "Phone Number";
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(267, 153);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(214, 31);
            this.textBox_LastName.TabIndex = 7;
            this.textBox_LastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Heb_KeyPress);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(387, 490);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(94, 47);
            this.delete.TabIndex = 14;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(267, 264);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(214, 31);
            this.textBox_Email.TabIndex = 9;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(287, 490);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(94, 47);
            this.clear.TabIndex = 13;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_Email.Location = new System.Drawing.Point(18, 258);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(97, 37);
            this.label_Email.TabIndex = 8;
            this.label_Email.Text = "Email";
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_Id.Location = new System.Drawing.Point(261, 37);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(29, 31);
            this.label_Id.TabIndex = 12;
            this.label_Id.Text = "0";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(187, 490);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(94, 47);
            this.save.TabIndex = 12;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // listBox_Employees
            // 
            this.listBox_Employees.FormattingEnabled = true;
            this.listBox_Employees.ItemHeight = 25;
            this.listBox_Employees.Location = new System.Drawing.Point(584, 131);
            this.listBox_Employees.Name = "listBox_Employees";
            this.listBox_Employees.Size = new System.Drawing.Size(569, 929);
            this.listBox_Employees.TabIndex = 27;
            this.listBox_Employees.DoubleClick += new System.EventHandler(this.listBox_Employees_DoubleClick);
            // 
            // button_EmployeeReport
            // 
            this.button_EmployeeReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_EmployeeReport.Location = new System.Drawing.Point(1061, 40);
            this.button_EmployeeReport.Name = "button_EmployeeReport";
            this.button_EmployeeReport.Size = new System.Drawing.Size(92, 78);
            this.button_EmployeeReport.TabIndex = 34;
            this.button_EmployeeReport.Text = "report";
            this.button_EmployeeReport.UseVisualStyleBackColor = true;
            this.button_EmployeeReport.Click += new System.EventHandler(this.button_EmployeeReport_Click);
            // 
            // Form_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1194, 1082);
            this.Controls.Add(this.button_EmployeeReport);
            this.Controls.Add(this.label_DateToday);
            this.Controls.Add(this.label_StoreName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox_Filter);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listBox_Employees);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Employee";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.Text = "Employees";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox_Filter.ResumeLayout(false);
            this.groupBox_Filter.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_DateToday;
        private System.Windows.Forms.Label label_StoreName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox_Filter;
        private System.Windows.Forms.TextBox textBox_PhoneNumberFilter;
        private System.Windows.Forms.Label label_IdFilter;
        private System.Windows.Forms.TextBox textBox_FirstNameFilter;
        private System.Windows.Forms.Label label_FirstNameFilter;
        private System.Windows.Forms.Label label_LastNameFilter;
        private System.Windows.Forms.Label label_PhoneNumerFilter;
        private System.Windows.Forms.TextBox textBox_LastNameFilter;
        private System.Windows.Forms.Button button_ClearFilter;
        private System.Windows.Forms.TextBox textBox_IdFilter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_PhoneNumber;
        private System.Windows.Forms.Label label_IdName;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.Label label_HourlyWage;
        private System.Windows.Forms.Label label_PhoneNumber;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ListBox listBox_Employees;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.TextBox textBox_HourlyWage;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Button button_EmployeeReport;
    }
}