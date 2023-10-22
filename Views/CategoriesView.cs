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
    public partial class CategoriesView : Form, ICategoriesView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string messaje;
        public CategoriesView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabCategorieDetail);

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

                tabControl1.TabPages.Remove(tabCategorieList);
                tabControl1.TabPages.Add(tabCategorieDetail);
                tabCategorieDetail.Text = "Add New Categorie";

            };
            BtnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabCategorieList);
                tabControl1.TabPages.Add(tabCategorieDetail);
                tabCategorieDetail.Text = "Edit Pay Mode";

            };
            BtnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);

                if (isSuccessful)
                {

                    tabControl1.TabPages.Remove(tabCategorieDetail);
                    tabControl1.TabPages.Add(tabCategorieList);


                }
                MessageBox.Show(Message);

            };

            BtnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabCategorieDetail);
                tabControl1.TabPages.Add(tabCategorieList);

            };
            BtnDelete.Click += delegate
            {
                var result = MessageBox.Show(
                    "Are you sure you want to delete the selected Categorie",
                    "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }

            };
        }

        public string CategorieId
        {
            get { return TxtCategorieModeId.Text; }
            set { TxtCategorieModeId.Text = value; }
        }
        public string CategorieName
        {
            get { return TxtPayCategorieName.Text; }
            set { TxtPayCategorieName.Text = value; }
        }
        public string PayModeObservation
        {
            get { return TxtCategorieObservation.Text; }
            set { TxtCategorieObservation.Text = value; }
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

        public string CategorieObservation
        {
            get { return messaje; }
            set { messaje = value; }
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetPayModeListBildingSource(BindingSource CategoriesList)
        {
            DgCategorie.DataSource = CategoriesList;
        }

        public void SetCategorieListBildingSource(BindingSource CategoriesList)
        {
            DgCategorie.DataSource = CategoriesList;
        }
        private static CategoriesView instance;
        public static CategoriesView GetInstance(Form parenContainer)
        {

            if (instance == null || instance.IsDisposed)
            {
                instance = new CategoriesView();
                instance.MdiParent = parenContainer;

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
    }
}
