//Console.WriteLine("Hello, World!");
//Console.WriteLine("list of names and numbers");
//string[] names = { "Michael", "Gabriel", "Tolulope", "Bright", "Sunday", "Joy", "Toyin", "John", "Abiodun", "george", "Chika", "Junior", "Funke", "Funmilayo", "Emmanuel", "Emeka", "Adewale", "Blessing", "Kayode", "Abosede" };
//foreach (string name in names)
//{
//    Console.WriteLine(name);
//}
//for (int i = 0; i <= 50; i += 2)
//{
//    if (i % 2 == 0) ;
//    Console.WriteLine(i);
//}
//Console.ReadLine();



using MICHAEl;
//MICHAEl.UserInfo("ABIODUN", "MICHAEL", 36, "COMPUTER SCIENCE", 400L);






List<AddToCart> carts = new List<AddToCart>();
carts.Add(new AddToCart { Id = 1, ItemsName = "HP Pavilion 15 core i5", Price = 3500000 });
carts.Add(new AddToCart { Id = 2, ItemsName = "iPhone15 pro max 512Gb", Price = 1150000 });
carts.Add(new AddToCart { Id = 3, ItemsName = "Dell Charger", Price = 10000 });
carts.Add(new AddToCart { Id = 4, ItemsName = "Laptop Battery", Price = 30000 });
carts.Add(new AddToCart { Id = 5, ItemsName = "Laptop Keyboard", Price = 10000 });
carts.Add(new AddToCart { Id = 6, ItemsName = "type c charger", Price = 8000 });
carts.Add(new AddToCart { Id = 7, ItemsName = "tecno spark 40", Price = 220000 });
carts.Add(new AddToCart { Id = 8, ItemsName = "RAM 256SSD", Price = 50000 });
carts.Add(new AddToCart { Id = 9, ItemsName = "500GB HDD", Price = 20000 });
carts.Add(new AddToCart { Id = 10, ItemsName = "15.6 Paper Screen", Price = 40000 });
carts.Add(new AddToCart { Id = 11, ItemsName = "HP Revolve 810 G1", Price = 220000 });

List<AddToCart> prdCarts = new List<AddToCart>();

AddToCart.ViewProduct(carts);
AddToCart.AdddProductToCart(carts, prdCarts);
AddToCart.ViewCart(prdCarts);
AddToCart.RemovedProductToCart(carts, prdCarts);
AddToCart.ViewCart(prdCarts);
AddToCart.Checkout(prdCarts);
