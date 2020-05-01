using System;
using System.Collections.Generic;
using System.Linq;
<<<<<<< HEAD
=======
using System.Threading.Tasks;
>>>>>>> 4413869995234d2d35b59dc65edf5747a909a520

namespace SalesWebMVC.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
<<<<<<< HEAD
        public Department Department { get; set; }
=======
        public Departments Department { get; set; }
>>>>>>> 4413869995234d2d35b59dc65edf5747a909a520
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }
<<<<<<< HEAD

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
=======
        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Departments department)
>>>>>>> 4413869995234d2d35b59dc65edf5747a909a520
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }
        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }
<<<<<<< HEAD
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sl => sl.Date >= initial && sl.Date <= final).Sum(sl => sl.Amount);
=======

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
>>>>>>> 4413869995234d2d35b59dc65edf5747a909a520
        }
    }
}
