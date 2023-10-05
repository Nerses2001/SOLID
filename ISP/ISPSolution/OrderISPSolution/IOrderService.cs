using SOLID.ISP.ISPViolation.OrderISPViolation;

namespace SOLID.ISP.ISPSolution.OrderISPSolution
{
    internal interface IOrderService
    {
        Order CreateOrder();
        Order AmendOrder();
        bool CanceledOrder(int orderId);
        Order SubmitOrder(int orderId);
        Order GetOrder(int orderId);
    }
}
