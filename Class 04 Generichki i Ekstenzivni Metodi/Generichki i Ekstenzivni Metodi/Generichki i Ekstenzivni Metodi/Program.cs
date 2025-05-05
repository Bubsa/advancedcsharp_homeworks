// See https://aka.ms/new-console-template for more information
using Generichki_i_Ekstenzivni_Metodi.Entities.Data;
using Generichki_i_Ekstenzivni_Metodi.Entities.Models;
using Generichki_i_Ekstenzivni_Metodi.Helpers;


List<string> strings = new List<string>() { "str1", "str2", "str3" };
List<int> ints = new List<int>() { 1, 2, 3, 4, 5 };
List<bool> bools = new List<bool> { true, false, true };

// *************** NE GENERICKI METODI PRIMER **********************
NotGenericListHelper notGenericListHelper = new NotGenericListHelper();
notGenericListHelper.PrintStrings(strings);
notGenericListHelper.PrintInfoForStrings(strings);


// *************** GENERICKI METODI PRIMER **************************
Console.WriteLine("\nUsing generic helper");
GenericListHelper genericListHelper = new();
genericListHelper.PrintList<string>(strings);
genericListHelper.PrintList<int>(ints);
// Ne ni morash tipot da go pratis spored nova sintaksa. Samo ovaka da si pishe genericListHelper.PrintList(ints);

GenericListHelper.PrintInfo(bools);

// **************** Instanciranje na klasata GenericDb ***********************
Product mobilePhone = new Product() { Id = 10, Title = "Mobile Phone", Description = "Mobile Phone Description" };
GenericDb<Product> ProductsDB = new GenericDb<Product>();
ProductsDB.Insert(mobilePhone);
ProductsDB.Insert(new Product { Id = 20, Title = "Keyboard", Description = "Mechanical"});
ProductsDB.Insert(new Product { Id = 30, Title = "USB", Description = "64GB"});
List<Product> products = ProductsDB.GetAll();

GenericDb<Order> OrdersDB = new GenericDb<Order>();
OrdersDB.Insert(new Order { Id = 1, Address = "Bobsky St", Receiver = "Bob Bobsky" });
OrdersDB.Insert(new Order { Id = 2, Address = "Jill St", Receiver = "Jill Bobsky" });
OrdersDB.Insert(new Order { Id = 3, Address = "Greg St", Receiver = "Greg Gregsky" });
List<Order> allOrders = OrdersDB.GetAll();

ProductsDB.PrintAll();
OrdersDB.PrintAll();
