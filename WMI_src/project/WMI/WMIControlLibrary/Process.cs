using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Management;

namespace WindowsProcessControlLibrary
{
	/// <summary>
	/// Summary description for Process.
	/// </summary>
	public class Process : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button buttonRefresh;
		private System.Windows.Forms.RadioButton radioRemoteMachine;
		private System.Windows.Forms.TextBox textPassword;
		private System.Windows.Forms.TextBox textUserID;
		private System.Windows.Forms.Label labelPassword;
		private System.Windows.Forms.Label labelUserID;
		private System.Windows.Forms.Label labelIP;
		private System.Windows.Forms.TextBox textIP;
		private System.Windows.Forms.RadioButton radioMachine;
		private System.Windows.Forms.ImageList imageList;
		private System.ComponentModel.IContainer components;

		//delegate status event
		public delegate void Status(string e);
		public event Status UpdateStatus;
		private bool boolLoaded = false;
		private System.Windows.Forms.ListView listViewProcesses;
		private string stringProcessID;
		private System.Windows.Forms.ComboBox comboBoxProcess;
		private System.Windows.Forms.ComboBox comboBoxProcessPerformance;
		private ListViewItem listViewProcessItem;

		public Process()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Init list view
			InitListView();

			boolLoaded = false;
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Process));
			this.listViewProcesses = new System.Windows.Forms.ListView();
			this.imageList = new System.Windows.Forms.ImageList(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.comboBoxProcessPerformance = new System.Windows.Forms.ComboBox();
			this.comboBoxProcess = new System.Windows.Forms.ComboBox();
			this.buttonRefresh = new System.Windows.Forms.Button();
			this.radioRemoteMachine = new System.Windows.Forms.RadioButton();
			this.textPassword = new System.Windows.Forms.TextBox();
			this.textUserID = new System.Windows.Forms.TextBox();
			this.labelPassword = new System.Windows.Forms.Label();
			this.labelUserID = new System.Windows.Forms.Label();
			this.labelIP = new System.Windows.Forms.Label();
			this.textIP = new System.Windows.Forms.TextBox();
			this.radioMachine = new System.Windows.Forms.RadioButton();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// listViewProcesses
			// 
			this.listViewProcesses.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewProcesses.LargeImageList = this.imageList;
			this.listViewProcesses.MultiSelect = false;
			this.listViewProcesses.Name = "listViewProcesses";
			this.listViewProcesses.Size = new System.Drawing.Size(464, 488);
			this.listViewProcesses.SmallImageList = this.imageList;
			this.listViewProcesses.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.listViewProcesses.TabIndex = 3;
			this.listViewProcesses.View = System.Windows.Forms.View.Details;
			this.listViewProcesses.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewProcesses_MouseDown);
			// 
			// imageList
			// 
			this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
			this.imageList.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// panel1
			// 
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.comboBoxProcessPerformance,
																				 this.comboBoxProcess,
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
			this.panel1.Location = new System.Drawing.Point(464, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(128, 488);
			this.panel1.TabIndex = 2;
			// 
			// comboBoxProcessPerformance
			// 
			this.comboBoxProcessPerformance.Location = new System.Drawing.Point(16, 368);
			this.comboBoxProcessPerformance.Name = "comboBoxProcessPerformance";
			this.comboBoxProcessPerformance.Size = new System.Drawing.Size(96, 21);
			this.comboBoxProcessPerformance.TabIndex = 20;
			this.comboBoxProcessPerformance.Visible = false;
			// 
			// comboBoxProcess
			// 
			this.comboBoxProcess.Location = new System.Drawing.Point(16, 336);
			this.comboBoxProcess.Name = "comboBoxProcess";
			this.comboBoxProcess.Size = new System.Drawing.Size(96, 21);
			this.comboBoxProcess.TabIndex = 19;
			this.comboBoxProcess.Visible = false;
			// 
			// buttonRefresh
			// 
			this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonRefresh.Location = new System.Drawing.Point(29, 16);
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.Size = new System.Drawing.Size(75, 24);
			this.buttonRefresh.TabIndex = 10;
			this.buttonRefresh.Text = "&Refresh";
			this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
			// 
			// radioRemoteMachine
			// 
			this.radioRemoteMachine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioRemoteMachine.Location = new System.Drawing.Point(14, 80);
			this.radioRemoteMachine.Name = "radioRemoteMachine";
			this.radioRemoteMachine.Size = new System.Drawing.Size(120, 24);
			this.radioRemoteMachine.TabIndex = 12;
			this.radioRemoteMachine.Text = "&Remote Machine";
			this.radioRemoteMachine.CheckedChanged += new System.EventHandler(this.radioMachine_CheckedChanged);
			// 
			// textPassword
			// 
			this.textPassword.Location = new System.Drawing.Point(13, 272);
			this.textPassword.Name = "textPassword";
			this.textPassword.PasswordChar = '*';
			this.textPassword.Size = new System.Drawing.Size(104, 20);
			this.textPassword.TabIndex = 18;
			this.textPassword.Text = "";
			this.textPassword.Visible = false;
			// 
			// textUserID
			// 
			this.textUserID.Location = new System.Drawing.Point(13, 208);
			this.textUserID.Name = "textUserID";
			this.textUserID.Size = new System.Drawing.Size(104, 20);
			this.textUserID.TabIndex = 16;
			this.textUserID.Text = "";
			this.textUserID.Visible = false;
			// 
			// labelPassword
			// 
			this.labelPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.labelPassword.Location = new System.Drawing.Point(13, 248);
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Size = new System.Drawing.Size(100, 16);
			this.labelPassword.TabIndex = 17;
			this.labelPassword.Text = "&Password:";
			this.labelPassword.Visible = false;
			// 
			// labelUserID
			// 
			this.labelUserID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.labelUserID.Location = new System.Drawing.Point(13, 184);
			this.labelUserID.Name = "labelUserID";
			this.labelUserID.Size = new System.Drawing.Size(100, 16);
			this.labelUserID.TabIndex = 15;
			this.labelUserID.Text = "&User ID:";
			this.labelUserID.Visible = false;
			// 
			// labelIP
			// 
			this.labelIP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.labelIP.Location = new System.Drawing.Point(13, 120);
			this.labelIP.Name = "labelIP";
			this.labelIP.Size = new System.Drawing.Size(112, 16);
			this.labelIP.TabIndex = 13;
			this.labelIP.Text = "&IP or Machine Name:";
			this.labelIP.Visible = false;
			// 
			// textIP
			// 
			this.textIP.Location = new System.Drawing.Point(13, 144);
			this.textIP.Name = "textIP";
			this.textIP.Size = new System.Drawing.Size(104, 20);
			this.textIP.TabIndex = 14;
			this.textIP.Text = "";
			this.textIP.Visible = false;
			// 
			// radioMachine
			// 
			this.radioMachine.Checked = true;
			this.radioMachine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioMachine.Location = new System.Drawing.Point(13, 56);
			this.radioMachine.Name = "radioMachine";
			this.radioMachine.Size = new System.Drawing.Size(120, 24);
			this.radioMachine.TabIndex = 11;
			this.radioMachine.TabStop = true;
			this.radioMachine.Text = "&Current Machine";
			this.radioMachine.CheckedChanged += new System.EventHandler(this.radioMachine_CheckedChanged);
			// 
			// Process
			// 
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.listViewProcesses,
																		  this.panel1});
			this.Name = "Process";
			this.Size = new System.Drawing.Size(592, 488);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Get processes and populate list view
		/// </summary>
		private void getProcess()
		{
			ManagementObjectCollection queryCollection;
			ManagementObjectCollection queryCollection1;
			ProcessesDictionary.ProcessesDictionary  processesDictionary = new ProcessesDictionary.ProcessesDictionary();
			ProcessesDictionary.ProcessesInfo processInfo;
			ProcessesDictionary.structProcessInfo structProcess;
			ProcessesPerformanceDictionary.Dictionary dictionaryPerformances = new ProcessesPerformanceDictionary.Dictionary();
			ProcessesPerformanceDictionary.structPerformance structProcessPerf;
			ProcessesPerformanceDictionary.ProcessPerf processPerformance;

			//Set up a handler for the asynchronous callback
			ManagementOperationObserver observer = new ManagementOperationObserver(); 
			completionHandler.MyHandler  completionHandlerObj = new completionHandler.MyHandler(); 
			observer.ObjectReady += new ObjectReadyEventHandler(completionHandlerObj.Done);

			string[] lvData =  new string[5];

			//Status
			updateStatus("Getting Services Information");

			//prevent listview update
			listViewProcesses.BeginUpdate();
  
			try
			{
				//get system processes collection
				queryCollection = getProcessCollection("SELECT * FROM Win32_Process");

				//create dictionary for processes
				foreach ( ManagementObject mo in queryCollection)
				{
					processInfo = new ProcessesDictionary.ProcessesInfo();
					structProcess = new ProcessesDictionary.structProcessInfo();
					
					structProcess.stringName = mo["Name"].ToString();
					structProcess.stringProcessID = mo["ProcessID"].ToString();
					structProcess.stringParentProcessID = mo["ParentProcessID"].ToString();

					//Status
					updateStatus("Getting " + structProcess.stringName + " process info...");

					//Get process owner info
					mo.InvokeMethod(observer,"GetOwner", null);
			
					//wait until call is complete
					while (!completionHandlerObj.IsComplete) 
					{ 
						System.Threading.Thread.Sleep(500); 
					} 

					//check if the call was successful
					if (completionHandlerObj.ReturnObject["returnValue"].ToString() == "0") 
						//get process user name
						structProcess.stringUserName = completionHandlerObj.ReturnObject.Properties["User"].Value.ToString();
					else
						//failed
						structProcess.stringUserName = "";

					processInfo.Value = structProcess;

					processesDictionary.Add(mo["ProcessID"].ToString(), processInfo);
				}

				//get operating system
				string stringOS = "";
				int intWinXP = 0;

				queryCollection = getProcessCollection("SELECT * FROM Win32_OperatingSystem");
				foreach(ManagementObject mo in queryCollection)
				{
					//look for Windows 2000 Operating system
					stringOS = mo["Caption"].ToString();
					intWinXP = stringOS.LastIndexOf("XP");
				}
				
				if (intWinXP >= 0)
				{
					//get process CPU and memory usage for XP machine
					//(Note: have problem calling this on 2000 and NT machine.)
					queryCollection1 = getProcessCollection("SELECT * FROM Win32_PerfFormattedData_PerfProc_Process");
				}
				else
				{
					//get process CPU and memory usage for 2000 and NT machine
					queryCollection1 = getProcessCollection("SELECT * FROM Win32_PerfRawData_PerfProc_Process");
				}

				foreach ( ManagementObject mo1 in queryCollection1)
				{
					//get process CPU and memory usage
					processPerformance = new ProcessesPerformanceDictionary.ProcessPerf();
					structProcessPerf = new ProcessesPerformanceDictionary.structPerformance();

					structProcessPerf.stringPercentProcessorTime = mo1.Properties["PercentProcessorTime"].Value.ToString();
					structProcessPerf.stringVirtualBytes = mo1["VirtualBytes"].ToString();
				
					processPerformance.Value = structProcessPerf;
					
					//add to dictionary
					dictionaryPerformances.Add(mo1["IDProcess"].ToString(), processPerformance);
					
					//cleanup
					processPerformance = null;
				}

				//populate listview
				foreach (string stringProcessID in processesDictionary)
				{
					//currentProcessInfo = processesDictionary[stringProcessID].Value;
					structProcess = processesDictionary[stringProcessID].Value;
					//create child node for operating system
					lvData[0] = structProcess.stringName.ToString(); 
					//get process id
					lvData[4] = structProcess.stringProcessID.ToString();

					//get parent process
					lvData[1] = structProcess.stringUserName.ToString(); 

					try
					{
						//get process % processor time
						lvData[2] = dictionaryPerformances[structProcess.stringProcessID.ToString()].Value.stringPercentProcessorTime.ToString();

						//get memory usage
						lvData[3] = dictionaryPerformances[structProcess.stringProcessID.ToString()].Value.stringVirtualBytes.ToString(); 
					}
					catch(NullReferenceException)
					{
						//can't find process performance data
						lvData[2] = "0";
						lvData[3] = "0";
					}

					//create list item
					ListViewItem lvItem = new ListViewItem(lvData,0);
					listViewProcesses.Items.Add(lvItem);
				}
			}
			catch (Exception e)
			{
				MessageBox.Show("Error: " + e);
			}

			//do some cleanup
			processesDictionary.Clear();
			processesDictionary = null;
			dictionaryPerformances.Clear();
			dictionaryPerformances = null;

			//update listview
			listViewProcesses.EndUpdate();

			//Status
			updateStatus("Ready");
			this.Update();

		}

		/// <summary>
		/// Initialize list view
		/// </summary>
		private void InitListView()
		{
			//init ListView control
			listViewProcesses.Clear();		//clear control
			//create column header for ListView
			listViewProcesses.Columns.Add("Process",150,System.Windows.Forms.HorizontalAlignment.Left);
			listViewProcesses.Columns.Add("User",150, System.Windows.Forms.HorizontalAlignment.Left);
			listViewProcesses.Columns.Add("CPU", 100, System.Windows.Forms.HorizontalAlignment.Left);
			listViewProcesses.Columns.Add("Mem Usage", 100, System.Windows.Forms.HorizontalAlignment.Left);
			listViewProcesses.Columns.Add("Process ID", 65, System.Windows.Forms.HorizontalAlignment.Right);

		}

		/// <summary>
		/// Update status
		/// </summary>
		/// <param name="stringStatus"></param>
		private void updateStatus(string stringStatus)
		{
			if (UpdateStatus != null)
				UpdateStatus(stringStatus );
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
		/// buttonRefresh click event allow user to refresh service list view
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonRefresh_Click(object sender, System.EventArgs e)
		{
			this.Refresh();
		}

		/// <summary>
		/// List view mouse down event to built context menu dynamically 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void listViewProcesses_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			System.Windows.Forms.ListView listViewObject = (System.Windows.Forms.ListView) sender;
			ContextMenu mnuContextMenu = new ContextMenu();
			MenuItem menuItem;
			MenuItem subMenuItem;

			//check if right button
			if (e.Button == System.Windows.Forms.MouseButtons.Right) 
			{
				//set list view item
				ProcessItem = listViewObject.GetItemAt(e.X,e.Y);

				//create popup menu
				listViewProcesses.ContextMenu = mnuContextMenu;

				try
				{
					ProcessID = ProcessItem.SubItems[4].Text;

					//right click on ltem add teminate process menu item
					menuItem = new MenuItem();
					menuItem.Text = "Terminate Process";
					mnuContextMenu.MenuItems.Add(menuItem);
					// Add functionality to the menu items using the Click event. 
					menuItem.Click  += new System.EventHandler(this.menuItemTerminate_Click);
				}
				catch (System.NullReferenceException) 
				{
					//no list item selected. Do ignor error
				}

				//create Create new process menu
				menuItem = new MenuItem();
				menuItem.Text = "Create New Process";
				mnuContextMenu.MenuItems.Add(menuItem);

				//Create Calculator submenu
				subMenuItem = new MenuItem();
				subMenuItem.Text = "Calculator";
				menuItem.MenuItems.Add(subMenuItem);
				// Add functionality to the menu items using the Click event. 
				subMenuItem.Click  += new System.EventHandler(this.menuItemCalc_Click);

				//Create Notepad submenu
				subMenuItem = new MenuItem();
				subMenuItem.Text = "Notepad";
				menuItem.MenuItems.Add(subMenuItem);
				// Add functionality to the menu items using the Click event. 
				subMenuItem.Click  += new System.EventHandler(this.menuItemNotepad_Click);

				//Create Custom submenu
				subMenuItem = new MenuItem();
				subMenuItem.Text = "Custom";
				menuItem.MenuItems.Add(subMenuItem);
				// Add functionality to the menu items using the Click event. 
				subMenuItem.Click  += new System.EventHandler(this.menuItemCustom_Click);

			}
		}

		/// <summary>
		/// List view context menu click event to invoke terminate process
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void menuItemTerminate_Click(object sender, System.EventArgs e)
		{   
			ManagementObjectCollection queryCollection;
			ListViewItem lvItem;

			//Set up a handler for the asynchronous callback
			ManagementOperationObserver observer = new ManagementOperationObserver(); 
			completionHandler.MyHandler completionHandlerObj = new completionHandler.MyHandler(); 
			observer.ObjectReady  += new ObjectReadyEventHandler(completionHandlerObj.Done);

			queryCollection = getProcessCollection("Select * from Win32_Process Where ProcessID = '" + ProcessID + "'");

			//Status
			updateStatus("Invoking terminate process");
			
			foreach ( ManagementObject mo in queryCollection)
			{
				//start or stop service
				mo.InvokeMethod(observer, "Terminate", null);
			}
			
			//wait until invoke method is complete or 5 sec timeout
			int intCount = 0;
			while (!completionHandlerObj.IsComplete) 
			{ 
				if (intCount == 10)
				{
					MessageBox.Show("Terminate process timed out.", "Terminate Process Status");
					break;
				}
				//wait 1/2 sec.
				System.Threading.Thread.Sleep(500); 
				
				//increment counter
				intCount++;
			} 

			if (intCount != 10)
			{
				//InvokeMethod did not time out
				if (completionHandlerObj.ReturnObject.Properties["returnValue"].Value.ToString() == "0")
				{ 
					lvItem = ProcessItem;
					lvItem.Remove();
				}
				else
				{
					MessageBox.Show("Error terminating process.", "Terminate Process");
				}
			}
			//clean-up objects
			ProcessID = "";
			ProcessItem = null;

			//Status
			updateStatus("Ready");
			this.Update();
		}

		/// <summary>
		/// Create Calculator appication on local or remote machine
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void menuItemCalc_Click(object sender, System.EventArgs e)
		{
			CreateProcess("Calc.exe");
		}

		/// <summary>
		/// Create Notepad appication on local or remote machine
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void menuItemNotepad_Click(object sender, System.EventArgs e)
		{
			CreateProcess("Notepad.exe");
		}
		
		/// <summary>
		/// Create custom appication on local or remote machine
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void menuItemCustom_Click(object sender, System.EventArgs e)
		{
			string stringApp;

			//show dialog box
			DialogBox.DialogBoxInput InputForm = new DialogBox.DialogBoxInput();
			InputForm.ShowDialog();

			if ((string)InputForm.Tag == "OK")
			{
				stringApp = InputForm.getCreateProcessName;
				CreateProcess(stringApp);
			}

			//cleanup
			InputForm.Dispose();
		}
		
		/// <summary>
		/// Invoke method 'Create' on local or remote machine
		/// </summary>
		/// <param name="stringCommandLine"></param>
		private void CreateProcess(string stringCommandLine)
		{   
			//Set up a handler for the asynchronous callback
			ManagementOperationObserver observer = new ManagementOperationObserver(); 
			completionHandler.MyHandler completionHandlerObj = new completionHandler.MyHandler(); 
			observer.ObjectReady  += new ObjectReadyEventHandler(completionHandlerObj.Done);

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
			//get process path
			ManagementPath path = new ManagementPath( "Win32_Process");

			//Get the object on which the method will be invoked
			ManagementClass processClass = new ManagementClass(ms,path,null);

			//Status
			updateStatus("Create process " + stringCommandLine + ".");
			
			//Create an array containing all arguments for the method
			object[] methodArgs = {stringCommandLine, null, null, 0};

			//Execute the method
			processClass.InvokeMethod (observer, "Create", methodArgs);

			//wait until invoke method is complete or 5 sec timeout
			int intCount = 0;
			while (!completionHandlerObj.IsComplete) 
			{ 
				if (intCount > 10)
				{
					MessageBox.Show("Create process timed out.", "Terminate Process Status");
					break;
				}
				//wait 1/2 sec.
				System.Threading.Thread.Sleep(500); 
				
				//increment counter
				intCount++;
			} 

			if (intCount != 10)
			{
				//InvokeMethod did not time out
				//check for error
				if (completionHandlerObj.ReturnObject.Properties["returnValue"].Value.ToString() == "0")
				{
					//refresh process list
					this.Refresh();
				}
				else
				{
					MessageBox.Show("Error creating new process.", "Create New Process");
				}
			}

			//Status
			updateStatus("Ready");
			this.Update();
		}

		/// <summary>
		/// Get computer service collection
		/// </summary>
		/// <param name="stringQuery"></param>
		/// <returns>queryCollection</returns>
		private ManagementObjectCollection getProcessCollection(string stringQuery)
		{
			ManagementObjectSearcher query;
			ManagementObjectCollection queryCollection = null;
			System.Management.ObjectQuery oq;
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
				return null;
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
			updateStatus("Getting Services Information");

			//Query remote computer across the connection
			oq = new System.Management.ObjectQuery(stringQuery);
			query = new ManagementObjectSearcher(ms,oq);

			try
			{
				queryCollection = query.Get();

			}
			catch (Exception e1)
			{
				MessageBox.Show("Error: " + e1);
			}

			//Status
			updateStatus("Ready");
			this.Update();
			return queryCollection;

		}

		/// <summary>
		/// Get/Set process name
		/// </summary>
		/// <returns>stringServiceName</returns>
		private string ProcessID
		{
			get
			{
				return stringProcessID;
			}

			set
			{
				stringProcessID = value;
			}
		}

		/// <summary>
		/// Get/Set list view item object
		/// </summary>
		/// <returns>listViewProcessItem</returns>
		private ListViewItem ProcessItem
		{
			get
			{
				return listViewProcessItem;
			}
			set 
			{
				listViewProcessItem = value;
			}
		}

		/// <summary>
		/// Public Refresh method 
		/// </summary>
		public override void Refresh()
		{
			// Init list view
			InitListView();

			getProcess();

			boolLoaded = true;
		}


		/// <summary>
		/// Loaded check if control was loaded before 
		/// </summary>
		/// <returns></returns>
		public bool Loaded
		{
			get
			{
				//true if control already loaded else false.
				return boolLoaded;
			}
			
		}
	}
}
