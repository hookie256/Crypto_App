namespace Crypto_app.MaHoaHienDai
{
    partial class frmRSA
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRSAKeyPrivate = new System.Windows.Forms.TextBox();
            this.txtRSAKeyPublic = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRSAKey = new System.Windows.Forms.Button();
            this.txtRSA = new System.Windows.Forms.TextBox();
            this.btnRSA = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRSAQ = new System.Windows.Forms.TextBox();
            this.txtRSAP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRSADe = new System.Windows.Forms.Button();
            this.btnRSAEn = new System.Windows.Forms.Button();
            this.txtRSAOutput = new System.Windows.Forms.TextBox();
            this.txtRSAInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(712, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 20);
            this.label2.TabIndex = 75;
            this.label2.Text = "]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(633, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 29);
            this.label3.TabIndex = 76;
            this.label3.Text = ",";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(555, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 20);
            this.label4.TabIndex = 77;
            this.label4.Text = "[";
            // 
            // txtRSAKeyPrivate
            // 
            this.txtRSAKeyPrivate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtRSAKeyPrivate.Location = new System.Drawing.Point(658, 161);
            this.txtRSAKeyPrivate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRSAKeyPrivate.Name = "txtRSAKeyPrivate";
            this.txtRSAKeyPrivate.ReadOnly = true;
            this.txtRSAKeyPrivate.Size = new System.Drawing.Size(48, 23);
            this.txtRSAKeyPrivate.TabIndex = 73;
            // 
            // txtRSAKeyPublic
            // 
            this.txtRSAKeyPublic.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtRSAKeyPublic.Location = new System.Drawing.Point(576, 160);
            this.txtRSAKeyPublic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRSAKeyPublic.Name = "txtRSAKeyPublic";
            this.txtRSAKeyPublic.ReadOnly = true;
            this.txtRSAKeyPublic.Size = new System.Drawing.Size(49, 23);
            this.txtRSAKeyPublic.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 17);
            this.label1.TabIndex = 72;
            this.label1.Text = "Khóa [công khai, bí mật] = ";
            // 
            // btnRSAKey
            // 
            this.btnRSAKey.Location = new System.Drawing.Point(294, 158);
            this.btnRSAKey.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRSAKey.Name = "btnRSAKey";
            this.btnRSAKey.Size = new System.Drawing.Size(87, 28);
            this.btnRSAKey.TabIndex = 71;
            this.btnRSAKey.Text = "Sinh khóa";
            this.btnRSAKey.UseVisualStyleBackColor = true;
            this.btnRSAKey.Click += new System.EventHandler(this.btnRSAKey_Click);
            // 
            // txtRSA
            // 
            this.txtRSA.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRSA.Location = new System.Drawing.Point(24, 249);
            this.txtRSA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRSA.Multiline = true;
            this.txtRSA.Name = "txtRSA";
            this.txtRSA.Size = new System.Drawing.Size(679, 312);
            this.txtRSA.TabIndex = 6;
            // 
            // btnRSA
            // 
            this.btnRSA.Location = new System.Drawing.Point(24, 206);
            this.btnRSA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRSA.Name = "btnRSA";
            this.btnRSA.Size = new System.Drawing.Size(78, 36);
            this.btnRSA.TabIndex = 69;
            this.btnRSA.Text = "Xoá";
            this.btnRSA.UseVisualStyleBackColor = true;
            this.btnRSA.Click += new System.EventHandler(this.btnRSA_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(262, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 20);
            this.label10.TabIndex = 66;
            this.label10.Text = "]";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(184, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 29);
            this.label11.TabIndex = 67;
            this.label11.Text = ",";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(113, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 20);
            this.label12.TabIndex = 68;
            this.label12.Text = "[";
            // 
            // txtRSAQ
            // 
            this.txtRSAQ.Location = new System.Drawing.Point(209, 159);
            this.txtRSAQ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRSAQ.Name = "txtRSAQ";
            this.txtRSAQ.Size = new System.Drawing.Size(46, 23);
            this.txtRSAQ.TabIndex = 2;
            this.txtRSAQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRSAQ_KeyPress);
            // 
            // txtRSAP
            // 
            this.txtRSAP.Location = new System.Drawing.Point(132, 159);
            this.txtRSAP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRSAP.Name = "txtRSAP";
            this.txtRSAP.Size = new System.Drawing.Size(45, 23);
            this.txtRSAP.TabIndex = 1;
            this.txtRSAP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRSAP_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 17);
            this.label9.TabIndex = 63;
            this.label9.Text = "Nhập [ p , q ] =  ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(555, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 62;
            this.label5.Text = "Output";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 61;
            this.label6.Text = "Input";
            // 
            // btnRSADe
            // 
            this.btnRSADe.Location = new System.Drawing.Point(322, 94);
            this.btnRSADe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRSADe.Name = "btnRSADe";
            this.btnRSADe.Size = new System.Drawing.Size(87, 47);
            this.btnRSADe.TabIndex = 5;
            this.btnRSADe.Text = "Giải Mã";
            this.btnRSADe.UseVisualStyleBackColor = true;
            this.btnRSADe.Click += new System.EventHandler(this.btnRSADe_Click);
            // 
            // btnRSAEn
            // 
            this.btnRSAEn.Location = new System.Drawing.Point(322, 39);
            this.btnRSAEn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRSAEn.Name = "btnRSAEn";
            this.btnRSAEn.Size = new System.Drawing.Size(87, 47);
            this.btnRSAEn.TabIndex = 4;
            this.btnRSAEn.Text = "Mã Hóa";
            this.btnRSAEn.UseVisualStyleBackColor = true;
            this.btnRSAEn.Click += new System.EventHandler(this.btnRSAEn_Click);
            // 
            // txtRSAOutput
            // 
            this.txtRSAOutput.Location = new System.Drawing.Point(435, 43);
            this.txtRSAOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRSAOutput.Multiline = true;
            this.txtRSAOutput.Name = "txtRSAOutput";
            this.txtRSAOutput.Size = new System.Drawing.Size(269, 93);
            this.txtRSAOutput.TabIndex = 58;
            // 
            // txtRSAInput
            // 
            this.txtRSAInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRSAInput.Location = new System.Drawing.Point(24, 41);
            this.txtRSAInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRSAInput.Multiline = true;
            this.txtRSAInput.Name = "txtRSAInput";
            this.txtRSAInput.Size = new System.Drawing.Size(272, 93);
            this.txtRSAInput.TabIndex = 3;
            this.txtRSAInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRSAP_KeyPress);
            // 
            // frmRSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRSAKeyPrivate);
            this.Controls.Add(this.txtRSAKeyPublic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRSAKey);
            this.Controls.Add(this.txtRSA);
            this.Controls.Add(this.btnRSA);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtRSAQ);
            this.Controls.Add(this.txtRSAP);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRSADe);
            this.Controls.Add(this.btnRSAEn);
            this.Controls.Add(this.txtRSAOutput);
            this.Controls.Add(this.txtRSAInput);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmRSA";
            this.Size = new System.Drawing.Size(743, 581);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRSAKeyPrivate;
        private System.Windows.Forms.TextBox txtRSAKeyPublic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRSAKey;
        private System.Windows.Forms.TextBox txtRSA;
        private System.Windows.Forms.Button btnRSA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRSAQ;
        private System.Windows.Forms.TextBox txtRSAP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRSADe;
        private System.Windows.Forms.Button btnRSAEn;
        private System.Windows.Forms.TextBox txtRSAOutput;
        private System.Windows.Forms.TextBox txtRSAInput;
    }
}
