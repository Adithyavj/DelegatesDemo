using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class ShoppingCartModel
    {
        public delegate void MentionDiscount(decimal subTotal); // Defining the delegate
        public List<ProductModel> Items { get; set; } = new List<ProductModel>();

        public decimal GenerateTotal(MentionDiscount mentionDiscount, // passing the delegate as parameter to the method
            Func<List<ProductModel>,decimal,decimal> calculateDiscountedTotal) 
        {
            decimal subTotal = Items.Sum(x => x.Price);

            mentionDiscount(subTotal); // calling the delegate

            return calculateDiscountedTotal(Items, subTotal); // This returns Total as output
        }
    }
}
