using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;

namespace mailruUserOnline
{
    public partial class Form1 : Form
    {

        public Form1(){
			#region ManualChecking	
			_client = new WebClient();
			_client.DownloadDataCompleted += Client_DownloadDataCompleted;
			#endregion
			#region Monitoring
			#endregion
            InitializeComponent();
        }

		#region ManualChecking
		public const string STATUS_URL = "http://status.mail.ru/?";
        WebClient _client;
		void Client_DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e){
			MessageBox.Show(e.Result.Length.ToString());
			var img = Image.FromStream(new System.IO.MemoryStream(e.Result));
			pb_status.Image = img;
		}

        private void b_check_Click(object sender, EventArgs e){
            string addr = STATUS_URL+tb_addr.Text;
			_client.DownloadDataAsync(new System.Uri(addr));
        }
		#endregion

		#region Monitoring
		MailRuUserStatusMonitor _monitor;
		private void b_makeMonitor_Click(object sender, EventArgs e){
			var l = new List<string>();
			foreach(var it in lb_addrList.Items)
				l.Add(it.ToString());
			
			_monitor = new MailRuUserStatusMonitor(l,Monitor_OnUserStatusChanged,false);
			_monitor.SetCheckPeriod(1000);
			_monitor.Start();
		}
		void Monitor_OnUserStatusChanged(object sender, UserStatus newStatus){
			MessageBox.Show(newStatus.Username + ":  " + newStatus.Status);
		}
		#endregion
    }
}
