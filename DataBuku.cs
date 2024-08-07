using System.Collections.Generic;

namespace Mission002
{
    public class DataBuku
    {
        private List<Buku> daftarBuku = new List<Buku>();

        public void TambahBuku(Buku buku)
        {
            daftarBuku.Add(buku);
        }

        public void HapusBuku(Buku buku)
        {
            daftarBuku.Remove(buku);
        }

        public List<Buku> GetDaftarBuku()
        {
            return daftarBuku;
        }
    }

}
