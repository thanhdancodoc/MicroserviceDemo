using System.Collections.Generic;
using PlatfromService.Models;

namespace PlatformService.Data
{
    public interface IPlatformRepository
    {
        bool SaveChanges();
        IEnumerable<Platform> GetAllPlatform();
        Platform GetPlatformById(int id);
        void CreatePlatform(Platform platform);
    }
}