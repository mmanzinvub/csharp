namespace McOrders {
  public class Ordering {
    public Ordering() {
      nextOrderId = 1;
      CompletedOrders = new List<Order>();
    }

    public void AddOrder(Food food) {
      var order = new Order(nextOrderId++, food);
      Task task = Task.Run(() => {
        Thread.Sleep(2000);
        StartOrder(order);
        Thread.Sleep(order.Food.PreparingTime * 1000);
        CompleteOrder(order);
      });
    }

    public void StartOrder(Order order) {
      ActiveOrders.Add(order);
      OrderStarted?.Invoke(this, new OrderArgs(order));
    }

    // TODO: Metoda koja prebacuje narudžbu iz aktivnih u završene
    // TODO: Mora pokrenuti događaj koji signalizira završetak
    // narudžbe
    public void CompleteOrder(Order order) {
            CompletedOrders.Add(order);
            OrderCompleted?.Invoke(this, new OrderArgs(order));
    }

    public delegate void OrderingDelegate(object sender, OrderArgs e);
    public event OrderingDelegate OrderStarted;
    // TODO: Događaj za završene narudžbe
    public event OrderingDelegate OrderComleted;

    public List<Order> ActiveOrders { get; }
        
    // TODO: List završenih narudžbi
    public List<Order> CompletedOrders { get; }
       
    private int nextOrderId;
    }
}
