using System.Collections.Generic;


class Contact
{
    public string Name { get; set; }
    public string Phone { get; set; }
}

class PhoneBook
{
    Contact[] contacts = new Contact[]
    {
        new Contact { Name = "Marcus Aurelius", Phone = "+380445554433" },
        new Contact { Name = "John Doe", Phone = "+380101000222"},
        new Contact { Name = "Will Smith", Phone = "+380595959000" }
    };

    public string FindPhoneByName(string name)
    {
        for (int x = 0; x < contacts.Length; x++)
        {
            if (string.Equals(contacts[x].Name, name, StringComparison.OrdinalIgnoreCase))
            {
                return contacts[x].Phone;
            }
        }
        return null;
    }

    public string FindPhoneByNameHash(string name)  
    {
        var dict = new Dictionary<string,string>(StringComparer.OrdinalIgnoreCase);
        for (int x = 0; x < contacts.Length; x++)
        {
            dict[contacts[x].Name] = contacts[x].Phone;
        }
        
        if (dict.TryGetValue(name, out var phone))
        {
            return phone;
        }
        return null;
    }
    
}

public class Program
{
    public static void Main()
    {
        var phone_book = new PhoneBook();
        Console.WriteLine(phone_book.FindPhoneByName("Marcus Aurelius")); 
        Console.WriteLine(phone_book.FindPhoneByNameHash("Marcus Aurelius"));
    }
}