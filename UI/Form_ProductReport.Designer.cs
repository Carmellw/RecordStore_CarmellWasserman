
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.button_Print = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label_DateToday = new System.Windows.Forms.Label();
            this.label_StoreName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage_ProductsCondition = new System.Windows.Forms.TabPage();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage_ProductGenres = new System.Windows.Forms.TabPage();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage_ProductCategories = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage_VinylRecordsSales = new System.Windows.Forms.TabPage();
            this.listView_Records = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Products = new System.Windows.Forms.TabPage();
            this.button_ClearFilter = new System.Windows.Forms.Button();
            this.comboBox_ArtistFilter = new System.Windows.Forms.ComboBox();
            this.listView_Products = new System.Windows.Forms.ListView();
            this.columnHeader_Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Artist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Company = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Condition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_ArtistFilter = new System.Windows.Forms.Label();
            this.label_NameFilter = new System.Windows.Forms.Label();
            this.textBox_NameFilter = new System.Windows.Forms.TextBox();
            this.comboBox_CategoryFilter = new System.Windows.Forms.ComboBox();
            this.label_CategoryFilter = new System.Windows.Forms.Label();
            this.label_IdFilter = new System.Windows.Forms.Label();
            this.textBox_IdFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage_ProductsCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.tabPage_ProductGenres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.tabPage_ProductCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage_VinylRecordsSales.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_Products.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.document_PrintPage);
            // 
            // button_Print
            // 
            this.button_Print.Location = new System.Drawing.Point(1055, 15);
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
            // label_DateToday
            // 
            this.label_DateToday.AutoSize = true;
            this.label_DateToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DateToday.Location = new System.Drawing.Point(646, 49);
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
            this.label_StoreName.Location = new System.Drawing.Point(105, 16);
            this.label_StoreName.Name = "label_StoreName";
            this.label_StoreName.Size = new System.Drawing.Size(551, 79);
            this.label_StoreName.TabIndex = 37;
            this.label_StoreName.Text = "Stock Reports";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RecordStore_CarmellWasserman.Properties.Resources.recordplayer;
            this.pictureBox1.Location = new System.Drawing.Point(-20, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage_ProductsCondition
            // 
            this.tabPage_ProductsCondition.Controls.Add(this.chart3);
            this.tabPage_ProductsCondition.Location = new System.Drawing.Point(8, 39);
            this.tabPage_ProductsCondition.Name = "tabPage_ProductsCondition";
            this.tabPage_ProductsCondition.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ProductsCondition.Size = new System.Drawing.Size(1154, 722);
            this.tabPage_ProductsCondition.TabIndex = 4;
            this.tabPage_ProductsCondition.Text = "Products Condition";
            this.tabPage_ProductsCondition.UseVisualStyleBackColor = true;
            // 
            // chart3
            // 
            chartArea1.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart3.Legends.Add(legend1);
            this.chart3.Location = new System.Drawing.Point(0, 0);
            this.chart3.Name = "chart3";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart3.Series.Add(series1);
            this.chart3.Size = new System.Drawing.Size(1159, 722);
            this.chart3.TabIndex = 0;
            this.chart3.Text = "chart3";
            // 
            // tabPage_ProductGenres
            // 
            this.tabPage_ProductGenres.Controls.Add(this.chart2);
            this.tabPage_ProductGenres.Location = new System.Drawing.Point(8, 39);
            this.tabPage_ProductGenres.Name = "tabPage_ProductGenres";
            this.tabPage_ProductGenres.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ProductGenres.Size = new System.Drawing.Size(1154, 722);
            this.tabPage_ProductGenres.TabIndex = 3;
            this.tabPage_ProductGenres.Text = "Product Genres";
            this.tabPage_ProductGenres.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(0, 0);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(1154, 722);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart2";
            // 
            // tabPage_ProductCategories
            // 
            this.tabPage_ProductCategories.Controls.Add(this.chart1);
            this.tabPage_ProductCategories.Location = new System.Drawing.Point(8, 39);
            this.tabPage_ProductCategories.Name = "tabPage_ProductCategories";
            this.tabPage_ProductCategories.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ProductCategories.Size = new System.Drawing.Size(1154, 722);
            this.tabPage_ProductCategories.TabIndex = 2;
            this.tabPage_ProductCategories.Text = "Product Categories";
            this.tabPage_ProductCategories.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(1154, 722);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabPage_VinylRecordsSales
            // 
            this.tabPage_VinylRecordsSales.Controls.Add(this.listView_Records);
            this.tabPage_VinylRecordsSales.Location = new System.Drawing.Point(8, 39);
            this.tabPage_VinylRecordsSales.Name = "tabPage_VinylRecordsSales";
            this.tabPage_VinylRecordsSales.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_VinylRecordsSales.Size = new System.Drawing.Size(1154, 722);
            this.tabPage_VinylRecordsSales.TabIndex = 1;
            this.tabPage_VinylRecordsSales.Text = "Vinyl Records Sales";
            this.tabPage_VinylRecordsSales.UseVisualStyleBackColor = true;
            // 
            // listView_Records
            // 
            this.listView_Records.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView_Records.HideSelection = false;
            this.listView_Records.Location = new System.Drawing.Point(181, -3);
            this.listView_Records.Name = "listView_Records";
            this.listView_Records.Size = new System.Drawing.Size(802, 722);
            this.listView_Records.TabIndex = 0;
            this.listView_Records.UseCompatibleStateImageBehavior = false;
            this.listView_Records.View = System.Windows.Forms.View.Details;
            this.listView_Records.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_Records_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Sales";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Products);
            this.tabControl1.Controls.Add(this.tabPage_VinylRecordsSales);
            this.tabControl1.Controls.Add(this.tabPage_ProductCategories);
            this.tabControl1.Controls.Add(this.tabPage_ProductGenres);
            this.tabControl1.Controls.Add(this.tabPage_ProductsCondition);
            this.tabControl1.Location = new System.Drawing.Point(12, 98);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1170, 769);
            this.tabControl1.TabIndex = 31;
            // 
            // tabPage_Products
            // 
            this.tabPage_Products.Controls.Add(this.button_ClearFilter);
            this.tabPage_Products.Controls.Add(this.comboBox_ArtistFilter);
            this.tabPage_Products.Controls.Add(this.listView_Products);
            this.tabPage_Products.Controls.Add(this.label_ArtistFilter);
            this.tabPage_Products.Controls.Add(this.label_NameFilter);
            this.tabPage_Products.Controls.Add(this.textBox_NameFilter);
            this.tabPage_Products.Controls.Add(this.comboBox_CategoryFilter);
            this.tabPage_Products.Controls.Add(this.label_CategoryFilter);
            this.tabPage_Products.Controls.Add(this.label_IdFilter);
            this.tabPage_Products.Controls.Add(this.textBox_IdFilter);
            this.tabPage_Products.Location = new System.Drawing.Point(8, 39);
            this.tabPage_Products.Name = "tabPage_Products";
            this.tabPage_Products.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Products.Size = new System.Drawing.Size(1154, 722);
            this.tabPage_Products.TabIndex = 0;
            this.tabPage_Products.Text = "Products";
            this.tabPage_Products.UseVisualStyleBackColor = true;
            // 
            // button_ClearFilter
            // 
            this.button_ClearFilter.Location = new System.Drawing.Point(1042, 66);
            this.button_ClearFilter.Name = "button_ClearFilter";
            this.button_ClearFilter.Size = new System.Drawing.Size(94, 47);
            this.button_ClearFilter.TabIndex = 5;
            this.button_ClearFilter.Text = "clear";
            this.button_ClearFilter.UseVisualStyleBackColor = true;
            this.button_ClearFilter.Click += new System.EventHandler(this.clearFilter_Click);
            // 
            // comboBox_ArtistFilter
            // 
            this.comboBox_ArtistFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ArtistFilter.FormattingEnabled = true;
            this.comboBox_ArtistFilter.Location = new System.Drawing.Point(966, 18);
            this.comboBox_ArtistFilter.Name = "comboBox_ArtistFilter";
            this.comboBox_ArtistFilter.Size = new System.Drawing.Size(170, 33);
            this.comboBox_ArtistFilter.TabIndex = 22;
            this.comboBox_ArtistFilter.TextChanged += new System.EventHandler(this.comboBoxFilter_TextChanged);
            // 
            // listView_Products
            // 
            this.listView_Products.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Category,
            this.columnHeader_Name,
            this.columnHeader_Genre,
            this.columnHeader_Artist,
            this.columnHeader_Company,
            this.columnHeader_Condition,
            this.columnHeader_Count});
            this.listView_Products.HideSelection = false;
            this.listView_Products.Location = new System.Drawing.Point(0, 122);
            this.listView_Products.Name = "listView_Products";
            this.listView_Products.Size = new System.Drawing.Size(1154, 600);
            this.listView_Products.TabIndex = 0;
            this.listView_Products.UseCompatibleStateImageBehavior = false;
            this.listView_Products.View = System.Windows.Forms.View.Details;
            this.listView_Products.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_Products_ColumnClick);
            // 
            // columnHeader_Category
            // 
            this.columnHeader_Category.Text = "Category";
            this.columnHeader_Category.Width = 80;
            // 
            // columnHeader_Name
            // 
            this.columnHeader_Name.Text = "Name";
            this.columnHeader_Name.Width = 110;
            // 
            // columnHeader_Genre
            // 
            this.columnHeader_Genre.Text = "Genre";
            // 
            // columnHeader_Artist
            // 
            this.columnHeader_Artist.Text = "Artist";
            this.columnHeader_Artist.Width = 105;
            // 
            // columnHeader_Company
            // 
            this.columnHeader_Company.Text = "Company";
            this.columnHeader_Company.Width = 90;
            // 
            // columnHeader_Condition
            // 
            this.columnHeader_Condition.Text = "Condition";
            // 
            // columnHeader_Count
            // 
            this.columnHeader_Count.Text = "Count";
            this.columnHeader_Count.Width = 50;
            // 
            // label_ArtistFilter
            // 
            this.label_ArtistFilter.AutoSize = true;
            this.label_ArtistFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_ArtistFilter.Location = new System.Drawing.Point(876, 16);
            this.label_ArtistFilter.Name = "label_ArtistFilter";
            this.label_ArtistFilter.Size = new System.Drawing.Size(91, 37);
            this.label_ArtistFilter.TabIndex = 3;
            this.label_ArtistFilter.Text = "Artist";
            // 
            // label_NameFilter
            // 
            this.label_NameFilter.AutoSize = true;
            this.label_NameFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_NameFilter.Location = new System.Drawing.Point(560, 16);
            this.label_NameFilter.Name = "label_NameFilter";
            this.label_NameFilter.Size = new System.Drawing.Size(103, 37);
            this.label_NameFilter.TabIndex = 2;
            this.label_NameFilter.Text = "Name";
            // 
            // textBox_NameFilter
            // 
            this.textBox_NameFilter.Location = new System.Drawing.Point(665, 18);
            this.textBox_NameFilter.Name = "textBox_NameFilter";
            this.textBox_NameFilter.Size = new System.Drawing.Size(167, 31);
            this.textBox_NameFilter.TabIndex = 3;
            this.textBox_NameFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Heb_KeyPress);
            this.textBox_NameFilter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
            // 
            // comboBox_CategoryFilter
            // 
            this.comboBox_CategoryFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CategoryFilter.FormattingEnabled = true;
            this.comboBox_CategoryFilter.Location = new System.Drawing.Point(345, 16);
            this.comboBox_CategoryFilter.Name = "comboBox_CategoryFilter";
            this.comboBox_CategoryFilter.Size = new System.Drawing.Size(170, 33);
            this.comboBox_CategoryFilter.TabIndex = 21;
            this.comboBox_CategoryFilter.TextChanged += new System.EventHandler(this.comboBoxFilter_TextChanged);
            // 
            // label_CategoryFilter
            // 
            this.label_CategoryFilter.AutoSize = true;
            this.label_CategoryFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_CategoryFilter.Location = new System.Drawing.Point(193, 15);
            this.label_CategoryFilter.Name = "label_CategoryFilter";
            this.label_CategoryFilter.Size = new System.Drawing.Size(146, 37);
            this.label_CategoryFilter.TabIndex = 1;
            this.label_CategoryFilter.Text = "Category";
            // 
            // label_IdFilter
            // 
            this.label_IdFilter.AutoSize = true;
            this.label_IdFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_IdFilter.Location = new System.Drawing.Point(6, 17);
            this.label_IdFilter.Name = "label_IdFilter";
            this.label_IdFilter.Size = new System.Drawing.Size(43, 37);
            this.label_IdFilter.TabIndex = 20;
            this.label_IdFilter.Text = "Id";
            // 
            // textBox_IdFilter
            // 
            this.textBox_IdFilter.Location = new System.Drawing.Point(55, 18);
            this.textBox_IdFilter.Name = "textBox_IdFilter";
            this.textBox_IdFilter.Size = new System.Drawing.Size(108, 31);
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
            this.ClientSize = new System.Drawing.Size(1191, 879);
            this.Controls.Add(this.label_DateToday);
            this.Controls.Add(this.label_StoreName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button_Print);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_ProductReport";
            this.Text = "Stock Reports";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage_ProductsCondition.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.tabPage_ProductGenres.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.tabPage_ProductCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage_VinylRecordsSales.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Products.ResumeLayout(false);
            this.tabPage_Products.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Print;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        protected System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label_DateToday;
        private System.Windows.Forms.Label label_StoreName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage_ProductsCondition;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.TabPage tabPage_ProductGenres;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.TabPage tabPage_ProductCategories;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage tabPage_VinylRecordsSales;
        private System.Windows.Forms.ListView listView_Records;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Products;
        private System.Windows.Forms.Button button_ClearFilter;
        private System.Windows.Forms.ListView listView_Products;
        private System.Windows.Forms.ColumnHeader columnHeader_Category;
        private System.Windows.Forms.ColumnHeader columnHeader_Name;
        private System.Windows.Forms.ColumnHeader columnHeader_Genre;
        private System.Windows.Forms.ColumnHeader columnHeader_Artist;
        private System.Windows.Forms.ColumnHeader columnHeader_Company;
        private System.Windows.Forms.ColumnHeader columnHeader_Condition;
        private System.Windows.Forms.ColumnHeader columnHeader_Count;
        private System.Windows.Forms.Label label_IdFilter;
        private System.Windows.Forms.TextBox textBox_IdFilter;
        private System.Windows.Forms.ComboBox comboBox_ArtistFilter;
        private System.Windows.Forms.Label label_ArtistFilter;
        private System.Windows.Forms.Label label_NameFilter;
        private System.Windows.Forms.TextBox textBox_NameFilter;
        private System.Windows.Forms.ComboBox comboBox_CategoryFilter;
        private System.Windows.Forms.Label label_CategoryFilter;
    }
}