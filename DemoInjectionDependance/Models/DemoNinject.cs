using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoInjectionDependance.Models
{
    public class DemoNinject : IDependencyResolver
    {
        private IKernel kernel;
        public DemoNinject()
        {
            kernel = new StandardKernel();
            AddBindings();
        }

        private void AddBindings()
        {
            var repoType = Type.GetType( Properties.Settings.Default.Repository);
            var logoType= Type.GetType(Properties.Settings.Default.Logo);
            kernel.Bind<IRepository>().To(repoType);
            kernel.Bind<ILogo>().To(logoType);
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
    }
}