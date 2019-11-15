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
}
