using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using DataObjects;

namespace Backend.Services;

public class CottageService : ICottageService
{
    private readonly HttpClient httpClient;

    public CottageService(HttpClient _httpClient)
    {
        httpClient = _httpClient;
    }

    public async Task<List<Cottage>> GetCottagesAsync()
    {
        return await httpClient.GetFromJsonAsync<List<Cottage>>("api/Cottage/all");
    }
}

public interface ICottageService
{
    Task<List<Cottage>> GetCottagesAsync();
}