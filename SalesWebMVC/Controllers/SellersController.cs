using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;
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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost] // Anotation: Define o método como do tipo html post
        [ValidateAntiForgeryToken] // Previne contra ataques CSRF -> https://docs.microsoft.com/en-us/aspnet/core/security/anti-request-forger
        public IActionResult Create(Seller seller)
        {
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }
    }
}