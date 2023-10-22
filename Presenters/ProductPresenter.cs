using Supermarket_mvp1.Models;
using Supermarket_mvp1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp1.Presenters
{
    internal class ProductPresenter
    {
        private IProductView view;
        private IProductRepository repository;
        private BindingSource productBindingSource;
        private IEnumerable<ProductModel> productsList;

        public ProductPresenter(IProductView view, IProductRepository repository)
        {
            this.productBindingSource = new BindingSource();   
            
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProduct;
            this.view.AddNewEvent += AddNewproduct;
            this.view.EditEvent += LoadSelectproductToEdit;
            this.view.DeleteEvent += DeleteSelectedproduct;
            this.view.SaveEvent += Saveproduct;
            this.view.CancelEvent += CancelAction;

            this.view.SetProductListBildingSource(productBindingSource);

            loadAllProductList();

            this.view.Show();
        }

        private void loadAllProductList()
        {
            productsList = repository.GetAll();
            productBindingSource.DataSource = productsList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }
        private void CleanViewFields()
        {
            view.ProductId = "0";
            view.ProductName = "";
            view.ProductPrecio = "";
            view.ProductStock = "0";
            view.ProductCategorie_Id = "0";
        }
        private void Saveproduct(object? sender, EventArgs e)
        {
            var product = new ProductModel();
            product.Id = Convert.ToInt32(view.ProductId);
            product.Name = view.ProductName;
            product.Price = Convert.ToInt32(view.ProductPrecio);
            product.Stock = Convert.ToInt32(view.ProductStock);
            product.Categorie_Id = Convert.ToInt32(view.ProductCategorie_Id);
            try
            {
                new Common.ModelDataValidation().Validate(product);
                if (view.IsEdit)
                {
                    repository.Edit(product);
                    view.Message = "PayMode Edited Successfuly";
                }
                else
                {
                    repository.Add(product);
                    view.Message = "PayMode added Successfuly";
                }
                view.IsSuccessful = true;

                CleanViewFields();
                loadAllProductList();

            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An Error Ocurred, Could not delete pay mode";
            }
        }

        private void DeleteSelectedproduct(object? sender, EventArgs e)
        {
            try
            {
                var product = (ProductModel)productBindingSource.Current;
                repository.Delete(product.Id);
                view.IsSuccessful = true;
                view.Message = "Pay Mode deleted succesfuly";
                loadAllProductList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "A error ocurred, could not delete paymode";
            }
        }

        private void LoadSelectproductToEdit(object? sender, EventArgs e)
        {
            var product = (ProductModel)productBindingSource.Current;

            view.ProductId = product.Id.ToString();
            view.ProductName = product.Name;
            view.ProductPrecio = product.Price.ToString();
            view.ProductStock = product.Stock.ToString();
            view.ProductCategorie_Id = product.Categorie_Id.ToString();

            view.IsEdit = true;
        }

        private void AddNewproduct(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchProduct(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                productsList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                productsList = repository.GetAll();
            }
            productBindingSource.DataSource = productsList;
        }
    }
}
