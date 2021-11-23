using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionContainer.Configuration.ImplementationData
{
    [Flags]
    public enum ImplementationNumber
    {
        None,
        First,
        Second,
        Any = None | First | Second,
    }
}
