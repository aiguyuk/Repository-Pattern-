using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepositoryPattern
{
    public partial class lblTotalRecords : Form
    {
        IProductRepository productRepository;
        public lblTotalRecords()
        {
            InitializeComponent();
        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            productRepository = new ProductRepository();
            DataGridView.DataSource = productRepository.GetProducts();
            lblTotalRecords.Text = $"Total records: {dataGridView.RowCount}";
        }
    }
}
