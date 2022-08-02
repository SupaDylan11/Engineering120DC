using System;
using System.Threading;
using System.Threading.Tasks;

namespace AysncCake
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Welcome to my birthday party");
            HaveAPartyAsync();
            Console.WriteLine("Thanks for a lovely party");
            Console.ReadLine();
        }

        private static async void HaveAPartyAsync()
        {
            var name = "Cathy";
            var cakeTask = BakeCakeAsync();
            var pizzaTask = OrderPizzaAsynch();
            PlayPartyGames();
            OpenPresents();
            var pizza = await pizzaTask;
            Console.WriteLine(pizza.ToString());
            var cake = await cakeTask;
            Console.WriteLine($"Happy birthday, {name}, {cake}!!");
        }

        private static async Task<Cake> BakeCakeAsync()
        {
            Console.WriteLine("Cake is in the oven");
            await Task.Delay(TimeSpan.FromSeconds(5));
            Console.WriteLine("Cake is done");
            return new Cake();
        }

        private static void PlayPartyGames()
        {
            Console.WriteLine("Starting games");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Console.WriteLine("Finishing Games");
        }

        private static void OpenPresents()
        {
            Console.WriteLine("Opening Presents");
            Thread.Sleep(TimeSpan.FromSeconds(1));
            Console.WriteLine("Finished Opening Presents");
        }

        private static async Task<Dominos> OrderPizzaAsynch()
        {
            Console.WriteLine("Phoning up the Dominions");
            // now let's order that one pizza that'll make us a mafia target
            await Task.Delay(TimeSpan.FromSeconds(10));
            Console.WriteLine("Pizza delivery alien is at the door");
            return new Dominos() { Topping1 = "Ham", Topping2 = "Pineapple"};
        }
    }

    public class Cake
    {
        public override string ToString()
        {
            return "Here's a cake";
        }
    }

    public class Dominos
    {
        public string? Topping1 { get; init; }
        public string? Topping2 { get; init; }
        public string? Topping3 { get; init; }
        public override string ToString()
        {
            if (Topping1.Contains("pineapple", StringComparison.OrdinalIgnoreCase) || Topping2.Contains("pineapple", StringComparison.OrdinalIgnoreCase) || Topping3.Contains("pineapple", StringComparison.OrdinalIgnoreCase))
                return "You are banned from Dominos! P*******e does not belong on a pizza.";
            else
                return "Enjoy your pizza.";
        }
    }
}
