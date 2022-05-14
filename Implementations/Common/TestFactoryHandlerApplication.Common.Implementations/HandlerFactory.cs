using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFactoryHandlerApplication.Common.Interfaces;
using TestFactoryHandlerApplication.CompanyImplementation;
using TestFactoryHandlerApplication.CustomerImplementation;
using TestFactoryHandlerApplication.EmployerImplementation;

namespace TestFactoryHandlerApplication.Common.Implementations
{
    public class HandlerFactory : IHandlerFactory
    {
        private readonly IServiceProvider _provider;
        public HandlerFactory(IServiceProvider provider)
        {
            _provider = provider;
        }

        public IHandler Create(string applicationType)
        {
            if (string.Equals(applicationType, CompanyHandler.Type))
                return (IHandler)ActivatorUtilities.CreateInstance(_provider, Type.GetType("TestFactoryHandlerApplication.CompanyImplementation.CompanyHandler, TestFactoryHandlerApplication.CompanyImplementation")); //<CompanyHandler>
            else if (string.Equals(applicationType, EmployerHandler.Type))
                return (IHandler)ActivatorUtilities.CreateInstance(_provider, Type.GetType("TestFactoryHandlerApplication.EmployerImplementation.EmployerHandler, TestFactoryHandlerApplication.EmployerImplementation")); //<EmployerHandler>
            else if (string.Equals(applicationType, CustomerHandler.Type))
                return (IHandler)ActivatorUtilities.CreateInstance(_provider, Type.GetType("TestFactoryHandlerApplication.CustomerImplementation.CustomerHandler, TestFactoryHandlerApplication.CustomerImplementation")); //<CustomerHandler>
            return null;
        }
    }
}
