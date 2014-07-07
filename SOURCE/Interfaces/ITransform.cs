using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtractTransform.Helpers;

namespace ExtractTransform.Interfaces
{
	public interface ITransform
	{
		Result Save(string filename, Dictionary<string, object> content, List<string> startChildrenPoint);
	}
}
