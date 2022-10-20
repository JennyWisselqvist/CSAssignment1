namespace Assignment.Models
{
    internal interface IMenu //ett kontrakt som talar om vad som ska finnas i menyn
    {
        void PrintMenu();
        void AddMenu();
        public void SearchMenu();
        void UpdateMenu();
        void ContactsMenu();
    }

    public class Menu : IMenu // en meny som använder sig utav interface
    {
        public void PrintMenu()
        {
            Console.WriteLine("------- Menu ------");
            Console.WriteLine("1. Add a contact");
            Console.WriteLine("2. View all contacts");
            Console.WriteLine("3. Search for a contacts by name");
            Console.WriteLine("4. Ending program");
            Console.Write("Option: ");
        }
        public void AddMenu()
        {
            Console.Clear();
            Console.WriteLine("------- Creating a contact -------");
        }
        public void UpdateMenu()
        {
            Console.WriteLine("------- Updating contact -------");
            Console.Write("Too update or delete, write \"delete\" or \"update\", press enter to exit: ");
        }
        public void SearchMenu()
        {
            Console.Clear();
            Console.WriteLine("------- Search contact -------");
            Console.Write("Name: ");
        }
        public void ContactsMenu()
        {
            Console.Clear();
            Console.WriteLine("------- All contacts -------");
        }
    }
}
