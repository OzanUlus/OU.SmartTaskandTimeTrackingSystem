namespace SmartTaskandTimeTrackingSystem.Shared.Services
{
    public class IdentityServiceFake : IIdentityService
    {
        public Guid GetUserId => Guid.Parse("53da6054-275b-4108-92cb-e66a09957368");

        public string UserName => "Ozan" ;
    }
}
