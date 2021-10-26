using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Controllers {
	public class ProductController : Controller {
		private ISportsStoreRepository repository;

		public ProductController(ISportsStoreRepository repository) {
			this.repository = repository;
		}

		public IActionResult Index() {
			return View(repository.Products);
		}
	}
}
