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
            ((System.ComponentModel.ISupportInitialize)carrello).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // carrello
            // 
            carrello.Image = (Image)resources.GetObject("carrello.Image");
            carrello.Location = new Point(733, 12);
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
            listBoxCarrello.Location = new Point(698, 86);
            listBoxCarrello.Name = "listBoxCarrello";
            listBoxCarrello.Size = new Size(90, 319);
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
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(51, 23);
            numericUpDown1.TabIndex = 3;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
