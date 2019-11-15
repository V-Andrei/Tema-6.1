using System;
using System.Collections.Generic;

namespace Tema_6._1_CarDealer
{
    class Store : IStore
    {
        private List<IOrder> Orders;

        public Store(string name)
        {
            this.Name = name;
            Orders = new List<IOrder>();
        }

        public string Name { get; set; }

        public void CancelOrder(IOrder order)
        {
            Console.WriteLine($"{order.Person.Name} cancel {order.Vehicle.Name}");

            Orders.Remove(order);
        }

        public IOrder EnterAndMakeOrder(IPerson person, IVehicle vehicle)
        {
            Console.WriteLine($"{person.Name} enter to {this.Name}");

            Console.WriteLine($"{person.Name} order {vehicle.Name}");

            var order = new Order
            {
                Person = person,
                Vehicle = vehicle,
                DeliveryDate = DateTime.Now
            };

            Orders.Add(order);

            return order;
        }
    }
}
