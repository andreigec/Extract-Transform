using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using ExtractTransform.Helpers;
using ExtractTransform.Interfaces;

namespace ExtractTransform
{
	public class JSON : IExtract
	{
		public string DownloadPage(string url, string @params, List<KeyValuePair<string, string>> cookies)
		{
			var jsr = new JsonRequest();

			var rex = jsr.Execute(url, @params, "POST", cookies);
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
