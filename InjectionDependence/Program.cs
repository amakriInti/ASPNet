using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using System.Web.Mvc;

namespace InjectionDependence
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ligne à supprimer si NInject (ou Unity)
            var repo = new Repository(); // ou
            //var repo = new FakeRepository();

            Personnes ps = new Personnes(repo);
            foreach(var item in ps.Get())
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
    class Personnes
    {
        public Personnes()
        {

        }
        private IRepository Repo = null;
        public Personnes(IRepository repo)
        {
            Repo = repo;
        }
        public List<string> Get()
        {
            return Repo.Get();
        }
    }
    class FakeRepository : IRepository
    {
        private List<string> ListeInterne = new List<string>();
        public FakeRepository()
        {
            Add("Alain");
            Add("Brigitte");
        }
        public void Add(string nom)
        {
            ListeInterne.Add(nom);
        }

        public List<string> Get()
        {
            return ListeInterne;
        }
    }
    class Repository : IRepository
    {
        private List<string> ListeInterne = new List<string>();
        public Repository()
        {
            Add("Charles");
            Add("Denise");
        }
        public void Add(string nom)
        {
            ListeInterne.Add(nom);
        }

        public List<string> Get()
        {
            return ListeInterne;
        }
    }

    internal interface IRepository
    {
        void Add(string nom);
        List<string> Get();

    }
    class DemoNinject : IDependencyResolver
    {
        private IKernel kernel;
        public DemoNinject()
        {
            kernel = new StandardKernel();
            AddBindings();
        }

        private void AddBindings()
        {
            kernel.Bind<IRepository>().To<Repository>();
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
