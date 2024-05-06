using store.Models;

namespace store.Services.Contract
{
    public interface IProduitService
    {
        Task<Product> GetProduit(int id);
        Task<IEnumerable<Product>> GetAllProduit();
        Task DeleteProduit(int id);
        Task AddProduit(Product produit);
        Task UpdateProduit(int id,Product newproduit);
    }
}
