﻿using Supermarket_mvp1._Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp1.Views
{
    internal interface IProductView
    {
        string ProductId { get; set; }
        string ProductName { get; set; }
        string ProductPrecio { get; set; }
        string ProductStock { get; set; }
        string ProductCategorie_Id { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetProductListBildingSource(BindingSource payModeList);
        void Show();
    }
}
