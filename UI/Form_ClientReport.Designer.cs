
namespace RecordStore_CarmellWasserman.UI
{
    partial class Form_ClientReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ClientReport));
            this.label_DateToday = new System.Windows.Forms.Label();
            this.label_StoreName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Cities = new System.Windows.Forms.TabPage();
            this.tabPage_ClientsOrders = new System.Windows.Forms.TabPage();
            this.listView_Clients = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_Print = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage_Cities.SuspendLayout();
            this.tabPage_ClientsOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_DateToday
            // 
            this.label_DateToday.AutoSize = true;
            this.label_DateToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DateToday.Location = new System.Drawing.Point(662, 52);
            this.label_DateToday.Name = "label_DateToday";
            this.label_DateToday.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_DateToday.Size = new System.Drawing.Size(220, 31);
            this.label_DateToday.TabIndex = 35;
            this.label_DateToday.Text = "label_DateToday";
            this.label_DateToday.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_StoreName
            // 
            this.label_StoreName.AutoSize = true;
            this.label_StoreName.Font = new System.Drawing.Font("Aharoni", 30F, System.Drawing.FontStyle.Bold);
            this.label_StoreName.Location = new System.Drawing.Point(109, 19);
            this.label_StoreName.Name = "label_StoreName";
            this.label_StoreName.Size = new System.Drawing.Size(556, 79);
            this.label_StoreName.TabIndex = 34;
            this.label_StoreName.Text = "Client Reports";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RecordStore_CarmellWasserman.Properties.Resources.recordplayer;
            this.pictureBox1.Location = new System.Drawing.Point(-16, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(1154, 701);
            this.chart1.TabIndex = 37;
            this.chart1.Text = "chart1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Cities);
            this.tabControl1.Controls.Add(this.tabPage_ClientsOrders);
            this.tabControl1.Location = new System.Drawing.Point(12, 104);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1170, 748);
            this.tabControl1.TabIndex = 38;
            // 
            // tabPage_Cities
            // 
            this.tabPage_Cities.Controls.Add(this.chart1);
            this.tabPage_Cities.Location = new System.Drawing.Point(8, 39);
            this.tabPage_Cities.Name = "tabPage_Cities";
            this.tabPage_Cities.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Cities.Size = new System.Drawing.Size(1154, 701);
            this.tabPage_Cities.TabIndex = 0;
            this.tabPage_Cities.Text = "Cities";
            this.tabPage_Cities.UseVisualStyleBackColor = true;
            // 
            // tabPage_ClientsOrders
            // 
            this.tabPage_ClientsOrders.Controls.Add(this.listView_Clients);
            this.tabPage_ClientsOrders.Location = new System.Drawing.Point(8, 39);
            this.tabPage_ClientsOrders.Name = "tabPage_ClientsOrders";
            this.tabPage_ClientsOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ClientsOrders.Size = new System.Drawing.Size(1154, 701);
            this.tabPage_ClientsOrders.TabIndex = 1;
            this.tabPage_ClientsOrders.Text = "Client\'s Orders";
            this.tabPage_ClientsOrders.UseVisualStyleBackColor = true;
            // 
            // listView_Clients
            // 
            this.listView_Clients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView_Clients.HideSelection = false;
            this.listView_Clients.Location = new System.Drawing.Point(174, 6);
            this.listView_Clients.Name = "listView_Clients";
            this.listView_Clients.Size = new System.Drawing.Size(766, 689);
            this.listView_Clients.TabIndex = 0;
            this.listView_Clients.UseCompatibleStateImageBehavior = false;
            this.listView_Clients.View = System.Windows.Forms.View.Details;
            this.listView_Clients.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_Clients_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Client";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Orders";
            this.columnHeader2.Width = 70;
            // 
            // button_Print
            // 
            this.button_Print.Location = new System.Drawing.Point(1061, 18);
            this.button_Print.Name = "button_Print";
            this.button_Print.Size = new System.Drawing.Size(113, 80);
            this.button_Print.TabIndex = 39;
            this.button_Print.Text = "print";
            this.button_Print.UseVisualStyleBackColor = true;
            this.button_Print.Click += new System.EventHandler(this.button_Print_Click);
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
            // Form_ClientReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1194, 864);
            this.Controls.Add(this.button_Print);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label_DateToday);
            this.Controls.Add(this.label_StoreName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form_ClientReport";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Text = "Client Reports";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Cities.ResumeLayout(false);
            this.tabPage_ClientsOrders.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_DateToday;
        private System.Windows.Forms.Label label_StoreName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Cities;
        private System.Windows.Forms.TabPage tabPage_ClientsOrders;
        private System.Windows.Forms.ListView listView_Clients;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button_Print;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}