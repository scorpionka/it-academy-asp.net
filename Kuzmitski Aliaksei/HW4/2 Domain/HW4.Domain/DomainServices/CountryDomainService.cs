using HW4.Domain.DomainServices.Interfaces;
using HW4.Domain.Models;
using System.Collections.Generic;

namespace HW4.Domain.DomainServices
{
    public class CountryDomainService : BaseDomainService, ICountryDomainService
    {
        public bool CheckingThePresenceOfCityInTheCountry(int countryId, int cityId)
        {
            throw new System.NotImplementedException();
        }

        public List<Country> GetAllCountries()
        {
            throw new System.NotImplementedException();
        }
    }
}
