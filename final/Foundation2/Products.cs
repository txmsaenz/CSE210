
public class Products
{
    private string _name;
    private string _id;
    private double _price;
    private int _quantity;
    private double _totalPrice = 0;

    public Products(string name, string id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public double PriceTotal()
    {
        _totalPrice = _price * _quantity;

        return _totalPrice;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetID()
    {
        return _id;
    }
}