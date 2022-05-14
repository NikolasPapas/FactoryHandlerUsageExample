using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TestFactoryHandlerApplication.Common.Types.Responses
{
    /// <summary>
    /// return tha requested data from tha api
    /// </summary>
    [DataContract]
    public class GetDataResponse
    {
        /// <summary>
        /// tha list from data objects 
        /// </summary>
        [DataMember(Name = "data")]
        public object Data { get; set; }
    }
}
