<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlDetailed
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControlDetailed))
        Me.bwSearchWmiClass = New System.ComponentModel.BackgroundWorker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.Label47 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label51 = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.ToolTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox15 = New System.Windows.Forms.GroupBox
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel
        Me.Label90 = New System.Windows.Forms.Label
        Me.Label91 = New System.Windows.Forms.Label
        Me.Label92 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.btnMSDNhelp = New System.Windows.Forms.Button
        Me.lblSearching = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Label56 = New System.Windows.Forms.Label
        Me.cboClassList = New System.Windows.Forms.ComboBox
        Me.lstClassProperties = New System.Windows.Forms.ListView
        Me.colProperty = New System.Windows.Forms.ColumnHeader
        Me.colValue = New System.Windows.Forms.ColumnHeader
        Me.Label1 = New System.Windows.Forms.Label
        Me.Divider2 = New SysInfo.CustomControls.DividerControl
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bwSearchWmiClass
        '
        Me.bwSearchWmiClass.WorkerReportsProgress = True
        Me.bwSearchWmiClass.WorkerSupportsCancellation = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(3, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 25)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Installed:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.AutoEllipsis = True
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.SystemColors.Control
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(130, 150)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(2, 18)
        Me.Label18.TabIndex = 12
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.AutoEllipsis = True
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.SystemColors.Control
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(130, 74)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(2, 18)
        Me.Label19.TabIndex = 10
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(7, 70)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(117, 25)
        Me.Label20.TabIndex = 11
        Me.Label20.Text = "Platform:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.AutoEllipsis = True
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label21.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(130, 49)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(2, 18)
        Me.Label21.TabIndex = 9
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(7, 45)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(117, 25)
        Me.Label22.TabIndex = 8
        Me.Label22.Text = "Version:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.AutoEllipsis = True
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.SystemColors.Control
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label23.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(130, 200)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(2, 18)
        Me.Label23.TabIndex = 5
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.AutoEllipsis = True
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.SystemColors.Control
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label24.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(130, 24)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(2, 18)
        Me.Label24.TabIndex = 1
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(3, 196)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(117, 25)
        Me.Label25.TabIndex = 6
        Me.Label25.Text = "Product Key:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.AutoEllipsis = True
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.SystemColors.Control
        Me.Label26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label26.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(130, 175)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(2, 18)
        Me.Label26.TabIndex = 4
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(10, 20)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(114, 25)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "Windows Edition:"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(3, 171)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(117, 25)
        Me.Label28.TabIndex = 3
        Me.Label28.Text = "Serial Number:"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label33
        '
        Me.Label33.AutoEllipsis = True
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.SystemColors.Control
        Me.Label33.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label33.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(130, 169)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(2, 18)
        Me.Label33.TabIndex = 21
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(7, 165)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(117, 25)
        Me.Label34.TabIndex = 20
        Me.Label34.Text = "Encryption Level:"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(3, 304)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(117, 25)
        Me.Label35.TabIndex = 19
        Me.Label35.Text = "Organisation:"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label36
        '
        Me.Label36.AutoEllipsis = True
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.SystemColors.Control
        Me.Label36.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label36.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(130, 308)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(2, 18)
        Me.Label36.TabIndex = 18
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label37
        '
        Me.Label37.AutoEllipsis = True
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.SystemColors.Control
        Me.Label37.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label37.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(130, 283)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(2, 18)
        Me.Label37.TabIndex = 17
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label38
        '
        Me.Label38.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(3, 279)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(117, 25)
        Me.Label38.TabIndex = 16
        Me.Label38.Text = "Registered User:"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label39
        '
        Me.Label39.AutoEllipsis = True
        Me.Label39.AutoSize = True
        Me.Label39.BackColor = System.Drawing.SystemColors.Control
        Me.Label39.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label39.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(130, 98)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(2, 18)
        Me.Label39.TabIndex = 15
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label40
        '
        Me.Label40.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Black
        Me.Label40.Location = New System.Drawing.Point(7, 94)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(117, 25)
        Me.Label40.TabIndex = 14
        Me.Label40.Text = "Role:"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label41
        '
        Me.Label41.AutoEllipsis = True
        Me.Label41.AutoSize = True
        Me.Label41.BackColor = System.Drawing.SystemColors.Control
        Me.Label41.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label41.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(130, 208)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(2, 18)
        Me.Label41.TabIndex = 12
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label42
        '
        Me.Label42.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Black
        Me.Label42.Location = New System.Drawing.Point(3, 204)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(117, 25)
        Me.Label42.TabIndex = 13
        Me.Label42.Text = "Installed:"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label43
        '
        Me.Label43.AutoEllipsis = True
        Me.Label43.AutoSize = True
        Me.Label43.BackColor = System.Drawing.SystemColors.Control
        Me.Label43.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label43.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(130, 74)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(2, 18)
        Me.Label43.TabIndex = 10
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label44
        '
        Me.Label44.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.Black
        Me.Label44.Location = New System.Drawing.Point(7, 70)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(117, 25)
        Me.Label44.TabIndex = 11
        Me.Label44.Text = "Platform:"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label45
        '
        Me.Label45.AutoEllipsis = True
        Me.Label45.AutoSize = True
        Me.Label45.BackColor = System.Drawing.SystemColors.Control
        Me.Label45.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label45.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(130, 49)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(2, 18)
        Me.Label45.TabIndex = 9
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label46
        '
        Me.Label46.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.Black
        Me.Label46.Location = New System.Drawing.Point(7, 45)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(117, 25)
        Me.Label46.TabIndex = 8
        Me.Label46.Text = "Version:"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label47
        '
        Me.Label47.AutoEllipsis = True
        Me.Label47.AutoSize = True
        Me.Label47.BackColor = System.Drawing.SystemColors.Control
        Me.Label47.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label47.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(130, 258)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(2, 18)
        Me.Label47.TabIndex = 5
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label48
        '
        Me.Label48.AutoEllipsis = True
        Me.Label48.AutoSize = True
        Me.Label48.BackColor = System.Drawing.SystemColors.Control
        Me.Label48.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label48.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(130, 24)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(2, 18)
        Me.Label48.TabIndex = 1
        '
        'Label49
        '
        Me.Label49.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.Black
        Me.Label49.Location = New System.Drawing.Point(3, 254)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(117, 25)
        Me.Label49.TabIndex = 6
        Me.Label49.Text = "Product Key:"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label50
        '
        Me.Label50.AutoEllipsis = True
        Me.Label50.AutoSize = True
        Me.Label50.BackColor = System.Drawing.SystemColors.Control
        Me.Label50.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label50.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(130, 233)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(2, 18)
        Me.Label50.TabIndex = 4
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label51
        '
        Me.Label51.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.Black
        Me.Label51.Location = New System.Drawing.Point(10, 20)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(114, 25)
        Me.Label51.TabIndex = 0
        Me.Label51.Text = "Windows Edition:"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label52
        '
        Me.Label52.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.Black
        Me.Label52.Location = New System.Drawing.Point(3, 229)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(117, 25)
        Me.Label52.TabIndex = 3
        Me.Label52.Text = "Serial Number:"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox15
        '
        Me.GroupBox15.BackColor = System.Drawing.Color.White
        Me.GroupBox15.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox15.TabIndex = 0
        Me.GroupBox15.TabStop = False
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.AutoSize = True
        Me.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel4.ColumnCount = 4
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel4.Controls.Add(Me.Label90, 1, 10)
        Me.TableLayoutPanel4.Controls.Add(Me.Label91, 0, 10)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 11
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(200, 100)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.BackColor = System.Drawing.Color.Transparent
        Me.Label90.ForeColor = System.Drawing.Color.Blue
        Me.Label90.Location = New System.Drawing.Point(84, 200)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(29, 13)
        Me.Label90.TabIndex = 66
        Me.Label90.Text = "label"
        Me.Label90.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label91
        '
        Me.Label91.AutoSize = True
        Me.Label91.Location = New System.Drawing.Point(3, 200)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(75, 13)
        Me.Label91.TabIndex = 66
        Me.Label91.Text = "Release Date:"
        Me.Label91.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.BackColor = System.Drawing.Color.Transparent
        Me.Label92.ForeColor = System.Drawing.Color.Blue
        Me.Label92.Location = New System.Drawing.Point(99, 165)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(32, 15)
        Me.Label92.TabIndex = 64
        Me.Label92.Text = "label"
        Me.Label92.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(530, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(123, 121)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(677, 6)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Location = New System.Drawing.Point(677, 6)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(102, 102)
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        '
        'btnMSDNhelp
        '
        Me.btnMSDNhelp.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnMSDNhelp.BackgroundImage = CType(resources.GetObject("btnMSDNhelp.BackgroundImage"), System.Drawing.Image)
        Me.btnMSDNhelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMSDNhelp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMSDNhelp.Location = New System.Drawing.Point(605, 86)
        Me.btnMSDNhelp.Name = "btnMSDNhelp"
        Me.btnMSDNhelp.Size = New System.Drawing.Size(70, 32)
        Me.btnMSDNhelp.TabIndex = 0
        Me.btnMSDNhelp.TabStop = False
        Me.btnMSDNhelp.UseVisualStyleBackColor = False
        '
        'lblSearching
        '
        Me.lblSearching.AutoSize = True
        Me.lblSearching.Location = New System.Drawing.Point(451, 99)
        Me.lblSearching.Name = "lblSearching"
        Me.lblSearching.Size = New System.Drawing.Size(0, 14)
        Me.lblSearching.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(681, 86)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(92, 32)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.TabStop = False
        Me.btnCancel.Text = "Cancel Search"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.Location = New System.Drawing.Point(39, 99)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(77, 14)
        Me.Label56.TabIndex = 0
        Me.Label56.Text = "WMI Classes:"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboClassList
        '
        Me.cboClassList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboClassList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboClassList.DropDownHeight = 250
        Me.cboClassList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboClassList.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboClassList.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboClassList.FormattingEnabled = True
        Me.cboClassList.IntegralHeight = False
        Me.cboClassList.Items.AddRange(New Object() {"Win32_1394Controller", "Win32_1394ControllerDevice", "Win32_Account", "Win32_AccountSID", "Win32_ACE", "Win32_ActionCheck!", "Win32_ActiveRoute", "Win32_AllocatedResource", "Win32_ApplicationCommandLine", "Win32_ApplicationService", "Win32_AssociatedBattery", "Win32_AssociatedProcessorMemory", "Win32_AutochkSetting", "Win32_BaseBoard", "Win32_BaseService!", "Win32_Battery", "Win32_Binary!", "Win32_BindImageAction", "Win32_BIOS", "Win32_BootConfiguration", "Win32_Bus", "Win32_CacheMemory", "Win32_CDROMDrive", "Win32_CheckCheck!", "Win32_CIMLogicalDeviceCIMDataFile", "Win32_ClassicCOMApplicationClasses!", "Win32_ClassicCOMClass!", "Win32_ClassicCOMClassSetting!", "Win32_ClassicCOMClassSettings!", "Win32_ClassInfoAction!", "Win32_ClientApplicationSetting", "Win32_CodecFile", "Win32_CollectionStatistics", "Win32_COMApplication!", "Win32_COMApplicationClasses!", "Win32_COMApplicationSettings!", "Win32_COMClass!", "Win32_ComClassAutoEmulator!", "Win32_ComClassEmulator!", "Win32_CommandLineAccess", "Win32_ComponentCategory", "Win32_ComputerShutdownEvent", "Win32_ComputerSystem", "Win32_ComputerSystemEvent", "Win32_ComputerSystemProcessor", "Win32_ComputerSystemProduct", "Win32_ComputerSystemWindowsProductActivationSetting", "Win32_COMSetting!", "Win32_Condition", "Win32_ConnectionShare", "Win32_ControllerHasHub", "Win32_CreateFolderAction", "Win32_CurrentProbe", "Win32_CurrentTime", "Win32_DCOMApplication", "Win32_DCOMApplicationAccessAllowedSetting", "Win32_DCOMApplicationLaunchAllowedSetting", "Win32_DCOMApplicationSetting", "Win32_DefragAnalysis", "Win32_DependentService", "Win32_Desktop", "Win32_DesktopMonitor", "Win32_DeviceBus", "Win32_DeviceChangeEvent", "Win32_DeviceMemoryAddress", "Win32_DeviceSettings", "Win32_DFSNode", "Win32_DFSNodeTarget", "Win32_DFSTarget", "Win32_Directory!", "Win32_DirectorySpecification!", "Win32_DiskDrive", "Win32_DiskDrivePhysicalMedia", "Win32_DiskDriveToDiskPartition", "Win32_DiskPartition", "Win32_DiskQuota", "Win32_DisplayConfiguration", "Win32_DisplayControllerConfiguration", "Win32_DMAChannel", "Win32_DriverForDevice", "Win32_DriverVXD", "Win32_DuplicateFileAction", "Win32_Environment", "Win32_EnvironmentSpecification", "Win32_ExtensionInfoAction", "Win32_Fan", "Win32_FileSpecification", "Win32_FloppyController", "Win32_FloppyDrive", "Win32_FontInfoAction", "Win32_Group", "Win32_GroupInDomain", "Win32_GroupUser", "Win32_HeatPipe", "Win32_IDEController", "Win32_IDEControllerDevice", "Win32_ImplementedCategory", "Win32_InfraredDevice", "Win32_IniFileSpecification", "Win32_InstalledSoftwareElement", "Win32_IP4PersistedRouteTable", "Win32_IP4RouteTable", "Win32_IP4RouteTableEvent", "Win32_IRQResource", "Win32_JobObjectStatus", "Win32_Keyboard", "Win32_LaunchCondition", "Win32_LoadOrderGroup", "Win32_LoadOrderGroupServiceDependencies", "Win32_LoadOrderGroupServiceMembers", "Win32_LocalTime", "Win32_LoggedOnUser", "Win32_LogicalDisk", "Win32_LogicalDiskRootDirectory", "Win32_LogicalDiskToPartition", "Win32_LogicalFileAccess", "Win32_LogicalFileAuditing", "Win32_LogicalFileGroup", "Win32_LogicalFileOwner", "Win32_LogicalFileSecuritySetting", "Win32_LogicalMemoryConfiguration", "Win32_LogicalProgramGroup", "Win32_LogicalProgramGroupDirectory", "Win32_LogicalProgramGroupItem", "Win32_LogicalProgramGroupItemDataFile", "Win32_LogicalShareAccess", "Win32_LogicalShareAuditing", "Win32_LogicalShareSecuritySetting", "Win32_LogonSession", "Win32_LogonSessionMappedDisk", "Win32_LUID", "Win32_LUIDandAttributes", "Win32_ManagedSystemElementResource", "Win32_MappedLogicalDisk", "Win32_MemoryArray", "Win32_MemoryArrayLocation", "Win32_MemoryDevice", "Win32_MemoryDeviceArray", "Win32_MemoryDeviceLocation", "Win32_MethodParameterClass", "Win32_MIMEInfoAction", "Win32_ModuleLoadTrace", "Win32_ModuleTrace", "Win32_MotherboardDevice", "Win32_MountPoint", "Win32_MoveFileAction", "Win32_MSIResource", "Win32_NamedJobObject", "Win32_NamedJobObjectActgInfo", "Win32_NamedJobObjectLimit", "Win32_NamedJobObjectLimitSetting", "Win32_NamedJobObjectProcess", "Win32_NamedJobObjectSecLimit", "Win32_NamedJobObjectSecLimitSetting", "Win32_NamedJobObjectStatistics", "Win32_NetworkAdapter", "Win32_NetworkAdapterConfiguration", "Win32_NetworkAdapterSetting", "Win32_NetworkClient", "Win32_NetworkConnection", "Win32_NetworkLoginProfile", "Win32_NetworkProtocol", "Win32_NTDomain", "Win32_NTEventlogFile", "Win32_NTLogEvent", "Win32_NTLogEventComputer", "Win32_NTLogEventLog", "Win32_NTLogEventUser", "Win32_ODBCAttribute", "Win32_ODBCDataSourceAttribute", "Win32_ODBCDataSourceSpecification", "Win32_ODBCDriverAttribute", "Win32_ODBCDriverSoftwareElement", "Win32_ODBCDriverSpecification", "Win32_ODBCSourceAttribute", "Win32_ODBCTranslatorSpecification", "Win32_OnBoardDevice", "Win32_OperatingSystem", "Win32_OperatingSystemAutochkSetting", "Win32_OperatingSystemQFE", "Win32_OptionalFeature", "Win32_OSRecoveryConfiguration", "Win32_PageFile", "Win32_PageFileElementSetting", "Win32_PageFileSetting", "Win32_PageFileUsage", "Win32_ParallelPort", "Win32_Patch", "Win32_PatchFile", "Win32_PatchPackage", "Win32_PCMCIAController", "Win32_Perf", "Win32_PerfFormattedData", "Win32_PerfFormattedData_ASP_ActiveServerPages", "Win32_PerfFormattedData_ContentFilter_IndexingServiceFilter", "Win32_PerfFormattedData_ContentIndex_IndexingService", "Win32_PerfFormattedData_InetInfo_InternetInformationServicesGlobal", "Win32_PerfFormattedData_ISAPISearch_HttpIndexingService", "Win32_PerfFormattedData_MSDTC_DistributedTransactionCoordinator", "Win32_PerfFormattedData_NTFSDRV_SMTPNTFSStoreDriver", "Win32_PerfFormattedData_PerfDisk_LogicalDisk", "Win32_PerfFormattedData_PerfDisk_PhysicalDisk", "Win32_PerfFormattedData_PerfNet_Browser", "Win32_PerfFormattedData_PerfNet_Redirector", "Win32_PerfFormattedData_PerfNet_Server", "Win32_PerfFormattedData_PerfNet_ServerWorkQueues", "Win32_PerfFormattedData_PerfOS_Cache", "Win32_PerfFormattedData_PerfOS_Memory", "Win32_PerfFormattedData_PerfOS_Objects", "Win32_PerfFormattedData_PerfOS_PagingFile", "Win32_PerfFormattedData_PerfOS_Processor", "Win32_PerfFormattedData_PerfOS_System", "Win32_PerfFormattedData_PerfProc_FullImage_Costly", "Win32_PerfFormattedData_PerfProc_Image_Costly", "Win32_PerfFormattedData_PerfProc_JobObject", "Win32_PerfFormattedData_PerfProc_JobObjectDetails", "Win32_PerfFormattedData_PerfProc_Process", "Win32_PerfFormattedData_PerfProc_ProcessAddressSpace_Costly", "Win32_PerfFormattedData_PerfProc_Thread", "Win32_PerfFormattedData_PerfProc_ThreadDetails_Costly", "Win32_PerfFormattedData_PSched_PSchedFlow", "Win32_PerfFormattedData_PSched_PSchedPipe", "Win32_PerfFormattedData_RemoteAccess_RASPort", "Win32_PerfFormattedData_RemoteAccess_RASTotal", "Win32_PerfFormattedData_RSVP_ACSRSVPInterfaces", "Win32_PerfFormattedData_RSVP_ACSRSVPService", "Win32_PerfFormattedData_SMTPSVC_SMTPServer", "Win32_PerfFormattedData_Spooler_PrintQueue", "Win32_PerfFormattedData_TapiSrv_Telephony", "Win32_PerfFormattedData_Tcpip_ICMP", "Win32_PerfFormattedData_Tcpip_IP", "Win32_PerfFormattedData_Tcpip_NBTConnection", "Win32_PerfFormattedData_Tcpip_NetworkInterface", "Win32_PerfFormattedData_Tcpip_TCP", "Win32_PerfFormattedData_Tcpip_UDP", "Win32_PerfFormattedData_TermService_TerminalServices", "Win32_PerfFormattedData_TermService_TerminalServicesSession", "Win32_PerfFormattedData_W3SVC_WebService", "Win32_PerfRawData", "Win32_PerfRawData_ASP_ActiveServerPages", "Win32_PerfRawData_ContentFilter_IndexingServiceFilter", "Win32_PerfRawData_ContentIndex_IndexingService", "Win32_PerfRawData_InetInfo_InternetInformationServicesGlobal", "Win32_PerfRawData_ISAPISearch_HttpIndexingService", "Win32_PerfRawData_MSDTC_DistributedTransactionCoordinator", "Win32_PerfRawData_NTFSDRV_SMTPNTFSStoreDriver", "Win32_PerfRawData_PerfDisk_LogicalDisk", "Win32_PerfRawData_PerfDisk_PhysicalDisk", "Win32_PerfRawData_PerfNet_Browser", "Win32_PerfRawData_PerfNet_Redirector", "Win32_PerfRawData_PerfNet_Server", "Win32_PerfRawData_PerfNet_ServerWorkQueues", "Win32_PerfRawData_PerfOS_Cache", "Win32_PerfRawData_PerfOS_Memory", "Win32_PerfRawData_PerfOS_Objects", "Win32_PerfRawData_PerfOS_PagingFile", "Win32_PerfRawData_PerfOS_Processor", "Win32_PerfRawData_PerfOS_System", "Win32_PerfRawData_PerfProc_FullImage_Costly", "Win32_PerfRawData_PerfProc_Image_Costly", "Win32_PerfRawData_PerfProc_JobObject", "Win32_PerfRawData_PerfProc_JobObjectDetails", "Win32_PerfRawData_PerfProc_Process", "Win32_PerfRawData_PerfProc_ProcessAddressSpace_Costly", "Win32_PerfRawData_PerfProc_Thread", "Win32_PerfRawData_PerfProc_ThreadDetails_Costly", "Win32_PerfRawData_PSched_PSchedFlow", "Win32_PerfRawData_PSched_PSchedPipe", "Win32_PerfRawData_RemoteAccess_RASPort", "Win32_PerfRawData_RemoteAccess_RASTotal", "Win32_PerfRawData_RSVP_ACSRSVPInterfaces", "Win32_PerfRawData_RSVP_ACSRSVPService", "Win32_PerfRawData_SMTPSVC_SMTPServer", "Win32_PerfRawData_Spooler_PrintQueue", "Win32_PerfRawData_TapiSrv_Telephony", "Win32_PerfRawData_Tcpip_ICMP", "Win32_PerfRawData_Tcpip_IP", "Win32_PerfRawData_Tcpip_NBTConnection", "Win32_PerfRawData_Tcpip_NetworkInterface", "Win32_PerfRawData_Tcpip_TCP", "Win32_PerfRawData_Tcpip_UDP", "Win32_PerfRawData_TermService_TerminalServices", "Win32_PerfRawData_TermService_TerminalServicesSession", "Win32_PerfRawData_W3SVC_WebService", "Win32_PhysicalMedia", "Win32_PhysicalMemory", "Win32_PhysicalMemoryArray", "Win32_PhysicalMemoryLocation", "Win32_PingStatus", "Win32_PnPAllocatedResource", "Win32_PnPDevice", "Win32_PnPEntity", "Win32_PnPSignedDriver", "Win32_PnPSignedDriverCIMDataFile", "Win32_PointingDevice", "Win32_PortableBattery", "Win32_PortConnector", "Win32_PortResource", "Win32_POTSModem", "Win32_POTSModemToSerialPort", "Win32_PowerManagementEvent", "Win32_Printer", "Win32_PrinterConfiguration", "Win32_PrinterController", "Win32_PrinterDriver", "Win32_PrinterDriverDll", "Win32_PrinterSetting", "Win32_PrinterShare", "Win32_PrintJob", "Win32_PrivilegesStatus", "Win32_Process", "Win32_Processor", "Win32_ProcessStartTrace", "Win32_ProcessStartup", "Win32_ProcessStopTrace", "Win32_ProcessTrace", "Win32_Product", "Win32_ProductCheck", "Win32_ProductResource", "Win32_ProductSoftwareFeatures", "Win32_ProgIDSpecification", "Win32_ProgramGroup", "Win32_ProgramGroupContents", "Win32_ProgramGroupOrItem", "Win32_Property", "Win32_ProtocolBinding", "Win32_Proxy", "Win32_PublishComponentAction", "Win32_QuickFixEngineering", "Win32_QuotaSetting", "Win32_Refrigeration", "Win32_Registry", "Win32_RegistryAction", "Win32_ReliabilityRecords", "Win32_ReliabilityStabilityMetrics", "Win32_RemoveFileAction", "Win32_RemoveIniAction", "Win32_ReserveCost", "Win32_ScheduledJob", "Win32_SCSIController", "Win32_SCSIControllerDevice", "Win32_SecurityDescriptor", "Win32_SecurityDescriptorHelper", "Win32_SecuritySetting", "Win32_SecuritySettingAccess", "Win32_SecuritySettingAuditing", "Win32_SecuritySettingGroup", "Win32_SecuritySettingOfLogicalFile", "Win32_SecuritySettingOfLogicalShare", "Win32_SecuritySettingOfObject", "Win32_SecuritySettingOwner", "Win32_SelfRegModuleAction", "Win32_SerialPort", "Win32_SerialPortConfiguration", "Win32_SerialPortSetting", "Win32_ServerConnection", "Win32_ServerFeature", "Win32_ServerSession", "Win32_Service", "Win32_ServiceControl", "Win32_ServiceSpecification", "Win32_ServiceSpecificationService", "Win32_Session", "Win32_SessionConnection", "Win32_SessionProcess", "Win32_SettingCheck", "Win32_ShadowBy", "Win32_ShadowContext", "Win32_ShadowCopy", "Win32_ShadowDiffVolumeSupport", "Win32_ShadowFor", "Win32_ShadowOn", "Win32_ShadowProvider", "Win32_ShadowStorage", "Win32_ShadowVolumeSupport", "Win32_Share", "Win32_ShareToDirectory", "Win32_ShortcutAction", "Win32_ShortcutFile", "Win32_ShortcutSAP", "Win32_SID", "Win32_SIDandAttributes", "Win32_SMBIOSMemory", "Win32_SoftwareElement", "Win32_SoftwareElementAction", "Win32_SoftwareElementCheck", "Win32_SoftwareElementCondition", "Win32_SoftwareElementResource", "Win32_SoftwareFeature", "Win32_SoftwareFeatureAction", "Win32_SoftwareFeatureCheck", "Win32_SoftwareFeatureParent", "Win32_SoftwareFeatureSoftwareElements", "Win32_SoundDevice", "Win32_StartupCommand", "Win32_SubDirectory", "Win32_SystemAccount", "Win32_SystemBIOS", "Win32_SystemBootConfiguration", "Win32_SystemConfigurationChangeEvent", "Win32_SystemDesktop", "Win32_SystemDevices", "Win32_SystemDriver", "Win32_SystemDriverPnPEntity", "Win32_SystemEnclosure", "Win32_SystemLoadOrderGroups", "Win32_SystemLogicalMemoryConfiguration", "Win32_SystemMemoryResource", "Win32_SystemNetworkConnections", "Win32_SystemOperatingSystem", "Win32_SystemPartitions", "Win32_SystemProcesses", "Win32_SystemProgramGroups", "Win32_SystemResources", "Win32_SystemServices", "Win32_SystemSetting", "Win32_SystemSlot", "Win32_SystemSystemDriver", "Win32_SystemTimeZone", "Win32_SystemTrace", "Win32_SystemUsers", "Win32_TapeDrive", "Win32_TCPIPPrinterPort", "Win32_TemperatureProbe", "Win32_Thread", "Win32_ThreadStartTrace", "Win32_ThreadStopTrace", "Win32_ThreadTrace", "Win32_TimeZone", "Win32_TokenGroups", "Win32_TokenPrivileges", "Win32_Trustee", "Win32_TypeLibraryAction", "Win32_UninterruptiblePowerSupply", "Win32_USBController", "Win32_USBControllerDevice", "Win32_USBHub", "Win32_UserAccount", "Win32_UserDesktop", "Win32_UserInDomain", "Win32_UserProfile", "Win32_UTCTime", "Win32_VideoConfiguration", "Win32_VideoController", "Win32_VideoSettings", "Win32_VoltageProbe", "Win32_Volume", "Win32_VolumeChangeEvent", "Win32_VolumeQuota", "Win32_VolumeQuotaSetting", "Win32_VolumeUserQuota", "Win32_WindowsProductActivation", "Win32_WMIElementSetting", "Win32_WMISetting"})
        Me.cboClassList.Location = New System.Drawing.Point(122, 96)
        Me.cboClassList.Name = "cboClassList"
        Me.cboClassList.Size = New System.Drawing.Size(323, 22)
        Me.cboClassList.TabIndex = 0
        Me.cboClassList.TabStop = False
        '
        'lstClassProperties
        '
        Me.lstClassProperties.AllowColumnReorder = True
        Me.lstClassProperties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstClassProperties.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colProperty, Me.colValue})
        Me.lstClassProperties.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstClassProperties.FullRowSelect = True
        Me.lstClassProperties.GridLines = True
        Me.lstClassProperties.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstClassProperties.Location = New System.Drawing.Point(49, 127)
        Me.lstClassProperties.MultiSelect = False
        Me.lstClassProperties.Name = "lstClassProperties"
        Me.lstClassProperties.ShowItemToolTips = True
        Me.lstClassProperties.Size = New System.Drawing.Size(724, 526)
        Me.lstClassProperties.TabIndex = 0
        Me.lstClassProperties.TabStop = False
        Me.lstClassProperties.UseCompatibleStateImageBehavior = False
        Me.lstClassProperties.View = System.Windows.Forms.View.Details
        '
        'colProperty
        '
        Me.colProperty.Text = "Property"
        Me.colProperty.Width = 205
        '
        'colValue
        '
        Me.colValue.Text = "Value"
        Me.colValue.Width = 500
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(10, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(347, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "View detailed information about your Computer"
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
        Me.Divider2.Text = "Windows Management Instrumentation Classes"
        '
        'UserControlDetailed
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Controls.Add(Me.Divider2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstClassProperties)
        Me.Controls.Add(Me.btnMSDNhelp)
        Me.Controls.Add(Me.lblSearching)
        Me.Controls.Add(Me.cboClassList)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label56)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "UserControlDetailed"
        Me.Size = New System.Drawing.Size(793, 668)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents bwSearchWmiClass As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents ToolTips As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label90 As System.Windows.Forms.Label
    Friend WithEvents Label91 As System.Windows.Forms.Label
    Friend WithEvents Label92 As System.Windows.Forms.Label
    Friend WithEvents btnMSDNhelp As System.Windows.Forms.Button
    Friend WithEvents lblSearching As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents cboClassList As System.Windows.Forms.ComboBox
    Friend WithEvents lstClassProperties As System.Windows.Forms.ListView
    Friend WithEvents colProperty As System.Windows.Forms.ColumnHeader
    Friend WithEvents colValue As System.Windows.Forms.ColumnHeader
    Friend WithEvents Divider2 As SysInfo.CustomControls.DividerControl
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
