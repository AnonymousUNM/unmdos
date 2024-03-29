/* unmdosx - Low Orbit Ion Cannon
 * Released to the public domain
 * Enjoy getting v&, kids.
 */

using System;
using System.Windows.Forms;

namespace unmdosx
{
	static class Program
	{
		[STAThread]
		static void Main(string[] cmdLine)
		{
			bool hive = false, hide = false;
			string ircserver = "", ircport = "", ircchannel = "";

			int count = 0;
			foreach(string s in cmdLine)
			{
				if(s.ToLowerInvariant() == "/hidden") {
					hide = true;
				}

				// IRC
				if(s.ToLowerInvariant() == "/hivemind") {
					hive = true;
					ircserver = cmdLine[count + 1]; //if no server entered let it crash
					try {ircport = cmdLine[count + 2];}
					catch(Exception) {ircport = "6667";} //default
					try {ircchannel = cmdLine[count + 3];}
					catch(Exception) {ircchannel = "#unmdosx";} //default
				}

				count++;
			}
          //  Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new frmMain(hive, hide, ircserver, ircport, ircchannel));
		}
	}
}
