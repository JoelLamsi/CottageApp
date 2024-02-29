using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using SharedLibrary.Entities;

namespace Backend.Services;

public class CottageService : ICottageService
{
    private readonly HttpClient _httpClient;
    private readonly IConfiguration _configuration;

    public CottageService(HttpClient httpClient, IConfiguration configuration)
    {
        _httpClient = httpClient;
        _configuration = configuration;
    }

    public async Task<List<Cottage>> GetCottagesAsync()
    {
        try
        {
            var response = await _httpClient.GetFromJsonAsync<List<Cottage>>($"api/Cottage/all");
            if (response.Count > 0)
            {
                return response;
            }
            return null;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            throw;
        }
    }

    public async Task<Cottage> GetCottageAsync(int id)
    {
        try
        {
            return await _httpClient.GetFromJsonAsync<Cottage>($"api/Cottage/{id}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            throw;
        }
    }

    public async Task<HttpResponseMessage> CreateCottageAsync(Cottage cottage)
    {
        try
        {
            var result = await _httpClient.PostAsJsonAsync<Cottage>($"{_configuration.GetValue<string>("ApiBaseAddress")}api/Cottage", cottage);
            
            return result;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            throw;
        }
    }
    
    public async Task<HttpResponseMessage> UpdateCottageAsync(Cottage cottage)
    {
        try
        {
            var itemJson = new StringContent(JsonSerializer.Serialize(cottage), Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync($"{_configuration.GetValue<string>("ApiBaseAddress")}api/Cottage/{cottage.Id}", itemJson);

            return response;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            throw;
        }
    }

    public async Task<HttpResponseMessage> DeleteCottageAsync(int id)
    {
        try
        {
            var response = await _httpClient.DeleteAsync($"{_configuration.GetValue<string>("ApiBaseAddress")}api/Cottage/{id}");
            return response;
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            throw;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            throw;
        }
    }
}