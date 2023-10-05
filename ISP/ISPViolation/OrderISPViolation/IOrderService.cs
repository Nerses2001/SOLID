namespace SOLID.ISP.ISPViolation.OrderISPViolation
{
    internal interface IOrderService
    {

        Order CreateOrder();
        Order AmendOrder();
        bool CanceledOrder(int orderId);
        Order SubmitOrder(int orderId);
        Order GetOrder(int orderId);
        bool ProcessOrder(int orderId);
    }
}
