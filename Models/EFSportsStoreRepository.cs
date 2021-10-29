using SportsStore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models {
	public class EFSportsStoreRepository : ISportsStoreRepository {
		private SportsStoreDbContext context;

		public EFSportsStoreRepository(SportsStoreDbContext context) {
			this.context = context;
		}

		public IEnumerable<Product> Products => context.Products;
	}
}
