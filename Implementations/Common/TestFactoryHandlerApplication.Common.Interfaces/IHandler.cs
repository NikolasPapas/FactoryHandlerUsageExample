using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFactoryHandlerApplication.Common.Interfaces
{
    public interface IHandler
    {
        string HandlerType { get; }

        Task<object> GetData();

    }
}
