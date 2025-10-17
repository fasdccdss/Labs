class Person
{
    public string Name { get; set; }
}

class User
{
    public string Name { get; set; }
    public string City { get; set; }
}

class Task
{

    private readonly Person const_user = new Person { Name = "Ivan" };

    static void fn()
    {
        var user = new Person { Name = "John" };

        const_user.Name = "Isaac";
        user.Name = "Joe";

        // const_user = new Person { name = "Alex" }; - won't work, readonly
        user = new Person { Name = "Alex" };

    }

    static User createUser(string name, string city)
    {
        // var user = new User { name = "John", city = "Springfield" };
        return new User { Name = name, City = city };
    }
}
