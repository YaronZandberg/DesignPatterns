using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class AdapterWebClienttoNormalClient : IDBWebData
    {
        IDBData perfectStoreFunction = new PerfectStore();

        public void Store(WebClientData webClientData)
        {
            perfectStoreFunction.Store(webClientData.GetClientData());
        }
    }
}
