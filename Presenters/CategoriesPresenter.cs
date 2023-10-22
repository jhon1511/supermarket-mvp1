using Supermarket_mvp1.Models;
using Supermarket_mvp1.Views;

namespace Supermarket_mvp1.Presenters
{
    internal class CategoriesPresenter
    {
        private ICategoriesView view;
        private ICategoriesRepository repository;
        private BindingSource categorieBindingSource;
        private IEnumerable<CategoriesModel> categorieList;

        public CategoriesPresenter(ICategoriesView view, ICategoriesRepository repository)
        {
            this.categorieBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchCategorie;
            this.view.AddNewEvent += AddNewCategorie;
            this.view.EditEvent += LoadSelectCategorieToEdit;
            this.view.DeleteEvent += DeleteSelectedCategorie;
            this.view.SaveEvent += SaveCategorie;
            this.view.CancelEvent += CancelAction;

            this.view.SetCategorieListBildingSource(categorieBindingSource);
            LoadAllCategorieList();
            this.view.Show();
        }

        private void LoadAllCategorieList()
        {
            categorieList = repository.GetAll();
            categorieBindingSource.DataSource = categorieList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void CleanViewFields()
        {
            view.CategorieId = "0";
            view.CategorieName = "";
            view.CategorieObservation = "";
        }

        private void SaveCategorie(object? sender, EventArgs e)
        {
            var categorie = new CategoriesModel();
            categorie.Id = Convert.ToInt32(view.CategorieId);
            categorie.Name = view.CategorieName;
            categorie.Observation = view.CategorieObservation;

            try
            {
                new Common.ModelDataValidation().Validate(categorie);
                if (view.IsEdit)
                {
                    repository.Edit(categorie);
                    view.Message = "Categorie Edited Successfuly";
                }
                else
                {
                    repository.Add(categorie);
                    view.Message = "categorie added Successfuly";
                }
                view.IsSuccessful = true;

                CleanViewFields();
                LoadAllCategorieList();

            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An Error Ocurred, Could not delete categorie";
            }
        }

        private void DeleteSelectedCategorie(object? sender, EventArgs e)
        {
            try
            {
                var payMode = (PayModeModel)categorieBindingSource.Current;
                repository.Delete(payMode.Id);
                view.IsSuccessful = true;
                view.Message = "Categorie deleted succesfuly";
                LoadAllCategorieList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "A error ocurred, could not delete Categorie";
            }
        }

        private void LoadSelectCategorieToEdit(object? sender, EventArgs e)
        {
            var category = (CategoriesModel)categorieBindingSource.Current;

            view.CategorieId = category.Id.ToString();
            view.CategorieName = category.Name.ToString();
            view.CategorieObservation = category.Observation.ToString();
            view.IsEdit = true;
        }

        private void AddNewCategorie(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchCategorie(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                categorieList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                categorieList = repository.GetAll();
            }
            categorieBindingSource.DataSource = categorieList;
        }
    }
}
