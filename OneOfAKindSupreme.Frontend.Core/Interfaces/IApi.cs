using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneOfAKindSupreme.Frontend.Core.Interfaces
{
    public interface IApi
    {
        Task<T> List<T>(string endpoint);
    }
}
