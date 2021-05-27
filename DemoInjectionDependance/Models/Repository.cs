using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoInjectionDependance.Models
{
    public interface IRepository
    {
        List<string> Get();
    }
    public class Repository : IRepository
    {
        public List<string> Get() { return new List<string> { "Repo1", "Repo2"}; }

    }
    public class FakeRepository : IRepository
    {
        public List<string> Get() { return new List<string> { "FakeRepo1", "FakeRepo2" }; }
    }
}