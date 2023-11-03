namespace StudentHouseProject.User
{
    partial class AdminCheckOrder
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
            lbOrderList = new Label();
            dataGridView1 = new DataGridView();
            btnLoad = new Button();
            btnUpdate = new Button();
            btnReturn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbOrderList
            // 
            lbOrderList.AutoSize = true;
            lbOrderList.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbOrderList.Location = new Point(305, 47);
            lbOrderList.Name = "lbOrderList";
            lbOrderList.Size = new Size(157, 41);
            lbOrderList.TabIndex = 0;
            lbOrderList.Text = "Order List";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(106, 107);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(558, 263);
            dataGridView1.TabIndex = 1;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(204, 393);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(341, 393);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(474, 393);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(94, 29);
            btnReturn.TabIndex = 4;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            // 
            // AdminCheckOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReturn);
            Controls.Add(btnUpdate);
            Controls.Add(btnLoad);
            Controls.Add(dataGridView1);
            Controls.Add(lbOrderList);
            Name = "AdminCheckOrder";
            Text = "AdminCheckOrder";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbOrderList;
        private DataGridView dataGridView1;
        private Button btnLoad;
        private Button btnUpdate;
        private Button btnReturn;
    }
}