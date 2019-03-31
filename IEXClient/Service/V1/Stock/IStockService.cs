﻿using IEXClient.Model.Shared.Response;
using IEXClient.Model.Stock.Request;
using IEXClient.Model.Stock.Response;
using QueryString;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IEXClient.Service.V1.Stock
{
    public interface IStockService
    {
        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#batch-requests"/>
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="types"></param>
        /// <param name="range"></param>
        /// <param name="last"></param>
        /// <returns></returns>
        Task<BatchBySymbolResponse> BatchBySymbolAsync(string symbol, IEnumerable<BatchType> types, string range = "", int last = 1);

        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#batch-requests"/>
        /// </summary>
        /// <param name="symbols"></param>
        /// <param name="types"></param>
        /// <param name="range"></param>
        /// <param name="last"></param>
        /// <returns></returns>
        Task<Dictionary<string, BatchBySymbolResponse>> BatchByMarketAsync(IEnumerable<string> symbols, IEnumerable<BatchType> types, string range = "", int last = 1);

        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#book"/>
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        Task<BookResponse> BookAsync(string symbol);

        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#chart"/>
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="range"></param>
        /// <param name="qsb">Additional optional querystring</param>
        /// <returns></returns>
        Task<IEnumerable<HistoricalPriceResponse>> ChartAsync(string symbol, ChartRange range = ChartRange._1m, DateTime? date = null, QueryStringBuilder qsb = null);

        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#chart"/>
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="qsb">Additional optional querystring</param>
        /// <returns></returns>
        Task<HistoricalPriceDynamicResponse> ChartAsync(string symbol, QueryStringBuilder qsb = null);

        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#collections"/>
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="collectionName"></param>
        Task<IEnumerable<Quote>> CollectionsAsync(CollectionType collection, string collectionName);

        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#company"/>
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        Task<CompanyResponse> CompanyAsync(string symbol);

        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#crypto"/>
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Quote>> CryptoAsync();
        
        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#delayed-quote"/>
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        Task<DelayedQuoteResponse> DelayedQuoteAsync(string symbol);

        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#dividends"/>
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="range"></param>
        /// <returns></returns>
        Task<IEnumerable<DividendResponse>> DividendAsync(string symbol, DividendRange range);

        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#earnings"/>
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="last"></param>
        /// <returns></returns>
        Task<EarningResponse> EarningAsync(string symbol, int last = 1);

        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#earnings"/>
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="field"></param>
        /// <param name="last"></param>
        /// <returns></returns>
        Task<string> EarningFieldAsync(string symbol, string field, int last = 1);

        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#earnings-today"/>
        /// </summary>
        /// <returns></returns>
        Task<EarningTodayResponse> EarningTodayAsync();

        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#effective-spread"/>
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        Task<IEnumerable<EffectiveSpreadResponse>> EffectiveSpreadAsync(string symbol);

        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#estimates"/>
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="last"></param>
        /// <returns></returns>
        Task<EstimateResponse> EstimateAsync(string symbol, int last = 1);

        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#estimates"/>
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="field"></param>
        /// <param name="last"></param>
        /// <returns></returns>
        Task<string> EstimateFieldAsync(string symbol, string field, int last = 1);

        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#financials"/>
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="last"></param>
        /// <returns></returns>
        Task<FinancialResponse> FinancialAsync(string symbol, int last = 1);

        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#financials"/>
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="field"></param>
        /// <param name="last"></param>
        /// <returns></returns>
        Task<string> FinancialFieldAsync(string symbol, string field, int last = 1);

        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#fund-ownership"/>
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        Task<FundOwnershipResponse> FundOwnershipAsync(string symbol);

        

        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#income-statement"/>
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="period"></param>
        /// <param name="last"></param>
        /// <returns></returns>
        Task<IncomeStatementResponse> IncomeStatementAsync(string symbol, Period period = Period.Quarter, int last = 1);

        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#income-statement"/>
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="field"></param>
        /// <param name="period"></param>
        /// <param name="last"></param>
        /// <returns></returns>
        Task<string> IncomeStatementFieldAsync(string symbol, string field, Period period = Period.Quarter, int last = 1);

        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#insider-roster"/>
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        Task<IEnumerable<InsiderRosterResponse>> InsiderRosterAsync(string symbol);

        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#insider-summary"/>
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        Task<IEnumerable<InsiderSummaryResponse>> InsiderSummaryAsync(string symbol);

        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#insider-transactions"/>
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        Task<IEnumerable<InsiderTransactionResponse>> InsiderTransactionAsync(string symbol);

        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#institutional-ownership"/>
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        Task<IEnumerable<InstitutionalOwnershipResponse>> InstitutionalOwnerShipAsync(string symbol);

        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#institutional-ownership"/>
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        Task<IEnumerable<IntradayPriceResponse>> IntradayPriceAsync(string symbol);

        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#intraday-prices"/>
        /// </summary>
        /// <param name="ipoType"></param>
        /// <returns></returns>
        Task<IPOCalendar> IPOCalendarAsync(IPOType ipoType);

        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#key-stats"/>
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        Task<KeyStatsResponse> KeyStatsAsync(string symbol);

        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#key-stats"/>
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="stat"></param>
        /// <returns></returns>
        Task<KeyStatsResponse> KeyStatsStatAsync(string symbol, string stat);

        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#largest-trades"/>
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        Task<IEnumerable<LargestTradeResponse>> LargestTradesAsync(string symbol);

        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#list"/>
        /// </summary>
        /// <param name="listType"></param>
        /// <returns></returns>
        Task<IEnumerable<Quote>> ListAsync(string listType);

        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#logo"/>
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        Task<LogoResponse> LogoAsync(string symbol);

        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#market-volume-u-s"/>
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<USMarketVolumeResponse>> USMarketVolumeAsync();

        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#news"/>
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="last"></param>
        /// <returns></returns>
        Task<IEnumerable<NewsResponse>> NewsAsync(string symbol, int last = 10);

        /// <summary>
        /// https://iextrading.com/developer/docs/#ohlc
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        Task<OHLCResponse> OHLCAsync(string symbol);

        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#peers"/>
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        Task<IEnumerable<string>> PeersAsync(string symbol);

        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#previous-day-price"/>
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        Task<HistoricalPriceResponse> PreviousDayPriceAsync(string symbol);

        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#price"/>
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        Task<decimal> PriceAsync(string symbol);

        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#price-target"/>
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        Task<PriceTargetResponse> PriceTargetAsync(string symbol);

        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#quote"/>
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        Task<Quote> QuoteAsync(string symbol);

        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#quote"/>
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="field"></param>
        /// <returns></returns>
        Task<string> QuoteFieldAsync(string symbol, string field);

        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#recommendation-trends"/>
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        Task<IEnumerable<RecommendationTrendResponse>> RecommendationTrendAsync(string symbol);

        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#sector-performance"/>
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<SectorPerformanceResponse>> SectorPerformanceAsync();

        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#splits"/>
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="range"></param>
        /// <returns></returns>
        Task<IEnumerable<SplitResponse>> SplitAsync(string symbol, SplitRange range = SplitRange._1m);

        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#upcoming-events"/>
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        Task<UpcomingEventSymbolResponse> UpcomingEventSymbolAsync(string symbol, UpcomingEventType type);

        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#upcoming-events"/>
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        Task<UpcomingEventMarketResponse> UpcomingEventMarketAsync(UpcomingEventType type);

        /// <summary>
        /// <see cref="https://iextrading.com/developer/docs/#volume-by-venue"/>
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        Task<VolumeByVenueResponse> VolumeByVenueAsync(string symbol);
    }
}