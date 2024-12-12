using gRPC.Service;
using Grpc.Core;

namespace gRPC.Service.Services
{
    public class OrderService: Orderer.OrdererBase
    {
        private readonly ILogger<OrderService> _logger;
        public OrderService(ILogger<OrderService> logger)
        {
            _logger = logger;
        }

        public override Task<OrderResponse> GetOrder(OrderRequest request, ServerCallContext context)
        {
            return Task.FromResult(new OrderResponse
            {
                Message = "Your order " + request.OrderId + " is ready."
            });
        }
    }
}
