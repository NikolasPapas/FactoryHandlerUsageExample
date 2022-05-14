using TestFactoryHandlerApplication.Common.CompanyBaseImplementation;

namespace TestFactoryHandlerApplication.CompanyImplementation
{
    public class CompanyHandler : CompanyBaseHandler
    {
        public async override Task<object> GetData()
        {
            return new CompanyData()
            {
                Name = "TestCompany",
                Size = "Big",
                StreetAddress = "sdsdsds"
            };
        }
    }

    public class CompanyData
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public string StreetAddress { get; set; }
    }
}