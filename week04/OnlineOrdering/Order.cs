using System.Diagnostics.Contracts;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer = new Customer();

    public void AddProduct(string productName, double price, int quantity)
    {
        Random random = new Random();
        Product product = new(random.NextInt64(100).ToString(), productName, price, quantity);
        _products.Add(product);
    }

    public void AddProduct(string productName, double price)
    {
        Random random = new Random();
        string idPrd = random.NextInt64(100, 999).ToString();
        Product product = new(idPrd, productName, price);
        _products.Add(product);
    }
    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }
    private double ShippingCost()
    {
        return _customer.LivesInUSA() ? 5 : 35;
    }
    public double GetTotalCostOrder()
    {
        return _products.Sum(product => product.GetTotalCost()) + ShippingCost();
    }
    public string GetPackingLabelList()
    {
        string labelList = "";
        int listCount = 0;
        foreach (Product product in _products)
        {
            listCount += 1;
            labelList += listCount.ToString() + ". " + product.GetPackingLabel() + "\n";
        }
        return labelList;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetShippingLabel()}";
    }
}