<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlServices
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label
        Me.lstServices = New System.Windows.Forms.ListView
        Me.colService = New System.Windows.Forms.ColumnHeader
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtServiceDescription = New System.Windows.Forms.TextBox
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.lblServiceStartMode = New System.Windows.Forms.Label
        Me.lblServiceStartName = New System.Windows.Forms.Label
        Me.lblServiceStarted = New System.Windows.Forms.Label
        Me.lblServicePathName = New System.Windows.Forms.Label
        Me.lblServiceProcessID = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblServiceName = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Divider2 = New SysInfo.CustomControls.DividerControl
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(10, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(378, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "View information about the Services on your system"
        '
        'lstServices
        '
        Me.lstServices.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lstServices.BackColor = System.Drawing.Color.White
        Me.lstServices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstServices.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colService})
        Me.lstServices.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstServices.FullRowSelect = True
        Me.lstServices.GridLines = True
        Me.lstServices.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstServices.HideSelection = False
        Me.lstServices.LabelWrap = False
        Me.lstServices.Location = New System.Drawing.Point(49, 90)
        Me.lstServices.MultiSelect = False
        Me.lstServices.Name = "lstServices"
        Me.lstServices.ShowGroups = False
        Me.lstServices.ShowItemToolTips = True
        Me.lstServices.Size = New System.Drawing.Size(535, 155)
        Me.lstServices.TabIndex = 0
        Me.lstServices.TabStop = False
        Me.lstServices.UseCompatibleStateImageBehavior = False
        Me.lstServices.View = System.Windows.Forms.View.Details
        '
        'colService
        '
        Me.colService.Text = "Service"
        Me.colService.Width = 510
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 136)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Description:"
        '
        'txtServiceDescription
        '
        Me.txtServiceDescription.BackColor = System.Drawing.Color.White
        Me.txtServiceDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtServiceDescription.ForeColor = System.Drawing.Color.Navy
        Me.txtServiceDescription.Location = New System.Drawing.Point(134, 135)
        Me.txtServiceDescription.Multiline = True
        Me.txtServiceDescription.Name = "txtServiceDescription"
        Me.txtServiceDescription.ReadOnly = True
        Me.txtServiceDescription.Size = New System.Drawing.Size(571, 126)
        Me.txtServiceDescription.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel1.Controls.Add(Me.lblServiceStartMode, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtServiceDescription, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.lblServiceStartName, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblServiceStarted, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblServicePathName, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblServiceProcessID, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblServiceName, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(49, 267)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(708, 264)
        Me.TableLayoutPanel1.TabIndex = 89
        '
        'lblServiceStartMode
        '
        Me.lblServiceStartMode.AutoSize = True
        Me.lblServiceStartMode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblServiceStartMode.ForeColor = System.Drawing.Color.Navy
        Me.lblServiceStartMode.Location = New System.Drawing.Point(135, 114)
        Me.lblServiceStartMode.Margin = New System.Windows.Forms.Padding(4)
        Me.lblServiceStartMode.Name = "lblServiceStartMode"
        Me.lblServiceStartMode.Size = New System.Drawing.Size(569, 14)
        Me.lblServiceStartMode.TabIndex = 12
        Me.lblServiceStartMode.Text = "    "
        Me.lblServiceStartMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblServiceStartName
        '
        Me.lblServiceStartName.AutoSize = True
        Me.lblServiceStartName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblServiceStartName.ForeColor = System.Drawing.Color.Navy
        Me.lblServiceStartName.Location = New System.Drawing.Point(135, 92)
        Me.lblServiceStartName.Margin = New System.Windows.Forms.Padding(4)
        Me.lblServiceStartName.Name = "lblServiceStartName"
        Me.lblServiceStartName.Size = New System.Drawing.Size(569, 14)
        Me.lblServiceStartName.TabIndex = 11
        Me.lblServiceStartName.Text = "    "
        Me.lblServiceStartName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblServiceStarted
        '
        Me.lblServiceStarted.AutoSize = True
        Me.lblServiceStarted.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblServiceStarted.ForeColor = System.Drawing.Color.Navy
        Me.lblServiceStarted.Location = New System.Drawing.Point(135, 70)
        Me.lblServiceStarted.Margin = New System.Windows.Forms.Padding(4)
        Me.lblServiceStarted.Name = "lblServiceStarted"
        Me.lblServiceStarted.Size = New System.Drawing.Size(569, 14)
        Me.lblServiceStarted.TabIndex = 10
        Me.lblServiceStarted.Text = "    "
        Me.lblServiceStarted.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblServicePathName
        '
        Me.lblServicePathName.AutoSize = True
        Me.lblServicePathName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblServicePathName.ForeColor = System.Drawing.Color.Navy
        Me.lblServicePathName.Location = New System.Drawing.Point(135, 48)
        Me.lblServicePathName.Margin = New System.Windows.Forms.Padding(4)
        Me.lblServicePathName.Name = "lblServicePathName"
        Me.lblServicePathName.Size = New System.Drawing.Size(569, 14)
        Me.lblServicePathName.TabIndex = 9
        Me.lblServicePathName.Text = "    "
        Me.lblServicePathName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblServiceProcessID
        '
        Me.lblServiceProcessID.AutoSize = True
        Me.lblServiceProcessID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblServiceProcessID.ForeColor = System.Drawing.Color.Navy
        Me.lblServiceProcessID.Location = New System.Drawing.Point(135, 26)
        Me.lblServiceProcessID.Margin = New System.Windows.Forms.Padding(4)
        Me.lblServiceProcessID.Name = "lblServiceProcessID"
        Me.lblServiceProcessID.Size = New System.Drawing.Size(569, 14)
        Me.lblServiceProcessID.TabIndex = 0
        Me.lblServiceProcessID.Text = "    "
        Me.lblServiceProcessID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 114)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 14)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Start Mode:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 92)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 14)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Account Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 4)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Actual Service Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 26)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 14)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Process ID:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 48)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 14)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Path to Executable:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 70)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 14)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Service Running:"
        '
        'lblServiceName
        '
        Me.lblServiceName.AutoSize = True
        Me.lblServiceName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblServiceName.ForeColor = System.Drawing.Color.Navy
        Me.lblServiceName.Location = New System.Drawing.Point(135, 4)
        Me.lblServiceName.Margin = New System.Windows.Forms.Padding(4)
        Me.lblServiceName.Name = "lblServiceName"
        Me.lblServiceName.Size = New System.Drawing.Size(569, 14)
        Me.lblServiceName.TabIndex = 0
        Me.lblServiceName.Text = "    "
        Me.lblServiceName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.SysInfo.My.Resources.Resources.Services
        Me.PictureBox1.Location = New System.Drawing.Point(645, 90)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.TabIndex = 90
        Me.PictureBox1.TabStop = False
        '
        'Divider2
        '
        Me.Divider2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Divider2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Divider2.Location = New System.Drawing.Point(13, 61)
        Me.Divider2.Name = "Divider2"
        Me.Divider2.Size = New System.Drawing.Size(760, 23)
        Me.Divider2.TabIndex = 0
        Me.Divider2.TabStop = False
        Me.Divider2.Text = "Services"
        '
        'UserControlServices
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.lstServices)
        Me.Controls.Add(Me.Divider2)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "UserControlServices"
        Me.Size = New System.Drawing.Size(793, 668)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Divider2 As SysInfo.CustomControls.DividerControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lstServices As System.Windows.Forms.ListView
    Friend WithEvents colService As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtServiceDescription As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblServiceStartMode As System.Windows.Forms.Label
    Friend WithEvents lblServiceStartName As System.Windows.Forms.Label
    Friend WithEvents lblServiceStarted As System.Windows.Forms.Label
    Friend WithEvents lblServicePathName As System.Windows.Forms.Label
    Friend WithEvents lblServiceProcessID As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblServiceName As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
