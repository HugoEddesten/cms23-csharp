using _01_Assignment_Example.Interfaces;

namespace _01_Assignment_Example.Services;

public class CustomerService : ICustomerService
{
    private List<ICustomer> _customers = new List<ICustomer>();
    private readonly string _filePath = @"c:\nackademin\customers.json";

    public void AddCustomerMenu(ICustomer customer)
    {
        _customers.Add(customer);
        Task.Run(() =>FileService.SaveToFileAsync(_filePath, ""));
    }

    public void RemoveCustomer(string email)
    {
        var customer = GetOneCustomer(email);
        _customers.Remove(customer);
    }

    public IEnumerable<ICustomer> GetAllCustomers()
    {
        return _customers;
    }

    public ICustomer GetOneCustomer(string email)
    {
        return _customers.FirstOrDefault(x => x.Email == email)!;
    }

    public Task AddCustomerAsync(ICustomer customer)
    {
        throw new NotImplementedException();
    }
}
