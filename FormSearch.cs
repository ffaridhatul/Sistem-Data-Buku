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
    public partial class FormSearch : Form
    {
        private DataBuku dataBuku;

        public FormSearch(DataBuku dataBuku)
        {
            InitializeComponent();
            this.dataBuku = dataBuku;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listBoxResults.Items.Clear();
            string searchQuery = txtSearch.Text.ToLower();

            var results = dataBuku.GetDaftarBuku()
                .Where(buku => buku.Judul.ToLower().Contains(searchQuery) || buku.Penulis.ToLower().Contains(searchQuery))
                .ToList();

            foreach (var buku in results)
            {
                listBoxResults.Items.Add($"{buku.Judul} - {buku.Penulis} - {buku.Penerbit} - {buku.TahunTerbit}");
            }

            if (results.Count == 0)
            {
                MessageBox.Show("Buku tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
