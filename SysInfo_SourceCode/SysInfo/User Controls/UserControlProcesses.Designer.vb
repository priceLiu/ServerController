<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlProcesses
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControlProcesses))
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lstProcesses = New System.Windows.Forms.ListView
        Me.colProcesses = New System.Windows.Forms.ColumnHeader
        Me.colPid = New System.Windows.Forms.ColumnHeader
        Me.colOwner = New System.Windows.Forms.ColumnHeader
        Me.colPriority = New System.Windows.Forms.ColumnHeader
        Me.colThreads = New System.Windows.Forms.ColumnHeader
        Me.colHandles = New System.Windows.Forms.ColumnHeader
        Me.lblProcessesFound = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblCommandLine = New System.Windows.Forms.Label
        Me.btnAdditionalInfo = New System.Windows.Forms.Button
        Me.ToolTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.Divider2 = New SysInfo.CustomControls.DividerControl
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(10, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(448, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "View information on the Processes running on your Computer"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.SysInfo.My.Resources.Resources.Processes
        Me.PictureBox1.Location = New System.Drawing.Point(645, 90)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.TabIndex = 90
        Me.PictureBox1.TabStop = False
        '
        'lstProcesses
        '
        Me.lstProcesses.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lstProcesses.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
        Me.lstProcesses.BackColor = System.Drawing.Color.White
        Me.lstProcesses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstProcesses.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colProcesses, Me.colPid, Me.colOwner, Me.colPriority, Me.colThreads, Me.colHandles})
        Me.lstProcesses.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstProcesses.FullRowSelect = True
        Me.lstProcesses.GridLines = True
        Me.lstProcesses.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstProcesses.Location = New System.Drawing.Point(48, 231)
        Me.lstProcesses.MultiSelect = False
        Me.lstProcesses.Name = "lstProcesses"
        Me.lstProcesses.ShowItemToolTips = True
        Me.lstProcesses.Size = New System.Drawing.Size(725, 345)
        Me.lstProcesses.TabIndex = 0
        Me.lstProcesses.TabStop = False
        Me.lstProcesses.UseCompatibleStateImageBehavior = False
        Me.lstProcesses.View = System.Windows.Forms.View.Details
        '
        'colProcesses
        '
        Me.colProcesses.Text = "Process"
        Me.colProcesses.Width = 160
        '
        'colPid
        '
        Me.colPid.Text = "Pid"
        '
        'colOwner
        '
        Me.colOwner.Text = "Owner"
        Me.colOwner.Width = 170
        '
        'colPriority
        '
        Me.colPriority.Text = "Priority"
        Me.colPriority.Width = 100
        '
        'colThreads
        '
        Me.colThreads.Text = "Threads"
        Me.colThreads.Width = 100
        '
        'colHandles
        '
        Me.colHandles.Text = "Handles"
        Me.colHandles.Width = 100
        '
        'lblProcessesFound
        '
        Me.lblProcessesFound.AutoSize = True
        Me.lblProcessesFound.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessesFound.Location = New System.Drawing.Point(45, 90)
        Me.lblProcessesFound.Name = "lblProcessesFound"
        Me.lblProcessesFound.Size = New System.Drawing.Size(23, 14)
        Me.lblProcessesFound.TabIndex = 93
        Me.lblProcessesFound.Text = "    "
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(48, 90)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(499, 128)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 583)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Process Commad line:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCommandLine
        '
        Me.lblCommandLine.AutoEllipsis = True
        Me.lblCommandLine.ForeColor = System.Drawing.Color.Navy
        Me.lblCommandLine.Location = New System.Drawing.Point(180, 583)
        Me.lblCommandLine.Name = "lblCommandLine"
        Me.lblCommandLine.Size = New System.Drawing.Size(593, 14)
        Me.lblCommandLine.TabIndex = 0
        Me.lblCommandLine.Text = "     "
        Me.lblCommandLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAdditionalInfo
        '
        Me.btnAdditionalInfo.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAdditionalInfo.Location = New System.Drawing.Point(48, 611)
        Me.btnAdditionalInfo.Name = "btnAdditionalInfo"
        Me.btnAdditionalInfo.Size = New System.Drawing.Size(125, 30)
        Me.btnAdditionalInfo.TabIndex = 97
        Me.btnAdditionalInfo.Text = "Additional Info"
        Me.btnAdditionalInfo.UseVisualStyleBackColor = False
        '
        'Divider2
        '
        Me.Divider2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Divider2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Divider2.Location = New System.Drawing.Point(13, 61)
        Me.Divider2.Name = "Divider2"
        Me.Divider2.Size = New System.Drawing.Size(760, 23)
        Me.Divider2.TabIndex = 0
        Me.Divider2.TabStop = False
        Me.Divider2.Text = "Processes"
        '
        'UserControlProcesses
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.btnAdditionalInfo)
        Me.Controls.Add(Me.lblCommandLine)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblProcessesFound)
        Me.Controls.Add(Me.lstProcesses)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Divider2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "UserControlProcesses"
        Me.Size = New System.Drawing.Size(793, 668)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Divider2 As SysInfo.CustomControls.DividerControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lstProcesses As System.Windows.Forms.ListView
    Friend WithEvents colProcesses As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblProcessesFound As System.Windows.Forms.Label
    Friend WithEvents colPriority As System.Windows.Forms.ColumnHeader
    Friend WithEvents colPid As System.Windows.Forms.ColumnHeader
    Friend WithEvents colOwner As System.Windows.Forms.ColumnHeader
    Friend WithEvents colThreads As System.Windows.Forms.ColumnHeader
    Friend WithEvents colHandles As System.Windows.Forms.ColumnHeader
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblCommandLine As System.Windows.Forms.Label
    Friend WithEvents btnAdditionalInfo As System.Windows.Forms.Button
    Friend WithEvents ToolTips As System.Windows.Forms.ToolTip

End Class
