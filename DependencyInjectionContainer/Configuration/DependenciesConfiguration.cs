using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjectionContainer.Configuration.ImplementationData;

namespace DependencyInjectionContainer.Configuration
{
    public class DependenciesConfiguration
    {
        public Dictionary<Type, List<ImplementationContainer>> DependenciesDictionary { get; private set; }

        public DependenciesConfiguration()
        {
            DependenciesDictionary = new Dictionary<Type, List<ImplementationContainer>>();
        }

        public void Register<TDependency, TImplementation>(LifeCycle ttl = LifeCycle.InstancePerDependency, ImplementationNumber number = ImplementationNumber.None)
            where TDependency : class
            where TImplementation : TDependency
        {
            Register(typeof(TDependency), typeof(TImplementation), ttl, number);
        }

        public void Register(Type dependencyType, Type implementType, LifeCycle ttl, ImplementationNumber number)
        {
            if (!IsDependency(implementType, dependencyType))
            {
                throw new ArgumentException("Incompatible parameters");
            }

            var implContainer = new ImplementationContainer(implementType, ttl, number);
            if (this.DependenciesDictionary.ContainsKey(dependencyType))
            {
                var index = this.DependenciesDictionary[dependencyType]
                    .FindIndex(elem => elem.ImplementationsType == implContainer.ImplementationsType);
                if (index != -1)
                {
                    this.DependenciesDictionary[dependencyType].RemoveAt(index);
                }

                this.DependenciesDictionary[dependencyType].Add(implContainer);

            }
            else
            {
                this.DependenciesDictionary.Add(dependencyType, new List<ImplementationContainer>() { implContainer });
            }
        }

        private bool IsDependency(Type implementation, Type dependency)
        {
            return implementation.IsAssignableFrom(dependency) || implementation.GetInterfaces().Any(i => i.ToString() == dependency.ToString());
        }
    }
}
