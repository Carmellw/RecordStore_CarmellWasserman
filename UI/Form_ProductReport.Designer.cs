﻿
namespace RecordStore_CarmellWasserman.UI
{
    partial class Form_ProductReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ProductReport));
            this.listView_Products = new System.Windows.Forms.ListView();
            this.columnHeader_Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Artist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.button_Print = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
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
            this.groupBox_Filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_Products
            // 
            this.listView_Products.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Category,
            this.columnHeader_Name,
            this.columnHeader_Artist,
            this.columnHeader_Count});
            this.listView_Products.HideSelection = false;
            this.listView_Products.Location = new System.Drawing.Point(12, 100);
            this.listView_Products.Name = "listView_Products";
            this.listView_Products.Size = new System.Drawing.Size(931, 613);
            this.listView_Products.TabIndex = 0;
            this.listView_Products.UseCompatibleStateImageBehavior = false;
            this.listView_Products.View = System.Windows.Forms.View.Details;
            this.listView_Products.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_Products_ColumnClick);
            // 
            // columnHeader_Category
            // 
            this.columnHeader_Category.Text = "Category";
            this.columnHeader_Category.Width = 112;
            // 
            // columnHeader_Name
            // 
            this.columnHeader_Name.Text = "Name";
            this.columnHeader_Name.Width = 139;
            // 
            // columnHeader_Artist
            // 
            this.columnHeader_Artist.Text = "Artist";
            this.columnHeader_Artist.Width = 119;
            // 
            // columnHeader_Count
            // 
            this.columnHeader_Count.Text = "Count";
            this.columnHeader_Count.Width = 70;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.document_PrintPage);
            // 
            // button_Print
            // 
            this.button_Print.Location = new System.Drawing.Point(1352, 442);
            this.button_Print.Name = "button_Print";
            this.button_Print.Size = new System.Drawing.Size(113, 80);
            this.button_Print.TabIndex = 2;
            this.button_Print.Text = "print";
            this.button_Print.UseVisualStyleBackColor = true;
            this.button_Print.Click += new System.EventHandler(this.button_Print_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
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
            this.groupBox_Filter.Location = new System.Drawing.Point(952, 100);
            this.groupBox_Filter.Name = "groupBox_Filter";
            this.groupBox_Filter.Size = new System.Drawing.Size(513, 336);
            this.groupBox_Filter.TabIndex = 30;
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
            // Form_ProductReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1474, 729);
            this.Controls.Add(this.groupBox_Filter);
            this.Controls.Add(this.button_Print);
            this.Controls.Add(this.listView_Products);
            this.Name = "Form_ProductReport";
            this.Text = "Form_ProductReport";
            this.groupBox_Filter.ResumeLayout(false);
            this.groupBox_Filter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_Products;
        private System.Windows.Forms.ColumnHeader columnHeader_Category;
        private System.Windows.Forms.ColumnHeader columnHeader_Name;
        private System.Windows.Forms.ColumnHeader columnHeader_Artist;
        private System.Windows.Forms.ColumnHeader columnHeader_Count;
        private System.Windows.Forms.Button button_Print;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.GroupBox groupBox_Filter;
        private System.Windows.Forms.ComboBox comboBox_ArtistFilter;
        private System.Windows.Forms.ComboBox comboBox_CategoryFilter;
        private System.Windows.Forms.Label label_IdFilter;
        private System.Windows.Forms.Label label_CategoryFilter;
        private System.Windows.Forms.Label label_NameFilter;
        private System.Windows.Forms.Label label_ArtistFilter;
        private System.Windows.Forms.TextBox textBox_NameFilter;
        private System.Windows.Forms.Button button_ClearFilter;
        private System.Windows.Forms.TextBox textBox_IdFilter;
        protected System.Drawing.Printing.PrintDocument printDocument1;
    }
}