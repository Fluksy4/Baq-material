
namespace RegisterForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_user = new System.Windows.Forms.Label();
            this.txtBox_user = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtBox_confpass = new System.Windows.Forms.TextBox();
            this.lbl_confpass = new System.Windows.Forms.Label();
            this.txtBox_pass = new System.Windows.Forms.TextBox();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.btn_reg = new System.Windows.Forms.Button();
            this.chBox_showpass = new System.Windows.Forms.CheckBox();
            this.lbl_test = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_user.Location = new System.Drawing.Point(125, 158);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(81, 18);
            this.lbl_user.TabIndex = 0;
            this.lbl_user.Text = "Username:";
            // 
            // txtBox_user
            // 
            this.txtBox_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_user.Location = new System.Drawing.Point(128, 179);
            this.txtBox_user.Name = "txtBox_user";
            this.txtBox_user.Size = new System.Drawing.Size(169, 22);
            this.txtBox_user.TabIndex = 1;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl1.Location = new System.Drawing.Point(12, 33);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(409, 24);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Sign up to watch the new NBA 2K23 trailer.";
            // 
            // txtBox_confpass
            // 
            this.txtBox_confpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_confpass.Location = new System.Drawing.Point(128, 296);
            this.txtBox_confpass.Name = "txtBox_confpass";
            this.txtBox_confpass.PasswordChar = '*';
            this.txtBox_confpass.Size = new System.Drawing.Size(169, 22);
            this.txtBox_confpass.TabIndex = 4;
            // 
            // lbl_confpass
            // 
            this.lbl_confpass.AutoSize = true;
            this.lbl_confpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_confpass.Location = new System.Drawing.Point(125, 275);
            this.lbl_confpass.Name = "lbl_confpass";
            this.lbl_confpass.Size = new System.Drawing.Size(136, 18);
            this.lbl_confpass.TabIndex = 3;
            this.lbl_confpass.Text = "Confirm Password:";
            // 
            // txtBox_pass
            // 
            this.txtBox_pass.AcceptsTab = true;
            this.txtBox_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_pass.Location = new System.Drawing.Point(128, 239);
            this.txtBox_pass.Name = "txtBox_pass";
            this.txtBox_pass.PasswordChar = '*';
            this.txtBox_pass.Size = new System.Drawing.Size(169, 22);
            this.txtBox_pass.TabIndex = 6;
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_pass.Location = new System.Drawing.Point(125, 218);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(79, 18);
            this.lbl_pass.TabIndex = 5;
            this.lbl_pass.Text = "Password:";
            // 
            // btn_reg
            // 
            this.btn_reg.Location = new System.Drawing.Point(141, 362);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(142, 31);
            this.btn_reg.TabIndex = 7;
            this.btn_reg.Text = "Register";
            this.btn_reg.UseMnemonic = false;
            this.btn_reg.UseVisualStyleBackColor = true;
            this.btn_reg.Click += new System.EventHandler(this.btn_reg_Click);
            // 
            // chBox_showpass
            // 
            this.chBox_showpass.AutoSize = true;
            this.chBox_showpass.Cursor = System.Windows.Forms.Cursors.Default;
            this.chBox_showpass.Location = new System.Drawing.Point(195, 324);
            this.chBox_showpass.Name = "chBox_showpass";
            this.chBox_showpass.Size = new System.Drawing.Size(102, 17);
            this.chBox_showpass.TabIndex = 8;
            this.chBox_showpass.Text = "Show Password";
            this.chBox_showpass.UseVisualStyleBackColor = true;
            this.chBox_showpass.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lbl_test
            // 
            this.lbl_test.AutoSize = true;
            this.lbl_test.Location = new System.Drawing.Point(380, 208);
            this.lbl_test.Name = "lbl_test";
            this.lbl_test.Size = new System.Drawing.Size(0, 13);
            this.lbl_test.TabIndex = 10;
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_id.Location = new System.Drawing.Point(128, 123);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(169, 22);
            this.txt_id.TabIndex = 12;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_id.Location = new System.Drawing.Point(125, 102);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(65, 18);
            this.lbl_id.TabIndex = 11;
            this.lbl_id.Text = "Number:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(793, 502);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_test);
            this.Controls.Add(this.chBox_showpass);
            this.Controls.Add(this.btn_reg);
            this.Controls.Add(this.txtBox_pass);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.txtBox_confpass);
            this.Controls.Add(this.lbl_confpass);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtBox_user);
            this.Controls.Add(this.lbl_user);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "NBA 2K23";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.TextBox txtBox_user;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtBox_confpass;
        private System.Windows.Forms.Label lbl_confpass;
        private System.Windows.Forms.TextBox txtBox_pass;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Button btn_reg;
        private System.Windows.Forms.CheckBox chBox_showpass;
        private System.Windows.Forms.Label lbl_test;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_id;
    }
}

