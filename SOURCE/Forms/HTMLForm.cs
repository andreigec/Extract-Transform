using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ANDREICSLIB;

namespace ExtractTransform.Forms
{
    public static class HTMLForm
    {
        public static RunConfig ExtractFormParams(Form1 baseform)
        {
            var fn = NetExtras.MakeStringURLSafe(baseform.HtmlURLTB.Text) + ".csv";
            var rc = new RunConfig(RunConfig.ExtractMode.HTML, RunConfig.TransformMode.Invalid, baseform.HtmlURLTB.Text, null, fn, null, -1, -1, null);

            return rc;
        }
    }
}
