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
            this.txtDESKey.Location = new System.Drawing.Point(140, 156);
            this.txtDESKey.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDESKey.Name = "txtDESKey";
            this.txtDESKey.Size = new System.Drawing.Size(214, 23);
            this.txtDESKey.TabIndex = 60;
            // 
            // txtDES
            // 
            this.txtDES.Location = new System.Drawing.Point(31, 249);
            this.txtDES.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDES.Multiline = true;
            this.txtDES.Name = "txtDES";
            this.txtDES.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDES.Size = new System.Drawing.Size(679, 312);
            this.txtDES.TabIndex = 59;
            // 
            // btnDES
            // 
            this.btnDES.Location = new System.Drawing.Point(31, 206);
            this.btnDES.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDES.Name = "btnDES";
            this.btnDES.Size = new System.Drawing.Size(78, 36);
            this.btnDES.TabIndex = 58;
            this.btnDES.Text = "Hiện";
            this.btnDES.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 17);
            this.label9.TabIndex = 57;
            this.label9.Text = "Nhập khóa k  = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(562, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 56;
            this.label5.Text = "Output";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 55;
            this.label6.Text = "Input";
            // 
            // btnDESDe
            // 
            this.btnDESDe.Location = new System.Drawing.Point(329, 94);
            this.btnDESDe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDESDe.Name = "btnDESDe";
            this.btnDESDe.Size = new System.Drawing.Size(87, 47);
            this.btnDESDe.TabIndex = 54;
            this.btnDESDe.Text = "Giải Mã";
            this.btnDESDe.UseVisualStyleBackColor = true;
            this.btnDESDe.Click += new System.EventHandler(this.btnDESDe_Click);
            // 
            // btnDESEn
            // 
            this.btnDESEn.Location = new System.Drawing.Point(329, 39);
            this.btnDESEn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDESEn.Name = "btnDESEn";
            this.btnDESEn.Size = new System.Drawing.Size(87, 47);
            this.btnDESEn.TabIndex = 53;
            this.btnDESEn.Text = "Mã Hóa";
            this.btnDESEn.UseVisualStyleBackColor = true;
            this.btnDESEn.Click += new System.EventHandler(this.btnDESEn_Click);
            // 
            // txtDESOutput
            // 
            this.txtDESOutput.Location = new System.Drawing.Point(442, 43);
            this.txtDESOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDESOutput.Multiline = true;
            this.txtDESOutput.Name = "txtDESOutput";
            this.txtDESOutput.Size = new System.Drawing.Size(269, 93);
            this.txtDESOutput.TabIndex = 52;
            // 
            // txtDESInput
            // 
            this.txtDESInput.Location = new System.Drawing.Point(31, 41);
            this.txtDESInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDESInput.Multiline = true;
            this.txtDESInput.Name = "txtDESInput";
            this.txtDESInput.Size = new System.Drawing.Size(272, 93);
            this.txtDESInput.TabIndex = 51;
            // 
            // frmDES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDES";
            this.Size = new System.Drawing.Size(743, 581);
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
