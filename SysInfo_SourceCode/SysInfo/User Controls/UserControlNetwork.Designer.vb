<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlNetwork
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
        Me.components = New System.ComponentModel.Container
        Me.btnGetNetworkedPCs = New System.Windows.Forms.Button
        Me.lstNetworkedPCs = New System.Windows.Forms.ListView
        Me.HostName = New System.Windows.Forms.ColumnHeader
        Me.IPAddress = New System.Windows.Forms.ColumnHeader
        Me.NetworkPath = New System.Windows.Forms.ColumnHeader
        Me.Time = New System.Windows.Forms.ColumnHeader
        Me.lblGettingList = New System.Windows.Forms.Label
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.lblMACAddress = New System.Windows.Forms.Label
        Me.MAC = New System.Windows.Forms.Label
        Me.Adaptor = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblAdaptorType = New System.Windows.Forms.Label
        Me.lblIPAddress = New System.Windows.Forms.Label
        Me.IPadd = New System.Windows.Forms.Label
        Me.Subnet = New System.Windows.Forms.Label
        Me.lblIPSubnet = New System.Windows.Forms.Label
        Me.Gateway = New System.Windows.Forms.Label
        Me.lblGateway = New System.Windows.Forms.Label
        Me.DNS = New System.Windows.Forms.Label
        Me.lblDNSServer = New System.Windows.Forms.Label
        Me.DHCP = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblDHCPServer = New System.Windows.Forms.Label
        Me.lblDHCPEnabled = New System.Windows.Forms.Label
        Me.lblDHCPObtained = New System.Windows.Forms.Label
        Me.lblDHCPExpires = New System.Windows.Forms.Label
        Me.Domain = New System.Windows.Forms.Label
        Me.lblDomain = New System.Windows.Forms.Label
        Me.Host = New System.Windows.Forms.Label
        Me.lblHostName = New System.Windows.Forms.Label
        Me.cmbAdaptorList = New System.Windows.Forms.ComboBox
        Me.ToolTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.PictureBox6 = New System.Windows.Forms.PictureBox
        Me.Divider2 = New SysInfo.CustomControls.DividerControl
        Me.Divider1 = New SysInfo.CustomControls.DividerControl
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGetNetworkedPCs
        '
        Me.btnGetNetworkedPCs.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnGetNetworkedPCs.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnGetNetworkedPCs.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetNetworkedPCs.ForeColor = System.Drawing.Color.Black
        Me.btnGetNetworkedPCs.Location = New System.Drawing.Point(49, 629)
        Me.btnGetNetworkedPCs.Name = "btnGetNetworkedPCs"
        Me.btnGetNetworkedPCs.Size = New System.Drawing.Size(142, 27)
        Me.btnGetNetworkedPCs.TabIndex = 95
        Me.btnGetNetworkedPCs.Text = "Get Remote Computers"
        Me.btnGetNetworkedPCs.UseVisualStyleBackColor = False
        '
        'lstNetworkedPCs
        '
        Me.lstNetworkedPCs.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
        Me.lstNetworkedPCs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstNetworkedPCs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.HostName, Me.IPAddress, Me.NetworkPath, Me.Time})
        Me.lstNetworkedPCs.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstNetworkedPCs.GridLines = True
        Me.lstNetworkedPCs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstNetworkedPCs.Location = New System.Drawing.Point(49, 460)
        Me.lstNetworkedPCs.MultiSelect = False
        Me.lstNetworkedPCs.Name = "lstNetworkedPCs"
        Me.lstNetworkedPCs.ShowGroups = False
        Me.lstNetworkedPCs.ShowItemToolTips = True
        Me.lstNetworkedPCs.Size = New System.Drawing.Size(690, 150)
        Me.lstNetworkedPCs.TabIndex = 94
        Me.lstNetworkedPCs.UseCompatibleStateImageBehavior = False
        Me.lstNetworkedPCs.View = System.Windows.Forms.View.Details
        '
        'HostName
        '
        Me.HostName.Text = "Host Name"
        Me.HostName.Width = 150
        '
        'IPAddress
        '
        Me.IPAddress.Text = "IP Address"
        Me.IPAddress.Width = 120
        '
        'NetworkPath
        '
        Me.NetworkPath.Text = "Network Path"
        Me.NetworkPath.Width = 250
        '
        'Time
        '
        Me.Time.Text = "Round Trip Time (MS)"
        Me.Time.Width = 150
        '
        'lblGettingList
        '
        Me.lblGettingList.AutoSize = True
        Me.lblGettingList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGettingList.ForeColor = System.Drawing.Color.Black
        Me.lblGettingList.Location = New System.Drawing.Point(210, 639)
        Me.lblGettingList.Name = "lblGettingList"
        Me.lblGettingList.Size = New System.Drawing.Size(0, 16)
        Me.lblGettingList.TabIndex = 96
        Me.lblGettingList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel2.Controls.Add(Me.lblMACAddress, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.MAC, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Adaptor, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lblAdaptorType, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lblIPAddress, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.IPadd, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Subnet, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.lblIPSubnet, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Gateway, 0, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.lblGateway, 1, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.DNS, 0, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.lblDNSServer, 1, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.DHCP, 0, 10)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 0, 11)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 12)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 13)
        Me.TableLayoutPanel2.Controls.Add(Me.lblDHCPServer, 1, 10)
        Me.TableLayoutPanel2.Controls.Add(Me.lblDHCPEnabled, 1, 11)
        Me.TableLayoutPanel2.Controls.Add(Me.lblDHCPObtained, 1, 12)
        Me.TableLayoutPanel2.Controls.Add(Me.lblDHCPExpires, 1, 13)
        Me.TableLayoutPanel2.Controls.Add(Me.Domain, 0, 15)
        Me.TableLayoutPanel2.Controls.Add(Me.lblDomain, 1, 15)
        Me.TableLayoutPanel2.Controls.Add(Me.Host, 0, 16)
        Me.TableLayoutPanel2.Controls.Add(Me.lblHostName, 1, 16)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbAdaptorList, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(49, 90)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 17
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(494, 320)
        Me.TableLayoutPanel2.TabIndex = 97
        '
        'lblMACAddress
        '
        Me.lblMACAddress.AutoEllipsis = True
        Me.lblMACAddress.AutoSize = True
        Me.lblMACAddress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMACAddress.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMACAddress.ForeColor = System.Drawing.Color.Navy
        Me.lblMACAddress.Location = New System.Drawing.Point(142, 32)
        Me.lblMACAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.lblMACAddress.Name = "lblMACAddress"
        Me.lblMACAddress.Size = New System.Drawing.Size(348, 14)
        Me.lblMACAddress.TabIndex = 83
        Me.lblMACAddress.Text = "    "
        Me.lblMACAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MAC
        '
        Me.MAC.AutoSize = True
        Me.MAC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MAC.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MAC.ForeColor = System.Drawing.Color.Black
        Me.MAC.Location = New System.Drawing.Point(4, 32)
        Me.MAC.Margin = New System.Windows.Forms.Padding(4)
        Me.MAC.Name = "MAC"
        Me.MAC.Size = New System.Drawing.Size(130, 14)
        Me.MAC.TabIndex = 82
        Me.MAC.Text = "MAC Address:"
        Me.MAC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Adaptor
        '
        Me.Adaptor.AutoSize = True
        Me.Adaptor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Adaptor.ForeColor = System.Drawing.Color.Black
        Me.Adaptor.Location = New System.Drawing.Point(4, 4)
        Me.Adaptor.Margin = New System.Windows.Forms.Padding(4)
        Me.Adaptor.Name = "Adaptor"
        Me.Adaptor.Size = New System.Drawing.Size(55, 14)
        Me.Adaptor.TabIndex = 87
        Me.Adaptor.Text = "Adaptor:"
        Me.Adaptor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(4, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 14)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "Connection Type:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAdaptorType
        '
        Me.lblAdaptorType.AutoEllipsis = True
        Me.lblAdaptorType.AutoSize = True
        Me.lblAdaptorType.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdaptorType.ForeColor = System.Drawing.Color.Navy
        Me.lblAdaptorType.Location = New System.Drawing.Point(142, 54)
        Me.lblAdaptorType.Margin = New System.Windows.Forms.Padding(4)
        Me.lblAdaptorType.Name = "lblAdaptorType"
        Me.lblAdaptorType.Size = New System.Drawing.Size(23, 14)
        Me.lblAdaptorType.TabIndex = 100
        Me.lblAdaptorType.Text = "    "
        Me.lblAdaptorType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIPAddress
        '
        Me.lblIPAddress.AutoEllipsis = True
        Me.lblIPAddress.AutoSize = True
        Me.lblIPAddress.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIPAddress.ForeColor = System.Drawing.Color.Navy
        Me.lblIPAddress.Location = New System.Drawing.Point(142, 84)
        Me.lblIPAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.lblIPAddress.Name = "lblIPAddress"
        Me.lblIPAddress.Size = New System.Drawing.Size(23, 14)
        Me.lblIPAddress.TabIndex = 79
        Me.lblIPAddress.Text = "    "
        Me.lblIPAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IPadd
        '
        Me.IPadd.AutoSize = True
        Me.IPadd.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IPadd.ForeColor = System.Drawing.Color.Black
        Me.IPadd.Location = New System.Drawing.Point(4, 84)
        Me.IPadd.Margin = New System.Windows.Forms.Padding(4)
        Me.IPadd.Name = "IPadd"
        Me.IPadd.Size = New System.Drawing.Size(69, 14)
        Me.IPadd.TabIndex = 89
        Me.IPadd.Text = "IP Address:"
        Me.IPadd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Subnet
        '
        Me.Subnet.AutoSize = True
        Me.Subnet.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subnet.ForeColor = System.Drawing.Color.Black
        Me.Subnet.Location = New System.Drawing.Point(4, 106)
        Me.Subnet.Margin = New System.Windows.Forms.Padding(4)
        Me.Subnet.Name = "Subnet"
        Me.Subnet.Size = New System.Drawing.Size(81, 14)
        Me.Subnet.TabIndex = 98
        Me.Subnet.Text = "Subnet Mask:"
        Me.Subnet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIPSubnet
        '
        Me.lblIPSubnet.AutoEllipsis = True
        Me.lblIPSubnet.AutoSize = True
        Me.lblIPSubnet.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIPSubnet.ForeColor = System.Drawing.Color.Navy
        Me.lblIPSubnet.Location = New System.Drawing.Point(142, 106)
        Me.lblIPSubnet.Margin = New System.Windows.Forms.Padding(4)
        Me.lblIPSubnet.Name = "lblIPSubnet"
        Me.lblIPSubnet.Size = New System.Drawing.Size(23, 14)
        Me.lblIPSubnet.TabIndex = 77
        Me.lblIPSubnet.Text = "    "
        Me.lblIPSubnet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Gateway
        '
        Me.Gateway.AutoSize = True
        Me.Gateway.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gateway.ForeColor = System.Drawing.Color.Black
        Me.Gateway.Location = New System.Drawing.Point(4, 136)
        Me.Gateway.Margin = New System.Windows.Forms.Padding(4)
        Me.Gateway.Name = "Gateway"
        Me.Gateway.Size = New System.Drawing.Size(102, 14)
        Me.Gateway.TabIndex = 98
        Me.Gateway.Text = "Default Gateway:"
        Me.Gateway.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGateway
        '
        Me.lblGateway.AutoEllipsis = True
        Me.lblGateway.AutoSize = True
        Me.lblGateway.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGateway.ForeColor = System.Drawing.Color.Navy
        Me.lblGateway.Location = New System.Drawing.Point(142, 136)
        Me.lblGateway.Margin = New System.Windows.Forms.Padding(4)
        Me.lblGateway.Name = "lblGateway"
        Me.lblGateway.Size = New System.Drawing.Size(23, 14)
        Me.lblGateway.TabIndex = 81
        Me.lblGateway.Text = "    "
        Me.lblGateway.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DNS
        '
        Me.DNS.AutoSize = True
        Me.DNS.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DNS.ForeColor = System.Drawing.Color.Black
        Me.DNS.Location = New System.Drawing.Point(4, 158)
        Me.DNS.Margin = New System.Windows.Forms.Padding(4)
        Me.DNS.Name = "DNS"
        Me.DNS.Size = New System.Drawing.Size(88, 14)
        Me.DNS.TabIndex = 94
        Me.DNS.Text = "DNS Server(s):"
        Me.DNS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDNSServer
        '
        Me.lblDNSServer.AutoSize = True
        Me.lblDNSServer.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDNSServer.ForeColor = System.Drawing.Color.Navy
        Me.lblDNSServer.Location = New System.Drawing.Point(142, 158)
        Me.lblDNSServer.Margin = New System.Windows.Forms.Padding(4)
        Me.lblDNSServer.Name = "lblDNSServer"
        Me.lblDNSServer.Size = New System.Drawing.Size(23, 14)
        Me.lblDNSServer.TabIndex = 94
        Me.lblDNSServer.Text = "    "
        Me.lblDNSServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DHCP
        '
        Me.DHCP.AutoSize = True
        Me.DHCP.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DHCP.ForeColor = System.Drawing.Color.Black
        Me.DHCP.Location = New System.Drawing.Point(4, 188)
        Me.DHCP.Margin = New System.Windows.Forms.Padding(4)
        Me.DHCP.Name = "DHCP"
        Me.DHCP.Size = New System.Drawing.Size(80, 14)
        Me.DHCP.TabIndex = 88
        Me.DHCP.Text = "DHCP Server:"
        Me.DHCP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(4, 210)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 14)
        Me.Label7.TabIndex = 105
        Me.Label7.Text = "DHCP Enabled:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(4, 232)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 14)
        Me.Label4.TabIndex = 102
        Me.Label4.Text = "DHCP Lease Obtained:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(4, 254)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 14)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "DHCP Lease Expires:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDHCPServer
        '
        Me.lblDHCPServer.AutoEllipsis = True
        Me.lblDHCPServer.AutoSize = True
        Me.lblDHCPServer.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDHCPServer.ForeColor = System.Drawing.Color.Navy
        Me.lblDHCPServer.Location = New System.Drawing.Point(142, 188)
        Me.lblDHCPServer.Margin = New System.Windows.Forms.Padding(4)
        Me.lblDHCPServer.Name = "lblDHCPServer"
        Me.lblDHCPServer.Size = New System.Drawing.Size(23, 14)
        Me.lblDHCPServer.TabIndex = 89
        Me.lblDHCPServer.Text = "    "
        Me.lblDHCPServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDHCPEnabled
        '
        Me.lblDHCPEnabled.AutoEllipsis = True
        Me.lblDHCPEnabled.AutoSize = True
        Me.lblDHCPEnabled.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDHCPEnabled.ForeColor = System.Drawing.Color.Navy
        Me.lblDHCPEnabled.Location = New System.Drawing.Point(142, 210)
        Me.lblDHCPEnabled.Margin = New System.Windows.Forms.Padding(4)
        Me.lblDHCPEnabled.Name = "lblDHCPEnabled"
        Me.lblDHCPEnabled.Size = New System.Drawing.Size(23, 14)
        Me.lblDHCPEnabled.TabIndex = 106
        Me.lblDHCPEnabled.Text = "    "
        Me.lblDHCPEnabled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDHCPObtained
        '
        Me.lblDHCPObtained.AutoEllipsis = True
        Me.lblDHCPObtained.AutoSize = True
        Me.lblDHCPObtained.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDHCPObtained.ForeColor = System.Drawing.Color.Navy
        Me.lblDHCPObtained.Location = New System.Drawing.Point(142, 232)
        Me.lblDHCPObtained.Margin = New System.Windows.Forms.Padding(4)
        Me.lblDHCPObtained.Name = "lblDHCPObtained"
        Me.lblDHCPObtained.Size = New System.Drawing.Size(23, 14)
        Me.lblDHCPObtained.TabIndex = 105
        Me.lblDHCPObtained.Text = "    "
        Me.lblDHCPObtained.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDHCPExpires
        '
        Me.lblDHCPExpires.AutoEllipsis = True
        Me.lblDHCPExpires.AutoSize = True
        Me.lblDHCPExpires.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDHCPExpires.ForeColor = System.Drawing.Color.Navy
        Me.lblDHCPExpires.Location = New System.Drawing.Point(142, 254)
        Me.lblDHCPExpires.Margin = New System.Windows.Forms.Padding(4)
        Me.lblDHCPExpires.Name = "lblDHCPExpires"
        Me.lblDHCPExpires.Size = New System.Drawing.Size(23, 14)
        Me.lblDHCPExpires.TabIndex = 105
        Me.lblDHCPExpires.Text = "    "
        Me.lblDHCPExpires.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Domain
        '
        Me.Domain.AutoSize = True
        Me.Domain.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Domain.ForeColor = System.Drawing.Color.Black
        Me.Domain.Location = New System.Drawing.Point(4, 284)
        Me.Domain.Margin = New System.Windows.Forms.Padding(4)
        Me.Domain.Name = "Domain"
        Me.Domain.Size = New System.Drawing.Size(51, 12)
        Me.Domain.TabIndex = 91
        Me.Domain.Text = "Domain:"
        Me.Domain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDomain
        '
        Me.lblDomain.AutoEllipsis = True
        Me.lblDomain.AutoSize = True
        Me.lblDomain.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDomain.ForeColor = System.Drawing.Color.Navy
        Me.lblDomain.Location = New System.Drawing.Point(142, 284)
        Me.lblDomain.Margin = New System.Windows.Forms.Padding(4)
        Me.lblDomain.Name = "lblDomain"
        Me.lblDomain.Size = New System.Drawing.Size(23, 12)
        Me.lblDomain.TabIndex = 92
        Me.lblDomain.Text = "    "
        Me.lblDomain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Host
        '
        Me.Host.AutoSize = True
        Me.Host.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Host.ForeColor = System.Drawing.Color.Black
        Me.Host.Location = New System.Drawing.Point(4, 304)
        Me.Host.Margin = New System.Windows.Forms.Padding(4)
        Me.Host.Name = "Host"
        Me.Host.Size = New System.Drawing.Size(71, 12)
        Me.Host.TabIndex = 84
        Me.Host.Text = "Host Name:"
        Me.Host.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHostName
        '
        Me.lblHostName.AutoSize = True
        Me.lblHostName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHostName.ForeColor = System.Drawing.Color.Navy
        Me.lblHostName.Location = New System.Drawing.Point(142, 304)
        Me.lblHostName.Margin = New System.Windows.Forms.Padding(4)
        Me.lblHostName.Name = "lblHostName"
        Me.lblHostName.Size = New System.Drawing.Size(23, 12)
        Me.lblHostName.TabIndex = 85
        Me.lblHostName.Text = "    "
        Me.lblHostName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbAdaptorList
        '
        Me.cmbAdaptorList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbAdaptorList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAdaptorList.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbAdaptorList.FormattingEnabled = True
        Me.cmbAdaptorList.Location = New System.Drawing.Point(141, 3)
        Me.cmbAdaptorList.Name = "cmbAdaptorList"
        Me.cmbAdaptorList.Size = New System.Drawing.Size(350, 22)
        Me.cmbAdaptorList.TabIndex = 107
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(10, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(276, 19)
        Me.Label3.TabIndex = 102
        Me.Label3.Text = "View information about your Network"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.White
        Me.PictureBox6.BackgroundImage = Global.SysInfo.My.Resources.Resources.Network
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox6.Location = New System.Drawing.Point(611, 87)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox6.TabIndex = 100
        Me.PictureBox6.TabStop = False
        '
        'Divider2
        '
        Me.Divider2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Divider2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Divider2.Location = New System.Drawing.Point(14, 431)
        Me.Divider2.Name = "Divider2"
        Me.Divider2.Size = New System.Drawing.Size(760, 23)
        Me.Divider2.TabIndex = 104
        Me.Divider2.Text = "Remote Computers"
        '
        'Divider1
        '
        Me.Divider1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Divider1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Divider1.Location = New System.Drawing.Point(13, 61)
        Me.Divider1.Name = "Divider1"
        Me.Divider1.Size = New System.Drawing.Size(760, 23)
        Me.Divider1.TabIndex = 103
        Me.Divider1.Text = "Local Computer"
        '
        'UserControlNetwork
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Divider2)
        Me.Controls.Add(Me.lblGettingList)
        Me.Controls.Add(Me.lstNetworkedPCs)
        Me.Controls.Add(Me.btnGetNetworkedPCs)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.Divider1)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "UserControlNetwork"
        Me.Size = New System.Drawing.Size(793, 668)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGetNetworkedPCs As System.Windows.Forms.Button
    Friend WithEvents lstNetworkedPCs As System.Windows.Forms.ListView
    Friend WithEvents HostName As System.Windows.Forms.ColumnHeader
    Friend WithEvents IPAddress As System.Windows.Forms.ColumnHeader
    Friend WithEvents NetworkPath As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblGettingList As System.Windows.Forms.Label
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblMACAddress As System.Windows.Forms.Label
    Friend WithEvents MAC As System.Windows.Forms.Label
    Friend WithEvents lblHostName As System.Windows.Forms.Label
    Friend WithEvents Host As System.Windows.Forms.Label
    Friend WithEvents lblDomain As System.Windows.Forms.Label
    Friend WithEvents Domain As System.Windows.Forms.Label
    Friend WithEvents lblDNSServer As System.Windows.Forms.Label
    Friend WithEvents DNS As System.Windows.Forms.Label
    Friend WithEvents Gateway As System.Windows.Forms.Label
    Friend WithEvents lblIPSubnet As System.Windows.Forms.Label
    Friend WithEvents lblDHCPServer As System.Windows.Forms.Label
    Friend WithEvents DHCP As System.Windows.Forms.Label
    Friend WithEvents Subnet As System.Windows.Forms.Label
    Friend WithEvents lblIPAddress As System.Windows.Forms.Label
    Friend WithEvents Adaptor As System.Windows.Forms.Label
    Friend WithEvents IPadd As System.Windows.Forms.Label
    Friend WithEvents lblGateway As System.Windows.Forms.Label
    Friend WithEvents ToolTips As System.Windows.Forms.ToolTip
    Friend WithEvents Divider1 As SysInfo.CustomControls.DividerControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Divider2 As SysInfo.CustomControls.DividerControl
    Friend WithEvents lblAdaptorType As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblDHCPExpires As System.Windows.Forms.Label
    Friend WithEvents lblDHCPObtained As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblDHCPEnabled As System.Windows.Forms.Label
    Friend WithEvents Time As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmbAdaptorList As System.Windows.Forms.ComboBox

End Class
