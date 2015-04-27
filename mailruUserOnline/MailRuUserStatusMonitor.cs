using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

// 570 - red status image length
// 349 - green status image length

namespace mailruUserOnline{

	public static class MailRuUserStatusChecker{
		public const string STATUS_URL = "http://status.mail.ru/?";
		public static bool IsOnline(string addressToCheck){
			string addr = STATUS_URL + addressToCheck;
			WebClient client = new WebClient();
			if(client.DownloadData(new System.Uri(addr)).Length > 400) // see the file beginning. :D
				return false;
			return true;
		}
	}

	
	public class UserStatus{
		public string Username;
		public bool Status;

		public UserStatus(string username, bool status){
			Username = username;
			Status = status;
		}

		public void SwitchStatus(){
			Status = !Status;
		}
	}

	public delegate void UserStatusChangedHandler(object sender, UserStatus changed);

	public class MailRuUserStatusMonitor{
		private List<UserStatus> _usersL;
		
		public const int DEFAULT_CHECKPERIOD = 30000; // ms
		public const int DEFAULT_CHECKDELAY = 100; // ms
		private int _checkDelay = DEFAULT_CHECKDELAY;
		private Timer _checkTimer = new Timer();
		WebClient _client = new WebClient();

		public event UserStatusChangedHandler OnUserStatusChanged;

		#region Structings
		public MailRuUserStatusMonitor(){
			_usersL = new List<UserStatus>();
			_checkTimer.Interval = DEFAULT_CHECKPERIOD;
			_checkTimer.Tick += CheckTimer_Tick;
		}
		public MailRuUserStatusMonitor(List<string> addressList, UserStatusChangedHandler onUserStatusChanged, bool startNow){
			_usersL = new List<UserStatus>();
			_checkTimer.Interval = DEFAULT_CHECKPERIOD;
			_checkTimer.Tick += CheckTimer_Tick;

			OnUserStatusChanged += onUserStatusChanged;

			foreach (var addr in addressList){
				_usersL.Add(new UserStatus(addr, false));
			}

			if(startNow)
				Start();
		}
		#endregion

		#region Settings
		public void SetUserListToMonitor(List<string> addressList, bool clearOldList){
			if(clearOldList) _usersL.Clear();
			foreach (var addr in addressList){
				_usersL.Add(new UserStatus(addr, false));
			}
		}
		public void SetCheckPeriod(int period_ms){
			_checkTimer.Stop();
			_checkTimer.Interval = period_ms;
			_checkTimer.Start();
		}
		public void SetCheckDelay(int delay_ms){
			_checkTimer.Stop();
			_checkDelay = delay_ms;
			_checkTimer.Start();
		}
		public void Start(){
			if(!_checkTimer.Enabled)
				_checkTimer.Start();
		}
		public void Stop(){
			if (_checkTimer.Enabled)
				_checkTimer.Stop();
		}
		#endregion

		#region Checking
		void CheckTimer_Tick(object sender, EventArgs e){
			foreach(var u in _usersL){
				if(IsOnline(u.Username) != u.Status){
					u.SwitchStatus();
					if(OnUserStatusChanged!=null)
						OnUserStatusChanged(this, u);
				}
				System.Threading.Thread.Sleep(_checkDelay);
			}
		}

		public bool IsOnline(string addressToCheck){
			string addr = MailRuUserStatusChecker.STATUS_URL + addressToCheck;
			if (_client.DownloadData(new System.Uri(addr)).Length > 400) // see the file beginning. :D
				return false;
			return true;
		}
		#endregion
	}
}


//var img = Image.FromStream(new MemoryStream(client.DownloadData(new System.Uri(addr)));