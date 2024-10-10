namespace WeversMarket_GUI_P1
{
    partial class FrmStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStart));
            pictureBox1 = new PictureBox();
            BtStart = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(134, -52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(750, 750);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BtStart
            // 
            BtStart.BackColor = Color.Cornsilk;
            BtStart.BackgroundImageLayout = ImageLayout.Center;
            BtStart.Cursor = Cursors.Hand;
            BtStart.FlatStyle = FlatStyle.Flat;
            BtStart.ForeColor = Color.Cornsilk;
            BtStart.Image = (Image)resources.GetObject("BtStart.Image");
            BtStart.Location = new Point(910, 537);
            BtStart.Name = "BtStart";
            BtStart.Size = new Size(115, 107);
            BtStart.TabIndex = 1;
            BtStart.UseVisualStyleBackColor = false;
            BtStart.Click += BtStart_Click;
            // 
            // FrmStart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(1045, 656);
            Controls.Add(BtStart);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmStart";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button BtStart;
    }
}
