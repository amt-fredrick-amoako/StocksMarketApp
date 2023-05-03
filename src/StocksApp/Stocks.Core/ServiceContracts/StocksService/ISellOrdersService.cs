using Stocks.Core.DTO;

namespace ServiceContracts.StocksService
{
    public interface ISellOrdersService
    {
        /// <summary>
        /// Takes a SellOrderRequest object and returns a SellOrderResponse
        /// </summary>
        /// <param name="request">SellOrderRequest parameter</param>
        /// <returns>New object of a SellOrderResponse</returns>
        Task<SellOrderResponse> CreateSellOrder(SellOrderRequest? sellOrder);

        /// <summary>
        /// Get all SellOrders in a form of a SellOrderResponse object type
        /// </summary>
        /// <returns>A list of SellOrderResponse</returns>
        Task<List<SellOrderResponse>> GetSellOrders();
    }
}
