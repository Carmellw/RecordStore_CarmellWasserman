
namespace RecordStore_CarmellWasserman.UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Order));
            this.tabControl_Order = new System.Windows.Forms.TabControl();
            this.tabPage_OrderDetails = new System.Windows.Forms.TabPage();
            this.groupBox_Filter = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_ToDateFilter = new System.Windows.Forms.DateTimePicker();
            this.label_ToDateFilter = new System.Windows.Forms.Label();
            this.dateTimePicker_FromDateFilter = new System.Windows.Forms.DateTimePicker();
            this.comboBox_ClientFilter = new System.Windows.Forms.ComboBox();
            this.label_ClientFilter = new System.Windows.Forms.Label();
            this.label_FromDateFilter = new System.Windows.Forms.Label();
            this.label_IdFilter = new System.Windows.Forms.Label();
            this.button_ClearFilter = new System.Windows.Forms.Button();
            this.textBox_IdFilter = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox_Note = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.label_IdName = new System.Windows.Forms.Label();
            this.button_AddClient = new System.Windows.Forms.Button();
            this.comboBox_Client = new System.Windows.Forms.ComboBox();
            this.label_Client = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_Note = new System.Windows.Forms.Label();
            this.label_Id = new System.Windows.Forms.Label();
            this.listBox_Orders = new System.Windows.Forms.ListBox();
            this.tabPage_OrderClient = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_PhoneNumberFilterClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_FirstNameFilterClient = new System.Windows.Forms.TextBox();
            this.label_FirstNameFilter = new System.Windows.Forms.Label();
            this.label_LastNameFilter = new System.Windows.Forms.Label();
            this.label_PhoneNumerFilter = new System.Windows.Forms.Label();
            this.textBox_LastNameFilterClient = new System.Windows.Forms.TextBox();
            this.button_ClearFilterClient = new System.Windows.Forms.Button();
            this.textBox_IdFilterClient = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_FirstNameClient = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_LastNameClient = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_CityClient = new System.Windows.Forms.Label();
            this.label_PhoneNumberClient = new System.Windows.Forms.Label();
            this.label_IdClient = new System.Windows.Forms.Label();
            this.listBox_Clients = new System.Windows.Forms.ListBox();
            this.tabPage_OrderItems = new System.Windows.Forms.TabPage();
            this.label_Payment = new System.Windows.Forms.Label();
            this.listBox_InOrderProductsCount = new System.Windows.Forms.ListBox();
            this.button_Minus = new System.Windows.Forms.Button();
            this.button_Plus = new System.Windows.Forms.Button();
            this.listBox_Products = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_ArtistFilterProduct = new System.Windows.Forms.ComboBox();
            this.comboBox_CategoryFilterProduct = new System.Windows.Forms.ComboBox();
            this.label_CategoryFilter = new System.Windows.Forms.Label();
            this.label_NameFilter = new System.Windows.Forms.Label();
            this.label_ArtistFilter = new System.Windows.Forms.Label();
            this.textBox_NameFilterProduct = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_ClearFilterProduct = new System.Windows.Forms.Button();
            this.textBox_IdFilterProduct = new System.Windows.Forms.TextBox();
            this.listBox_InOrderProducts = new System.Windows.Forms.ListBox();
            this.label_DateToday = new System.Windows.Forms.Label();
            this.label_StoreName = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_OrderReport = new System.Windows.Forms.Button();
            this.tabControl_Order.SuspendLayout();
            this.tabPage_OrderDetails.SuspendLayout();
            this.groupBox_Filter.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage_OrderClient.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage_OrderItems.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // dateTimePicker_ToDateFilter
            // 
            this.dateTimePicker_ToDateFilter.Location = new System.Drawing.Point(268, 212);
            this.dateTimePicker_ToDateFilter.Name = "dateTimePicker_ToDateFilter";
            this.dateTimePicker_ToDateFilter.Size = new System.Drawing.Size(213, 31);
            this.dateTimePicker_ToDateFilter.TabIndex = 28;
            this.dateTimePicker_ToDateFilter.ValueChanged += new System.EventHandler(this.dateTimePicker_DateFilter_ValueChanged);
            this.dateTimePicker_ToDateFilter.MouseCaptureChanged += new System.EventHandler(this.dateTimePicker_Filter_MouseCaptureChanged);
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
            // dateTimePicker_FromDateFilter
            // 
            this.dateTimePicker_FromDateFilter.Location = new System.Drawing.Point(268, 160);
            this.dateTimePicker_FromDateFilter.Name = "dateTimePicker_FromDateFilter";
            this.dateTimePicker_FromDateFilter.Size = new System.Drawing.Size(213, 31);
            this.dateTimePicker_FromDateFilter.TabIndex = 26;
            this.dateTimePicker_FromDateFilter.ValueChanged += new System.EventHandler(this.dateTimePicker_DateFilter_ValueChanged);
            this.dateTimePicker_FromDateFilter.MouseCaptureChanged += new System.EventHandler(this.dateTimePicker_Filter_MouseCaptureChanged);
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
            // richTextBox_Note
            // 
            this.richTextBox_Note.Location = new System.Drawing.Point(25, 252);
            this.richTextBox_Note.Name = "richTextBox_Note";
            this.richTextBox_Note.Size = new System.Drawing.Size(456, 202);
            this.richTextBox_Note.TabIndex = 22;
            this.richTextBox_Note.Text = "";
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.Location = new System.Drawing.Point(267, 153);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Size = new System.Drawing.Size(214, 31);
            this.dateTimePicker_Date.TabIndex = 21;
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
            // comboBox_Client
            // 
            this.comboBox_Client.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Client.FormattingEnabled = true;
            this.comboBox_Client.Location = new System.Drawing.Point(267, 91);
            this.comboBox_Client.Name = "comboBox_Client";
            this.comboBox_Client.Size = new System.Drawing.Size(171, 33);
            this.comboBox_Client.TabIndex = 10;
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
            // tabPage_OrderClient
            // 
            this.tabPage_OrderClient.BackColor = System.Drawing.Color.Firebrick;
            this.tabPage_OrderClient.Controls.Add(this.groupBox3);
            this.tabPage_OrderClient.Controls.Add(this.groupBox4);
            this.tabPage_OrderClient.Controls.Add(this.listBox_Clients);
            this.tabPage_OrderClient.Location = new System.Drawing.Point(8, 39);
            this.tabPage_OrderClient.Name = "tabPage_OrderClient";
            this.tabPage_OrderClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_OrderClient.Size = new System.Drawing.Size(1204, 948);
            this.tabPage_OrderClient.TabIndex = 1;
            this.tabPage_OrderClient.Text = "Order Client";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Controls.Add(this.textBox_PhoneNumberFilterClient);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBox_FirstNameFilterClient);
            this.groupBox3.Controls.Add(this.label_FirstNameFilter);
            this.groupBox3.Controls.Add(this.label_LastNameFilter);
            this.groupBox3.Controls.Add(this.label_PhoneNumerFilter);
            this.groupBox3.Controls.Add(this.textBox_LastNameFilterClient);
            this.groupBox3.Controls.Add(this.button_ClearFilterClient);
            this.groupBox3.Controls.Add(this.textBox_IdFilterClient);
            this.groupBox3.Location = new System.Drawing.Point(45, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(513, 336);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filter";
            // 
            // textBox_PhoneNumberFilterClient
            // 
            this.textBox_PhoneNumberFilterClient.Location = new System.Drawing.Point(267, 208);
            this.textBox_PhoneNumberFilterClient.MaxLength = 10;
            this.textBox_PhoneNumberFilterClient.Name = "textBox_PhoneNumberFilterClient";
            this.textBox_PhoneNumberFilterClient.Size = new System.Drawing.Size(214, 31);
            this.textBox_PhoneNumberFilterClient.TabIndex = 4;
            this.textBox_PhoneNumberFilterClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            this.textBox_PhoneNumberFilterClient.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_FilterClient_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(18, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 37);
            this.label1.TabIndex = 20;
            this.label1.Text = "Id";
            // 
            // textBox_FirstNameFilterClient
            // 
            this.textBox_FirstNameFilterClient.Location = new System.Drawing.Point(267, 95);
            this.textBox_FirstNameFilterClient.MaxLength = 4000;
            this.textBox_FirstNameFilterClient.Name = "textBox_FirstNameFilterClient";
            this.textBox_FirstNameFilterClient.Size = new System.Drawing.Size(214, 31);
            this.textBox_FirstNameFilterClient.TabIndex = 2;
            this.textBox_FirstNameFilterClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Heb_KeyPress);
            this.textBox_FirstNameFilterClient.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_FilterClient_KeyUp);
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
            // textBox_LastNameFilterClient
            // 
            this.textBox_LastNameFilterClient.Location = new System.Drawing.Point(267, 153);
            this.textBox_LastNameFilterClient.Name = "textBox_LastNameFilterClient";
            this.textBox_LastNameFilterClient.Size = new System.Drawing.Size(214, 31);
            this.textBox_LastNameFilterClient.TabIndex = 3;
            this.textBox_LastNameFilterClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Heb_KeyPress);
            this.textBox_LastNameFilterClient.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_FilterClient_KeyUp);
            // 
            // button_ClearFilterClient
            // 
            this.button_ClearFilterClient.Location = new System.Drawing.Point(387, 265);
            this.button_ClearFilterClient.Name = "button_ClearFilterClient";
            this.button_ClearFilterClient.Size = new System.Drawing.Size(94, 47);
            this.button_ClearFilterClient.TabIndex = 5;
            this.button_ClearFilterClient.Text = "clear";
            this.button_ClearFilterClient.UseVisualStyleBackColor = true;
            this.button_ClearFilterClient.Click += new System.EventHandler(this.button_ClearFilterClient_Click);
            // 
            // textBox_IdFilterClient
            // 
            this.textBox_IdFilterClient.Location = new System.Drawing.Point(267, 40);
            this.textBox_IdFilterClient.Name = "textBox_IdFilterClient";
            this.textBox_IdFilterClient.Size = new System.Drawing.Size(214, 31);
            this.textBox_IdFilterClient.TabIndex = 1;
            this.textBox_IdFilterClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            this.textBox_IdFilterClient.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_FilterClient_KeyUp);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label_FirstNameClient);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label_LastNameClient);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label_CityClient);
            this.groupBox4.Controls.Add(this.label_PhoneNumberClient);
            this.groupBox4.Controls.Add(this.label_IdClient);
            this.groupBox4.Location = new System.Drawing.Point(45, 415);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(513, 486);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Client Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(18, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 37);
            this.label2.TabIndex = 20;
            this.label2.Text = "Id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(10, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 37);
            this.label9.TabIndex = 1;
            this.label9.Text = " First Name";
            // 
            // label_FirstNameClient
            // 
            this.label_FirstNameClient.AutoSize = true;
            this.label_FirstNameClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_FirstNameClient.Location = new System.Drawing.Point(260, 89);
            this.label_FirstNameClient.Name = "label_FirstNameClient";
            this.label_FirstNameClient.Size = new System.Drawing.Size(0, 37);
            this.label_FirstNameClient.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(10, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 37);
            this.label8.TabIndex = 2;
            this.label8.Text = " Last Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(10, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 37);
            this.label7.TabIndex = 16;
            this.label7.Text = " City";
            // 
            // label_LastNameClient
            // 
            this.label_LastNameClient.AutoSize = true;
            this.label_LastNameClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_LastNameClient.Location = new System.Drawing.Point(260, 147);
            this.label_LastNameClient.Name = "label_LastNameClient";
            this.label_LastNameClient.Size = new System.Drawing.Size(0, 37);
            this.label_LastNameClient.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(20, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 37);
            this.label6.TabIndex = 3;
            this.label6.Text = "Phone Number";
            // 
            // label_CityClient
            // 
            this.label_CityClient.AutoSize = true;
            this.label_CityClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_CityClient.Location = new System.Drawing.Point(260, 256);
            this.label_CityClient.Name = "label_CityClient";
            this.label_CityClient.Size = new System.Drawing.Size(0, 37);
            this.label_CityClient.TabIndex = 16;
            // 
            // label_PhoneNumberClient
            // 
            this.label_PhoneNumberClient.AutoSize = true;
            this.label_PhoneNumberClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_PhoneNumberClient.Location = new System.Drawing.Point(260, 202);
            this.label_PhoneNumberClient.Name = "label_PhoneNumberClient";
            this.label_PhoneNumberClient.Size = new System.Drawing.Size(0, 37);
            this.label_PhoneNumberClient.TabIndex = 3;
            // 
            // label_IdClient
            // 
            this.label_IdClient.AutoSize = true;
            this.label_IdClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_IdClient.Location = new System.Drawing.Point(261, 37);
            this.label_IdClient.Name = "label_IdClient";
            this.label_IdClient.Size = new System.Drawing.Size(0, 31);
            this.label_IdClient.TabIndex = 12;
            // 
            // listBox_Clients
            // 
            this.listBox_Clients.FormattingEnabled = true;
            this.listBox_Clients.ItemHeight = 25;
            this.listBox_Clients.Location = new System.Drawing.Point(591, 47);
            this.listBox_Clients.Name = "listBox_Clients";
            this.listBox_Clients.Size = new System.Drawing.Size(569, 854);
            this.listBox_Clients.TabIndex = 24;
            this.listBox_Clients.DoubleClick += new System.EventHandler(this.listBox_Clients_DoubleClick);
            // 
            // tabPage_OrderItems
            // 
            this.tabPage_OrderItems.BackColor = System.Drawing.Color.Firebrick;
            this.tabPage_OrderItems.Controls.Add(this.label_Payment);
            this.tabPage_OrderItems.Controls.Add(this.listBox_InOrderProductsCount);
            this.tabPage_OrderItems.Controls.Add(this.button_Minus);
            this.tabPage_OrderItems.Controls.Add(this.button_Plus);
            this.tabPage_OrderItems.Controls.Add(this.listBox_Products);
            this.tabPage_OrderItems.Controls.Add(this.groupBox1);
            this.tabPage_OrderItems.Controls.Add(this.listBox_InOrderProducts);
            this.tabPage_OrderItems.Location = new System.Drawing.Point(8, 39);
            this.tabPage_OrderItems.Name = "tabPage_OrderItems";
            this.tabPage_OrderItems.Size = new System.Drawing.Size(1204, 948);
            this.tabPage_OrderItems.TabIndex = 2;
            this.tabPage_OrderItems.Text = "Order Items";
            // 
            // label_Payment
            // 
            this.label_Payment.BackColor = System.Drawing.Color.White;
            this.label_Payment.Location = new System.Drawing.Point(590, 847);
            this.label_Payment.Name = "label_Payment";
            this.label_Payment.Size = new System.Drawing.Size(437, 60);
            this.label_Payment.TabIndex = 35;
            // 
            // listBox_InOrderProductsCount
            // 
            this.listBox_InOrderProductsCount.FormattingEnabled = true;
            this.listBox_InOrderProductsCount.ItemHeight = 25;
            this.listBox_InOrderProductsCount.Location = new System.Drawing.Point(1033, 52);
            this.listBox_InOrderProductsCount.Name = "listBox_InOrderProductsCount";
            this.listBox_InOrderProductsCount.Size = new System.Drawing.Size(126, 779);
            this.listBox_InOrderProductsCount.TabIndex = 34;
            this.listBox_InOrderProductsCount.Click += new System.EventHandler(this.listBox_InOrderProductsCount_Click);
            // 
            // button_Minus
            // 
            this.button_Minus.BackColor = System.Drawing.Color.White;
            this.button_Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_Minus.Location = new System.Drawing.Point(1033, 847);
            this.button_Minus.Name = "button_Minus";
            this.button_Minus.Size = new System.Drawing.Size(60, 60);
            this.button_Minus.TabIndex = 33;
            this.button_Minus.Text = "-";
            this.button_Minus.UseVisualStyleBackColor = false;
            this.button_Minus.Click += new System.EventHandler(this.button_Minus_Click);
            // 
            // button_Plus
            // 
            this.button_Plus.BackColor = System.Drawing.Color.White;
            this.button_Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Plus.Location = new System.Drawing.Point(1099, 847);
            this.button_Plus.Name = "button_Plus";
            this.button_Plus.Size = new System.Drawing.Size(60, 60);
            this.button_Plus.TabIndex = 33;
            this.button_Plus.Text = "+";
            this.button_Plus.UseVisualStyleBackColor = false;
            this.button_Plus.Click += new System.EventHandler(this.button_Plus_Click);
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.comboBox_ArtistFilterProduct);
            this.groupBox1.Controls.Add(this.comboBox_CategoryFilterProduct);
            this.groupBox1.Controls.Add(this.label_CategoryFilter);
            this.groupBox1.Controls.Add(this.label_NameFilter);
            this.groupBox1.Controls.Add(this.label_ArtistFilter);
            this.groupBox1.Controls.Add(this.textBox_NameFilterProduct);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button_ClearFilterProduct);
            this.groupBox1.Controls.Add(this.textBox_IdFilterProduct);
            this.groupBox1.Location = new System.Drawing.Point(44, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 336);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // comboBox_ArtistFilterProduct
            // 
            this.comboBox_ArtistFilterProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ArtistFilterProduct.FormattingEnabled = true;
            this.comboBox_ArtistFilterProduct.Location = new System.Drawing.Point(267, 207);
            this.comboBox_ArtistFilterProduct.Name = "comboBox_ArtistFilterProduct";
            this.comboBox_ArtistFilterProduct.Size = new System.Drawing.Size(214, 33);
            this.comboBox_ArtistFilterProduct.TabIndex = 28;
            this.comboBox_ArtistFilterProduct.TextChanged += new System.EventHandler(this.comboBoxFilterProduct_TextChanged);
            // 
            // comboBox_CategoryFilterProduct
            // 
            this.comboBox_CategoryFilterProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CategoryFilterProduct.FormattingEnabled = true;
            this.comboBox_CategoryFilterProduct.Location = new System.Drawing.Point(267, 94);
            this.comboBox_CategoryFilterProduct.Name = "comboBox_CategoryFilterProduct";
            this.comboBox_CategoryFilterProduct.Size = new System.Drawing.Size(214, 33);
            this.comboBox_CategoryFilterProduct.TabIndex = 27;
            this.comboBox_CategoryFilterProduct.TextChanged += new System.EventHandler(this.comboBoxFilterProduct_TextChanged);
            // 
            // label_CategoryFilter
            // 
            this.label_CategoryFilter.AutoSize = true;
            this.label_CategoryFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_CategoryFilter.Location = new System.Drawing.Point(14, 88);
            this.label_CategoryFilter.Name = "label_CategoryFilter";
            this.label_CategoryFilter.Size = new System.Drawing.Size(146, 37);
            this.label_CategoryFilter.TabIndex = 23;
            this.label_CategoryFilter.Text = "Category";
            // 
            // label_NameFilter
            // 
            this.label_NameFilter.AutoSize = true;
            this.label_NameFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_NameFilter.Location = new System.Drawing.Point(14, 146);
            this.label_NameFilter.Name = "label_NameFilter";
            this.label_NameFilter.Size = new System.Drawing.Size(103, 37);
            this.label_NameFilter.TabIndex = 24;
            this.label_NameFilter.Text = "Name";
            // 
            // label_ArtistFilter
            // 
            this.label_ArtistFilter.AutoSize = true;
            this.label_ArtistFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_ArtistFilter.Location = new System.Drawing.Point(14, 201);
            this.label_ArtistFilter.Name = "label_ArtistFilter";
            this.label_ArtistFilter.Size = new System.Drawing.Size(91, 37);
            this.label_ArtistFilter.TabIndex = 25;
            this.label_ArtistFilter.Text = "Artist";
            // 
            // textBox_NameFilterProduct
            // 
            this.textBox_NameFilterProduct.Location = new System.Drawing.Point(267, 152);
            this.textBox_NameFilterProduct.Name = "textBox_NameFilterProduct";
            this.textBox_NameFilterProduct.Size = new System.Drawing.Size(214, 31);
            this.textBox_NameFilterProduct.TabIndex = 26;
            this.textBox_NameFilterProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Heb_KeyPress);
            this.textBox_NameFilterProduct.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_FilterProduct_KeyUp);
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
            // button_ClearFilterProduct
            // 
            this.button_ClearFilterProduct.Location = new System.Drawing.Point(387, 265);
            this.button_ClearFilterProduct.Name = "button_ClearFilterProduct";
            this.button_ClearFilterProduct.Size = new System.Drawing.Size(94, 47);
            this.button_ClearFilterProduct.TabIndex = 5;
            this.button_ClearFilterProduct.Text = "clear";
            this.button_ClearFilterProduct.UseVisualStyleBackColor = true;
            this.button_ClearFilterProduct.Click += new System.EventHandler(this.button_ClearFilterProduct_Click);
            // 
            // textBox_IdFilterProduct
            // 
            this.textBox_IdFilterProduct.Location = new System.Drawing.Point(267, 40);
            this.textBox_IdFilterProduct.Name = "textBox_IdFilterProduct";
            this.textBox_IdFilterProduct.Size = new System.Drawing.Size(214, 31);
            this.textBox_IdFilterProduct.TabIndex = 1;
            this.textBox_IdFilterProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            this.textBox_IdFilterProduct.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_FilterProduct_KeyUp);
            // 
            // listBox_InOrderProducts
            // 
            this.listBox_InOrderProducts.FormattingEnabled = true;
            this.listBox_InOrderProducts.ItemHeight = 25;
            this.listBox_InOrderProducts.Location = new System.Drawing.Point(590, 52);
            this.listBox_InOrderProducts.Name = "listBox_InOrderProducts";
            this.listBox_InOrderProducts.Size = new System.Drawing.Size(437, 779);
            this.listBox_InOrderProducts.TabIndex = 27;
            this.listBox_InOrderProducts.Click += new System.EventHandler(this.listBox_InOrderProducts_Click);
            // 
            // label_DateToday
            // 
            this.label_DateToday.AutoSize = true;
            this.label_DateToday.Cursor = System.Windows.Forms.Cursors.Default;
            this.label_DateToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DateToday.Location = new System.Drawing.Point(414, 58);
            this.label_DateToday.Name = "label_DateToday";
            this.label_DateToday.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
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
            this.label_StoreName.Size = new System.Drawing.Size(297, 79);
            this.label_StoreName.TabIndex = 28;
            this.label_StoreName.Text = "Orders";
            // 
            // button_Save
            // 
            this.button_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Save.Location = new System.Drawing.Point(930, 1119);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(94, 47);
            this.button_Save.TabIndex = 12;
            this.button_Save.Text = "save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.save_Click);
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
            // button_OrderReport
            // 
            this.button_OrderReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OrderReport.Location = new System.Drawing.Point(1132, 37);
            this.button_OrderReport.Name = "button_OrderReport";
            this.button_OrderReport.Size = new System.Drawing.Size(92, 78);
            this.button_OrderReport.TabIndex = 34;
            this.button_OrderReport.Text = "report";
            this.button_OrderReport.UseVisualStyleBackColor = true;
            this.button_OrderReport.Click += new System.EventHandler(this.button_OrderReport_Click);
            // 
            // Form_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1244, 1189);
            this.Controls.Add(this.button_OrderReport);
            this.Controls.Add(this.label_DateToday);
            this.Controls.Add(this.label_StoreName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl_Order);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Clear);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Order";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.Text = "Orders";
            this.tabControl_Order.ResumeLayout(false);
            this.tabPage_OrderDetails.ResumeLayout(false);
            this.groupBox_Filter.ResumeLayout(false);
            this.groupBox_Filter.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage_OrderClient.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage_OrderItems.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_ClearFilterProduct;
        private System.Windows.Forms.TextBox textBox_IdFilterProduct;
        private System.Windows.Forms.ListBox listBox_InOrderProducts;
        private System.Windows.Forms.ComboBox comboBox_ArtistFilterProduct;
        private System.Windows.Forms.ComboBox comboBox_CategoryFilterProduct;
        private System.Windows.Forms.Label label_CategoryFilter;
        private System.Windows.Forms.Label label_NameFilter;
        private System.Windows.Forms.Label label_ArtistFilter;
        private System.Windows.Forms.TextBox textBox_NameFilterProduct;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_PhoneNumberFilterClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_FirstNameFilterClient;
        private System.Windows.Forms.Label label_FirstNameFilter;
        private System.Windows.Forms.Label label_LastNameFilter;
        private System.Windows.Forms.Label label_PhoneNumerFilter;
        private System.Windows.Forms.TextBox textBox_LastNameFilterClient;
        private System.Windows.Forms.Button button_ClearFilterClient;
        private System.Windows.Forms.TextBox textBox_IdFilterClient;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_FirstNameClient;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_LastNameClient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_CityClient;
        private System.Windows.Forms.Label label_PhoneNumberClient;
        private System.Windows.Forms.Label label_IdClient;
        private System.Windows.Forms.ListBox listBox_Clients;
        private System.Windows.Forms.Button button_Minus;
        private System.Windows.Forms.Button button_Plus;
        private System.Windows.Forms.ListBox listBox_InOrderProductsCount;
        private System.Windows.Forms.Label label_Payment;
        private System.Windows.Forms.Button button_OrderReport;
    }
}