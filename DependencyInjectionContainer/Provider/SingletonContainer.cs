using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjectionContainer.Configuration.ImplementationData;

namespace DependencyInjectionContainer.Provider
{
    public class SingletonContainer
    {
        public readonly ImplementationNumber ImplNumber;

        public readonly object Instance;

        public SingletonContainer(object instance, ImplementationNumber number)
        {
            this.ImplNumber = number;
            this.Instance = instance;
        }
    }
}
