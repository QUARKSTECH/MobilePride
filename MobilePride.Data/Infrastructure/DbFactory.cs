
namespace MobilePride.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private MobilePrideContext _dbContext;

        public MobilePrideContext Init()
        {
            return _dbContext ?? (_dbContext = new MobilePrideContext());
        }

        protected override void DisposeCore()
        {
            _dbContext.Dispose();
        }
    }
}
