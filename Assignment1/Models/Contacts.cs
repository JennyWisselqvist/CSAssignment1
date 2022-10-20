namespace Assignment1.Models
{
    internal interface IContact
    {
    }
    internal class Contact : IContact
    {
        public Contact()
        {
        }
        public Contact(string firstname, string lastname, string city, string postalcode, string phonenumber)
        {
            Id = Guid.NewGuid();
            FirstName = firstname;
            LastName = lastname;
            City = city;
            Postalcode = postalcode;
            Phonenumber = phonenumber;
        }
        public Guid Id { get; set; } = new Guid();
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? City { get; set; }
        public string? Postalcode { get; set; }
        public string? Phonenumber { get; set; }
        public static void UpdateContact(Contact contact) //Gjorde en switch som låter användaren uppdatera specifik information.
        {
            Console.Clear();
            Console.WriteLine("Updating " + contact.FirstName);
            Console.WriteLine("what do you want to update? \n 1.Name\n 2.Lastname \n 3.City \n 4.Postalcode \n 5.Phonenumber \n 6.All");
            Console.Write(" Option: ");
            string option2 = Console.ReadLine();

            switch (option2)
            {
                case "1":
                    {
                        Console.Write("Name: ");
                        var firstname = Console.ReadLine();
                        contact.FirstName = firstname;
                        break;
                    }
                case "2":
                    {
                        Console.Write("Lastname: ");
                        var lastname = Console.ReadLine();
                        contact.LastName = lastname;
                        break;
                    }
                case "3":
                    {
                        Console.Write("City: ");
                        var city = Console.ReadLine();
                        contact.City = city;
                        break;
                    }
                case "4":
                    {
                        Console.Write("Postalcode: ");
                        var postalcode = Console.ReadLine();
                        contact.Postalcode = postalcode;
                        break;
                    }
                case "5":
                    {
                        Console.Write("Phonenumber: ");
                        var number = Console.ReadLine();
                        contact.Phonenumber = number;
                        break;
                    }
                case "6":
                    {
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

                        contact.FirstName = firstname;
                        contact.LastName = lastname;
                        contact.City = city;
                        contact.Postalcode = postalcode;
                        contact.Phonenumber = number;
                        break;
                    }
            }
            Console.WriteLine("Contact has been updated!");
        }
  
    }
}

