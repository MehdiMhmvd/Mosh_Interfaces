using System;

namespace ClassLibrary1
{
    public class MainProgram
    {
        var orderProcessor = new OrderProcessor();
        var order = new Order
        {
            DatePlaces = DateTime.Now,
            TotalPrice - 100f;

        }
        orderProcessor.Process(order);

    }
}
