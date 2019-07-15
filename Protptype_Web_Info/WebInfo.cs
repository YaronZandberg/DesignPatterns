using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protptype_Web_Info
{
    public class WebInfo : IProtoType<WebInfo>
    {
        public DateTime timestamp;
        public string size;
        public string url;

        public WebInfo(DateTime timestamp, string size, string url)
        {
            this.timestamp = timestamp;
            this.size = size;
            this.url = url;
        }

        public WebInfo clone()
        {
            return new WebInfo(timestamp, size, url);
        }

        public string ToString()
        {
            string finalString = $"URL: {timestamp} size: {size} url: {url}";
            return finalString;
        }
    }
}
