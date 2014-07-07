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
				dynamic items = content;
				var c = new CsvExport();

				foreach (var k in startChildrenPoint)
				{
					items = items[k];
				}

				foreach (var row in items)
				{
					c.AddRow();

					foreach (KeyValuePair<string, object> kvp in row)
					{
						var key = kvp.Key;
						var val = kvp.Value;
						c[key] = val;
					}
				}
				ret.Items.Add("extracted:" + items.Count);
				c.ExportToFile(filename);
				ret.Status = items.Count > 0;
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
