using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class OrderProcessor
    {
        private ShippingCalculator _shippingCalculator;
        public OrderProcessor()
        {
            _shippingCalculator = new ShippingCalculator();

        }

        public void Process(Order order)
        {
            if (order.IsShipped)
                throw new InvalidOperationException("this order has already process");
            order.Shipment = new Shipment
            {
                cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            }
        }
    }
}
