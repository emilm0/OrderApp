using NUnit.Framework;

namespace OrderApp.UnitTests;

public class OrderTests
{
    [Test]
    public void GetNetTotal_WhenAddedDummyOrderItemListInClassFile_ShouldResoult7000()
    {
        var order = new Order(20);

        var result = order.GetNetTotal();

        Assert.AreEqual(7000, result);
    }

    [Test]
    public void GetTotal_WhenAddedDummyOrderItemListInClassFileAndTaxIs20_ShouldResoult8400()
    {
        var order = new Order(20);

        var result = order.GetTotal();

        Assert.AreEqual(8400, result);
    }
}
