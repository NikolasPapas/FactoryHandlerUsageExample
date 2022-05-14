using TestFactoryHandlerApplication.Common.Interfaces;

namespace TestFactoryHandlerApplication.Common.BaseAImplementation
{
    public abstract class EmployerBaseHandler : IHandler
    {
        public const string Type = "Employer";
        public string HandlerType => Type;

        public abstract Task<object> GetData();
    }
}