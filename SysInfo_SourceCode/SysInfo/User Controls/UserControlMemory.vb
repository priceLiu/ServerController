Option Strict On
Option Explicit On

Imports SysInfo.Wmi
Imports System.Globalization.CultureInfo
Imports System.Management

Public Class UserControlMemory

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        GetMemoryInformation()

    End Sub

    Private Structure MemoryModule
        Dim DataWidth As Integer
        Dim Speed As Integer
        Dim Capacity As Long
    End Structure

    Private Sub GetMemoryInformation()

		' Get memory module information.

        Dim installedCapacity As Long
        Dim slotCount As Integer
		Dim memorySize As Long

        Dim query As ManagementObjectSearcher = New ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory WHERE Capacity > 0")
        Dim queryCollection As ManagementObjectCollection = query.Get()

		lstMemoryModules.Items.Clear()

		Try
			For Each mo As ManagementObject In queryCollection

				Dim mm As New MemoryModule
				Dim lvi As New ListViewItem

				slotCount += 1
				memorySize = CLng(mo("Capacity"))

				installedCapacity += memorySize

                lvi.Text = slotCount.ToString(InvariantCulture)
                lvi.SubItems.Add(CLng(memorySize / (1024 ^ 2)).ToString(InvariantCulture))
                lvi.SubItems.Add(CInt(mo("Speed")).ToString(InvariantCulture))
                lvi.SubItems.Add(CInt(mo("DataWidth")).ToString(InvariantCulture))

				lstMemoryModules.Items.Add(lvi)

			Next
		Catch ex As ManagementException
            ErrorList.AddErrorToList(ex.Message, "Win32_PhysicalMemory", "Getting Memory Module Info.")
		End Try

        installedCapacity = CLng(installedCapacity / (1024 ^ 2))

        Dim totalMem As Long = installedCapacity
        Dim availableMem As Long = CLng(Win32ClassInfo.GetClassProperty("Win32_PerfFormattedData_PerfOS_Memory", "AvailableMbytes"))

        lblMemInstalled.Text = totalMem.ToString(InvariantCulture) & " MBytes"
        lblMemAvailable.Text = availableMem.ToString(InvariantCulture) & " MBytes"
        lblMemUsed.Text = (totalMem - availableMem).ToString(InvariantCulture) & " MBytes"
        lblMemForm.Text = Win32ClassInfo.GetClassProperty("Win32_PhysicalMemory", "FormFactor")
        lblMemFree.Text = Win32ClassInfo.GetClassProperty("Win32_PerfFormattedData_PerfOS_Memory", "FreeAndZeroPageListBytes")
        lblMemType.Text = Win32ClassInfo.GetClassProperty("Win32_PhysicalMemory", "MemoryType")

        lblMemSlotsOccupied.Text = slotCount.ToString(InvariantCulture)
        lblMemSlotsAvailable.Text = Win32ClassInfo.GetClassProperty("Win32_PhysicalMemoryArray", "MemoryDevices")
		lblMemMaxInstallable.Text = Win32ClassInfo.GetClassProperty("Win32_PhysicalMemoryArray", "MaxCapacity")

		' Get page file information.
        Dim mc As New ManagementClass("Win32_PageFile")

        lstPageFile.Items.Clear()

        Try
            For Each mo As ManagementObject In mc.GetInstances()
                Dim lvi As New ListViewItem

                lvi.Text = mo("InitialSize").ToString
                lvi.SubItems.Add(mo("MaximumSize").ToString)
                lvi.SubItems.Add(mo("Encrypted").ToString)
                lvi.SubItems.Add(mo("EightDotThreeFileName").ToString)

                lstPageFile.Items.Add(lvi)
            Next

        Catch ex As ManagementException
            ErrorList.AddErrorToList(ex.Message, mc.ClassPath.ClassName(), "Getting Page File Info.")
        End Try

    End Sub

    Public Sub CollectReportData()

        Dim newReport As TextReport = FormMain.TextReportFile

        newReport.WriteSubtitle(vbTab & "[Memory]")
        newReport.WriteItem("Installed", lblMemInstalled.Text)
        newReport.WriteItem("Maximum Installable", lblMemMaxInstallable.Text)
        newReport.WriteItem("Memory Slots", lblMemSlotsAvailable.Text)
        newReport.WriteItem("Slots Occupied", lblMemSlotsOccupied.Text)
        newReport.WriteItem("Module Type", lblMemType.Text)
        newReport.WriteItem("Module Form Factor", lblMemForm.Text)

    End Sub

End Class
