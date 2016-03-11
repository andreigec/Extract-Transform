using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using ANDREICSLIB.ClassExtras;
using ANDREICSLIB.Extracters;
using ANDREICSLIB.Helpers;
using ExtractTransform.Helpers;
using HtmlAgilityPack;

namespace ExtractTransform.AdaptorIn
{
    public class HTMLExtract1 : IExtract
    {
        public async Task<string> DownloadPage(string url, string @params, string method, List<KeyValuePair<string, string>> cookies)
        {
            var page = await NetExtras.DownloadWebPage(url);
            return page;
        }

        public Dictionary<string, object> Extract(string content)
        {
            var doc = new HtmlDocument();
            doc.LoadHtml(content);


            var ret = new Dictionary<string, object>();
            return ret;
        }
    }
}
