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

        public decimal GenerateTotal(MentionDiscount mentionDiscount) // passing the delegate as parameter to the method
        {
            decimal subTotal = Items.Sum(x => x.Price);

            mentionDiscount(subTotal); // calling the delegate

            if (subTotal > 100)
            {
                return subTotal * 0.80M; // 20% discount
            }
            else if (subTotal > 50)
            {
                return subTotal * 0.85M; // 15% discount
            }
            else if (subTotal > 10)
            {
                return subTotal * 0.90M; // 10% discount
            }
            else
            {
                return subTotal;
            }
        }
    }
}
