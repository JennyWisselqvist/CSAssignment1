using Assignment.Service;
using Assignment1.Models;
using Newtonsoft.Json;

namespace Assignment.Interface
{
    internal interface IPhonebook
    {
    }
    internal class Phonebook : IPhonebook
    {
        private List<Contact> Contacts { get; set; } = new List<Contact>();

        private Filemanager filemanager = new Filemanager();

        public Phonebook()
        {
            Contacts = JsonConvert.DeserializeObject<List<Contact>>(filemanager.Read());
        }
        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
            filemanager.Save(JsonConvert.SerializeObject(Contacts));
        }
        private static void ShowContactDetails(Contact contact) //visar kontaktens information
        {
            Console.WriteLine($"Contact: Name: {contact.FirstName}, Lastname: {contact.LastName},  City: {contact.City}, Postalcode:  {contact.Postalcode}, Phonenumber: {contact.Phonenumber}");
        }
        public void DisplayAllContacts() // visar alla kontakters namn 
        {
            foreach (var contact in Contacts)
            {
                Console.WriteLine($" {contact.FirstName}");
            }
        }
        public Contact ShowMatchingContact(string searchPhrase) //en metod för att söka en kontakt efter namn
        {
            Contact contact = Contacts.Find(c => c.FirstName.Contains(searchPhrase));
            ShowContactDetails(contact);
            return contact;
        }
        public void DeleteContact(Contact contact)
        {
            Contacts.Remove(contact);
        }
    }
}
