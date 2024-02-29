using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using SharedLibrary.Entities;

namespace Backend.Services;

public interface ICottageService
{
    Task<List<Cottage>> GetCottagesAsync();
    Task<Cottage> GetCottageAsync(int id);
    Task<HttpResponseMessage> CreateCottageAsync(Cottage cottage);
    Task<HttpResponseMessage> UpdateCottageAsync(Cottage cottage);
    Task<HttpResponseMessage> DeleteCottageAsync(int id);
}