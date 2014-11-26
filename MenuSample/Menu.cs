using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace MenuSample
{
    public class Menu
    {
        private static readonly MenuItemEqualityComparer itemsComparer = new MenuItemEqualityComparer();

        private readonly List<MenuItem> menuItems = new List<MenuItem>();

        public Menu(bool redrawAfterAction = false)
        {
            this.RedrawAfterAction = redrawAfterAction;
        }

        public IEnumerable<MenuItem> Items
        {
            get
            {
                return new ReadOnlyCollection<MenuItem>(this.menuItems.ToArray());
            }
        }

        public bool RedrawAfterAction { get; private set; }

        public void Add(MenuItem item)
        {
            if (item == null)
                throw new ArgumentNullException("item");


            if (this.Items.Contains(item, Menu.itemsComparer))
            {
                throw new InvalidOperationException(Strings.ExceptionMenuItemExists);
            }

            this.menuItems.Add(item);
        }

        public void Remove(MenuItem item)
        {
            if (item == null)
                throw new ArgumentNullException("item");

            this.menuItems.Remove(item);
        }

        private void WriteMenu()
        {
            Console.WriteLine(string.Join(Environment.NewLine, this.Items));
            Console.WriteLine(Strings.MenuEnterCommandGreeting);
        }

        public void WaitingLoop()
        {
            while (true)
            {
                if (RedrawAfterAction)
                {
                    Console.Clear();
                }

                this.WriteMenu();

                var command = Console.ReadLine();

                MenuItem item = this.Items.SingleOrDefault(i => i.Command == command);

                if (item == null)
                {
                    Console.WriteLine(Strings.MenuWrongCommand);
                }
                else
                {
                    item.ExecuteAction();
                    Console.WriteLine(Strings.MenuItemPressAnyKey);
                }
                Console.ReadKey(true);
                
            }
        }
    }
}
