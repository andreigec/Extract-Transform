using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using ANDREICSLIB.ClassExtras;
using ANDREICSLIB.Helpers;
using ExtractTransform.Helpers;
using HtmlAgilityPack;

namespace ExtractTransform.AdaptorIn
{
    public class HTMLExtract : IExtract
    {
        public string DownloadPage(string url, string @params, string method, List<KeyValuePair<string, string>> cookies)
        {
            var page = AsyncHelpers.RunSync(() => NetExtras.DownloadWebPage(url));
            return page;
        }

        public Dictionary<string, object> Extract(string content)
        {
            var Webget = new HtmlWeb();
            var doc = Webget.Load(url);
            foreach (HtmlNode node in doc.DocumentNode.SelectNodes("//h2//a"))
            {
                names.Add(node.ChildNodes[0].InnerHtml);
            }
            foreach (HtmlNode node in doc.DocumentNode.SelectNodes("//li[@class='tel']//a"))
            {
                phones.Add(node.ChildNodes[0].InnerHtml);
            }

            var ret = new Dictionary<string, object>();
            return ret;
        }
    }
}
