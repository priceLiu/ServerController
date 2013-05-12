<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlProcessor
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
        Me.TableLayoutProcessor = New System.Windows.Forms.TableLayoutPanel
        Me.lblCPUL1CacheSize = New System.Windows.Forms.Label
        Me.Label79 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblCPUVendor = New System.Windows.Forms.Label
        Me.lblCPUVoltage = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblCPUDataWidth = New System.Windows.Forms.Label
        Me.lblCPUAddressWidth = New System.Windows.Forms.Label
        Me.lblCPUExtClkSpeed = New System.Windows.Forms.Label
        Me.Label68 = New System.Windows.Forms.Label
        Me.Label66 = New System.Windows.Forms.Label
        Me.lblCPUCurrentSpeed = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblCPUL3CacheSize = New System.Windows.Forms.Label
        Me.Label69 = New System.Windows.Forms.Label
        Me.Label77 = New System.Windows.Forms.Label
        Me.Label71 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblCPUName = New System.Windows.Forms.Label
        Me.Label78 = New System.Windows.Forms.Label
        Me.lblCPUL2CacheSize = New System.Windows.Forms.Label
        Me.lblCPUIdent = New System.Windows.Forms.Label
        Me.Label76 = New System.Windows.Forms.Label
        Me.lblCPUArchitecture = New System.Windows.Forms.Label
        Me.lblCPUCores = New System.Windows.Forms.Label
        Me.Label75 = New System.Windows.Forms.Label
        Me.Label72 = New System.Windows.Forms.Label
        Me.Label70 = New System.Windows.Forms.Label
        Me.lblCPUSocket = New System.Windows.Forms.Label
        Me.lblCPUMaxSpeed = New System.Windows.Forms.Label
        Me.pctCPULogo = New System.Windows.Forms.PictureBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Divider6 = New SysInfo.CustomControls.DividerControl
        Me.Divider5 = New SysInfo.CustomControls.DividerControl
        Me.Divider4 = New SysInfo.CustomControls.DividerControl
        Me.Divider3 = New SysInfo.CustomControls.DividerControl
        Me.Divider1 = New SysInfo.CustomControls.DividerControl
        Me.Divider2 = New SysInfo.CustomControls.DividerControl
        Me.TableLayoutProcessor.SuspendLayout()
        CType(Me.pctCPULogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutProcessor
        '
        Me.TableLayoutProcessor.AutoSize = True
        Me.TableLayoutProcessor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutProcessor.ColumnCount = 2
        Me.TableLayoutProcessor.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutProcessor.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutProcessor.Controls.Add(Me.lblCPUL1CacheSize, 1, 9)
        Me.TableLayoutProcessor.Controls.Add(Me.Label79, 0, 0)
        Me.TableLayoutProcessor.Controls.Add(Me.Label2, 0, 9)
        Me.TableLayoutProcessor.Controls.Add(Me.lblCPUVendor, 1, 0)
        Me.TableLayoutProcessor.Controls.Add(Me.lblCPUVoltage, 1, 20)
        Me.TableLayoutProcessor.Controls.Add(Me.Label1, 0, 20)
        Me.TableLayoutProcessor.Controls.Add(Me.lblCPUDataWidth, 1, 17)
        Me.TableLayoutProcessor.Controls.Add(Me.lblCPUAddressWidth, 1, 18)
        Me.TableLayoutProcessor.Controls.Add(Me.lblCPUExtClkSpeed, 1, 15)
        Me.TableLayoutProcessor.Controls.Add(Me.Label68, 0, 17)
        Me.TableLayoutProcessor.Controls.Add(Me.Label66, 0, 18)
        Me.TableLayoutProcessor.Controls.Add(Me.lblCPUCurrentSpeed, 1, 13)
        Me.TableLayoutProcessor.Controls.Add(Me.Label4, 0, 15)
        Me.TableLayoutProcessor.Controls.Add(Me.lblCPUL3CacheSize, 1, 11)
        Me.TableLayoutProcessor.Controls.Add(Me.Label69, 0, 13)
        Me.TableLayoutProcessor.Controls.Add(Me.Label77, 0, 14)
        Me.TableLayoutProcessor.Controls.Add(Me.Label71, 0, 11)
        Me.TableLayoutProcessor.Controls.Add(Me.Label6, 0, 1)
        Me.TableLayoutProcessor.Controls.Add(Me.lblCPUName, 1, 1)
        Me.TableLayoutProcessor.Controls.Add(Me.Label78, 0, 2)
        Me.TableLayoutProcessor.Controls.Add(Me.lblCPUL2CacheSize, 1, 10)
        Me.TableLayoutProcessor.Controls.Add(Me.lblCPUIdent, 1, 2)
        Me.TableLayoutProcessor.Controls.Add(Me.Label76, 0, 4)
        Me.TableLayoutProcessor.Controls.Add(Me.lblCPUArchitecture, 1, 4)
        Me.TableLayoutProcessor.Controls.Add(Me.lblCPUCores, 1, 5)
        Me.TableLayoutProcessor.Controls.Add(Me.Label75, 0, 5)
        Me.TableLayoutProcessor.Controls.Add(Me.Label72, 0, 10)
        Me.TableLayoutProcessor.Controls.Add(Me.Label70, 0, 7)
        Me.TableLayoutProcessor.Controls.Add(Me.lblCPUSocket, 1, 7)
        Me.TableLayoutProcessor.Controls.Add(Me.lblCPUMaxSpeed, 1, 14)
        Me.TableLayoutProcessor.Location = New System.Drawing.Point(49, 90)
        Me.TableLayoutProcessor.Name = "TableLayoutProcessor"
        Me.TableLayoutProcessor.RowCount = 21
        Me.TableLayoutProcessor.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutProcessor.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutProcessor.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutProcessor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutProcessor.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutProcessor.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutProcessor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0.0!))
        Me.TableLayoutProcessor.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutProcessor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutProcessor.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutProcessor.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutProcessor.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutProcessor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutProcessor.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutProcessor.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutProcessor.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutProcessor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutProcessor.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutProcessor.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutProcessor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutProcessor.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutProcessor.Size = New System.Drawing.Size(162, 530)
        Me.TableLayoutProcessor.TabIndex = 69
        '
        'lblCPUL1CacheSize
        '
        Me.lblCPUL1CacheSize.AutoSize = True
        Me.lblCPUL1CacheSize.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCPUL1CacheSize.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPUL1CacheSize.ForeColor = System.Drawing.Color.Navy
        Me.lblCPUL1CacheSize.Location = New System.Drawing.Point(135, 216)
        Me.lblCPUL1CacheSize.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCPUL1CacheSize.Name = "lblCPUL1CacheSize"
        Me.lblCPUL1CacheSize.Size = New System.Drawing.Size(23, 14)
        Me.lblCPUL1CacheSize.TabIndex = 86
        Me.lblCPUL1CacheSize.Text = "    "
        Me.lblCPUL1CacheSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label79.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.Location = New System.Drawing.Point(4, 4)
        Me.Label79.Margin = New System.Windows.Forms.Padding(4)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(123, 14)
        Me.Label79.TabIndex = 47
        Me.Label79.Text = "Manufacturer:"
        Me.Label79.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 216)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 14)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "L1 Cache Size:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCPUVendor
        '
        Me.lblCPUVendor.AutoSize = True
        Me.lblCPUVendor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCPUVendor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPUVendor.ForeColor = System.Drawing.Color.Navy
        Me.lblCPUVendor.Location = New System.Drawing.Point(135, 4)
        Me.lblCPUVendor.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCPUVendor.Name = "lblCPUVendor"
        Me.lblCPUVendor.Size = New System.Drawing.Size(23, 14)
        Me.lblCPUVendor.TabIndex = 48
        Me.lblCPUVendor.Text = "    "
        Me.lblCPUVendor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCPUVoltage
        '
        Me.lblCPUVoltage.AutoSize = True
        Me.lblCPUVoltage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCPUVoltage.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPUVoltage.ForeColor = System.Drawing.Color.Navy
        Me.lblCPUVoltage.Location = New System.Drawing.Point(135, 512)
        Me.lblCPUVoltage.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCPUVoltage.Name = "lblCPUVoltage"
        Me.lblCPUVoltage.Size = New System.Drawing.Size(23, 14)
        Me.lblCPUVoltage.TabIndex = 84
        Me.lblCPUVoltage.Text = "    "
        Me.lblCPUVoltage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 512)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 14)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Current Voltage:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCPUDataWidth
        '
        Me.lblCPUDataWidth.AutoSize = True
        Me.lblCPUDataWidth.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCPUDataWidth.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPUDataWidth.ForeColor = System.Drawing.Color.Navy
        Me.lblCPUDataWidth.Location = New System.Drawing.Point(135, 428)
        Me.lblCPUDataWidth.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCPUDataWidth.Name = "lblCPUDataWidth"
        Me.lblCPUDataWidth.Size = New System.Drawing.Size(23, 14)
        Me.lblCPUDataWidth.TabIndex = 66
        Me.lblCPUDataWidth.Text = "    "
        Me.lblCPUDataWidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCPUAddressWidth
        '
        Me.lblCPUAddressWidth.AutoSize = True
        Me.lblCPUAddressWidth.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCPUAddressWidth.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPUAddressWidth.ForeColor = System.Drawing.Color.Navy
        Me.lblCPUAddressWidth.Location = New System.Drawing.Point(135, 450)
        Me.lblCPUAddressWidth.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCPUAddressWidth.Name = "lblCPUAddressWidth"
        Me.lblCPUAddressWidth.Size = New System.Drawing.Size(23, 14)
        Me.lblCPUAddressWidth.TabIndex = 68
        Me.lblCPUAddressWidth.Text = "    "
        Me.lblCPUAddressWidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCPUExtClkSpeed
        '
        Me.lblCPUExtClkSpeed.AutoEllipsis = True
        Me.lblCPUExtClkSpeed.AutoSize = True
        Me.lblCPUExtClkSpeed.BackColor = System.Drawing.Color.Transparent
        Me.lblCPUExtClkSpeed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCPUExtClkSpeed.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPUExtClkSpeed.ForeColor = System.Drawing.Color.Navy
        Me.lblCPUExtClkSpeed.Location = New System.Drawing.Point(135, 366)
        Me.lblCPUExtClkSpeed.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCPUExtClkSpeed.Name = "lblCPUExtClkSpeed"
        Me.lblCPUExtClkSpeed.Size = New System.Drawing.Size(23, 14)
        Me.lblCPUExtClkSpeed.TabIndex = 11
        Me.lblCPUExtClkSpeed.Text = "    "
        Me.lblCPUExtClkSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label68.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.Location = New System.Drawing.Point(4, 428)
        Me.Label68.Margin = New System.Windows.Forms.Padding(4)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(123, 14)
        Me.Label68.TabIndex = 65
        Me.Label68.Text = "Data Width:"
        Me.Label68.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label66.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.Location = New System.Drawing.Point(4, 450)
        Me.Label66.Margin = New System.Windows.Forms.Padding(4)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(123, 14)
        Me.Label66.TabIndex = 67
        Me.Label66.Text = "Address Width:"
        Me.Label66.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCPUCurrentSpeed
        '
        Me.lblCPUCurrentSpeed.AutoSize = True
        Me.lblCPUCurrentSpeed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCPUCurrentSpeed.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPUCurrentSpeed.ForeColor = System.Drawing.Color.Navy
        Me.lblCPUCurrentSpeed.Location = New System.Drawing.Point(135, 322)
        Me.lblCPUCurrentSpeed.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCPUCurrentSpeed.Name = "lblCPUCurrentSpeed"
        Me.lblCPUCurrentSpeed.Size = New System.Drawing.Size(23, 14)
        Me.lblCPUCurrentSpeed.TabIndex = 64
        Me.lblCPUCurrentSpeed.Text = "    "
        Me.lblCPUCurrentSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(4, 366)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 14)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "FSB Speed:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCPUL3CacheSize
        '
        Me.lblCPUL3CacheSize.AutoSize = True
        Me.lblCPUL3CacheSize.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCPUL3CacheSize.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPUL3CacheSize.ForeColor = System.Drawing.Color.Navy
        Me.lblCPUL3CacheSize.Location = New System.Drawing.Point(135, 260)
        Me.lblCPUL3CacheSize.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCPUL3CacheSize.Name = "lblCPUL3CacheSize"
        Me.lblCPUL3CacheSize.Size = New System.Drawing.Size(23, 14)
        Me.lblCPUL3CacheSize.TabIndex = 60
        Me.lblCPUL3CacheSize.Text = "    "
        Me.lblCPUL3CacheSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label69.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.Location = New System.Drawing.Point(4, 322)
        Me.Label69.Margin = New System.Windows.Forms.Padding(4)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(123, 14)
        Me.Label69.TabIndex = 63
        Me.Label69.Text = "Current Clock Speed:"
        Me.Label69.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label77.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.Location = New System.Drawing.Point(4, 344)
        Me.Label77.Margin = New System.Windows.Forms.Padding(4)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(123, 14)
        Me.Label77.TabIndex = 51
        Me.Label77.Text = "Max Clock Speed:"
        Me.Label77.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label71.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.Location = New System.Drawing.Point(4, 260)
        Me.Label71.Margin = New System.Windows.Forms.Padding(4)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(123, 14)
        Me.Label71.TabIndex = 59
        Me.Label71.Text = "L3 Cache Size:"
        Me.Label71.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(4, 26)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 14)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Processor:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCPUName
        '
        Me.lblCPUName.AutoEllipsis = True
        Me.lblCPUName.AutoSize = True
        Me.lblCPUName.BackColor = System.Drawing.Color.Transparent
        Me.lblCPUName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCPUName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPUName.ForeColor = System.Drawing.Color.Navy
        Me.lblCPUName.Location = New System.Drawing.Point(135, 26)
        Me.lblCPUName.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCPUName.Name = "lblCPUName"
        Me.lblCPUName.Size = New System.Drawing.Size(23, 14)
        Me.lblCPUName.TabIndex = 8
        Me.lblCPUName.Text = "    "
        Me.lblCPUName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label78.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.Location = New System.Drawing.Point(4, 48)
        Me.Label78.Margin = New System.Windows.Forms.Padding(4)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(123, 14)
        Me.Label78.TabIndex = 49
        Me.Label78.Text = "Identifier:"
        Me.Label78.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCPUL2CacheSize
        '
        Me.lblCPUL2CacheSize.AutoSize = True
        Me.lblCPUL2CacheSize.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCPUL2CacheSize.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPUL2CacheSize.ForeColor = System.Drawing.Color.Navy
        Me.lblCPUL2CacheSize.Location = New System.Drawing.Point(135, 238)
        Me.lblCPUL2CacheSize.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCPUL2CacheSize.Name = "lblCPUL2CacheSize"
        Me.lblCPUL2CacheSize.Size = New System.Drawing.Size(23, 14)
        Me.lblCPUL2CacheSize.TabIndex = 58
        Me.lblCPUL2CacheSize.Text = "    "
        Me.lblCPUL2CacheSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCPUIdent
        '
        Me.lblCPUIdent.AutoSize = True
        Me.lblCPUIdent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCPUIdent.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPUIdent.ForeColor = System.Drawing.Color.Navy
        Me.lblCPUIdent.Location = New System.Drawing.Point(135, 48)
        Me.lblCPUIdent.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCPUIdent.Name = "lblCPUIdent"
        Me.lblCPUIdent.Size = New System.Drawing.Size(23, 14)
        Me.lblCPUIdent.TabIndex = 50
        Me.lblCPUIdent.Text = "    "
        Me.lblCPUIdent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label76.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label76.Location = New System.Drawing.Point(4, 110)
        Me.Label76.Margin = New System.Windows.Forms.Padding(4)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(123, 14)
        Me.Label76.TabIndex = 53
        Me.Label76.Text = "Architecture:"
        Me.Label76.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCPUArchitecture
        '
        Me.lblCPUArchitecture.AutoSize = True
        Me.lblCPUArchitecture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCPUArchitecture.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPUArchitecture.ForeColor = System.Drawing.Color.Navy
        Me.lblCPUArchitecture.Location = New System.Drawing.Point(135, 110)
        Me.lblCPUArchitecture.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCPUArchitecture.Name = "lblCPUArchitecture"
        Me.lblCPUArchitecture.Size = New System.Drawing.Size(23, 14)
        Me.lblCPUArchitecture.TabIndex = 54
        Me.lblCPUArchitecture.Text = "    "
        Me.lblCPUArchitecture.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCPUCores
        '
        Me.lblCPUCores.AutoEllipsis = True
        Me.lblCPUCores.AutoSize = True
        Me.lblCPUCores.BackColor = System.Drawing.Color.Transparent
        Me.lblCPUCores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCPUCores.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPUCores.ForeColor = System.Drawing.Color.Navy
        Me.lblCPUCores.Location = New System.Drawing.Point(135, 132)
        Me.lblCPUCores.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCPUCores.Name = "lblCPUCores"
        Me.lblCPUCores.Size = New System.Drawing.Size(23, 14)
        Me.lblCPUCores.TabIndex = 10
        Me.lblCPUCores.Text = "    "
        Me.lblCPUCores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label75.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.Location = New System.Drawing.Point(4, 132)
        Me.Label75.Margin = New System.Windows.Forms.Padding(4)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(123, 14)
        Me.Label75.TabIndex = 55
        Me.Label75.Text = "No. Of Cores:"
        Me.Label75.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label72.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.Location = New System.Drawing.Point(4, 238)
        Me.Label72.Margin = New System.Windows.Forms.Padding(4)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(123, 14)
        Me.Label72.TabIndex = 57
        Me.Label72.Text = "L2 Cache Size:"
        Me.Label72.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label70.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.Location = New System.Drawing.Point(4, 154)
        Me.Label70.Margin = New System.Windows.Forms.Padding(4)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(123, 14)
        Me.Label70.TabIndex = 61
        Me.Label70.Text = "Socket Type:"
        Me.Label70.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCPUSocket
        '
        Me.lblCPUSocket.AutoSize = True
        Me.lblCPUSocket.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCPUSocket.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPUSocket.ForeColor = System.Drawing.Color.Navy
        Me.lblCPUSocket.Location = New System.Drawing.Point(135, 154)
        Me.lblCPUSocket.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCPUSocket.Name = "lblCPUSocket"
        Me.lblCPUSocket.Size = New System.Drawing.Size(23, 14)
        Me.lblCPUSocket.TabIndex = 62
        Me.lblCPUSocket.Text = "    "
        Me.lblCPUSocket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCPUMaxSpeed
        '
        Me.lblCPUMaxSpeed.AutoSize = True
        Me.lblCPUMaxSpeed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCPUMaxSpeed.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPUMaxSpeed.ForeColor = System.Drawing.Color.Navy
        Me.lblCPUMaxSpeed.Location = New System.Drawing.Point(135, 344)
        Me.lblCPUMaxSpeed.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCPUMaxSpeed.Name = "lblCPUMaxSpeed"
        Me.lblCPUMaxSpeed.Size = New System.Drawing.Size(23, 14)
        Me.lblCPUMaxSpeed.TabIndex = 52
        Me.lblCPUMaxSpeed.Text = "    "
        Me.lblCPUMaxSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pctCPULogo
        '
        Me.pctCPULogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pctCPULogo.Location = New System.Drawing.Point(645, 90)
        Me.pctCPULogo.Name = "pctCPULogo"
        Me.pctCPULogo.Size = New System.Drawing.Size(128, 128)
        Me.pctCPULogo.TabIndex = 72
        Me.pctCPULogo.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(10, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(370, 19)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "View information about your Computer's Processor"
        '
        'Divider6
        '
        Me.Divider6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Divider6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Divider6.Location = New System.Drawing.Point(14, 572)
        Me.Divider6.Name = "Divider6"
        Me.Divider6.Size = New System.Drawing.Size(760, 23)
        Me.Divider6.TabIndex = 88
        Me.Divider6.Text = "Core Voltage"
        '
        'Divider5
        '
        Me.Divider5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Divider5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Divider5.Location = New System.Drawing.Point(14, 488)
        Me.Divider5.Name = "Divider5"
        Me.Divider5.Size = New System.Drawing.Size(760, 23)
        Me.Divider5.TabIndex = 87
        Me.Divider5.Text = "Address and Data Widths"
        '
        'Divider4
        '
        Me.Divider4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Divider4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Divider4.Location = New System.Drawing.Point(14, 382)
        Me.Divider4.Name = "Divider4"
        Me.Divider4.Size = New System.Drawing.Size(760, 23)
        Me.Divider4.TabIndex = 86
        Me.Divider4.Text = "Clock Speeds"
        '
        'Divider3
        '
        Me.Divider3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Divider3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Divider3.Location = New System.Drawing.Point(14, 276)
        Me.Divider3.Name = "Divider3"
        Me.Divider3.Size = New System.Drawing.Size(760, 23)
        Me.Divider3.TabIndex = 85
        Me.Divider3.Text = "Processor Caches"
        '
        'Divider1
        '
        Me.Divider1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Divider1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Divider1.Location = New System.Drawing.Point(14, 170)
        Me.Divider1.Name = "Divider1"
        Me.Divider1.Size = New System.Drawing.Size(625, 23)
        Me.Divider1.TabIndex = 84
        Me.Divider1.Text = "Architecture, Number of Cores and Socket Type"
        '
        'Divider2
        '
        Me.Divider2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Divider2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Divider2.Location = New System.Drawing.Point(13, 61)
        Me.Divider2.Name = "Divider2"
        Me.Divider2.Size = New System.Drawing.Size(760, 23)
        Me.Divider2.TabIndex = 83
        Me.Divider2.Text = "Processor"
        '
        'UserControlProcessor
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Divider6)
        Me.Controls.Add(Me.Divider5)
        Me.Controls.Add(Me.Divider4)
        Me.Controls.Add(Me.Divider3)
        Me.Controls.Add(Me.pctCPULogo)
        Me.Controls.Add(Me.Divider1)
        Me.Controls.Add(Me.TableLayoutProcessor)
        Me.Controls.Add(Me.Divider2)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "UserControlProcessor"
        Me.Size = New System.Drawing.Size(793, 668)
        Me.TableLayoutProcessor.ResumeLayout(False)
        Me.TableLayoutProcessor.PerformLayout()
        CType(Me.pctCPULogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutProcessor As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents lblCPUAddressWidth As System.Windows.Forms.Label
    Friend WithEvents lblCPUVendor As System.Windows.Forms.Label
    Friend WithEvents lblCPUDataWidth As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblCPUName As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents lblCPUExtClkSpeed As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblCPUIdent As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents lblCPUMaxSpeed As System.Windows.Forms.Label
    Friend WithEvents lblCPUL3CacheSize As System.Windows.Forms.Label
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents lblCPUSocket As System.Windows.Forms.Label
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents lblCPUL2CacheSize As System.Windows.Forms.Label
    Friend WithEvents lblCPUArchitecture As System.Windows.Forms.Label
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents lblCPUCores As System.Windows.Forms.Label
    Friend WithEvents lblCPUCurrentSpeed As System.Windows.Forms.Label
    Friend WithEvents pctCPULogo As System.Windows.Forms.PictureBox
    Friend WithEvents Divider2 As SysInfo.CustomControls.DividerControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblCPUVoltage As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblCPUL1CacheSize As System.Windows.Forms.Label
    Friend WithEvents Divider1 As SysInfo.CustomControls.DividerControl
    Friend WithEvents Divider3 As SysInfo.CustomControls.DividerControl
    Friend WithEvents Divider4 As SysInfo.CustomControls.DividerControl
    Friend WithEvents Divider5 As SysInfo.CustomControls.DividerControl
    Friend WithEvents Divider6 As SysInfo.CustomControls.DividerControl

End Class
