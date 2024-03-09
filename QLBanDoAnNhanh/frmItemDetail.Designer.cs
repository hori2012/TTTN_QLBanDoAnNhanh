namespace QLBanDoAnNhanh
{
    partial class frmItemDetail
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemDetail));
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.picItem = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.btnSoldOut = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2TileButton2 = new Guna.UI2.WinForms.Guna2TileButton();
            this.lbDecript = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(417, 1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // picItem
            // 
            this.picItem.Image = ((System.Drawing.Image)(resources.GetObject("picItem.Image")));
            this.picItem.ImageRotate = 0F;
            this.picItem.Location = new System.Drawing.Point(99, 12);
            this.picItem.Name = "picItem";
            this.picItem.Size = new System.Drawing.Size(260, 203);
            this.picItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picItem.TabIndex = 1;
            this.picItem.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(7, 227);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(100, 32);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Buger";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.lbPrice.Location = new System.Drawing.Point(6, 273);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(50, 25);
            this.lbPrice.TabIndex = 3;
            this.lbPrice.Text = "9.0$";
            // 
            // btnSoldOut
            // 
            this.btnSoldOut.BorderRadius = 4;
            this.btnSoldOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSoldOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSoldOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSoldOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSoldOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSoldOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSoldOut.ForeColor = System.Drawing.Color.White;
            this.btnSoldOut.Location = new System.Drawing.Point(12, 458);
            this.btnSoldOut.Name = "btnSoldOut";
            this.btnSoldOut.Size = new System.Drawing.Size(140, 54);
            this.btnSoldOut.TabIndex = 5;
            this.btnSoldOut.Text = "Sold out";
            // 
            // guna2TileButton2
            // 
            this.guna2TileButton2.BorderRadius = 4;
            this.guna2TileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2TileButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2TileButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2TileButton2.FillColor = System.Drawing.Color.Red;
            this.guna2TileButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TileButton2.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton2.Location = new System.Drawing.Point(290, 458);
            this.guna2TileButton2.Name = "guna2TileButton2";
            this.guna2TileButton2.Size = new System.Drawing.Size(138, 54);
            this.guna2TileButton2.TabIndex = 6;
            this.guna2TileButton2.Text = "Delete";
            // 
            // lbDecript
            // 
            this.lbDecript.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDecript.Location = new System.Drawing.Point(12, 315);
            this.lbDecript.Name = "lbDecript";
            this.lbDecript.Size = new System.Drawing.Size(439, 126);
            this.lbDecript.TabIndex = 7;
            this.lbDecript.Text = "abc";
            // 
            // frmItemDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(463, 524);
            this.Controls.Add(this.lbDecript);
            this.Controls.Add(this.guna2TileButton2);
            this.Controls.Add(this.btnSoldOut);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.picItem);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmItemDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmListItem";
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2PictureBox picItem;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPrice;
        private Guna.UI2.WinForms.Guna2TileButton btnSoldOut;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton2;
        private System.Windows.Forms.Label lbDecript;
    }
}