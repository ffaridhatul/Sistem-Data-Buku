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
    public partial class FormDelete : Form
    {
        private DataBuku dataBuku;

        public FormDelete(DataBuku dataBuku)
        {
            InitializeComponent();
            this.dataBuku = dataBuku;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string deleteQuery = txtDelete.Text.ToLower();

            var bookToDelete = dataBuku.GetDaftarBuku()
                .FirstOrDefault(buku => buku.Judul.ToLower().Contains(deleteQuery) || buku.Penulis.ToLower().Contains(deleteQuery));

            if (bookToDelete != null)
            {
                dataBuku.HapusBuku(bookToDelete);
                MessageBox.Show("Buku berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Buku tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
