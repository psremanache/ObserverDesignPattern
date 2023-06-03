namespace ObserverDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPhoneStore iphoneStore = new IPhoneStore();
            User user1 = new User();
            User user2 = new User();
            User user3 = new User();
            user1.Subscribe(iphoneStore);
            user2.Subscribe(iphoneStore);
            user3.Subscribe(iphoneStore);
            user2.Unsubscribe(iphoneStore);
            iphoneStore.UpdateData(10);
        }
    }
}