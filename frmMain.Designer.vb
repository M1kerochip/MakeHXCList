<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.txtSource = New System.Windows.Forms.TextBox()
        Me.lblSourceFileDir = New System.Windows.Forms.Label()
        Me.lvSource = New System.Windows.Forms.ListView()
        Me.gbSource = New System.Windows.Forms.GroupBox()
        Me.txtDiskPatterns = New System.Windows.Forms.TextBox()
        Me.lblSourceDiskImageExt = New System.Windows.Forms.Label()
        Me.cmbSourceList = New System.Windows.Forms.ComboBox()
        Me.btnPopulate = New System.Windows.Forms.Button()
        Me.btnSetDir = New System.Windows.Forms.Button()
        Me.gboxExportList = New System.Windows.Forms.GroupBox()
        Me.btnLoadList = New System.Windows.Forms.Button()
        Me.lblDestinationDrive = New System.Windows.Forms.Label()
        Me.cmbDriveLabel = New System.Windows.Forms.ComboBox()
        Me.chkIncludeDiskListExt = New System.Windows.Forms.CheckBox()
        Me.chkIncludeDiskList = New System.Windows.Forms.CheckBox()
        Me.btnSortAsc = New System.Windows.Forms.Button()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.btnSaveList = New System.Windows.Forms.Button()
        Me.nUDDecimals = New System.Windows.Forms.NumericUpDown()
        Me.lblDecimalsList = New System.Windows.Forms.Label()
        Me.lvSlotList = New System.Windows.Forms.ListView()
        Me.FolderBrowserDialogSourceDir = New System.Windows.Forms.FolderBrowserDialog()
        Me.SaveFileDialogExportList = New System.Windows.Forms.SaveFileDialog()
        Me.pnlFilesList = New System.Windows.Forms.Panel()
        Me.pnlControls = New System.Windows.Forms.Panel()
        Me.chkOverWriteFiles = New System.Windows.Forms.CheckBox()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnBottom = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnCopyGames = New System.Windows.Forms.Button()
        Me.btnTop = New System.Windows.Forms.Button()
        Me.btnRemoveAll = New System.Windows.Forms.Button()
        Me.btnRemoveSingle = New System.Windows.Forms.Button()
        Me.btnAddAll = New System.Windows.Forms.Button()
        Me.btnAddSingle = New System.Windows.Forms.Button()
        Me.SaveFileDialogLoadDisk = New System.Windows.Forms.SaveFileDialog()
        Me.gbSource.SuspendLayout()
        Me.gboxExportList.SuspendLayout()
        CType(Me.nUDDecimals, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlControls.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSource
        '
        Me.txtSource.Location = New System.Drawing.Point(6, 32)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Size = New System.Drawing.Size(374, 20)
        Me.txtSource.TabIndex = 0
        Me.txtSource.Text = "F:\"
        '
        'lblSourceFileDir
        '
        Me.lblSourceFileDir.AutoSize = True
        Me.lblSourceFileDir.Location = New System.Drawing.Point(6, 16)
        Me.lblSourceFileDir.Name = "lblSourceFileDir"
        Me.lblSourceFileDir.Size = New System.Drawing.Size(86, 13)
        Me.lblSourceFileDir.TabIndex = 1
        Me.lblSourceFileDir.Text = "Source Directory"
        '
        'lvSource
        '
        Me.lvSource.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvSource.AutoArrange = False
        Me.lvSource.FullRowSelect = True
        Me.lvSource.GridLines = True
        Me.lvSource.HideSelection = False
        Me.lvSource.LabelWrap = False
        Me.lvSource.Location = New System.Drawing.Point(6, 96)
        Me.lvSource.Name = "lvSource"
        Me.lvSource.ShowGroups = False
        Me.lvSource.Size = New System.Drawing.Size(510, 768)
        Me.lvSource.TabIndex = 22
        Me.lvSource.UseCompatibleStateImageBehavior = False
        Me.lvSource.View = System.Windows.Forms.View.Details
        '
        'gbSource
        '
        Me.gbSource.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbSource.Controls.Add(Me.txtDiskPatterns)
        Me.gbSource.Controls.Add(Me.lblSourceDiskImageExt)
        Me.gbSource.Controls.Add(Me.cmbSourceList)
        Me.gbSource.Controls.Add(Me.btnPopulate)
        Me.gbSource.Controls.Add(Me.btnSetDir)
        Me.gbSource.Controls.Add(Me.lvSource)
        Me.gbSource.Controls.Add(Me.lblSourceFileDir)
        Me.gbSource.Controls.Add(Me.txtSource)
        Me.gbSource.Location = New System.Drawing.Point(12, 12)
        Me.gbSource.Name = "gbSource"
        Me.gbSource.Size = New System.Drawing.Size(525, 873)
        Me.gbSource.TabIndex = 4
        Me.gbSource.TabStop = False
        Me.gbSource.Text = "Files List (Source Directory)"
        '
        'txtDiskPatterns
        '
        Me.txtDiskPatterns.Location = New System.Drawing.Point(125, 70)
        Me.txtDiskPatterns.Name = "txtDiskPatterns"
        Me.txtDiskPatterns.Size = New System.Drawing.Size(285, 20)
        Me.txtDiskPatterns.TabIndex = 15
        Me.txtDiskPatterns.Text = ".adf|.ipf|.hfe|.st|.dsk|.img|.ima"
        '
        'lblSourceDiskImageExt
        '
        Me.lblSourceDiskImageExt.AutoSize = True
        Me.lblSourceDiskImageExt.Location = New System.Drawing.Point(3, 55)
        Me.lblSourceDiskImageExt.Name = "lblSourceDiskImageExt"
        Me.lblSourceDiskImageExt.Size = New System.Drawing.Size(151, 13)
        Me.lblSourceDiskImageExt.TabIndex = 12
        Me.lblSourceDiskImageExt.Text = "Source Disk Image Extensions"
        '
        'cmbSourceList
        '
        Me.cmbSourceList.FormattingEnabled = True
        Me.cmbSourceList.Items.AddRange(New Object() {"Commodore Amiga", "Atari ST", "IMB PC", "Common", "ALL"})
        Me.cmbSourceList.Location = New System.Drawing.Point(6, 70)
        Me.cmbSourceList.Name = "cmbSourceList"
        Me.cmbSourceList.Size = New System.Drawing.Size(113, 21)
        Me.cmbSourceList.TabIndex = 10
        Me.cmbSourceList.Text = "Common"
        '
        'btnPopulate
        '
        Me.btnPopulate.Location = New System.Drawing.Point(416, 32)
        Me.btnPopulate.Name = "btnPopulate"
        Me.btnPopulate.Size = New System.Drawing.Size(100, 58)
        Me.btnPopulate.TabIndex = 20
        Me.btnPopulate.Text = "&Populate"
        Me.btnPopulate.UseVisualStyleBackColor = True
        '
        'btnSetDir
        '
        Me.btnSetDir.Location = New System.Drawing.Point(386, 32)
        Me.btnSetDir.Name = "btnSetDir"
        Me.btnSetDir.Size = New System.Drawing.Size(24, 20)
        Me.btnSetDir.TabIndex = 5
        Me.btnSetDir.Text = "..."
        Me.btnSetDir.UseVisualStyleBackColor = True
        '
        'gboxExportList
        '
        Me.gboxExportList.AutoSize = True
        Me.gboxExportList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gboxExportList.Controls.Add(Me.btnLoadList)
        Me.gboxExportList.Controls.Add(Me.lblDestinationDrive)
        Me.gboxExportList.Controls.Add(Me.cmbDriveLabel)
        Me.gboxExportList.Controls.Add(Me.chkIncludeDiskListExt)
        Me.gboxExportList.Controls.Add(Me.chkIncludeDiskList)
        Me.gboxExportList.Controls.Add(Me.btnSortAsc)
        Me.gboxExportList.Controls.Add(Me.btnSort)
        Me.gboxExportList.Controls.Add(Me.btnSaveList)
        Me.gboxExportList.Controls.Add(Me.nUDDecimals)
        Me.gboxExportList.Controls.Add(Me.lblDecimalsList)
        Me.gboxExportList.Controls.Add(Me.lvSlotList)
        Me.gboxExportList.Location = New System.Drawing.Point(655, 12)
        Me.gboxExportList.Name = "gboxExportList"
        Me.gboxExportList.Size = New System.Drawing.Size(522, 877)
        Me.gboxExportList.TabIndex = 9
        Me.gboxExportList.TabStop = False
        Me.gboxExportList.Text = "Export List (Destination Drive)"
        '
        'btnLoadList
        '
        Me.btnLoadList.Location = New System.Drawing.Point(335, 69)
        Me.btnLoadList.Name = "btnLoadList"
        Me.btnLoadList.Size = New System.Drawing.Size(75, 21)
        Me.btnLoadList.TabIndex = 95
        Me.btnLoadList.Text = "&Load List"
        Me.btnLoadList.UseVisualStyleBackColor = True
        '
        'lblDestinationDrive
        '
        Me.lblDestinationDrive.AutoSize = True
        Me.lblDestinationDrive.Location = New System.Drawing.Point(6, 55)
        Me.lblDestinationDrive.Name = "lblDestinationDrive"
        Me.lblDestinationDrive.Size = New System.Drawing.Size(61, 13)
        Me.lblDestinationDrive.TabIndex = 14
        Me.lblDestinationDrive.Text = "Drive Label"
        '
        'cmbDriveLabel
        '
        Me.cmbDriveLabel.FormattingEnabled = True
        Me.cmbDriveLabel.ItemHeight = 13
        Me.cmbDriveLabel.Location = New System.Drawing.Point(9, 70)
        Me.cmbDriveLabel.Name = "cmbDriveLabel"
        Me.cmbDriveLabel.Size = New System.Drawing.Size(58, 21)
        Me.cmbDriveLabel.TabIndex = 90
        '
        'chkIncludeDiskListExt
        '
        Me.chkIncludeDiskListExt.AutoSize = True
        Me.chkIncludeDiskListExt.Checked = True
        Me.chkIncludeDiskListExt.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIncludeDiskListExt.Enabled = False
        Me.chkIncludeDiskListExt.Location = New System.Drawing.Point(257, 33)
        Me.chkIncludeDiskListExt.Name = "chkIncludeDiskListExt"
        Me.chkIncludeDiskListExt.Size = New System.Drawing.Size(146, 17)
        Me.chkIncludeDiskListExt.TabIndex = 85
        Me.chkIncludeDiskListExt.Text = "Include Disk List Disk &Ext"
        Me.chkIncludeDiskListExt.UseVisualStyleBackColor = True
        '
        'chkIncludeDiskList
        '
        Me.chkIncludeDiskList.AutoSize = True
        Me.chkIncludeDiskList.Location = New System.Drawing.Point(147, 33)
        Me.chkIncludeDiskList.Name = "chkIncludeDiskList"
        Me.chkIncludeDiskList.Size = New System.Drawing.Size(104, 17)
        Me.chkIncludeDiskList.TabIndex = 80
        Me.chkIncludeDiskList.Text = "&Include Disk List"
        Me.chkIncludeDiskList.UseVisualStyleBackColor = True
        '
        'btnSortAsc
        '
        Me.btnSortAsc.Location = New System.Drawing.Point(228, 69)
        Me.btnSortAsc.Name = "btnSortAsc"
        Me.btnSortAsc.Size = New System.Drawing.Size(75, 21)
        Me.btnSortAsc.TabIndex = 105
        Me.btnSortAsc.Text = "Sort (&Asc)"
        Me.btnSortAsc.UseVisualStyleBackColor = True
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(147, 69)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(75, 21)
        Me.btnSort.TabIndex = 100
        Me.btnSort.Text = "Sort (&Dec)"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'btnSaveList
        '
        Me.btnSaveList.Location = New System.Drawing.Point(416, 32)
        Me.btnSaveList.Name = "btnSaveList"
        Me.btnSaveList.Size = New System.Drawing.Size(100, 58)
        Me.btnSaveList.TabIndex = 110
        Me.btnSaveList.Text = "&SaveList"
        Me.btnSaveList.UseVisualStyleBackColor = True
        '
        'nUDDecimals
        '
        Me.nUDDecimals.Location = New System.Drawing.Point(9, 32)
        Me.nUDDecimals.Name = "nUDDecimals"
        Me.nUDDecimals.Size = New System.Drawing.Size(51, 20)
        Me.nUDDecimals.TabIndex = 75
        Me.nUDDecimals.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'lblDecimalsList
        '
        Me.lblDecimalsList.AutoSize = True
        Me.lblDecimalsList.Location = New System.Drawing.Point(6, 16)
        Me.lblDecimalsList.Name = "lblDecimalsList"
        Me.lblDecimalsList.Size = New System.Drawing.Size(114, 13)
        Me.lblDecimalsList.TabIndex = 6
        Me.lblDecimalsList.Text = "Pad to Decimal Places"
        '
        'lvSlotList
        '
        Me.lvSlotList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvSlotList.FullRowSelect = True
        Me.lvSlotList.GridLines = True
        Me.lvSlotList.HideSelection = False
        Me.lvSlotList.LabelWrap = False
        Me.lvSlotList.Location = New System.Drawing.Point(6, 97)
        Me.lvSlotList.Name = "lvSlotList"
        Me.lvSlotList.ShowGroups = False
        Me.lvSlotList.Size = New System.Drawing.Size(510, 771)
        Me.lvSlotList.TabIndex = 120
        Me.lvSlotList.UseCompatibleStateImageBehavior = False
        Me.lvSlotList.View = System.Windows.Forms.View.Details
        '
        'pnlFilesList
        '
        Me.pnlFilesList.AutoSize = True
        Me.pnlFilesList.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlFilesList.Location = New System.Drawing.Point(0, 0)
        Me.pnlFilesList.Name = "pnlFilesList"
        Me.pnlFilesList.Size = New System.Drawing.Size(0, 895)
        Me.pnlFilesList.TabIndex = 10
        '
        'pnlControls
        '
        Me.pnlControls.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlControls.AutoSize = True
        Me.pnlControls.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnlControls.Controls.Add(Me.chkOverWriteFiles)
        Me.pnlControls.Controls.Add(Me.btnUp)
        Me.pnlControls.Controls.Add(Me.btnBottom)
        Me.pnlControls.Controls.Add(Me.btnDown)
        Me.pnlControls.Controls.Add(Me.btnCopyGames)
        Me.pnlControls.Controls.Add(Me.btnTop)
        Me.pnlControls.Controls.Add(Me.btnRemoveAll)
        Me.pnlControls.Controls.Add(Me.btnRemoveSingle)
        Me.pnlControls.Controls.Add(Me.btnAddAll)
        Me.pnlControls.Controls.Add(Me.btnAddSingle)
        Me.pnlControls.Location = New System.Drawing.Point(543, 28)
        Me.pnlControls.Name = "pnlControls"
        Me.pnlControls.Size = New System.Drawing.Size(106, 858)
        Me.pnlControls.TabIndex = 11
        '
        'chkOverWriteFiles
        '
        Me.chkOverWriteFiles.Location = New System.Drawing.Point(12, 807)
        Me.chkOverWriteFiles.Name = "chkOverWriteFiles"
        Me.chkOverWriteFiles.Size = New System.Drawing.Size(78, 48)
        Me.chkOverWriteFiles.TabIndex = 70
        Me.chkOverWriteFiles.Text = "&Overwrite Existing Games"
        Me.chkOverWriteFiles.UseVisualStyleBackColor = True
        '
        'btnUp
        '
        Me.btnUp.Location = New System.Drawing.Point(3, 453)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(100, 23)
        Me.btnUp.TabIndex = 50
        Me.btnUp.Text = "Move Up ^"
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'btnBottom
        '
        Me.btnBottom.Location = New System.Drawing.Point(3, 540)
        Me.btnBottom.Name = "btnBottom"
        Me.btnBottom.Size = New System.Drawing.Size(100, 23)
        Me.btnBottom.TabIndex = 60
        Me.btnBottom.Text = "Bottom vv"
        Me.btnBottom.UseVisualStyleBackColor = True
        '
        'btnDown
        '
        Me.btnDown.Location = New System.Drawing.Point(3, 511)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(100, 23)
        Me.btnDown.TabIndex = 55
        Me.btnDown.Text = "Move Down v"
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'btnCopyGames
        '
        Me.btnCopyGames.Location = New System.Drawing.Point(3, 778)
        Me.btnCopyGames.Name = "btnCopyGames"
        Me.btnCopyGames.Size = New System.Drawing.Size(100, 23)
        Me.btnCopyGames.TabIndex = 65
        Me.btnCopyGames.Text = "&Copy Games"
        Me.btnCopyGames.UseVisualStyleBackColor = True
        '
        'btnTop
        '
        Me.btnTop.Location = New System.Drawing.Point(3, 424)
        Me.btnTop.Name = "btnTop"
        Me.btnTop.Size = New System.Drawing.Size(100, 23)
        Me.btnTop.TabIndex = 45
        Me.btnTop.Text = "Top ^^"
        Me.btnTop.UseVisualStyleBackColor = True
        '
        'btnRemoveAll
        '
        Me.btnRemoveAll.Location = New System.Drawing.Point(3, 268)
        Me.btnRemoveAll.Name = "btnRemoveAll"
        Me.btnRemoveAll.Size = New System.Drawing.Size(100, 23)
        Me.btnRemoveAll.TabIndex = 40
        Me.btnRemoveAll.Text = "Remove All <<"
        Me.btnRemoveAll.UseVisualStyleBackColor = True
        '
        'btnRemoveSingle
        '
        Me.btnRemoveSingle.Location = New System.Drawing.Point(3, 239)
        Me.btnRemoveSingle.Name = "btnRemoveSingle"
        Me.btnRemoveSingle.Size = New System.Drawing.Size(100, 23)
        Me.btnRemoveSingle.TabIndex = 35
        Me.btnRemoveSingle.Text = "&Remove <"
        Me.btnRemoveSingle.UseVisualStyleBackColor = True
        '
        'btnAddAll
        '
        Me.btnAddAll.Location = New System.Drawing.Point(3, 163)
        Me.btnAddAll.Name = "btnAddAll"
        Me.btnAddAll.Size = New System.Drawing.Size(100, 23)
        Me.btnAddAll.TabIndex = 30
        Me.btnAddAll.Text = "Add All >>"
        Me.btnAddAll.UseVisualStyleBackColor = True
        '
        'btnAddSingle
        '
        Me.btnAddSingle.Location = New System.Drawing.Point(3, 134)
        Me.btnAddSingle.Name = "btnAddSingle"
        Me.btnAddSingle.Size = New System.Drawing.Size(100, 23)
        Me.btnAddSingle.TabIndex = 25
        Me.btnAddSingle.Text = "&Add >"
        Me.btnAddSingle.UseVisualStyleBackColor = True
        '
        'SaveFileDialogLoadDisk
        '
        Me.SaveFileDialogLoadDisk.AddExtension = False
        Me.SaveFileDialogLoadDisk.Filter = "Text Files|*.txt|All Files|*.*"
        Me.SaveFileDialogLoadDisk.Title = "Load Disk List"
        '
        'frmMain
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1190, 895)
        Me.Controls.Add(Me.gbSource)
        Me.Controls.Add(Me.pnlControls)
        Me.Controls.Add(Me.pnlFilesList)
        Me.Controls.Add(Me.gboxExportList)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HxC HXCFEMNG slot list creator v1.0"
        Me.gbSource.ResumeLayout(False)
        Me.gbSource.PerformLayout()
        Me.gboxExportList.ResumeLayout(False)
        Me.gboxExportList.PerformLayout()
        CType(Me.nUDDecimals, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlControls.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSource As TextBox
    Friend WithEvents lblSourceFileDir As Label
    Friend WithEvents lvSource As ListView
    Friend WithEvents gbSource As GroupBox
    Friend WithEvents btnPopulate As Button
    Friend WithEvents btnSetDir As Button
    Friend WithEvents gboxExportList As GroupBox
    Friend WithEvents nUDDecimals As NumericUpDown
    Friend WithEvents lblDecimalsList As Label
    Friend WithEvents lvSlotList As ListView
    Friend WithEvents FolderBrowserDialogSourceDir As FolderBrowserDialog
    Friend WithEvents btnSaveList As Button
    Friend WithEvents txtDiskPatterns As TextBox
    Friend WithEvents lblSourceDiskImageExt As Label
    Friend WithEvents cmbSourceList As ComboBox
    Friend WithEvents SaveFileDialogExportList As SaveFileDialog
    Friend WithEvents btnSort As Button
    Friend WithEvents btnSortAsc As Button
    Friend WithEvents pnlFilesList As Panel
    Friend WithEvents pnlControls As Panel
    Friend WithEvents btnRemoveAll As Button
    Friend WithEvents btnRemoveSingle As Button
    Friend WithEvents btnAddAll As Button
    Friend WithEvents btnAddSingle As Button
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents btnCopyGames As Button
    Friend WithEvents chkIncludeDiskList As CheckBox
    Friend WithEvents chkIncludeDiskListExt As CheckBox
    Friend WithEvents btnUp As Button
    Friend WithEvents btnBottom As Button
    Friend WithEvents btnDown As Button
    Friend WithEvents btnTop As Button
    Friend WithEvents lblDestinationDrive As Label
    Friend WithEvents cmbDriveLabel As ComboBox
    Friend WithEvents chkOverWriteFiles As CheckBox
    Friend WithEvents btnLoadList As Button
    Friend WithEvents SaveFileDialogLoadDisk As SaveFileDialog
End Class
