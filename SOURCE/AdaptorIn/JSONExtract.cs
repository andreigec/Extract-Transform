using System.Collections.Generic;
using System.Web.Script.Serialization;
using ExtractTransform.Helpers;

namespace ExtractTransform.AdaptorIn
{
    public class JSONExtract : IExtract
    {
        public string DownloadPage(string url, string @params, string method = "POST", List<KeyValuePair<string, string>> cookies = null)
        {
            var jsr = new JsonRequest();

            var rex = jsr.Execute(url, @params, method, cookies);
            return rex.ToString();
        }

        public Dictionary<string, object> Extract(string content)
        {
            var serializer = new JavaScriptSerializer();
            serializer.RegisterConverters(new[] { new DynamicJsonConverter() });

            var obj = serializer.Deserialize(content, typeof(object));
            var d = ((DynamicJsonConverter.DynamicJsonObject)obj)._dictionary;
            return (Dictionary<string, object>)d;
        }
    }
}
