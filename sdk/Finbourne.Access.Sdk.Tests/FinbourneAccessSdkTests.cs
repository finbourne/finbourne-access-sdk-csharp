using Finbourne.Access.Sdk.Api;
using Finbourne.Access.Sdk.Utilities;
using NUnit.Framework;

namespace Finbourne.Acces.Sdk.Tests
{
    [TestFixture]
    public class FinbourneAccessSdkTests
    {
        private IAccessApiFactory _apiFactory;

        [OneTimeSetUp]
        public void SetUp()
        {
            _apiFactory = AccessApiFactoryBuilder.Build("secrets.json");
        }
        
        [Test]
        public void Get_User_Policies()
        {
            var policies = _apiFactory.Api<IPoliciesApi>().GetOwnPolicies();
            
            Assert.That(policies.Count, Is.GreaterThan(0), "no policies found");
        }

    }
}