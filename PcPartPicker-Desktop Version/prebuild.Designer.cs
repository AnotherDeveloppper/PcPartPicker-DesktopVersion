﻿namespace PcPartPicker_Desktop_Version
{
    partial class prebuild
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(prebuild));
            this.panel1 = new System.Windows.Forms.Panel();
            this.prebuildID = new System.Windows.Forms.Label();
            this.prebuildbuilder = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.prebuildpic = new System.Windows.Forms.PictureBox();
            this.prebuildname = new System.Windows.Forms.Label();
            this.prebuildcpu = new System.Windows.Forms.Label();
            this.prebuildgpu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.prebuildprice = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prebuildpic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.prebuildID);
            this.panel1.Controls.Add(this.prebuildbuilder);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 32);
            this.panel1.TabIndex = 0;
            // 
            // prebuildID
            // 
            this.prebuildID.AutoSize = true;
            this.prebuildID.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prebuildID.Location = new System.Drawing.Point(214, 20);
            this.prebuildID.Name = "prebuildID";
            this.prebuildID.Size = new System.Drawing.Size(0, 2);
            this.prebuildID.TabIndex = 2;
            // 
            // prebuildbuilder
            // 
            this.prebuildbuilder.AutoSize = true;
            this.prebuildbuilder.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prebuildbuilder.Location = new System.Drawing.Point(65, 11);
            this.prebuildbuilder.Name = "prebuildbuilder";
            this.prebuildbuilder.Size = new System.Drawing.Size(70, 13);
            this.prebuildbuilder.TabIndex = 1;
            this.prebuildbuilder.Text = "Build name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "🖥️";
            // 
            // prebuildpic
            // 
            this.prebuildpic.Enabled = false;
            this.prebuildpic.Location = new System.Drawing.Point(0, 27);
            this.prebuildpic.Name = "prebuildpic";
            this.prebuildpic.Size = new System.Drawing.Size(233, 108);
            this.prebuildpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prebuildpic.TabIndex = 1;
            this.prebuildpic.TabStop = false;
            this.prebuildpic.Click += new System.EventHandler(this.prebuildpic_Click);
            // 
            // prebuildname
            // 
            this.prebuildname.AutoSize = true;
            this.prebuildname.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prebuildname.Location = new System.Drawing.Point(18, 140);
            this.prebuildname.Name = "prebuildname";
            this.prebuildname.Size = new System.Drawing.Size(115, 18);
            this.prebuildname.TabIndex = 2;
            this.prebuildname.Text = "prebuild name\'";
            // 
            // prebuildcpu
            // 
            this.prebuildcpu.AutoSize = true;
            this.prebuildcpu.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prebuildcpu.Location = new System.Drawing.Point(42, 163);
            this.prebuildcpu.Name = "prebuildcpu";
            this.prebuildcpu.Size = new System.Drawing.Size(28, 13);
            this.prebuildcpu.TabIndex = 3;
            this.prebuildcpu.Text = "CPU";
            // 
            // prebuildgpu
            // 
            this.prebuildgpu.AutoSize = true;
            this.prebuildgpu.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prebuildgpu.Location = new System.Drawing.Point(42, 182);
            this.prebuildgpu.Name = "prebuildgpu";
            this.prebuildgpu.Size = new System.Drawing.Size(28, 13);
            this.prebuildgpu.TabIndex = 4;
            this.prebuildgpu.Text = "GPU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 5);
            this.label1.TabIndex = 5;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // prebuildprice
            // 
            this.prebuildprice.AutoSize = true;
            this.prebuildprice.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prebuildprice.ForeColor = System.Drawing.Color.DarkGreen;
            this.prebuildprice.Location = new System.Drawing.Point(15, 205);
            this.prebuildprice.Name = "prebuildprice";
            this.prebuildprice.Size = new System.Drawing.Size(55, 16);
            this.prebuildprice.TabIndex = 6;
            this.prebuildprice.Text = "980.36 $";
            // 
            // prebuild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.prebuildprice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prebuildgpu);
            this.Controls.Add(this.prebuildcpu);
            this.Controls.Add(this.prebuildname);
            this.Controls.Add(this.prebuildpic);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "prebuild";
            this.Size = new System.Drawing.Size(233, 227);
            this.Load += new System.EventHandler(this.prebuild_Load_1);
            this.Click += new System.EventHandler(this.prebuild_Click);
            this.MouseLeave += new System.EventHandler(this.prebuild_MouseLeave);
            this.MouseHover += new System.EventHandler(this.prebuild_MouseHover);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prebuildpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox prebuildpic;
        private System.Windows.Forms.Label prebuildname;
        private System.Windows.Forms.Label prebuildcpu;
        private System.Windows.Forms.Label prebuildgpu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label prebuildprice;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCustomLabel prebuildbuilder;
        private System.Windows.Forms.Label prebuildID;
    }
}
