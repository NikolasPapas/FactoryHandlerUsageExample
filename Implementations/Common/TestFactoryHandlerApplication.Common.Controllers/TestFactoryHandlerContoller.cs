using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestFactoryHandlerApplication.Common.Interfaces;
using TestFactoryHandlerApplication.Common.Types.Requests;
using TestFactoryHandlerApplication.Common.Types.Responses;

namespace TestFactoryHandlerApplication.Common.Controllers
{
    [Route("testfactoryhandler")]
    [ApiController]
    public class TestFactoryHandlerContoller : ControllerBase
    {
        private readonly IMainService _mainService;
        private readonly ILogger<TestFactoryHandlerContoller> _logger;

        public TestFactoryHandlerContoller(IMainService mainService, ILogger<TestFactoryHandlerContoller> logger)
        {
            _mainService = mainService;
            _logger = logger;
        }

        /// <summary>
        /// tha values of the type = Company | Employer | Customer
        /// </summary>
        /// <param name="request"> Get tha Type of Instance you wont </param>
        /// <returns>the data of that instsance</returns>
        [HttpPost]
        [Route("getData")]
        public async Task<GetDataResponse> GetData(GetDataRequest request)
        {
            return await _mainService.GetData(request);
        }
    }
}