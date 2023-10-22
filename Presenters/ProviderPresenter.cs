using Supermarket_mvp1.Models;
using Supermarket_mvp1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp1.Presenters
{
    internal class ProviderPresenter
    {
        private IProvidersView view;
        private IProvidersRepository repository;
        private BindingSource providerBindingSource;
        private IEnumerable<ProvidersModel> providerList;

        public ProviderPresenter(IProvidersView view, IProvidersRepository repository)
        {
            this.providerBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProvider;
            this.view.AddNewEvent += AddNewProvider;
            this.view.EditEvent += LoadSelectProviderToEdit;
            this.view.DeleteEvent += DeleteSelectedProvider;
            this.view.SaveEvent += SaveProvider;
            this.view.CancelEvent += CancelAction;

            this.view.SetProviderListBildingSource(providerBindingSource);

            loadAllProviderList();

            this.view.Show();
        }

        private void DeleteSelectedProvider(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectProviderToEdit(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }
        private void CleanViewFields()
        {
            view.ProviderId = "0";
            view.ProviderName = "";
            view.ProviderObservation = "";
        }

        private void SaveProvider(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewProvider(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SearchProvider(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                providerList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                providerList = repository.GetAll();
            }
            providerBindingSource.DataSource = providerList;
        }

        private void loadAllProviderList()
        {
            providerList = repository.GetAll();
            providerBindingSource.DataSource = providerList;
        }
    }
}
