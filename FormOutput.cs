using System;
using System.Windows.Forms;

namespace Mission002
{
    public partial class FormOutput : Form
    {
        private DataBuku dataBuku;

        public FormOutput(DataBuku dataBuku)
        {
            InitializeComponent();
            this.dataBuku = dataBuku;
            LoadDataBuku();
        }

        private void LoadDataBuku()
        {
            listBoxBuku.Items.Clear();
            foreach (var buku in dataBuku.GetDaftarBuku())
            {
                listBoxBuku.Items.Add($"{buku.Judul} - {buku.Penulis} - {buku.Penerbit} - {buku.TahunTerbit}");
            }
        }
    }
}
