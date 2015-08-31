using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtractTransform.Helpers;
using ExtractTransform.Interfaces;

namespace ExtractTransform.Controllers
{
    public class CSV : ITransform
    {
        public Result Save(string filename, Dictionary<string, object> content, List<string> startChildrenPoint)
        {
            var ret = new Result();
            try
            {
                var c = new CsvExport();

                c.AddRow();

                foreach (KeyValuePair<string, object> kvp in content)
                {
                    var key = kvp.Key;
                    var val = kvp.Value;
                    c[key] = val;
                }

                ret.Items.Add("extracted:" + content.Count);
                c.ExportToFile(filename);
                ret.Status = content.Count > 0;
            }
            catch (Exception ex)
            {
                ret.ErrorStatus = ex.ToString();
                ret.Items.Add(ex.ToString());
            }

            return ret;
        }
    }
}
