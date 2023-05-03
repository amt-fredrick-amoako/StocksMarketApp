﻿using Stocks.Core.DTO;

namespace ServiceContracts.StocksService
{
    public interface IBuyOrdersService
    {
        /// <summary>
        /// Takes a BuyOrderRequest object and returns a BuyOrderResponse
        /// </summary>
        /// <param name="request">BuyOrderRequest parameter</param>
        /// <returns>New object of a BuyOrderResponse</returns>
        Task<BuyOrderResponse> CreateBuyOrder(BuyOrderRequest? request);

        /// <summary>
        /// Get all BuyOrders in a form of a BuyOrderResponse object type
        /// </summary>
        /// <returns>A list of BuyOrderResponse</returns>
        Task<List<BuyOrderResponse>> GetBuyOrders();
    }
}
