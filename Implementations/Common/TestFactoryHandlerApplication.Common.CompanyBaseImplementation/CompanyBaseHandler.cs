using TestFactoryHandlerApplication.Common.Interfaces;

namespace TestFactoryHandlerApplication.Common.CompanyBaseImplementation
{
    public abstract class CompanyBaseHandler : IHandler
    {
        public const string Type = "Company";
        public string HandlerType => Type;

        public abstract Task<object> GetData();
    }
}