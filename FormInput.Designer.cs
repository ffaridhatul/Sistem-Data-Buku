namespace Mission002
{
    partial class FormInput
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtJudul;
        private System.Windows.Forms.TextBox txtPenulis;
        private System.Windows.Forms.TextBox txtPenerbit;
        private System.Windows.Forms.TextBox txtTahunTerbit;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblPenulis;
        private System.Windows.Forms.Label lblPenerbit;
        private System.Windows.Forms.Label lblTahunTerbit;

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
            this.txtJudul = new System.Windows.Forms.TextBox();
            this.txtPenulis = new System.Windows.Forms.TextBox();
            this.txtPenerbit = new System.Windows.Forms.TextBox();
            this.txtTahunTerbit = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblPenulis = new System.Windows.Forms.Label();
            this.lblPenerbit = new System.Windows.Forms.Label();
            this.lblTahunTerbit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtJudul
            // 
            this.txtJudul.Location = new System.Drawing.Point(100, 30);
            this.txtJudul.Name = "txtJudul";
            this.txtJudul.Size = new System.Drawing.Size(150, 26);
            this.txtJudul.TabIndex = 1;
            // 
            // txtPenulis
            // 
            this.txtPenulis.Location = new System.Drawing.Point(100, 70);
            this.txtPenulis.Name = "txtPenulis";
            this.txtPenulis.Size = new System.Drawing.Size(150, 26);
            this.txtPenulis.TabIndex = 2;
            // 
            // txtPenerbit
            // 
            this.txtPenerbit.Location = new System.Drawing.Point(100, 110);
            this.txtPenerbit.Name = "txtPenerbit";
            this.txtPenerbit.Size = new System.Drawing.Size(150, 26);
            this.txtPenerbit.TabIndex = 3;
            // 
            // txtTahunTerbit
            // 
            this.txtTahunTerbit.Location = new System.Drawing.Point(100, 150);
            this.txtTahunTerbit.Name = "txtTahunTerbit";
            this.txtTahunTerbit.Size = new System.Drawing.Size(150, 26);
            this.txtTahunTerbit.TabIndex = 4;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(131, 196);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(84, 34);
            this.btnTambah.TabIndex = 5;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Location = new System.Drawing.Point(30, 33);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(47, 20);
            this.lblJudul.TabIndex = 6;
            this.lblJudul.Text = "Judul";
            // 
            // lblPenulis
            // 
            this.lblPenulis.AutoSize = true;
            this.lblPenulis.Location = new System.Drawing.Point(30, 73);
            this.lblPenulis.Name = "lblPenulis";
            this.lblPenulis.Size = new System.Drawing.Size(60, 20);
            this.lblPenulis.TabIndex = 7;
            this.lblPenulis.Text = "Penulis";
            // 
            // lblPenerbit
            // 
            this.lblPenerbit.AutoSize = true;
            this.lblPenerbit.Location = new System.Drawing.Point(30, 113);
            this.lblPenerbit.Name = "lblPenerbit";
            this.lblPenerbit.Size = new System.Drawing.Size(68, 20);
            this.lblPenerbit.TabIndex = 8;
            this.lblPenerbit.Text = "Penerbit";
            // 
            // lblTahunTerbit
            // 
            this.lblTahunTerbit.AutoSize = true;
            this.lblTahunTerbit.Location = new System.Drawing.Point(30, 153);
            this.lblTahunTerbit.Name = "lblTahunTerbit";
            this.lblTahunTerbit.Size = new System.Drawing.Size(98, 20);
            this.lblTahunTerbit.TabIndex = 9;
            this.lblTahunTerbit.Text = "Tahun Terbit";
            // 
            // FormInput
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblTahunTerbit);
            this.Controls.Add(this.lblPenerbit);
            this.Controls.Add(this.lblPenulis);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.txtTahunTerbit);
            this.Controls.Add(this.txtPenerbit);
            this.Controls.Add(this.txtPenulis);
            this.Controls.Add(this.txtJudul);
            this.Controls.Add(this.btnTambah);
            this.Name = "FormInput";
            this.Load += new System.EventHandler(this.FormInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
