namespace StudentHouseProject.User
{
    partial class ListItems
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            lbTitle = new Label();
            lbPrice = new Label();
            lbTime = new Label();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            AddtoCart = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(21, 13);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 107);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbTitle
            // 
            lbTitle.Location = new Point(178, 13);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(390, 29);
            lbTitle.TabIndex = 1;
            lbTitle.Text = "Title";
            // 
            // lbPrice
            // 
            lbPrice.Location = new Point(178, 51);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(390, 22);
            lbPrice.TabIndex = 2;
            lbPrice.Text = "Price";
            // 
            // lbTime
            // 
            lbTime.Location = new Point(178, 87);
            lbTime.Name = "lbTime";
            lbTime.Size = new Size(391, 22);
            lbTime.TabIndex = 3;
            lbTime.Text = "Time";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(161, 135);
            panel1.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.GradientActiveCaption;
            flowLayoutPanel1.Location = new Point(-1, 133);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(669, 14);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // AddtoCart
            // 
            AddtoCart.Location = new Point(514, 45);
            AddtoCart.Name = "AddtoCart";
            AddtoCart.Size = new Size(133, 39);
            AddtoCart.TabIndex = 6;
            AddtoCart.Text = "AddToCart";
            AddtoCart.UseVisualStyleBackColor = true;
            AddtoCart.Click += AddtoCart_Click;
            // 
            // ListItems
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AddtoCart);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(lbTime);
            Controls.Add(lbPrice);
            Controls.Add(lbTitle);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ListItems";
            Size = new Size(667, 147);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbTitle;
        private Label lbPrice;
        private Label lbTime;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button AddtoCart;
    }
}
