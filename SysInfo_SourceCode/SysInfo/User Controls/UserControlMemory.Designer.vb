<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlMemory
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
		Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Not Set", "Not Set", "No", "None"}, -1)
		Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
		Me.Label80 = New System.Windows.Forms.Label
		Me.lblMemFree = New System.Windows.Forms.Label
		Me.lblMemInstalled = New System.Windows.Forms.Label
		Me.Label74 = New System.Windows.Forms.Label
		Me.Label81 = New System.Windows.Forms.Label
		Me.lblMemAvailable = New System.Windows.Forms.Label
		Me.lblMemUsed = New System.Windows.Forms.Label
		Me.Label87 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.lblMemMaxInstallable = New System.Windows.Forms.Label
		Me.Label93 = New System.Windows.Forms.Label
		Me.Label62 = New System.Windows.Forms.Label
		Me.Label99 = New System.Windows.Forms.Label
		Me.Label82 = New System.Windows.Forms.Label
		Me.lblMemType = New System.Windows.Forms.Label
		Me.lblMemForm = New System.Windows.Forms.Label
		Me.lblMemSlotsOccupied = New System.Windows.Forms.Label
		Me.lblMemSlotsAvailable = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.lstMemoryModules = New System.Windows.Forms.ListView
		Me.colBank = New System.Windows.Forms.ColumnHeader
		Me.colSize = New System.Windows.Forms.ColumnHeader
		Me.colSpeed = New System.Windows.Forms.ColumnHeader
		Me.colDataWidth = New System.Windows.Forms.ColumnHeader
		Me.PictureBox1 = New System.Windows.Forms.PictureBox
		Me.PictureBox7 = New System.Windows.Forms.PictureBox
		Me.lstPageFile = New System.Windows.Forms.ListView
		Me.colPFInitialSize = New System.Windows.Forms.ColumnHeader
		Me.colPFMaxSize = New System.Windows.Forms.ColumnHeader
		Me.colPFEncrypted = New System.Windows.Forms.ColumnHeader
		Me.colPFFile = New System.Windows.Forms.ColumnHeader
		Me.DividerControl1 = New SysInfo.CustomControls.DividerControl
		Me.Divider1 = New SysInfo.CustomControls.DividerControl
		Me.Divider2 = New SysInfo.CustomControls.DividerControl
		Me.TableLayoutPanel3.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'TableLayoutPanel3
		'
		Me.TableLayoutPanel3.AutoSize = True
		Me.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel3.ColumnCount = 2
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
		Me.TableLayoutPanel3.Controls.Add(Me.Label80, 0, 0)
		Me.TableLayoutPanel3.Controls.Add(Me.lblMemFree, 1, 2)
		Me.TableLayoutPanel3.Controls.Add(Me.lblMemInstalled, 1, 0)
		Me.TableLayoutPanel3.Controls.Add(Me.Label74, 0, 2)
		Me.TableLayoutPanel3.Controls.Add(Me.Label81, 0, 1)
		Me.TableLayoutPanel3.Controls.Add(Me.lblMemAvailable, 1, 1)
		Me.TableLayoutPanel3.Controls.Add(Me.lblMemUsed, 1, 3)
		Me.TableLayoutPanel3.Controls.Add(Me.Label87, 0, 3)
		Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 4)
		Me.TableLayoutPanel3.Controls.Add(Me.lblMemMaxInstallable, 1, 4)
		Me.TableLayoutPanel3.Controls.Add(Me.Label93, 0, 10)
		Me.TableLayoutPanel3.Controls.Add(Me.Label62, 0, 8)
		Me.TableLayoutPanel3.Controls.Add(Me.Label99, 0, 7)
		Me.TableLayoutPanel3.Controls.Add(Me.Label82, 0, 6)
		Me.TableLayoutPanel3.Controls.Add(Me.lblMemType, 1, 10)
		Me.TableLayoutPanel3.Controls.Add(Me.lblMemForm, 1, 8)
		Me.TableLayoutPanel3.Controls.Add(Me.lblMemSlotsOccupied, 1, 7)
		Me.TableLayoutPanel3.Controls.Add(Me.lblMemSlotsAvailable, 1, 6)
		Me.TableLayoutPanel3.Location = New System.Drawing.Point(49, 90)
		Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
		Me.TableLayoutPanel3.RowCount = 12
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle)
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle)
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle)
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle)
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle)
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle)
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle)
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle)
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle)
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle)
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle)
		Me.TableLayoutPanel3.Size = New System.Drawing.Size(178, 206)
		Me.TableLayoutPanel3.TabIndex = 79
		'
		'Label80
		'
		Me.Label80.AutoSize = True
		Me.Label80.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label80.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label80.Location = New System.Drawing.Point(4, 4)
		Me.Label80.Margin = New System.Windows.Forms.Padding(4)
		Me.Label80.Name = "Label80"
		Me.Label80.Size = New System.Drawing.Size(139, 14)
		Me.Label80.TabIndex = 71
		Me.Label80.Text = "Installed Memory:"
		Me.Label80.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblMemFree
		'
		Me.lblMemFree.AutoSize = True
		Me.lblMemFree.Dock = System.Windows.Forms.DockStyle.Left
		Me.lblMemFree.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMemFree.ForeColor = System.Drawing.Color.Navy
		Me.lblMemFree.Location = New System.Drawing.Point(151, 48)
		Me.lblMemFree.Margin = New System.Windows.Forms.Padding(4)
		Me.lblMemFree.Name = "lblMemFree"
		Me.lblMemFree.Size = New System.Drawing.Size(23, 14)
		Me.lblMemFree.TabIndex = 74
		Me.lblMemFree.Text = "    "
		Me.lblMemFree.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblMemInstalled
		'
		Me.lblMemInstalled.AutoEllipsis = True
		Me.lblMemInstalled.AutoSize = True
		Me.lblMemInstalled.BackColor = System.Drawing.Color.Transparent
		Me.lblMemInstalled.Dock = System.Windows.Forms.DockStyle.Left
		Me.lblMemInstalled.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMemInstalled.ForeColor = System.Drawing.Color.Navy
		Me.lblMemInstalled.Location = New System.Drawing.Point(151, 4)
		Me.lblMemInstalled.Margin = New System.Windows.Forms.Padding(4)
		Me.lblMemInstalled.Name = "lblMemInstalled"
		Me.lblMemInstalled.Size = New System.Drawing.Size(23, 14)
		Me.lblMemInstalled.TabIndex = 6
		Me.lblMemInstalled.Text = "    "
		Me.lblMemInstalled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label74
		'
		Me.Label74.AutoSize = True
		Me.Label74.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label74.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label74.Location = New System.Drawing.Point(4, 48)
		Me.Label74.Margin = New System.Windows.Forms.Padding(4)
		Me.Label74.Name = "Label74"
		Me.Label74.Size = New System.Drawing.Size(139, 14)
		Me.Label74.TabIndex = 73
		Me.Label74.Text = "Free Memory:"
		Me.Label74.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label81
		'
		Me.Label81.AutoSize = True
		Me.Label81.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label81.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label81.Location = New System.Drawing.Point(4, 26)
		Me.Label81.Margin = New System.Windows.Forms.Padding(4)
		Me.Label81.Name = "Label81"
		Me.Label81.Size = New System.Drawing.Size(139, 14)
		Me.Label81.TabIndex = 69
		Me.Label81.Text = "Available Memory:"
		Me.Label81.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblMemAvailable
		'
		Me.lblMemAvailable.AutoEllipsis = True
		Me.lblMemAvailable.AutoSize = True
		Me.lblMemAvailable.BackColor = System.Drawing.Color.Transparent
		Me.lblMemAvailable.Dock = System.Windows.Forms.DockStyle.Left
		Me.lblMemAvailable.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMemAvailable.ForeColor = System.Drawing.Color.Navy
		Me.lblMemAvailable.Location = New System.Drawing.Point(151, 26)
		Me.lblMemAvailable.Margin = New System.Windows.Forms.Padding(4)
		Me.lblMemAvailable.Name = "lblMemAvailable"
		Me.lblMemAvailable.Size = New System.Drawing.Size(23, 14)
		Me.lblMemAvailable.TabIndex = 8
		Me.lblMemAvailable.Text = "    "
		Me.lblMemAvailable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblMemUsed
		'
		Me.lblMemUsed.AutoSize = True
		Me.lblMemUsed.Dock = System.Windows.Forms.DockStyle.Left
		Me.lblMemUsed.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMemUsed.ForeColor = System.Drawing.Color.Navy
		Me.lblMemUsed.Location = New System.Drawing.Point(151, 70)
		Me.lblMemUsed.Margin = New System.Windows.Forms.Padding(4)
		Me.lblMemUsed.Name = "lblMemUsed"
		Me.lblMemUsed.Size = New System.Drawing.Size(23, 14)
		Me.lblMemUsed.TabIndex = 58
		Me.lblMemUsed.Text = "    "
		Me.lblMemUsed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label87
		'
		Me.Label87.AutoSize = True
		Me.Label87.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label87.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label87.Location = New System.Drawing.Point(4, 70)
		Me.Label87.Margin = New System.Windows.Forms.Padding(4)
		Me.Label87.Name = "Label87"
		Me.Label87.Size = New System.Drawing.Size(139, 14)
		Me.Label87.TabIndex = 57
		Me.Label87.Text = "Used Memory:"
		Me.Label87.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(4, 92)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(118, 14)
		Me.Label1.TabIndex = 85
		Me.Label1.Text = "Maximum Installable:"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblMemMaxInstallable
		'
		Me.lblMemMaxInstallable.AutoSize = True
		Me.lblMemMaxInstallable.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMemMaxInstallable.ForeColor = System.Drawing.Color.Navy
		Me.lblMemMaxInstallable.Location = New System.Drawing.Point(151, 92)
		Me.lblMemMaxInstallable.Margin = New System.Windows.Forms.Padding(4)
		Me.lblMemMaxInstallable.Name = "lblMemMaxInstallable"
		Me.lblMemMaxInstallable.Size = New System.Drawing.Size(23, 14)
		Me.lblMemMaxInstallable.TabIndex = 85
		Me.lblMemMaxInstallable.Text = "    "
		Me.lblMemMaxInstallable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label93
		'
		Me.Label93.AutoSize = True
		Me.Label93.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label93.Location = New System.Drawing.Point(4, 188)
		Me.Label93.Margin = New System.Windows.Forms.Padding(4)
		Me.Label93.Name = "Label93"
		Me.Label93.Size = New System.Drawing.Size(86, 14)
		Me.Label93.TabIndex = 82
		Me.Label93.Text = "Memory Type:"
		Me.Label93.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label62
		'
		Me.Label62.AutoSize = True
		Me.Label62.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label62.Location = New System.Drawing.Point(4, 166)
		Me.Label62.Margin = New System.Windows.Forms.Padding(4)
		Me.Label62.Name = "Label62"
		Me.Label62.Size = New System.Drawing.Size(81, 14)
		Me.Label62.TabIndex = 75
		Me.Label62.Text = "Module Form:"
		Me.Label62.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label99
		'
		Me.Label99.AutoSize = True
		Me.Label99.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label99.Location = New System.Drawing.Point(4, 144)
		Me.Label99.Margin = New System.Windows.Forms.Padding(4)
		Me.Label99.Name = "Label99"
		Me.Label99.Size = New System.Drawing.Size(139, 14)
		Me.Label99.TabIndex = 82
		Me.Label99.Text = "Occupied Memory Slots:"
		Me.Label99.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label82
		'
		Me.Label82.AutoSize = True
		Me.Label82.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label82.Location = New System.Drawing.Point(4, 122)
		Me.Label82.Margin = New System.Windows.Forms.Padding(4)
		Me.Label82.Name = "Label82"
		Me.Label82.Size = New System.Drawing.Size(129, 14)
		Me.Label82.TabIndex = 67
		Me.Label82.Text = "Physical Memory Slots:"
		Me.Label82.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblMemType
		'
		Me.lblMemType.AutoSize = True
		Me.lblMemType.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMemType.ForeColor = System.Drawing.Color.Navy
		Me.lblMemType.Location = New System.Drawing.Point(151, 188)
		Me.lblMemType.Margin = New System.Windows.Forms.Padding(4)
		Me.lblMemType.Name = "lblMemType"
		Me.lblMemType.Size = New System.Drawing.Size(23, 14)
		Me.lblMemType.TabIndex = 82
		Me.lblMemType.Text = "    "
		Me.lblMemType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblMemForm
		'
		Me.lblMemForm.AutoSize = True
		Me.lblMemForm.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMemForm.ForeColor = System.Drawing.Color.Navy
		Me.lblMemForm.Location = New System.Drawing.Point(151, 166)
		Me.lblMemForm.Margin = New System.Windows.Forms.Padding(4)
		Me.lblMemForm.Name = "lblMemForm"
		Me.lblMemForm.Size = New System.Drawing.Size(23, 14)
		Me.lblMemForm.TabIndex = 76
		Me.lblMemForm.Text = "    "
		Me.lblMemForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblMemSlotsOccupied
		'
		Me.lblMemSlotsOccupied.AutoSize = True
		Me.lblMemSlotsOccupied.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMemSlotsOccupied.ForeColor = System.Drawing.Color.Navy
		Me.lblMemSlotsOccupied.Location = New System.Drawing.Point(151, 144)
		Me.lblMemSlotsOccupied.Margin = New System.Windows.Forms.Padding(4)
		Me.lblMemSlotsOccupied.Name = "lblMemSlotsOccupied"
		Me.lblMemSlotsOccupied.Size = New System.Drawing.Size(23, 14)
		Me.lblMemSlotsOccupied.TabIndex = 80
		Me.lblMemSlotsOccupied.Text = "    "
		Me.lblMemSlotsOccupied.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblMemSlotsAvailable
		'
		Me.lblMemSlotsAvailable.AutoSize = True
		Me.lblMemSlotsAvailable.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMemSlotsAvailable.ForeColor = System.Drawing.Color.Navy
		Me.lblMemSlotsAvailable.Location = New System.Drawing.Point(151, 122)
		Me.lblMemSlotsAvailable.Margin = New System.Windows.Forms.Padding(4)
		Me.lblMemSlotsAvailable.Name = "lblMemSlotsAvailable"
		Me.lblMemSlotsAvailable.Size = New System.Drawing.Size(23, 14)
		Me.lblMemSlotsAvailable.TabIndex = 68
		Me.lblMemSlotsAvailable.Text = "    "
		Me.lblMemSlotsAvailable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.Label3.Location = New System.Drawing.Point(10, 21)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(455, 19)
		Me.Label3.TabIndex = 83
		Me.Label3.Text = "View information about your System's Installed Memory (RAM)"
		'
		'lstMemoryModules
		'
		Me.lstMemoryModules.AutoArrange = False
		Me.lstMemoryModules.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lstMemoryModules.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colBank, Me.colSize, Me.colSpeed, Me.colDataWidth})
		Me.lstMemoryModules.FullRowSelect = True
		Me.lstMemoryModules.GridLines = True
		Me.lstMemoryModules.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
		Me.lstMemoryModules.LabelWrap = False
		Me.lstMemoryModules.Location = New System.Drawing.Point(49, 494)
		Me.lstMemoryModules.MultiSelect = False
		Me.lstMemoryModules.Name = "lstMemoryModules"
		Me.lstMemoryModules.ShowGroups = False
		Me.lstMemoryModules.ShowItemToolTips = True
		Me.lstMemoryModules.Size = New System.Drawing.Size(416, 102)
		Me.lstMemoryModules.TabIndex = 85
		Me.lstMemoryModules.UseCompatibleStateImageBehavior = False
		Me.lstMemoryModules.View = System.Windows.Forms.View.Details
		'
		'colBank
		'
		Me.colBank.Text = "Bank"
		Me.colBank.Width = 100
		'
		'colSize
		'
		Me.colSize.Text = "Size (MBytes)"
		Me.colSize.Width = 100
		'
		'colSpeed
		'
		Me.colSpeed.Text = "Speed (MHz)"
		Me.colSpeed.Width = 100
		'
		'colDataWidth
		'
		Me.colDataWidth.Text = "Data Width (Bits)"
		Me.colDataWidth.Width = 110
		'
		'PictureBox1
		'
		Me.PictureBox1.BackgroundImage = Global.SysInfo.My.Resources.Resources.Memory_Modules
		Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.PictureBox1.Location = New System.Drawing.Point(642, 494)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
		Me.PictureBox1.TabIndex = 87
		Me.PictureBox1.TabStop = False
		'
		'PictureBox7
		'
		Me.PictureBox7.BackgroundImage = Global.SysInfo.My.Resources.Resources._107
		Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.PictureBox7.Location = New System.Drawing.Point(642, 90)
		Me.PictureBox7.Name = "PictureBox7"
		Me.PictureBox7.Size = New System.Drawing.Size(128, 128)
		Me.PictureBox7.TabIndex = 82
		Me.PictureBox7.TabStop = False
		'
		'lstPageFile
		'
		Me.lstPageFile.AutoArrange = False
		Me.lstPageFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lstPageFile.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colPFInitialSize, Me.colPFMaxSize, Me.colPFEncrypted, Me.colPFFile})
		Me.lstPageFile.GridLines = True
		Me.lstPageFile.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
		Me.lstPageFile.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
		Me.lstPageFile.LabelWrap = False
		Me.lstPageFile.Location = New System.Drawing.Point(49, 352)
		Me.lstPageFile.MultiSelect = False
		Me.lstPageFile.Name = "lstPageFile"
		Me.lstPageFile.ShowGroups = False
		Me.lstPageFile.ShowItemToolTips = True
		Me.lstPageFile.Size = New System.Drawing.Size(416, 86)
		Me.lstPageFile.TabIndex = 89
		Me.lstPageFile.UseCompatibleStateImageBehavior = False
		Me.lstPageFile.View = System.Windows.Forms.View.Details
		'
		'colPFInitialSize
		'
		Me.colPFInitialSize.Text = "Initial Size (MBs)"
		Me.colPFInitialSize.Width = 100
		'
		'colPFMaxSize
		'
		Me.colPFMaxSize.Text = "Max Size (MBs)"
		Me.colPFMaxSize.Width = 100
		'
		'colPFEncrypted
		'
		Me.colPFEncrypted.Text = "Encrypted?"
		Me.colPFEncrypted.Width = 80
		'
		'colPFFile
		'
		Me.colPFFile.Text = "File"
		Me.colPFFile.Width = 130
		'
		'DividerControl1
		'
        Me.DividerControl1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DividerControl1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.DividerControl1.Location = New System.Drawing.Point(10, 323)
		Me.DividerControl1.Name = "DividerControl1"
		Me.DividerControl1.Size = New System.Drawing.Size(760, 23)
		Me.DividerControl1.TabIndex = 88
		Me.DividerControl1.Text = "Page File (Virtual Memory)"
		'
		'Divider1
		'
        Me.Divider1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Divider1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.Divider1.Location = New System.Drawing.Point(10, 455)
		Me.Divider1.Name = "Divider1"
		Me.Divider1.Size = New System.Drawing.Size(760, 23)
		Me.Divider1.TabIndex = 86
		Me.Divider1.Text = "Installed Memory Modules"
		'
		'Divider2
		'
        Me.Divider2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Divider2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.Divider2.Location = New System.Drawing.Point(10, 62)
		Me.Divider2.Name = "Divider2"
		Me.Divider2.Size = New System.Drawing.Size(760, 23)
		Me.Divider2.TabIndex = 84
		Me.Divider2.Text = "Physical Memory"
		'
		'UserControlMemory
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.White
		Me.Controls.Add(Me.lstPageFile)
		Me.Controls.Add(Me.DividerControl1)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.Divider1)
		Me.Controls.Add(Me.lstMemoryModules)
		Me.Controls.Add(Me.Divider2)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.TableLayoutPanel3)
		Me.Controls.Add(Me.PictureBox7)
		Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Name = "UserControlMemory"
		Me.Size = New System.Drawing.Size(793, 668)
		Me.TableLayoutPanel3.ResumeLayout(False)
		Me.TableLayoutPanel3.PerformLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents lblMemSlotsOccupied As System.Windows.Forms.Label
	Friend WithEvents Label99 As System.Windows.Forms.Label
	Friend WithEvents Label80 As System.Windows.Forms.Label
	Friend WithEvents lblMemFree As System.Windows.Forms.Label
	Friend WithEvents lblMemInstalled As System.Windows.Forms.Label
	Friend WithEvents Label74 As System.Windows.Forms.Label
	Friend WithEvents Label81 As System.Windows.Forms.Label
	Friend WithEvents lblMemAvailable As System.Windows.Forms.Label
	Friend WithEvents lblMemUsed As System.Windows.Forms.Label
	Friend WithEvents Label87 As System.Windows.Forms.Label
	Friend WithEvents Label93 As System.Windows.Forms.Label
	Friend WithEvents Label62 As System.Windows.Forms.Label
	Friend WithEvents lblMemType As System.Windows.Forms.Label
	Friend WithEvents lblMemForm As System.Windows.Forms.Label
	Friend WithEvents Label82 As System.Windows.Forms.Label
	Friend WithEvents lblMemSlotsAvailable As System.Windows.Forms.Label
	Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
	Friend WithEvents Divider2 As SysInfo.CustomControls.DividerControl
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents lblMemMaxInstallable As System.Windows.Forms.Label
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents lstMemoryModules As System.Windows.Forms.ListView
	Friend WithEvents colBank As System.Windows.Forms.ColumnHeader
	Friend WithEvents colSize As System.Windows.Forms.ColumnHeader
	Friend WithEvents colSpeed As System.Windows.Forms.ColumnHeader
	Friend WithEvents Divider1 As SysInfo.CustomControls.DividerControl
	Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
	Friend WithEvents colDataWidth As System.Windows.Forms.ColumnHeader
	Friend WithEvents DividerControl1 As SysInfo.CustomControls.DividerControl
	Friend WithEvents lstPageFile As System.Windows.Forms.ListView
	Friend WithEvents colPFInitialSize As System.Windows.Forms.ColumnHeader
	Friend WithEvents colPFMaxSize As System.Windows.Forms.ColumnHeader
	Friend WithEvents colPFEncrypted As System.Windows.Forms.ColumnHeader
	Friend WithEvents colPFFile As System.Windows.Forms.ColumnHeader

End Class
