namespace oop_Ayobola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Bakery App");

            var bakeryOrders = new BakeryOrders();
            Console.WriteLine("\nThe price for our Small Bread is "+ bakeryOrders.PriceSmallBread + " Naira");
            Console.WriteLine("\nThe price for our Medium Bread is "+ bakeryOrders.PriceMediumBread + " Naira");
            Console.WriteLine("\nThe price for our Large Bread is "+ bakeryOrders.PriceLargeBread + " Naira");

            Console.WriteLine("\nwhat type of bread do you want to buy? for small bread, press S, for medium bread press M, for large bread press L") ;
            var breadType = Console.ReadLine();
            Console.WriteLine("how many bread do you want to buy? ");
            var breadNumber = Convert.ToDouble(Console.ReadLine());

            if (breadType.ToUpper() == "S")
            {
                var price = bakeryOrders.Price(breadNumber);
                Console.WriteLine("Your amount due is " + price);
            }
            else if (breadType.ToUpper() == "M")
            {
                var price = bakeryOrders.Price(0, breadNumber);
                Console.WriteLine("Your amount due is " + price);


            }
            else if (breadType.ToUpper() == "L")
            {
                var price = bakeryOrders.Price(0,0,breadNumber);
                Console.WriteLine("Your amount due is " + price);


            }



        }
    }
}