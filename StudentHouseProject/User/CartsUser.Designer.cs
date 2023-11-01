namespace StudentHouseProject.User
{
    partial class CartsUser
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
            Remove = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lbPrice = new Label();
            lbTitle = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(24, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 97);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Remove
            // 
            Remove.Location = new Point(668, 31);
            Remove.Margin = new Padding(3, 4, 3, 4);
            Remove.Name = "Remove";
            Remove.Size = new Size(127, 52);
            Remove.TabIndex = 12;
            Remove.Text = "Remove";
            Remove.UseVisualStyleBackColor = true;
            Remove.Click += Remove_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.GradientActiveCaption;
            flowLayoutPanel1.Location = new Point(-1, 119);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(821, 13);
            flowLayoutPanel1.TabIndex = 11;
            // 
            // lbPrice
            // 
            lbPrice.Location = new Point(203, 54);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(446, 29);
            lbPrice.TabIndex = 8;
            lbPrice.Text = "Price";
            // 
            // lbTitle
            // 
            lbTitle.Location = new Point(203, 15);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(446, 39);
            lbTitle.TabIndex = 7;
            lbTitle.Text = "Title";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(163, 134);
            panel1.TabIndex = 10;
            // 
            // CartsUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Remove);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(lbPrice);
            Controls.Add(lbTitle);
            Controls.Add(panel1);
            Name = "CartsUser";
            Size = new Size(828, 133);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button Remove;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lbPrice;
        private Label lbTitle;
        private Panel panel1;
    }
}
