using System;
using System.Collections.Generic;


namespace SalesWebMVC.Models.ViewModels
{
    public class SellerFormViewModel
    {

        public Seller Seller { get; set; }
        public ICollection<Departamento> Departamentos { get; set; }
    }
}
