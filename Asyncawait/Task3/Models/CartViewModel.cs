using System.Collections.Generic;

namespace Task3.Models
{
    public class CartViewModel
    {
        public IEnumerable<CartLine> Lines { get; set; }

        public decimal TotalSum { get; set; }

        public int TotalItems { get; set; }
    }
}
