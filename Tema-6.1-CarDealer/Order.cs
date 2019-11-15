using System;

namespace Tema_6._1_CarDealer
{
    class Order : IOrder
    {
        public IPerson Person { get; set; }
        public IVehicle Vehicle { get; set; }
        public DateTime DeliveryDate { get; set; }
    }
}
