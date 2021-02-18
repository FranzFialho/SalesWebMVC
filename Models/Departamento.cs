using SalesWebMVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMVC.Models
{
    public class Departamento
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Departamento()
        {
        }

        public Departamento(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(x => x.TotalSales(initial, final));
        }

        public static implicit operator Departamento(DepartamentoService v)
        {
            throw new NotImplementedException();
        }
    }
}
