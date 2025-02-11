using System.IO.Pipes;

public class Product
{
    private string _productId;
    private string _productName;
    private double _price;
    private int _quantity;

    public Product(string productId, string productName, double price, int quantity)
    {
        _productId = productId;
        _productName = productName;
        _price = price;
        _quantity = quantity;
    }

    public Product(string productId, string productName, double price)
    {
        _productId = productId;
        _productName = productName;
        _price = price;
        _quantity = 1;
    }
    public double GetTotalCost()
    {
        return _price * Convert.ToDouble(_quantity);
    }

    public string GetPackingLabel()
    {
        return $"{_productName} (id: {_productId})";
    }
}