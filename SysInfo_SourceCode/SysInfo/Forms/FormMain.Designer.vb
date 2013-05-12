<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    '<System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
                newReport.Dispose()
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.pnlMenu = New System.Windows.Forms.Panel
        Me.LinkLabelReport = New System.Windows.Forms.LinkLabel
        Me.LinkLabelDrivers = New System.Windows.Forms.LinkLabel
        Me.LinkLabelProcesses = New System.Windows.Forms.LinkLabel
        Me.LinkLabelServices = New System.Windows.Forms.LinkLabel
        Me.LinkLabelDevices = New System.Windows.Forms.LinkLabel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.LinkLabelProcessor = New System.Windows.Forms.LinkLabel
        Me.LinkLabelHome = New System.Windows.Forms.LinkLabel
        Me.LinkLabelStorage = New System.Windows.Forms.LinkLabel
        Me.LinkLabelDetailed = New System.Windows.Forms.LinkLabel
        Me.LinkLabelEnvVariables = New System.Windows.Forms.LinkLabel
        Me.LinkLabelSpecialFolders = New System.Windows.Forms.LinkLabel
        Me.LinkLabelVideo = New System.Windows.Forms.LinkLabel
        Me.LinkLabelNetwork = New System.Windows.Forms.LinkLabel
        Me.LinkLabelMemory = New System.Windows.Forms.LinkLabel
        Me.LinkLabelSystem = New System.Windows.Forms.LinkLabel
        Me.LinkLabelOS = New System.Windows.Forms.LinkLabel
        Me.pnlUserCtrls = New System.Windows.Forms.Panel
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog
        Me.pnlMenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlMenu
        '
        Me.pnlMenu.BackgroundImage = CType(resources.GetObject("pnlMenu.BackgroundImage"), System.Drawing.Image)
        Me.pnlMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlMenu.Controls.Add(Me.LinkLabelReport)
        Me.pnlMenu.Controls.Add(Me.LinkLabelDrivers)
        Me.pnlMenu.Controls.Add(Me.LinkLabelProcesses)
        Me.pnlMenu.Controls.Add(Me.LinkLabelServices)
        Me.pnlMenu.Controls.Add(Me.LinkLabelDevices)
        Me.pnlMenu.Controls.Add(Me.PictureBox1)
        Me.pnlMenu.Controls.Add(Me.LinkLabelProcessor)
        Me.pnlMenu.Controls.Add(Me.LinkLabelHome)
        Me.pnlMenu.Controls.Add(Me.LinkLabelStorage)
        Me.pnlMenu.Controls.Add(Me.LinkLabelDetailed)
        Me.pnlMenu.Controls.Add(Me.LinkLabelEnvVariables)
        Me.pnlMenu.Controls.Add(Me.LinkLabelSpecialFolders)
        Me.pnlMenu.Controls.Add(Me.LinkLabelVideo)
        Me.pnlMenu.Controls.Add(Me.LinkLabelNetwork)
        Me.pnlMenu.Controls.Add(Me.LinkLabelMemory)
        Me.pnlMenu.Controls.Add(Me.LinkLabelSystem)
        Me.pnlMenu.Controls.Add(Me.LinkLabelOS)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(197, 668)
        Me.pnlMenu.TabIndex = 0
        '
        'LinkLabelReport
        '
        Me.LinkLabelReport.ActiveLinkColor = System.Drawing.Color.Navy
        Me.LinkLabelReport.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabelReport.DisabledLinkColor = System.Drawing.Color.Navy
        Me.LinkLabelReport.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelReport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LinkLabelReport.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabelReport.LinkColor = System.Drawing.Color.Navy
        Me.LinkLabelReport.Location = New System.Drawing.Point(25, 521)
        Me.LinkLabelReport.Margin = New System.Windows.Forms.Padding(3)
        Me.LinkLabelReport.Name = "LinkLabelReport"
        Me.LinkLabelReport.Padding = New System.Windows.Forms.Padding(3)
        Me.LinkLabelReport.Size = New System.Drawing.Size(147, 22)
        Me.LinkLabelReport.TabIndex = 15
        Me.LinkLabelReport.TabStop = True
        Me.LinkLabelReport.Text = "Save Text Report"
        Me.LinkLabelReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabelReport.VisitedLinkColor = System.Drawing.Color.Navy
        '
        'LinkLabelDrivers
        '
        Me.LinkLabelDrivers.ActiveLinkColor = System.Drawing.Color.Navy
        Me.LinkLabelDrivers.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabelDrivers.DisabledLinkColor = System.Drawing.Color.Navy
        Me.LinkLabelDrivers.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelDrivers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LinkLabelDrivers.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabelDrivers.LinkColor = System.Drawing.Color.Navy
        Me.LinkLabelDrivers.Location = New System.Drawing.Point(25, 412)
        Me.LinkLabelDrivers.Margin = New System.Windows.Forms.Padding(3)
        Me.LinkLabelDrivers.Name = "LinkLabelDrivers"
        Me.LinkLabelDrivers.Padding = New System.Windows.Forms.Padding(3)
        Me.LinkLabelDrivers.Size = New System.Drawing.Size(166, 22)
        Me.LinkLabelDrivers.TabIndex = 13
        Me.LinkLabelDrivers.TabStop = True
        Me.LinkLabelDrivers.Text = "System Drivers"
        Me.LinkLabelDrivers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabelDrivers.VisitedLinkColor = System.Drawing.Color.Navy
        '
        'LinkLabelProcesses
        '
        Me.LinkLabelProcesses.ActiveLinkColor = System.Drawing.Color.Navy
        Me.LinkLabelProcesses.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabelProcesses.DisabledLinkColor = System.Drawing.Color.Navy
        Me.LinkLabelProcesses.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelProcesses.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LinkLabelProcesses.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabelProcesses.LinkColor = System.Drawing.Color.Navy
        Me.LinkLabelProcesses.Location = New System.Drawing.Point(25, 300)
        Me.LinkLabelProcesses.Margin = New System.Windows.Forms.Padding(3)
        Me.LinkLabelProcesses.Name = "LinkLabelProcesses"
        Me.LinkLabelProcesses.Padding = New System.Windows.Forms.Padding(3)
        Me.LinkLabelProcesses.Size = New System.Drawing.Size(147, 22)
        Me.LinkLabelProcesses.TabIndex = 12
        Me.LinkLabelProcesses.TabStop = True
        Me.LinkLabelProcesses.Text = "Running Processes"
        Me.LinkLabelProcesses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabelProcesses.VisitedLinkColor = System.Drawing.Color.Navy
        '
        'LinkLabelServices
        '
        Me.LinkLabelServices.ActiveLinkColor = System.Drawing.Color.Navy
        Me.LinkLabelServices.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabelServices.DisabledLinkColor = System.Drawing.Color.Navy
        Me.LinkLabelServices.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelServices.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabelServices.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabelServices.LinkColor = System.Drawing.Color.Navy
        Me.LinkLabelServices.Location = New System.Drawing.Point(25, 328)
        Me.LinkLabelServices.Margin = New System.Windows.Forms.Padding(3)
        Me.LinkLabelServices.Name = "LinkLabelServices"
        Me.LinkLabelServices.Padding = New System.Windows.Forms.Padding(3)
        Me.LinkLabelServices.Size = New System.Drawing.Size(147, 22)
        Me.LinkLabelServices.TabIndex = 9
        Me.LinkLabelServices.TabStop = True
        Me.LinkLabelServices.Text = "Services"
        Me.LinkLabelServices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabelServices.VisitedLinkColor = System.Drawing.Color.Navy
        '
        'LinkLabelDevices
        '
        Me.LinkLabelDevices.ActiveLinkColor = System.Drawing.Color.Navy
        Me.LinkLabelDevices.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabelDevices.DisabledLinkColor = System.Drawing.Color.Navy
        Me.LinkLabelDevices.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelDevices.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabelDevices.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabelDevices.LinkColor = System.Drawing.Color.Navy
        Me.LinkLabelDevices.Location = New System.Drawing.Point(25, 104)
        Me.LinkLabelDevices.Margin = New System.Windows.Forms.Padding(3)
        Me.LinkLabelDevices.Name = "LinkLabelDevices"
        Me.LinkLabelDevices.Padding = New System.Windows.Forms.Padding(3)
        Me.LinkLabelDevices.Size = New System.Drawing.Size(147, 22)
        Me.LinkLabelDevices.TabIndex = 8
        Me.LinkLabelDevices.TabStop = True
        Me.LinkLabelDevices.Text = "Devices"
        Me.LinkLabelDevices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabelDevices.VisitedLinkColor = System.Drawing.Color.Navy
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Location = New System.Drawing.Point(46, 564)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(92, 92)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'LinkLabelProcessor
        '
        Me.LinkLabelProcessor.ActiveLinkColor = System.Drawing.Color.Navy
        Me.LinkLabelProcessor.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabelProcessor.DisabledLinkColor = System.Drawing.Color.Navy
        Me.LinkLabelProcessor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelProcessor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabelProcessor.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabelProcessor.LinkColor = System.Drawing.Color.Navy
        Me.LinkLabelProcessor.Location = New System.Drawing.Point(25, 272)
        Me.LinkLabelProcessor.Margin = New System.Windows.Forms.Padding(3)
        Me.LinkLabelProcessor.Name = "LinkLabelProcessor"
        Me.LinkLabelProcessor.Padding = New System.Windows.Forms.Padding(3)
        Me.LinkLabelProcessor.Size = New System.Drawing.Size(147, 22)
        Me.LinkLabelProcessor.TabIndex = 7
        Me.LinkLabelProcessor.TabStop = True
        Me.LinkLabelProcessor.Text = "Processor"
        Me.LinkLabelProcessor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabelProcessor.VisitedLinkColor = System.Drawing.Color.Navy
        '
        'LinkLabelHome
        '
        Me.LinkLabelHome.ActiveLinkColor = System.Drawing.Color.Navy
        Me.LinkLabelHome.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabelHome.DisabledLinkColor = System.Drawing.Color.Navy
        Me.LinkLabelHome.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelHome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LinkLabelHome.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabelHome.LinkColor = System.Drawing.Color.Navy
        Me.LinkLabelHome.Location = New System.Drawing.Point(25, 25)
        Me.LinkLabelHome.Margin = New System.Windows.Forms.Padding(3)
        Me.LinkLabelHome.Name = "LinkLabelHome"
        Me.LinkLabelHome.Padding = New System.Windows.Forms.Padding(3)
        Me.LinkLabelHome.Size = New System.Drawing.Size(147, 22)
        Me.LinkLabelHome.TabIndex = 0
        Me.LinkLabelHome.TabStop = True
        Me.LinkLabelHome.Text = "Home"
        Me.LinkLabelHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabelHome.VisitedLinkColor = System.Drawing.Color.Navy
        '
        'LinkLabelStorage
        '
        Me.LinkLabelStorage.ActiveLinkColor = System.Drawing.Color.Navy
        Me.LinkLabelStorage.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabelStorage.DisabledLinkColor = System.Drawing.Color.Navy
        Me.LinkLabelStorage.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelStorage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabelStorage.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabelStorage.LinkColor = System.Drawing.Color.Navy
        Me.LinkLabelStorage.Location = New System.Drawing.Point(25, 384)
        Me.LinkLabelStorage.Margin = New System.Windows.Forms.Padding(3)
        Me.LinkLabelStorage.Name = "LinkLabelStorage"
        Me.LinkLabelStorage.Padding = New System.Windows.Forms.Padding(3)
        Me.LinkLabelStorage.Size = New System.Drawing.Size(147, 22)
        Me.LinkLabelStorage.TabIndex = 6
        Me.LinkLabelStorage.TabStop = True
        Me.LinkLabelStorage.Text = "Storage Devices"
        Me.LinkLabelStorage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabelStorage.VisitedLinkColor = System.Drawing.Color.Navy
        '
        'LinkLabelDetailed
        '
        Me.LinkLabelDetailed.ActiveLinkColor = System.Drawing.Color.Navy
        Me.LinkLabelDetailed.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabelDetailed.DisabledLinkColor = System.Drawing.Color.Navy
        Me.LinkLabelDetailed.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelDetailed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LinkLabelDetailed.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabelDetailed.LinkColor = System.Drawing.Color.Navy
        Me.LinkLabelDetailed.Location = New System.Drawing.Point(25, 132)
        Me.LinkLabelDetailed.Margin = New System.Windows.Forms.Padding(3)
        Me.LinkLabelDetailed.Name = "LinkLabelDetailed"
        Me.LinkLabelDetailed.Padding = New System.Windows.Forms.Padding(3)
        Me.LinkLabelDetailed.Size = New System.Drawing.Size(147, 22)
        Me.LinkLabelDetailed.TabIndex = 14
        Me.LinkLabelDetailed.TabStop = True
        Me.LinkLabelDetailed.Text = "Detailed Information"
        Me.LinkLabelDetailed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabelDetailed.VisitedLinkColor = System.Drawing.Color.Navy
        '
        'LinkLabelEnvVariables
        '
        Me.LinkLabelEnvVariables.ActiveLinkColor = System.Drawing.Color.Navy
        Me.LinkLabelEnvVariables.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabelEnvVariables.DisabledLinkColor = System.Drawing.Color.Navy
        Me.LinkLabelEnvVariables.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelEnvVariables.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LinkLabelEnvVariables.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabelEnvVariables.LinkColor = System.Drawing.Color.Navy
        Me.LinkLabelEnvVariables.Location = New System.Drawing.Point(25, 160)
        Me.LinkLabelEnvVariables.Margin = New System.Windows.Forms.Padding(3)
        Me.LinkLabelEnvVariables.Name = "LinkLabelEnvVariables"
        Me.LinkLabelEnvVariables.Padding = New System.Windows.Forms.Padding(3)
        Me.LinkLabelEnvVariables.Size = New System.Drawing.Size(147, 22)
        Me.LinkLabelEnvVariables.TabIndex = 11
        Me.LinkLabelEnvVariables.TabStop = True
        Me.LinkLabelEnvVariables.Text = "Environment Variables"
        Me.LinkLabelEnvVariables.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabelEnvVariables.VisitedLinkColor = System.Drawing.Color.Navy
        '
        'LinkLabelSpecialFolders
        '
        Me.LinkLabelSpecialFolders.ActiveLinkColor = System.Drawing.Color.Navy
        Me.LinkLabelSpecialFolders.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabelSpecialFolders.DisabledLinkColor = System.Drawing.Color.Navy
        Me.LinkLabelSpecialFolders.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelSpecialFolders.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LinkLabelSpecialFolders.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabelSpecialFolders.LinkColor = System.Drawing.Color.Navy
        Me.LinkLabelSpecialFolders.Location = New System.Drawing.Point(25, 356)
        Me.LinkLabelSpecialFolders.Margin = New System.Windows.Forms.Padding(3)
        Me.LinkLabelSpecialFolders.Name = "LinkLabelSpecialFolders"
        Me.LinkLabelSpecialFolders.Padding = New System.Windows.Forms.Padding(3)
        Me.LinkLabelSpecialFolders.Size = New System.Drawing.Size(147, 22)
        Me.LinkLabelSpecialFolders.TabIndex = 10
        Me.LinkLabelSpecialFolders.TabStop = True
        Me.LinkLabelSpecialFolders.Text = "Special Folders"
        Me.LinkLabelSpecialFolders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabelSpecialFolders.VisitedLinkColor = System.Drawing.Color.Navy
        '
        'LinkLabelVideo
        '
        Me.LinkLabelVideo.ActiveLinkColor = System.Drawing.Color.Navy
        Me.LinkLabelVideo.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabelVideo.DisabledLinkColor = System.Drawing.Color.Navy
        Me.LinkLabelVideo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelVideo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LinkLabelVideo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabelVideo.LinkColor = System.Drawing.Color.Navy
        Me.LinkLabelVideo.Location = New System.Drawing.Point(25, 440)
        Me.LinkLabelVideo.Margin = New System.Windows.Forms.Padding(3)
        Me.LinkLabelVideo.Name = "LinkLabelVideo"
        Me.LinkLabelVideo.Padding = New System.Windows.Forms.Padding(3)
        Me.LinkLabelVideo.Size = New System.Drawing.Size(147, 22)
        Me.LinkLabelVideo.TabIndex = 5
        Me.LinkLabelVideo.TabStop = True
        Me.LinkLabelVideo.Text = "Video"
        Me.LinkLabelVideo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabelVideo.VisitedLinkColor = System.Drawing.Color.Navy
        '
        'LinkLabelNetwork
        '
        Me.LinkLabelNetwork.ActiveLinkColor = System.Drawing.Color.Navy
        Me.LinkLabelNetwork.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabelNetwork.DisabledLinkColor = System.Drawing.Color.Navy
        Me.LinkLabelNetwork.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelNetwork.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LinkLabelNetwork.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabelNetwork.LinkColor = System.Drawing.Color.Navy
        Me.LinkLabelNetwork.Location = New System.Drawing.Point(25, 216)
        Me.LinkLabelNetwork.Margin = New System.Windows.Forms.Padding(3)
        Me.LinkLabelNetwork.Name = "LinkLabelNetwork"
        Me.LinkLabelNetwork.Padding = New System.Windows.Forms.Padding(3)
        Me.LinkLabelNetwork.Size = New System.Drawing.Size(147, 22)
        Me.LinkLabelNetwork.TabIndex = 4
        Me.LinkLabelNetwork.TabStop = True
        Me.LinkLabelNetwork.Text = "Network"
        Me.LinkLabelNetwork.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabelNetwork.VisitedLinkColor = System.Drawing.Color.Navy
        '
        'LinkLabelMemory
        '
        Me.LinkLabelMemory.ActiveLinkColor = System.Drawing.Color.Navy
        Me.LinkLabelMemory.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabelMemory.DisabledLinkColor = System.Drawing.Color.Navy
        Me.LinkLabelMemory.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelMemory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LinkLabelMemory.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabelMemory.LinkColor = System.Drawing.Color.Navy
        Me.LinkLabelMemory.Location = New System.Drawing.Point(25, 188)
        Me.LinkLabelMemory.Margin = New System.Windows.Forms.Padding(3)
        Me.LinkLabelMemory.Name = "LinkLabelMemory"
        Me.LinkLabelMemory.Padding = New System.Windows.Forms.Padding(3)
        Me.LinkLabelMemory.Size = New System.Drawing.Size(147, 22)
        Me.LinkLabelMemory.TabIndex = 3
        Me.LinkLabelMemory.TabStop = True
        Me.LinkLabelMemory.Text = "Memory"
        Me.LinkLabelMemory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabelMemory.VisitedLinkColor = System.Drawing.Color.Navy
        '
        'LinkLabelSystem
        '
        Me.LinkLabelSystem.ActiveLinkColor = System.Drawing.Color.Navy
        Me.LinkLabelSystem.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabelSystem.DisabledLinkColor = System.Drawing.Color.Navy
        Me.LinkLabelSystem.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelSystem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LinkLabelSystem.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabelSystem.LinkColor = System.Drawing.Color.Navy
        Me.LinkLabelSystem.Location = New System.Drawing.Point(25, 76)
        Me.LinkLabelSystem.Margin = New System.Windows.Forms.Padding(3)
        Me.LinkLabelSystem.Name = "LinkLabelSystem"
        Me.LinkLabelSystem.Padding = New System.Windows.Forms.Padding(3)
        Me.LinkLabelSystem.Size = New System.Drawing.Size(147, 22)
        Me.LinkLabelSystem.TabIndex = 2
        Me.LinkLabelSystem.TabStop = True
        Me.LinkLabelSystem.Text = "Computer System"
        Me.LinkLabelSystem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabelSystem.VisitedLinkColor = System.Drawing.Color.Navy
        '
        'LinkLabelOS
        '
        Me.LinkLabelOS.ActiveLinkColor = System.Drawing.Color.Navy
        Me.LinkLabelOS.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabelOS.DisabledLinkColor = System.Drawing.Color.Navy
        Me.LinkLabelOS.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelOS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LinkLabelOS.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabelOS.LinkColor = System.Drawing.Color.Navy
        Me.LinkLabelOS.Location = New System.Drawing.Point(25, 244)
        Me.LinkLabelOS.Margin = New System.Windows.Forms.Padding(3)
        Me.LinkLabelOS.Name = "LinkLabelOS"
        Me.LinkLabelOS.Padding = New System.Windows.Forms.Padding(3)
        Me.LinkLabelOS.Size = New System.Drawing.Size(147, 22)
        Me.LinkLabelOS.TabIndex = 1
        Me.LinkLabelOS.TabStop = True
        Me.LinkLabelOS.Text = "Operating System"
        Me.LinkLabelOS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabelOS.VisitedLinkColor = System.Drawing.Color.Navy
        '
        'pnlUserCtrls
        '
        Me.pnlUserCtrls.BackColor = System.Drawing.Color.White
        Me.pnlUserCtrls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlUserCtrls.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlUserCtrls.Location = New System.Drawing.Point(197, 0)
        Me.pnlUserCtrls.Name = "pnlUserCtrls"
        Me.pnlUserCtrls.Size = New System.Drawing.Size(793, 668)
        Me.pnlUserCtrls.TabIndex = 0
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(990, 668)
        Me.Controls.Add(Me.pnlUserCtrls)
        Me.Controls.Add(Me.pnlMenu)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SysInfo"
        Me.pnlMenu.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlMenu As System.Windows.Forms.Panel
    Friend WithEvents pnlUserCtrls As System.Windows.Forms.Panel
    Friend WithEvents LinkLabelOS As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabelSystem As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabelMemory As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabelNetwork As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabelVideo As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabelEnvVariables As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabelSpecialFolders As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabelDetailed As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabelStorage As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabelHome As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabelProcessor As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LinkLabelDevices As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabelServices As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabelProcesses As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabelDrivers As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabelReport As System.Windows.Forms.LinkLabel
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog

End Class
