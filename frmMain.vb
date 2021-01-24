Imports System.ComponentModel
Imports System.IO
Public Class frmMain

    Private Enum MoveDirection
        Up = -1
        Down = 1
    End Enum

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="SourceFile"></param>
    ''' <param name="SourceDir"></param>
    ''' <returns></returns>
    Public Shared Function ReplaceStart(ByVal SourceFile As String, ByVal SourceDir As String) As String
        Dim tempStr As String = ""
        tempStr = Strings.Right(SourceFile, SourceFile.Length - SourceDir.Length)
        tempStr = ":\" + tempStr
        Return tempStr
    End Function

    ''' <summary>
    ''' Saves the lvSlotList Items out to a text file (Temp.dat)
    ''' </summary>
    ''' <param name="Lv">Listview control to display text file</param>
    ''' <returns>True if successful, false if not.</returns>
    Function SaveCurrentGameListToTempFile(lv As ListView) As Boolean
        Try
            Dim TempSaveFile As String = Application.StartupPath & "\Temp.dat"
            If File.Exists(TempSaveFile) Then
                File.Delete(TempSaveFile)
            End If
            Dim lvStream As New IO.StreamWriter(TempSaveFile)
            For Each Lvi As ListViewItem In lv.Items
                lvStream.WriteLine(Lvi.Text)
            Next
            lvStream.Close()
            lvStream.Flush()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Function to read in a text file, optionally removing x characters from the beginning of the line, and display it in a ListView control.
    ''' </summary>
    ''' <param name="GameList">Path to text file (a previously saved game list) to read in </param>
    ''' <param name="Lv">Listview control to display text file</param>
    ''' <param name="Remove">If true, remove characters from the beginning of the line</param>
    ''' <param name="Count">If remove=true, remove this number of characters from the beginning of the line</param>
    ''' <returns>Returns false if there's an error. Otherwise True.</returns>
    Function LoadGameListToListView(GameList As String, Lv As ListView, Remove As Boolean, Count As Integer) As Boolean
        Try
            Dim TempSaveFile As String = GameList
            If File.Exists(TempSaveFile) Then
                Dim lvStream As New IO.StreamReader(TempSaveFile)
                While lvStream.EndOfStream <> True
                    If Remove = True Then
                        Lv.Items.Add(lvStream.ReadLine().Remove(0, Count))
                    Else
                        Lv.Items.Add(lvStream.ReadLine())
                    End If
                End While
                lvStream.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Copy game disks from the Source folder (and subfolders) to the destination USB drive.
    ''' </summary>
    ''' <param name="SourcePath">Base directory of the source files.</param>
    ''' <param name="Destination">Path of the USB HDD that will be plugged into Gotek</param>
    ''' <param name="Overwrite">Overwrite exsiting disk images if true.</param>
    ''' <returns>False if there's an error, otherwise true.</returns>
    Private Function CopyGamesToUSB(SourcePath As String, Destination As String, Overwrite As Boolean) As Boolean
        Try
            If lvSlotList.Items.Count > 0 Then
                Dim listFrom(lvSlotList.Items.Count - 1) As String
                Dim listTo(lvSlotList.Items.Count - 1) As String
                For CopyCount As Integer = 0 To lvSlotList.Items.Count - 1
                    listFrom(CopyCount) = SourcePath & lvSlotList.Items(CopyCount).Text.Remove(0, 2)
                    listTo(CopyCount) = Destination & lvSlotList.Items(CopyCount).Text.Remove(0, 2)
                Next
                For CopyCount As Integer = 0 To lvSlotList.Items.Count - 1
                    File.Copy(listFrom(CopyCount), listTo(CopyCount), Overwrite)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return True
    End Function

    Function UpdateListCount() As Boolean
        Try
            gboxExportList.Text = "Export List (" & CStr(lvSlotList.Items.Count) & " disk images)"

            'For i = 0 To lvSlotList.Items.Count
            '    If lvSlotList.Items.Item(i).ListView.Size.Width > lvSlotList.Columns(0).Width Then
            '        lvSlotList.Columns(0).Width = lvSlotList.Items.Item(i).ListView.Size.Width
            '    End If
            'Next
            lvSlotList.Columns(0).Width = 1000
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function PopulateList(lvList As ListView) As Boolean
        Try
            lvList.Items.Clear()                                                                                'Clear main listbox for processing (Note, only clear items, not col names etc)
            txtSource.Text.TrimEnd(" ", Path.DirectorySeparatorChar)                                            'Remove anny trailing spaces
            If Not txtSource.Text.EndsWith(Path.DirectorySeparatorChar) Then
                txtSource.Text = txtSource.Text & Path.DirectorySeparatorChar                                   'Set a trailing backslash
            End If
            If Directory.Exists(txtSource.Text) Then                                                            'Check Directory Exists
                My.Settings.LastUsedDir = txtSource.Text                                                        'Set the lastused Dir in the settings, for saving later on.
                My.Settings.Item("LastUsedDir") = txtSource.Text                                                'Set the lastused Dir in the settings, for saving later on.
                ProcessDirectory(txtSource.Text)                                                                'Process the Source Directly, and show all files found in the listbox
                gbSource.Text = "Files List (" & CStr(lvList.Items.Count) & " disk images)"                     'Update The Group Box Title
                My.Settings.Save()                                                                              'Save The newly selected Source Directory
            Else
                MessageBox.Show("Directory Not Found: " & txtSource.Text)                                       'If Directory Not found
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Shared Function MoveListViewItems(ByVal sender As ListView, ByVal dir As MoveDirection) As Boolean
        Return False
        ''dir = (Int())direction
        'Dim opp As Int16 = dir * -1

        'Dim valid As Boolean
        'If sender.SelectedItems.Count > 0 And (((dir = MoveDirection.Down) And (sender.SelectedItems[sender.SelectedItems.Count - 1].Index < sender.Items.Count - 1)) Or (dir = MoveDirection.Up And (sender.SelectedItems[0].Index > 0))) Then
        '    valid = True
        'Else
        '    valid = False
        'End If

        'If (valid) Then
        '    Dim selfile As ListViewItem
        '    For Each selfile In sender.SelectedItems

        '        Dim Index As Int16 = selfile.Index + dir
        '        sender.Items.RemoveAt(selfile.Index)
        '        sender.Items.Insert(Index, selfile)

        '        sender.Items[index + opp].SubItems[1].Text = (index + opp).ToString()
        '    item.SubItems[1].Text = (index).ToString()
        'Next
        'End If
    End Function

    ''' <summary>
    ''' Process all files in the directory passed in, recurse on any directories 
    ''' that are found, and process the files they contain.
    ''' </summary>
    ''' <param name="targetDirectory">Directory to Search (recursivly)</param>
    Public Shared Sub ProcessDirectory(ByVal targetDirectory As String)
        Dim fileEntries As String() = Directory.GetFiles(targetDirectory)
        ' Process the list of files found in the directory.

        Dim extlist As String()
        extlist = frmMain.txtDiskPatterns.Text.Split("|")
        Dim extName As String

        Dim fileName As String = ""
        For Each fileName In fileEntries
            For Each extName In extlist
                If Path.GetExtension(fileName).ToUpper = extName.ToUpper Then
                    frmMain.lvSource.Items.Add(ReplaceStart(fileName, frmMain.txtSource.Text).Replace(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar))
                End If
            Next extName
        Next fileName

        Dim subdirectoryEntries As String() = Directory.GetDirectories(targetDirectory)
        ' Recurse into subdirectories of this directory.
        Dim subdirectory As String
        For Each subdirectory In subdirectoryEntries
            ProcessDirectory(subdirectory)
        Next subdirectory
    End Sub

    Public Function CreateExportFile(ByVal FileToExport As String, ByVal OverWriteExisting As Boolean, CreateDiskList As Boolean, IncludeExtensions As Boolean) As Boolean
        If File.Exists(FileToExport) = True And OverWriteExisting = False Then
            Return False
        Else
            If File.Exists(FileToExport) Then       'If File Exists
                File.Delete(FileToExport)           'Delete Original File
            End If
            If Not File.Exists(FileToExport) Then
                Using sw As StreamWriter = File.CreateText(FileToExport)    ' Create a file to write to. 
                    Dim str As ListViewItem
                    Dim count As Integer = 1
                    For Each str In lvSlotList.Items
                        sw.WriteLine(CStr(count).PadLeft(nUDDecimals.Value, "0") & str.Text)
                        count = count + 1
                    Next
                End Using
            End If
            If CreateDiskList = True Then
                Dim DiskList As String = FileToExport & ".DiskList.txt"     'Disk List File is always titles <FileName> + .DiskList.txt
                If Not File.Exists(DiskList) Then
                    Using sw As StreamWriter = File.CreateText(DiskList)
                        Dim str As ListViewItem
                        Dim count As Integer = 1
                        For Each str In lvSlotList.Items
                            If IncludeExtensions = True Then
                                sw.WriteLine(Path.GetFileName(str.Text))
                            Else
                                sw.WriteLine(Path.GetFileNameWithoutExtension(str.Text))
                            End If
                            count = count + 1
                        Next
                    End Using
                End If
            End If
            Return True
        End If
    End Function

    Private Sub BtnPopulate_Click(sender As Object, e As EventArgs) Handles btnPopulate.Click
        PopulateList(lvSource)
    End Sub

    Private Sub btnSetDir_Click(sender As Object, e As EventArgs) Handles btnSetDir.Click
        If FolderBrowserDialogSourceDir.ShowDialog = DialogResult.OK Then
            txtSource.Text = FolderBrowserDialogSourceDir.SelectedPath
            PopulateList(lvSource)
        End If
    End Sub

    Private Sub btnSaveList_Click(sender As Object, e As EventArgs) Handles btnSaveList.Click
        If SaveFileDialogExportList.ShowDialog = DialogResult.OK Then
            If CreateExportFile(SaveFileDialogExportList.FileName, True, chkIncludeDiskList.Checked, chkIncludeDiskListExt.Checked) = True Then
                MessageBox.Show("Export List Successfully created: " & vbCrLf & SaveFileDialogExportList.FileName)
            Else
                MessageBox.Show("Could Not create Export List")
            End If
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "HxC HXCFEMNG slot list creator v" + My.Application.Info.Version.ToString

        If My.Settings.UpdateSettings = True Then                       'Copy user settings from previous application version if necessary
            My.Settings.Upgrade()
            My.Settings.UpdateSettings = False
            My.Settings.Save()
        End If

        lvSource.Items.Clear()
        lvSource.HeaderStyle = ColumnHeaderStyle.None
        Dim header = New ColumnHeader()
        header.Text = ""
        header.Name = "col1"
        header.Width = -2
        lvSource.Columns.Add(header)

        My.Settings.Reload()
        txtSource.Text = My.Settings.LastUsedDir

        Dim header2 = New ColumnHeader()
        header2.Text = ""
        header2.Name = "col1"
        header2.Width = -2
        lvSlotList.Items.Clear()
        lvSlotList.HeaderStyle = ColumnHeaderStyle.None
        lvSlotList.Columns.Add(header2)

        cmbDriveLabel.Items.Clear()
        For Each Drive As System.IO.DriveInfo In My.Computer.FileSystem.Drives
            cmbDriveLabel.Items.Add(Drive.Name)
        Next

        Dim TempSaveFile As String = Application.StartupPath & "\Temp.dat"          'Create the name of a temp file, called Temp.dat in the main program directory.
        LoadGameListToListView(TempSaveFile, lvSlotList, False, 0)                  'Read into the current Slots (destination) list view, this temp file.

        UpdateListCount()
    End Sub

    Private Sub btnAddSingle_Click(sender As Object, e As EventArgs) Handles btnAddSingle.Click
        Dim selfile As ListViewItem
        For Each selfile In lvSource.SelectedItems
            lvSlotList.Items.Add(selfile.Text)
        Next selfile
        UpdateListCount()
    End Sub

    Private Sub cmbSourceList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSourceList.SelectedIndexChanged
        Select Case cmbSourceList.SelectedIndex
            Case 0
                'Commodore Amiga
                txtDiskPatterns.Text = ".adf|.adz|.dms|.amigados|.raw|.ipf|.hfe"
            Case 1
                'Atari ST
                txtDiskPatterns.Text = ".dim|.msa|.st|.stt|.stw|.stx|.raw|.ipf|.hfe"
            Case 2
                'IBM PC
                txtDiskPatterns.Text = ".img|.imz|.raw|.ipf|.hfe"
            Case 3
                'Common
                txtDiskPatterns.Text = ".adf|.ipf|.hfe|.st|.dsk|.img|.ima"
            Case 4
                'All
                txtDiskPatterns.Text = ""
        End Select
    End Sub

    Private Sub btnAddAll_Click(sender As Object, e As EventArgs) Handles btnAddAll.Click
        Dim selfile As ListViewItem
        For Each selfile In lvSource.Items
            lvSlotList.Items.Add(selfile.Text)
        Next selfile
        UpdateListCount()
    End Sub

    Private Sub btnRemoveAll_Click(sender As Object, e As EventArgs) Handles btnRemoveAll.Click
        lvSlotList.Items.Clear()
        UpdateListCount()
    End Sub

    Private Sub btnRemoveSingle_Click(sender As Object, e As EventArgs) Handles btnRemoveSingle.Click
        Dim selfile As ListViewItem
        For Each selfile In lvSlotList.SelectedItems
            selfile.Remove()
        Next selfile
        UpdateListCount()
    End Sub

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        lvSlotList.Sorting = SortOrder.Descending
        lvSlotList.Sort()
        lvSlotList.Sorting = SortOrder.None
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSortAsc.Click
        lvSlotList.Sorting = SortOrder.Ascending
        lvSlotList.Sort()
        lvSlotList.Sorting = SortOrder.None
    End Sub

    Private Sub chkIncludeDiskList_CheckedChanged(sender As Object, e As EventArgs) Handles chkIncludeDiskList.CheckedChanged
        chkIncludeDiskListExt.Enabled = chkIncludeDiskList.Checked
    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SaveCurrentGameListToTempFile(lvSlotList)
    End Sub

    Private Sub btnCopyGames_Click(sender As Object, e As EventArgs) Handles btnCopyGames.Click
        If (txtSource.Text <> "") And (cmbDriveLabel.Text <> "") Then
            txtSource.Text.TrimEnd(" ", Path.DirectorySeparatorChar)                                            'Remove anny trailing spaces
            If Not txtSource.Text.EndsWith(Path.DirectorySeparatorChar) Then
                txtSource.Text = txtSource.Text & Path.DirectorySeparatorChar                                   'Set a trailing backslash
            End If
            CopyGamesToUSB(txtSource.Text, cmbDriveLabel.Text, chkOverWriteFiles.Checked)
        Else
            MessageBox.Show("Source Dir and Drive Label cannot be blank.")
        End If
    End Sub

    Private Sub btnLoadList_Click(sender As Object, e As EventArgs) Handles btnLoadList.Click
        SaveFileDialogLoadDisk.CreatePrompt = False
        SaveFileDialogLoadDisk.ValidateNames = True
        If SaveFileDialogLoadDisk.ShowDialog = DialogResult.OK Then
            'lvSlotList.Clear
            LoadGameListToListView(SaveFileDialogLoadDisk.FileName, lvSlotList, True, nUDDecimals.Value)
            UpdateListCount()
        End If
    End Sub

    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        Dim selfile As ListViewItem
        For Each selfile In lvSlotList.SelectedItems
            Try
                Dim i As Integer = selfile.Index
                selfile.Remove()
                Dim i2 As Integer = i - 1
                If i2 < 0 Then i2 = 0
                lvSlotList.Items.Insert(i2, selfile)
            Catch ex As Exception
            End Try
        Next selfile
    End Sub

    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click
        Dim selfile As ListViewItem
        For Each selfile In lvSlotList.SelectedItems
            Try
                Dim i As Integer = selfile.Index
                selfile.Remove()
                Dim i2 As Integer = i + 1
                If i2 > lvSlotList.Items.Count + 1 Then
                    i2 = lvSlotList.Items.Count + 1
                    lvSlotList.Items.Insert(i2, selfile)
                Else
                    lvSlotList.Items.Add(selfile)
                End If

            Catch ex As Exception
            End Try
        Next selfile
    End Sub

    Private Sub btnTop_Click(sender As Object, e As EventArgs) Handles btnTop.Click
        Dim selfile As ListViewItem
        Dim i As Integer = 0
        For Each selfile In lvSlotList.SelectedItems
            Try
                selfile.Remove()
                lvSlotList.Items.Insert(i, selfile)
                i = i + 1
            Catch ex As Exception
            End Try
        Next selfile
    End Sub

    Private Sub btnBottom_Click(sender As Object, e As EventArgs) Handles btnBottom.Click
        Dim selfile As ListViewItem
        For Each selfile In lvSlotList.SelectedItems
            Try
                selfile.Remove()
                lvSlotList.Items.Add(selfile)
            Catch ex As Exception
            End Try
        Next selfile
    End Sub
End Class
