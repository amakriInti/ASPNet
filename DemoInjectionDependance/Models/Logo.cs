using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoInjectionDependance.Models
{
    public class LogoOrange : ILogo
    {
        public string Get() { return "orange.png"; }
    }
    public class LogoFree : ILogo
    {
        public string Get() { return "free.png"; }
    }
    public class LogoSfr : ILogo
    {
        public string Get() { return "sfr.png"; }
    }
    public interface ILogo
    {
        string Get();
    }
}