namespace Constructors;

class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer
        {
            Id = 1,
            FirstName = "Berk",
            LastName = "Karanfil",
            City = "Ankara"
        };

        Customer customer2 = new Customer(2, "Ekin", "Karanfil", "Ankara" );

        Console.WriteLine(customer2.FirstName);
    }
}

class Customer
{
    //default constructor
    public Customer()
    {

    }

    public Customer(int id, string firstName, string lastName, string city)
    {
        Console.WriteLine("Yapıcı blok çalıştı");
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        City = city;
    }

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
}



