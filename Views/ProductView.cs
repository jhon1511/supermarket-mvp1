using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp1.Views
{
    public partial class ProductView : Form, IProductView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string messaje;

        public ProductView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabControl1.TabPages.Remove(tabProductsDetail);

            BtnClose.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            TxtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            BtnNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabProductsList);
                tabControl1.TabPages.Add(tabProductsList);
                tabProductsList.Text = "Add New Pay Mode";
            };
            BtnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabProductsList);
                tabControl1.TabPages.Add(tabProductsList);
                tabProductsList.Text = "Edit Pay Mode";
            };
            BtnDelete.Click += delegate
            {
                var result = MessageBox.Show(
                    "Are you sure you want to delete the selected Pay Mode",
                    "Warning",
             MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
            BtnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {

                    tabControl1.TabPages.Remove(tabProductsList);
                    tabControl1.TabPages.Add(tabProductsList);

                }
                MessageBox.Show(Message);
            };
            BtnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabProductsList);
                tabControl1.TabPages.Add(tabProductsList);
            };
        }

        public string ProductId
        {
            get { return TxtProductId.Text; }
            set { TxtProductId.Text = value; }
        }
        public string ProductPrecio
        {
            get { return TxtProductPrice.Text; }
            set { TxtProductPrice.Text = value; }

        }
        public string ProductStock
        {
            get { return TxtProductStock.Text; }
            set { TxtProductStock.Text = value; }
        }
        public string ProductCategorie_Id 
        {
            get { return TxtProductCategorie.Text; }
            set { TxtProductCategorie.Text = value; }
        }
        public string SearchValue
        {
            get { return TxtSearch.Text; }
            set { TxtSearch.Text = value; }
        }
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        public string Message
        {
            get { return messaje; }
            set { messaje = value; }
        }

        public string ProductName {
            get { return TxtProductName.Text; }
            set { TxtProductName.Text = value; }
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetPayModeListBildingSource(BindingSource productList)
        {
            DgProducts.DataSource = productList;
        }
        private static ProductView instance;
        public static ProductView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProductView();
                instance.MdiParent = parentContainer;

                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }

        private void tabPagePayModeList_Click(object sender, EventArgs e)
        {

        }

        private void tabProductsDetail_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void SetProductListBildingSource(BindingSource payModeList)
        {
            throw new NotImplementedException();
        }
    }
}
