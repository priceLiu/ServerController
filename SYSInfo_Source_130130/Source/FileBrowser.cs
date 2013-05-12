//============================================================================
// SYSInfo 2.0
// Copyright © 2010 Stephan Berger
// 
//This file is part of SYSInfo.
//
//SYSInfo is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.
//
//SYSInfo is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.
//
//You should have received a copy of the GNU General Public License
//along with SYSInfo.  If not, see <http://www.gnu.org/licenses/>.
//
//============================================================================

/// <summary>
///Simple filebrowser class
///parses all files and folders in the given path
///populates a context menu with results
///
/// uses unmanaged code of SHFILEINFO interface for retrieving file icons
/// right click opens shell context menu
/// 
/// double click opens selected file/folder
///</summary>

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Runtime.InteropServices;

namespace SYSInfo
{
    public class ToolStripDropDownItemEx : ToolStripDropDownItem
    {
        string _Path;

        public ToolStripDropDownItemEx():base()
        {
        }

        public string Path
        {
            get
            {
                return _Path;
            }
            set
            {
                _Path = value;
            }
        }
    }
    public class ToolStripMenuItemEx : ToolStripMenuItem
    {
        string _Path, _fileInfo;

        public ToolStripMenuItemEx():base()
        {
        }
        public ToolStripMenuItemEx(string Name, Image i):base(Name,i)
        {
        }

        public string Path
        {
            get
            {
                return _Path;
            }
            set
            {
                _Path = value;
            }
        }
    }

    class FileBrowser
    {
        Form f1;
        ImageList imageList;
        string rootDir;
        int xPos,yPos;

        public FileBrowser(Form1 f1, int xPos, int yPos)
        {
            this.f1 = f1;   //reference to form for positioning
            imageList = f1.imageList1;  //folder icon
            this.xPos = xPos;   //position of hdd-bar
            this.yPos = yPos;
        }

        //Create and populate the contextmenu with files/folders of selected directory
        public void populateList(string sPath)
        {

            ContextMenuStrip cMenue = new ContextMenuStrip();
            DirectoryInfo nodeDirInfo = new DirectoryInfo(sPath);
            if (nodeDirInfo.Exists)
            {
                rootDir = sPath;
                int i = 0;
                ToolStripMenuItemEx[] iItem = new ToolStripMenuItemEx[nodeDirInfo.GetDirectories().Length];
                foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
                {
                    iItem[i] = new ToolStripMenuItemEx(dir.Name,imageList.Images[0]);
                  //  iItem[i].ToolTipText = dir.FullName;
                    iItem[i].Path = dir.FullName;
                    if (System.Threading.Thread.CurrentThread.CurrentUICulture.ToString() == "de-DE")
                        iItem[i].ToolTipText = de[3]; //"Erstellt: "
                    else
                        iItem[i].ToolTipText = en[3];
                    iItem[i].ToolTipText += dir.CreationTime.ToString();
                    iItem[i].DropDownItems.Add("...");
                    iItem[i].DropDownOpening += new EventHandler(iItem_DropDownOpening);
                    Console.Write(iItem[i].Name + "\n");
                    i++;
                }
                
                cMenue.Items.AddRange(iItem);
                cMenue.DoubleClick += new EventHandler(DropDown_DoubleClick);
                cMenue.MouseClick += new MouseEventHandler(DropDown_MouseClick);
                iItem = new ToolStripMenuItemEx[nodeDirInfo.GetFiles().Length];
                i = 0;
                foreach (FileInfo file in nodeDirInfo.GetFiles())
                {
                    iItem[i] = fileInfo(file, iItem.Length);
                    i++;
                }
                cMenue.Items.AddRange(iItem);
                Rectangle rScreen = Screen.GetWorkingArea(f1);
                if (rScreen.Width + rScreen.X > f1.Location.X + xPos + cMenue.Width)
                    cMenue.Show(f1.Location.X + xPos, f1.Location.Y + yPos);
                else
                    cMenue.Show(f1.Location.X - cMenue.Width, f1.Location.Y + yPos);
            }
        }
        void iItem_DropDownOpening(object sender, EventArgs e)
        {
            ToolStripMenuItemEx iParentItem = (ToolStripMenuItemEx)sender;
            string DirTemp = iParentItem.Path;
            DirectoryInfo nodeDirInfo = new DirectoryInfo(DirTemp);
            int i = 0;
            if (nodeDirInfo.Exists)
            {

                rootDir = DirTemp;
                iParentItem.DropDownItems.Clear();

                DirectoryInfo[] dir = null;
                try
                {
                    dir = nodeDirInfo.GetDirectories();
                }
                catch (UnauthorizedAccessException)
                {
                     ; ;
                }
                ToolStripMenuItemEx[] iItem;

                if (dir != null)
                {
                    iItem = new ToolStripMenuItemEx[dir.Length];
                    i = 0;
                    foreach (DirectoryInfo dDir in dir)
                    {
                        iItem[i] = new ToolStripMenuItemEx(dDir.Name, imageList.Images[0]);
                        iItem[i].Path = dDir.FullName;
                        iItem[i].DropDownItems.Add("...");
                        iItem[i].DropDown.Closing += new ToolStripDropDownClosingEventHandler(DropDown_Closing);
                        iItem[i].DropDownOpening += new EventHandler(iItem_DropDownOpening);
                        i++;
                    }
                    iParentItem.DropDownItems.AddRange(iItem);
                    iParentItem.DropDown.DoubleClick += new EventHandler(DropDown_DoubleClick);
                    iParentItem.DropDown.MouseClick += new MouseEventHandler(DropDown_MouseClick);
                }
                FileInfo[] fFile = null;
                try
                {
                    fFile = nodeDirInfo.GetFiles();
                }
                catch (UnauthorizedAccessException)
                {
                     ; ;
                }
                i = 0;
                if (fFile != null)
                {
                    iItem = new ToolStripMenuItemEx[fFile.Length];
                    foreach (FileInfo file in fFile)
                    {
                        iItem[i] = fileInfo(file, fFile.Length);
                        i++;
                    }
                    iParentItem.DropDownItems.AddRange(iItem);
                }
            }
        }

        void DropDown_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
              //  Point location = new Point(f1.Location.X, f1.Location.Y + yPos);
                string dirSelected, dirRoot;
                DirectoryInfo nodeDirInfo = new DirectoryInfo(rootDir);

                if (nodeDirInfo.Exists)
                {
                    if (nodeDirInfo.Parent != null)
                    {
                        dirRoot = nodeDirInfo.Parent.FullName.ToString();
                        dirSelected = nodeDirInfo.Name.ToString();
                        IShellContextMenu contextmen = new IShellContextMenu();
                        contextmen.iContextMenu(dirRoot, dirSelected,false);
                    }
                }
            }
        }

        ToolStripMenuItemEx fileInfo(FileInfo file, int iLength)
        {
            ToolStripMenuItemEx iItem = new ToolStripMenuItemEx();
            ShellExtensions.SHFILEINFO shinfo = new ShellExtensions.SHFILEINFO();
            IntPtr hImgSmall = ShellExtensions.Win32.SHGetFileInfo(file.FullName, 0, ref shinfo,
               (uint)Marshal.SizeOf(shinfo),
                ShellExtensions.Win32.SHGFI_ICON |
                ShellExtensions.Win32.SHGFI_SMALLICON);
            System.Drawing.Icon shellIcon =
                System.Drawing.Icon.FromHandle(shinfo.hIcon);
            Image iImage = shellIcon.ToBitmap();
            ShellExtensions.Win32.DestroyIcon(shinfo.hIcon);
            iItem = new ToolStripMenuItemEx(file.Name, iImage);
            iItem.DoubleClick += new EventHandler(iItem_DoubleClick);
            iItem.MouseDown += new MouseEventHandler(iItem_Click);
            iItem.Path = file.FullName;
            IntPtr hFileInfo = ShellExtensions.Win32.SHGetFileInfo(file.FullName, 0, ref shinfo,
               (uint)Marshal.SizeOf(shinfo),
                ShellExtensions.Win32.SHGFI_TYPENAME);
            string[] sCultureText;
            if (System.Threading.Thread.CurrentThread.CurrentUICulture.ToString() == "de-DE")
                sCultureText = de;
            else
                sCultureText = en;

            iItem.ToolTipText = sCultureText[0] + shinfo.szTypeName + "\n";
            iItem.ToolTipText += sCultureText[1] + CalcSize(file.Length) + "\n";
            iItem.ToolTipText += sCultureText[2] + file.LastWriteTime + "\n";
            iItem.ToolTipText += sCultureText[3] + file.CreationTime + "\n";
            return iItem;
        }

        string CalcSize(float lVal)
        {
            if (lVal < 1024)
                return lVal.ToString() + " Bytes";
            else
            {
                lVal /= 1024;
                if (lVal < 1024)
                    return lVal.ToString("##.##") + " KB";
                else
                {
                    lVal /= 1024;
                    if (lVal < 1024)
                        return lVal.ToString("##.##") + " MB";
                    else
                    {
                        lVal /= 1024;
                        return lVal.ToString("##.##") + " GB";
                    }

                }
            }
        }

        void iItem_Click(object sender, MouseEventArgs e)
        {
        //    Point location = new Point(f1.Location.X, f1.Location.Y + yPos);
            if (e.Button == MouseButtons.Right)
            {
                IShellContextMenu contextmen = new IShellContextMenu();
                ToolStripMenuItemEx mItem = (ToolStripMenuItemEx)sender;
 //               string root = mItem.ToolTipText.Substring(0, mItem.ToolTipText.LastIndexOf("\\")+1);
                string root="";
                if(mItem.Name.Length>0)            
                    root = mItem.Name.Substring(0, mItem.Path.LastIndexOf("\\")+1);
                else
                    root = mItem.Path.Substring(0, mItem.Path.LastIndexOf("\\")+1);

                contextmen.iContextMenu(root, sender.ToString(), false);
            }
            if (e.Button == MouseButtons.Left)
                iItem_DoubleClick(sender, e);
        }

        void iItem_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "rundll32.exe";
            proc.StartInfo.Arguments = " shell32.dll,ShellExec_RunDLL " + rootDir + "\\" + sender.ToString(); 
            try
            {
                proc.Start();
            }
            catch (Exception ex)
            {
                if (ex.Message == "Application not found" || ex.Message == "Anwendung nicht gefunden") //open "OpenAs" filedialog
                {
                    proc.StartInfo.FileName = "rundll32.exe";
                    proc.StartInfo.Arguments = " shell32.dll, OpenAs_RunDLL " + rootDir + "\\" + sender.ToString();
                    proc.Start();
                }
            }
        }
        void DropDown_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(rootDir);
        }
        void DropDown_Closing(object sender, ToolStripDropDownClosingEventArgs e)
        {
        }

        string[] de = { "Typ: ", "Größe: ", "Geändert: ", "Erstellt: " };
        string[] en = { "type: ", "size: ", "changed: ", "created: " };
    }
}
