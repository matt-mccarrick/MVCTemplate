using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using MVCTemplate.IoC;

namespace MVCTemplate.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            UnityContainerBootstrapper.RegisterTypes(container);
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}