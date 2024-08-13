namespace TestConsoleApp;
public class Order
{
	public int Id { get; set; }
	public string CustomerName { get; set; }
	public List<OrderItem> Items { get; set; }
	public double TotalAmount { get; set; }

	public double CalculateTotalAmount()
	{
		double total = 0;
		foreach (var item in Items)
		{
			total += item.Price * item.Quantity;
		}
		return total;
	}
}

public class OrderItem
{
	public int Id { get; set; }
	public string Name { get; set; }
	public int Quantity { get; set; }
	public double Price { get; set; }
}
