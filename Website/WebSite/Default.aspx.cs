using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Text;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = "SystemInformation:<br/>" + SystemInformation();
    }

    private string SystemInformation()
    {
        StringBuilder StringBuilder1 = new StringBuilder(string.Empty);
        try
        {
            StringBuilder1.AppendFormat("Operation System:  {0}<br/>", Environment.OSVersion);
            if (Environment.Is64BitOperatingSystem)
                StringBuilder1.AppendFormat("\t\t  64 Bit Operating System<br/>");
            else
                StringBuilder1.AppendFormat("\t\t  32 Bit Operating System<br/>");
            StringBuilder1.AppendFormat("SystemDirectory:  {0}<br/>", Environment.SystemDirectory);
            StringBuilder1.AppendFormat("ProcessorCount:  {0}<br/>", Environment.ProcessorCount);
            StringBuilder1.AppendFormat("UserDomainName:  {0}<br/>", Environment.UserDomainName);
            StringBuilder1.AppendFormat("UserName: {0}<br>", Environment.UserName);
            //Drives
            StringBuilder1.AppendFormat("LogicalDrives:<br>");
            foreach (System.IO.DriveInfo DriveInfo1 in System.IO.DriveInfo.GetDrives())
            {
                try
                {
                    StringBuilder1.AppendFormat("\t Drive: {0}<br/>\t\t VolumeLabel: {1}<br/>\t\t DriveType: {2}<br/>\t\t DriveFormat: {3}<br/>\t\t TotalSize: {4}<br/>\t\t AvailableFreeSpace: {5}<br/>",
                        DriveInfo1.Name, DriveInfo1.VolumeLabel, DriveInfo1.DriveType, DriveInfo1.DriveFormat, DriveInfo1.TotalSize, DriveInfo1.AvailableFreeSpace);
                }
                catch
                {
                }
            }
            StringBuilder1.AppendFormat("SystemPageSize:  {0}<br/>", Environment.SystemPageSize);
            StringBuilder1.AppendFormat("Version:  {0}", Environment.Version);
        }
        catch
        {
        }
        return StringBuilder1.ToString();
    }
}