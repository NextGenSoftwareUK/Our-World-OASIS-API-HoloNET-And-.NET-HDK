using System;
using System.Threading.Tasks;
using NextGenSoftware.OASIS.API.Core.Enums;
using NextGenSoftware.OASIS.API.Core.Helpers;
using NextGenSoftware.OASIS.API.Core.Interfaces.STAR;
using NextGenSoftware.OASIS.STAR.CelestialBodies;

namespace NextGenSoftware.OASIS.STAR.TestHarness.Genesis
{
    public class TheJusticeLeagueAccademy : Moon, IMoon
    {
        public TheJusticeLeagueAccademy() : base(new Guid("ddce1076-63c0-423a-8838-81c174c4a88c")) { }
 
        public OASISResult<SuperTest> LoadSuperTest(Guid id)
        {
            return base.CelestialBodyCore.LoadHolon<SuperTest>(id);
        }

        public async Task<OASISResult<SuperTest>> LoadSuperTestAsync(Guid id)
        {
            return await base.CelestialBodyCore.LoadHolonAsync<SuperTest>(id);
        }

        public OASISResult<SuperTest> LoadSuperTest(ProviderType providerType, string providerKey)
        {
            return base.CelestialBodyCore.LoadHolon<SuperTest>(providerType, providerKey);
        }

        public async Task<OASISResult<SuperTest>> LoadSuperTestAsync(ProviderType providerType, string providerKey)
        {
            return await base.CelestialBodyCore.LoadHolonAsync<SuperTest>(providerType, providerKey);
        }

        public OASISResult<SuperTest> SaveSuperTest(SuperTest holon)
        {
            return base.CelestialBodyCore.SaveHolon<SuperTest>(holon);
        }

        public async Task<OASISResult<SuperTest>> SaveSuperTestAsync(SuperTest holon)
        {
            return await base.CelestialBodyCore.SaveHolonAsync<SuperTest>(holon);
        }

        public OASISResult<SuperHolon> LoadSuperHolon(Guid id)
        {
            return base.CelestialBodyCore.LoadHolon<SuperHolon>(id);
        }

        public async Task<OASISResult<SuperHolon>> LoadSuperHolonAsync(Guid id)
        {
            return await base.CelestialBodyCore.LoadHolonAsync<SuperHolon>(id);
        }

        public OASISResult<SuperHolon> LoadSuperHolon(ProviderType providerType, string providerKey)
        {
            return base.CelestialBodyCore.LoadHolon<SuperHolon>(providerType, providerKey);
        }

        public async Task<OASISResult<SuperHolon>> LoadSuperHolonAsync(ProviderType providerType, string providerKey)
        {
            return await base.CelestialBodyCore.LoadHolonAsync<SuperHolon>(providerType, providerKey);
        }

        public OASISResult<SuperHolon> SaveSuperHolon(SuperHolon holon)
        {
            return base.CelestialBodyCore.SaveHolon<SuperHolon>(holon);
        }

        public async Task<OASISResult<SuperHolon>> SaveSuperHolonAsync(SuperHolon holon)
        {
            return await base.CelestialBodyCore.SaveHolonAsync<SuperHolon>(holon);
        }
   }
}