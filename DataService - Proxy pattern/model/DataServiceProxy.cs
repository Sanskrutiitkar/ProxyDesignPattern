using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService___Proxy_pattern.model
{
    internal class DataServiceProxy : IDataService
    {
        private RemoteDataService _remoteDataService;
        private string _cachedData;

        public string GetData()
        {
            // Check if data is already cached
            if (_cachedData == null)
            {
                if (_remoteDataService == null)
                {
                    _remoteDataService = new RemoteDataService();
                }
                //GetData() will only return "Data from remote server"
                _cachedData = _remoteDataService.GetData();
            }
            else
            {
                Console.WriteLine("Returning cached data");
            }
            return _cachedData;
        }

    }
}
