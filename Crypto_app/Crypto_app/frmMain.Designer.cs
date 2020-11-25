namespace Crypto_app
{
    partial class frmMain
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
            this.panel = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.MaHoaCoDien = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Hill = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Affine = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Base64 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.MaHoaHienDai = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.DES = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.RSA = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.panel.Appearance.Options.UseBackColor = true;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(232, 39);
            this.panel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(750, 587);
            this.panel.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.AccordionControl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.AccordionControl.Options.UseFont = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.MaHoaCoDien,
            this.MaHoaHienDai});
            this.accordionControl1.Location = new System.Drawing.Point(0, 39);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(232, 587);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // MaHoaCoDien
            // 
            this.MaHoaCoDien.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.Hill,
            this.Affine,
            this.Base64});
            this.MaHoaCoDien.Expanded = true;
            this.MaHoaCoDien.Name = "MaHoaCoDien";
            this.MaHoaCoDien.Text = "Mã hóa cổ điển";
            // 
            // Hill
            // 
            this.Hill.Name = "Hill";
            this.Hill.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Hill.Text = "Hill";
            this.Hill.Click += new System.EventHandler(this.Hill_Click);
            // 
            // Affine
            // 
            this.Affine.Name = "Affine";
            this.Affine.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Affine.Text = "Affine";
            this.Affine.Click += new System.EventHandler(this.Affine_Click);
            // 
            // Base64
            // 
            this.Base64.Name = "Base64";
            this.Base64.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Base64.Text = "Base64";
            this.Base64.Click += new System.EventHandler(this.Base64_Click);
            // 
            // MaHoaHienDai
            // 
            this.MaHoaHienDai.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.DES,
            this.RSA});
            this.MaHoaHienDai.Expanded = true;
            this.MaHoaHienDai.Name = "MaHoaHienDai";
            this.MaHoaHienDai.Text = "Mã hóa hiện đại";
            // 
            // DES
            // 
            this.DES.Name = "DES";
            this.DES.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.DES.Text = "DES";
            this.DES.Click += new System.EventHandler(this.DES_Click);
            // 
            // RSA
            // 
            this.RSA.Name = "RSA";
            this.RSA.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.RSA.Text = "RSA";
            this.RSA.Click += new System.EventHandler(this.RSA_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(982, 39);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 626);
            this.ControlContainer = this.panel;
            this.Controls.Add(this.panel);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.NavigationControl = this.accordionControl1;
            this.Text = "PHẦN MỀM KIỂM THỬ MÃ HÓA";
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer panel;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement MaHoaCoDien;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Hill;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Affine;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Base64;
        private DevExpress.XtraBars.Navigation.AccordionControlElement MaHoaHienDai;
        private DevExpress.XtraBars.Navigation.AccordionControlElement DES;
        private DevExpress.XtraBars.Navigation.AccordionControlElement RSA;
    }
}

