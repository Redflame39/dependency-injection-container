using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjectionContainer.Configuration.ImplementationData;

namespace DependencyInjectionContainer.Provider
{
    [AttributeUsage(AttributeTargets.Parameter)]
    public class DependencyKeyAttribute : Attribute
    {
        public ImplementationNumber ImplNumber { get; }

        public DependencyKeyAttribute(ImplementationNumber number)
        {
            this.ImplNumber = number;
        }
    }
}
