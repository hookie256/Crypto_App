namespace Crypto_app.MaHoaHienDai
{
    partial class frmDES
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
            this.txtDESKey = new System.Windows.Forms.TextBox();
            this.txtDES = new System.Windows.Forms.TextBox();
            this.btnDES = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDESDe = new System.Windows.Forms.Button();
            this.btnDESEn = new System.Windows.Forms.Button();
            this.txtDESOutput = new System.Windows.Forms.TextBox();
            this.txtDESInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDESKey
            // 
            this.txtDESKey.Location = new System.Drawing.Point(120, 127);
            this.txtDESKey.Name = "txtDESKey";
            this.txtDESKey.Size = new System.Drawing.Size(184, 21);
            this.txtDESKey.TabIndex = 60;
            // 
            // txtDES
            // 
            this.txtDES.Location = new System.Drawing.Point(27, 202);
            this.txtDES.Multiline = true;
            this.txtDES.Name = "txtDES";
            this.txtDES.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDES.Size = new System.Drawing.Size(583, 254);
            this.txtDES.TabIndex = 59;
            // 
            // btnDES
            // 
            this.btnDES.Location = new System.Drawing.Point(27, 167);
            this.btnDES.Name = "btnDES";
            this.btnDES.Size = new System.Drawing.Size(67, 29);
            this.btnDES.TabIndex = 58;
            this.btnDES.Text = "Hiện";
            this.btnDES.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 57;
            this.label9.Text = "Nhập khóa k  = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(482, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Output";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "Input";
            // 
            // btnDESDe
            // 
            this.btnDESDe.Location = new System.Drawing.Point(282, 76);
            this.btnDESDe.Name = "btnDESDe";
            this.btnDESDe.Size = new System.Drawing.Size(75, 38);
            this.btnDESDe.TabIndex = 54;
            this.btnDESDe.Text = "Giải Mã";
            this.btnDESDe.UseVisualStyleBackColor = true;
            this.btnDESDe.Click += new System.EventHandler(this.btnDESDe_Click);
            // 
            // btnDESEn
            // 
            this.btnDESEn.Location = new System.Drawing.Point(282, 32);
            this.btnDESEn.Name = "btnDESEn";
            this.btnDESEn.Size = new System.Drawing.Size(75, 38);
            this.btnDESEn.TabIndex = 53;
            this.btnDESEn.Text = "Mã Hóa";
            this.btnDESEn.UseVisualStyleBackColor = true;
            this.btnDESEn.Click += new System.EventHandler(this.btnDESEn_Click);
            // 
            // txtDESOutput
            // 
            this.txtDESOutput.Location = new System.Drawing.Point(379, 35);
            this.txtDESOutput.Multiline = true;
            this.txtDESOutput.Name = "txtDESOutput";
            this.txtDESOutput.Size = new System.Drawing.Size(231, 76);
            this.txtDESOutput.TabIndex = 52;
            // 
            // txtDESInput
            // 
            this.txtDESInput.Location = new System.Drawing.Point(27, 33);
            this.txtDESInput.Multiline = true;
            this.txtDESInput.Name = "txtDESInput";
            this.txtDESInput.Size = new System.Drawing.Size(234, 76);
            this.txtDESInput.TabIndex = 51;
            // 
            // frmDES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDESKey);
            this.Controls.Add(this.txtDES);
            this.Controls.Add(this.btnDES);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDESDe);
            this.Controls.Add(this.btnDESEn);
            this.Controls.Add(this.txtDESOutput);
            this.Controls.Add(this.txtDESInput);
            this.Name = "frmDES";
            this.Size = new System.Drawing.Size(637, 472);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDESKey;
        private System.Windows.Forms.TextBox txtDES;
        private System.Windows.Forms.Button btnDES;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDESDe;
        private System.Windows.Forms.Button btnDESEn;
        private System.Windows.Forms.TextBox txtDESOutput;
        private System.Windows.Forms.TextBox txtDESInput;
    }
}
