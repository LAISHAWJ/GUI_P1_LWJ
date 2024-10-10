namespace WeversMarket_GUI_P1
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            MenuPrincipal = new MenuStrip();
            BtProducto = new FontAwesome.Sharp.IconMenuItem();
            BtCategoria = new FontAwesome.Sharp.IconMenuItem();
            BtSuplidor = new FontAwesome.Sharp.IconMenuItem();
            pictureBox1 = new PictureBox();
            MenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MenuPrincipal
            // 
            MenuPrincipal.BackColor = Color.Wheat;
            MenuPrincipal.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenuPrincipal.ImageScalingSize = new Size(20, 20);
            MenuPrincipal.Items.AddRange(new ToolStripItem[] { BtProducto, BtCategoria, BtSuplidor });
            MenuPrincipal.Location = new Point(0, 0);
            MenuPrincipal.Name = "MenuPrincipal";
            MenuPrincipal.Size = new Size(994, 84);
            MenuPrincipal.TabIndex = 0;
            MenuPrincipal.Text = "menuStrip1";
            // 
            // BtProducto
            // 
            BtProducto.AutoSize = false;
            BtProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtProducto.ForeColor = Color.SeaGreen;
            BtProducto.IconChar = FontAwesome.Sharp.IconChar.Box;
            BtProducto.IconColor = Color.SeaGreen;
            BtProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtProducto.IconSize = 55;
            BtProducto.ImageScaling = ToolStripItemImageScaling.None;
            BtProducto.Name = "BtProducto";
            BtProducto.Padding = new Padding(8, 0, 8, 0);
            BtProducto.Size = new Size(120, 80);
            BtProducto.Text = "PRODUCTOS";
            BtProducto.TextImageRelation = TextImageRelation.ImageAboveText;
            BtProducto.Click += BtProducto_Click;
            // 
            // BtCategoria
            // 
            BtCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtCategoria.ForeColor = Color.SeaGreen;
            BtCategoria.IconChar = FontAwesome.Sharp.IconChar.ListSquares;
            BtCategoria.IconColor = Color.SeaGreen;
            BtCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtCategoria.IconSize = 55;
            BtCategoria.ImageScaling = ToolStripItemImageScaling.None;
            BtCategoria.Name = "BtCategoria";
            BtCategoria.Padding = new Padding(8, 0, 8, 0);
            BtCategoria.Size = new Size(121, 80);
            BtCategoria.Text = "CATEGORIAS";
            BtCategoria.TextImageRelation = TextImageRelation.ImageAboveText;
            BtCategoria.Click += BtCategoria_Click;
            // 
            // BtSuplidor
            // 
            BtSuplidor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtSuplidor.ForeColor = Color.SeaGreen;
            BtSuplidor.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            BtSuplidor.IconColor = Color.SeaGreen;
            BtSuplidor.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtSuplidor.IconSize = 55;
            BtSuplidor.ImageScaling = ToolStripItemImageScaling.None;
            BtSuplidor.Name = "BtSuplidor";
            BtSuplidor.Padding = new Padding(8, 0, 8, 0);
            BtSuplidor.Size = new Size(118, 80);
            BtSuplidor.Text = "SUPLIDORES";
            BtSuplidor.TextImageRelation = TextImageRelation.ImageAboveText;
            BtSuplidor.Click += BtSuplidor_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(172, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(622, 563);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(994, 702);
            Controls.Add(pictureBox1);
            Controls.Add(MenuPrincipal);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = MenuPrincipal;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmPrincipal_Load;
            MenuPrincipal.ResumeLayout(false);
            MenuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuPrincipal;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconMenuItem BtProducto;
        private FontAwesome.Sharp.IconMenuItem BtCategoria;
        private FontAwesome.Sharp.IconMenuItem BtSuplidor;
    }
}