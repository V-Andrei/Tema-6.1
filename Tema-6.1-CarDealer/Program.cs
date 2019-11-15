using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_6._1_CarDealer
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson serban = new Client { Name = "Serban" };

            IStore nissan = new Store("Nissan");
            IVehicle tida = new Vehicle
            {
                Name = "Tida",
                Price = 4688,
                Producer = new Producer { Name = "Nissan" }
            };

            IStore dacia = new Store("Dacia");
            IVehicle sandero = new Vehicle
            {
                Name = "Sandero",
                Price = 14000,
                Producer = new Producer { Name = "Dacia" }
            };

            IOrder focusOrder = nissan.EnterAndMakeOrder(serban, tida);

            IOrder skodaOrder = nissan.EnterAndMakeOrder(serban, sandero);

            if (focusOrder.DeliveryDate < skodaOrder.DeliveryDate)
            {
                dacia.CancelOrder(skodaOrder);
            }
            else
            {
                nissan.CancelOrder(focusOrder);
            }
        }

    }
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

    class Client : IPerson
    {
        public string Name { get; set; }
    }
    interface IOrder
    {
        IPerson Person { get; set; }
        IVehicle Vehicle { get; set; }
        DateTime DeliveryDate { get; set; }
    }

    class Order : IOrder
    {
        public IPerson Person { get; set; }
        public IVehicle Vehicle { get; set; }
        public DateTime DeliveryDate { get; set; }
    }
    interface IProducer
    {
        string Name { get; set; }
    }
    interface IStore
    {
        string Name { get; set; }

        IOrder EnterAndMakeOrder(IPerson person, IVehicle vehicle);

        void CancelOrder(IOrder order);
    }
    interface IPerson
    {
        string Name { get; set; }
    }
    class Vehicle : IVehicle
    {
        public IProducer Producer { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    interface IVehicle
    {
        IProducer Producer { get; set; }
        string Name { get; set; }
        decimal Price { get; set; }
    }
    class Producer : IProducer
    {
        public string Name { get; set; }
    }
}
