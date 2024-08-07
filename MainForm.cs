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
    public partial class MainForm : Form
    {
        private DataBuku dataBuku = new DataBuku();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var formInput = new FormInput(dataBuku);
            formInput.ShowDialog();

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var formOutput = new FormOutput(dataBuku);
            formOutput.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var formSearch = new FormSearch(dataBuku);
            formSearch.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var formDelete = new FormDelete(dataBuku);
            formDelete.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
