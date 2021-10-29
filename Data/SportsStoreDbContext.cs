using Microsoft.EntityFrameworkCore;
using SportsStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Data {
	public class SportsStoreDbContext : DbContext {
		public SportsStoreDbContext(DbContextOptions<SportsStoreDbContext> options) : base(options) {
		}

		public DbSet<Product> Products { get; set; }
	}
}
