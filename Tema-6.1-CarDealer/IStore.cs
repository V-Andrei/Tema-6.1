namespace Tema_6._1_CarDealer
{
    interface IStore
    {
        string Name { get; set; }

        IOrder EnterAndMakeOrder(IPerson person, IVehicle vehicle);

        void CancelOrder(IOrder order);
    }
}
