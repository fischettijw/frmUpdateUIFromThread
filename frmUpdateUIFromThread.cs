using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmUpdateUIFromThread
{
    public partial class frmUpdateUIFromThread : Form
    {
        Control control;
        public frmUpdateUIFromThread()
        {
            InitializeComponent();
        }
        private void frmUpdateUIFromThread_Load(object sender, EventArgs e)
        {
            control = LbxTxtLog; //this can be any control
            numThreads.Value = 14;
        }

        private void Log(string msg)
        {
            string m = $"{DateTime.Now.ToString("H:mm:ss.fffff")}\t{msg}\n\n";
            control.BeginInvoke((MethodInvoker)delegate ()
            {
                LbxTxtLog.Items.Add(m);
                LbxTxtLog.TopIndex = LbxTxtLog.Items.Count - 1;
            });
        }
        private async void btnStartThreads_Click(object sender, EventArgs e)
        {
            LbxTxtLog.Items.Clear();
            Random random = new Random();
            List<Task> allTasks = new List<Task>();

            for (int i = 1; i <= (int)numThreads.Value; i++)
            {
                var j = i;
                var delayFor = TimeSpan.FromMilliseconds(random.Next(100, 5000));
                var task = Task.Run(async () =>
                {
                    var idForLog = $"Task ID {j}, ThreadID={Thread.CurrentThread.ManagedThreadId}";

                    Log($"{idForLog} starting processing");

                    await Task.Delay(delayFor);

                    Log($"{idForLog} finished. Took {delayFor.TotalSeconds}");
                });

                allTasks.Add(task);
            }

            await Task.WhenAll(allTasks);

            Log("All tasks have finished");
        }

    }
}

//  https://makolyte.com/how-to-update-ui-from-another-thread/
