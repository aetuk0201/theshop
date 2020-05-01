using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _appDbContext;
        public ProductRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _appDbContext.Products
                                .Include(p => p.ProductType)
                                .Include(p => p.ProductBrand)
                                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _appDbContext.Products
                                        .Include(p => p.ProductType)
                                        .Include(p => p.ProductBrand)
                                        .ToListAsync();
        }
    }
}