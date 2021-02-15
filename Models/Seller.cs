using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SalesWebMVC.Models
{
    public class Seller
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} Obrigatório")]
        [Display(Name = "Vendedor")]
        [StringLength(60,MinimumLength = 3,ErrorMessage ="{0} inválido, tamanho do nome deve ser de {1} a {2} caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} Obrigatório")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage ="Digite um E-mail válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} Obrigatório")]
        [Display(Name = "Nascimento")] [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyy}")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "{0} Obrigatório")]
        [Range(1000.0, 50000.0, ErrorMessage ="{0} deve ser entre {1} a {2}")]
        [Display(Name = "Salário Base")]
        [DisplayFormat(DataFormatString ="{0:F2}")]
        public double BaseSalary { get; set; }

        public Departamento Departamento { get; set; }

        [Display(Name ="ID Departamento")]
        public int DepartamentoId { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

     
        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Departamento department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Departamento = department;
         
        }

        public Seller()
        {
        }


        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }
        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(x => x.Date >= initial && x.Date <= final).Sum(x => x.Amount);
        }

    }
}
