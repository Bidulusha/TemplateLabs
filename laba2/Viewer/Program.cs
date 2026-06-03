internal class Program
{
    static void Main(string[] args)
    {
        var order = new Order()
        {
            OrderNumber = "131232",
            OrderDate = DateTime.Now,
            TotalAmount = 10.01m
        };

        var smsObserver = new SmsObserver();
        var emailObserver = new EmailObserver();

        var orderService = new OrderServer();

        orderService.Attach(smsObserver);
        orderService.Attach(emailObserver);

        orderService.UpdateOrder(order);
    }
}

public class Order
{
    public string OrderNumber { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
}

public interface IOrderObserver
{
    void Update(Order order);
}

public class EmailObserver : IOrderObserver
{
    public void Update(Order order)
    {
        Console.WriteLine("Order status is updated. Emails: {0}", order.OrderNumber);
    }
}

public class SmsObserver : IOrderObserver
{
    public void Update(Order order)
    {
        Console.WriteLine("Order status is updated. Sms: {0}", order.OrderNumber);
    }
}

public interface IOrderNotifier
{
    void Attach(IOrderObserver observer);
    void Detach(IOrderObserver observer);
    void Notify(Order order);
}

public class OrderServer : IOrderNotifier
{
    private List<IOrderObserver> Observers = new List<IOrderObserver>();

    public void Attach(IOrderObserver observer)
    {
        Observers.Add(observer);
    }

    public void Detach(IOrderObserver observer)
    {
        Observers.Remove(observer);
    }

    public void Notify(Order order)
    {
        foreach (IOrderObserver observer in Observers)
        {
            observer.Update(order);
        }
    }

    public void UpdateOrder(Order order)
    {
        Notify(order);
    }
}