using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ExtractTransform.Helpers;
using System.Web.Script.Serialization;
using ExtractTransform.Interfaces;

namespace ExtractTransform.Controllers
{
    public static class Controller
    {

        /// <summary>
        /// returns true if no errors occured
        /// </summary>
        /// <param name="rc"></param>
        /// <returns></returns>
        public static Result Run(RunConfig rc)
        {
            var ret = new Result();
            try
            {
                IExtract j = new JSON();
                ret.Items.Add("Getting:" + rc.URL + " With Params:" + rc.ParamsString);

                var method = (rc.PostValues == null || rc.PostValues.Any() == false) ? "GET" : "POST";

                var xx = j.DownloadPage(rc.URL, rc.PostValues, method, rc.Cookies);
                var xy = j.Extract(xx);
                ITransform c = new CSV();
                var result = c.Save(rc.OutputFilename, xy, new List<string> { "items", "results" });
                ret.Status = result.Status;
                ret.ErrorStatus = result.ErrorStatus;
                ret.Items.AddRange(result.Items);
            }
            catch (Exception ex)
            {
                ret.Status = false;
                ret.Items.Add(ex.ToString());
            }
            return ret;
        }
    }
}
