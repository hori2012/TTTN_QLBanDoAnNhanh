namespace QLBanDoAnNhanh
{
    partial class Item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Item));
            this.pnPrice = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pnName = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.btnValid = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnPrice.SuspendLayout();
            this.pnName.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnPrice
            // 
            this.pnPrice.BackColor = System.Drawing.Color.Transparent;
            this.pnPrice.BorderRadius = 3;
            this.pnPrice.Controls.Add(this.lbPrice);
            this.pnPrice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.pnPrice.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.pnPrice.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pnPrice.Location = new System.Drawing.Point(2, 3);
            this.pnPrice.Name = "pnPrice";
            this.pnPrice.Size = new System.Drawing.Size(91, 26);
            this.pnPrice.TabIndex = 0;
            // 
            // pnName
            // 
            this.pnName.BackColor = System.Drawing.Color.Transparent;
            this.pnName.Controls.Add(this.lbName);
            this.pnName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnName.Location = new System.Drawing.Point(14, 158);
            this.pnName.Name = "pnName";
            this.pnName.ShadowColor = System.Drawing.Color.White;
            this.pnName.Size = new System.Drawing.Size(173, 38);
            this.pnName.TabIndex = 1;
            this.pnName.Click += new System.EventHandler(this.pnName_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(58, 9);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(47, 18);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Buger";
            this.lbName.Click += new System.EventHandler(this.lbName_Click);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.White;
            this.lbPrice.Location = new System.Drawing.Point(18, 4);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(36, 18);
            this.lbPrice.TabIndex = 0;
            this.lbPrice.Text = "9.0$";
            // 
            // btnValid
            // 
            this.btnValid.BackColor = System.Drawing.Color.Transparent;
            this.btnValid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnValid.BorderRadius = 4;
            this.btnValid.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnValid.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnValid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnValid.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnValid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnValid.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.btnValid.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.btnValid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnValid.ForeColor = System.Drawing.Color.Transparent;
            this.btnValid.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnValid.Image = ((System.Drawing.Image)(resources.GetObject("btnValid.Image")));
            this.btnValid.Location = new System.Drawing.Point(158, 2);
            this.btnValid.Name = "btnValid";
            this.btnValid.Size = new System.Drawing.Size(43, 31);
            this.btnValid.TabIndex = 2;
            this.btnValid.Visible = false;
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnValid);
            this.Controls.Add(this.pnName);
            this.Controls.Add(this.pnPrice);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Item";
            this.Size = new System.Drawing.Size(203, 196);
            this.Click += new System.EventHandler(this.Item_Click);
            this.pnPrice.ResumeLayout(false);
            this.pnPrice.PerformLayout();
            this.pnName.ResumeLayout(false);
            this.pnName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel pnPrice;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnName;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbName;
        private Guna.UI2.WinForms.Guna2GradientButton btnValid;
    }
}
