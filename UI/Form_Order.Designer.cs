
namespace RecordStore_CarmellWasserman
{
    partial class Form_Order
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
            this.tabControl_Order = new System.Windows.Forms.TabControl();
            this.tabPage_OrderDetails = new System.Windows.Forms.TabPage();
            this.tabPage_OrderClient = new System.Windows.Forms.TabPage();
            this.label_DateToday = new System.Windows.Forms.Label();
            this.label_StoreName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage_OrderItems = new System.Windows.Forms.TabPage();
            this.listBox_Orders = new System.Windows.Forms.ListBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.label_Id = new System.Windows.Forms.Label();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.label_Note = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_Client = new System.Windows.Forms.Label();
            this.comboBox_Client = new System.Windows.Forms.ComboBox();
            this.button_AddClient = new System.Windows.Forms.Button();
            this.label_IdName = new System.Windows.Forms.Label();
            this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.richTextBox_Note = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_IdFilter = new System.Windows.Forms.TextBox();
            this.button_ClearFilter = new System.Windows.Forms.Button();
            this.label_IdFilter = new System.Windows.Forms.Label();
            this.label_FromDateFilter = new System.Windows.Forms.Label();
            this.label_ClientFilter = new System.Windows.Forms.Label();
            this.comboBox_ClientFilter = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_FromDateFilter = new System.Windows.Forms.DateTimePicker();
            this.label_ToDateFilter = new System.Windows.Forms.Label();
            this.dateTimePicker_ToDateFilter = new System.Windows.Forms.DateTimePicker();
            this.groupBox_Filter = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox_InOrderProducts = new System.Windows.Forms.ListBox();
            this.listBox_Products = new System.Windows.Forms.ListBox();
            this.tabControl_Order.SuspendLayout();
            this.tabPage_OrderDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage_OrderItems.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_Filter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Order
            // 
            this.tabControl_Order.Controls.Add(this.tabPage_OrderDetails);
            this.tabControl_Order.Controls.Add(this.tabPage_OrderClient);
            this.tabControl_Order.Controls.Add(this.tabPage_OrderItems);
            this.tabControl_Order.Location = new System.Drawing.Point(12, 107);
            this.tabControl_Order.Name = "tabControl_Order";
            this.tabControl_Order.SelectedIndex = 0;
            this.tabControl_Order.Size = new System.Drawing.Size(1220, 995);
            this.tabControl_Order.TabIndex = 1;
            // 
            // tabPage_OrderDetails
            // 
            this.tabPage_OrderDetails.BackColor = System.Drawing.Color.Firebrick;
            this.tabPage_OrderDetails.Controls.Add(this.groupBox_Filter);
            this.tabPage_OrderDetails.Controls.Add(this.groupBox2);
            this.tabPage_OrderDetails.Controls.Add(this.listBox_Orders);
            this.tabPage_OrderDetails.Location = new System.Drawing.Point(8, 39);
            this.tabPage_OrderDetails.Name = "tabPage_OrderDetails";
            this.tabPage_OrderDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_OrderDetails.Size = new System.Drawing.Size(1204, 948);
            this.tabPage_OrderDetails.TabIndex = 0;
            this.tabPage_OrderDetails.Text = "Order Details";
            // 
            // tabPage_OrderClient
            // 
            this.tabPage_OrderClient.BackColor = System.Drawing.Color.Firebrick;
            this.tabPage_OrderClient.Location = new System.Drawing.Point(8, 39);
            this.tabPage_OrderClient.Name = "tabPage_OrderClient";
            this.tabPage_OrderClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_OrderClient.Size = new System.Drawing.Size(1204, 948);
            this.tabPage_OrderClient.TabIndex = 1;
            this.tabPage_OrderClient.Text = "Order Client";
            // 
            // label_DateToday
            // 
            this.label_DateToday.AutoSize = true;
            this.label_DateToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DateToday.Location = new System.Drawing.Point(888, 58);
            this.label_DateToday.Name = "label_DateToday";
            this.label_DateToday.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_DateToday.Size = new System.Drawing.Size(220, 31);
            this.label_DateToday.TabIndex = 29;
            this.label_DateToday.Text = "label_DateToday";
            this.label_DateToday.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_StoreName
            // 
            this.label_StoreName.AutoSize = true;
            this.label_StoreName.Font = new System.Drawing.Font("Aharoni", 30F, System.Drawing.FontStyle.Bold);
            this.label_StoreName.Location = new System.Drawing.Point(111, 25);
            this.label_StoreName.Name = "label_StoreName";
            this.label_StoreName.Size = new System.Drawing.Size(556, 79);
            this.label_StoreName.TabIndex = 28;
            this.label_StoreName.Text = "RECORDLAND";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RecordStore_CarmellWasserman.Properties.Resources.recordplayer;
            this.pictureBox1.Location = new System.Drawing.Point(-14, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage_OrderItems
            // 
            this.tabPage_OrderItems.BackColor = System.Drawing.Color.Firebrick;
            this.tabPage_OrderItems.Controls.Add(this.listBox_Products);
            this.tabPage_OrderItems.Controls.Add(this.groupBox1);
            this.tabPage_OrderItems.Controls.Add(this.listBox_InOrderProducts);
            this.tabPage_OrderItems.Location = new System.Drawing.Point(8, 39);
            this.tabPage_OrderItems.Name = "tabPage_OrderItems";
            this.tabPage_OrderItems.Size = new System.Drawing.Size(1204, 948);
            this.tabPage_OrderItems.TabIndex = 2;
            this.tabPage_OrderItems.Text = "Order Items";
            // 
            // listBox_Orders
            // 
            this.listBox_Orders.FormattingEnabled = true;
            this.listBox_Orders.ItemHeight = 25;
            this.listBox_Orders.Location = new System.Drawing.Point(589, 57);
            this.listBox_Orders.Name = "listBox_Orders";
            this.listBox_Orders.Size = new System.Drawing.Size(569, 854);
            this.listBox_Orders.TabIndex = 24;
            this.listBox_Orders.Click += new System.EventHandler(this.listBox_Orders_DoubleClick);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(930, 1119);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(94, 47);
            this.button_Save.TabIndex = 12;
            this.button_Save.Text = "save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.save_Click);
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
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(1030, 1119);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(94, 47);
            this.button_Clear.TabIndex = 13;
            this.button_Clear.Text = "clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(1130, 1119);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(94, 47);
            this.button_Delete.TabIndex = 14;
            this.button_Delete.Text = "delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // label_Note
            // 
            this.label_Note.AutoSize = true;
            this.label_Note.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_Note.Location = new System.Drawing.Point(18, 202);
            this.label_Note.Name = "label_Note";
            this.label_Note.Size = new System.Drawing.Size(85, 37);
            this.label_Note.TabIndex = 3;
            this.label_Note.Text = "Note";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_Date.Location = new System.Drawing.Point(18, 147);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(84, 37);
            this.label_Date.TabIndex = 2;
            this.label_Date.Text = "Date";
            // 
            // label_Client
            // 
            this.label_Client.AutoSize = true;
            this.label_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_Client.Location = new System.Drawing.Point(17, 87);
            this.label_Client.Name = "label_Client";
            this.label_Client.Size = new System.Drawing.Size(98, 37);
            this.label_Client.TabIndex = 1;
            this.label_Client.Text = "Client";
            // 
            // comboBox_Client
            // 
            this.comboBox_Client.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Client.FormattingEnabled = true;
            this.comboBox_Client.Location = new System.Drawing.Point(267, 91);
            this.comboBox_Client.Name = "comboBox_Client";
            this.comboBox_Client.Size = new System.Drawing.Size(171, 33);
            this.comboBox_Client.TabIndex = 10;
            // 
            // button_AddClient
            // 
            this.button_AddClient.Location = new System.Drawing.Point(444, 89);
            this.button_AddClient.Name = "button_AddClient";
            this.button_AddClient.Size = new System.Drawing.Size(45, 45);
            this.button_AddClient.TabIndex = 11;
            this.button_AddClient.Text = "+";
            this.button_AddClient.UseVisualStyleBackColor = true;
            this.button_AddClient.Click += new System.EventHandler(this.button_AddClient_Click);
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
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.Location = new System.Drawing.Point(267, 153);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Size = new System.Drawing.Size(214, 31);
            this.dateTimePicker_Date.TabIndex = 21;
            // 
            // richTextBox_Note
            // 
            this.richTextBox_Note.Location = new System.Drawing.Point(25, 252);
            this.richTextBox_Note.Name = "richTextBox_Note";
            this.richTextBox_Note.Size = new System.Drawing.Size(456, 202);
            this.richTextBox_Note.TabIndex = 22;
            this.richTextBox_Note.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.richTextBox_Note);
            this.groupBox2.Controls.Add(this.dateTimePicker_Date);
            this.groupBox2.Controls.Add(this.label_IdName);
            this.groupBox2.Controls.Add(this.button_AddClient);
            this.groupBox2.Controls.Add(this.comboBox_Client);
            this.groupBox2.Controls.Add(this.label_Client);
            this.groupBox2.Controls.Add(this.label_Date);
            this.groupBox2.Controls.Add(this.label_Note);
            this.groupBox2.Controls.Add(this.label_Id);
            this.groupBox2.Location = new System.Drawing.Point(43, 425);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 486);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add/Update";
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
            // label_FromDateFilter
            // 
            this.label_FromDateFilter.AutoSize = true;
            this.label_FromDateFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_FromDateFilter.Location = new System.Drawing.Point(15, 152);
            this.label_FromDateFilter.Name = "label_FromDateFilter";
            this.label_FromDateFilter.Size = new System.Drawing.Size(93, 37);
            this.label_FromDateFilter.TabIndex = 23;
            this.label_FromDateFilter.Text = "From";
            // 
            // label_ClientFilter
            // 
            this.label_ClientFilter.AutoSize = true;
            this.label_ClientFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_ClientFilter.Location = new System.Drawing.Point(16, 92);
            this.label_ClientFilter.Name = "label_ClientFilter";
            this.label_ClientFilter.Size = new System.Drawing.Size(98, 37);
            this.label_ClientFilter.TabIndex = 22;
            this.label_ClientFilter.Text = "Client";
            // 
            // comboBox_ClientFilter
            // 
            this.comboBox_ClientFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ClientFilter.FormattingEnabled = true;
            this.comboBox_ClientFilter.Location = new System.Drawing.Point(268, 98);
            this.comboBox_ClientFilter.Name = "comboBox_ClientFilter";
            this.comboBox_ClientFilter.Size = new System.Drawing.Size(213, 33);
            this.comboBox_ClientFilter.TabIndex = 24;
            this.comboBox_ClientFilter.TextChanged += new System.EventHandler(this.comboBoxFilter_TextChanged);
            // 
            // dateTimePicker_FromDateFilter
            // 
            this.dateTimePicker_FromDateFilter.Location = new System.Drawing.Point(268, 160);
            this.dateTimePicker_FromDateFilter.Name = "dateTimePicker_FromDateFilter";
            this.dateTimePicker_FromDateFilter.Size = new System.Drawing.Size(213, 31);
            this.dateTimePicker_FromDateFilter.TabIndex = 26;
            this.dateTimePicker_FromDateFilter.ValueChanged += new System.EventHandler(this.clear_Click);
            // 
            // label_ToDateFilter
            // 
            this.label_ToDateFilter.AutoSize = true;
            this.label_ToDateFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_ToDateFilter.Location = new System.Drawing.Point(17, 208);
            this.label_ToDateFilter.Name = "label_ToDateFilter";
            this.label_ToDateFilter.Size = new System.Drawing.Size(55, 37);
            this.label_ToDateFilter.TabIndex = 27;
            this.label_ToDateFilter.Text = "To";
            // 
            // dateTimePicker_ToDateFilter
            // 
            this.dateTimePicker_ToDateFilter.Location = new System.Drawing.Point(268, 212);
            this.dateTimePicker_ToDateFilter.Name = "dateTimePicker_ToDateFilter";
            this.dateTimePicker_ToDateFilter.Size = new System.Drawing.Size(213, 31);
            this.dateTimePicker_ToDateFilter.TabIndex = 28;
            this.dateTimePicker_ToDateFilter.ValueChanged += new System.EventHandler(this.dateTimePicker_DateFilter_ValueChanged);
            // 
            // groupBox_Filter
            // 
            this.groupBox_Filter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox_Filter.Controls.Add(this.dateTimePicker_ToDateFilter);
            this.groupBox_Filter.Controls.Add(this.label_ToDateFilter);
            this.groupBox_Filter.Controls.Add(this.dateTimePicker_FromDateFilter);
            this.groupBox_Filter.Controls.Add(this.comboBox_ClientFilter);
            this.groupBox_Filter.Controls.Add(this.label_ClientFilter);
            this.groupBox_Filter.Controls.Add(this.label_FromDateFilter);
            this.groupBox_Filter.Controls.Add(this.label_IdFilter);
            this.groupBox_Filter.Controls.Add(this.button_ClearFilter);
            this.groupBox_Filter.Controls.Add(this.textBox_IdFilter);
            this.groupBox_Filter.Location = new System.Drawing.Point(43, 57);
            this.groupBox_Filter.Name = "groupBox_Filter";
            this.groupBox_Filter.Size = new System.Drawing.Size(513, 336);
            this.groupBox_Filter.TabIndex = 26;
            this.groupBox_Filter.TabStop = false;
            this.groupBox_Filter.Text = "Filter";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(44, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 336);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(268, 212);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(213, 31);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(17, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 37);
            this.label1.TabIndex = 27;
            this.label1.Text = "To";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(268, 160);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(213, 31);
            this.dateTimePicker2.TabIndex = 26;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(268, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(213, 33);
            this.comboBox1.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(16, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 37);
            this.label2.TabIndex = 22;
            this.label2.Text = "Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(15, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 37);
            this.label3.TabIndex = 23;
            this.label3.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(18, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 37);
            this.label4.TabIndex = 20;
            this.label4.Text = "Id";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "clear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(267, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 31);
            this.textBox1.TabIndex = 1;
            // 
            // listBox_InOrderProducts
            // 
            this.listBox_InOrderProducts.FormattingEnabled = true;
            this.listBox_InOrderProducts.ItemHeight = 25;
            this.listBox_InOrderProducts.Location = new System.Drawing.Point(590, 52);
            this.listBox_InOrderProducts.Name = "listBox_InOrderProducts";
            this.listBox_InOrderProducts.Size = new System.Drawing.Size(569, 854);
            this.listBox_InOrderProducts.TabIndex = 27;
            // 
            // listBox_Products
            // 
            this.listBox_Products.FormattingEnabled = true;
            this.listBox_Products.ItemHeight = 25;
            this.listBox_Products.Location = new System.Drawing.Point(44, 428);
            this.listBox_Products.Name = "listBox_Products";
            this.listBox_Products.Size = new System.Drawing.Size(513, 479);
            this.listBox_Products.TabIndex = 30;
            this.listBox_Products.DoubleClick += new System.EventHandler(this.listBox_Products_DoubleClick);
            // 
            // Form_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1244, 1189);
            this.Controls.Add(this.label_DateToday);
            this.Controls.Add(this.label_StoreName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl_Order);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Clear);
            this.Name = "Form_Order";
            this.Text = "Form_Order";
            this.tabControl_Order.ResumeLayout(false);
            this.tabPage_OrderDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage_OrderItems.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox_Filter.ResumeLayout(false);
            this.groupBox_Filter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Order;
        private System.Windows.Forms.TabPage tabPage_OrderDetails;
        private System.Windows.Forms.TabPage tabPage_OrderClient;
        private System.Windows.Forms.Label label_DateToday;
        private System.Windows.Forms.Label label_StoreName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox_Filter;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ToDateFilter;
        private System.Windows.Forms.Label label_ToDateFilter;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FromDateFilter;
        private System.Windows.Forms.ComboBox comboBox_ClientFilter;
        private System.Windows.Forms.Label label_ClientFilter;
        private System.Windows.Forms.Label label_FromDateFilter;
        private System.Windows.Forms.Label label_IdFilter;
        private System.Windows.Forms.Button button_ClearFilter;
        private System.Windows.Forms.TextBox textBox_IdFilter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox_Note;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
        private System.Windows.Forms.Label label_IdName;
        private System.Windows.Forms.Button button_AddClient;
        private System.Windows.Forms.ComboBox comboBox_Client;
        private System.Windows.Forms.Label label_Client;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_Note;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.ListBox listBox_Orders;
        private System.Windows.Forms.TabPage tabPage_OrderItems;
        private System.Windows.Forms.ListBox listBox_Products;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox_InOrderProducts;
    }
}