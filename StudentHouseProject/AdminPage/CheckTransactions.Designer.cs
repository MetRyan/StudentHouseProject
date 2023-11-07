﻿namespace StudentHouseProject.AdminPage
{
    partial class CheckTransactions
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
            dgvOrderDetails = new DataGridView();
            dgvCustomer = new DataGridView();
            btnLoad = new Button();
            dgvOrder = new DataGridView();
            lbCheckOrder = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            // 
            // dgvOrderDetails
            // 
            dgvOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dgvOrderDetails.Location = new Point(456, 431);
            dgvOrderDetails.Margin = new Padding(3, 2, 3, 2);

            dgvOrderDetails.Location = new Point(431, 687);

            dgvOrderDetails.Name = "dgvOrderDetails";
            dgvOrderDetails.RowHeadersWidth = 51;
            dgvOrderDetails.RowTemplate.Height = 29;
            dgvOrderDetails.Size = new Size(840, 160);
            dgvOrderDetails.TabIndex = 9;
            // 
            // dgvCustomer
            // 
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dgvCustomer.Location = new Point(456, 324);
            dgvCustomer.Margin = new Padding(3, 2, 3, 2);

            dgvCustomer.Location = new Point(431, 484);

            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.RowTemplate.Height = 29;
            dgvCustomer.Size = new Size(840, 51);
            dgvCustomer.TabIndex = 8;
            // 
            // btnLoad
            // 

            btnLoad.Location = new Point(1302, 89);
            btnLoad.Margin = new Padding(3, 2, 3, 2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(83, 35);
            btnLoad.TabIndex = 7;
            btnLoad.Text = "Load Orders";
            btnLoad.UseVisualStyleBackColor = true;

            btnLoad.BackColor = SystemColors.ActiveCaption;
            btnLoad.Location = new Point(174, 115);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(160, 70);
            btnLoad.TabIndex = 7;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;

            btnLoad.Click += btnLoad_Click;
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dgvOrder.Location = new Point(456, 79);
            dgvOrder.Margin = new Padding(3, 2, 3, 2);

            dgvOrder.Location = new Point(431, 115);

            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.RowTemplate.Height = 29;
            dgvOrder.Size = new Size(840, 194);
            dgvOrder.TabIndex = 6;
            dgvOrder.CellClick += dgvOrder_CellClick;
            dgvOrder.CellContentClick += dgvOrder_CellContentClick_2;
            // 
            // lbCheckOrder
            // 
            lbCheckOrder.AutoSize = true;
            lbCheckOrder.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);

            lbCheckOrder.Location = new Point(789, 33);

            lbCheckOrder.Location = new Point(798, 36);

            lbCheckOrder.Name = "lbCheckOrder";
            lbCheckOrder.Size = new Size(142, 30);
            lbCheckOrder.TabIndex = 5;
            lbCheckOrder.Text = "Check Order";
            // 
            // label1
            // 
            label1.AutoSize = true;

            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(456, 285);
            label1.Name = "label1";
            label1.Size = new Size(242, 30);

            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(122, 484);
            label1.Name = "label1";
            label1.Size = new Size(277, 35);

            label1.TabIndex = 10;
            label1.Text = "Customer Information";
            // 
            // label2
            // 
            label2.AutoSize = true;

            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(456, 389);
            label2.Name = "label2";
            label2.Size = new Size(241, 32);

            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(137, 687);
            label2.Name = "label2";
            label2.Size = new Size(249, 35);

            label2.TabIndex = 11;
            label2.Text = "Service Information";
            // 
            // CheckTransactions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;

            ClientSize = new Size(1431, 651);

            ClientSize = new Size(1718, 961);

            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvOrderDetails);
            Controls.Add(dgvCustomer);
            Controls.Add(btnLoad);
            Controls.Add(dgvOrder);
            Controls.Add(lbCheckOrder);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CheckTransactions";
            Text = "Check Order";
            Load += CheckTransactions_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrderDetails;
        private DataGridView dgvCustomer;
        private Button btnLoad;
        private DataGridView dgvOrder;
        private Label lbCheckOrder;
        private Label label1;
        private Label label2;
    }
}