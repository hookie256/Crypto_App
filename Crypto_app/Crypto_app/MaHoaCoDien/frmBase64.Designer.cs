namespace Crypto_app.MaHoaCoDien
{
    partial class frmBase64
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
            this.btnProcess = new System.Windows.Forms.Button();
            this.txbDecode = new System.Windows.Forms.TextBox();
            this.txbEncode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.plainText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProcess
            // 
            this.btnProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.Location = new System.Drawing.Point(193, 123);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(177, 37);
            this.btnProcess.TabIndex = 15;
            this.btnProcess.Text = "Mã hóa";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // txbDecode
            // 
            this.txbDecode.Location = new System.Drawing.Point(137, 295);
            this.txbDecode.Multiline = true;
            this.txbDecode.Name = "txbDecode";
            this.txbDecode.Size = new System.Drawing.Size(367, 84);
            this.txbDecode.TabIndex = 14;
            // 
            // txbEncode
            // 
            this.txbEncode.Location = new System.Drawing.Point(137, 182);
            this.txbEncode.Multiline = true;
            this.txbEncode.Name = "txbEncode";
            this.txbEncode.Size = new System.Drawing.Size(367, 84);
            this.txbEncode.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Text đã giải mã: ";
            // 
            // plainText
            // 
            this.plainText.Location = new System.Drawing.Point(137, 19);
            this.plainText.Multiline = true;
            this.plainText.Name = "plainText";
            this.plainText.Size = new System.Drawing.Size(367, 84);
            this.plainText.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Text đã mã hóa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Text đầu vào:";
            // 
            // frmBase64
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.txbDecode);
            this.Controls.Add(this.txbEncode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.plainText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBase64";
            this.Size = new System.Drawing.Size(518, 392);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TextBox txbDecode;
        private System.Windows.Forms.TextBox txbEncode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox plainText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
