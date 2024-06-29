using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneOfAKindSupreme.Frontend.Core.Interfaces.Api
{
    public interface IApi
    {
        /// <summary>
        /// Get data from API.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="endpoint"></param>
        /// <returns>Returns a deserialized response object of type T.</returns>
        Task<T?> GetFromApiAsync<T>(string endpoint);

        /// <summary>
        /// Post data to API.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="endpoint"></param>
        /// <param name="data">Request content</param>
        /// <returns>Returns a deserialized response object of type T.</returns>
        Task<T?> PostToApiAsync<T>(string endpoint, IApiDto data);
    }
}
