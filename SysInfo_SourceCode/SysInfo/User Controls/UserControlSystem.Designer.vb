<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlSystem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControlSystem))
        Me.lblSysLastBoot = New System.Windows.Forms.Label
        Me.Label97 = New System.Windows.Forms.Label
        Me.lblSysIdentifier = New System.Windows.Forms.Label
        Me.Label85 = New System.Windows.Forms.Label
        Me.Label84 = New System.Windows.Forms.Label
        Me.lblSysThreads = New System.Windows.Forms.Label
        Me.lblSysProcesses = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblMoBoMake = New System.Windows.Forms.Label
        Me.Label96 = New System.Windows.Forms.Label
        Me.Label98 = New System.Windows.Forms.Label
        Me.lblSysPrinter = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblMoBoModel = New System.Windows.Forms.Label
        Me.Label94 = New System.Windows.Forms.Label
        Me.lblMoBoRevision = New System.Windows.Forms.Label
        Me.Label89 = New System.Windows.Forms.Label
        Me.lblMoBoSerialNumber = New System.Windows.Forms.Label
        Me.Label95 = New System.Windows.Forms.Label
        Me.lblSysUUID = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label88 = New System.Windows.Forms.Label
        Me.lblBiosMake = New System.Windows.Forms.Label
        Me.lblSMBiosVersion = New System.Windows.Forms.Label
        Me.lblBiosDate = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.lblBiosVersion = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
        Me.lblSysVersion = New System.Windows.Forms.Label
        Me.lblSysVendor = New System.Windows.Forms.Label
        Me.lblSysName = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel
        Me.pctOEMBitmap = New System.Windows.Forms.PictureBox
        Me.pctBiosMake = New System.Windows.Forms.PictureBox
        Me.pctOSLogo = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblSysUptime = New System.Windows.Forms.Label
        Me.Divider4 = New SysInfo.CustomControls.DividerControl
        Me.Divider3 = New SysInfo.CustomControls.DividerControl
        Me.Divider1 = New SysInfo.CustomControls.DividerControl
        Me.Divider2 = New SysInfo.CustomControls.DividerControl
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.pctOEMBitmap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctBiosMake, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctOSLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSysLastBoot
        '
        Me.lblSysLastBoot.AutoSize = True
        Me.lblSysLastBoot.BackColor = System.Drawing.Color.Transparent
        Me.lblSysLastBoot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSysLastBoot.ForeColor = System.Drawing.Color.Navy
        Me.lblSysLastBoot.Location = New System.Drawing.Point(113, 4)
        Me.lblSysLastBoot.Margin = New System.Windows.Forms.Padding(4)
        Me.lblSysLastBoot.Name = "lblSysLastBoot"
        Me.lblSysLastBoot.Size = New System.Drawing.Size(23, 14)
        Me.lblSysLastBoot.TabIndex = 67
        Me.lblSysLastBoot.Text = "    "
        Me.lblSysLastBoot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label97
        '
        Me.Label97.AutoSize = True
        Me.Label97.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label97.Location = New System.Drawing.Point(4, 4)
        Me.Label97.Margin = New System.Windows.Forms.Padding(4)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(101, 14)
        Me.Label97.TabIndex = 70
        Me.Label97.Text = "Last Boot Time:"
        Me.Label97.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSysIdentifier
        '
        Me.lblSysIdentifier.AutoSize = True
        Me.lblSysIdentifier.BackColor = System.Drawing.Color.Transparent
        Me.lblSysIdentifier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSysIdentifier.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSysIdentifier.ForeColor = System.Drawing.Color.Navy
        Me.lblSysIdentifier.Location = New System.Drawing.Point(134, 70)
        Me.lblSysIdentifier.Margin = New System.Windows.Forms.Padding(4)
        Me.lblSysIdentifier.Name = "lblSysIdentifier"
        Me.lblSysIdentifier.Size = New System.Drawing.Size(23, 14)
        Me.lblSysIdentifier.TabIndex = 68
        Me.lblSysIdentifier.Text = "    "
        Me.lblSysIdentifier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label85.Location = New System.Drawing.Point(4, 80)
        Me.Label85.Margin = New System.Windows.Forms.Padding(4)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(101, 14)
        Me.Label85.TabIndex = 66
        Me.Label85.Text = "Threads:"
        Me.Label85.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label84.Location = New System.Drawing.Point(4, 58)
        Me.Label84.Margin = New System.Windows.Forms.Padding(4)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(101, 14)
        Me.Label84.TabIndex = 66
        Me.Label84.Text = "Processes:"
        Me.Label84.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSysThreads
        '
        Me.lblSysThreads.AutoSize = True
        Me.lblSysThreads.BackColor = System.Drawing.Color.Transparent
        Me.lblSysThreads.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSysThreads.ForeColor = System.Drawing.Color.Navy
        Me.lblSysThreads.Location = New System.Drawing.Point(113, 80)
        Me.lblSysThreads.Margin = New System.Windows.Forms.Padding(4)
        Me.lblSysThreads.Name = "lblSysThreads"
        Me.lblSysThreads.Size = New System.Drawing.Size(23, 14)
        Me.lblSysThreads.TabIndex = 66
        Me.lblSysThreads.Text = "    "
        Me.lblSysThreads.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSysProcesses
        '
        Me.lblSysProcesses.AutoSize = True
        Me.lblSysProcesses.BackColor = System.Drawing.Color.Transparent
        Me.lblSysProcesses.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSysProcesses.ForeColor = System.Drawing.Color.Navy
        Me.lblSysProcesses.Location = New System.Drawing.Point(113, 58)
        Me.lblSysProcesses.Margin = New System.Windows.Forms.Padding(4)
        Me.lblSysProcesses.Name = "lblSysProcesses"
        Me.lblSysProcesses.Size = New System.Drawing.Size(23, 14)
        Me.lblSysProcesses.TabIndex = 66
        Me.lblSysProcesses.Text = "    "
        Me.lblSysProcesses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 4)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 14)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Manufacturer:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMoBoMake
        '
        Me.lblMoBoMake.AutoSize = True
        Me.lblMoBoMake.BackColor = System.Drawing.Color.Transparent
        Me.lblMoBoMake.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMoBoMake.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoBoMake.ForeColor = System.Drawing.Color.Navy
        Me.lblMoBoMake.Location = New System.Drawing.Point(134, 4)
        Me.lblMoBoMake.Margin = New System.Windows.Forms.Padding(4)
        Me.lblMoBoMake.Name = "lblMoBoMake"
        Me.lblMoBoMake.Size = New System.Drawing.Size(23, 14)
        Me.lblMoBoMake.TabIndex = 64
        Me.lblMoBoMake.Text = "    "
        Me.lblMoBoMake.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label96
        '
        Me.Label96.AutoSize = True
        Me.Label96.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label96.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label96.Location = New System.Drawing.Point(4, 70)
        Me.Label96.Margin = New System.Windows.Forms.Padding(4)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(122, 14)
        Me.Label96.TabIndex = 69
        Me.Label96.Text = "Identifier:"
        Me.Label96.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label98
        '
        Me.Label98.AutoSize = True
        Me.Label98.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label98.Location = New System.Drawing.Point(4, 4)
        Me.Label98.Margin = New System.Windows.Forms.Padding(4)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(90, 14)
        Me.Label98.TabIndex = 71
        Me.Label98.Text = "Default Printer:"
        Me.Label98.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSysPrinter
        '
        Me.lblSysPrinter.AutoSize = True
        Me.lblSysPrinter.BackColor = System.Drawing.Color.Transparent
        Me.lblSysPrinter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSysPrinter.ForeColor = System.Drawing.Color.Navy
        Me.lblSysPrinter.Location = New System.Drawing.Point(102, 4)
        Me.lblSysPrinter.Margin = New System.Windows.Forms.Padding(4)
        Me.lblSysPrinter.Name = "lblSysPrinter"
        Me.lblSysPrinter.Size = New System.Drawing.Size(23, 14)
        Me.lblSysPrinter.TabIndex = 72
        Me.lblSysPrinter.Text = "    "
        Me.lblSysPrinter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 26)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 14)
        Me.Label10.TabIndex = 64
        Me.Label10.Text = "Model:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMoBoModel
        '
        Me.lblMoBoModel.AutoSize = True
        Me.lblMoBoModel.BackColor = System.Drawing.Color.Transparent
        Me.lblMoBoModel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMoBoModel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoBoModel.ForeColor = System.Drawing.Color.Navy
        Me.lblMoBoModel.Location = New System.Drawing.Point(134, 26)
        Me.lblMoBoModel.Margin = New System.Windows.Forms.Padding(4)
        Me.lblMoBoModel.Name = "lblMoBoModel"
        Me.lblMoBoModel.Size = New System.Drawing.Size(23, 14)
        Me.lblMoBoModel.TabIndex = 65
        Me.lblMoBoModel.Text = "    "
        Me.lblMoBoModel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label94.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label94.Location = New System.Drawing.Point(4, 48)
        Me.Label94.Margin = New System.Windows.Forms.Padding(4)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(122, 14)
        Me.Label94.TabIndex = 68
        Me.Label94.Text = "Version:"
        Me.Label94.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMoBoRevision
        '
        Me.lblMoBoRevision.AutoSize = True
        Me.lblMoBoRevision.BackColor = System.Drawing.Color.Transparent
        Me.lblMoBoRevision.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMoBoRevision.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoBoRevision.ForeColor = System.Drawing.Color.Navy
        Me.lblMoBoRevision.Location = New System.Drawing.Point(134, 48)
        Me.lblMoBoRevision.Margin = New System.Windows.Forms.Padding(4)
        Me.lblMoBoRevision.Name = "lblMoBoRevision"
        Me.lblMoBoRevision.Size = New System.Drawing.Size(23, 14)
        Me.lblMoBoRevision.TabIndex = 67
        Me.lblMoBoRevision.Text = "    "
        Me.lblMoBoRevision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label89.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label89.Location = New System.Drawing.Point(4, 70)
        Me.Label89.Margin = New System.Windows.Forms.Padding(4)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(122, 14)
        Me.Label89.TabIndex = 67
        Me.Label89.Text = "Serial Number:"
        Me.Label89.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMoBoSerialNumber
        '
        Me.lblMoBoSerialNumber.AutoSize = True
        Me.lblMoBoSerialNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblMoBoSerialNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMoBoSerialNumber.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoBoSerialNumber.ForeColor = System.Drawing.Color.Navy
        Me.lblMoBoSerialNumber.Location = New System.Drawing.Point(134, 70)
        Me.lblMoBoSerialNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.lblMoBoSerialNumber.Name = "lblMoBoSerialNumber"
        Me.lblMoBoSerialNumber.Size = New System.Drawing.Size(23, 14)
        Me.lblMoBoSerialNumber.TabIndex = 66
        Me.lblMoBoSerialNumber.Text = "    "
        Me.lblMoBoSerialNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label95
        '
        Me.Label95.AutoSize = True
        Me.Label95.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label95.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label95.Location = New System.Drawing.Point(4, 92)
        Me.Label95.Margin = New System.Windows.Forms.Padding(4)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(122, 14)
        Me.Label95.TabIndex = 68
        Me.Label95.Text = "UUID:"
        Me.Label95.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSysUUID
        '
        Me.lblSysUUID.AutoSize = True
        Me.lblSysUUID.BackColor = System.Drawing.Color.Transparent
        Me.lblSysUUID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSysUUID.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSysUUID.ForeColor = System.Drawing.Color.Navy
        Me.lblSysUUID.Location = New System.Drawing.Point(134, 92)
        Me.lblSysUUID.Margin = New System.Windows.Forms.Padding(4)
        Me.lblSysUUID.Name = "lblSysUUID"
        Me.lblSysUUID.Size = New System.Drawing.Size(23, 14)
        Me.lblSysUUID.TabIndex = 67
        Me.lblSysUUID.Text = "    "
        Me.lblSysUUID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(4, 4)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(122, 14)
        Me.Label12.TabIndex = 64
        Me.Label12.Text = "Manufacturer:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(4, 26)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(122, 14)
        Me.Label13.TabIndex = 65
        Me.Label13.Text = "SM Bios Version:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label88.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label88.Location = New System.Drawing.Point(4, 70)
        Me.Label88.Margin = New System.Windows.Forms.Padding(4)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(122, 14)
        Me.Label88.TabIndex = 66
        Me.Label88.Text = "Release Date:"
        Me.Label88.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBiosMake
        '
        Me.lblBiosMake.AutoSize = True
        Me.lblBiosMake.BackColor = System.Drawing.Color.Transparent
        Me.lblBiosMake.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblBiosMake.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBiosMake.ForeColor = System.Drawing.Color.Navy
        Me.lblBiosMake.Location = New System.Drawing.Point(134, 4)
        Me.lblBiosMake.Margin = New System.Windows.Forms.Padding(4)
        Me.lblBiosMake.Name = "lblBiosMake"
        Me.lblBiosMake.Size = New System.Drawing.Size(23, 14)
        Me.lblBiosMake.TabIndex = 64
        Me.lblBiosMake.Text = "    "
        Me.lblBiosMake.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSMBiosVersion
        '
        Me.lblSMBiosVersion.AutoSize = True
        Me.lblSMBiosVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblSMBiosVersion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSMBiosVersion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSMBiosVersion.ForeColor = System.Drawing.Color.Navy
        Me.lblSMBiosVersion.Location = New System.Drawing.Point(134, 26)
        Me.lblSMBiosVersion.Margin = New System.Windows.Forms.Padding(4)
        Me.lblSMBiosVersion.Name = "lblSMBiosVersion"
        Me.lblSMBiosVersion.Size = New System.Drawing.Size(23, 14)
        Me.lblSMBiosVersion.TabIndex = 65
        Me.lblSMBiosVersion.Text = "    "
        Me.lblSMBiosVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBiosDate
        '
        Me.lblBiosDate.AutoSize = True
        Me.lblBiosDate.BackColor = System.Drawing.Color.Transparent
        Me.lblBiosDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblBiosDate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBiosDate.ForeColor = System.Drawing.Color.Navy
        Me.lblBiosDate.Location = New System.Drawing.Point(134, 70)
        Me.lblBiosDate.Margin = New System.Windows.Forms.Padding(4)
        Me.lblBiosDate.Name = "lblBiosDate"
        Me.lblBiosDate.Size = New System.Drawing.Size(23, 14)
        Me.lblBiosDate.TabIndex = 66
        Me.lblBiosDate.Text = "    "
        Me.lblBiosDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(10, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(343, 19)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "View information about your Computer System"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel1.Controls.Add(Me.lblMoBoSerialNumber, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblMoBoMake, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblMoBoModel, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label94, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblMoBoRevision, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label89, 0, 3)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(49, 249)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(161, 88)
        Me.TableLayoutPanel1.TabIndex = 68
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel2.Controls.Add(Me.lblBiosVersion, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label12, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblBiosMake, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label13, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblSMBiosVersion, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label88, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lblBiosDate, 1, 3)
        Me.TableLayoutPanel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(49, 391)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(161, 88)
        Me.TableLayoutPanel2.TabIndex = 70
        '
        'lblBiosVersion
        '
        Me.lblBiosVersion.AutoSize = True
        Me.lblBiosVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblBiosVersion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblBiosVersion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBiosVersion.ForeColor = System.Drawing.Color.Navy
        Me.lblBiosVersion.Location = New System.Drawing.Point(134, 48)
        Me.lblBiosVersion.Margin = New System.Windows.Forms.Padding(4)
        Me.lblBiosVersion.Name = "lblBiosVersion"
        Me.lblBiosVersion.Size = New System.Drawing.Size(23, 14)
        Me.lblBiosVersion.TabIndex = 75
        Me.lblBiosVersion.Text = "    "
        Me.lblBiosVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 48)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 14)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Bios Version:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSize = True
        Me.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel3.Controls.Add(Me.lblSysVersion, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.lblSysVendor, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.lblSysName, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label9, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label8, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label96, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.lblSysIdentifier, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label95, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.lblSysUUID, 1, 4)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(49, 90)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 5
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(161, 110)
        Me.TableLayoutPanel3.TabIndex = 76
        '
        'lblSysVersion
        '
        Me.lblSysVersion.AutoSize = True
        Me.lblSysVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblSysVersion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSysVersion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSysVersion.ForeColor = System.Drawing.Color.Navy
        Me.lblSysVersion.Location = New System.Drawing.Point(134, 48)
        Me.lblSysVersion.Margin = New System.Windows.Forms.Padding(4)
        Me.lblSysVersion.Name = "lblSysVersion"
        Me.lblSysVersion.Size = New System.Drawing.Size(23, 14)
        Me.lblSysVersion.TabIndex = 77
        Me.lblSysVersion.Text = "    "
        Me.lblSysVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSysVendor
        '
        Me.lblSysVendor.AutoSize = True
        Me.lblSysVendor.BackColor = System.Drawing.Color.Transparent
        Me.lblSysVendor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSysVendor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSysVendor.ForeColor = System.Drawing.Color.Navy
        Me.lblSysVendor.Location = New System.Drawing.Point(134, 26)
        Me.lblSysVendor.Margin = New System.Windows.Forms.Padding(4)
        Me.lblSysVendor.Name = "lblSysVendor"
        Me.lblSysVendor.Size = New System.Drawing.Size(23, 14)
        Me.lblSysVendor.TabIndex = 77
        Me.lblSysVendor.Text = "    "
        Me.lblSysVendor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSysName
        '
        Me.lblSysName.AutoSize = True
        Me.lblSysName.BackColor = System.Drawing.Color.Transparent
        Me.lblSysName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSysName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSysName.ForeColor = System.Drawing.Color.Navy
        Me.lblSysName.Location = New System.Drawing.Point(134, 4)
        Me.lblSysName.Margin = New System.Windows.Forms.Padding(4)
        Me.lblSysName.Name = "lblSysName"
        Me.lblSysName.Size = New System.Drawing.Size(23, 14)
        Me.lblSysName.TabIndex = 77
        Me.lblSysName.Text = "    "
        Me.lblSysName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(4, 48)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 14)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = "Version:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 26)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 14)
        Me.Label8.TabIndex = 78
        Me.Label8.Text = "Vendor:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 4)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 14)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Name:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.AutoSize = True
        Me.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel4.Controls.Add(Me.lblSysUptime, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label97, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lblSysLastBoot, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label84, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.lblSysProcesses, 1, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.Label85, 0, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.lblSysThreads, 1, 3)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(49, 531)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 4
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(140, 98)
        Me.TableLayoutPanel4.TabIndex = 79
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.AutoSize = True
        Me.TableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel5.Controls.Add(Me.Label98, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.lblSysPrinter, 1, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(460, 531)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(129, 42)
        Me.TableLayoutPanel5.TabIndex = 80
        '
        'pctOEMBitmap
        '
        Me.pctOEMBitmap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pctOEMBitmap.Location = New System.Drawing.Point(646, 90)
        Me.pctOEMBitmap.Name = "pctOEMBitmap"
        Me.pctOEMBitmap.Size = New System.Drawing.Size(128, 128)
        Me.pctOEMBitmap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctOEMBitmap.TabIndex = 77
        Me.pctOEMBitmap.TabStop = False
        '
        'pctBiosMake
        '
        Me.pctBiosMake.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pctBiosMake.Location = New System.Drawing.Point(646, 391)
        Me.pctBiosMake.Name = "pctBiosMake"
        Me.pctBiosMake.Size = New System.Drawing.Size(128, 88)
        Me.pctBiosMake.TabIndex = 74
        Me.pctBiosMake.TabStop = False
        '
        'pctOSLogo
        '
        Me.pctOSLogo.BackgroundImage = CType(resources.GetObject("pctOSLogo.BackgroundImage"), System.Drawing.Image)
        Me.pctOSLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pctOSLogo.Location = New System.Drawing.Point(646, 236)
        Me.pctOSLogo.Name = "pctOSLogo"
        Me.pctOSLogo.Size = New System.Drawing.Size(128, 128)
        Me.pctOSLogo.TabIndex = 73
        Me.pctOSLogo.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(4, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 14)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "System Up Time:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSysUptime
        '
        Me.lblSysUptime.AutoSize = True
        Me.lblSysUptime.BackColor = System.Drawing.Color.Transparent
        Me.lblSysUptime.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblSysUptime.ForeColor = System.Drawing.Color.Navy
        Me.lblSysUptime.Location = New System.Drawing.Point(113, 26)
        Me.lblSysUptime.Margin = New System.Windows.Forms.Padding(4)
        Me.lblSysUptime.Name = "lblSysUptime"
        Me.lblSysUptime.Size = New System.Drawing.Size(23, 14)
        Me.lblSysUptime.TabIndex = 85
        Me.lblSysUptime.Text = "    "
        Me.lblSysUptime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Divider4
        '
        Me.Divider4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Divider4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Divider4.Location = New System.Drawing.Point(10, 502)
        Me.Divider4.Name = "Divider4"
        Me.Divider4.Size = New System.Drawing.Size(760, 23)
        Me.Divider4.TabIndex = 84
        Me.Divider4.Text = "Miscellaneous"
        '
        'Divider3
        '
        Me.Divider3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Divider3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Divider3.Location = New System.Drawing.Point(10, 362)
        Me.Divider3.Name = "Divider3"
        Me.Divider3.Size = New System.Drawing.Size(760, 23)
        Me.Divider3.TabIndex = 83
        Me.Divider3.Text = "BIOS"
        '
        'Divider1
        '
        Me.Divider1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Divider1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Divider1.Location = New System.Drawing.Point(10, 220)
        Me.Divider1.Name = "Divider1"
        Me.Divider1.Size = New System.Drawing.Size(760, 23)
        Me.Divider1.TabIndex = 82
        Me.Divider1.Text = "Motherboard"
        '
        'Divider2
        '
        Me.Divider2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Divider2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Divider2.Location = New System.Drawing.Point(10, 61)
        Me.Divider2.Name = "Divider2"
        Me.Divider2.Size = New System.Drawing.Size(760, 23)
        Me.Divider2.TabIndex = 81
        Me.Divider2.Text = "System"
        '
        'UserControlSystem
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Divider4)
        Me.Controls.Add(Me.Divider3)
        Me.Controls.Add(Me.Divider1)
        Me.Controls.Add(Me.Divider2)
        Me.Controls.Add(Me.TableLayoutPanel5)
        Me.Controls.Add(Me.TableLayoutPanel4)
        Me.Controls.Add(Me.pctOEMBitmap)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.pctBiosMake)
        Me.Controls.Add(Me.pctOSLogo)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label3)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "UserControlSystem"
        Me.Size = New System.Drawing.Size(793, 668)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        CType(Me.pctOEMBitmap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctBiosMake, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctOSLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSysLastBoot As System.Windows.Forms.Label
    Friend WithEvents Label97 As System.Windows.Forms.Label
    Friend WithEvents lblSysIdentifier As System.Windows.Forms.Label
    Friend WithEvents Label85 As System.Windows.Forms.Label
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents lblSysThreads As System.Windows.Forms.Label
    Friend WithEvents lblSysProcesses As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblMoBoMake As System.Windows.Forms.Label
    Friend WithEvents Label96 As System.Windows.Forms.Label
    Friend WithEvents Label98 As System.Windows.Forms.Label
    Friend WithEvents lblSysPrinter As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblMoBoModel As System.Windows.Forms.Label
    Friend WithEvents Label94 As System.Windows.Forms.Label
    Friend WithEvents lblMoBoRevision As System.Windows.Forms.Label
    Friend WithEvents Label89 As System.Windows.Forms.Label
    Friend WithEvents lblMoBoSerialNumber As System.Windows.Forms.Label
    Friend WithEvents Label95 As System.Windows.Forms.Label
    Friend WithEvents lblSysUUID As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents lblBiosMake As System.Windows.Forms.Label
    Friend WithEvents lblSMBiosVersion As System.Windows.Forms.Label
    Friend WithEvents lblBiosDate As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pctOSLogo As System.Windows.Forms.PictureBox
    Friend WithEvents pctBiosMake As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblBiosVersion As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblSysVersion As System.Windows.Forms.Label
    Friend WithEvents lblSysVendor As System.Windows.Forms.Label
    Friend WithEvents lblSysName As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents pctOEMBitmap As System.Windows.Forms.PictureBox
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Divider2 As SysInfo.CustomControls.DividerControl
    Friend WithEvents Divider1 As SysInfo.CustomControls.DividerControl
    Friend WithEvents Divider3 As SysInfo.CustomControls.DividerControl
    Friend WithEvents Divider4 As SysInfo.CustomControls.DividerControl
    Friend WithEvents lblSysUptime As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
