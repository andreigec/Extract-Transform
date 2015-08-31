using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractTransform.Interfaces
{
    interface IExtract
    {
        Dictionary<string, object> Extract(string content);

        string DownloadPage(string url, string @params, string method, List<KeyValuePair<string, string>> cookies);



    }
}
