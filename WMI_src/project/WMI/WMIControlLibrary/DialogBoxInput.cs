using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace DialogBox
{
	/// <summary>
	/// Summary description for DialogBox.
	/// </summary>
	public class DialogBoxInput : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Label labelInput;
		private System.Windows.Forms.TextBox textBoxInput;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public DialogBoxInput()
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
				if(components != null)
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
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.labelInput = new System.Windows.Forms.Label();
			this.textBoxInput = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// buttonOK
			// 
			this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonOK.Location = new System.Drawing.Point(72, 56);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.TabIndex = 3;
			this.buttonOK.Text = "OK";
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCancel.Location = new System.Drawing.Point(184, 56);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.TabIndex = 4;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// labelInput
			// 
			this.labelInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.labelInput.Location = new System.Drawing.Point(16, 18);
			this.labelInput.Name = "labelInput";
			this.labelInput.Size = new System.Drawing.Size(96, 16);
			this.labelInput.TabIndex = 1;
			this.labelInput.Text = "New Application:";
			// 
			// textBoxInput
			// 
			this.textBoxInput.Location = new System.Drawing.Point(112, 16);
			this.textBoxInput.Name = "textBoxInput";
			this.textBoxInput.Size = new System.Drawing.Size(200, 20);
			this.textBoxInput.TabIndex = 2;
			this.textBoxInput.Text = "";
			// 
			// DialogBoxInput
			// 
			this.AcceptButton = this.buttonOK;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(328, 85);
			this.ControlBox = false;
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.textBoxInput,
																		  this.labelInput,
																		  this.buttonCancel,
																		  this.buttonOK});
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(336, 112);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(336, 112);
			this.Name = "DialogBoxInput";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Create Cutom Application";
			this.ResumeLayout(false);

		}
		#endregion

		private void buttonOK_Click(object sender, System.EventArgs e)
		{
			if (textBoxInput.Text.Trim().Length > 0)
			{
				this.Tag = "OK";
				this.Hide();
			}
			else
				MessageBox.Show("Please enter an application name to continue.", "Missing Application Name");
		}

		private void buttonCancel_Click(object sender, System.EventArgs e)
		{
			this.Tag = "Cancel";
			this.Hide();
		}

		/// <summary>
		/// get new application
		/// </summary>
		public string getCreateProcessName
		{
			get
			{
				return textBoxInput.Text.Trim();
			}
		}
	}
}
