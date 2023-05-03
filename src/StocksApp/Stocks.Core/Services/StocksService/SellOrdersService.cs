﻿using RepositoryContracts;
using ServiceContracts.StocksService;
using Stocks.Core.DTO;
using Stocks.Core.Entities;
using Stocks.Core.Extensions;
using Stocks.Core.Helpers;

namespace Services.StockService
{
    public class SellOrdersService : ISellOrdersService
    {
        private readonly IStocksRepository _stocksRepository;

        public SellOrdersService(IStocksRepository stocksRepository)
        {
            _stocksRepository = stocksRepository;
        }

        public async Task<SellOrderResponse> CreateSellOrder(SellOrderRequest? sellOrder)
        {
            //validation: sellOrderRequest should not be null
            if (sellOrder == null) throw new ArgumentException(nameof(sellOrder));
            //model validation using validation helper
            ValidationHelpers.ModelValidation(sellOrder);

            //convert sellOrderRequest into SellOrder type
            SellOrder order = sellOrder.ToSellOrder();

            //generate a new guid for the order id
            order.SellOrderID = Guid.NewGuid();

            //add order to sellOders list
            await _stocksRepository.CreateSellOrder(order);

            //convert order to sellOrderResponse type
            SellOrderResponse sellOrderResponse = order.ToSellOrderResponse();
            return sellOrderResponse;
        }

        public async Task<List<SellOrderResponse>> GetSellOrders()
        {
            List<SellOrder> sellOrders = await _stocksRepository.GetSellOrders();
            return sellOrders.Select(order => order.ToSellOrderResponse()).ToList();
        }
    }
}
