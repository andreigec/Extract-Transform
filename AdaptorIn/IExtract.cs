using System.Collections.Generic;

namespace ExtractTransform.AdaptorIn
{
    public interface IExtract
    {
        Dictionary<string, object> Extract(string content);

        string DownloadPage( string url, string @params, string method, List<KeyValuePair<string, string>> cookies);
    }
}
