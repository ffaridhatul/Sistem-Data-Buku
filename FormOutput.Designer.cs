namespace Mission002
{
    partial class FormOutput
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxBuku;

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
            this.listBoxBuku = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxBuku
            // 
            this.listBoxBuku.FormattingEnabled = true;
            this.listBoxBuku.Location = new System.Drawing.Point(12, 12);
            this.listBoxBuku.Name = "listBoxBuku";
            this.listBoxBuku.Size = new System.Drawing.Size(260, 238);
            this.listBoxBuku.TabIndex = 0;
            // 
            // FormOutput
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.listBoxBuku);
            this.Name = "FormOutput";
            this.Text = "Daftar Buku";
            this.ResumeLayout(false);
        }
    }
}
