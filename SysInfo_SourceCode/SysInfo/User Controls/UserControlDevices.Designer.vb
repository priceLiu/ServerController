<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlDevices
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
        Me.lblDevPnpId = New System.Windows.Forms.Label
        Me.Label66 = New System.Windows.Forms.Label
        Me.lblDevDriverPath = New System.Windows.Forms.Label
        Me.Label64 = New System.Windows.Forms.Label
        Me.lblDevService = New System.Windows.Forms.Label
        Me.Label68 = New System.Windows.Forms.Label
        Me.lblDevCategory = New System.Windows.Forms.Label
        Me.Label70 = New System.Windows.Forms.Label
        Me.lblDevManufacturer = New System.Windows.Forms.Label
        Me.Label72 = New System.Windows.Forms.Label
        Me.lstDevices = New System.Windows.Forms.ListView
        Me.colDevice = New System.Windows.Forms.ColumnHeader
        Me.Label3 = New System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.lblDevDriverVersion = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblDevClassGuid = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Divider2 = New SysInfo.CustomControls.DividerControl
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDevPnpId
        '
        Me.lblDevPnpId.AutoEllipsis = True
        Me.lblDevPnpId.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDevPnpId.ForeColor = System.Drawing.Color.Navy
        Me.lblDevPnpId.Location = New System.Drawing.Point(101, 114)
        Me.lblDevPnpId.Margin = New System.Windows.Forms.Padding(4)
        Me.lblDevPnpId.Name = "lblDevPnpId"
        Me.lblDevPnpId.Size = New System.Drawing.Size(618, 14)
        Me.lblDevPnpId.TabIndex = 0
        Me.lblDevPnpId.Text = "    "
        Me.lblDevPnpId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label66.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.Location = New System.Drawing.Point(4, 114)
        Me.Label66.Margin = New System.Windows.Forms.Padding(4)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(89, 14)
        Me.Label66.TabIndex = 0
        Me.Label66.Text = "PNP Device ID:"
        Me.Label66.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDevDriverPath
        '
        Me.lblDevDriverPath.AutoSize = True
        Me.lblDevDriverPath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDevDriverPath.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDevDriverPath.ForeColor = System.Drawing.Color.Navy
        Me.lblDevDriverPath.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblDevDriverPath.Location = New System.Drawing.Point(101, 48)
        Me.lblDevDriverPath.Margin = New System.Windows.Forms.Padding(4)
        Me.lblDevDriverPath.Name = "lblDevDriverPath"
        Me.lblDevDriverPath.Size = New System.Drawing.Size(618, 14)
        Me.lblDevDriverPath.TabIndex = 0
        Me.lblDevDriverPath.Text = "    "
        Me.lblDevDriverPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label64.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(4, 48)
        Me.Label64.Margin = New System.Windows.Forms.Padding(4)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(89, 14)
        Me.Label64.TabIndex = 0
        Me.Label64.Text = "Driver Path:"
        Me.Label64.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDevService
        '
        Me.lblDevService.AutoSize = True
        Me.lblDevService.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDevService.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDevService.ForeColor = System.Drawing.Color.Navy
        Me.lblDevService.Location = New System.Drawing.Point(101, 92)
        Me.lblDevService.Margin = New System.Windows.Forms.Padding(4)
        Me.lblDevService.Name = "lblDevService"
        Me.lblDevService.Size = New System.Drawing.Size(618, 14)
        Me.lblDevService.TabIndex = 0
        Me.lblDevService.Text = "    "
        Me.lblDevService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label68.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.Location = New System.Drawing.Point(4, 92)
        Me.Label68.Margin = New System.Windows.Forms.Padding(4)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(89, 14)
        Me.Label68.TabIndex = 0
        Me.Label68.Text = "Service:"
        Me.Label68.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDevCategory
        '
        Me.lblDevCategory.AutoSize = True
        Me.lblDevCategory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDevCategory.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDevCategory.ForeColor = System.Drawing.Color.Navy
        Me.lblDevCategory.Location = New System.Drawing.Point(101, 4)
        Me.lblDevCategory.Margin = New System.Windows.Forms.Padding(4)
        Me.lblDevCategory.Name = "lblDevCategory"
        Me.lblDevCategory.Size = New System.Drawing.Size(618, 14)
        Me.lblDevCategory.TabIndex = 0
        Me.lblDevCategory.Text = "    "
        Me.lblDevCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label70.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.Location = New System.Drawing.Point(4, 4)
        Me.Label70.Margin = New System.Windows.Forms.Padding(4)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(89, 14)
        Me.Label70.TabIndex = 0
        Me.Label70.Text = "Category:"
        Me.Label70.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDevManufacturer
        '
        Me.lblDevManufacturer.AutoSize = True
        Me.lblDevManufacturer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDevManufacturer.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDevManufacturer.ForeColor = System.Drawing.Color.Navy
        Me.lblDevManufacturer.Location = New System.Drawing.Point(101, 26)
        Me.lblDevManufacturer.Margin = New System.Windows.Forms.Padding(4)
        Me.lblDevManufacturer.Name = "lblDevManufacturer"
        Me.lblDevManufacturer.Size = New System.Drawing.Size(618, 14)
        Me.lblDevManufacturer.TabIndex = 0
        Me.lblDevManufacturer.Text = "    "
        Me.lblDevManufacturer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label72.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.Location = New System.Drawing.Point(4, 26)
        Me.Label72.Margin = New System.Windows.Forms.Padding(4)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(89, 14)
        Me.Label72.TabIndex = 0
        Me.Label72.Text = "Manufacturer:"
        Me.Label72.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lstDevices
        '
        Me.lstDevices.BackColor = System.Drawing.Color.White
        Me.lstDevices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstDevices.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colDevice})
        Me.lstDevices.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDevices.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstDevices.Location = New System.Drawing.Point(49, 90)
        Me.lstDevices.MultiSelect = False
        Me.lstDevices.Name = "lstDevices"
        Me.lstDevices.Size = New System.Drawing.Size(440, 155)
        Me.lstDevices.TabIndex = 0
        Me.lstDevices.TabStop = False
        Me.lstDevices.UseCompatibleStateImageBehavior = False
        Me.lstDevices.View = System.Windows.Forms.View.Details
        '
        'colDevice
        '
        Me.colDevice.Text = "Device"
        Me.colDevice.Width = 420
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(10, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(336, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "View information about your System's Devices"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDevDriverVersion, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label70, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label72, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label64, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDevDriverPath, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDevCategory, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDevManufacturer, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label66, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label68, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDevClassGuid, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDevPnpId, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDevService, 1, 4)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(49, 271)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(723, 154)
        Me.TableLayoutPanel1.TabIndex = 87
        '
        'lblDevDriverVersion
        '
        Me.lblDevDriverVersion.AutoEllipsis = True
        Me.lblDevDriverVersion.AutoSize = True
        Me.lblDevDriverVersion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDevDriverVersion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDevDriverVersion.ForeColor = System.Drawing.Color.Navy
        Me.lblDevDriverVersion.Location = New System.Drawing.Point(101, 70)
        Me.lblDevDriverVersion.Margin = New System.Windows.Forms.Padding(4)
        Me.lblDevDriverVersion.Name = "lblDevDriverVersion"
        Me.lblDevDriverVersion.Size = New System.Drawing.Size(618, 14)
        Me.lblDevDriverVersion.TabIndex = 0
        Me.lblDevDriverVersion.Text = "    "
        Me.lblDevDriverVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 136)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Class Guid:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 70)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Driver Version:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDevClassGuid
        '
        Me.lblDevClassGuid.AutoEllipsis = True
        Me.lblDevClassGuid.AutoSize = True
        Me.lblDevClassGuid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDevClassGuid.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDevClassGuid.ForeColor = System.Drawing.Color.Navy
        Me.lblDevClassGuid.Location = New System.Drawing.Point(101, 136)
        Me.lblDevClassGuid.Margin = New System.Windows.Forms.Padding(4)
        Me.lblDevClassGuid.Name = "lblDevClassGuid"
        Me.lblDevClassGuid.Size = New System.Drawing.Size(618, 14)
        Me.lblDevClassGuid.TabIndex = 0
        Me.lblDevClassGuid.Text = "    "
        Me.lblDevClassGuid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.SysInfo.My.Resources.Resources.Devices
        Me.PictureBox1.Location = New System.Drawing.Point(642, 90)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.TabIndex = 88
        Me.PictureBox1.TabStop = False
        '
        'Divider2
        '
        Me.Divider2.AllowDrop = True
        Me.Divider2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Divider2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Divider2.Location = New System.Drawing.Point(10, 62)
        Me.Divider2.Name = "Divider2"
        Me.Divider2.Size = New System.Drawing.Size(760, 23)
        Me.Divider2.TabIndex = 0
        Me.Divider2.TabStop = False
        Me.Divider2.Text = "Devices"
        '
        'UserControlDevices
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Divider2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstDevices)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "UserControlDevices"
        Me.Size = New System.Drawing.Size(793, 668)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDevPnpId As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents lblDevDriverPath As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents lblDevService As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents lblDevCategory As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents lblDevManufacturer As System.Windows.Forms.Label
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents lstDevices As System.Windows.Forms.ListView
    Friend WithEvents colDevice As System.Windows.Forms.ColumnHeader
    Friend WithEvents Divider2 As SysInfo.CustomControls.DividerControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblDevClassGuid As System.Windows.Forms.Label
    Friend WithEvents lblDevDriverVersion As System.Windows.Forms.Label

End Class
