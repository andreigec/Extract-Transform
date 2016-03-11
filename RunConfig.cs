using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ANDREICSLIB.Extracters;
using ANDREICSLIB.Transformers;
using ExtractTransform.AdaptorIn;

namespace ExtractTransform
{
    public class RunConfig
    {
        public enum ExtractMode
        {
            Invalid, JSON, HTML
        }

        public enum TransformMode
        {
            Invalid, CSV
        }

        public IExtract Extractor { get; set; }
        public ITransform Transformer { get; set; }
        public List<KeyValuePair<string, string>> Cookies = new List<KeyValuePair<string, string>>();
        private string OrigURL;
        private string OrigPostValues;
        public string OutputFilename { get; private set; }
        private List<Param> Params;
        public ExtractMode Em { get; set; }
        public TransformMode Tm { get; set; }
        public int RunCountRemaining { get; private set; }
        private bool RunUntilDone = false;
        public int WaitTimeSec { get; private set; }
        public bool InsertHeader = true;
        public int? UniqueColumn;
        public string ParamsString
        {
            get { return Params?.Aggregate("", (a, b) => a + "," + b.Regex + ":" + b.Current); }
        }

        public void SetAdaptors()
        {
            switch (Em)
            {
                case ExtractMode.JSON:
                    Extractor = new JSONExtract();
                    break;
                case ExtractMode.HTML:
                  //  Extractor = new HTMLExtract();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(Em), Em, null);
            }

            switch (Tm)
            {
                case TransformMode.CSV:
                    Transformer = new CSVTransform();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(Tm), Tm, null);
            }
        }

        public RunConfig(ExtractMode em, TransformMode tm, string url, string postValues, string outputFilename, List<Param> @params, int runCountRemaining, int waitTimeSec, List<KeyValuePair<string, string>> cookies)
        {
            if (runCountRemaining == -1)
                RunUntilDone = true;

            Cookies = cookies;
            Em = em;
            Tm = tm;
            RunCountRemaining = runCountRemaining;
            WaitTimeSec = waitTimeSec;
            OrigURL = url;
            OrigPostValues = postValues;
            OutputFilename = outputFilename;
            Params = @params;
            InsertHeader = true;
        }

        public bool IncrementParams()
        {
            RunCountRemaining--;
            if (RunCountRemaining <= 0 && RunUntilDone == false)
                return false;
            foreach (var p in Params)
            {
                p.Current += p.Delta;
            }
            InsertHeader = false;
            return true;
        }
        public string URL => Subst(OrigURL);

        public string PostValues => Subst(OrigPostValues);

        private string Subst(string instr)
        {
            var outstr = instr;
            if (Params == null) return outstr;

            foreach (var p in Params)
            {
                outstr = outstr.Replace(p.Regex, p.Current.ToString(CultureInfo.InvariantCulture));
            }
            return outstr;
        }
    }
}