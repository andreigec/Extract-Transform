using System.Collections.Generic;
using ExtractTransform.Helpers;

namespace ExtractTransform.AdaptorOut
{
    public interface ITransform
    {
        Result Save(string filename, Dictionary<string, object> content, List<string> startChildrenPoint, bool header, int? uniqueColumn);
    }
}
