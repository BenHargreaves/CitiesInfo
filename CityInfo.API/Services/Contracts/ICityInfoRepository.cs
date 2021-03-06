﻿using CityInfo.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Services.Contracts
{
    public interface ICityInfoRepository
    {
        IEnumerable<City> GetCities();

        City GetCity(int cityId, bool includePointsOfInterest);

        bool CityExists(int cityId);

        IEnumerable<PointOfInterest> GetPointsOfInterestForCity(int cityId);

        PointOfInterest GetPointOfInterestForCity(int cityId, int pointOfInterestId);
    }
}
