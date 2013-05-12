<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlOS
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
        Me.TableLayoutOS = New System.Windows.Forms.TableLayoutPanel
        Me.Label53 = New System.Windows.Forms.Label
        Me.Label55 = New System.Windows.Forms.Label
        Me.Label54 = New System.Windows.Forms.Label
        Me.lblOSSystemDir = New System.Windows.Forms.Label
        Me.lblOSWindowsDir = New System.Windows.Forms.Label
        Me.lblOSBootDevice = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.lblOSInstallationDate = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblOSRegUser = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.lblOSSerialNumber = New System.Windows.Forms.Label
        Me.lblOSEdition = New System.Windows.Forms.Label
        Me.lblOSProductKey = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.lblOSEncryptionLevel = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.lblOSRole = New System.Windows.Forms.Label
        Me.lblOSPlatform = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblOSVersion = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblOSOrganisation = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblOSBuildType = New System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.Divider3 = New SysInfo.CustomControls.DividerControl
        Me.Divider2 = New SysInfo.CustomControls.DividerControl
        Me.Divider1 = New SysInfo.CustomControls.DividerControl
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pctOSLogo = New System.Windows.Forms.PictureBox
        Me.TableLayoutOS.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctOSLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutOS
        '
        Me.TableLayoutOS.AutoSize = True
        Me.TableLayoutOS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutOS.ColumnCount = 2
        Me.TableLayoutOS.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutOS.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutOS.Controls.Add(Me.Label53, 0, 0)
        Me.TableLayoutOS.Controls.Add(Me.Label55, 0, 1)
        Me.TableLayoutOS.Controls.Add(Me.Label54, 0, 2)
        Me.TableLayoutOS.Controls.Add(Me.lblOSSystemDir, 1, 0)
        Me.TableLayoutOS.Controls.Add(Me.lblOSWindowsDir, 1, 1)
        Me.TableLayoutOS.Controls.Add(Me.lblOSBootDevice, 1, 2)
        Me.TableLayoutOS.Controls.Add(Me.Label16, 0, 3)
        Me.TableLayoutOS.Controls.Add(Me.lblOSInstallationDate, 1, 3)
        Me.TableLayoutOS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutOS.Location = New System.Drawing.Point(49, 271)
        Me.TableLayoutOS.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutOS.Name = "TableLayoutOS"
        Me.TableLayoutOS.RowCount = 4
        Me.TableLayoutOS.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutOS.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutOS.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutOS.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutOS.Size = New System.Drawing.Size(161, 88)
        Me.TableLayoutOS.TabIndex = 54
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label53.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.Black
        Me.Label53.Location = New System.Drawing.Point(4, 4)
        Me.Label53.Margin = New System.Windows.Forms.Padding(4)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(122, 14)
        Me.Label53.TabIndex = 48
        Me.Label53.Text = "System Directory:"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label55.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.Color.Black
        Me.Label55.Location = New System.Drawing.Point(4, 26)
        Me.Label55.Margin = New System.Windows.Forms.Padding(4)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(122, 14)
        Me.Label55.TabIndex = 50
        Me.Label55.Text = "Windows Directory:"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label54.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.Black
        Me.Label54.Location = New System.Drawing.Point(4, 48)
        Me.Label54.Margin = New System.Windows.Forms.Padding(4)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(122, 14)
        Me.Label54.TabIndex = 52
        Me.Label54.Text = "Boot Device:"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOSSystemDir
        '
        Me.lblOSSystemDir.AutoEllipsis = True
        Me.lblOSSystemDir.AutoSize = True
        Me.lblOSSystemDir.BackColor = System.Drawing.Color.Transparent
        Me.lblOSSystemDir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOSSystemDir.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOSSystemDir.ForeColor = System.Drawing.Color.Navy
        Me.lblOSSystemDir.Location = New System.Drawing.Point(134, 4)
        Me.lblOSSystemDir.Margin = New System.Windows.Forms.Padding(4)
        Me.lblOSSystemDir.Name = "lblOSSystemDir"
        Me.lblOSSystemDir.Size = New System.Drawing.Size(23, 14)
        Me.lblOSSystemDir.TabIndex = 49
        Me.lblOSSystemDir.Text = "    "
        Me.lblOSSystemDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOSWindowsDir
        '
        Me.lblOSWindowsDir.AutoEllipsis = True
        Me.lblOSWindowsDir.AutoSize = True
        Me.lblOSWindowsDir.BackColor = System.Drawing.Color.Transparent
        Me.lblOSWindowsDir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOSWindowsDir.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOSWindowsDir.ForeColor = System.Drawing.Color.Navy
        Me.lblOSWindowsDir.Location = New System.Drawing.Point(134, 26)
        Me.lblOSWindowsDir.Margin = New System.Windows.Forms.Padding(4)
        Me.lblOSWindowsDir.Name = "lblOSWindowsDir"
        Me.lblOSWindowsDir.Size = New System.Drawing.Size(23, 14)
        Me.lblOSWindowsDir.TabIndex = 51
        Me.lblOSWindowsDir.Text = "    "
        Me.lblOSWindowsDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOSBootDevice
        '
        Me.lblOSBootDevice.AutoEllipsis = True
        Me.lblOSBootDevice.AutoSize = True
        Me.lblOSBootDevice.BackColor = System.Drawing.Color.Transparent
        Me.lblOSBootDevice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOSBootDevice.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOSBootDevice.ForeColor = System.Drawing.Color.Navy
        Me.lblOSBootDevice.Location = New System.Drawing.Point(134, 48)
        Me.lblOSBootDevice.Margin = New System.Windows.Forms.Padding(4)
        Me.lblOSBootDevice.Name = "lblOSBootDevice"
        Me.lblOSBootDevice.Size = New System.Drawing.Size(23, 14)
        Me.lblOSBootDevice.TabIndex = 53
        Me.lblOSBootDevice.Text = "    "
        Me.lblOSBootDevice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(4, 70)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(122, 14)
        Me.Label16.TabIndex = 39
        Me.Label16.Text = "Installed:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOSInstallationDate
        '
        Me.lblOSInstallationDate.AutoEllipsis = True
        Me.lblOSInstallationDate.AutoSize = True
        Me.lblOSInstallationDate.BackColor = System.Drawing.Color.Transparent
        Me.lblOSInstallationDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOSInstallationDate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOSInstallationDate.ForeColor = System.Drawing.Color.Navy
        Me.lblOSInstallationDate.Location = New System.Drawing.Point(134, 70)
        Me.lblOSInstallationDate.Margin = New System.Windows.Forms.Padding(4)
        Me.lblOSInstallationDate.Name = "lblOSInstallationDate"
        Me.lblOSInstallationDate.Size = New System.Drawing.Size(23, 14)
        Me.lblOSInstallationDate.TabIndex = 38
        Me.lblOSInstallationDate.Text = "    "
        Me.lblOSInstallationDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 14)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Windows Edition:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOSRegUser
        '
        Me.lblOSRegUser.AutoSize = True
        Me.lblOSRegUser.BackColor = System.Drawing.Color.Transparent
        Me.lblOSRegUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOSRegUser.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOSRegUser.ForeColor = System.Drawing.Color.Navy
        Me.lblOSRegUser.Location = New System.Drawing.Point(134, 4)
        Me.lblOSRegUser.Margin = New System.Windows.Forms.Padding(4)
        Me.lblOSRegUser.Name = "lblOSRegUser"
        Me.lblOSRegUser.Size = New System.Drawing.Size(23, 14)
        Me.lblOSRegUser.TabIndex = 43
        Me.lblOSRegUser.Text = "    "
        Me.lblOSRegUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label32.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(4, 26)
        Me.Label32.Margin = New System.Windows.Forms.Padding(4)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(122, 14)
        Me.Label32.TabIndex = 45
        Me.Label32.Text = "Organisation:"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOSSerialNumber
        '
        Me.lblOSSerialNumber.AutoSize = True
        Me.lblOSSerialNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblOSSerialNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOSSerialNumber.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOSSerialNumber.ForeColor = System.Drawing.Color.Navy
        Me.lblOSSerialNumber.Location = New System.Drawing.Point(134, 70)
        Me.lblOSSerialNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.lblOSSerialNumber.Name = "lblOSSerialNumber"
        Me.lblOSSerialNumber.Size = New System.Drawing.Size(23, 14)
        Me.lblOSSerialNumber.TabIndex = 31
        Me.lblOSSerialNumber.Text = "    "
        Me.lblOSSerialNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOSEdition
        '
        Me.lblOSEdition.AutoEllipsis = True
        Me.lblOSEdition.AutoSize = True
        Me.lblOSEdition.BackColor = System.Drawing.Color.Transparent
        Me.lblOSEdition.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOSEdition.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOSEdition.ForeColor = System.Drawing.Color.Navy
        Me.lblOSEdition.Location = New System.Drawing.Point(134, 4)
        Me.lblOSEdition.Margin = New System.Windows.Forms.Padding(4)
        Me.lblOSEdition.Name = "lblOSEdition"
        Me.lblOSEdition.Size = New System.Drawing.Size(23, 14)
        Me.lblOSEdition.TabIndex = 29
        Me.lblOSEdition.Text = "    "
        Me.lblOSEdition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOSProductKey
        '
        Me.lblOSProductKey.AutoSize = True
        Me.lblOSProductKey.BackColor = System.Drawing.Color.Transparent
        Me.lblOSProductKey.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOSProductKey.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOSProductKey.ForeColor = System.Drawing.Color.Navy
        Me.lblOSProductKey.Location = New System.Drawing.Point(134, 48)
        Me.lblOSProductKey.Margin = New System.Windows.Forms.Padding(4)
        Me.lblOSProductKey.Name = "lblOSProductKey"
        Me.lblOSProductKey.Size = New System.Drawing.Size(23, 14)
        Me.lblOSProductKey.TabIndex = 32
        Me.lblOSProductKey.Text = "    "
        Me.lblOSProductKey.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(4, 26)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(122, 14)
        Me.Label17.TabIndex = 34
        Me.Label17.Text = "Version:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOSEncryptionLevel
        '
        Me.lblOSEncryptionLevel.AutoEllipsis = True
        Me.lblOSEncryptionLevel.AutoSize = True
        Me.lblOSEncryptionLevel.BackColor = System.Drawing.Color.Transparent
        Me.lblOSEncryptionLevel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOSEncryptionLevel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOSEncryptionLevel.ForeColor = System.Drawing.Color.Navy
        Me.lblOSEncryptionLevel.Location = New System.Drawing.Point(134, 114)
        Me.lblOSEncryptionLevel.Margin = New System.Windows.Forms.Padding(4)
        Me.lblOSEncryptionLevel.Name = "lblOSEncryptionLevel"
        Me.lblOSEncryptionLevel.Size = New System.Drawing.Size(23, 14)
        Me.lblOSEncryptionLevel.TabIndex = 47
        Me.lblOSEncryptionLevel.Text = "    "
        Me.lblOSEncryptionLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(4, 48)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(122, 14)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "Platform:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOSRole
        '
        Me.lblOSRole.AutoEllipsis = True
        Me.lblOSRole.AutoSize = True
        Me.lblOSRole.BackColor = System.Drawing.Color.Transparent
        Me.lblOSRole.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOSRole.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOSRole.ForeColor = System.Drawing.Color.Navy
        Me.lblOSRole.Location = New System.Drawing.Point(134, 92)
        Me.lblOSRole.Margin = New System.Windows.Forms.Padding(4)
        Me.lblOSRole.Name = "lblOSRole"
        Me.lblOSRole.Size = New System.Drawing.Size(23, 14)
        Me.lblOSRole.TabIndex = 41
        Me.lblOSRole.Text = "    "
        Me.lblOSRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOSPlatform
        '
        Me.lblOSPlatform.AutoEllipsis = True
        Me.lblOSPlatform.AutoSize = True
        Me.lblOSPlatform.BackColor = System.Drawing.Color.Transparent
        Me.lblOSPlatform.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOSPlatform.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOSPlatform.ForeColor = System.Drawing.Color.Navy
        Me.lblOSPlatform.Location = New System.Drawing.Point(134, 48)
        Me.lblOSPlatform.Margin = New System.Windows.Forms.Padding(4)
        Me.lblOSPlatform.Name = "lblOSPlatform"
        Me.lblOSPlatform.Size = New System.Drawing.Size(23, 14)
        Me.lblOSPlatform.TabIndex = 36
        Me.lblOSPlatform.Text = "    "
        Me.lblOSPlatform.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(4, 92)
        Me.Label29.Margin = New System.Windows.Forms.Padding(4)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(122, 14)
        Me.Label29.TabIndex = 40
        Me.Label29.Text = "Role:"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(4, 4)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(122, 14)
        Me.Label30.TabIndex = 42
        Me.Label30.Text = "Registered User:"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(4, 70)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 14)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Serial Number:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOSVersion
        '
        Me.lblOSVersion.AutoEllipsis = True
        Me.lblOSVersion.AutoSize = True
        Me.lblOSVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblOSVersion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOSVersion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOSVersion.ForeColor = System.Drawing.Color.Navy
        Me.lblOSVersion.Location = New System.Drawing.Point(134, 26)
        Me.lblOSVersion.Margin = New System.Windows.Forms.Padding(4)
        Me.lblOSVersion.Name = "lblOSVersion"
        Me.lblOSVersion.Size = New System.Drawing.Size(23, 14)
        Me.lblOSVersion.TabIndex = 35
        Me.lblOSVersion.Text = "    "
        Me.lblOSVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label31.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(4, 114)
        Me.Label31.Margin = New System.Windows.Forms.Padding(4)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(122, 14)
        Me.Label31.TabIndex = 46
        Me.Label31.Text = "Encryption Level:"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(4, 48)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 14)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Product Key:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOSOrganisation
        '
        Me.lblOSOrganisation.AutoSize = True
        Me.lblOSOrganisation.BackColor = System.Drawing.Color.Transparent
        Me.lblOSOrganisation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOSOrganisation.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOSOrganisation.ForeColor = System.Drawing.Color.Navy
        Me.lblOSOrganisation.Location = New System.Drawing.Point(134, 26)
        Me.lblOSOrganisation.Margin = New System.Windows.Forms.Padding(4)
        Me.lblOSOrganisation.Name = "lblOSOrganisation"
        Me.lblOSOrganisation.Size = New System.Drawing.Size(23, 14)
        Me.lblOSOrganisation.TabIndex = 44
        Me.lblOSOrganisation.Text = "    "
        Me.lblOSOrganisation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(10, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(343, 19)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "View information about your Operating System"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(4, 70)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 14)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Build Type:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOSBuildType
        '
        Me.lblOSBuildType.AutoEllipsis = True
        Me.lblOSBuildType.AutoSize = True
        Me.lblOSBuildType.BackColor = System.Drawing.Color.Transparent
        Me.lblOSBuildType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOSBuildType.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOSBuildType.ForeColor = System.Drawing.Color.Navy
        Me.lblOSBuildType.Location = New System.Drawing.Point(134, 70)
        Me.lblOSBuildType.Margin = New System.Windows.Forms.Padding(4)
        Me.lblOSBuildType.Name = "lblOSBuildType"
        Me.lblOSBuildType.Size = New System.Drawing.Size(23, 14)
        Me.lblOSBuildType.TabIndex = 55
        Me.lblOSBuildType.Text = "    "
        Me.lblOSBuildType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel1.Controls.Add(Me.lblOSBuildType, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblOSEncryptionLevel, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblOSEdition, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label17, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblOSVersion, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label15, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label31, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lblOSPlatform, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label29, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblOSRole, 1, 4)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(49, 90)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(161, 132)
        Me.TableLayoutPanel1.TabIndex = 59
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lblOSSerialNumber, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lblOSOrganisation, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label32, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblOSRegUser, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lblOSProductKey, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label30, 0, 0)
        Me.TableLayoutPanel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(49, 438)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(161, 88)
        Me.TableLayoutPanel2.TabIndex = 62
        '
        'Divider3
        '
        Me.Divider3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Divider3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Divider3.Location = New System.Drawing.Point(10, 409)
        Me.Divider3.Name = "Divider3"
        Me.Divider3.Size = New System.Drawing.Size(760, 23)
        Me.Divider3.TabIndex = 67
        Me.Divider3.Text = "Registered User"
        '
        'Divider2
        '
        Me.Divider2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Divider2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Divider2.Location = New System.Drawing.Point(10, 245)
        Me.Divider2.Name = "Divider2"
        Me.Divider2.Size = New System.Drawing.Size(760, 23)
        Me.Divider2.TabIndex = 66
        Me.Divider2.Text = "Installation"
        '
        'Divider1
        '
        Me.Divider1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Divider1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Divider1.Location = New System.Drawing.Point(10, 61)
        Me.Divider1.Name = "Divider1"
        Me.Divider1.Size = New System.Drawing.Size(760, 23)
        Me.Divider1.TabIndex = 65
        Me.Divider1.Text = "Operating System"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.SysInfo.My.Resources.Resources.Registered_User
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(658, 438)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(112, 112)
        Me.PictureBox2.TabIndex = 64
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.SysInfo.My.Resources.Resources.install
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(658, 271)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 112)
        Me.PictureBox1.TabIndex = 63
        Me.PictureBox1.TabStop = False
        '
        'pctOSLogo
        '
        Me.pctOSLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pctOSLogo.Location = New System.Drawing.Point(658, 90)
        Me.pctOSLogo.Name = "pctOSLogo"
        Me.pctOSLogo.Size = New System.Drawing.Size(112, 112)
        Me.pctOSLogo.TabIndex = 28
        Me.pctOSLogo.TabStop = False
        '
        'UserControlOS
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Divider3)
        Me.Controls.Add(Me.Divider2)
        Me.Controls.Add(Me.Divider1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutOS)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pctOSLogo)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "UserControlOS"
        Me.Size = New System.Drawing.Size(793, 668)
        Me.TableLayoutOS.ResumeLayout(False)
        Me.TableLayoutOS.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctOSLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pctOSLogo As System.Windows.Forms.PictureBox
    Friend WithEvents TableLayoutOS As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblOSBootDevice As System.Windows.Forms.Label
    Friend WithEvents lblOSRegUser As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents lblOSSerialNumber As System.Windows.Forms.Label
    Friend WithEvents lblOSInstallationDate As System.Windows.Forms.Label
    Friend WithEvents lblOSEdition As System.Windows.Forms.Label
    Friend WithEvents lblOSProductKey As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents lblOSWindowsDir As System.Windows.Forms.Label
    Friend WithEvents lblOSEncryptionLevel As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblOSRole As System.Windows.Forms.Label
    Friend WithEvents lblOSSystemDir As System.Windows.Forms.Label
    Friend WithEvents lblOSPlatform As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents lblOSVersion As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblOSOrganisation As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblOSBuildType As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Divider1 As SysInfo.CustomControls.DividerControl
    Friend WithEvents Divider2 As SysInfo.CustomControls.DividerControl
    Friend WithEvents Divider3 As SysInfo.CustomControls.DividerControl

End Class
