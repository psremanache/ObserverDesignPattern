namespace ObserverDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ItemStore iphoneStore = new ItemStore("IPHONE");
            User bangloreUser = new User();
            User puneUser = new User();
            User kolkataUser = new User();
            bangloreUser.Subscribe(iphoneStore);
            puneUser.Subscribe(iphoneStore);
            kolkataUser.Subscribe(iphoneStore);
            ItemStore samsungStore = new ItemStore("Samsung");
            puneUser.Unsubscribe(iphoneStore);
            kolkataUser.Subscribe(samsungStore);
            puneUser.Subscribe(samsungStore);
            iphoneStore.UpdateData(25);
            samsungStore.UpdateData(14);
        }
    }
}