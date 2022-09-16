using NUnit.Framework;

namespace OrderApp.UnitTests;

public class OrderItemTests
{
    [Test]
    public void GetNetTotal_WhenNetPriceIs300andQuantityIs10_ShouldReturn3000()
    {
        var orderItem = new OrderItem(1, 300, 10);

        var result = orderItem.GetNetTotal();

        Assert.AreEqual(3000, result);
    }

    [Test]
    public void GetTotal_WhenNetPriceIs300andQuantityIs10AndTaxIsEqualOrderId_ShouldReturn3300()
    {
        var orderItem = new OrderItem(10, 300, 10);

        var result = orderItem.GetTotal();

        Assert.AreEqual(3300, result);
    }

}
