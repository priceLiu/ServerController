<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlVideo
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
        Me.TableLayoutVideo = New System.Windows.Forms.TableLayoutPanel
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblVideoRefreshRate = New System.Windows.Forms.Label
        Me.lblVideoScanMode = New System.Windows.Forms.Label
        Me.Label65 = New System.Windows.Forms.Label
        Me.Label67 = New System.Windows.Forms.Label
        Me.Label63 = New System.Windows.Forms.Label
        Me.Label60 = New System.Windows.Forms.Label
        Me.lblVideoManufacturer = New System.Windows.Forms.Label
        Me.lblVideoCard = New System.Windows.Forms.Label
        Me.lblVideoMem = New System.Windows.Forms.Label
        Me.lblVideoDriverVersion = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.lblVideoColourDepth = New System.Windows.Forms.Label
        Me.Label58 = New System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.lblVideoPixelsY = New System.Windows.Forms.Label
        Me.lblVideoPixelsX = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label86 = New System.Windows.Forms.Label
        Me.Label64 = New System.Windows.Forms.Label
        Me.Label73 = New System.Windows.Forms.Label
        Me.lblMonitorManufacturer = New System.Windows.Forms.Label
        Me.lblMonitorName = New System.Windows.Forms.Label
        Me.Label59 = New System.Windows.Forms.Label
        Me.Label61 = New System.Windows.Forms.Label
        Me.lblVideoHorizontalRes = New System.Windows.Forms.Label
        Me.lblVideoVerticalRes = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox8 = New System.Windows.Forms.PictureBox
        Me.cmbMonitors = New System.Windows.Forms.ComboBox
        Me.cmbVideoCards = New System.Windows.Forms.ComboBox
        Me.DividerControl1 = New SysInfo.CustomControls.DividerControl
        Me.Divider2 = New SysInfo.CustomControls.DividerControl
        Me.TableLayoutVideo.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutVideo
        '
        Me.TableLayoutVideo.AutoSize = True
        Me.TableLayoutVideo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutVideo.ColumnCount = 2
        Me.TableLayoutVideo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutVideo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutVideo.Controls.Add(Me.Label2, 0, 6)
        Me.TableLayoutVideo.Controls.Add(Me.lblVideoRefreshRate, 1, 5)
        Me.TableLayoutVideo.Controls.Add(Me.lblVideoScanMode, 1, 6)
        Me.TableLayoutVideo.Controls.Add(Me.Label65, 0, 0)
        Me.TableLayoutVideo.Controls.Add(Me.Label67, 0, 1)
        Me.TableLayoutVideo.Controls.Add(Me.Label63, 0, 2)
        Me.TableLayoutVideo.Controls.Add(Me.Label60, 0, 3)
        Me.TableLayoutVideo.Controls.Add(Me.lblVideoManufacturer, 1, 0)
        Me.TableLayoutVideo.Controls.Add(Me.lblVideoCard, 1, 1)
        Me.TableLayoutVideo.Controls.Add(Me.lblVideoMem, 1, 2)
        Me.TableLayoutVideo.Controls.Add(Me.lblVideoDriverVersion, 1, 3)
        Me.TableLayoutVideo.Controls.Add(Me.Label14, 0, 4)
        Me.TableLayoutVideo.Controls.Add(Me.lblVideoColourDepth, 1, 4)
        Me.TableLayoutVideo.Controls.Add(Me.Label58, 0, 5)
        Me.TableLayoutVideo.Location = New System.Drawing.Point(49, 429)
        Me.TableLayoutVideo.Margin = New System.Windows.Forms.Padding(6)
        Me.TableLayoutVideo.Name = "TableLayoutVideo"
        Me.TableLayoutVideo.Padding = New System.Windows.Forms.Padding(5)
        Me.TableLayoutVideo.RowCount = 7
        Me.TableLayoutVideo.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutVideo.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutVideo.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutVideo.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutVideo.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutVideo.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutVideo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutVideo.Size = New System.Drawing.Size(138, 162)
        Me.TableLayoutVideo.TabIndex = 103
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(9, 141)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 12)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "Scan Mode:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVideoRefreshRate
        '
        Me.lblVideoRefreshRate.AutoSize = True
        Me.lblVideoRefreshRate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblVideoRefreshRate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVideoRefreshRate.ForeColor = System.Drawing.Color.Navy
        Me.lblVideoRefreshRate.Location = New System.Drawing.Point(106, 119)
        Me.lblVideoRefreshRate.Margin = New System.Windows.Forms.Padding(4)
        Me.lblVideoRefreshRate.Name = "lblVideoRefreshRate"
        Me.lblVideoRefreshRate.Size = New System.Drawing.Size(23, 14)
        Me.lblVideoRefreshRate.TabIndex = 108
        Me.lblVideoRefreshRate.Text = "    "
        Me.lblVideoRefreshRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVideoScanMode
        '
        Me.lblVideoScanMode.AutoSize = True
        Me.lblVideoScanMode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblVideoScanMode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVideoScanMode.ForeColor = System.Drawing.Color.Navy
        Me.lblVideoScanMode.Location = New System.Drawing.Point(106, 141)
        Me.lblVideoScanMode.Margin = New System.Windows.Forms.Padding(4)
        Me.lblVideoScanMode.Name = "lblVideoScanMode"
        Me.lblVideoScanMode.Size = New System.Drawing.Size(23, 12)
        Me.lblVideoScanMode.TabIndex = 109
        Me.lblVideoScanMode.Text = "    "
        Me.lblVideoScanMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label65.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label65.Location = New System.Drawing.Point(9, 9)
        Me.Label65.Margin = New System.Windows.Forms.Padding(4)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(89, 14)
        Me.Label65.TabIndex = 87
        Me.Label65.Text = "Manufacturer:"
        Me.Label65.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label67.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label67.Location = New System.Drawing.Point(9, 31)
        Me.Label67.Margin = New System.Windows.Forms.Padding(4)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(89, 14)
        Me.Label67.TabIndex = 85
        Me.Label67.Text = "Card:"
        Me.Label67.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label63.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label63.Location = New System.Drawing.Point(9, 53)
        Me.Label63.Margin = New System.Windows.Forms.Padding(4)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(89, 14)
        Me.Label63.TabIndex = 89
        Me.Label63.Text = "Video Memory:"
        Me.Label63.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label60.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label60.Location = New System.Drawing.Point(9, 75)
        Me.Label60.Margin = New System.Windows.Forms.Padding(4)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(89, 14)
        Me.Label60.TabIndex = 102
        Me.Label60.Text = "Driver Version:"
        Me.Label60.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVideoManufacturer
        '
        Me.lblVideoManufacturer.AutoSize = True
        Me.lblVideoManufacturer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblVideoManufacturer.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVideoManufacturer.ForeColor = System.Drawing.Color.Navy
        Me.lblVideoManufacturer.Location = New System.Drawing.Point(106, 9)
        Me.lblVideoManufacturer.Margin = New System.Windows.Forms.Padding(4)
        Me.lblVideoManufacturer.Name = "lblVideoManufacturer"
        Me.lblVideoManufacturer.Size = New System.Drawing.Size(23, 14)
        Me.lblVideoManufacturer.TabIndex = 88
        Me.lblVideoManufacturer.Text = "    "
        Me.lblVideoManufacturer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVideoCard
        '
        Me.lblVideoCard.AutoSize = True
        Me.lblVideoCard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblVideoCard.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVideoCard.ForeColor = System.Drawing.Color.Navy
        Me.lblVideoCard.Location = New System.Drawing.Point(106, 31)
        Me.lblVideoCard.Margin = New System.Windows.Forms.Padding(4)
        Me.lblVideoCard.Name = "lblVideoCard"
        Me.lblVideoCard.Size = New System.Drawing.Size(23, 14)
        Me.lblVideoCard.TabIndex = 86
        Me.lblVideoCard.Text = "    "
        Me.lblVideoCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVideoMem
        '
        Me.lblVideoMem.AutoSize = True
        Me.lblVideoMem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblVideoMem.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVideoMem.ForeColor = System.Drawing.Color.Navy
        Me.lblVideoMem.Location = New System.Drawing.Point(106, 53)
        Me.lblVideoMem.Margin = New System.Windows.Forms.Padding(4)
        Me.lblVideoMem.Name = "lblVideoMem"
        Me.lblVideoMem.Size = New System.Drawing.Size(23, 14)
        Me.lblVideoMem.TabIndex = 90
        Me.lblVideoMem.Text = "    "
        Me.lblVideoMem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVideoDriverVersion
        '
        Me.lblVideoDriverVersion.AutoSize = True
        Me.lblVideoDriverVersion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblVideoDriverVersion.ForeColor = System.Drawing.Color.Navy
        Me.lblVideoDriverVersion.Location = New System.Drawing.Point(106, 75)
        Me.lblVideoDriverVersion.Margin = New System.Windows.Forms.Padding(4)
        Me.lblVideoDriverVersion.Name = "lblVideoDriverVersion"
        Me.lblVideoDriverVersion.Size = New System.Drawing.Size(23, 14)
        Me.lblVideoDriverVersion.TabIndex = 101
        Me.lblVideoDriverVersion.Text = "    "
        Me.lblVideoDriverVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(9, 97)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 14)
        Me.Label14.TabIndex = 95
        Me.Label14.Text = "Colour Depth:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVideoColourDepth
        '
        Me.lblVideoColourDepth.AutoSize = True
        Me.lblVideoColourDepth.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblVideoColourDepth.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVideoColourDepth.ForeColor = System.Drawing.Color.Navy
        Me.lblVideoColourDepth.Location = New System.Drawing.Point(106, 97)
        Me.lblVideoColourDepth.Margin = New System.Windows.Forms.Padding(4)
        Me.lblVideoColourDepth.Name = "lblVideoColourDepth"
        Me.lblVideoColourDepth.Size = New System.Drawing.Size(23, 14)
        Me.lblVideoColourDepth.TabIndex = 96
        Me.lblVideoColourDepth.Text = "    "
        Me.lblVideoColourDepth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label58.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label58.Location = New System.Drawing.Point(9, 119)
        Me.Label58.Margin = New System.Windows.Forms.Padding(4)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(89, 14)
        Me.Label58.TabIndex = 103
        Me.Label58.Text = "Refresh Rate:"
        Me.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel1.Controls.Add(Me.lblVideoPixelsY, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lblVideoPixelsX, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label86, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label64, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label73, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblMonitorManufacturer, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblMonitorName, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label59, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label61, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblVideoHorizontalRes, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblVideoVerticalRes, 1, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(49, 145)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(6)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(215, 180)
        Me.TableLayoutPanel1.TabIndex = 106
        '
        'lblVideoPixelsY
        '
        Me.lblVideoPixelsY.AutoSize = True
        Me.lblVideoPixelsY.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblVideoPixelsY.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVideoPixelsY.ForeColor = System.Drawing.Color.Navy
        Me.lblVideoPixelsY.Location = New System.Drawing.Point(183, 119)
        Me.lblVideoPixelsY.Margin = New System.Windows.Forms.Padding(4)
        Me.lblVideoPixelsY.Name = "lblVideoPixelsY"
        Me.lblVideoPixelsY.Size = New System.Drawing.Size(23, 12)
        Me.lblVideoPixelsY.TabIndex = 118
        Me.lblVideoPixelsY.Text = "    "
        Me.lblVideoPixelsY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVideoPixelsX
        '
        Me.lblVideoPixelsX.AutoSize = True
        Me.lblVideoPixelsX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblVideoPixelsX.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVideoPixelsX.ForeColor = System.Drawing.Color.Navy
        Me.lblVideoPixelsX.Location = New System.Drawing.Point(183, 97)
        Me.lblVideoPixelsX.Margin = New System.Windows.Forms.Padding(4)
        Me.lblVideoPixelsX.Name = "lblVideoPixelsX"
        Me.lblVideoPixelsX.Size = New System.Drawing.Size(23, 14)
        Me.lblVideoPixelsX.TabIndex = 117
        Me.lblVideoPixelsX.Text = "    "
        Me.lblVideoPixelsX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(9, 119)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 12)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "Pixels/Inch Y:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label86.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label86.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label86.Location = New System.Drawing.Point(9, 97)
        Me.Label86.Margin = New System.Windows.Forms.Padding(4)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(166, 14)
        Me.Label86.TabIndex = 109
        Me.Label86.Text = "Pixels/Inch X:"
        Me.Label86.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label64.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label64.Location = New System.Drawing.Point(9, 9)
        Me.Label64.Margin = New System.Windows.Forms.Padding(4)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(166, 14)
        Me.Label64.TabIndex = 97
        Me.Label64.Text = "Manufacturer:"
        Me.Label64.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label73.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label73.Location = New System.Drawing.Point(9, 31)
        Me.Label73.Margin = New System.Windows.Forms.Padding(4)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(166, 14)
        Me.Label73.TabIndex = 99
        Me.Label73.Text = "Model:"
        Me.Label73.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMonitorManufacturer
        '
        Me.lblMonitorManufacturer.AutoSize = True
        Me.lblMonitorManufacturer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMonitorManufacturer.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonitorManufacturer.ForeColor = System.Drawing.Color.Navy
        Me.lblMonitorManufacturer.Location = New System.Drawing.Point(183, 9)
        Me.lblMonitorManufacturer.Margin = New System.Windows.Forms.Padding(4)
        Me.lblMonitorManufacturer.Name = "lblMonitorManufacturer"
        Me.lblMonitorManufacturer.Size = New System.Drawing.Size(23, 14)
        Me.lblMonitorManufacturer.TabIndex = 98
        Me.lblMonitorManufacturer.Text = "    "
        Me.lblMonitorManufacturer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMonitorName
        '
        Me.lblMonitorName.AutoEllipsis = True
        Me.lblMonitorName.AutoSize = True
        Me.lblMonitorName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMonitorName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonitorName.ForeColor = System.Drawing.Color.Navy
        Me.lblMonitorName.Location = New System.Drawing.Point(183, 31)
        Me.lblMonitorName.Margin = New System.Windows.Forms.Padding(4)
        Me.lblMonitorName.Name = "lblMonitorName"
        Me.lblMonitorName.Size = New System.Drawing.Size(23, 14)
        Me.lblMonitorName.TabIndex = 100
        Me.lblMonitorName.Text = "    "
        Me.lblMonitorName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label59.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label59.Location = New System.Drawing.Point(9, 75)
        Me.Label59.Margin = New System.Windows.Forms.Padding(4)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(166, 14)
        Me.Label59.TabIndex = 93
        Me.Label59.Text = "Vertical Screen Resolution:"
        Me.Label59.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label61.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label61.Location = New System.Drawing.Point(9, 53)
        Me.Label61.Margin = New System.Windows.Forms.Padding(4)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(166, 14)
        Me.Label61.TabIndex = 91
        Me.Label61.Text = "Horizontal Screen Resolution:"
        Me.Label61.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVideoHorizontalRes
        '
        Me.lblVideoHorizontalRes.AutoSize = True
        Me.lblVideoHorizontalRes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblVideoHorizontalRes.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVideoHorizontalRes.ForeColor = System.Drawing.Color.Navy
        Me.lblVideoHorizontalRes.Location = New System.Drawing.Point(183, 53)
        Me.lblVideoHorizontalRes.Margin = New System.Windows.Forms.Padding(4)
        Me.lblVideoHorizontalRes.Name = "lblVideoHorizontalRes"
        Me.lblVideoHorizontalRes.Size = New System.Drawing.Size(23, 14)
        Me.lblVideoHorizontalRes.TabIndex = 92
        Me.lblVideoHorizontalRes.Text = "    "
        Me.lblVideoHorizontalRes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVideoVerticalRes
        '
        Me.lblVideoVerticalRes.AutoSize = True
        Me.lblVideoVerticalRes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblVideoVerticalRes.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVideoVerticalRes.ForeColor = System.Drawing.Color.Navy
        Me.lblVideoVerticalRes.Location = New System.Drawing.Point(183, 75)
        Me.lblVideoVerticalRes.Margin = New System.Windows.Forms.Padding(4)
        Me.lblVideoVerticalRes.Name = "lblVideoVerticalRes"
        Me.lblVideoVerticalRes.Size = New System.Drawing.Size(23, 14)
        Me.lblVideoVerticalRes.TabIndex = 94
        Me.lblVideoVerticalRes.Text = "    "
        Me.lblVideoVerticalRes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(10, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(398, 19)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "View information about your Computer's Video System"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.SysInfo.My.Resources.Resources.graphics_card
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(642, 368)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.TabIndex = 113
        Me.PictureBox1.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackgroundImage = Global.SysInfo.My.Resources.Resources.computer_monitor
        Me.PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox8.Location = New System.Drawing.Point(642, 90)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox8.TabIndex = 109
        Me.PictureBox8.TabStop = False
        '
        'cmbMonitors
        '
        Me.cmbMonitors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMonitors.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbMonitors.FormattingEnabled = True
        Me.cmbMonitors.Location = New System.Drawing.Point(49, 105)
        Me.cmbMonitors.Name = "cmbMonitors"
        Me.cmbMonitors.Size = New System.Drawing.Size(295, 22)
        Me.cmbMonitors.TabIndex = 114
        '
        'cmbVideoCards
        '
        Me.cmbVideoCards.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVideoCards.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbVideoCards.FormattingEnabled = True
        Me.cmbVideoCards.Location = New System.Drawing.Point(49, 379)
        Me.cmbVideoCards.Name = "cmbVideoCards"
        Me.cmbVideoCards.Size = New System.Drawing.Size(295, 22)
        Me.cmbVideoCards.TabIndex = 115
        '
        'DividerControl1
        '
        Me.DividerControl1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DividerControl1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DividerControl1.Location = New System.Drawing.Point(14, 336)
        Me.DividerControl1.Name = "DividerControl1"
        Me.DividerControl1.Size = New System.Drawing.Size(760, 23)
        Me.DividerControl1.TabIndex = 112
        Me.DividerControl1.Text = "Video Card"
        '
        'Divider2
        '
        Me.Divider2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Divider2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Divider2.Location = New System.Drawing.Point(10, 62)
        Me.Divider2.Name = "Divider2"
        Me.Divider2.Size = New System.Drawing.Size(760, 23)
        Me.Divider2.TabIndex = 111
        Me.Divider2.Text = "Monitor"
        '
        'UserControlVideo
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.cmbVideoCards)
        Me.Controls.Add(Me.cmbMonitors)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TableLayoutVideo)
        Me.Controls.Add(Me.DividerControl1)
        Me.Controls.Add(Me.Divider2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox8)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "UserControlVideo"
        Me.Size = New System.Drawing.Size(793, 668)
        Me.TableLayoutVideo.ResumeLayout(False)
        Me.TableLayoutVideo.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents TableLayoutVideo As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblVideoRefreshRate As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents lblVideoManufacturer As System.Windows.Forms.Label
    Friend WithEvents lblVideoCard As System.Windows.Forms.Label
    Friend WithEvents lblVideoMem As System.Windows.Forms.Label
    Friend WithEvents lblVideoDriverVersion As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblVideoColourDepth As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblVideoScanMode As System.Windows.Forms.Label
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents lblMonitorManufacturer As System.Windows.Forms.Label
    Friend WithEvents lblMonitorName As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents lblVideoHorizontalRes As System.Windows.Forms.Label
    Friend WithEvents lblVideoVerticalRes As System.Windows.Forms.Label
    Friend WithEvents Divider2 As SysInfo.CustomControls.DividerControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DividerControl1 As SysInfo.CustomControls.DividerControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmbMonitors As System.Windows.Forms.ComboBox
    Friend WithEvents cmbVideoCards As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblVideoPixelsY As System.Windows.Forms.Label
    Friend WithEvents lblVideoPixelsX As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
