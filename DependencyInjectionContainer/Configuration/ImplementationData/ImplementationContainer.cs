using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionContainer.Configuration.ImplementationData
{
    public class ImplementationContainer
    {
        public Type ImplementationsType { get; }
        public LifeCycle TimeToLive { get; }
        public ImplementationNumber ImplNumber { get; }

        public ImplementationContainer(Type implementationsType, LifeCycle timeToLive, ImplementationNumber implNumber)
        {
            this.ImplNumber = implNumber;
            this.ImplementationsType = implementationsType;
            this.TimeToLive = timeToLive;
        }
    }
}
