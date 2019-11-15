namespace Tema_6._1_CarDealer
{
    interface IVehicle
    {
        IProducer Producer { get; set; }
        string Name { get; set; }
        decimal Price { get; set; }
    }
}
