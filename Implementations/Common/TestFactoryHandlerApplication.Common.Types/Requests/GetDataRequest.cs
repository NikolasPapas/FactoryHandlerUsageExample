using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TestFactoryHandlerApplication.Common.Types.Requests
{
    /// <summary>
    /// Request to call TestFactoryHandlerContoller getData
    /// </summary>
    [DataContract]
    public class GetDataRequest
    {

        /// <summary>
        /// give the Type of the User type
        /// </summary>
        [DataMember(Name = "type")]
        public string Type { get; set; }
    }
}
