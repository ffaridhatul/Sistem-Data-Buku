using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mission002
{
    public partial class FormInput : Form
    {
        private DataBuku dataBuku;

        public FormInput(DataBuku dataBuku)
        {
            InitializeComponent();
            this.dataBuku = dataBuku;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            string judul = txtJudul.Text;
            string penulis = txtPenulis.Text;
            string penerbit = txtPenerbit.Text;
            int tahunTerbit;

            if (!int.TryParse(txtTahunTerbit.Text, out tahunTerbit))
            {
                MessageBox.Show("Tahun terbit harus berupa angka.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Buku buku = new Buku { Judul = judul, Penulis = penulis, Penerbit = penerbit, TahunTerbit = tahunTerbit };
            dataBuku.TambahBuku(buku);
            MessageBox.Show("Data buku berhasil ditambahkan.");
            Close();
        }

        private void FormInput_Load(object sender, EventArgs e)
        {

        }
    }
}
