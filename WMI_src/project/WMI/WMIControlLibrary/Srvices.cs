using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Management;

namespace WindowsServicesControlLibrary
{
	/// <summary>
	/// Display srvices informatin.
	/// </summary>
	public class Srvices : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ListView listViewServices;
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

		private string stringServiceName = "";
		private string stringServiceAction = "";
		private ListViewItem listViewServiceItem;
		private bool boolLoaded = false;

		public Srvices()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Init list view
			InitListView();

			// Init boolLoaded flag
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Srvices));
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
			this.listViewServices = new System.Windows.Forms.ListView();
			this.imageList = new System.Windows.Forms.ImageList(this.components);
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
			this.panel1.Location = new System.Drawing.Point(632, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(128, 512);
			this.panel1.TabIndex = 0;
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
			// listViewServices
			// 
			this.listViewServices.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewServices.LargeImageList = this.imageList;
			this.listViewServices.MultiSelect = false;
			this.listViewServices.Name = "listViewServices";
			this.listViewServices.Size = new System.Drawing.Size(632, 512);
			this.listViewServices.SmallImageList = this.imageList;
			this.listViewServices.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.listViewServices.TabIndex = 1;
			this.listViewServices.View = System.Windows.Forms.View.Details;
			this.listViewServices.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewServices_MouseDown);
			// 
			// imageList
			// 
			this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
			this.imageList.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// Srvices
			// 
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.listViewServices,
																		  this.panel1});
			this.Name = "Srvices";
			this.Size = new System.Drawing.Size(760, 512);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
	
		/// <summary>
		/// Get services and populate list view
		/// </summary>
		private void getServices()
		{
			ManagementObjectCollection queryCollection;
			string[] lvData =  new string[4];
  
			try
			{
				queryCollection = getServiceCollection("SELECT * FROM Win32_Service");
				foreach ( ManagementObject mo in queryCollection)
				{
					//create child node for operating system
					lvData[0] = mo["Name"].ToString();
					lvData[1] = mo["StartMode"].ToString();
					if (mo["Started"].Equals(true))
						lvData[2] = "Started";
					else
						lvData[2] = "Stop";
					lvData[3] = mo["StartName"].ToString();
					
					//create list item
					ListViewItem lvItem = new ListViewItem(lvData,0);
					listViewServices.Items.Add(lvItem);
				}
			}
			catch (Exception e)
			{
				MessageBox.Show("Error: " + e);
			}

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
			listViewServices.Clear();		//clear control
			//create column header for ListView
			listViewServices.Columns.Add("Service",150,System.Windows.Forms.HorizontalAlignment.Left);
			listViewServices.Columns.Add("Start Mode",65, System.Windows.Forms.HorizontalAlignment.Left);
			listViewServices.Columns.Add("Status", 65, System.Windows.Forms.HorizontalAlignment.Left);
			listViewServices.Columns.Add("Account Name", 180, System.Windows.Forms.HorizontalAlignment.Left);

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
			//call refresh function
			this.Refresh();
		}

		/// <summary>
		/// List view mouse down event to built context menu dynamically 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void listViewServices_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			System.Windows.Forms.ListView listViewObject = (System.Windows.Forms.ListView) sender;
			ContextMenu mnuContextMenu = new ContextMenu();
			MenuItem menuItem = new MenuItem();
			ManagementObjectCollection queryCollection;

			//check if right button
			if (e.Button == System.Windows.Forms.MouseButtons.Right) 
			{
				//get service name
				ServiceName = listViewObject.GetItemAt(e.X, e.Y).Text;
				//set list view item
				ServiceItem = listViewObject.GetItemAt(e.X,e.Y);

				//create popup menu
				listViewObject.ContextMenu = mnuContextMenu;
  				try
				{
					//get specific service object
					queryCollection = getServiceCollection("SELECT * FROM Win32_Service Where Name = '" + ServiceName + "'");
					foreach ( ManagementObject mo in queryCollection)
					{
						//create menu depending on service state
						if (mo["Started"].Equals(true))
						{
							menuItem.Text = "Stop";
							//set action property
							ServiceAction = "StopService";
						}
						else
						{
							menuItem.Text = "Start";
							ServiceAction = "StartService";
						}
						mnuContextMenu.MenuItems.Add(menuItem);

						// Add functionality to the menu items using the Click event. 
						menuItem.Click  += new System.EventHandler(this.menuItem_Click);
					}
				}
				catch (Exception e1)
				{
					MessageBox.Show("Error: " + e1);
				}
			}
		}

		/// <summary>
		/// List view context menu click event to invoke start/stop service
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void menuItem_Click(object sender, System.EventArgs e)
		{   
			ManagementObjectCollection queryCollection;
			ListViewItem lvItem;

			//Set up a handler for the asynchronous callback
			ManagementOperationObserver observer = new ManagementOperationObserver(); 
			completionHandler.MyHandler completionHandlerObj = new completionHandler.MyHandler(); 
			observer.ObjectReady += new ObjectReadyEventHandler(completionHandlerObj.Done);

			//get specific service object
			queryCollection = getServiceCollection("Select * from Win32_Service Where Name = '" + ServiceName + "'");

			//Status
			updateStatus("Starting/Stopping service...");
			
			foreach ( ManagementObject mo in queryCollection)
			{
				//start or stop service
				mo.InvokeMethod(observer, ServiceAction, null);
			}
			
			//wait until invoke method is complete or 5 sec timeout
			int intCount = 0;
			while (!completionHandlerObj.IsComplete) 
			{ 
				if (intCount > 10)
				{
					MessageBox.Show("Terminate process timed out.", "Terminate Process Status");
					break;
				}
				//wait 1/2 sec.
				System.Threading.Thread.Sleep(500); 
				
				//increment counter
				intCount++;
			} 

			//see if call was successful.
			if (completionHandlerObj.ReturnObject.Properties["returnValue"].Value.ToString() == "0")
			{ 
				//succeeded
				lvItem = ServiceItem;

				if (ServiceAction == "StartService")
					lvItem.SubItems[2].Text = "Started";
				else
					lvItem.SubItems[2].Text = "Stop";
			}
			else
			{
				//error message
				string stringAction;

				if (ServiceAction == "StartService")
					stringAction = "start";
				else
					stringAction = "stop";

				MessageBox.Show("Failed to " + stringAction + " service " + ServiceName + ".", "Start/Stop Service Failure");
			}

			//clean-up objects
			ServiceName = "";
			ServiceAction = "";
			ServiceItem = null;

			//Status
			updateStatus("Ready");
			this.Update();
		}

		/// <summary>
		/// Get computer service collection
		/// </summary>
		/// <param name="stringQuery"></param>
		/// <returns>queryCollection</returns>
		private ManagementObjectCollection getServiceCollection(string stringQuery)
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
		/// Get/Set service name
		/// </summary>
		/// <returns>stringServiceName</returns>
		private string ServiceName
		{
			get
			{
				return stringServiceName;
			}

			set
			{
				stringServiceName = value;
			}
		}


		/// <summary>
		/// Get/Set invoke service action
		/// </summary>
		/// <returns>stringServiceAction</returns>
		private string ServiceAction
		{
			get
			{
				return stringServiceAction;
			}
			set
			{
				stringServiceAction = value;
			}
		}


		/// <summary>
		/// Get/Set list view item object
		/// </summary>
		/// <returns>listViewServiceItem</returns>
		private ListViewItem ServiceItem
		{
			get
			{
				return listViewServiceItem;
			}
			set 
			{
				listViewServiceItem = value;
			}
		}

		/// <summary>
		/// Public Refresh method 
		/// </summary>
		public override void Refresh()
		{
			// Init list view
			InitListView();

			getServices();

			boolLoaded = true;
		}

		/// <summary>
		/// GetLoaded check if control was loaded before 
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
