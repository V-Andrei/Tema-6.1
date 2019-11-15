namespace Tema_6._1_CarDealer
{
    class Vehicle : IVehicle
    {
        public IProducer Producer { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
