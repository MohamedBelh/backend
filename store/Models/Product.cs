namespace store.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int QuantiteProduitStock { get; set; }
        public string Image { get; set; }  // a modifier 
    }
}
