using Events.Enums;

namespace Events.Models
{
    public class Market
    {

        // Ovde se kreira delegatot
        public delegate void PromotionHandler(ProductType productType);

        // Kako se kreira Event-ot
        private event PromotionHandler OnPromotionSent;

        public int Id { get; set; }
        public string Name { get; set; }
        public ProductType ProductType { get; set; }
        public List<string> SubscribersEmails { get; set; } = new List<string>();
        public List<string> Complaints { get; set; } = new List<string>();

        // Metoda za pretplata na promotion
        public void SubscribeForPromotion(PromotionHandler promotionHandler, string email)
        {
            OnPromotionSent += promotionHandler;
            SubscribersEmails.Add(email);
        }

        // Prakjanje na promotions
        public void SendPromotions()
        {
            Console.WriteLine("==================");
            Console.WriteLine($"{Name} is sending promotions for {ProductType}");
            Console.WriteLine("....Sending....");
            Thread.Sleep(3000); // Ceka 3 sekundi i posle pushta
            NotifySubscribers();
        }

        private void NotifySubscribers()
        {
            OnPromotionSent(ProductType);
        }

        // Metoda za trganje od predplata
        public void UnsubscribeFromPromotions(PromotionHandler promotionHandler, string reason)
        {
            OnPromotionSent -= promotionHandler;
            Complaints.Add(reason);
        }

        public void ReadComplaints()
        {
            Console.WriteLine($"{Name} Complaints:");
            foreach (string complaint in Complaints)
            {
                Console.WriteLine(complaint);
            }
        }
    }
}
