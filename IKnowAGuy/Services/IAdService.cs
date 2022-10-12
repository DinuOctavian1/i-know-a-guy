﻿using IKnowAGuy.Models;
namespace IKnowAGuy.Services
{
    public interface IAdService
    {
        IEnumerable<Ad> GetAllAds();

        Ad GetAdById(long id);

        bool CreateAd(Ad ad);

        IEnumerable<Ad> GetAdsByService(long serviceId);

        IEnumerable<Ad> GetAdsByJob(long jobId);

        IEnumerable<Ad> GetAdsByAddress(long addressId);
    }
}
