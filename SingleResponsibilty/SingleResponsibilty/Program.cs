namespace SingleResponsibilty;


public class Customer
{
    public string Name { get; set; }
    public string Email { get; set; }
}

public class CustomerRepository
{
    public void SaveCustomer(Customer customer)
    {
        Console.WriteLine("Saved: " + customer.Name);
    }
}

public class EmailService
{
    public void SendEmail(Customer customer, string message)
    {
        Console.WriteLine("E-mail sent: " + message + " - Buyer: " + customer.Email);
    }
}

class Program
{
    static void Main()
    {
        var customer = new Customer { Name = "Javid Gasim", Email = "gasimovcavid777@gmail.com" };

        var customerRepository = new CustomerRepository();
        customerRepository.SaveCustomer(customer);

        var emailService = new EmailService();
        emailService.SendEmail(customer, "Hello, Welcom!");
    }
}
