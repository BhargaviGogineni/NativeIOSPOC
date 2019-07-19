using System;
using System.Threading.Tasks;
using Refit;
using XamarinNativPOC.iOS.Models.Responses;

namespace XamarinNativPOC.iOS.Services
{
    public interface ISpeciesApi
    {
        [Get("/s/2iodh4vg0eortkl/facts.json")]
        Task<Country> GetSpecies();
    }
}
