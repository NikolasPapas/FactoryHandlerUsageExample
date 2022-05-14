using TestFactoryHandlerApplication.Common.Types.Requests;
using TestFactoryHandlerApplication.Common.Types.Responses;

namespace TestFactoryHandlerApplication.Common.Interfaces
{
    public interface IMainService
    {
        /// <summary>
        /// return to Controller the data for tha request id
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GetDataResponse> GetData(GetDataRequest request);
    }
}