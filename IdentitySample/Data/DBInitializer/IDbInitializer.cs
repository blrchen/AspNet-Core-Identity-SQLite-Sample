using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentitySample.Models
{
    public interface IDbInitializer
    {
        void Initialize();
    }
}
