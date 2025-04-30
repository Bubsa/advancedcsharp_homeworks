using Statichki_Klasi.Entities.Helpers;

namespace Statichki_Klasi.Entities.Models
{
    public class User: BaseEntity
    {


        public string Username { get; set; }
        public string Address { get; set; }
        public List<Order> Orders { get; set; }


        public User(int id, string username, string address)
        {
            Id = id;
            Username = username;
            Address = address;

        }

        public void PrintOrders()
        {
            ConsoleHelper.WriteInColor("User's orders:/n", ConsoleColor.Blue);
            for (int i = 0; i < Orders.Count; i++)
            {
                Console.WriteLine($"{i+1}) {Orders[i].GetInfo()}");
            }
        }
    }
}
