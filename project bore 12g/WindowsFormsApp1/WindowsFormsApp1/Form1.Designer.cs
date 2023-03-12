
namespace WindowsFormsApp1
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
            this.lblText = new System.Windows.Forms.Label();
            this.txtEq = new System.Windows.Forms.TextBox();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.chbSP = new System.Windows.Forms.CheckBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.btnReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Old English Text MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(367, 38);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(110, 33);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Tashak";
            this.lblText.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtEq
            // 
            this.txtEq.Location = new System.Drawing.Point(171, 74);
            this.txtEq.Multiline = true;
            this.txtEq.Name = "txtEq";
            this.txtEq.Size = new System.Drawing.Size(499, 22);
            this.txtEq.TabIndex = 1;
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(171, 200);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(183, 22);
            this.txtBox.TabIndex = 2;
            this.txtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // chbSP
            // 
            this.chbSP.AutoSize = true;
            this.chbSP.Location = new System.Drawing.Point(373, 226);
            this.chbSP.Name = "chbSP";
            this.chbSP.Size = new System.Drawing.Size(99, 21);
            this.chbSP.TabIndex = 3;
            this.chbSP.Text = "Show Pass";
            this.chbSP.UseVisualStyleBackColor = true;
            this.chbSP.CheckedChanged += new System.EventHandler(this.chbSP_CheckedChanged);
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(211, 170);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(88, 17);
            this.lblpassword.TabIndex = 4;
            this.lblpassword.Text = "PASSWORD";
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(191, 293);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(127, 47);
            this.btnReg.TabIndex = 5;
            this.btnReg.Text = "Register";
            this.btnReg.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(886, 450);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.chbSP);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.txtEq);
            this.Controls.Add(this.lblText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox txtEq;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.CheckBox chbSP;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Button btnReg;
    }
}

