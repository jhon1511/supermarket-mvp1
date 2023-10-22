using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp1.Models
{
    internal class ProductModel
    {
        [DisplayName("Product Id")]
        public int Id { get; set; }

        [DisplayName("Product Name")]
        [Required(ErrorMessage = "Pay mode name is required")]
        [StringLength(50, MinimumLength = 3,
        ErrorMessage = "Product name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [DisplayName("Observacion")]
        [Required(ErrorMessage = "Pay mode observacion is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage =
        "Product observation must be between 3 and 200 characters")]
        public string Observation { get; set; }

        [DisplayName("Product Price")]
        public int Price { get; set; }

        [DisplayName("Product Stock")]
        public int Stock { get; set; }

        [DisplayName("Product Categorie_Id")]
        public int Categorie_Id { get; set; }



    }
}
