public class Customer
{
    private string _name;
    private Address _address;

    public Customer() { }

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public Customer(string name, string street, string city, string state, string country)
    {
        _name = name;
        _address = new Address(street, city, state, country);
    }

    public string GetShippingLabel()
    {
        return $"{_name}\n{_address.GetFullAddress()}";
    }

    public bool LivesInUSA()
    {
        return _address.AddresIsInUSA();
    }
}