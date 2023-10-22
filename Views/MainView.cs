namespace Supermarket_mvp1.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();

            
            BtnPayMode.Click += delegate { ShowPayModeView?.Invoke(this, EventArgs.Empty); };
            BtnCategorie.Click += delegate { ShowCategorieView?.Invoke(this, EventArgs.Empty); };
            BtnProviders.Click += delegate { ShowProvidersView?.Invoke(this, EventArgs.Empty); };
            BtnProducts.Click += delegate { ShowProvidersView?.Invoke(this, EventArgs.Empty); };

            BtnExit.Click += delegate { this.Close(); };


        }
        public event EventHandler ShowPayModeView;
        public event EventHandler ShowProdctView;
        public event EventHandler ShowCustomerView;
        public event EventHandler ShowProductView;
        public event EventHandler ShowCategorieView;
        public event EventHandler ShowProvidersView;
        public event EventHandler ShowProductsView;

        private void BtnPayMode_Click(object sender, EventArgs e)
        {

        }
    }
}
