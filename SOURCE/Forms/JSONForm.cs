using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ANDREICSLIB;

namespace ExtractTransform.Forms
{
    public static class JSONForm
    {
        public static RunConfig ExtractFormParams(Form1 baseform)
        {
            //get params from delta combo box
            var @params = GetJSONRunPostParams(baseform);
            int wait = -1;
            if (int.TryParse(baseform.waitTimeSeconds.Text, out wait) == false)
                wait = -1;

            int runCount = -1;
            if (int.TryParse(baseform.runCountCB.Text, out runCount) == false)
                runCount = -1;

            var fn = NetExtras.MakeStringURLSafe(baseform.urlTB.Text) + ".csv";
            var rc = new RunConfig(RunConfig.ExtractMode.JSON, RunConfig.TransformMode.Invalid, baseform.urlTB.Text, baseform.postTB.Text, fn, @params, runCount, wait, null);
            return rc;
        }

        private static List<Param> GetJSONRunPostParams(Form1 baseform)
        {
            var ret = new List<Param>();
            foreach (ListViewItem i in baseform.deltaLogicLV.Items)
            {
                var regex = i.Text;
                var change = long.Parse(i.SubItems[1].Text);
                var start = long.Parse(i.SubItems[2].Text);

                var p = new Param(regex, start, change);
                ret.Add(p);
            }
            return ret;
        }
    }
}
