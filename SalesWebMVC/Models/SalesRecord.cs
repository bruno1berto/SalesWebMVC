using System;
using System.Collections.Generic;
<<<<<<< HEAD
=======
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models.Enums;
>>>>>>> 4413869995234d2d35b59dc65edf5747a909a520

namespace SalesWebMVC.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord()
        {
        }
<<<<<<< HEAD

=======
>>>>>>> 4413869995234d2d35b59dc65edf5747a909a520
        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
