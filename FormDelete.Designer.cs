namespace Mission002
{
    partial class FormDelete
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.Button btnDelete;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(12, 15);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(180, 26);
            this.txtDelete.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(198, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 37);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Hapus";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FormDelete
            // 
            this.ClientSize = new System.Drawing.Size(299, 84);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtDelete);
            this.Name = "FormDelete";
            this.Text = "Hapus Buku";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
