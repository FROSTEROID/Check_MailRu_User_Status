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

        public const string STATUS_URL = "http://status.mail.ru/?";
        WebClient _client;

        public Form1(){
			_client = new WebClient();
			_client.DownloadDataCompleted += Client_DownloadDataCompleted;
            InitializeComponent();
        }

		void Client_DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e){
			MessageBox.Show(e.Result.Length.ToString());
			var img = Image.FromStream(new System.IO.MemoryStream(e.Result));
			pb_status.Image = img;
		}

        private void b_check_Click(object sender, EventArgs e){
            string addr = STATUS_URL+tb_addr.Text;
			_client.DownloadDataAsync(new System.Uri(addr));
        }
    }
}
