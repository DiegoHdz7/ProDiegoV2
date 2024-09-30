using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using ProDiegoV2.Authorization.Users;
using ProDiegoV2.Editions;

namespace ProDiegoV2.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
