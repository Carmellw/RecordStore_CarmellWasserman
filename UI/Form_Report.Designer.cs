
namespace RecordStore_CarmellWasserman.UI
{
    partial class Form_Report
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
            this.label_Stock = new System.Windows.Forms.Label();
            this.label_Clients = new System.Windows.Forms.Label();
            this.label_StoreName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_Order = new System.Windows.Forms.Label();
            this.label_Employees = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Stock
            // 
            this.label_Stock.BackColor = System.Drawing.Color.White;
            this.label_Stock.Font = new System.Drawing.Font("Aharoni", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Stock.Location = new System.Drawing.Point(385, 171);
            this.label_Stock.Name = "label_Stock";
            this.label_Stock.Size = new System.Drawing.Size(280, 170);
            this.label_Stock.TabIndex = 51;
            this.label_Stock.Text = "Stock";
            this.label_Stock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Stock.Click += new System.EventHandler(this.label_Stock_Click);
            // 
            // label_Clients
            // 
            this.label_Clients.BackColor = System.Drawing.Color.White;
            this.label_Clients.Font = new System.Drawing.Font("Aharoni", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Clients.Location = new System.Drawing.Point(85, 360);
            this.label_Clients.Name = "label_Clients";
            this.label_Clients.Size = new System.Drawing.Size(280, 170);
            this.label_Clients.TabIndex = 49;
            this.label_Clients.Text = "Clients";
            this.label_Clients.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Clients.Click += new System.EventHandler(this.label_Clients_Click);
            // 
            // label_StoreName
            // 
            this.label_StoreName.AutoSize = true;
            this.label_StoreName.Font = new System.Drawing.Font("Aharoni", 30F, System.Drawing.FontStyle.Bold);
            this.label_StoreName.Location = new System.Drawing.Point(246, 60);
            this.label_StoreName.Name = "label_StoreName";
            this.label_StoreName.Size = new System.Drawing.Size(370, 79);
            this.label_StoreName.TabIndex = 46;
            this.label_StoreName.Text = "REPORTS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RecordStore_CarmellWasserman.Properties.Resources.recordplayer;
            this.pictureBox1.Location = new System.Drawing.Point(121, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // label_Order
            // 
            this.label_Order.BackColor = System.Drawing.Color.White;
            this.label_Order.Font = new System.Drawing.Font("Aharoni", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Order.Location = new System.Drawing.Point(85, 170);
            this.label_Order.Name = "label_Order";
            this.label_Order.Size = new System.Drawing.Size(280, 170);
            this.label_Order.TabIndex = 44;
            this.label_Order.Text = "Orders";
            this.label_Order.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Order.Click += new System.EventHandler(this.label_Order_Click);
            // 
            // label_Employees
            // 
            this.label_Employees.BackColor = System.Drawing.Color.White;
            this.label_Employees.Font = new System.Drawing.Font("Aharoni", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Employees.Location = new System.Drawing.Point(385, 360);
            this.label_Employees.Name = "label_Employees";
            this.label_Employees.Size = new System.Drawing.Size(280, 170);
            this.label_Employees.TabIndex = 52;
            this.label_Employees.Text = "Employees";
            this.label_Employees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Employees.Click += new System.EventHandler(this.label_Employees_Click);
            // 
            // Form_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(779, 619);
            this.Controls.Add(this.label_Employees);
            this.Controls.Add(this.label_Stock);
            this.Controls.Add(this.label_Clients);
            this.Controls.Add(this.label_StoreName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_Order);
            this.Name = "Form_Report";
            this.Text = "Form_Report";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_Stock;
        private System.Windows.Forms.Label label_Clients;
        private System.Windows.Forms.Label label_StoreName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Order;
        private System.Windows.Forms.Label label_Employees;
    }
}