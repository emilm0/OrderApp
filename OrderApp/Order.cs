namespace OrderApp;

public class Order
{
    private int id;
    private double netTotal;
    private int tax;
    private double total;

    public Order(int tax)
    {
        this.tax = tax;
    }

    public int GetId()
    {
        return id;
    }

    public int GetTax()
    {
        return tax;
    }

    private void SetNetTotal()
    {
        var items = FindAllOrdersItemsByOrderId(id);

        netTotal = SumAllOrderItemsNetTotals(items);
    }

    public double GetNetTotal()
    {
        SetNetTotal();
        return netTotal;
    }

    private List<OrderItem> FindAllOrdersItemsByOrderId(int orderId)
    {
        //function finding all order items from the database

        List<OrderItem> items = new List<OrderItem>();
        //For tests added dummy order item List

        items.Add(new OrderItem(1, 100, 10)); //net total 1000
        items.Add(new OrderItem(1, 200, 30)); //net total 6000

        return items;
    }

    private double SumAllOrderItemsNetTotals(List<OrderItem> orderItems)
    {
        double total = 0;

        foreach(OrderItem item in orderItems)
        {
            total += item.GetNetTotal();
        }

        return total;
    }

    private void SetTotal()
    {
        SetNetTotal();
        total = new Calculator().CalculateBrutto(netTotal, tax);
    }

    public double GetTotal()
    {
        SetTotal();

        return total;
    }


}