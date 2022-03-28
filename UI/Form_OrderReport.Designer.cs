
namespace RecordStore_CarmellWasserman.UI
{
    partial class Form_OrderReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_OrderReport));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dateTimePicker_ToDateFilter = new System.Windows.Forms.DateTimePicker();
            this.label_ToDateFilter = new System.Windows.Forms.Label();
            this.dateTimePicker_FromDateFilter = new System.Windows.Forms.DateTimePicker();
            this.comboBox_ClientFilter = new System.Windows.Forms.ComboBox();
            this.label_ClientFilter = new System.Windows.Forms.Label();
            this.label_FromDateFilter = new System.Windows.Forms.Label();
            this.label_IdFilter = new System.Windows.Forms.Label();
            this.button_ClearFilter = new System.Windows.Forms.Button();
            this.textBox_IdFilter = new System.Windows.Forms.TextBox();
            this.button_Print = new System.Windows.Forms.Button();
            this.listView_Orders = new System.Windows.Forms.ListView();
            this.columnHeader_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Note = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Orders = new System.Windows.Forms.TabPage();
            this.tabPage_OrdersByMonth = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage_OrdersByDay = new System.Windows.Forms.TabPage();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_DateToday = new System.Windows.Forms.Label();
            this.label_StoreName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage_Orders.SuspendLayout();
            this.tabPage_OrdersByMonth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage_OrdersByDay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker_ToDateFilter
            // 
            this.dateTimePicker_ToDateFilter.Location = new System.Drawing.Point(924, 10);
            this.dateTimePicker_ToDateFilter.Name = "dateTimePicker_ToDateFilter";
            this.dateTimePicker_ToDateFilter.Size = new System.Drawing.Size(213, 31);
            this.dateTimePicker_ToDateFilter.TabIndex = 37;
            this.dateTimePicker_ToDateFilter.ValueChanged += new System.EventHandler(this.dateTimePicker_DateFilter_ValueChanged);
            this.dateTimePicker_ToDateFilter.MouseCaptureChanged += new System.EventHandler(this.dateTimePicker_Filter_MouseCaptureChanged);
            // 
            // label_ToDateFilter
            // 
            this.label_ToDateFilter.AutoSize = true;
            this.label_ToDateFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_ToDateFilter.Location = new System.Drawing.Point(847, 6);
            this.label_ToDateFilter.Name = "label_ToDateFilter";
            this.label_ToDateFilter.Size = new System.Drawing.Size(55, 37);
            this.label_ToDateFilter.TabIndex = 36;
            this.label_ToDateFilter.Text = "To";
            // 
            // dateTimePicker_FromDateFilter
            // 
            this.dateTimePicker_FromDateFilter.Location = new System.Drawing.Point(620, 6);
            this.dateTimePicker_FromDateFilter.Name = "dateTimePicker_FromDateFilter";
            this.dateTimePicker_FromDateFilter.Size = new System.Drawing.Size(189, 31);
            this.dateTimePicker_FromDateFilter.TabIndex = 35;
            this.dateTimePicker_FromDateFilter.ValueChanged += new System.EventHandler(this.dateTimePicker_DateFilter_ValueChanged);
            this.dateTimePicker_FromDateFilter.MouseCaptureChanged += new System.EventHandler(this.dateTimePicker_Filter_MouseCaptureChanged);
            // 
            // comboBox_ClientFilter
            // 
            this.comboBox_ClientFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ClientFilter.FormattingEnabled = true;
            this.comboBox_ClientFilter.Location = new System.Drawing.Point(290, 7);
            this.comboBox_ClientFilter.Name = "comboBox_ClientFilter";
            this.comboBox_ClientFilter.Size = new System.Drawing.Size(187, 33);
            this.comboBox_ClientFilter.TabIndex = 34;
            this.comboBox_ClientFilter.TextChanged += new System.EventHandler(this.comboBoxFilter_TextChanged);
            // 
            // label_ClientFilter
            // 
            this.label_ClientFilter.AutoSize = true;
            this.label_ClientFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_ClientFilter.Location = new System.Drawing.Point(186, 3);
            this.label_ClientFilter.Name = "label_ClientFilter";
            this.label_ClientFilter.Size = new System.Drawing.Size(98, 37);
            this.label_ClientFilter.TabIndex = 32;
            this.label_ClientFilter.Text = "Client";
            // 
            // label_FromDateFilter
            // 
            this.label_FromDateFilter.AutoSize = true;
            this.label_FromDateFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_FromDateFilter.Location = new System.Drawing.Point(521, 3);
            this.label_FromDateFilter.Name = "label_FromDateFilter";
            this.label_FromDateFilter.Size = new System.Drawing.Size(93, 37);
            this.label_FromDateFilter.TabIndex = 33;
            this.label_FromDateFilter.Text = "From";
            // 
            // label_IdFilter
            // 
            this.label_IdFilter.AutoSize = true;
            this.label_IdFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_IdFilter.Location = new System.Drawing.Point(3, 3);
            this.label_IdFilter.Name = "label_IdFilter";
            this.label_IdFilter.Size = new System.Drawing.Size(43, 37);
            this.label_IdFilter.TabIndex = 31;
            this.label_IdFilter.Text = "Id";
            // 
            // button_ClearFilter
            // 
            this.button_ClearFilter.Location = new System.Drawing.Point(1043, 54);
            this.button_ClearFilter.Name = "button_ClearFilter";
            this.button_ClearFilter.Size = new System.Drawing.Size(94, 47);
            this.button_ClearFilter.TabIndex = 30;
            this.button_ClearFilter.Text = "clear";
            this.button_ClearFilter.UseVisualStyleBackColor = true;
            this.button_ClearFilter.Click += new System.EventHandler(this.clearFilter_Click);
            // 
            // textBox_IdFilter
            // 
            this.textBox_IdFilter.Location = new System.Drawing.Point(52, 6);
            this.textBox_IdFilter.Name = "textBox_IdFilter";
            this.textBox_IdFilter.Size = new System.Drawing.Size(100, 31);
            this.textBox_IdFilter.TabIndex = 29;
            this.textBox_IdFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            this.textBox_IdFilter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
            // 
            // button_Print
            // 
            this.button_Print.Location = new System.Drawing.Point(1069, 12);
            this.button_Print.Name = "button_Print";
            this.button_Print.Size = new System.Drawing.Size(113, 80);
            this.button_Print.TabIndex = 32;
            this.button_Print.Text = "print";
            this.button_Print.UseVisualStyleBackColor = true;
            this.button_Print.Click += new System.EventHandler(this.button_Print_Click);
            // 
            // listView_Orders
            // 
            this.listView_Orders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Name,
            this.columnHeader_Date,
            this.columnHeader_Note});
            this.listView_Orders.HideSelection = false;
            this.listView_Orders.Location = new System.Drawing.Point(3, 114);
            this.listView_Orders.Name = "listView_Orders";
            this.listView_Orders.Size = new System.Drawing.Size(1145, 605);
            this.listView_Orders.TabIndex = 31;
            this.listView_Orders.UseCompatibleStateImageBehavior = false;
            this.listView_Orders.View = System.Windows.Forms.View.Details;
            this.listView_Orders.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_Orders_ColumnClick);
            // 
            // columnHeader_Name
            // 
            this.columnHeader_Name.Text = "Name";
            this.columnHeader_Name.Width = 140;
            // 
            // columnHeader_Date
            // 
            this.columnHeader_Date.Text = "Date";
            this.columnHeader_Date.Width = 140;
            // 
            // columnHeader_Note
            // 
            this.columnHeader_Note.Text = "Note";
            this.columnHeader_Note.Width = 270;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.document_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Orders);
            this.tabControl1.Controls.Add(this.tabPage_OrdersByMonth);
            this.tabControl1.Controls.Add(this.tabPage_OrdersByDay);
            this.tabControl1.Location = new System.Drawing.Point(12, 98);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1170, 769);
            this.tabControl1.TabIndex = 34;
            // 
            // tabPage_Orders
            // 
            this.tabPage_Orders.Controls.Add(this.button_ClearFilter);
            this.tabPage_Orders.Controls.Add(this.dateTimePicker_ToDateFilter);
            this.tabPage_Orders.Controls.Add(this.listView_Orders);
            this.tabPage_Orders.Controls.Add(this.label_ToDateFilter);
            this.tabPage_Orders.Controls.Add(this.dateTimePicker_FromDateFilter);
            this.tabPage_Orders.Controls.Add(this.label_IdFilter);
            this.tabPage_Orders.Controls.Add(this.label_FromDateFilter);
            this.tabPage_Orders.Controls.Add(this.comboBox_ClientFilter);
            this.tabPage_Orders.Controls.Add(this.textBox_IdFilter);
            this.tabPage_Orders.Controls.Add(this.label_ClientFilter);
            this.tabPage_Orders.Location = new System.Drawing.Point(8, 39);
            this.tabPage_Orders.Name = "tabPage_Orders";
            this.tabPage_Orders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Orders.Size = new System.Drawing.Size(1154, 722);
            this.tabPage_Orders.TabIndex = 0;
            this.tabPage_Orders.Text = "Orders";
            this.tabPage_Orders.UseVisualStyleBackColor = true;
            // 
            // tabPage_OrdersByMonth
            // 
            this.tabPage_OrdersByMonth.Controls.Add(this.chart1);
            this.tabPage_OrdersByMonth.Location = new System.Drawing.Point(8, 39);
            this.tabPage_OrdersByMonth.Name = "tabPage_OrdersByMonth";
            this.tabPage_OrdersByMonth.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_OrdersByMonth.Size = new System.Drawing.Size(1154, 722);
            this.tabPage_OrdersByMonth.TabIndex = 1;
            this.tabPage_OrdersByMonth.Text = "Orders By Month";
            this.tabPage_OrdersByMonth.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1154, 719);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabPage_OrdersByDay
            // 
            this.tabPage_OrdersByDay.Controls.Add(this.chart2);
            this.tabPage_OrdersByDay.Location = new System.Drawing.Point(8, 39);
            this.tabPage_OrdersByDay.Name = "tabPage_OrdersByDay";
            this.tabPage_OrdersByDay.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_OrdersByDay.Size = new System.Drawing.Size(1154, 722);
            this.tabPage_OrdersByDay.TabIndex = 2;
            this.tabPage_OrdersByDay.Text = "Orders By Day";
            this.tabPage_OrdersByDay.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(3, 3);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(1148, 716);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart2";
            // 
            // label_DateToday
            // 
            this.label_DateToday.AutoSize = true;
            this.label_DateToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DateToday.Location = new System.Drawing.Point(681, 49);
            this.label_DateToday.Name = "label_DateToday";
            this.label_DateToday.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_DateToday.Size = new System.Drawing.Size(220, 31);
            this.label_DateToday.TabIndex = 41;
            this.label_DateToday.Text = "label_DateToday";
            this.label_DateToday.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_StoreName
            // 
            this.label_StoreName.AutoSize = true;
            this.label_StoreName.Font = new System.Drawing.Font("Aharoni", 30F, System.Drawing.FontStyle.Bold);
            this.label_StoreName.Location = new System.Drawing.Point(113, 16);
            this.label_StoreName.Name = "label_StoreName";
            this.label_StoreName.Size = new System.Drawing.Size(573, 79);
            this.label_StoreName.TabIndex = 40;
            this.label_StoreName.Text = "Order Reports";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RecordStore_CarmellWasserman.Properties.Resources.recordplayer;
            this.pictureBox1.Location = new System.Drawing.Point(-12, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // Form_OrderReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1194, 879);
            this.Controls.Add(this.label_DateToday);
            this.Controls.Add(this.label_StoreName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button_Print);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_OrderReport";
            this.Text = "Order Reports";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Orders.ResumeLayout(false);
            this.tabPage_Orders.PerformLayout();
            this.tabPage_OrdersByMonth.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage_OrdersByDay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Print;
        private System.Windows.Forms.ListView listView_Orders;
        private System.Windows.Forms.ColumnHeader columnHeader_Name;
        private System.Windows.Forms.ColumnHeader columnHeader_Date;
        private System.Windows.Forms.ColumnHeader columnHeader_Note;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ToDateFilter;
        private System.Windows.Forms.Label label_ToDateFilter;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FromDateFilter;
        private System.Windows.Forms.ComboBox comboBox_ClientFilter;
        private System.Windows.Forms.Label label_ClientFilter;
        private System.Windows.Forms.Label label_FromDateFilter;
        private System.Windows.Forms.Label label_IdFilter;
        private System.Windows.Forms.Button button_ClearFilter;
        private System.Windows.Forms.TextBox textBox_IdFilter;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Orders;
        private System.Windows.Forms.TabPage tabPage_OrdersByMonth;
        private System.Windows.Forms.Label label_DateToday;
        private System.Windows.Forms.Label label_StoreName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage tabPage_OrdersByDay;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}