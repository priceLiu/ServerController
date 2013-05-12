<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlDrivers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControlDrivers))
        Me.Label3 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lstDrivers = New System.Windows.Forms.ListView
        Me.colDriverName = New System.Windows.Forms.ColumnHeader
        Me.colDriverPath = New System.Windows.Forms.ColumnHeader
        Me.colDriverType = New System.Windows.Forms.ColumnHeader
        Me.colDriverStartMode = New System.Windows.Forms.ColumnHeader
        Me.lblDescription = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblPublisher = New System.Windows.Forms.Label
        Me.Divider2 = New SysInfo.CustomControls.DividerControl
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(10, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(384, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "View information about your System's Device Drivers"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.SysInfo.My.Resources.Resources.driver
        Me.PictureBox1.Location = New System.Drawing.Point(642, 90)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.TabIndex = 89
        Me.PictureBox1.TabStop = False
        '
        'lstDrivers
        '
        Me.lstDrivers.BackColor = System.Drawing.Color.White
        Me.lstDrivers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstDrivers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colDriverName, Me.colDriverPath, Me.colDriverType, Me.colDriverStartMode})
        Me.lstDrivers.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDrivers.FullRowSelect = True
        Me.lstDrivers.GridLines = True
        Me.lstDrivers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstDrivers.Location = New System.Drawing.Point(49, 248)
        Me.lstDrivers.MultiSelect = False
        Me.lstDrivers.Name = "lstDrivers"
        Me.lstDrivers.ShowItemToolTips = True
        Me.lstDrivers.Size = New System.Drawing.Size(721, 282)
        Me.lstDrivers.TabIndex = 0
        Me.lstDrivers.TabStop = False
        Me.lstDrivers.UseCompatibleStateImageBehavior = False
        Me.lstDrivers.View = System.Windows.Forms.View.Details
        '
        'colDriverName
        '
        Me.colDriverName.Text = "Name"
        Me.colDriverName.Width = 120
        '
        'colDriverPath
        '
        Me.colDriverPath.Text = "Driver Path"
        Me.colDriverPath.Width = 320
        '
        'colDriverType
        '
        Me.colDriverType.Text = "Type"
        Me.colDriverType.Width = 120
        '
        'colDriverStartMode
        '
        Me.colDriverStartMode.Text = "Start Mode"
        Me.colDriverStartMode.Width = 120
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.ForeColor = System.Drawing.Color.Navy
        Me.lblDescription.Location = New System.Drawing.Point(167, 542)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(27, 14)
        Me.lblDescription.TabIndex = 0
        Me.lblDescription.Text = "     "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 542)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Driver Description:"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(49, 92)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(556, 126)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 560)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Driver Publisher:"
        '
        'lblPublisher
        '
        Me.lblPublisher.AutoSize = True
        Me.lblPublisher.ForeColor = System.Drawing.Color.Navy
        Me.lblPublisher.Location = New System.Drawing.Point(167, 560)
        Me.lblPublisher.Name = "lblPublisher"
        Me.lblPublisher.Size = New System.Drawing.Size(27, 14)
        Me.lblPublisher.TabIndex = 0
        Me.lblPublisher.Text = "     "
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
        Me.Divider2.Text = "System Drivers"
        '
        'UserControlDrivers
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblPublisher)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lstDrivers)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Divider2)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "UserControlDrivers"
        Me.Size = New System.Drawing.Size(793, 668)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Divider2 As SysInfo.CustomControls.DividerControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lstDrivers As System.Windows.Forms.ListView
    Friend WithEvents colDriverName As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDriverPath As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDriverType As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDriverStartMode As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblPublisher As System.Windows.Forms.Label

End Class
