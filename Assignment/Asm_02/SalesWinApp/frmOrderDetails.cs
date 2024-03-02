using BusinessObject.Models;
using System.Data;

namespace SalesWinApp
{
    public partial class frmOrderDetails : Form
    {
        public List<OrderDetail> orderDetailsList { get; set; } = new List<OrderDetail>();
        public frmOrderDetails()
        {
            InitializeComponent();
            RaiseEvent();
        }
        private void RaiseEvent() { this.Load += frmOrderDetails_Load; }

        private void frmOrderDetails_Load(object sender, EventArgs e)
        {
            if (orderDetailsList.Count == 0) { return; }

            var datasource = orderDetailsList.Select(od => new
            {
                ProductName = od.Product.ProductName,
                UnitPrice = od.UnitPrice,
                Quantity = od.Quantity,
                Discount = od.Discount
            }).ToList();

            dgvOrderProducts.DataSource = null;
            dgvOrderProducts.DataSource = datasource;
        }
    }
}
