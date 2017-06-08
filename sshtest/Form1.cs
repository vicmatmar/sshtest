using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Threading;
using System.Net;
using System.Net.NetworkInformation;
using System.DirectoryServices;



using Renci.SshNet;

namespace sshtest
{
    public partial class Form1 : Form
    {
        Task _pingScanTask;
        CancellationTokenSource _cancelPing;

        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            label_mactoip_ms.Text = "";
        }

        void cancelPingTask()
        {
            if (_pingScanTask != null)
            {
                if (!_pingScanTask.IsCompleted && _cancelPing != null && _cancelPing.Token.CanBeCanceled)
                {
                    _cancelPing.Cancel();
                    _pingScanTask.Wait(250);
                }
            }
        }
        void startPingScanTask()
        {
            cancelPingTask();            

            _cancelPing = new CancellationTokenSource();
            _pingScanTask = new Task(() => pingScan("172.19", _cancelPing));
            _pingScanTask.Start();
        }

        void pingScan(string ipBase, CancellationTokenSource cancel)
        {
            if (cancel.IsCancellationRequested)
                return;

            bool return_on_exception = true;
            for (int y = 0; y < 255; y++)
            {
                for (int x = 1; x < 255; x++)
                {
                    if (cancel.IsCancellationRequested)
                        return;

                    string ip = string.Format("{0}.{1}.{2}", ipBase, y, x);
                    Ping p = new Ping();
                    try
                    {
                        p.SendAsync(ip, 50, new byte[] { 0x5A }, ip);
                    }
                    catch {
                        if(return_on_exception)
                            return;
                    }
                }
            }
        }

        private void button_Run_Click(object sender, EventArgs e)
        {
            run_cmd();
        }

        void run_cmd()
        {
            Stopwatch st = new Stopwatch();
            st.Start();

            // Get ip from mac if ip not specified
            while (textBox_HostName.Text == "")
            {
                string ip = getIpFromMAC(textBox_MacAddr.Text);
                if (ip != null)
                {
                    cancelPingTask();  // Just in case we started it

                    textBox_HostName.Text = ip;
                    break;
                }
                else
                {
                    // Start a ping scan to try to force it into the arp table
                    if (_pingScanTask == null || _pingScanTask.Status != TaskStatus.Running)
                    {
                        startPingScanTask();
                        Thread.Sleep(250);
                    }
                }
            }
            st.Stop();
            label_mactoip_ms.Text = st.Elapsed.ToString();

            string host = textBox_HostName.Text;
            string user = textBox_Username.Text;
            string opensshkey_file = textBox_Keyfile.Text;
            string cmdstr = textBox_Command.Text;

            var atm = new AuthenticationMethod[]
            {
                new PasswordAuthenticationMethod(user, ""),

                new PrivateKeyAuthenticationMethod(user, new PrivateKeyFile[] {
                    new PrivateKeyFile(opensshkey_file) })
            };


            var conInfo = new ConnectionInfo(host, 22, user, atm);

            using (var client = new SshClient(conInfo))
            {
                client.Connect();
                using (var cmd = client.CreateCommand(cmdstr))
                {
                    string outstr = cmd.Execute();
                    textBox_Output.Text = outstr.Replace("\n", "\r\n");
                }

                client.Disconnect();
            }

        }

        private void button_keyBrowse_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox_Keyfile.Text = dlg.FileName;
            }
        }


        /// <summary>
        /// Seraches arp table for specified mac
        /// </summary>
        /// <param name="mac"></param>
        /// <returns>Corresponding ip or null if not found</returns>
        string getIpFromMAC(string mac)
        {
            string arp = getARPResult();

            string arp_mac = mac.ToLower().Replace(':', '-');

            Regex r = new Regex(@"(\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3})\s{1,}(" + arp_mac + ")");
            Match m = r.Match(arp);

            if (m.Success && m.Groups.Count > 1)
            {
                return m.Groups[1].Value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Just returns "arp -a" command output
        /// </summary>
        /// <returns></returns>
        static string getARPResult()
        {
            Process p = null;
            string output = string.Empty;

            try
            {
                p = Process.Start(new ProcessStartInfo("arp", "-a")
                {
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardOutput = true
                });

                output = p.StandardOutput.ReadToEnd();

            }
            catch (Exception ex)
            {
                throw new Exception("IPInfo: Error Retrieving 'arp -a' Results", ex);
            }
            finally
            {
                if (p != null)
                {
                    p.Close();
                }
            }

            return output;
        }
    }
}
