namespace sslDataTextBox
{
    partial class ucDataInformation
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
            this.lblHeader = new DevExpress.XtraEditors.LabelControl();
            this.meContext = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.meContext.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Appearance.Options.UseFont = true;
            this.lblHeader.Location = new System.Drawing.Point(13, 13);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(85, 16);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "labelControl1";
            // 
            // meContext
            // 
            this.meContext.Location = new System.Drawing.Point(13, 35);
            this.meContext.Name = "meContext";
            this.meContext.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.meContext.Properties.Appearance.Options.UseBackColor = true;
            this.meContext.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.meContext.Size = new System.Drawing.Size(392, 148);
            this.meContext.TabIndex = 1;
            // 
            // ucDataInformation
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.meContext);
            this.Controls.Add(this.lblHeader);
            this.Name = "ucDataInformation";
            this.OptionsBeakPanel.BackColor = System.Drawing.Color.White;
            this.Size = new System.Drawing.Size(418, 199);
            ((System.ComponentModel.ISupportInitialize)(this.meContext.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblHeader;
        private DevExpress.XtraEditors.MemoEdit meContext;
    }
}
