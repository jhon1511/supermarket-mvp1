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
    public partial class ProvidersView : Form, IProvidersView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string messaje;
        public ProvidersView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabControl1.TabPages.Remove(tabPageProvidersDetail);

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
        }

        public string ProviderId
        {
            get { return TxtProviId.Text; }
            set { TxtProviId.Text = value; }
        }
        public string ProviderName
        {
            get { return TxtProviName.Text; }
            set { TxtProviName.Text = value; }
        }
        public string ProviderObservation
        {
            get { return TxtProviObservation.Text; }
            set { TxtProviObservation.Text = value; }
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

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetProviderListBildingSource(BindingSource providerList)
        {
            DgProviders.DataSource = providerList;
        }

        private static ProvidersView instance;

        public static ProvidersView GetInstance(Form parenContainer)
        {

            if (instance == null || instance.IsDisposed)
            {
                instance = new ProvidersView();
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
