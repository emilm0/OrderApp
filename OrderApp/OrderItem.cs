namespace OrderApp;

public class OrderItem
{
    public int id;
    public int orderId;
    private double netPrice;
    private int quantity;
    private double netTotal;
    private double total;

    public OrderItem(int orderId, double netPrice, int quantity)
    {
        this.orderId = orderId;
        this.netPrice = netPrice;
        this.quantity = quantity;
        SetNetTotal();
    }

    private void SetNetTotal()
    {
        netTotal = netPrice * quantity;
    }

    public double GetNetTotal()
    {
        return netTotal;
    }

    public double GetTotal()
    {
        var tax = GetTexFromOrderByOrderId();
        total = new Calculator().CalculateBrutto(netTotal, tax);
        return total;
    }
    private int GetTexFromOrderByOrderId()
    {
        //function finding an order in the database by orderId property
        //for tests order's constructor get parameter equals orderId
        var order = new Order(orderId);

        return order.GetTax();
    }
}
