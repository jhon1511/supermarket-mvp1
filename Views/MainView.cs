namespace Supermarket_mvp1.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            BtnPayMode.Click += delegate { ShowPayModeView?.Invoke(this, EventArgs.Empty); };

            //BtnExit.Click += delegate { this.Close(); };
        }
        public event EventHandler ShowPayModeView;
        public event EventHandler ShowProdctView;
        public event EventHandler ShowCustomerView;
        public event EventHandler ShowProductView;


    }
}
