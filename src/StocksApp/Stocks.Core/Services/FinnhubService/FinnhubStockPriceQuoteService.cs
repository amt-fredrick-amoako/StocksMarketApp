using RepositoryContracts;
using ServiceContracts.FinnhubService;
using Stocks.Core.Exceptions;

namespace Services.FinnhubService
{
    public class FinnhubStockPriceQuoteService : IFinnhubStockPriceQuoteService
    {
        private readonly IFinnhubRepository _finnhubRepository;

        public FinnhubStockPriceQuoteService(IFinnhubRepository finnhubRepository)
        {
            _finnhubRepository = finnhubRepository;
        }

        public async Task<Dictionary<string, object>?> GetStockPriceQuote(string? stockSymbol)
        {
            try
            {
                Dictionary<string, object>? responseDictionary = await _finnhubRepository.GetStockPriceQuote(stockSymbol);

                //return response dictionary to the caller
                return responseDictionary;
            }
            catch (Exception ex)
            {
                FinnhubException finnhubException = new("Unable to connect to finnhub", ex);
                throw finnhubException;
            };
        }
    }
}
