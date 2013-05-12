Option Strict On
Option Explicit On

Imports System.DirectoryServices
Imports System.Globalization.CultureInfo
Imports System.Management
Imports System.Net
Imports System.Net.NetworkInformation

Public Class UserControlNetwork

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        GetNetworkInformation()

    End Sub

    Private Structure NicData
        Dim IPAddress As String
        Dim IPSubnet As String
        Dim DefaultGateway As String
        Dim DnsServer As String
        Dim DhcpEnabled As Boolean
        Dim DhcpServer As String
        Dim DnsHostName As String
        Dim MacAddress As String
        Dim AdaptorName As String
        Dim DhcpLeaseObtained As String
        Dim DhcpLeaseExpires As String
        Dim AdaptorType As String
    End Structure

    Dim nicList() As NicData
    Dim nicCount As Integer


    Private Sub GetNetworkInformation()

        ' This routine gets the available nics that are configured 
        ' with a valid IP address and are connected to our network.

        Dim query As ManagementObjectSearcher = New ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = TRUE")
        Dim queryCollection As ManagementObjectCollection = query.Get()

        Dim Win32_NicConfigProperties() As String = {"IPSubnet", "IPAddress", "DNSServerSearchOrder", "DefaultIPGateway", "DHCPServer", "DHCPLeaseObtained", _
                                       "DHCPLeaseExpires", "DHCPEnabled", "DNSHostName", "MACAddress", "Description"}
        Dim propertyIndex As Integer
        Dim IP() As String

        Try
            For Each mo As ManagementObject In queryCollection

                ReDim Preserve nicList(nicCount)

                propertyIndex = 0
                If mo(Win32_NicConfigProperties(propertyIndex)) IsNot Nothing Then
                    IP = CType(mo(Win32_NicConfigProperties(propertyIndex)), String())
                    nicList(nicCount).IPSubnet = IP(0)
                End If

                propertyIndex = 1
                If mo(Win32_NicConfigProperties(propertyIndex)) IsNot Nothing Then
                    IP = CType(mo(Win32_NicConfigProperties(propertyIndex)), String())

                    ' On Windows XP x64, if there are two network adaptors such as Ethernet and Wireless
                    ' and, lets say the wireless adaptor isn't connected to a network, it is still assigned
                    ' an IP address. In this case it's 0.0.0.0. This only seems to occur on XP x64. Anyway,
                    ' we exclude the adaptor from our list.
                    If IP(0) <> "0.0.0.0" Then
                        nicList(nicCount).IPAddress = IP(0)
                    Else
                        Exit For
                    End If
                End If

                propertyIndex = 2
                If mo(Win32_NicConfigProperties(propertyIndex)) IsNot Nothing Then
                    IP = CType(mo(Win32_NicConfigProperties(propertyIndex)), String())
                    nicList(nicCount).DnsServer = IP(0)
                End If

                propertyIndex = 3
                If mo(Win32_NicConfigProperties(propertyIndex)) IsNot Nothing Then
                    IP = CType(mo(Win32_NicConfigProperties(propertyIndex)), String())
                    nicList(nicCount).DefaultGateway = IP(0)
                End If

                propertyIndex = 4
                If mo(Win32_NicConfigProperties(propertyIndex)) IsNot Nothing Then
                    nicList(nicCount).DhcpServer = mo(Win32_NicConfigProperties(propertyIndex)).ToString
                End If

                propertyIndex = 5
                If mo(Win32_NicConfigProperties(propertyIndex)) IsNot Nothing Then
                    nicList(nicCount).DhcpLeaseObtained = mo(Win32_NicConfigProperties(propertyIndex)).ToString
                End If

                propertyIndex = 6
                If mo(Win32_NicConfigProperties(propertyIndex)) IsNot Nothing Then
                    nicList(nicCount).DhcpLeaseExpires = mo(Win32_NicConfigProperties(propertyIndex)).ToString
                End If

                propertyIndex = 7
                If mo(Win32_NicConfigProperties(propertyIndex)) IsNot Nothing Then
                    nicList(nicCount).DhcpEnabled = CBool(mo(Win32_NicConfigProperties(propertyIndex)))
                End If

                propertyIndex = 8
                If mo(Win32_NicConfigProperties(propertyIndex)) IsNot Nothing Then
                    nicList(nicCount).DnsHostName = mo(Win32_NicConfigProperties(propertyIndex)).ToString
                End If

                propertyIndex = 9
                If mo(Win32_NicConfigProperties(propertyIndex)) IsNot Nothing Then
                    nicList(nicCount).MacAddress = mo(Win32_NicConfigProperties(propertyIndex)).ToString
                End If

                propertyIndex = 10
                If mo(Win32_NicConfigProperties(propertyIndex)) IsNot Nothing Then
                    nicList(nicCount).AdaptorName = mo(Win32_NicConfigProperties(propertyIndex)).ToString
                End If

                nicList(nicCount).AdaptorType = GetConnectionType(CInt(mo("Index")))

                cmbAdaptorList.Items.Add(nicList(nicCount).AdaptorName.ToString)
                nicCount += 1

            Next
        Catch ex As ManagementException
            ErrorList.AddErrorToList(ex.Message, "Win32_NetworkAdapterConfiguration", Win32_NicConfigProperties(propertyIndex))
            Exit Sub
        End Try

        cmbAdaptorList.Text = nicList(0).AdaptorName
        cmbAdaptorList.SelectedItem = 0

    End Sub

    Private Shared Function GetConnectionType(ByVal index As Integer) As String

        ' Get the connection type of the connected NIC for our computer.
        Dim query As ManagementObjectSearcher = New ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapter WHERE Index = " & index)
        Dim queryCollection As ManagementObjectCollection = query.Get()
        Dim connectionType As String = notAvailable

        queryCollection = query.Get

        For Each mo As ManagementObject In queryCollection
            connectionType = mo("NetConnectionID").ToString
        Next

        Return connectionType

    End Function

    Private Sub cmbAdaptorList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAdaptorList.SelectedIndexChanged

        ' Have we found any connected network adaptors?
        If nicList(cmbAdaptorList.SelectedIndex).IPAddress IsNot Nothing Then

            lblHostName.Text = nicList(cmbAdaptorList.SelectedIndex).DnsHostName
            lblMACAddress.Text = nicList(cmbAdaptorList.SelectedIndex).MacAddress
            lblAdaptorType.Text = nicList(cmbAdaptorList.SelectedIndex).AdaptorType

            ' Does the NIC get its IP address from a DHCP server?
            If nicList(cmbAdaptorList.SelectedIndex).DhcpEnabled Then

                lblDHCPEnabled.Text = "Yes"

                If nicList(cmbAdaptorList.SelectedIndex).DhcpLeaseObtained IsNot Nothing Then
                    lblDHCPObtained.Text = ManagementDateTimeConverter.ToDateTime(nicList(cmbAdaptorList.SelectedIndex).DhcpLeaseObtained).ToString(CurrentCulture)
                End If

                If nicList(cmbAdaptorList.SelectedIndex).DhcpLeaseExpires IsNot Nothing Then
                    lblDHCPExpires.Text = ManagementDateTimeConverter.ToDateTime(nicList(cmbAdaptorList.SelectedIndex).DhcpLeaseExpires).ToString(CurrentCulture)
                End If

                lblIPAddress.Text = nicList(cmbAdaptorList.SelectedIndex).IPAddress
                lblIPSubnet.Text = nicList(cmbAdaptorList.SelectedIndex).IPSubnet
                lblGateway.Text = nicList(cmbAdaptorList.SelectedIndex).DefaultGateway
                lblDHCPServer.Text = nicList(cmbAdaptorList.SelectedIndex).DhcpServer
            Else
                lblDHCPEnabled.Text = "No"
                lblDHCPObtained.Text = "Not Applicable"
                lblDHCPExpires.Text = "Not Applicable"
                lblDHCPServer.Text = "Not Applicable"
                lblIPAddress.Text = nicList(cmbAdaptorList.SelectedIndex).IPAddress & " (Manually Configured)"
                lblIPSubnet.Text = nicList(cmbAdaptorList.SelectedIndex).IPSubnet & " (Manually Configured)"
                lblGateway.Text = nicList(cmbAdaptorList.SelectedIndex).DefaultGateway & " (Manually Configured)"
            End If

            lblDomain.Text = Wmi.Win32ClassInfo.GetClassProperty("Win32_ComputerSystem", "Domain")
            lblDNSServer.Text = nicList(cmbAdaptorList.SelectedIndex).DnsServer

        Else
            lblIPAddress.Text = "No connected networks found."
            btnGetNetworkedPCs.Enabled = False
        End If

    End Sub

    Private Sub btnGetNetworkedPCs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetNetworkedPCs.Click

        lblGettingList.Text = "Getting list of other networked computers .... Please wait"
        Me.Refresh()
        Me.Cursor = Cursors.WaitCursor

        ' Get a list of other connected computers on our network; ignoring our own computer.
        GetNetworkedComputers(lblHostName.Text)

        lblGettingList.Text = ""
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub GetNetworkedComputers(ByVal Exclude As String)

        ' This sub gets a list of any computers on our subnet.
        ' Because we've already got info on the local computer, 
        ' we exclude it from this list.

        lstNetworkedPCs.Items.Clear()

        Dim rootNode As New DirectoryEntry("WinNT:")
        Dim nodes As DirectoryServices.DirectoryEntries
        Dim found As Boolean = False
        Dim hostName As String
        Dim myPing As New Ping

        ' Get the child nodes from the root node.
        nodes = rootNode.Children
        Try
            For Each node As DirectoryEntry In nodes
                For Each child As DirectoryEntry In node.Children

                    hostName = child.Name

                    ' Exclude schema entries and the local computer.
                    If hostName <> "Schema" AndAlso hostName.ToUpperInvariant <> Exclude.ToUpperInvariant Then

                        Dim lvi As New ListViewItem
                        lvi.Text = hostName

                        found = True

                        ' Alternate background colour of the listview control entries.
                        If lstNetworkedPCs.Items.Count Mod 2 <> 0 Then
                            lvi.BackColor = Color.White
                        Else
                            lvi.BackColor = Color.Ivory
                        End If

                        Dim pingReturn As PingReply = Nothing

                        ' We try pinging the remote computer first. This is because the
                        ' Dns.GetHostEntry throws an exception if the computer exists but
                        ' has a firewall that blocks file & printer sharing or file &
                        ' printer sharing has been turned off or the computer is no longer
                        ' available on the network.

                        ' The Ping will also throw an exception under the same circumstances; 
                        ' however, we catch it here instead of displaying an error message later.

                        Try
                            pingReturn = myPing.Send(hostNameOrAddress:=hostName)
                            If pingReturn.Status = IPStatus.Success Then

                                ' Get the IP Address of the computer found.
                                lvi.SubItems.Add(System.Net.Dns.GetHostEntry(hostName).AddressList(0).ToString)

                                ' Get the network path to the found computer and remove the 'WinNT:' portion.
                                lvi.SubItems.Add(child.Path.Substring(6))
                                lvi.SubItems.Add(pingReturn.RoundtripTime.ToString(InvariantCulture))
                            End If

                            ' Pinging the remote computer failed.
                        Catch ex As PingException
                            lvi.SubItems.Add("Not Found")
                            lvi.SubItems.Add(child.Path.Substring(6))
                            lvi.SubItems.Add("Ping Unsuccessful")
                        End Try

                        lstNetworkedPCs.Items.Add(lvi)
                        lstNetworkedPCs.Refresh()

                    End If
                Next
            Next

            If Not found Then
                MsgBox("No other computers found on this network.", MsgBoxStyle.Information, "Not Found.")
            End If

        Catch ex As Sockets.SocketException
            MsgBox("The following error occurred retrieving the list of networked computers:" & vbNewLine & vbNewLine _
                             & ex.ToString, MsgBoxStyle.Exclamation, "Error Retrieving Network List.")
        End Try
    End Sub

    Public Sub CollectReportData()

        Dim newReport As TextReport = FormMain.TextReportFile

        For n As Integer = 0 To nicCount - 1
            newReport.WriteItem("Device", nicList(n).AdaptorName)
            newReport.WriteItem("Type", nicList(n).AdaptorType)
            newReport.WriteItem("MAC Address", nicList(n).MacAddress)
            newReport.WriteItem("IP Address", nicList(n).IPAddress(1).ToString)
            newReport.WriteItem("IP Subnet", nicList(n).IPSubnet(1).ToString)
            newReport.WriteItem("Gateway Address", nicList(n).DefaultGateway(1).ToString)
            newReport.WriteItem("DNS Server Address", nicList(n).DnsServer(1).ToString)
            newReport.WriteItem("DHCP Server Address", nicList(n).DhcpServer.ToString)

            newReport.WriteSubtitle("")
        Next

    End Sub

End Class
