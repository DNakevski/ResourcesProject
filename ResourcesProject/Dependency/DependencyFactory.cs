using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResourcesProject.Dependency
{
    public static class DependencyFactory
    {
        private static IUnityContainer _container;

        public static T Get<T>()
        {
            return _container.Resolve<T>();
        }

        public static T Get<T>(string name)
        {
            return _container.Resolve<T>(name);
        }

        private static void Init()
        {
            _container = new UnityContainer();
            UnityBootstrapper.RegisterTypes(_container);
        }

    }
}