namespace Crypto_app.MaHoaCoDien
{
    partial class frmAffine
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
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAffineKeyB = new System.Windows.Forms.TextBox();
            this.txtAffineKeyA = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAffineDe = new System.Windows.Forms.Button();
            this.btnAffineEn = new System.Windows.Forms.Button();
            this.txtAffineOutput = new System.Windows.Forms.TextBox();
            this.txtAffineInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(27, 202);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(583, 254);
            this.textBox5.TabIndex = 49;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(27, 167);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 29);
            this.button5.TabIndex = 48;
            this.button5.Text = "Hiện";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(272, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 16);
            this.label10.TabIndex = 45;
            this.label10.Text = "]";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(205, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 24);
            this.label11.TabIndex = 46;
            this.label11.Text = ",";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(144, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 16);
            this.label12.TabIndex = 47;
            this.label12.Text = "[";
            // 
            // txtAffineKeyB
            // 
            this.txtAffineKeyB.Location = new System.Drawing.Point(226, 127);
            this.txtAffineKeyB.Name = "txtAffineKeyB";
            this.txtAffineKeyB.Size = new System.Drawing.Size(40, 21);
            this.txtAffineKeyB.TabIndex = 43;
            // 
            // txtAffineKeyA
            // 
            this.txtAffineKeyA.Location = new System.Drawing.Point(160, 127);
            this.txtAffineKeyA.Name = "txtAffineKeyA";
            this.txtAffineKeyA.Size = new System.Drawing.Size(39, 21);
            this.txtAffineKeyA.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Nhập khóa k  [ a , b ] =  ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(482, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Output";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Input";
            // 
            // btnAffineDe
            // 
            this.btnAffineDe.Location = new System.Drawing.Point(282, 76);
            this.btnAffineDe.Name = "btnAffineDe";
            this.btnAffineDe.Size = new System.Drawing.Size(75, 38);
            this.btnAffineDe.TabIndex = 39;
            this.btnAffineDe.Text = "Giải Mã";
            this.btnAffineDe.UseVisualStyleBackColor = true;
            this.btnAffineDe.Click += new System.EventHandler(this.btnAffineDe_Click);
            // 
            // btnAffineEn
            // 
            this.btnAffineEn.Location = new System.Drawing.Point(282, 32);
            this.btnAffineEn.Name = "btnAffineEn";
            this.btnAffineEn.Size = new System.Drawing.Size(75, 38);
            this.btnAffineEn.TabIndex = 38;
            this.btnAffineEn.Text = "Mã Hóa";
            this.btnAffineEn.UseVisualStyleBackColor = true;
            this.btnAffineEn.Click += new System.EventHandler(this.btnAffineEn_Click);
            // 
            // txtAffineOutput
            // 
            this.txtAffineOutput.Location = new System.Drawing.Point(379, 35);
            this.txtAffineOutput.Multiline = true;
            this.txtAffineOutput.Name = "txtAffineOutput";
            this.txtAffineOutput.Size = new System.Drawing.Size(231, 76);
            this.txtAffineOutput.TabIndex = 37;
            // 
            // txtAffineInput
            // 
            this.txtAffineInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAffineInput.Location = new System.Drawing.Point(27, 33);
            this.txtAffineInput.Multiline = true;
            this.txtAffineInput.Name = "txtAffineInput";
            this.txtAffineInput.Size = new System.Drawing.Size(234, 76);
            this.txtAffineInput.TabIndex = 36;
            // 
            // frmAffine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtAffineKeyB);
            this.Controls.Add(this.txtAffineKeyA);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAffineDe);
            this.Controls.Add(this.btnAffineEn);
            this.Controls.Add(this.txtAffineOutput);
            this.Controls.Add(this.txtAffineInput);
            this.Name = "frmAffine";
            this.Size = new System.Drawing.Size(637, 472);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAffineKeyB;
        private System.Windows.Forms.TextBox txtAffineKeyA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAffineDe;
        private System.Windows.Forms.Button btnAffineEn;
        private System.Windows.Forms.TextBox txtAffineOutput;
        private System.Windows.Forms.TextBox txtAffineInput;
    }
}
