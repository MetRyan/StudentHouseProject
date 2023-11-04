namespace StudentHouseProject.User
{
    partial class Carts
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
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button2 = new Button();
            lbAddress = new Label();
            txtAdress = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cbPayment = new ComboBox();
            txtPhone = new TextBox();
            Total = new Label();
            txtTotal = new TextBox();
            label4 = new Label();
            txtNote = new TextBox();
            btnLoad = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(327, 28);
            label1.Name = "label1";
            label1.Size = new Size(167, 31);
            label1.TabIndex = 21;
            label1.Text = "Service Details";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Location = new Point(25, 87);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(815, 385);
            flowLayoutPanel1.TabIndex = 23;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(288, 711);
            button2.Name = "button2";
            button2.Size = new Size(149, 43);
            button2.TabIndex = 24;
            button2.Text = "ConfirmOrder";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Location = new Point(40, 528);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(53, 20);
            lbAddress.TabIndex = 25;
            lbAddress.Text = "Adress";
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(151, 523);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(215, 27);
            txtAdress.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(401, 528);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 27;
            label2.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(401, 581);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 28;
            label3.Text = "PaymentMethod";
            // 
            // cbPayment
            // 
            cbPayment.FormattingEnabled = true;
            cbPayment.Items.AddRange(new object[] { "Cash", "Working on ...." });
            cbPayment.Location = new Point(519, 576);
            cbPayment.Name = "cbPayment";
            cbPayment.Size = new Size(176, 28);
            cbPayment.TabIndex = 29;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(466, 524);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(229, 27);
            txtPhone.TabIndex = 30;
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.Location = new Point(40, 584);
            Total.Name = "Total";
            Total.Size = new Size(42, 20);
            Total.TabIndex = 31;
            Total.Text = "Total";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(151, 580);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(215, 27);
            txtTotal.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 636);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 33;
            label4.Text = "Note";
            // 
            // txtNote
            // 
            txtNote.Location = new Point(146, 627);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(549, 57);
            txtNote.TabIndex = 34;
            txtNote.TextChanged += textBox1_TextChanged;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(535, 712);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(135, 43);
            btnLoad.TabIndex = 35;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // Carts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 792);
            Controls.Add(btnLoad);
            Controls.Add(txtNote);
            Controls.Add(label4);
            Controls.Add(txtTotal);
            Controls.Add(Total);
            Controls.Add(txtPhone);
            Controls.Add(cbPayment);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtAdress);
            Controls.Add(lbAddress);
            Controls.Add(button2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Name = "Carts";
            Text = "Carts";
            Load += Carts_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button2;
        private Label lbAddress;
        private TextBox txtAdress;
        private Label label2;
        private Label label3;
        private ComboBox cbPayment;
        private TextBox txtPhone;
        private Label Total;
        private TextBox txtTotal;
        private Label label4;
        private TextBox txtNote;
        private Button btnLoad;
    }
}