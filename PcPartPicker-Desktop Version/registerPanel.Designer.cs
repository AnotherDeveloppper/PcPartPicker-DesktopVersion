namespace PcPartPicker_Desktop_Version
{
    partial class registerPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registerPanel));
            this.label2 = new System.Windows.Forms.Label();
            this.tb_date = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label3 = new System.Windows.Forms.Label();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_adress = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_password = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tb_username = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tb_phone = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tb_email = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tb_last = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tb_fisrt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // tb_date
            // 
            this.tb_date.BackColor = System.Drawing.Color.Black;
            this.tb_date.BorderRadius = 0;
            this.tb_date.ForeColor = System.Drawing.Color.White;
            this.tb_date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.tb_date.FormatCustom = null;
            resources.ApplyResources(this.tb_date, "tb_date");
            this.tb_date.Name = "tb_date";
            this.tb_date.Value = new System.DateTime(2020, 2, 18, 1, 58, 44, 163);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // male
            // 
            resources.ApplyResources(this.male, "male");
            this.male.Checked = true;
            this.male.Name = "male";
            this.male.TabStop = true;
            this.male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            resources.ApplyResources(this.female, "female");
            this.female.Name = "female";
            this.female.TabStop = true;
            this.female.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.male);
            this.groupBox1.Controls.Add(this.female);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // tb_adress
            // 
            this.tb_adress.BorderColorFocused = System.Drawing.Color.Blue;
            this.tb_adress.BorderColorIdle = System.Drawing.Color.Black;
            this.tb_adress.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tb_adress.BorderThickness = 2;
            this.tb_adress.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.tb_adress, "tb_adress");
            this.tb_adress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_adress.isPassword = false;
            this.tb_adress.Name = "tb_adress";
            this.tb_adress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.button2, "button2");
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_password
            // 
            this.tb_password.BorderColorFocused = System.Drawing.Color.Blue;
            this.tb_password.BorderColorIdle = System.Drawing.Color.Black;
            this.tb_password.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tb_password.BorderThickness = 2;
            this.tb_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.tb_password, "tb_password");
            this.tb_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_password.isPassword = false;
            this.tb_password.Name = "tb_password";
            this.tb_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tb_username
            // 
            this.tb_username.BorderColorFocused = System.Drawing.Color.Blue;
            this.tb_username.BorderColorIdle = System.Drawing.Color.Black;
            this.tb_username.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tb_username.BorderThickness = 2;
            this.tb_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.tb_username, "tb_username");
            this.tb_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_username.isPassword = false;
            this.tb_username.Name = "tb_username";
            this.tb_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tb_phone
            // 
            this.tb_phone.BorderColorFocused = System.Drawing.Color.Blue;
            this.tb_phone.BorderColorIdle = System.Drawing.Color.Black;
            this.tb_phone.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tb_phone.BorderThickness = 2;
            this.tb_phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.tb_phone, "tb_phone");
            this.tb_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_phone.isPassword = false;
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tb_email
            // 
            this.tb_email.BorderColorFocused = System.Drawing.Color.Blue;
            this.tb_email.BorderColorIdle = System.Drawing.Color.Black;
            this.tb_email.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tb_email.BorderThickness = 2;
            this.tb_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.tb_email, "tb_email");
            this.tb_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_email.isPassword = false;
            this.tb_email.Name = "tb_email";
            this.tb_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tb_last
            // 
            this.tb_last.BorderColorFocused = System.Drawing.Color.Blue;
            this.tb_last.BorderColorIdle = System.Drawing.Color.Black;
            this.tb_last.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tb_last.BorderThickness = 2;
            this.tb_last.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.tb_last, "tb_last");
            this.tb_last.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_last.isPassword = false;
            this.tb_last.Name = "tb_last";
            this.tb_last.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tb_fisrt
            // 
            this.tb_fisrt.BorderColorFocused = System.Drawing.Color.Blue;
            this.tb_fisrt.BorderColorIdle = System.Drawing.Color.Black;
            this.tb_fisrt.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tb_fisrt.BorderThickness = 2;
            this.tb_fisrt.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.tb_fisrt, "tb_fisrt");
            this.tb_fisrt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_fisrt.isPassword = false;
            this.tb_fisrt.Name = "tb_fisrt";
            this.tb_fisrt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // registerPanel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_last);
            this.Controls.Add(this.tb_fisrt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_adress);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_date);
            this.Controls.Add(this.label2);
            this.Name = "registerPanel";
            this.Load += new System.EventHandler(this.registerPanel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDatepicker tb_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuMetroTextbox tb_adress;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private Bunifu.Framework.UI.BunifuMetroTextbox tb_password;
        private Bunifu.Framework.UI.BunifuMetroTextbox tb_username;
        private Bunifu.Framework.UI.BunifuMetroTextbox tb_phone;
        private Bunifu.Framework.UI.BunifuMetroTextbox tb_email;
        private Bunifu.Framework.UI.BunifuMetroTextbox tb_last;
        private Bunifu.Framework.UI.BunifuMetroTextbox tb_fisrt;
        private System.Windows.Forms.Label label1;
    }
}
