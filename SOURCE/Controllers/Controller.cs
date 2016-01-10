﻿using System;
using System.Collections.Generic;
using System.Globalization;
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
                //try and set unique col
                if (rc.UniqueColumn == null)
                {
                    rc.UniqueColumn = GuessUnique(xy); 
                }
                var result = c.Save(rc.OutputFilename, xy, new List<string> { "items", "results" }, rc.InsertHeader, rc.UniqueColumn);
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

        private static int? GuessUnique(Dictionary<string, object> row)
        {
            //try id and int
            long testlong;
            var idcol =
                row.Keys.Where(s => s.EndsWith("id", true, CultureInfo.CurrentCulture))
                    .Where(s => row[s] != null && long.TryParse((string)row[s], out testlong));

            var key = idcol.FirstOrDefault();
            //get index

            if (string.IsNullOrEmpty(key) == false)
            {
                var i = 0;
                foreach (var k in row.Keys)
                {
                    if (k == key)
                        break;
                    i++;
                }
                if (i == row.Keys.Count - 1)
                    i = -1;

                if (i != -1)
                    return i;
            }
            return null;
        }
    }
}
