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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(31, 206);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(78, 36);
            this.button5.TabIndex = 48;
            this.button5.Text = "Hiện";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(317, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 20);
            this.label10.TabIndex = 45;
            this.label10.Text = "]";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(239, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 29);
            this.label11.TabIndex = 46;
            this.label11.Text = ",";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(168, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 20);
            this.label12.TabIndex = 47;
            this.label12.Text = "[";
            // 
            // txtAffineKeyB
            // 
            this.txtAffineKeyB.Location = new System.Drawing.Point(264, 156);
            this.txtAffineKeyB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAffineKeyB.Name = "txtAffineKeyB";
            this.txtAffineKeyB.Size = new System.Drawing.Size(46, 23);
            this.txtAffineKeyB.TabIndex = 3;
            // 
            // txtAffineKeyA
            // 
            this.txtAffineKeyA.Location = new System.Drawing.Point(187, 156);
            this.txtAffineKeyA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAffineKeyA.Name = "txtAffineKeyA";
            this.txtAffineKeyA.Size = new System.Drawing.Size(45, 23);
            this.txtAffineKeyA.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 17);
            this.label9.TabIndex = 42;
            this.label9.Text = "Nhập khóa k  [ a , b ] =  ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(562, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 41;
            this.label5.Text = "Output";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 40;
            this.label6.Text = "Input";
            // 
            // btnAffineDe
            // 
            this.btnAffineDe.Location = new System.Drawing.Point(329, 94);
            this.btnAffineDe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAffineDe.Name = "btnAffineDe";
            this.btnAffineDe.Size = new System.Drawing.Size(87, 47);
            this.btnAffineDe.TabIndex = 5;
            this.btnAffineDe.Text = "Giải Mã";
            this.btnAffineDe.UseVisualStyleBackColor = true;
            this.btnAffineDe.Click += new System.EventHandler(this.btnAffineDe_Click);
            // 
            // btnAffineEn
            // 
            this.btnAffineEn.Location = new System.Drawing.Point(329, 39);
            this.btnAffineEn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAffineEn.Name = "btnAffineEn";
            this.btnAffineEn.Size = new System.Drawing.Size(87, 47);
            this.btnAffineEn.TabIndex = 4;
            this.btnAffineEn.Text = "Mã Hóa";
            this.btnAffineEn.UseVisualStyleBackColor = true;
            this.btnAffineEn.Click += new System.EventHandler(this.btnAffineEn_Click);
            // 
            // txtAffineOutput
            // 
            this.txtAffineOutput.Location = new System.Drawing.Point(442, 43);
            this.txtAffineOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAffineOutput.Multiline = true;
            this.txtAffineOutput.Name = "txtAffineOutput";
            this.txtAffineOutput.Size = new System.Drawing.Size(269, 93);
            this.txtAffineOutput.TabIndex = 6;
            // 
            // txtAffineInput
            // 
            this.txtAffineInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAffineInput.Location = new System.Drawing.Point(31, 41);
            this.txtAffineInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAffineInput.Multiline = true;
            this.txtAffineInput.Name = "txtAffineInput";
            this.txtAffineInput.Size = new System.Drawing.Size(272, 93);
            this.txtAffineInput.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(31, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(680, 318);
            this.dataGridView1.TabIndex = 7;
            // 
            // frmAffine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAffine";
            this.Size = new System.Drawing.Size(743, 581);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
