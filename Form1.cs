using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindAndSort04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        List<SanPham> listProduct = null;

        public void DisplayProduct()
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            listProduct = (from x in context.SanPhams
                           select x).ToList();
            lsvListProduct.Items.Clear();
            listProduct.ForEach(x =>
            {
                ListViewItem item = new ListViewItem(x.MaSP + "");
                item.SubItems.Add(x.TenSP);
                item.SubItems.Add(x.DonGia + "");
                lsvListProduct.Items.Add(item);
            });
        }

        public void DataProduct()
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            var dataProduct = (from i in context.SanPhams
                               select new
                               {
                                   i.MaSP,
                                   i.TenSP
                               }).ToList();
            dgvListProduct.DataSource = dataProduct;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayProduct();
            DataProduct();
        }

        private void lsvListProduct_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ColumnHeader column = lsvListProduct.Columns[e.Column];
            if (e.Column == 0)
            {
                if (column.Tag == null || column.Tag.ToString() == "des")
                {
                    listProduct = listProduct.OrderBy(x => x.MaSP).ToList();
                    column.Tag = "asc";
                }
                else
                {
                    listProduct = listProduct.OrderByDescending(x => x.MaSP).ToList();
                    column.Tag = "des";
                }
            }
            else if(e.Column == 1)
            {
                if(column.Tag == null || column.Tag.ToString() == "des")
                {
                    listProduct = listProduct.OrderBy(x => x.TenSP).ToList();
                    column.Tag = "asc";
                }
                else
                {
                    listProduct = listProduct.OrderByDescending(x => x.TenSP).ToList();
                    column.Tag = "des";
                }
            }
            else if(e.Column == 2)
            {
                if(column.Tag == null || column.Tag.ToString() == "des")
                {
                    listProduct = listProduct.OrderBy(x => x.DonGia).ToList();
                    column.Tag = "asc";
                }
                else
                {
                    listProduct = listProduct.OrderByDescending(x => x.DonGia).ToList();
                    column.Tag = "des";
                }
            }
            lsvListProduct.Items.Clear();
            listProduct.ForEach(x =>
            {
                ListViewItem item = new ListViewItem(x.MaSP + "");
                item.SubItems.Add(x.TenSP);
                item.SubItems.Add(x.DonGia + "");
                lsvListProduct.Items.Add(item);
            });
        }

        private void lsvListProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
