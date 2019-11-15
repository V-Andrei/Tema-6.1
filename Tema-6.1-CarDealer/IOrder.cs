using System;

namespace Tema_6._1_CarDealer
{
    interface IOrder
    {
        IPerson Person { get; set; }
        IVehicle Vehicle { get; set; }
        DateTime DeliveryDate { get; set; }
    }
}
