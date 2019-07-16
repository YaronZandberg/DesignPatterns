using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //D3Shape d3Shape = new D3Shape();
            //
            //draw(new Adapter3Dto2D(), d3Shape);

            WebClientData webClientData = new WebClientData("Yaron", "315234963", "190.190.190.190", true);

            StoreClient(new AdapterWebClienttoNormalClient(), webClientData);

        }

        // non mutable
        //private static void draw(ID3Painter painter, D3Shape shape)
        //{
        //    painter.Paint3DShape(shape);
        //}

        private static void StoreClient(IDBWebData dBWebDataadapter, WebClientData webClientData)
        {
            dBWebDataadapter.Store(webClientData);
        }
    }
}
