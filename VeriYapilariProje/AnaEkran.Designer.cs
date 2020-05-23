namespace VeriYapilariProje
{
    partial class AnaEkran
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
            this.btnIsyeriForm = new System.Windows.Forms.Button();
            this.btnKisiForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIsyeriForm
            // 
            this.btnIsyeriForm.BackColor = System.Drawing.Color.White;
            this.btnIsyeriForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIsyeriForm.Font = new System.Drawing.Font("Bahamas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIsyeriForm.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIsyeriForm.Location = new System.Drawing.Point(34, 85);
            this.btnIsyeriForm.Name = "btnIsyeriForm";
            this.btnIsyeriForm.Size = new System.Drawing.Size(156, 93);
            this.btnIsyeriForm.TabIndex = 0;
            this.btnIsyeriForm.Text = "İşyeri Giriş";
            this.btnIsyeriForm.UseVisualStyleBackColor = false;
            this.btnIsyeriForm.Click += new System.EventHandler(this.btnIsyeriForm_Click);
            // 
            // btnKisiForm
            // 
            this.btnKisiForm.BackColor = System.Drawing.Color.White;
            this.btnKisiForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKisiForm.Font = new System.Drawing.Font("Bahamas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKisiForm.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKisiForm.Location = new System.Drawing.Point(244, 85);
            this.btnKisiForm.Name = "btnKisiForm";
            this.btnKisiForm.Size = new System.Drawing.Size(153, 93);
            this.btnKisiForm.TabIndex = 1;
            this.btnKisiForm.Text = "Kişi Giriş";
            this.btnKisiForm.UseVisualStyleBackColor = false;
            this.btnKisiForm.Click += new System.EventHandler(this.btnKisiForm_Click);
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(460, 261);
            this.Controls.Add(this.btnKisiForm);
            this.Controls.Add(this.btnIsyeriForm);
            this.Name = "AnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İnsan Kaynakları Bilgi Sistemi -Giriş";
            this.Load += new System.EventHandler(this.AnaEkran_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIsyeriForm;
        private System.Windows.Forms.Button btnKisiForm;
    }
}