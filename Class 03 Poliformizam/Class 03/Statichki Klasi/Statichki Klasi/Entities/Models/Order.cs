using Statichki_Klasi.Entities.Enums;
using Statichki_Klasi.Entities.Helpers;
namespace Statichki_Klasi.Entities.Models
{
    public class Order: BaseEntity
    {
        public string Title { get; set; }
        public string Description  { get; set; }
        public OrderStatus OrderStatus { get; set; }

        public Order(int id, string title, string description, OrderStatus status = OrderStatus.Processing)
        {
            Id = id;
            Title = title;
            Description = description;
            OrderStatus = status;
        }

        public string GetInfo()
        {
            return $"{TextHelper.CapitalizeFirstLetter(Title)} - {Description}";
        }
    }
}
