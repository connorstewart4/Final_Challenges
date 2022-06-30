using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;


public class UnitTest1
{
    private ClaimRepo _TRepo = new ClaimRepo();
        [Fact]
        public void Initialize()
        {
            _TRepo.AddClaim(new Claims(1, "Fire in kitchen", 400.00m, DateTime.Now, DateTime.Now));
        }

        [Fact]
        public void Claim_ClaimRepository_CanAddClaim()
        {

            _TRepo.AddClaim(new Claims(2, "Wreck on IN-37", 2500.00m, DateTime.Now, DateTime.Now));
            _TRepo.Dequeue();
            string actual = _TRepo.GetNextClaim().Description;
            string expected = "Wreck on IN-37";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Claim_ClaimRepository_CanGetNextClaim()
        {
            string actual = _TRepo.GetNextClaim().Description;
            string expected = "Fire in kitchen";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Claim_ClaimRepository_GetClaimsAsList()
        {
            var claim1 = new Claims(2, "House on Fire", 40000.00m, DateTime.Now, DateTime.Now);

            _TRepo.AddClaim(claim1);

            int actual = _TRepo.GetListOfClaims().Count;
            int expected = 1;

            Assert.Equal(expected, actual);
        }
}