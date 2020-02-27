namespace PcPartPicker_Desktop_Version
{
    partial class AllParts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllParts));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.cbCPU = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRAM = new Bunifu.Framework.UI.BunifuCheckbox();
            this.cbMobo = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuCheckbox4 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.cbStorage = new System.Windows.Forms.Label();
            this.bunifuCheckbox2 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCheckbox6 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.cbGPU = new System.Windows.Forms.Label();
            this.cbPSU = new System.Windows.Forms.Label();
            this.bunifuCheckbox7 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.cbCase = new System.Windows.Forms.Label();
            this.bunifuCheckbox5 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(31, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(628, 518);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(652, 545);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Visible = false;
            // 
            // tbSearch
            // 
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbSearch.HintForeColor = System.Drawing.Color.Empty;
            this.tbSearch.HintText = "";
            this.tbSearch.isPassword = false;
            this.tbSearch.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbSearch.LineIdleColor = System.Drawing.Color.Black;
            this.tbSearch.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbSearch.LineThickness = 3;
            this.tbSearch.Location = new System.Drawing.Point(47, 32);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(584, 44);
            this.tbSearch.TabIndex = 2;
            this.tbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(685, 32);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(114, 47);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 3;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // cbCPU
            // 
            this.cbCPU.BackColor = System.Drawing.Color.Black;
            this.cbCPU.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbCPU.Checked = true;
            this.cbCPU.CheckedOnColor = System.Drawing.Color.Black;
            this.cbCPU.ForeColor = System.Drawing.Color.White;
            this.cbCPU.Location = new System.Drawing.Point(702, 225);
            this.cbCPU.Name = "cbCPU";
            this.cbCPU.Size = new System.Drawing.Size(20, 20);
            this.cbCPU.TabIndex = 4;
            this.cbCPU.OnChange += new System.EventHandler(this.cbCPU_OnChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(742, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Processor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(742, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Memory";
            // 
            // cbRAM
            // 
            this.cbRAM.BackColor = System.Drawing.Color.Black;
            this.cbRAM.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbRAM.Checked = true;
            this.cbRAM.CheckedOnColor = System.Drawing.Color.Black;
            this.cbRAM.ForeColor = System.Drawing.Color.White;
            this.cbRAM.Location = new System.Drawing.Point(702, 251);
            this.cbRAM.Name = "cbRAM";
            this.cbRAM.Size = new System.Drawing.Size(20, 20);
            this.cbRAM.TabIndex = 6;
            this.cbRAM.OnChange += new System.EventHandler(this.cbRAM_OnChange);
            // 
            // cbMobo
            // 
            this.cbMobo.BackColor = System.Drawing.Color.Black;
            this.cbMobo.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbMobo.Checked = true;
            this.cbMobo.CheckedOnColor = System.Drawing.Color.Black;
            this.cbMobo.ForeColor = System.Drawing.Color.White;
            this.cbMobo.Location = new System.Drawing.Point(702, 277);
            this.cbMobo.Name = "cbMobo";
            this.cbMobo.Size = new System.Drawing.Size(20, 20);
            this.cbMobo.TabIndex = 8;
            this.cbMobo.OnChange += new System.EventHandler(this.cbMobo_OnChange);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(742, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Motherboard";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(742, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "CPU Cooler";
            // 
            // bunifuCheckbox4
            // 
            this.bunifuCheckbox4.BackColor = System.Drawing.Color.Black;
            this.bunifuCheckbox4.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox4.Checked = true;
            this.bunifuCheckbox4.CheckedOnColor = System.Drawing.Color.Black;
            this.bunifuCheckbox4.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox4.Location = new System.Drawing.Point(702, 303);
            this.bunifuCheckbox4.Name = "bunifuCheckbox4";
            this.bunifuCheckbox4.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox4.TabIndex = 10;
            this.bunifuCheckbox4.OnChange += new System.EventHandler(this.bunifuCheckbox4_OnChange);
            // 
            // cbStorage
            // 
            this.cbStorage.AutoSize = true;
            this.cbStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbStorage.Location = new System.Drawing.Point(742, 329);
            this.cbStorage.Name = "cbStorage";
            this.cbStorage.Size = new System.Drawing.Size(56, 16);
            this.cbStorage.TabIndex = 13;
            this.cbStorage.Text = "Storage";
            // 
            // bunifuCheckbox2
            // 
            this.bunifuCheckbox2.BackColor = System.Drawing.Color.Black;
            this.bunifuCheckbox2.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox2.Checked = true;
            this.bunifuCheckbox2.CheckedOnColor = System.Drawing.Color.Black;
            this.bunifuCheckbox2.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox2.Location = new System.Drawing.Point(702, 329);
            this.bunifuCheckbox2.Name = "bunifuCheckbox2";
            this.bunifuCheckbox2.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox2.TabIndex = 12;
            this.bunifuCheckbox2.OnChange += new System.EventHandler(this.bunifuCheckbox2_OnChange);
            // 
            // bunifuCheckbox6
            // 
            this.bunifuCheckbox6.BackColor = System.Drawing.Color.Black;
            this.bunifuCheckbox6.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox6.Checked = true;
            this.bunifuCheckbox6.CheckedOnColor = System.Drawing.Color.Black;
            this.bunifuCheckbox6.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox6.Location = new System.Drawing.Point(702, 355);
            this.bunifuCheckbox6.Name = "bunifuCheckbox6";
            this.bunifuCheckbox6.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox6.TabIndex = 14;
            this.bunifuCheckbox6.OnChange += new System.EventHandler(this.bunifuCheckbox6_OnChange);
            // 
            // cbGPU
            // 
            this.cbGPU.AutoSize = true;
            this.cbGPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbGPU.Location = new System.Drawing.Point(742, 355);
            this.cbGPU.Name = "cbGPU";
            this.cbGPU.Size = new System.Drawing.Size(87, 16);
            this.cbGPU.TabIndex = 15;
            this.cbGPU.Text = "Graphic Card";
            // 
            // cbPSU
            // 
            this.cbPSU.AutoSize = true;
            this.cbPSU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbPSU.Location = new System.Drawing.Point(742, 381);
            this.cbPSU.Name = "cbPSU";
            this.cbPSU.Size = new System.Drawing.Size(91, 16);
            this.cbPSU.TabIndex = 17;
            this.cbPSU.Text = "Power Supply";
            // 
            // bunifuCheckbox7
            // 
            this.bunifuCheckbox7.BackColor = System.Drawing.Color.Black;
            this.bunifuCheckbox7.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox7.Checked = true;
            this.bunifuCheckbox7.CheckedOnColor = System.Drawing.Color.Black;
            this.bunifuCheckbox7.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox7.Location = new System.Drawing.Point(702, 381);
            this.bunifuCheckbox7.Name = "bunifuCheckbox7";
            this.bunifuCheckbox7.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox7.TabIndex = 16;
            this.bunifuCheckbox7.OnChange += new System.EventHandler(this.bunifuCheckbox7_OnChange);
            // 
            // cbCase
            // 
            this.cbCase.AutoSize = true;
            this.cbCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbCase.Location = new System.Drawing.Point(742, 407);
            this.cbCase.Name = "cbCase";
            this.cbCase.Size = new System.Drawing.Size(40, 16);
            this.cbCase.TabIndex = 19;
            this.cbCase.Text = "Case";
            // 
            // bunifuCheckbox5
            // 
            this.bunifuCheckbox5.BackColor = System.Drawing.Color.Black;
            this.bunifuCheckbox5.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox5.Checked = true;
            this.bunifuCheckbox5.CheckedOnColor = System.Drawing.Color.Black;
            this.bunifuCheckbox5.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox5.Location = new System.Drawing.Point(702, 407);
            this.bunifuCheckbox5.Name = "bunifuCheckbox5";
            this.bunifuCheckbox5.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox5.TabIndex = 18;
            this.bunifuCheckbox5.OnChange += new System.EventHandler(this.bunifuCheckbox5_OnChange);
            // 
            // AllParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbCase);
            this.Controls.Add(this.bunifuCheckbox5);
            this.Controls.Add(this.cbPSU);
            this.Controls.Add(this.bunifuCheckbox7);
            this.Controls.Add(this.cbGPU);
            this.Controls.Add(this.bunifuCheckbox6);
            this.Controls.Add(this.cbStorage);
            this.Controls.Add(this.bunifuCheckbox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bunifuCheckbox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbMobo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbRAM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCPU);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.panel2);
            this.Name = "AllParts";
            this.Size = new System.Drawing.Size(862, 637);
            this.Load += new System.EventHandler(this.AllParts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbSearch;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCheckbox cbCPU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCheckbox cbRAM;
        private Bunifu.Framework.UI.BunifuCheckbox cbMobo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox4;
        private System.Windows.Forms.Label cbStorage;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox2;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox6;
        private System.Windows.Forms.Label cbGPU;
        private System.Windows.Forms.Label cbPSU;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox7;
        private System.Windows.Forms.Label cbCase;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
