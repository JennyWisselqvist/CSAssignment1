using Assignment1.Models;
using Assignment.Models;
using Assignment.Interface;

namespace Assignment
{
    class Program 
    {
        static void Main(string[] args)
        {   
            var menu = new Menu();
            var phonebook = new Phonebook();
            
            menu.PrintMenu();
            string choice = Console.ReadLine();

            while (choice != "4")
            {
                switch (choice)
                {
                    case "1":
                        AddContact(phonebook);
                        break;
                    case "2":
                        ViewContacts(phonebook);
                        break;
                    case "3":
                        FindContact(phonebook);
                        break;
                    case "4":
                        Console.Write("End program");
                        break;
                    default:
                        Console.WriteLine("Select valid operation");
                        break;
                }
                menu.PrintMenu();
                choice = Console.ReadLine();
            }
        }
        static Contact AddContact(Phonebook phonebook) //lägger till en kontakt
        {
            var menu = new Menu();
            menu.AddMenu();   
            Console.Write("Name: ");
            var firstname = Console.ReadLine();
            Console.Write("Lastname: ");
            var lastname = Console.ReadLine();
            Console.Write("City: ");
            var city = Console.ReadLine();
            Console.Write("Postalcode: ");
            var postalcode = Console.ReadLine();
            Console.Write("Phonenumber: ");
            var number = Console.ReadLine();
            Console.WriteLine("\n" + firstname + " has been added!");
            Console.ReadKey();
            Console.Clear();
            var newContact = new Contact(firstname, lastname, city, postalcode, number);
            phonebook.AddContact(newContact);
            return newContact;
        }
        static private void ViewContacts(Phonebook phonebook)   //visar alla kontakter
        {
            var menu = new Menu();
            menu.ContactsMenu();
            phonebook.DisplayAllContacts();
            Console.ReadKey();
            Console.Clear();
        }
        static private void FindContact(Phonebook phonebook)     // hittar en kontakt genom att söka namnet 
        {
            var menu = new Menu();
            menu.SearchMenu();
            var searchPhrase = Console.ReadLine();
            Contact contact = phonebook.ShowMatchingContact(searchPhrase);
            Console.ReadKey();
            Console.Clear();
            menu.UpdateMenu();
            var option = Console.ReadLine();
            if (option == "Delete" || option == "delete")          //tar bort en användare
            {
                Console.WriteLine("Removed " + searchPhrase);
                phonebook.DeleteContact(contact);
            }
            else if (option == "Update" || option == "update")     //updaterar en användare
            {
                Contact.UpdateContact(contact);
            }
            else                                
            {
            }
        }
    }
}