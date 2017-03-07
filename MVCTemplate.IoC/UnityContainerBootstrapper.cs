using Microsoft.Practices.Unity;
using MVCTemplate.Data.Repositories;
using MVCTemplate.Domain.Sample;
using MVCTemplate.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTemplate.IoC
{
    public class UnityContainerBootstrapper
    {
        public static IUnityContainer RegisterTypes(IUnityContainer container)
        {
            //Register Repos
            container.RegisterType<ISampleRepository>(new InjectionFactory((c, t, s) => new SampleRepository()));

            //Register Services
            container.RegisterType<ISampleService>(new InjectionFactory((c, t, s) => new SampleService(
                  container.Resolve<ISampleRepository>()
            )));
            return container;
        }
    }
}
