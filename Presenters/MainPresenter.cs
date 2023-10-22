﻿using Supermarket_mvp1._Repositories;
using Supermarket_mvp1.Models;
using Supermarket_mvp1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp1.Presenters
{
    internal class MainPresenter
    {
        private readonly IMainView mainView;
        private readonly string sqlConnectionString;
        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;

            this.mainView.ShowPayModeView += ShowPayModeView;
            this.mainView.ShowCategorieView += ShowCategorieView;
        }

        private void ShowCategorieView(object? sender, EventArgs e)
        {
            ICategoriesView view = CategoriesView.GetInstance((MainView)mainView);
            ICategoriesRepository repository = new CategoriesRepository(sqlConnectionString);
            new CategoriesPresenter(view, repository);
        }

        private void ShowPayModeView(object? sender, EventArgs e)
        {
            IPayModeView view = PayModeView.GetInstance((MainView)mainView);
            //.GetInstance((MainView)mainView);
            IPayModeRepository repository = new PayModeRepository(sqlConnectionString);
            new PayModePresenter(view, repository);
        }
    }
}
