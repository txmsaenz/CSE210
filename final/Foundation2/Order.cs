
public class Order
{
    public List<Products> _products = new List<Products>();

    private Customer _customer;
    private double _totalCost = 0;
    private string _packLabel;
    private string _shipLabel;

    public Order (List<Products> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double TotalCost()
    {
        foreach (Products products in _products)
        {
            _totalCost += products.PriceTotal();
        }

        if (_customer.InTheUSA())
        {
            _totalCost += 5;
        }
        else
        {
            _totalCost += 35;
        }

        return _totalCost;
    }

     public string PackingLabel()
    {
        _packLabel = "Items: ";

        foreach (Products products in _products)
        {
            _packLabel +="\n" + products.GetName() + " : Number " + products.GetID();
        }
        return _packLabel;
    }

    public string ShippingLabel()
    {
        _shipLabel = "Customer: " + _customer.GetName() + ", " + _customer.GetAddress();

        return _shipLabel;
    }

   
}