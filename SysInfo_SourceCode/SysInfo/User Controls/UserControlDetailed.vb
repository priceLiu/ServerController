Option Strict On
Option Explicit On

Imports System.ComponentModel
Imports System.Globalization
Imports SysInfo.Wmi

Public Class UserControlDetailed

    Dim selectedClassIndex As Integer
    Dim frm_msdn As New FormMSDN

    Public Sub New()

        InitializeComponent()

        ToolTips.SetToolTip(Me.btnMSDNhelp, "Retrieves MSDN documentation from Microsoft for the selected Class.")
        ToolTips.SetToolTip(Me.btnCancel, "Cancels the background searching operation.")
        ToolTips.SetToolTip(Me.cboClassList, "Displays a selectable list of WMI Win32 Classes.")

    End Sub


    Private Sub cboClassList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
                                                 Handles cboClassList.SelectedIndexChanged

        lstClassProperties.Items.Clear()
        lblSearching.Text = "Searching....."

        Dim selectedClass As String = cboClassList.SelectedItem.ToString
        selectedClassIndex = cboClassList.SelectedIndex

        ' The list of Win32 classes has been hardcoded within the combobox control.
        ' Some of these classes return a tremendous amount of information which can take 
        ' quite a while to retrieve. So that we can notify the user of this fact, the
        ' offending classes have been preceded with a '!' which we then check for.

        If selectedClass.Contains("!") Then
            Dim reply As MsgBoxResult = MsgBox("Selecting this wmi Class can return a significant amount of data." & _
                   Environment.NewLine & Environment.NewLine & _
                   "Are you sure you want to continue? The operation could take some time to complete; although it can be cancelled.", _
                   MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo, "Warning, Potentially Long Operation!")

            If reply = MsgBoxResult.Yes Then
                ' Go fetch the class data.
                Me.Cursor = Cursors.WaitCursor
                ' We disable the combobox so that the user can't select another class while the
                ' background worker is searching for the first class selected.
                cboClassList.Enabled = False
                Me.bwSearchWmiClass.RunWorkerAsync(selectedClass.TrimEnd("!"c))
            Else
                ' User aborted fetching data for the selected class.
                lblSearching.Text = ""
                Exit Sub
            End If
        Else
            ' Class doesn't yield a tremendous amount of information, so go fetch it.
            Me.Cursor = Cursors.WaitCursor
            cboClassList.Enabled = False
            Me.bwSearchWmiClass.RunWorkerAsync(selectedClass)
        End If
    End Sub

    Private Sub bwSearchWmiClass_DoWork(ByVal sender As System.Object, _
                                        ByVal e As System.ComponentModel.DoWorkEventArgs) _
                                        Handles bwSearchWmiClass.DoWork

        ' Get a reference to our background worker thread.
        Dim bw As BackgroundWorker = CType(sender, BackgroundWorker)

        ' Start the background thread and do the work.
        Wmi.Win32ClassInfo.ListClassProperties(bw, lstClassProperties, e.Argument.ToString)

        ' Does the user want to cancel the search?
        If bw.CancellationPending Then
            e.Cancel = True
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, _
                                ByVal e As System.EventArgs) _
                                Handles btnCancel.Click

        ' Send a cancellation message to our background thread.
        Me.bwSearchWmiClass.CancelAsync()
    End Sub

    Private Sub bwSearchWMIClass_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) _
                                                 Handles bwSearchWmiClass.ProgressChanged

        Select Case e.ProgressPercentage

            Case -1 ' Nothing found, hide the 'Searching....." text on UI.
                lblSearching.Text = ""
            Case 1
                lblSearching.Text = "Found " & e.ProgressPercentage.ToString(CultureInfo.InvariantCulture) & " Record"
            Case Else
                lblSearching.Text = "Found " & e.ProgressPercentage.ToString(CultureInfo.InvariantCulture) & " Records"
        End Select

    End Sub

    Private Sub bwSearchWMIClass_RunWorkerCompleted(ByVal sender As Object, _
                                                    ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) _
                                                    Handles bwSearchWmiClass.RunWorkerCompleted

        cboClassList.Enabled = True
        Me.Cursor = Cursors.Arrow

        If e.Cancelled Then
            MsgBox("Operation Was Cancelled by User.")
        End If

    End Sub

    Private Sub btnMSDNhelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
                                  Handles btnMSDNhelp.Click

        ' Display MSDN help on the selected WMI Class, straight from the internet.
        ' TODO Check for an internet connection. Although, the web browser will display a
        ' Page Not Found error if there is no Internet connection.

        ' Check to see if our browser form is already open, if so, reuse it, else instantiate a new one.
        If frm_msdn.IsDisposed Then
            frm_msdn = New FormMSDN
        End If

        frm_msdn.ShowURL(GetMsdnUrl(selectedClassIndex))
        frm_msdn.Show()

    End Sub

    Public Shared Function GetMsdnUrl(ByVal wmiSelectedClassIndex As Integer) As System.Uri

        ' This function gets the associated MSDN URL for the selected WMI Class.
        ' For example, Win32_BIOS has the MSDN URL of http://msdn.microsoft.com/en-us/library/aa394077(VS.85).aspx

        ' This list is ok until MS move or change their URLs!
        Dim urls As String() = {"aa394059", _
                                "aa394060", _
                                "aa394061", _
                                "aa394062", _
                                "aa394063", _
                                "aa394064", _
                                "aa394065", _
                                "aa394066", _
                                "aa394067", _
                                "aa394068", _
                                "aa394069", _
                                "aa394070", _
                                "aa394071", _
                                "aa394072", _
                                "aa394073", _
                                "aa394074", _
                                "aa394075", _
                                "aa394076", _
                                "aa394077", _
                                "aa394078", _
                                "aa394079", _
                                "aa394080", _
                                "aa394081", _
                                "aa394082", _
                                "aa394083", _
                                "aa394085", _
                                "aa394086", _
                                "aa394087", _
                                "aa394088", _
                                "aa394089", _
                                "aa394090", _
                                "aa394091", _
                                "aa394092", _
                                "aa394093", _
                                "aa394094", _
                                "aa394095", _
                                "aa394096", _
                                "aa394097", _
                                "aa394098", _
                                "aa394099", _
                                "aa394100", _
                                "aa394101", _
                                "aa394102", _
                                "aa394103", _
                                "aa394104", _
                                "aa394105", _
                                "aa394106", _
                                "aa394107", _
                                "aa394108", _
                                "aa394109", _
                                "aa394110", _
                                "aa394112", _
                                "aa394113", _
                                "aa394114", _
                                "aa394115", _
                                "aa394116", _
                                "aa394117", _
                                "aa394118", _
                                "aa394119", _
                                "aa394120", _
                                "aa394121", _
                                "aa394122", _
                                "aa394123", _
                                "aa394124", _
                                "aa394125", _
                                "aa394126", _
                                "aa394127", _
                                "aa394128", _
                                "aa394129", _
                                "aa394130", _
                                "aa394131", _
                                "aa394132", _
                                "aa394133", _
                                "aa394134", _
                                "aa394135", _
                                "aa394136", _
                                "aa394137", _
                                "aa394138", _
                                "aa394139", _
                                "aa394140", _
                                "aa394141", _
                                "aa394142", _
                                "aa394143", _
                                "aa394144", _
                                "aa394145", _
                                "aa394146", _
                                "aa394147", _
                                "aa394148", _
                                "aa394149", _
                                "aa394150", _
                                "aa394151", _
                                "aa394152", _
                                "aa394153", _
                                "aa394154", _
                                "aa394155", _
                                "aa394156", _
                                "aa394157", _
                                "aa394158", _
                                "aa394159", _
                                "aa394160", _
                                "aa394161", _
                                "aa394162", _
                                "aa394163", _
                                "aa394164", _
                                "aa394165", _
                                "aa394166", _
                                "aa394167", _
                                "aa394168", _
                                "aa394169", _
                                "aa394170", _
                                "aa394171", _
                                "aa394172", _
                                "aa394173", _
                                "aa394174", _
                                "aa394175", _
                                "aa394176", _
                                "aa394177", _
                                "aa394178", _
                                "aa394179", _
                                "aa394180", _
                                "aa394181", _
                                "aa394182", _
                                "aa394183", _
                                "aa394184", _
                                "aa394185", _
                                "aa394186", _
                                "aa394187", _
                                "aa394188", _
                                "aa394189", _
                                "aa394190", _
                                "aa394191", _
                                "aa394192", _
                                "aa394193", _
                                "aa394194", _
                                "aa394195", _
                                "aa394196", _
                                "aa394197", _
                                "aa394198", _
                                "aa394199", _
                                "aa394200", _
                                "aa394201", _
                                "aa394202", _
                                "aa394203", _
                                "aa394204", _
                                "aa394205", _
                                "aa394206", _
                                "aa394207", _
                                "aa394208", _
                                "aa394209", _
                                "aa394210", _
                                "aa394211", _
                                "aa394212", _
                                "aa394213", _
                                "aa394214", _
                                "aa394215", _
                                "aa394216", _
                                "aa394217", _
                                "aa394218", _
                                "aa394219", _
                                "aa394220", _
                                "aa394221", _
                                "aa394223", _
                                "aa394224", _
                                "aa394225", _
                                "aa394226", _
                                "aa394227", _
                                "aa394228", _
                                "aa394229", _
                                "aa394230", _
                                "aa394231", _
                                "aa394232", _
                                "aa394233", _
                                "aa394234", _
                                "aa394235", _
                                "aa394236", _
                                "aa394237", _
                                "aa394238", _
                                "aa394239", _
                                "aa394240", _
                                "aa394241", _
                                "ee309383", _
                                "aa394242", _
                                "aa394243", _
                                "aa394244", _
                                "aa394245", _
                                "aa394246", _
                                "aa394247", _
                                "aa394248", _
                                "aa394249", _
                                "aa394250", _
                                "aa394251", _
                                "aa394252", _
                                "aa394253", _
                                "aa394254", _
                                "aa394255", _
                                "aa394256", _
                                "aa394257", _
                                "aa394258", _
                                "aa394259", _
                                "aa394260", _
                                "aa394261", _
                                "aa394262", _
                                "aa394263", _
                                "aa394264", _
                                "aa394265", _
                                "aa394266", _
                                "aa394267", _
                                "aa394268", _
                                "aa394269", _
                                "aa394270", _
                                "aa394271", _
                                "aa394272", _
                                "aa394273", _
                                "aa394274", _
                                "aa394275", _
                                "aa394276", _
                                "aa394277", _
                                "aa394278", _
                                "aa394279", _
                                "aa394280", _
                                "aa394281", _
                                "aa394282", _
                                "aa394283", _
                                "aa394284", _
                                "aa394285", _
                                "aa394286", _
                                "aa394287", _
                                "aa394288", _
                                "aa394289", _
                                "aa394290", _
                                "aa394291", _
                                "aa394292", _
                                "aa394293", _
                                "aa394294", _
                                "aa394295", _
                                "aa394296", _
                                "aa394297", _
                                "aa394298", _
                                "aa394299", _
                                "aa394300", _
                                "aa394301", _
                                "aa394302", _
                                "aa394303", _
                                "aa394304", _
                                "aa394305", _
                                "aa394306", _
                                "aa394307", _
                                "aa394308", _
                                "aa394309", _
                                "aa394310", _
                                "aa394311", _
                                "aa394312", _
                                "aa394313", _
                                "aa394314", _
                                "aa394315", _
                                "aa394316", _
                                "aa394317", _
                                "aa394318", _
                                "aa394319", _
                                "aa394320", _
                                "aa394321", _
                                "aa394322", _
                                "aa394323", _
                                "aa394324", _
                                "aa394325", _
                                "aa394326", _
                                "aa394327", _
                                "aa394328", _
                                "aa394329", _
                                "aa394330", _
                                "aa394331", _
                                "aa394332", _
                                "aa394334", _
                                "aa394335", _
                                "aa394336", _
                                "aa394337", _
                                "aa394338", _
                                "aa394339", _
                                "aa394340", _
                                "aa394341", _
                                "aa394342", _
                                "aa394343", _
                                "aa394344", _
                                "aa394345", _
                                "aa394346", _
                                "aa394347", _
                                "aa394348", _
                                "aa394349", _
                                "aa394350", _
                                "aa394351", _
                                "aa394352", _
                                "aa394353", _
                                "aa394354", _
                                "aa394355", _
                                "aa394356", _
                                "aa394357", _
                                "aa394358", _
                                "aa394359", _
                                "aa394360", _
                                "aa394361", _
                                "aa394362", _
                                "aa394363", _
                                "aa394364", _
                                "aa394365", _
                                "aa394366", _
                                "aa394367", _
                                "aa394368", _
                                "aa394369", _
                                "aa394370", _
                                "aa394371", _
                                "aa394372", _
                                "aa394373", _
                                "aa394374", _
                                "aa394375", _
                                "aa394376", _
                                "aa394377", _
                                "aa394378", _
                                "aa394379", _
                                "aa394380", _
                                "aa394381", _
                                "aa394382", _
                                "aa394383", _
                                "aa394384", _
                                "aa394385", _
                                "aa394386", _
                                "aa394387", _
                                "aa394389", _
                                "aa394390", _
                                "aa394391", _
                                "aa394392", _
                                "aa394393", _
                                "aa394394", _
                                "aa394395", _
                                "ee706630", _
                                "ee706632", _
                                "aa394396", _
                                "aa394397", _
                                "aa394398", _
                                "aa394399", _
                                "aa394400", _
                                "aa394401", _
                                "aa394402", _
                                "aa394403", _
                                "aa394404", _
                                "aa394405", _
                                "aa394406", _
                                "aa394407", _
                                "aa394408", _
                                "aa394409", _
                                "aa394410", _
                                "aa394411", _
                                "aa394412", _
                                "aa394413", _
                                "aa394414", _
                                "aa394415", _
                                "aa394416", _
                                "cc280268", _
                                "aa394417", _
                                "aa394418", _
                                "aa394419", _
                                "aa394420", _
                                "aa394421", _
                                "aa394422", _
                                "aa394423", _
                                "aa394424", _
                                "aa394425", _
                                "aa394426", _
                                "aa394427", _
                                "aa394428", _
                                "aa394429", _
                                "aa394430", _
                                "aa394431", _
                                "aa394432", _
                                "aa394433", _
                                "aa394434", _
                                "aa394435", _
                                "aa394436", _
                                "aa394437", _
                                "aa394438", _
                                "aa394439", _
                                "aa394450", _
                                "aa394451", _
                                "aa394452", _
                                "aa394453", _
                                "aa394454", _
                                "aa394455", _
                                "aa394456", _
                                "aa394457", _
                                "aa394458", _
                                "aa394459", _
                                "aa394460", _
                                "aa394461", _
                                "aa394462", _
                                "aa394463", _
                                "aa394464", _
                                "aa394465", _
                                "aa394466", _
                                "aa394467", _
                                "aa394468", _
                                "aa394469", _
                                "aa394470", _
                                "aa394471", _
                                "aa394472", _
                                "aa394473", _
                                "aa394474", _
                                "aa394475", _
                                "aa394476", _
                                "aa394477", _
                                "aa394478", _
                                "aa394479", _
                                "aa394480", _
                                "aa394481", _
                                "aa394482", _
                                "aa394483", _
                                "aa394484", _
                                "aa394485", _
                                "aa394486", _
                                "aa394487", _
                                "aa394488", _
                                "aa394489", _
                                "aa394490", _
                                "aa394491", _
                                "aa394492", _
                                "aa394493", _
                                "aa394494", _
                                "aa394495", _
                                "aa394496", _
                                "aa394497", _
                                "aa394498", _
                                "aa394499", _
                                "aa394500", _
                                "aa394501", _
                                "aa394502", _
                                "aa394503", _
                                "aa394504", _
                                "aa394505", _
                                "aa394506", _
                                "aa394507", _
                                "aa394508", _
                                "aa394509", _
                                "ee886409", _
                                "aa394510", _
                                "aa394511", _
                                "aa394512", _
                                "aa394513", _
                                "aa394514", _
                                "aa394515", _
                                "aa394516", _
                                "aa394517", _
                                "aa394518", _
                                "aa394519", _
                                "aa394520", _
                                "aa394521", _
                                "aa394522"}


        Return New Uri("http://msdn.microsoft.com/en-us/library/" & urls(wmiSelectedClassIndex) & "(VS.85).aspx")

    End Function

End Class
