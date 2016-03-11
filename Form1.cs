using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using ANDREICSLIB;
using ANDREICSLIB.ClassExtras;
using ANDREICSLIB.Licensing;
using ExtractTransform.Controllers;
using ExtractTransform.Forms;

namespace ExtractTransform
{
    public partial class Form1 : Form
    {
        #region licensing
        private const String HelpString = "";

        private readonly String OtherText =
            @"©" + DateTime.Now.Year +
            @" Andrei Gec (http://www.andreigec.net)

Licensed under GNU LGPL (http://www.gnu.org/)

Zip Assets © SharpZipLib (http://www.sharpdevelop.net/OpenSource/SharpZipLib/)
";

        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Licensing.LicensingForm(this, menuStrip1, HelpString, OtherText);

            runCountCB.SelectedIndex = runCountCB.Items.Count - 1;
            waitTimeSeconds.SelectedIndex = 0;
            CheckForIllegalCrossThreadCalls = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool Running = false;
        private Thread runThread;

        private void goB_Click(object sender, EventArgs e)
        {
            if (Running)
            {
                ToggleRun(false);
            }
            else
            {
                outputTB.Text = "";
                ToggleRun(true);
                try
                {
                    RunConfig rc = null;
                    if (tabControl1.SelectedTab.Text == "JSON")
                        rc = JSONForm.ExtractFormParams(this);
                    else if (tabControl1.SelectedTab.Text == "HTML")
                        rc = HTMLForm.ExtractFormParams(this);

                    if (rc == null)
                        throw new Exception("Error getting run config");

                    //set csv for now
                    rc.Tm = RunConfig.TransformMode.CSV;
                    rc.SetAdaptors();

                    runThread = new Thread(() => RunThread(rc, this));
                    runThread.Start();
                }
                catch (Exception ex)
                {
                    outputTB.Text = "Error:" + ex;
                    ToggleRun(false);
                }
            }
        }

        private void ToggleRun(bool enabled)
        {
            Running = enabled;
            tabControl1.Enabled = !enabled;

            outputTB.ReadOnly = enabled;
            goB.Text = enabled ? "Abort" : "Run";

            if (enabled == false)
            {
                if (runThread != null)
                    runThread.Abort();
                runThread = null;
            }
        }

        private static void RunThread(RunConfig rc, Form1 f)
        {
            try
            {
                //keep going until error
                while (true)
                {
                    DateTime start = DateTime.Now;
                    var res = Controller.Run(rc);

                    foreach (var i in res.Items)
                    {
                        f.outputTB.Text += "\r\n" + i;
                    }
                    f.outputTB.Text += $"\r\nRuntime(MS):{(DateTime.Now - start).TotalMilliseconds}";
                    TextboxExtras.ScrollToEnd(f.outputTB);

                    if (res.Status == false)
                        break;
                    //increment params
                    var ok = rc.IncrementParams();
                    if (ok == false)
                        break;
                    Thread.Sleep(rc.WaitTimeSec * 1000);
                }
            }
            catch (Exception ex)
            {
            }
            f.ToggleRun(false);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (runThread != null)
                runThread.Abort();
        }
    }
}
