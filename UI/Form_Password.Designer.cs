
namespace RecordStore_CarmellWasserman.UI
{
    partial class Form_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Password));
            this.groupBox_Filter = new System.Windows.Forms.GroupBox();
            this.label_Username = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.button_LogIn = new System.Windows.Forms.Button();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.groupBox_Filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Filter
            // 
            this.groupBox_Filter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox_Filter.Controls.Add(this.label_Username);
            this.groupBox_Filter.Controls.Add(this.textBox_Password);
            this.groupBox_Filter.Controls.Add(this.label_Password);
            this.groupBox_Filter.Controls.Add(this.button_LogIn);
            this.groupBox_Filter.Controls.Add(this.textBox_Username);
            this.groupBox_Filter.Location = new System.Drawing.Point(132, 109);
            this.groupBox_Filter.Name = "groupBox_Filter";
            this.groupBox_Filter.Size = new System.Drawing.Size(513, 230);
            this.groupBox_Filter.TabIndex = 30;
            this.groupBox_Filter.TabStop = false;
            this.groupBox_Filter.Text = "Log In";
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_Username.Location = new System.Drawing.Point(18, 34);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(164, 37);
            this.label_Username.TabIndex = 20;
            this.label_Username.Text = "Username";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(267, 95);
            this.textBox_Password.MaxLength = 4000;
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(214, 31);
            this.textBox_Password.TabIndex = 2;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_Password.Location = new System.Drawing.Point(18, 89);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(158, 37);
            this.label_Password.TabIndex = 1;
            this.label_Password.Text = "Password";
            // 
            // button_LogIn
            // 
            this.button_LogIn.Location = new System.Drawing.Point(387, 160);
            this.button_LogIn.Name = "button_LogIn";
            this.button_LogIn.Size = new System.Drawing.Size(94, 47);
            this.button_LogIn.TabIndex = 3;
            this.button_LogIn.Text = "Log In";
            this.button_LogIn.UseVisualStyleBackColor = true;
            this.button_LogIn.Click += new System.EventHandler(this.button_LogIn_Click);
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(267, 40);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(214, 31);
            this.textBox_Username.TabIndex = 1;
            // 
            // Form_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_Filter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Password";
            this.Text = "Log In";
            this.groupBox_Filter.ResumeLayout(false);
            this.groupBox_Filter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Filter;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Button button_LogIn;
        private System.Windows.Forms.TextBox textBox_Username;
    }
}