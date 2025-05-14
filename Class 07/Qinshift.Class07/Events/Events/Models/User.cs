﻿using Events.Enums;

namespace Events.Models
{
    public class User
    {
        // Ova e SUBSCRIBER vo event sistemot
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public ProductType FavouriteProductType { get; set; }

        public User(int id, string name, string email, int age, ProductType favouriteProductType)
        {
            Id = id;
            Name = name;
            Email = email;
            Age = age;
            FavouriteProductType = favouriteProductType;
        }

        public void ReadPromotion(ProductType productType)
        {
            Console.WriteLine($"Mr/Mrs: {Name}, the products {productType} are on sale !!!");
            if (productType == FavouriteProductType)
            {
                Console.WriteLine("MY FAVOURITE PRODUCTS");
            }
        }

    }
}
