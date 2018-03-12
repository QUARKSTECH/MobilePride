using System;

namespace MobilePride.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        MobilePrideContext Init();
    }
}
