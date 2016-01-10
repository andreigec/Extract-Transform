using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using ExtractTransform.Helpers;

namespace ExtractTransform.AdaptorIn
{
    public class HTMLExtract : IExtract
    {
        public string DownloadPage(string url, string @params, string method, List<KeyValuePair<string, string>> cookies)
        {
            var page = ANDREICSLIB.NetExtras.DownloadWebPage(url);
            return page;
        }

        public Dictionary<string, object> Extract(string content)
        {
            var ret = new Dictionary<string, object>();
            return ret;
        }
    }
}
