using Supermarket_mvp1.Models;
using Supermarket_mvp1.Views;
using System.ComponentModel.DataAnnotations;


namespace Supermarket_mvp1.Presenters
{
    internal class PayModePresenter
    {
        private IPayModeView view;
        private IPayModeRepository repository;
        private BindingSource payModeBindingSource;
        private IEnumerable<PayModeModel> payModeList;

        public PayModePresenter(IPayModeView view, IPayModeRepository repository)
        {

            this.payModeBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchPayMode;
            this.view.AddNewEvent += AddNewPayMode;
            this.view.EditEvent += LoadSelectPayModeToEdit;
            this.view.DeleteEvent += DeleteSelectedPayMode;
            this.view.SaveEvent += SavePayMode;
            this.view.CancelEvent += CancelAction;

            this.view.SetPayModeListBildingSource(payModeBindingSource);

            loadAllPayModeList();

            this.view.Show();

        }

        private void loadAllPayModeList()
        {
            //throw new NotImplementedException();
            payModeList = repository.GetAll();
            payModeBindingSource.DataSource = payModeList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SavePayMode(object? sender, EventArgs e)
        {
            
            var payMode = new PayModeModel();
            payMode.Id = Convert.ToInt32(view.PayModeId);
            payMode.Name = view.PayModeName;
            payMode.Observation = view.PayModeObservation;
            //MessageBox.Show("Hizo clic en el boton guardar");

            try
            {
                new Common.ModelDataValidation().Validate(payMode);
                if (view.IsEdit)
                {
                    repository.Edit(payMode);
                    view.Message = "PayMode Edited Successfuly";
                }
                else
                {
                    repository.Add(payMode);
                    view.Message = "PayMode add Successfuly";
                }
                view.IsSuccessful = true;
                loadAllPayModeList();
                CleanViewFields();

            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An Error Ocurred, Could not delete pay mode";
            }
        }  
            //bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            //if (emptyValue)
            //{
            //    payModeList = repository.GetByValue(this.view.SearchValue);
            //}
            //else
            //{
            //    payModeList = repository.GetAll();
            //}
            //payModeBindinSource.DataSource = payModeList;
            //}

            //private BindingSource payModeBindinSource;
            //private IEnumerable<PayModeModel> payModeList;
        
        private void CleanViewFields()
        {
            view.PayModeId = "0";
            view.PayModeName = "";
            view.PayModeObservation = "";
        }

        private void DeleteSelectedPayMode(object? sender, EventArgs e)
        {
            try
            {
                var payMode = (PayModeModel)payModeBindingSource.Current;
                repository.Delete(payMode.Id);
                view.IsSuccessful = true;
                view.Message = "Pay Mode deleted succesfuly";
                loadAllPayModeList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "A error ocurred, could not delete paymode";
            }
        }

        private void LoadSelectPayModeToEdit(object? sender, EventArgs e)
        {
            var payMode = (PayModeModel)payModeBindingSource.Current;

            view.PayModeId = payMode.Id.ToString();
            view.PayModeName = payMode.Name;
            view.PayModeObservation = payMode.Observation;

            view.IsEdit = true;
            MessageBox.Show("Va a Editar");
        }

        private void AddNewPayMode(object? sender, EventArgs e)
        {
            //MessageBox.Show("Hizo clic en el boton nuevo");
            view.IsEdit = false;
        }

        private void SearchPayMode(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                payModeList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                payModeList = repository.GetAll();
            }
            payModeBindingSource.DataSource = payModeList;
        }

        //private BindingSource payModeBindinSource;
        //private IEnumerable<PayModeModel> payModeList;
         
    }
}
