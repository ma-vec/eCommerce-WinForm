namespace eCommerce
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            carrello = new PictureBox();
            listBoxCarrello = new ListBox();
            pictureBox1 = new PictureBox();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            buttonAdd = new Button();
            buttonRemove = new Button();
            button1 = new Button();
            buttonAddMS = new Button();
            label3 = new Label();
            label4 = new Label();
            numericUpDownMS = new NumericUpDown();
            pictureBox2 = new PictureBox();
            buttonAddMX = new Button();
            label5 = new Label();
            label6 = new Label();
            numericUpDownMX = new NumericUpDown();
            pictureBox3 = new PictureBox();
            buttonAddRoad = new Button();
            label7 = new Label();
            label8 = new Label();
            numericUpDownRoad = new NumericUpDown();
            pictureBox4 = new PictureBox();
            label9 = new Label();
            labelPrice = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)carrello).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRoad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // carrello
            // 
            carrello.Image = (Image)resources.GetObject("carrello.Image");
            carrello.Location = new Point(919, 6);
            carrello.Name = "carrello";
            carrello.Size = new Size(55, 55);
            carrello.SizeMode = PictureBoxSizeMode.StretchImage;
            carrello.TabIndex = 0;
            carrello.TabStop = false;
            // 
            // listBoxCarrello
            // 
            listBoxCarrello.FormattingEnabled = true;
            listBoxCarrello.ItemHeight = 15;
            listBoxCarrello.Location = new Point(884, 80);
            listBoxCarrello.Name = "listBoxCarrello";
            listBoxCarrello.Size = new Size(90, 364);
            listBoxCarrello.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(26, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(310, 143);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(121, 263);
            numericUpDown1.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(51, 23);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 261);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 4;
            label1.Text = "Quantità";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 35);
            label2.Name = "label2";
            label2.Size = new Size(194, 37);
            label2.TabIndex = 5;
            label2.Text = "Tesla Model 3";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(191, 261);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(134, 28);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Aggiungi";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(884, 506);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(90, 28);
            buttonRemove.TabIndex = 7;
            buttonRemove.Text = "Rimuovi";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // button1
            // 
            button1.Location = new Point(884, 540);
            button1.Name = "button1";
            button1.Size = new Size(90, 28);
            button1.TabIndex = 8;
            button1.Text = "Svuota";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonAddMS
            // 
            buttonAddMS.Location = new Point(596, 261);
            buttonAddMS.Name = "buttonAddMS";
            buttonAddMS.Size = new Size(134, 28);
            buttonAddMS.TabIndex = 13;
            buttonAddMS.Text = "Aggiungi";
            buttonAddMS.UseVisualStyleBackColor = true;
            buttonAddMS.Click += buttonAddMS_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(431, 35);
            label3.Name = "label3";
            label3.Size = new Size(193, 37);
            label3.TabIndex = 12;
            label3.Text = "Tesla Model S";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(431, 261);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 11;
            label4.Text = "Quantità";
            // 
            // numericUpDownMS
            // 
            numericUpDownMS.Location = new Point(526, 263);
            numericUpDownMS.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDownMS.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownMS.Name = "numericUpDownMS";
            numericUpDownMS.Size = new Size(51, 23);
            numericUpDownMS.TabIndex = 10;
            numericUpDownMS.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(431, 86);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(338, 143);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // buttonAddMX
            // 
            buttonAddMX.Location = new Point(191, 542);
            buttonAddMX.Name = "buttonAddMX";
            buttonAddMX.Size = new Size(134, 28);
            buttonAddMX.TabIndex = 18;
            buttonAddMX.Text = "Aggiungi";
            buttonAddMX.UseVisualStyleBackColor = true;
            buttonAddMX.Click += buttonAddMX_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(26, 316);
            label5.Name = "label5";
            label5.Size = new Size(196, 37);
            label5.TabIndex = 17;
            label5.Text = "Tesla Model X";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(26, 542);
            label6.Name = "label6";
            label6.Size = new Size(89, 25);
            label6.TabIndex = 16;
            label6.Text = "Quantità";
            // 
            // numericUpDownMX
            // 
            numericUpDownMX.Location = new Point(121, 544);
            numericUpDownMX.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDownMX.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownMX.Name = "numericUpDownMX";
            numericUpDownMX.Size = new Size(51, 23);
            numericUpDownMX.TabIndex = 15;
            numericUpDownMX.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-143, 307);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(641, 285);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // buttonAddRoad
            // 
            buttonAddRoad.Location = new Point(596, 542);
            buttonAddRoad.Name = "buttonAddRoad";
            buttonAddRoad.Size = new Size(134, 28);
            buttonAddRoad.TabIndex = 23;
            buttonAddRoad.Text = "Aggiungi";
            buttonAddRoad.UseVisualStyleBackColor = true;
            buttonAddRoad.Click += buttonAddRoad_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(431, 316);
            label7.Name = "label7";
            label7.Size = new Size(203, 37);
            label7.TabIndex = 22;
            label7.Text = "Tesla Roadster";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(431, 542);
            label8.Name = "label8";
            label8.Size = new Size(89, 25);
            label8.TabIndex = 21;
            label8.Text = "Quantità";
            // 
            // numericUpDownRoad
            // 
            numericUpDownRoad.Location = new Point(526, 544);
            numericUpDownRoad.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDownRoad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownRoad.Name = "numericUpDownRoad";
            numericUpDownRoad.Size = new Size(51, 23);
            numericUpDownRoad.TabIndex = 20;
            numericUpDownRoad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(431, 356);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(328, 178);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 19;
            pictureBox4.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(884, 450);
            label9.Name = "label9";
            label9.Size = new Size(52, 20);
            label9.TabIndex = 24;
            label9.Text = "Totale";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPrice.Location = new Point(907, 476);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(18, 20);
            labelPrice.TabIndex = 25;
            labelPrice.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(887, 476);
            label10.Name = "label10";
            label10.Size = new Size(18, 20);
            label10.TabIndex = 26;
            label10.Text = "€";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 589);
            Controls.Add(label10);
            Controls.Add(labelPrice);
            Controls.Add(label9);
            Controls.Add(buttonAddRoad);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(numericUpDownRoad);
            Controls.Add(pictureBox4);
            Controls.Add(buttonAddMX);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(numericUpDownMX);
            Controls.Add(pictureBox3);
            Controls.Add(buttonAddMS);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(numericUpDownMS);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(buttonRemove);
            Controls.Add(buttonAdd);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(pictureBox1);
            Controls.Add(listBoxCarrello);
            Controls.Add(carrello);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)carrello).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMS).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMX).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRoad).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox carrello;
        private ListBox listBoxCarrello;
        private PictureBox pictureBox1;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private Label label2;
        private Button buttonAdd;
        private Button buttonRemove;
        private Button button1;
        private Button buttonAddMS;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDownMS;
        private PictureBox pictureBox2;
        private Button buttonAddMX;
        private Label label5;
        private Label label6;
        private NumericUpDown numericUpDownMX;
        private PictureBox pictureBox3;
        private Button buttonAddRoad;
        private Label label7;
        private Label label8;
        private NumericUpDown numericUpDownRoad;
        private PictureBox pictureBox4;
        private Label label9;
        private Label labelPrice;
        private Label label10;
    }
}
