namespace ServiceContracts.FinnhubService
{
    public interface IFinnhubCompanyProfileService
    {
        /// <summary>
        /// Defines a method that gets profile of a company
        /// </summary>
        /// <param name="stockSymbol">string parameter of the symbol of the company profile required</param>
        /// <returns>a dictionary with a string and object as the key value pair</returns>
        Task<Dictionary<string, object>?> GetCompanyProfile(string? stockSymbol);
    }
}
