using IntroducaoEnumPedido.Entities;
using IntroducaoEnumPedido.Entities.Enums;

namespace IntroducaoEnumPedido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1800,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            //Converter enum para string
            string txt = OrderStatus.PendingPayment.ToString();

            //Converter string para enum
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(txt);
            Console.WriteLine(os);

        }
    }
}
