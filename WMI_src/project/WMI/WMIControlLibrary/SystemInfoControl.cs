using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Management;
using System.Globalization;

namespace WindowsInfoControlLibrary
{
	/// <summary>
	/// This UserControl display system information.
	/// </summary>

	public class SysInfoControl : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton radioMachine;
		private System.Windows.Forms.TextBox textIP;
		private System.Windows.Forms.Label labelUserID;
		private System.Windows.Forms.Label labelPassword;
		private System.Windows.Forms.TextBox textUserID;
		private System.Windows.Forms.TextBox textPassword;
		private System.Windows.Forms.TreeView treeSysInfo;
		private System.Windows.Forms.Label labelIP;
		private System.Windows.Forms.RadioButton radioRemoteMachine;
		private System.Windows.Forms.Button buttonRefresh;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		private bool boolLoaded = false;

		//delegate status event
		public delegate void Status(string e);
		public event Status UpdateStatus;


		public SysInfoControl()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonRefresh = new System.Windows.Forms.Button();
			this.radioRemoteMachine = new System.Windows.Forms.RadioButton();
			this.textPassword = new System.Windows.Forms.TextBox();
			this.textUserID = new System.Windows.Forms.TextBox();
			this.labelPassword = new System.Windows.Forms.Label();
			this.labelUserID = new System.Windows.Forms.Label();
			this.labelIP = new System.Windows.Forms.Label();
			this.textIP = new System.Windows.Forms.TextBox();
			this.radioMachine = new System.Windows.Forms.RadioButton();
			this.treeSysInfo = new System.Windows.Forms.TreeView();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.buttonRefresh,
																				 this.radioRemoteMachine,
																				 this.textPassword,
																				 this.textUserID,
																				 this.labelPassword,
																				 this.labelUserID,
																				 this.labelIP,
																				 this.textIP,
																				 this.radioMachine});
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(488, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(128, 432);
			this.panel1.TabIndex = 9;
			// 
			// buttonRefresh
			// 
			this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonRefresh.Location = new System.Drawing.Point(29, 15);
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.Size = new System.Drawing.Size(75, 24);
			this.buttonRefresh.TabIndex = 1;
			this.buttonRefresh.Text = "&Refresh";
			this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
			// 
			// radioRemoteMachine
			// 
			this.radioRemoteMachine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioRemoteMachine.Location = new System.Drawing.Point(13, 82);
			this.radioRemoteMachine.Name = "radioRemoteMachine";
			this.radioRemoteMachine.Size = new System.Drawing.Size(120, 24);
			this.radioRemoteMachine.TabIndex = 3;
			this.radioRemoteMachine.Text = "&Remote Machine";
			this.radioRemoteMachine.CheckedChanged += new System.EventHandler(this.radioMachine_CheckedChanged);
			// 
			// textPassword
			// 
			this.textPassword.Location = new System.Drawing.Point(12, 270);
			this.textPassword.Name = "textPassword";
			this.textPassword.PasswordChar = '*';
			this.textPassword.Size = new System.Drawing.Size(104, 20);
			this.textPassword.TabIndex = 9;
			this.textPassword.Text = "";
			this.textPassword.Visible = false;
			// 
			// textUserID
			// 
			this.textUserID.Location = new System.Drawing.Point(12, 209);
			this.textUserID.Name = "textUserID";
			this.textUserID.Size = new System.Drawing.Size(104, 20);
			this.textUserID.TabIndex = 7;
			this.textUserID.Text = "";
			this.textUserID.Visible = false;
			// 
			// labelPassword
			// 
			this.labelPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.labelPassword.Location = new System.Drawing.Point(12, 245);
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Size = new System.Drawing.Size(100, 16);
			this.labelPassword.TabIndex = 8;
			this.labelPassword.Text = "&Password:";
			this.labelPassword.Visible = false;
			// 
			// labelUserID
			// 
			this.labelUserID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.labelUserID.Location = new System.Drawing.Point(12, 185);
			this.labelUserID.Name = "labelUserID";
			this.labelUserID.Size = new System.Drawing.Size(100, 16);
			this.labelUserID.TabIndex = 6;
			this.labelUserID.Text = "&User ID:";
			this.labelUserID.Visible = false;
			// 
			// labelIP
			// 
			this.labelIP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.labelIP.Location = new System.Drawing.Point(12, 123);
			this.labelIP.Name = "labelIP";
			this.labelIP.Size = new System.Drawing.Size(112, 16);
			this.labelIP.TabIndex = 4;
			this.labelIP.Text = "&IP or Machine Name:";
			this.labelIP.Visible = false;
			// 
			// textIP
			// 
			this.textIP.Location = new System.Drawing.Point(12, 148);
			this.textIP.Name = "textIP";
			this.textIP.Size = new System.Drawing.Size(104, 20);
			this.textIP.TabIndex = 5;
			this.textIP.Text = "";
			this.textIP.Visible = false;
			// 
			// radioMachine
			// 
			this.radioMachine.Checked = true;
			this.radioMachine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioMachine.Location = new System.Drawing.Point(12, 54);
			this.radioMachine.Name = "radioMachine";
			this.radioMachine.Size = new System.Drawing.Size(120, 24);
			this.radioMachine.TabIndex = 2;
			this.radioMachine.TabStop = true;
			this.radioMachine.Text = "&Current Machine";
			this.radioMachine.CheckedChanged += new System.EventHandler(this.radioMachine_CheckedChanged);
			// 
			// treeSysInfo
			// 
			this.treeSysInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeSysInfo.ImageIndex = -1;
			this.treeSysInfo.Name = "treeSysInfo";
			this.treeSysInfo.SelectedImageIndex = -1;
			this.treeSysInfo.Size = new System.Drawing.Size(488, 432);
			this.treeSysInfo.TabIndex = 0;
			// 
			// SysInfoControl
			// 
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.treeSysInfo,
																		  this.panel1});
			this.Name = "SysInfoControl";
			this.Size = new System.Drawing.Size(616, 432);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Overide Refresh function to requery system information
		/// </summary>
		public override void Refresh()
		{
			//set curser to hour glass
			this.Cursor = Cursors.WaitCursor;

			//clear text box
			treeSysInfo.Nodes.Clear();
			
			//get system info
			getSystemInfo();

			//set curser to hour glass
			this.Cursor = Cursors.Default;
		}

		/// <summary>
		/// Loaded property 
		/// </summary>
		/// <returns>boolLoaded</returns>
		public bool Loaded
		{
			get
			{
				//true if control already loaded else false.
				return boolLoaded;
			}
		}

		/// <summary>
		/// Private property
		/// </summary>
		/// <param name="booleanFlag"></param>
		private void setLoaded(bool booleanFlag)
		{
			boolLoaded = booleanFlag;
		}

		
		/// <summary>
		/// Get system information
		/// </summary>
		private void getSystemInfo()
		{
			ManagementObjectSearcher query;
			ManagementObjectCollection queryCollection;
			System.Management.ObjectQuery oq;
			TreeNodeCollection nodeCollection;
			string stringMachineName = "";

			//Connect to the remote computer
			ConnectionOptions co = new ConnectionOptions();

			if (radioMachine.Checked == true)
			{
				stringMachineName = "localhost";
			}
			else
			{
				stringMachineName = textIP.Text;
			}

			if (stringMachineName.Trim().Length == 0)
			{
				MessageBox.Show("Must enter machine IP address or name.");
				return;
			}

			//get user and password
			if (textUserID.Text.Trim().Length   > 0)
			{
				co.Username = textUserID.Text;
				co.Password = textPassword.Text;
			}

			//Point to machine
			System.Management.ManagementScope ms = new System.Management.ManagementScope("\\\\" + stringMachineName + "\\root\\cimv2", co);      

			//Status
			updateStatus("Getting System Information");

			//Query remote computer across the connection
			oq = new System.Management.ObjectQuery("SELECT * FROM Win32_OperatingSystem");
			query = new ManagementObjectSearcher(ms,oq);
  
			try
			{
				//clear TreeView
				treeSysInfo.Nodes.Clear();

				//create parent
				nodeCollection = createParentNode("Operating System");

				queryCollection = query.Get();
				foreach ( ManagementObject mo in queryCollection)
				{
					//create child node for operating system
					createChildNode(nodeCollection, "Operating System: " + mo["Caption"]);
					createChildNode(nodeCollection, "Version: " + mo["Version"]);
					createChildNode(nodeCollection, "Manufacturer : " + mo["Manufacturer"]);
					createChildNode(nodeCollection, "Computer Name : " +mo["csname"]);
					createChildNode(nodeCollection, "Windows Directory : " + mo["WindowsDirectory"]);
					createChildNode(nodeCollection, "Serial Number : " + mo["SerialNumber"]);
				}

				this.Update();

				//Status
				updateStatus("Getting Computer Information");

				//machine info
				oq = new System.Management.ObjectQuery("SELECT * FROM Win32_ComputerSystem");
				query = new ManagementObjectSearcher(ms,oq);
				queryCollection = query.Get();

				//create parent
				nodeCollection = createParentNode("Computer System");

				foreach ( ManagementObject mo in queryCollection)
				{
					//create new child node
					createChildNode(nodeCollection, "Computer Manufacturer Name: " + mo["Manufacturer"]);
					createChildNode(nodeCollection, "Computer Model: " + mo["model"]);
					createChildNode(nodeCollection, "System Type: " + mo["SystemType"]);
					createChildNode(nodeCollection, "Total Physical Memory: " + formatSize(Int64.Parse(mo["totalphysicalmemory"].ToString()), false));
					createChildNode(nodeCollection, "Domain: " + mo["Domain"]);
					createChildNode(nodeCollection, "User Name: " + mo["UserName"]);

				}

				//Status
				updateStatus("Getting Processor Information");

				this.Update();

				//get processor info
				oq = new System.Management.ObjectQuery("SELECT * FROM Win32_processor");
				query = new ManagementObjectSearcher(ms,oq);
				queryCollection = query.Get();

				//create parent
				nodeCollection = createParentNode("System Processor");

				foreach ( ManagementObject mo in queryCollection)
				{
					//create new child node
					createChildNode(nodeCollection, "Manufacturer: " + mo["Manufacturer"]);
					createChildNode(nodeCollection, "Computer Processor: " + mo["Caption"]);
					createChildNode(nodeCollection, "CPU Speed: " + formatSpeed(Int64.Parse(mo["MaxClockSpeed"].ToString())));
					createChildNode(nodeCollection, "L2 Cache Size: " + formatSize(Int64.Parse(mo["L2CacheSize"].ToString()), false));
				}

				//Status
				updateStatus("Getting Bios Information");
				this.Update();

				//Get Bios info
				oq = new System.Management.ObjectQuery("SELECT * FROM Win32_bios");
				query = new ManagementObjectSearcher(ms,oq);
				queryCollection = query.Get();

				//create parent
				nodeCollection = createParentNode("System Bios");

				foreach ( ManagementObject mo in queryCollection)
				{
					createChildNode(nodeCollection, "BIOS: " + mo["Caption"]);
					createChildNode(nodeCollection, "BIOS Version: " + mo["version"]);
				}

				//Status
				updateStatus("Getting Time Zone");
				this.Update();

				//Get Time Zone
				oq = new System.Management.ObjectQuery("SELECT * FROM Win32_timezone");
				query = new ManagementObjectSearcher(ms,oq);
				queryCollection = query.Get();

				//create parent
				nodeCollection = createParentNode("System Time Zone");

				foreach ( ManagementObject mo in queryCollection)
				{
					createChildNode(nodeCollection, "Time Zone: " + mo["Caption"]);
				}

				//Status
				updateStatus("Getting Memory Configuration");
				this.Update();

				//Get memory configuration
				oq = new System.Management.ObjectQuery("SELECT * FROM Win32_LogicalMemoryConfiguration");
				query = new ManagementObjectSearcher(ms,oq);
				queryCollection = query.Get();

				//create parent
				nodeCollection = createParentNode("Logical Memory Configuration");

				foreach ( ManagementObject mo in queryCollection)
				{
					//create new child node
					createChildNode(nodeCollection, "Total Page File Space: " + formatSize(Int64.Parse(mo["TotalPageFileSpace"].ToString()), true));
					createChildNode(nodeCollection, "Total Virtual Memory: " + formatSize(Int64.Parse(mo["TotalVirtualMemory"].ToString()), true));
					createChildNode(nodeCollection, "Total Physical Memory: " + formatSize(Int64.Parse(mo["TotalPhysicalMemory"].ToString()), true));
				}

				//Status
				updateStatus("Getting Network Connection");
				this.Update();

				//Get Network connection
				oq = new System.Management.ObjectQuery("SELECT * FROM Win32_NetworkConnection");
				query = new ManagementObjectSearcher(ms,oq);
				queryCollection = query.Get();

				//create parent
				nodeCollection = createParentNode("Network Connection");

				foreach ( ManagementObject mo in queryCollection)
				{
					//create new child node
					createChildNode(nodeCollection, "Name: " + mo["Name"]);
				}

				//Status
				updateStatus("Getting Video Information");
				this.Update();

				//Get Video 
				oq = new System.Management.ObjectQuery("SELECT * FROM Win32_VideoController");
				query = new ManagementObjectSearcher(ms,oq);
				queryCollection = query.Get();

				//create parent
				nodeCollection = createParentNode("Video Controller");

				foreach ( ManagementObject mo in queryCollection)
				{
					//create new child node
					createChildNode(nodeCollection, "Name: " + mo["Name"]);
					createChildNode(nodeCollection, "Processor: " + mo["VideoProcessor"]);
					createChildNode(nodeCollection, "Mode: " + mo["VideoModeDescription"]);
					if (mo["AdapterRAM"] == null)
					{
						createChildNode(nodeCollection, "Video Ram: " + mo["AdapterRAM"]);
					}
					else
					{
						createChildNode(nodeCollection, "Video Ram: " + formatSize(Int64.Parse(mo["AdapterRAM"].ToString()), false));
					}
					createChildNode(nodeCollection, "PNP Device ID: " + mo["PNPDeviceID"]);
					createChildNode(nodeCollection, "Status: " + mo["Status"]);
				}

			}
			catch (Exception e)
			{
				MessageBox.Show("Error: " + e);
			}

			//Status
			updateStatus("Ready");
			this.Update();

			//expand all tree node
			treeSysInfo.ExpandAll();

			//set control loaded
			setLoaded(true);
		}


		/// <summary>
		/// radioMachine_CheckedChanged event allow user to access services on other machine
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void radioMachine_CheckedChanged(object sender, System.EventArgs e)
		{
			
			bool booleanFlag = true;
			RadioButton rbClicked = (RadioButton) sender;

			if (rbClicked.Text == "&Current Machine")
				booleanFlag = false;

			//toggle controls
			labelIP.Visible = booleanFlag;
			textIP.Visible = booleanFlag;
			labelUserID.Visible = booleanFlag;
			textUserID.Visible = booleanFlag;
			labelPassword.Visible = booleanFlag;
			textPassword.Visible = booleanFlag;

		}

		/// <summary>
		/// Create parent tree node
		/// </summary>
		/// <param name="stringName"></param>
		/// <returns>nodeTreeNode.Nodes</returns>
		private TreeNodeCollection createParentNode(string stringName)
		{
			//create parent
			TreeNode nodeTreeNode = new TreeNode(stringName);
			treeSysInfo.Nodes.Add(nodeTreeNode);

			//return back collection
			return nodeTreeNode.Nodes;

		}

		/// <summary>
		/// Create child tree node
		/// </summary>
		/// <param name="nodeCollection"></param>
		/// <param name="stringCaption"></param>
		private void createChildNode(TreeNodeCollection nodeCollection, string stringCaption)
		{
			//create new drive node
			TreeNode nodeTreeNode = new TreeNode(stringCaption);
			//add new node
			nodeCollection.Add(nodeTreeNode);

		} 

		/// <summary>
		/// formatnumber to KB
		/// </summary>
		/// <param name="lSize"></param>
		/// <param name="booleanFormatOnly"></param>
		/// <returns>stringSize + " KB"</returns>
		private string formatSize(Int64 lSize, bool booleanFormatOnly)
		{
			//Format number to KB
			string stringSize = "";
			NumberFormatInfo myNfi = new NumberFormatInfo();

			Int64 lKBSize = 0;

			if (lSize < 1024 ) 
			{
				if (lSize == 0) 
				{
					//zero byte
					stringSize = "0";
				}
				else 
				{
					//less than 1K but not zero byte
					stringSize = "1";
				}
			}
			else 
			{
				if (booleanFormatOnly == false)
				{
					//convert to KB
					lKBSize = lSize / 1024;
				}
				else 
				{
					lKBSize = lSize;
				}

				//format number with default format
				stringSize = lKBSize.ToString("n",myNfi);
				//remove decimal
				stringSize = stringSize.Replace(".00", "");
			}

			return stringSize + " KB";

		}

		/// <summary>
		/// Formate speed to Hz
		/// </summary>
		/// <param name="lSpeed"></param>
		/// <returns>stringSpeed</returns>
		private string formatSpeed(Int64 lSpeed)
		{
			//Format number to Hz
			float floatSpeed = 0;
			string stringSpeed = "";
			NumberFormatInfo myNfi = new NumberFormatInfo();

			if (lSpeed < 1000 ) 
			{
				//less than 1G Hz
				stringSpeed = lSpeed.ToString() + "M Hz";
			}
			else 
			{
				//convert to Giga Hz
				floatSpeed = (float) lSpeed / 1000;
				stringSpeed = floatSpeed.ToString() + "G Hz";
			}

			return stringSpeed;

		}

		/// <summary>
		/// buttonRefresh click event allow user to refresh service list view
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonRefresh_Click(object sender, System.EventArgs e)
		{
			//refresh display
			this.Refresh();
		}

		/// <summary>
		/// status event
		/// </summary>
		/// <param name="stringStatus"></param>
		private void updateStatus(string stringStatus)
		{
			if (UpdateStatus != null)
				UpdateStatus(stringStatus );
		}

	}
}
