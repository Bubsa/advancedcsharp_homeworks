using Events.Enums;
using Events.Models;

Console.WriteLine("\n=================SUPER MARKET ==================\n");

Market market = new Market
{
    Id = 1,
    Name = "Super Market",
    ProductType = ProductType.Electronics
};

User user1 = new User(1, "Bob Bobsky", "bob@email.com", 32, ProductType.Electronics);
User user2 = new User(2, "John Doe", "john@email.com", 23, ProductType.Cosmetics);
User user3 = new User(3, "Jane Doe", "jane@email.com", 22, ProductType.Food);

market.SubscribeForPromotion(user1.ReadPromotion, user1.Email);
market.SubscribeForPromotion(user2.ReadPromotion, user2.Email);
market.SubscribeForPromotion(user3.ReadPromotion, user3.Email);

market.SendPromotions();

Console.WriteLine("========================");

market.UnsubscribeFromPromotions(user1.ReadPromotion, "I don't wun it");

market.SendPromotions();
market.ReadComplaints();