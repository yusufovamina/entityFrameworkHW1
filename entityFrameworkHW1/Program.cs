namespace entityFrameworkHW1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (AppContext db = new AppContext())
            {

                // создание и добавление моделей
                Person p1 = new Person { Name = "Zara", Surname = "Samedova", Age=20 };
                Person p2 = new Person { Name = "Nazim", Surname = "Pashayev", Age = 41 };
                Person p3 = new Person { Name = "Ali", Surname = "Veliyev", Age = 23 };

                db.Persons.Add(p1);
                db.Persons.Add(p2);
                db.Persons.Add(p3);
                

                Product rice = new Product { Name = "Rice", Price=6 };
                Product tomatos = new Product { Name = "Tomatos", Price=3 };
                Product salmon = new Product { Name = "Salmon", Price = 9 };
                Product avocado = new Product { Name = "Avocado", Price = 4 };
                Product bread = new Product { Name = "Bread", Price = 1 };
                Product cheese = new Product { Name = "Cheese", Price = 2 };
                db.Products.Add(rice);
                db.Products.Add(tomatos);
                db.Products.Add(salmon);
                db.Products.Add(avocado);
                db.Products.Add(bread);
                db.Products.Add(cheese);



                p1.Products.Add(tomatos);
                p1.Products.Add(salmon);
                p1.Products.Add(cheese);
                p2.Products.Add(rice);
                p2.Products.Add(bread);
                p3.Products.Add(rice);
                p3.Products.Add(avocado);
                p3.Products.Add(salmon);
                db.SaveChanges();
                Console.WriteLine("Db was created");
            }
        }
    }
}