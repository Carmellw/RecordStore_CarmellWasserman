
namespace RecordStore_CarmellWasserman.UI
{
    partial class Form_Category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Category));
            this.label_DateToday = new System.Windows.Forms.Label();
            this.label_StoreName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox_Filter = new System.Windows.Forms.GroupBox();
            this.label_IdFilter = new System.Windows.Forms.Label();
            this.textBox_NameFilter = new System.Windows.Forms.TextBox();
            this.label_NameFilter = new System.Windows.Forms.Label();
            this.button_ClearFilter = new System.Windows.Forms.Button();
            this.textBox_IdFilter = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_IdName = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.label_Id = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.listBox_Categories = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox_Filter.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_DateToday
            // 
            this.label_DateToday.AutoSize = true;
            this.label_DateToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DateToday.Location = new System.Drawing.Point(573, 69);
            this.label_DateToday.Name = "label_DateToday";
            this.label_DateToday.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_DateToday.Size = new System.Drawing.Size(220, 31);
            this.label_DateToday.TabIndex = 38;
            this.label_DateToday.Text = "label_DateToday";
            this.label_DateToday.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_StoreName
            // 
            this.label_StoreName.AutoSize = true;
            this.label_StoreName.Font = new System.Drawing.Font("Aharoni", 30F, System.Drawing.FontStyle.Bold);
            this.label_StoreName.Location = new System.Drawing.Point(129, 36);
            this.label_StoreName.Name = "label_StoreName";
            this.label_StoreName.Size = new System.Drawing.Size(438, 79);
            this.label_StoreName.TabIndex = 37;
            this.label_StoreName.Text = "Categories";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RecordStore_CarmellWasserman.Properties.Resources.recordplayer;
            this.pictureBox1.Location = new System.Drawing.Point(4, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox_Filter
            // 
            this.groupBox_Filter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox_Filter.Controls.Add(this.label_IdFilter);
            this.groupBox_Filter.Controls.Add(this.textBox_NameFilter);
            this.groupBox_Filter.Controls.Add(this.label_NameFilter);
            this.groupBox_Filter.Controls.Add(this.button_ClearFilter);
            this.groupBox_Filter.Controls.Add(this.textBox_IdFilter);
            this.groupBox_Filter.Location = new System.Drawing.Point(38, 127);
            this.groupBox_Filter.Name = "groupBox_Filter";
            this.groupBox_Filter.Size = new System.Drawing.Size(513, 230);
            this.groupBox_Filter.TabIndex = 35;
            this.groupBox_Filter.TabStop = false;
            this.groupBox_Filter.Text = "Filter";
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
            // textBox_NameFilter
            // 
            this.textBox_NameFilter.Location = new System.Drawing.Point(267, 95);
            this.textBox_NameFilter.MaxLength = 4000;
            this.textBox_NameFilter.Name = "textBox_NameFilter";
            this.textBox_NameFilter.Size = new System.Drawing.Size(214, 31);
            this.textBox_NameFilter.TabIndex = 2;
            this.textBox_NameFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Heb_KeyPress);
            this.textBox_NameFilter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
            // 
            // label_NameFilter
            // 
            this.label_NameFilter.AutoSize = true;
            this.label_NameFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_NameFilter.Location = new System.Drawing.Point(8, 89);
            this.label_NameFilter.Name = "label_NameFilter";
            this.label_NameFilter.Size = new System.Drawing.Size(112, 37);
            this.label_NameFilter.TabIndex = 1;
            this.label_NameFilter.Text = " Name";
            // 
            // button_ClearFilter
            // 
            this.button_ClearFilter.Location = new System.Drawing.Point(387, 160);
            this.button_ClearFilter.Name = "button_ClearFilter";
            this.button_ClearFilter.Size = new System.Drawing.Size(94, 47);
            this.button_ClearFilter.TabIndex = 3;
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
            this.groupBox2.Controls.Add(this.label_IdName);
            this.groupBox2.Controls.Add(this.textBox_Name);
            this.groupBox2.Controls.Add(this.label_Name);
            this.groupBox2.Controls.Add(this.button_Delete);
            this.groupBox2.Controls.Add(this.button_Clear);
            this.groupBox2.Controls.Add(this.label_Id);
            this.groupBox2.Controls.Add(this.button_Save);
            this.groupBox2.Location = new System.Drawing.Point(38, 393);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 238);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add/Update";
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
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(267, 95);
            this.textBox_Name.MaxLength = 4000;
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(214, 31);
            this.textBox_Name.TabIndex = 4;
            this.textBox_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Heb_KeyPress);
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_Name.Location = new System.Drawing.Point(16, 89);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(103, 37);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "Name";
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(387, 163);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(94, 47);
            this.button_Delete.TabIndex = 7;
            this.button_Delete.Text = "delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(287, 163);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(94, 47);
            this.button_Clear.TabIndex = 6;
            this.button_Clear.Text = "clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.clear_Click);
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
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(187, 163);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(94, 47);
            this.button_Save.TabIndex = 5;
            this.button_Save.Text = "save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.save_Click);
            // 
            // listBox_Categories
            // 
            this.listBox_Categories.FormattingEnabled = true;
            this.listBox_Categories.ItemHeight = 25;
            this.listBox_Categories.Location = new System.Drawing.Point(584, 127);
            this.listBox_Categories.Name = "listBox_Categories";
            this.listBox_Categories.Size = new System.Drawing.Size(569, 504);
            this.listBox_Categories.TabIndex = 33;
            this.listBox_Categories.DoubleClick += new System.EventHandler(this.listBox_Categories_DoubleClick);
            // 
            // Form_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1194, 669);
            this.Controls.Add(this.label_DateToday);
            this.Controls.Add(this.label_StoreName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox_Filter);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listBox_Categories);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Category";
            this.Text = "Categories";
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
        private System.Windows.Forms.Label label_IdFilter;
        private System.Windows.Forms.TextBox textBox_NameFilter;
        private System.Windows.Forms.Label label_NameFilter;
        private System.Windows.Forms.Button button_ClearFilter;
        private System.Windows.Forms.TextBox textBox_IdFilter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_IdName;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.ListBox listBox_Categories;
    }
}