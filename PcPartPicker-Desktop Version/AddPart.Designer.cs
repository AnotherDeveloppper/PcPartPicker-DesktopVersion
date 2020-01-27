namespace PcPartPicker_Desktop_Version
{
    partial class AddPart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPart));
            this.lblPrice = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbItemName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pbItemPic = new System.Windows.Forms.PictureBox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemPic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblPrice.Location = new System.Drawing.Point(463, 33);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(32, 23);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "20";
            // 
            // lbItemName
            // 
            this.lbItemName.AutoSize = true;
            this.lbItemName.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbItemName.Location = new System.Drawing.Point(109, 33);
            this.lbItemName.Name = "lbItemName";
            this.lbItemName.Size = new System.Drawing.Size(113, 23);
            this.lbItemName.TabIndex = 8;
            this.lbItemName.Text = "Item Name";
            // 
            // pbItemPic
            // 
            this.pbItemPic.Location = new System.Drawing.Point(3, 3);
            this.pbItemPic.Name = "pbItemPic";
            this.pbItemPic.Size = new System.Drawing.Size(100, 78);
            this.pbItemPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbItemPic.TabIndex = 9;
            this.pbItemPic.TabStop = false;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Add";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(528, 24);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(75, 41);
            this.bunifuThinButton21.TabIndex = 12;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.pbItemPic);
            this.Controls.Add(this.lbItemName);
            this.Name = "AddPart";
            this.Size = new System.Drawing.Size(618, 84);
            ((System.ComponentModel.ISupportInitialize)(this.pbItemPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel lblPrice;
        private System.Windows.Forms.PictureBox pbItemPic;
        private Bunifu.Framework.UI.BunifuCustomLabel lbItemName;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
    }
}
