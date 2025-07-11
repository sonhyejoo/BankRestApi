﻿using BankRestApi.Models.DTOs;

namespace BankRestApi.Services;

public class ExchangeService : IExchangeService
{
    private readonly HttpClient _httpClient;
    private readonly IConfiguration _config;
    
    public ExchangeService(HttpClient httpClient, IConfiguration config)
    {
        _httpClient = httpClient;
        _config = config;
    }
    public async Task<Dictionary<string, decimal>> GetExchangeRatesAsync(string currencies)
    {
        _httpClient.DefaultRequestHeaders.Add("apikey", _config["apikey"]);
        var response = await _httpClient.GetFromJsonAsync<FreeCurrencyApiResponse>("?currencies=" + currencies);
        return response.data;
    }
}