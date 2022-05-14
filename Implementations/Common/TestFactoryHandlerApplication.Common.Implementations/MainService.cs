using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Logging;
using TestFactoryHandlerApplication.Common.Interfaces;
using TestFactoryHandlerApplication.Common.Types.Requests;
using TestFactoryHandlerApplication.Common.Types.Responses;

namespace TestFactoryHandlerApplication.Common.Implementations
{
    public class MainService : IMainService
    {
        private readonly IHandlerFactory _handlerFactory;
        private readonly ILogger<MainService> _logger;
        public MainService(
            IHandlerFactory handlerFactory,
            ILogger<MainService> logger)
        {
            _handlerFactory = handlerFactory;
            _logger = logger;
        }

        public async Task<GetDataResponse> GetData(GetDataRequest request)
        {
            var handler = _handlerFactory.Create(request.Type);
            if (handler != null)
                return new GetDataResponse() { Data = await handler.GetData() };
            return null;
        }
    }
}