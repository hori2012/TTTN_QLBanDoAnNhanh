namespace QLBanDoAnNhanh
{
    partial class ItemOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemOrder));
            this.numCount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lbName = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // numCount
            // 
            this.numCount.BackColor = System.Drawing.Color.Transparent;
            this.numCount.BorderColor = System.Drawing.Color.Tomato;
            this.numCount.BorderRadius = 4;
            this.numCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numCount.Location = new System.Drawing.Point(280, 18);
            this.numCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(71, 31);
            this.numCount.TabIndex = 0;
            this.numCount.UpDownButtonFillColor = System.Drawing.Color.Tomato;
            this.numCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(47, 7);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(52, 18);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Buger";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.Gray;
            this.lbDate.Location = new System.Drawing.Point(47, 38);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(71, 16);
            this.lbDate.TabIndex = 2;
            this.lbDate.Text = "20-12-2002";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(5, 7);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(39, 48);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 3;
            this.guna2PictureBox1.TabStop = false;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(376, 24);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(36, 18);
            this.lbPrice.TabIndex = 4;
            this.lbPrice.Text = "9.0$";
            // 
            // ItemOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.numCount);
            this.Name = "ItemOrder";
            this.Size = new System.Drawing.Size(444, 67);
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2NumericUpDown numCount;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbDate;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label lbPrice;
    }
}
