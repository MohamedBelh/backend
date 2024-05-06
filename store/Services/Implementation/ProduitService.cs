using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using store.Helper.Data;
using store.Models;
using store.Services.Contract;

namespace store.Services.Implementation
{
    public class ProduitService : IProduitService
    {
        private readonly StoreDbContext _context;
        public ProduitService(StoreDbContext context)
        {
            _context = context;
        }
        public async Task AddProduit(Product produit)
        {
            await _context.AddAsync(produit);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProduit(int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
              _context.Remove(product);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetAllProduit()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetProduit(int id)
        {
            return await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task UpdateProduit(int id, Product newproduit)
        {
            var productToModife = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
            productToModife.Name = newproduit.Name;
            productToModife.QuantiteProduitStock = newproduit.QuantiteProduitStock;
            productToModife.Image = newproduit.Image;
            productToModife.Description = newproduit.Description;

             _context.Products.Update(productToModife);
            await _context.SaveChangesAsync();

        }
    }
}
