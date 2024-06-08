using System;

namespace final
{

    public class Final
    {
        public static void Main()
        {
            Product bread = new Product("bread", 12.0);
            Product cheese = new Product("cheese", 50.0);
            Product milk = new Product("bread", 20.0);

            Delivery deliveryToShop = new ShopDelivery("Ленина, 10");
            Delivery deliveryToHome = new HomeDelivery("Пушкина, 12");
            Delivery deliveryToPickPoint = new PickPointDelivery("Некрасова, 50");

            Courier courier = new Courier("Иван", "Иванов", 213);
            Client client = new Client("Петров", "Петр", "А432");

            Product[] products1 = { bread, cheese };
            Product[] products2 = { bread, milk };
            Product[] products3 = { bread, cheese, milk };

            Order<ShopDelivery> order1 = new Order<ShopDelivery>(deliveryToShop, products1);
            Order<HomeDelivery> order2 = new Order<HomeDelivery>(deliveryToHome, products2, client, courier);
            order2.AddDescription("Домофон не работает");
            Order<PickPointDelivery> order3 = new Order<PickPointDelivery>(deliveryToPickPoint, products3, client);

            Console.WriteLine("Заказ 1");
            order1.DisplayAddress();
            order1.DisplayInfo();
            Console.WriteLine();
            Console.WriteLine("Заказ 2");
            order2.DisplayAddress();
            order2.DisplayInfo();
            Console.WriteLine();
            Console.WriteLine("Заказ 3");
            order3.DisplayAddress();
            order3.DisplayInfo();

        }
    }

    abstract class Delivery
    {
        protected string Address;

        public Delivery(string Address)
        {
            this.Address = Address;
        }

        public string GetAddres()
        {
            return Address;
        }

    }

    class HomeDelivery : Delivery
    {

        public HomeDelivery(string Address) : base(Address) { }
    }

    class PickPointDelivery : Delivery
    {

        public PickPointDelivery(string Address) : base(Address) { }
    }

    class ShopDelivery : Delivery
    {

        public ShopDelivery(string Address) : base(Address) { }
    }

    class Order<TDelivery> where TDelivery : Delivery
    {
        private TDelivery Delivery;

        private Product [] Product;

        private Client Client;

        private Courier Courier;

        private int Number = 0;

        private double Sum = 0;

        private string Description;



        public Order(Delivery delivery, Product [] product)
        {
            Number++;
            Delivery = (TDelivery)delivery;
            Product = product;

            for (int i = 0; i < product.Length; i++)
            {
                Sum += product[i].price;
            }

            
        }

        public Order(Delivery delivery, Product [] product, Client client)
        {
            Number++;
            Delivery = (TDelivery)delivery;
            Product = product;
            Client = client;

            for (int i = 0; i < product.Length; i++)
            {
                Sum += product[i].price;
            }

        }

        public Order(Delivery delivery, Product [] product, Client client, Courier courier)
        {
            Number++;
            Delivery = (TDelivery)delivery;
            Product = product;
            Client = client;
            Courier = courier;

            for (int i = 0; i < product.Length; i++)
            {
                Sum += product[i].price;
            }
        }

        public void AddDescription (string Description)
        {
            this.Description = Description;
        }


        public void DisplayInfo()
        {
            Console.WriteLine($"Номер заказа: {Number}");
            for (int i = 0; i< Product.Length; i++)
            {

                Console.WriteLine($"Товар №{i+1}: {Product[i].name}");
                Console.WriteLine($"Цена:  {Product[i].price}");
            }
            Console.WriteLine($"Сумма заказа: {Sum}");
            Courier?.Display();
            Client?.Display();
            if (Description != null) {
                Console.WriteLine(Description);
                    }

        }

        public void DisplayAddress()
        {
            Console.WriteLine($"Адрес: {Delivery.GetAddres()}");
        }


    }

    abstract class Person<Tid>
    {
        protected string Name { get; set; }
        protected string Surname { get; set; }
        protected Tid Id { get; set; }


        public virtual void Display()
        {
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Фамилия: {Surname}");
            Console.WriteLine($"ID: {Id}");
        }

    }

    class Client : Person<string>
    {

        public Client(string Name, string Surname, string Id)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Id = Id;
        }


        public override void Display()
        {
            Console.WriteLine("Клиент: ");
            base.Display();
        }

    }

    class Courier : Person<int>
    {

        public Courier(string Name, string Surname, int Id)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Id = Id;
        }


        public override void Display()
        {
            Console.WriteLine("Курьер: ");
            base.Display();
        }


    }

    class Product
    {
        private string Name;
        private double Price;
        static double MinPrice = 10.0;

        public Product(string Name, double Price)
        {
            this.Name = Name;
            this.Price = Price;
        }

        public string name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }

        public double price
        {
            get
            {
                return Price;
            }
            set
            {
                if (value > MinPrice)
                {
                    Price = value;
                }
                else
                {
                    Console.WriteLine("Введена некорректная цена");
                }
            }
        }

    }


}
