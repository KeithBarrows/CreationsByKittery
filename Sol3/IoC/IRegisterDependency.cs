using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol3.IoC
{
    /// <summary>
    /// When registering IoC objects, if it has this Interface, get it's concrete type and register it...
    /// </summary>
    public interface IRegisterDependency { }
}
