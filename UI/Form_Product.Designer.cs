
namespace RecordStore_CarmellWasserman
{
    partial class Form_Product
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
            this.label_DateToday = new System.Windows.Forms.Label();
            this.label_StoreName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox_Filter = new System.Windows.Forms.GroupBox();
            this.comboBox_ArtistFilter = new System.Windows.Forms.ComboBox();
            this.comboBox_CategoryFilter = new System.Windows.Forms.ComboBox();
            this.label_IdFilter = new System.Windows.Forms.Label();
            this.label_CategoryFilter = new System.Windows.Forms.Label();
            this.label_NameFilter = new System.Windows.Forms.Label();
            this.label_ArtistFilter = new System.Windows.Forms.Label();
            this.textBox_NameFilter = new System.Windows.Forms.TextBox();
            this.button_ClearFilter = new System.Windows.Forms.Button();
            this.textBox_IdFilter = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_IdName = new System.Windows.Forms.Label();
            this.button_AddCategory = new System.Windows.Forms.Button();
            this.button_AddGenre = new System.Windows.Forms.Button();
            this.button_AddArtist = new System.Windows.Forms.Button();
            this.button_AddCompany = new System.Windows.Forms.Button();
            this.label_Category = new System.Windows.Forms.Label();
            this.comboBox_Category = new System.Windows.Forms.ComboBox();
            this.comboBox_Genre = new System.Windows.Forms.ComboBox();
            this.comboBox_Artist = new System.Windows.Forms.ComboBox();
            this.comboBox_Company = new System.Windows.Forms.ComboBox();
            this.label_Count = new System.Windows.Forms.Label();
            this.label_Price = new System.Windows.Forms.Label();
            this.label_IsNew = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Company = new System.Windows.Forms.Label();
            this.label_Genre = new System.Windows.Forms.Label();
            this.textBox_Count = new System.Windows.Forms.TextBox();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.label_Artist = new System.Windows.Forms.Label();
            this.label_Id = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.checkBox_IsNew = new System.Windows.Forms.CheckBox();
            this.listBox_Products = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox_Filter.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_DateToday
            // 
            this.label_DateToday.AutoSize = true;
            this.label_DateToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DateToday.Location = new System.Drawing.Point(822, 69);
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
            this.label_StoreName.Location = new System.Drawing.Point(126, 36);
            this.label_StoreName.Name = "label_StoreName";
            this.label_StoreName.Size = new System.Drawing.Size(556, 79);
            this.label_StoreName.TabIndex = 31;
            this.label_StoreName.Text = "RECORDLAND";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RecordStore_CarmellWasserman.Properties.Resources.recordplayer;
            this.pictureBox1.Location = new System.Drawing.Point(1, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox_Filter
            // 
            this.groupBox_Filter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox_Filter.Controls.Add(this.comboBox_ArtistFilter);
            this.groupBox_Filter.Controls.Add(this.comboBox_CategoryFilter);
            this.groupBox_Filter.Controls.Add(this.label_IdFilter);
            this.groupBox_Filter.Controls.Add(this.label_CategoryFilter);
            this.groupBox_Filter.Controls.Add(this.label_NameFilter);
            this.groupBox_Filter.Controls.Add(this.label_ArtistFilter);
            this.groupBox_Filter.Controls.Add(this.textBox_NameFilter);
            this.groupBox_Filter.Controls.Add(this.button_ClearFilter);
            this.groupBox_Filter.Controls.Add(this.textBox_IdFilter);
            this.groupBox_Filter.Location = new System.Drawing.Point(35, 127);
            this.groupBox_Filter.Name = "groupBox_Filter";
            this.groupBox_Filter.Size = new System.Drawing.Size(513, 336);
            this.groupBox_Filter.TabIndex = 29;
            this.groupBox_Filter.TabStop = false;
            this.groupBox_Filter.Text = "Filter";
            // 
            // comboBox_ArtistFilter
            // 
            this.comboBox_ArtistFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ArtistFilter.FormattingEnabled = true;
            this.comboBox_ArtistFilter.Location = new System.Drawing.Point(267, 208);
            this.comboBox_ArtistFilter.Name = "comboBox_ArtistFilter";
            this.comboBox_ArtistFilter.Size = new System.Drawing.Size(214, 33);
            this.comboBox_ArtistFilter.TabIndex = 22;
            this.comboBox_ArtistFilter.TextChanged += new System.EventHandler(this.comboBoxFilter_TextChanged);
            // 
            // comboBox_CategoryFilter
            // 
            this.comboBox_CategoryFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CategoryFilter.FormattingEnabled = true;
            this.comboBox_CategoryFilter.Location = new System.Drawing.Point(267, 95);
            this.comboBox_CategoryFilter.Name = "comboBox_CategoryFilter";
            this.comboBox_CategoryFilter.Size = new System.Drawing.Size(214, 33);
            this.comboBox_CategoryFilter.TabIndex = 21;
            this.comboBox_CategoryFilter.TextChanged += new System.EventHandler(this.comboBoxFilter_TextChanged);
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
            // label_CategoryFilter
            // 
            this.label_CategoryFilter.AutoSize = true;
            this.label_CategoryFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_CategoryFilter.Location = new System.Drawing.Point(14, 89);
            this.label_CategoryFilter.Name = "label_CategoryFilter";
            this.label_CategoryFilter.Size = new System.Drawing.Size(146, 37);
            this.label_CategoryFilter.TabIndex = 1;
            this.label_CategoryFilter.Text = "Category";
            // 
            // label_NameFilter
            // 
            this.label_NameFilter.AutoSize = true;
            this.label_NameFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_NameFilter.Location = new System.Drawing.Point(14, 147);
            this.label_NameFilter.Name = "label_NameFilter";
            this.label_NameFilter.Size = new System.Drawing.Size(103, 37);
            this.label_NameFilter.TabIndex = 2;
            this.label_NameFilter.Text = "Name";
            // 
            // label_ArtistFilter
            // 
            this.label_ArtistFilter.AutoSize = true;
            this.label_ArtistFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_ArtistFilter.Location = new System.Drawing.Point(14, 202);
            this.label_ArtistFilter.Name = "label_ArtistFilter";
            this.label_ArtistFilter.Size = new System.Drawing.Size(91, 37);
            this.label_ArtistFilter.TabIndex = 3;
            this.label_ArtistFilter.Text = "Artist";
            // 
            // textBox_NameFilter
            // 
            this.textBox_NameFilter.Location = new System.Drawing.Point(267, 153);
            this.textBox_NameFilter.Name = "textBox_NameFilter";
            this.textBox_NameFilter.Size = new System.Drawing.Size(214, 31);
            this.textBox_NameFilter.TabIndex = 3;
            this.textBox_NameFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Heb_KeyPress);
            this.textBox_NameFilter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
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
            this.groupBox2.Controls.Add(this.label_IdName);
            this.groupBox2.Controls.Add(this.button_AddCategory);
            this.groupBox2.Controls.Add(this.button_AddGenre);
            this.groupBox2.Controls.Add(this.button_AddArtist);
            this.groupBox2.Controls.Add(this.button_AddCompany);
            this.groupBox2.Controls.Add(this.label_Category);
            this.groupBox2.Controls.Add(this.comboBox_Category);
            this.groupBox2.Controls.Add(this.comboBox_Genre);
            this.groupBox2.Controls.Add(this.comboBox_Artist);
            this.groupBox2.Controls.Add(this.comboBox_Company);
            this.groupBox2.Controls.Add(this.label_Count);
            this.groupBox2.Controls.Add(this.label_Price);
            this.groupBox2.Controls.Add(this.label_IsNew);
            this.groupBox2.Controls.Add(this.label_Name);
            this.groupBox2.Controls.Add(this.label_Company);
            this.groupBox2.Controls.Add(this.label_Genre);
            this.groupBox2.Controls.Add(this.textBox_Count);
            this.groupBox2.Controls.Add(this.textBox_Price);
            this.groupBox2.Controls.Add(this.textBox_Name);
            this.groupBox2.Controls.Add(this.delete);
            this.groupBox2.Controls.Add(this.clear);
            this.groupBox2.Controls.Add(this.label_Artist);
            this.groupBox2.Controls.Add(this.label_Id);
            this.groupBox2.Controls.Add(this.save);
            this.groupBox2.Controls.Add(this.checkBox_IsNew);
            this.groupBox2.Location = new System.Drawing.Point(35, 495);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 613);
            this.groupBox2.TabIndex = 28;
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
            // button_AddCategory
            // 
            this.button_AddCategory.Location = new System.Drawing.Point(444, 91);
            this.button_AddCategory.Name = "button_AddCategory";
            this.button_AddCategory.Size = new System.Drawing.Size(45, 45);
            this.button_AddCategory.TabIndex = 11;
            this.button_AddCategory.Text = "+";
            this.button_AddCategory.UseVisualStyleBackColor = true;
            this.button_AddCategory.Click += new System.EventHandler(this.button_AddCategory_Click);
            // 
            // button_AddGenre
            // 
            this.button_AddGenre.Location = new System.Drawing.Point(444, 206);
            this.button_AddGenre.Name = "button_AddGenre";
            this.button_AddGenre.Size = new System.Drawing.Size(45, 45);
            this.button_AddGenre.TabIndex = 11;
            this.button_AddGenre.Text = "+";
            this.button_AddGenre.UseVisualStyleBackColor = true;
            this.button_AddGenre.Click += new System.EventHandler(this.button_AddGenre_Click);
            // 
            // button_AddArtist
            // 
            this.button_AddArtist.Location = new System.Drawing.Point(444, 260);
            this.button_AddArtist.Name = "button_AddArtist";
            this.button_AddArtist.Size = new System.Drawing.Size(45, 45);
            this.button_AddArtist.TabIndex = 11;
            this.button_AddArtist.Text = "+";
            this.button_AddArtist.UseVisualStyleBackColor = true;
            this.button_AddArtist.Click += new System.EventHandler(this.button_AddArtist_Click);
            // 
            // button_AddCompany
            // 
            this.button_AddCompany.Location = new System.Drawing.Point(444, 314);
            this.button_AddCompany.Name = "button_AddCompany";
            this.button_AddCompany.Size = new System.Drawing.Size(45, 45);
            this.button_AddCompany.TabIndex = 11;
            this.button_AddCompany.Text = "+";
            this.button_AddCompany.UseVisualStyleBackColor = true;
            this.button_AddCompany.Click += new System.EventHandler(this.button_AddCompany_Click);
            // 
            // label_Category
            // 
            this.label_Category.AutoSize = true;
            this.label_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_Category.Location = new System.Drawing.Point(14, 89);
            this.label_Category.Name = "label_Category";
            this.label_Category.Size = new System.Drawing.Size(146, 37);
            this.label_Category.TabIndex = 1;
            this.label_Category.Text = "Category";
            // 
            // comboBox_Category
            // 
            this.comboBox_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Category.FormattingEnabled = true;
            this.comboBox_Category.Location = new System.Drawing.Point(267, 93);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(171, 33);
            this.comboBox_Category.TabIndex = 10;
            // 
            // comboBox_Genre
            // 
            this.comboBox_Genre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Genre.FormattingEnabled = true;
            this.comboBox_Genre.Location = new System.Drawing.Point(267, 208);
            this.comboBox_Genre.Name = "comboBox_Genre";
            this.comboBox_Genre.Size = new System.Drawing.Size(171, 33);
            this.comboBox_Genre.TabIndex = 10;
            // 
            // comboBox_Artist
            // 
            this.comboBox_Artist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Artist.FormattingEnabled = true;
            this.comboBox_Artist.Location = new System.Drawing.Point(267, 262);
            this.comboBox_Artist.Name = "comboBox_Artist";
            this.comboBox_Artist.Size = new System.Drawing.Size(171, 33);
            this.comboBox_Artist.TabIndex = 10;
            // 
            // comboBox_Company
            // 
            this.comboBox_Company.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Company.FormattingEnabled = true;
            this.comboBox_Company.Location = new System.Drawing.Point(267, 316);
            this.comboBox_Company.Name = "comboBox_Company";
            this.comboBox_Company.Size = new System.Drawing.Size(171, 33);
            this.comboBox_Company.TabIndex = 10;
            // 
            // label_Count
            // 
            this.label_Count.AutoSize = true;
            this.label_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_Count.Location = new System.Drawing.Point(20, 482);
            this.label_Count.Name = "label_Count";
            this.label_Count.Size = new System.Drawing.Size(103, 37);
            this.label_Count.TabIndex = 2;
            this.label_Count.Text = "Count";
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_Price.Location = new System.Drawing.Point(20, 426);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(89, 37);
            this.label_Price.TabIndex = 2;
            this.label_Price.Text = "Price";
            // 
            // label_IsNew
            // 
            this.label_IsNew.AutoSize = true;
            this.label_IsNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_IsNew.Location = new System.Drawing.Point(16, 370);
            this.label_IsNew.Name = "label_IsNew";
            this.label_IsNew.Size = new System.Drawing.Size(153, 37);
            this.label_IsNew.TabIndex = 2;
            this.label_IsNew.Text = "Condition";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_Name.Location = new System.Drawing.Point(14, 147);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(103, 37);
            this.label_Name.TabIndex = 2;
            this.label_Name.Text = "Name";
            // 
            // label_Company
            // 
            this.label_Company.AutoSize = true;
            this.label_Company.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_Company.Location = new System.Drawing.Point(8, 316);
            this.label_Company.Name = "label_Company";
            this.label_Company.Size = new System.Drawing.Size(163, 37);
            this.label_Company.TabIndex = 16;
            this.label_Company.Text = " Company";
            // 
            // label_Genre
            // 
            this.label_Genre.AutoSize = true;
            this.label_Genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_Genre.Location = new System.Drawing.Point(18, 202);
            this.label_Genre.Name = "label_Genre";
            this.label_Genre.Size = new System.Drawing.Size(105, 37);
            this.label_Genre.TabIndex = 3;
            this.label_Genre.Text = "Genre";
            // 
            // textBox_Count
            // 
            this.textBox_Count.Location = new System.Drawing.Point(267, 488);
            this.textBox_Count.Name = "textBox_Count";
            this.textBox_Count.Size = new System.Drawing.Size(214, 31);
            this.textBox_Count.TabIndex = 7;
            this.textBox_Count.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            // 
            // textBox_Price
            // 
            this.textBox_Price.Location = new System.Drawing.Point(267, 432);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(214, 31);
            this.textBox_Price.TabIndex = 7;
            this.textBox_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(267, 153);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(214, 31);
            this.textBox_Name.TabIndex = 7;
            this.textBox_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Heb_KeyPress);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(387, 542);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(94, 47);
            this.delete.TabIndex = 14;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(287, 542);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(94, 47);
            this.clear.TabIndex = 13;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label_Artist
            // 
            this.label_Artist.AutoSize = true;
            this.label_Artist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_Artist.Location = new System.Drawing.Point(18, 258);
            this.label_Artist.Name = "label_Artist";
            this.label_Artist.Size = new System.Drawing.Size(91, 37);
            this.label_Artist.TabIndex = 8;
            this.label_Artist.Text = "Artist";
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
            this.save.Location = new System.Drawing.Point(187, 542);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(94, 47);
            this.save.TabIndex = 12;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // checkBox_IsNew
            // 
            this.checkBox_IsNew.AutoSize = true;
            this.checkBox_IsNew.Location = new System.Drawing.Point(267, 378);
            this.checkBox_IsNew.Name = "checkBox_IsNew";
            this.checkBox_IsNew.Size = new System.Drawing.Size(86, 29);
            this.checkBox_IsNew.TabIndex = 21;
            this.checkBox_IsNew.Text = "New";
            this.checkBox_IsNew.UseVisualStyleBackColor = true;
            // 
            // listBox_Products
            // 
            this.listBox_Products.FormattingEnabled = true;
            this.listBox_Products.ItemHeight = 25;
            this.listBox_Products.Location = new System.Drawing.Point(581, 127);
            this.listBox_Products.Name = "listBox_Products";
            this.listBox_Products.Size = new System.Drawing.Size(569, 979);
            this.listBox_Products.TabIndex = 27;
            this.listBox_Products.DoubleClick += new System.EventHandler(this.listBox_Products_DoubleClick);
            // 
            // Form_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1194, 1144);
            this.Controls.Add(this.label_DateToday);
            this.Controls.Add(this.label_StoreName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox_Filter);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listBox_Products);
            this.Name = "Form_Product";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.Text = "Form_Product";
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
        private System.Windows.Forms.Label label_CategoryFilter;
        private System.Windows.Forms.Label label_NameFilter;
        private System.Windows.Forms.Label label_ArtistFilter;
        private System.Windows.Forms.TextBox textBox_NameFilter;
        private System.Windows.Forms.Button button_ClearFilter;
        private System.Windows.Forms.TextBox textBox_IdFilter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_IdName;
        private System.Windows.Forms.Button button_AddCategory;
        private System.Windows.Forms.Button button_AddGenre;
        private System.Windows.Forms.Button button_AddArtist;
        private System.Windows.Forms.Button button_AddCompany;
        private System.Windows.Forms.Label label_Category;
        private System.Windows.Forms.ComboBox comboBox_Category;
        private System.Windows.Forms.ComboBox comboBox_Genre;
        private System.Windows.Forms.ComboBox comboBox_Artist;
        private System.Windows.Forms.ComboBox comboBox_Company;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Company;
        private System.Windows.Forms.Label label_Genre;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label_Artist;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ListBox listBox_Products;
        private System.Windows.Forms.Label label_Count;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.Label label_IsNew;
        private System.Windows.Forms.TextBox textBox_Count;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.CheckBox checkBox_IsNew;
        private System.Windows.Forms.ComboBox comboBox_ArtistFilter;
        private System.Windows.Forms.ComboBox comboBox_CategoryFilter;
    }
}