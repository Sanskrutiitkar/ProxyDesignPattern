using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService___Proxy_pattern.model
{
    internal class RemoteDataService: IDataService
    {
        public string GetData()
        {
            Console.WriteLine("Fetching data from the remote server");
            return "Data from remote server";
        }
    }
}
