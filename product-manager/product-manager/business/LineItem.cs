using System;
using System.Collections.Generic;
using System.Text;

namespace product_manager.business
{
    class LineItem
    {
        public Product product { get; set; }
        public int quantity { get; set; }
        public LineItem()
        {

        }

        public LineItem(Product product, int quantity)
        {
            this.product = product;
            this.quantity = quantity;
        }

    }

}
