<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlStorage
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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox7 = New System.Windows.Forms.PictureBox
        Me.lstPhysicalDisks = New System.Windows.Forms.ListView
        Me.colDiskDesc = New System.Windows.Forms.ColumnHeader
        Me.colSize = New System.Windows.Forms.ColumnHeader
        Me.colPartitions = New System.Windows.Forms.ColumnHeader
        Me.colSerialNo = New System.Windows.Forms.ColumnHeader
        Me.colFirmware = New System.Windows.Forms.ColumnHeader
        Me.lstUSBDisks = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.lstCDDrives = New System.Windows.Forms.ListView
        Me.colName = New System.Windows.Forms.ColumnHeader
        Me.colDriveLetter = New System.Windows.Forms.ColumnHeader
        Me.colMediaLoaded = New System.Windows.Forms.ColumnHeader
        Me.colMediaType = New System.Windows.Forms.ColumnHeader
        Me.DividerControl2 = New SysInfo.CustomControls.DividerControl
        Me.DividerControl1 = New SysInfo.CustomControls.DividerControl
        Me.Divider2 = New SysInfo.CustomControls.DividerControl
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(10, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(395, 19)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "View information about your System's Storage Devices"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.SysInfo.My.Resources.Resources.CD_Drive
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(642, 459)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox2.TabIndex = 91
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.SysInfo.My.Resources.Resources.USB
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(642, 274)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.TabIndex = 90
        Me.PictureBox1.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackgroundImage = Global.SysInfo.My.Resources.Resources.HardDrive
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox7.Location = New System.Drawing.Point(642, 90)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox7.TabIndex = 89
        Me.PictureBox7.TabStop = False
        '
        'lstPhysicalDisks
        '
        Me.lstPhysicalDisks.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
        Me.lstPhysicalDisks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstPhysicalDisks.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colDiskDesc, Me.colSize, Me.colPartitions, Me.colSerialNo, Me.colFirmware})
        Me.lstPhysicalDisks.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPhysicalDisks.GridLines = True
        Me.lstPhysicalDisks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstPhysicalDisks.Location = New System.Drawing.Point(49, 90)
        Me.lstPhysicalDisks.MultiSelect = False
        Me.lstPhysicalDisks.Name = "lstPhysicalDisks"
        Me.lstPhysicalDisks.ShowGroups = False
        Me.lstPhysicalDisks.ShowItemToolTips = True
        Me.lstPhysicalDisks.Size = New System.Drawing.Size(557, 128)
        Me.lstPhysicalDisks.TabIndex = 95
        Me.lstPhysicalDisks.UseCompatibleStateImageBehavior = False
        Me.lstPhysicalDisks.View = System.Windows.Forms.View.Details
        '
        'colDiskDesc
        '
        Me.colDiskDesc.Text = "Disk Description"
        Me.colDiskDesc.Width = 175
        '
        'colSize
        '
        Me.colSize.Text = "Size (GBs)"
        Me.colSize.Width = 75
        '
        'colPartitions
        '
        Me.colPartitions.Text = "Partitions"
        Me.colPartitions.Width = 65
        '
        'colSerialNo
        '
        Me.colSerialNo.Text = "Serial No."
        Me.colSerialNo.Width = 145
        '
        'colFirmware
        '
        Me.colFirmware.Text = "Firmware"
        Me.colFirmware.Width = 70
        '
        'lstUSBDisks
        '
        Me.lstUSBDisks.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
        Me.lstUSBDisks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstUSBDisks.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lstUSBDisks.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstUSBDisks.GridLines = True
        Me.lstUSBDisks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstUSBDisks.Location = New System.Drawing.Point(49, 274)
        Me.lstUSBDisks.MultiSelect = False
        Me.lstUSBDisks.Name = "lstUSBDisks"
        Me.lstUSBDisks.ShowGroups = False
        Me.lstUSBDisks.ShowItemToolTips = True
        Me.lstUSBDisks.Size = New System.Drawing.Size(557, 128)
        Me.lstUSBDisks.TabIndex = 96
        Me.lstUSBDisks.UseCompatibleStateImageBehavior = False
        Me.lstUSBDisks.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Drive Description"
        Me.ColumnHeader1.Width = 175
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Size (GBs)"
        Me.ColumnHeader3.Width = 75
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Partitions"
        Me.ColumnHeader4.Width = 65
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Serial No."
        Me.ColumnHeader5.Width = 145
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Firmware"
        Me.ColumnHeader6.Width = 70
        '
        'lstCDDrives
        '
        Me.lstCDDrives.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
        Me.lstCDDrives.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstCDDrives.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colName, Me.colDriveLetter, Me.colMediaLoaded, Me.colMediaType})
        Me.lstCDDrives.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCDDrives.GridLines = True
        Me.lstCDDrives.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstCDDrives.Location = New System.Drawing.Point(49, 459)
        Me.lstCDDrives.MultiSelect = False
        Me.lstCDDrives.Name = "lstCDDrives"
        Me.lstCDDrives.ShowGroups = False
        Me.lstCDDrives.ShowItemToolTips = True
        Me.lstCDDrives.Size = New System.Drawing.Size(557, 128)
        Me.lstCDDrives.TabIndex = 97
        Me.lstCDDrives.UseCompatibleStateImageBehavior = False
        Me.lstCDDrives.View = System.Windows.Forms.View.Details
        '
        'colName
        '
        Me.colName.Text = "Device Name"
        Me.colName.Width = 185
        '
        'colDriveLetter
        '
        Me.colDriveLetter.Text = "Drive Letter"
        Me.colDriveLetter.Width = 100
        '
        'colMediaLoaded
        '
        Me.colMediaLoaded.Text = "Media Loaded?"
        Me.colMediaLoaded.Width = 100
        '
        'colMediaType
        '
        Me.colMediaType.Text = "Drive Type"
        Me.colMediaType.Width = 145
        '
        'DividerControl2
        '
        Me.DividerControl2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DividerControl2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DividerControl2.Location = New System.Drawing.Point(10, 245)
        Me.DividerControl2.Name = "DividerControl2"
        Me.DividerControl2.Size = New System.Drawing.Size(760, 23)
        Me.DividerControl2.TabIndex = 88
        Me.DividerControl2.Text = "Removable USB Drives"
        '
        'DividerControl1
        '
        Me.DividerControl1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DividerControl1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DividerControl1.Location = New System.Drawing.Point(10, 430)
        Me.DividerControl1.Name = "DividerControl1"
        Me.DividerControl1.Size = New System.Drawing.Size(760, 23)
        Me.DividerControl1.TabIndex = 87
        Me.DividerControl1.Text = "CD/DVD Drives"
        '
        'Divider2
        '
        Me.Divider2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Divider2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Divider2.Location = New System.Drawing.Point(10, 61)
        Me.Divider2.Name = "Divider2"
        Me.Divider2.Size = New System.Drawing.Size(760, 23)
        Me.Divider2.TabIndex = 86
        Me.Divider2.Text = "Physical Disk Drives"
        '
        'UserControlStorage
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.lstCDDrives)
        Me.Controls.Add(Me.lstUSBDisks)
        Me.Controls.Add(Me.lstPhysicalDisks)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.DividerControl2)
        Me.Controls.Add(Me.DividerControl1)
        Me.Controls.Add(Me.Divider2)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "UserControlStorage"
        Me.Size = New System.Drawing.Size(793, 668)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Divider2 As SysInfo.CustomControls.DividerControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DividerControl1 As SysInfo.CustomControls.DividerControl
    Friend WithEvents DividerControl2 As SysInfo.CustomControls.DividerControl
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lstPhysicalDisks As System.Windows.Forms.ListView
    Friend WithEvents colDiskDesc As System.Windows.Forms.ColumnHeader
    Friend WithEvents colSize As System.Windows.Forms.ColumnHeader
    Friend WithEvents colPartitions As System.Windows.Forms.ColumnHeader
    Friend WithEvents colSerialNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents colFirmware As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstUSBDisks As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstCDDrives As System.Windows.Forms.ListView
    Friend WithEvents colName As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDriveLetter As System.Windows.Forms.ColumnHeader
    Friend WithEvents colMediaLoaded As System.Windows.Forms.ColumnHeader
    Friend WithEvents colMediaType As System.Windows.Forms.ColumnHeader

End Class
