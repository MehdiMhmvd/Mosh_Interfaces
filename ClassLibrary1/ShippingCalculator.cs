using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class ShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f)
                return order.TotalPrice * .1f;
            return 0; // free shipping 
        }
    }
}
