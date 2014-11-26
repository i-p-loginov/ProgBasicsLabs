using System;

namespace MenuSample
{
    static class Program
    {
        static void Main()
        {
            Menu menu = new Menu(true);

            menu.Add(new MenuItem("Item1", "item1", () => Console.WriteLine("Item1 selected")));
            menu.Add(new MenuItem("Item2", "item2", () => Console.WriteLine("Item2 selected")));
            menu.Add(new MenuItem("Item3", "item3", Item3Handler));
            menu.Add(new MenuItem("Exit", "exit", () => Environment.Exit(0)));

            menu.WaitingLoop();
        }

        static void Item3Handler()
        {
            Console.WriteLine("Item3 selected");
        }
    }
}
