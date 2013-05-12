using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace WMIApplication
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class formWMI : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TabControl tabWMI;
		private System.Windows.Forms.TabPage tabExplorer;
		private ExplorerControlLibrary.ExplorerControl myExplorer;
		private System.Windows.Forms.TabPage tabSystemInfo;
		private WindowsInfoControlLibrary.SysInfoControl sysInfo;
		private System.Windows.Forms.TabPage tabServices;
		private WindowsServicesControlLibrary.Srvices srvices1;
		private System.Windows.Forms.TabPage tabProcesses;
		private WindowsProcessControlLibrary.Process process1;
		private System.Windows.Forms.StatusBar statusBar;
		private System.Windows.Forms.StatusBarPanel statusBarStatus;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public formWMI()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.statusBar = new System.Windows.Forms.StatusBar();
			this.statusBarStatus = new System.Windows.Forms.StatusBarPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tabWMI = new System.Windows.Forms.TabControl();
			this.tabExplorer = new System.Windows.Forms.TabPage();
			this.myExplorer = new ExplorerControlLibrary.ExplorerControl();
			this.tabSystemInfo = new System.Windows.Forms.TabPage();
			this.sysInfo = new WindowsInfoControlLibrary.SysInfoControl();
			this.tabServices = new System.Windows.Forms.TabPage();
			this.srvices1 = new WindowsServicesControlLibrary.Srvices();
			this.tabProcesses = new System.Windows.Forms.TabPage();
			this.process1 = new WindowsProcessControlLibrary.Process();
			((System.ComponentModel.ISupportInitialize)(this.statusBarStatus)).BeginInit();
			this.panel1.SuspendLayout();
			this.tabWMI.SuspendLayout();
			this.tabExplorer.SuspendLayout();
			this.tabSystemInfo.SuspendLayout();
			this.tabServices.SuspendLayout();
			this.tabProcesses.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusBar
			// 
			this.statusBar.Location = new System.Drawing.Point(0, 461);
			this.statusBar.Name = "statusBar";
			this.statusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																						 this.statusBarStatus});
			this.statusBar.ShowPanels = true;
			this.statusBar.Size = new System.Drawing.Size(752, 24);
			this.statusBar.TabIndex = 2;
			// 
			// statusBarStatus
			// 
			this.statusBarStatus.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None;
			this.statusBarStatus.Width = 600;
			// 
			// panel1
			// 
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.tabWMI});
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(752, 461);
			this.panel1.TabIndex = 3;
			// 
			// tabWMI
			// 
			this.tabWMI.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.tabExplorer,
																				 this.tabSystemInfo,
																				 this.tabServices,
																				 this.tabProcesses});
			this.tabWMI.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabWMI.Name = "tabWMI";
			this.tabWMI.SelectedIndex = 0;
			this.tabWMI.Size = new System.Drawing.Size(752, 461);
			this.tabWMI.TabIndex = 2;
			this.tabWMI.SelectedIndexChanged += new System.EventHandler(this.tabWMI_SelectedIndexChanged);
			// 
			// tabExplorer
			// 
			this.tabExplorer.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.myExplorer});
			this.tabExplorer.Location = new System.Drawing.Point(4, 22);
			this.tabExplorer.Name = "tabExplorer";
			this.tabExplorer.Size = new System.Drawing.Size(744, 435);
			this.tabExplorer.TabIndex = 0;
			this.tabExplorer.Text = "My Exploryer";
			// 
			// myExplorer
			// 
			this.myExplorer.Cursor = System.Windows.Forms.Cursors.Default;
			this.myExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.myExplorer.Name = "myExplorer";
			this.myExplorer.Size = new System.Drawing.Size(744, 435);
			this.myExplorer.TabIndex = 0;
			this.myExplorer.UpdateStatus += new ExplorerControlLibrary.ExplorerControl.Status(this.refreshStatusBar);
			// 
			// tabSystemInfo
			// 
			this.tabSystemInfo.Controls.AddRange(new System.Windows.Forms.Control[] {
																						this.sysInfo});
			this.tabSystemInfo.Location = new System.Drawing.Point(4, 22);
			this.tabSystemInfo.Name = "tabSystemInfo";
			this.tabSystemInfo.Size = new System.Drawing.Size(744, 435);
			this.tabSystemInfo.TabIndex = 1;
			this.tabSystemInfo.Text = "System Info";
			this.tabSystemInfo.Visible = false;
			// 
			// sysInfo
			// 
			this.sysInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sysInfo.Name = "sysInfo";
			this.sysInfo.Size = new System.Drawing.Size(744, 435);
			this.sysInfo.TabIndex = 0;
			this.sysInfo.UpdateStatus += new WindowsInfoControlLibrary.SysInfoControl.Status(this.refreshStatusBar);
			// 
			// tabServices
			// 
			this.tabServices.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.srvices1});
			this.tabServices.Location = new System.Drawing.Point(4, 22);
			this.tabServices.Name = "tabServices";
			this.tabServices.Size = new System.Drawing.Size(744, 435);
			this.tabServices.TabIndex = 2;
			this.tabServices.Text = "Services";
			this.tabServices.Visible = false;
			// 
			// srvices1
			// 
			this.srvices1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.srvices1.Name = "srvices1";
			this.srvices1.Size = new System.Drawing.Size(744, 435);
			this.srvices1.TabIndex = 0;
			this.srvices1.UpdateStatus += new WindowsServicesControlLibrary.Srvices.Status(this.refreshStatusBar);
			// 
			// tabProcesses
			// 
			this.tabProcesses.Controls.AddRange(new System.Windows.Forms.Control[] {
																					   this.process1});
			this.tabProcesses.Location = new System.Drawing.Point(4, 22);
			this.tabProcesses.Name = "tabProcesses";
			this.tabProcesses.Size = new System.Drawing.Size(744, 435);
			this.tabProcesses.TabIndex = 3;
			this.tabProcesses.Text = "Processes";
			this.tabProcesses.Visible = false;
			// 
			// process1
			// 
			this.process1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.process1.Name = "process1";
			this.process1.Size = new System.Drawing.Size(744, 435);
			this.process1.TabIndex = 0;
			this.process1.UpdateStatus += new WindowsProcessControlLibrary.Process.Status(this.refreshStatusBar);
			// 
			// formWMI
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(752, 485);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.panel1,
																		  this.statusBar});
			this.Menu = this.mainMenu1;
			this.Name = "formWMI";
			this.Text = "Window Management Instrumentation (WMI)";
			((System.ComponentModel.ISupportInitialize)(this.statusBarStatus)).EndInit();
			this.panel1.ResumeLayout(false);
			this.tabWMI.ResumeLayout(false);
			this.tabExplorer.ResumeLayout(false);
			this.tabSystemInfo.ResumeLayout(false);
			this.tabServices.ResumeLayout(false);
			this.tabProcesses.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new formWMI());
		}

		private void tabWMI_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			switch(tabWMI.SelectedTab.Text)
			{
				case "System Info":
					if (sysInfo.Loaded == false)
					{
						//control not loaded
						sysInfo.Refresh();
					}
					break;
				case "Services":
					if (srvices1.Loaded  == false)
					{
						//control not loaded
						srvices1.Refresh();
					}
					break;
				case "Processes":
					if (process1.Loaded  == false)
					{
						//control not loaded
						process1.Refresh();
					}
					break;

			}
		}

		private void refreshStatusBar(string stringStatus)
		{
			//update status bar
			statusBarStatus.Text = stringStatus;
		}


	}
}
