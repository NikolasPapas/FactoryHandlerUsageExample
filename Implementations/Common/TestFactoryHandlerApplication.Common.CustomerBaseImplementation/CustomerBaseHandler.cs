using TestFactoryHandlerApplication.Common.Interfaces;

namespace TestFactoryHandlerApplication.Common.CustomerBaseImplementation
{
    public abstract class CustomerBaseHandler : IHandler
    {
        public const string Type = "Customer";
        public string HandlerType => Type;
        public abstract Task<object> GetData();
    }
}