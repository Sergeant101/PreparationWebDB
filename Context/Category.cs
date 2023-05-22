using Microsoft.EntityFrameworkCore;

namespace PracticalApps.Context
{
    internal class Category
    {
        public int CategoryID {get; set;}
        public string CategoryName {get; set;} = null!;
        public string Description {get; set;} = null!;

        public Category()
        {
            this.Products = new List<Product>{};
        }
        public virtual ICollection<Product> Products {get; set;} 
    }
}