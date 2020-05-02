using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Services;

namespace SalesWebMVC.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService; // declaração de dependência para a classe SellerService

        public SellersController(SellerService sellerService) // Construtor injeta a dependência
        {
            _sellerService = sellerService;
        }

        public IActionResult Index()
        {
            // variável recebe uma lista de objetos do sellerService e injeta na view
            var list = _sellerService.FindAll(); 
            return View(list);
        }
    }
}