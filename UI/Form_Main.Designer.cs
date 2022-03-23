
namespace RecordStore_CarmellWasserman.UI
{
    partial class Form_Main
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
            this.label_Order = new System.Windows.Forms.Label();
            this.label_StoreName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_Clients = new System.Windows.Forms.Label();
            this.label_Stock = new System.Windows.Forms.Label();
            this.label_Shifts = new System.Windows.Forms.Label();
            this.label_Manager = new System.Windows.Forms.Label();
            this.label_Statistics = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Order
            // 
            this.label_Order.BackColor = System.Drawing.Color.White;
            this.label_Order.Font = new System.Drawing.Font("Aharoni", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Order.Location = new System.Drawing.Point(137, 237);
            this.label_Order.Name = "label_Order";
            this.label_Order.Size = new System.Drawing.Size(250, 170);
            this.label_Order.TabIndex = 0;
            this.label_Order.Text = "Orders";
            this.label_Order.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Order.Click += new System.EventHandler(this.label_Order_Click);
            // 
            // label_StoreName
            // 
            this.label_StoreName.AutoSize = true;
            this.label_StoreName.Font = new System.Drawing.Font("Aharoni", 30F, System.Drawing.FontStyle.Bold);
            this.label_StoreName.Location = new System.Drawing.Point(417, 103);
            this.label_StoreName.Name = "label_StoreName";
            this.label_StoreName.Size = new System.Drawing.Size(556, 79);
            this.label_StoreName.TabIndex = 39;
            this.label_StoreName.Text = "RECORDLAND";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RecordStore_CarmellWasserman.Properties.Resources.recordplayer;
            this.pictureBox1.Location = new System.Drawing.Point(292, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RecordStore_CarmellWasserman.Properties.Resources.recordplayerGIF;
            this.pictureBox2.Location = new System.Drawing.Point(492, 340);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(296, 326);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // label_Clients
            // 
            this.label_Clients.BackColor = System.Drawing.Color.White;
            this.label_Clients.Font = new System.Drawing.Font("Aharoni", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Clients.Location = new System.Drawing.Point(137, 432);
            this.label_Clients.Name = "label_Clients";
            this.label_Clients.Size = new System.Drawing.Size(250, 170);
            this.label_Clients.TabIndex = 41;
            this.label_Clients.Text = "Clients";
            this.label_Clients.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Clients.Click += new System.EventHandler(this.label_Clients_Click);
            // 
            // label_Stock
            // 
            this.label_Stock.BackColor = System.Drawing.Color.White;
            this.label_Stock.Font = new System.Drawing.Font("Aharoni", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Stock.Location = new System.Drawing.Point(137, 624);
            this.label_Stock.Name = "label_Stock";
            this.label_Stock.Size = new System.Drawing.Size(250, 170);
            this.label_Stock.TabIndex = 42;
            this.label_Stock.Text = "Stock";
            this.label_Stock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Shifts
            // 
            this.label_Shifts.BackColor = System.Drawing.Color.White;
            this.label_Shifts.Font = new System.Drawing.Font("Aharoni", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Shifts.Location = new System.Drawing.Point(915, 237);
            this.label_Shifts.Name = "label_Shifts";
            this.label_Shifts.Size = new System.Drawing.Size(250, 170);
            this.label_Shifts.TabIndex = 0;
            this.label_Shifts.Text = "Shifts";
            this.label_Shifts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Shifts.Click += new System.EventHandler(this.label_Order_Click);
            // 
            // label_Manager
            // 
            this.label_Manager.BackColor = System.Drawing.Color.White;
            this.label_Manager.Font = new System.Drawing.Font("Aharoni", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Manager.Location = new System.Drawing.Point(915, 432);
            this.label_Manager.Name = "label_Manager";
            this.label_Manager.Size = new System.Drawing.Size(250, 170);
            this.label_Manager.TabIndex = 41;
            this.label_Manager.Text = "Manager";
            this.label_Manager.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Manager.Click += new System.EventHandler(this.label_Clients_Click);
            // 
            // label_Statistics
            // 
            this.label_Statistics.BackColor = System.Drawing.Color.White;
            this.label_Statistics.Font = new System.Drawing.Font("Aharoni", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Statistics.Location = new System.Drawing.Point(915, 624);
            this.label_Statistics.Name = "label_Statistics";
            this.label_Statistics.Size = new System.Drawing.Size(250, 170);
            this.label_Statistics.TabIndex = 42;
            this.label_Statistics.Text = "Statistics";
            this.label_Statistics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1325, 888);
            this.Controls.Add(this.label_Statistics);
            this.Controls.Add(this.label_Stock);
            this.Controls.Add(this.label_Manager);
            this.Controls.Add(this.label_Clients);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label_StoreName);
            this.Controls.Add(this.label_Shifts);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_Order);
            this.Name = "Form_Main";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 60);
            this.Text = "Form_Main";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Order;
        private System.Windows.Forms.Label label_StoreName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_Clients;
        private System.Windows.Forms.Label label_Stock;
        private System.Windows.Forms.Label label_Shifts;
        private System.Windows.Forms.Label label_Manager;
        private System.Windows.Forms.Label label_Statistics;
    }
}