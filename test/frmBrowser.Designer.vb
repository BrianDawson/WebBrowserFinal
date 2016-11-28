<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBrowser
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBrowser))
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebsitePropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrinTPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cboURL = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.WebBrowser = New System.Windows.Forms.TabControl()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.rdoGoogle = New System.Windows.Forms.RadioButton()
        Me.rdoYahoo = New System.Windows.Forms.RadioButton()
        Me.rdoBing = New System.Windows.Forms.RadioButton()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.picFavorites = New System.Windows.Forms.PictureBox()
        Me.picSearch = New System.Windows.Forms.PictureBox()
        Me.picGo = New System.Windows.Forms.PictureBox()
        Me.picLock = New System.Windows.Forms.PictureBox()
        Me.picHome = New System.Windows.Forms.PictureBox()
        Me.picStop = New System.Windows.Forms.PictureBox()
        Me.picRefresh = New System.Windows.Forms.PictureBox()
        Me.picBack = New System.Windows.Forms.PictureBox()
        Me.picForward = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        CType(Me.picFavorites, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picForward, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Timer1
        '
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'WebsitePropertiesToolStripMenuItem
        '
        Me.WebsitePropertiesToolStripMenuItem.Name = "WebsitePropertiesToolStripMenuItem"
        Me.WebsitePropertiesToolStripMenuItem.Size = New System.Drawing.Size(117, 20)
        Me.WebsitePropertiesToolStripMenuItem.Text = "Website Properties"
        '
        'RemoveTabToolStripMenuItem
        '
        Me.RemoveTabToolStripMenuItem.Name = "RemoveTabToolStripMenuItem"
        Me.RemoveTabToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.RemoveTabToolStripMenuItem.Text = "Remove Tab"
        '
        'AddTabToolStripMenuItem
        '
        Me.AddTabToolStripMenuItem.Name = "AddTabToolStripMenuItem"
        Me.AddTabToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.AddTabToolStripMenuItem.Text = "Add Tab"
        '
        'PrinTPreviewToolStripMenuItem
        '
        Me.PrinTPreviewToolStripMenuItem.Name = "PrinTPreviewToolStripMenuItem"
        Me.PrinTPreviewToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.PrinTPreviewToolStripMenuItem.Text = "Print Preview"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripMenuItem, Me.PrinTPreviewToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'cboURL
        '
        Me.cboURL.FormattingEnabled = True
        Me.cboURL.Location = New System.Drawing.Point(341, 29)
        Me.cboURL.Name = "cboURL"
        Me.cboURL.Size = New System.Drawing.Size(1239, 21)
        Me.cboURL.TabIndex = 28
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AddTabToolStripMenuItem, Me.RemoveTabToolStripMenuItem, Me.WebsitePropertiesToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1904, 24)
        Me.MenuStrip1.TabIndex = 29
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 1019)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1904, 22)
        Me.StatusStrip1.TabIndex = 27
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(150, 150)
        Me.ToolStripContainer1.Location = New System.Drawing.Point(25, 1022)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(150, 175)
        Me.ToolStripContainer1.TabIndex = 26
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(1617, 29)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(194, 20)
        Me.txtSearch.TabIndex = 24
        Me.txtSearch.Text = "Search"
        '
        'WebBrowser
        '
        Me.WebBrowser.Location = New System.Drawing.Point(4, 53)
        Me.WebBrowser.Name = "WebBrowser"
        Me.WebBrowser.SelectedIndex = 0
        Me.WebBrowser.Size = New System.Drawing.Size(1904, 975)
        Me.WebBrowser.TabIndex = 23
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'rdoGoogle
        '
        Me.rdoGoogle.AutoSize = True
        Me.rdoGoogle.Location = New System.Drawing.Point(1638, 4)
        Me.rdoGoogle.Name = "rdoGoogle"
        Me.rdoGoogle.Size = New System.Drawing.Size(59, 17)
        Me.rdoGoogle.TabIndex = 40
        Me.rdoGoogle.TabStop = True
        Me.rdoGoogle.Text = "Google"
        Me.rdoGoogle.UseVisualStyleBackColor = True
        '
        'rdoYahoo
        '
        Me.rdoYahoo.AutoSize = True
        Me.rdoYahoo.Location = New System.Drawing.Point(1703, 4)
        Me.rdoYahoo.Name = "rdoYahoo"
        Me.rdoYahoo.Size = New System.Drawing.Size(56, 17)
        Me.rdoYahoo.TabIndex = 41
        Me.rdoYahoo.TabStop = True
        Me.rdoYahoo.Text = "Yahoo"
        Me.rdoYahoo.UseVisualStyleBackColor = True
        '
        'rdoBing
        '
        Me.rdoBing.AutoSize = True
        Me.rdoBing.Location = New System.Drawing.Point(1765, 4)
        Me.rdoBing.Name = "rdoBing"
        Me.rdoBing.Size = New System.Drawing.Size(46, 17)
        Me.rdoBing.TabIndex = 42
        Me.rdoBing.TabStop = True
        Me.rdoBing.Text = "Bing"
        Me.rdoBing.UseVisualStyleBackColor = True
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(1513, 6)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(119, 13)
        Me.lblSearch.TabIndex = 43
        Me.lblSearch.Text = "Choose Search Engine:"
        '
        'picFavorites
        '
        Me.picFavorites.BackgroundImage = Global.BrianWebBrowser.My.Resources.Resources.wm_fave
        Me.picFavorites.Location = New System.Drawing.Point(1867, -1)
        Me.picFavorites.Name = "picFavorites"
        Me.picFavorites.Size = New System.Drawing.Size(25, 25)
        Me.picFavorites.TabIndex = 44
        Me.picFavorites.TabStop = False
        '
        'picSearch
        '
        Me.picSearch.Image = Global.BrianWebBrowser.My.Resources.Resources.wm_Search
        Me.picSearch.Location = New System.Drawing.Point(1817, 27)
        Me.picSearch.Name = "picSearch"
        Me.picSearch.Size = New System.Drawing.Size(25, 25)
        Me.picSearch.TabIndex = 39
        Me.picSearch.TabStop = False
        '
        'picGo
        '
        Me.picGo.Image = Global.BrianWebBrowser.My.Resources.Resources.wm_Go
        Me.picGo.Location = New System.Drawing.Point(1586, 27)
        Me.picGo.Name = "picGo"
        Me.picGo.Size = New System.Drawing.Size(25, 25)
        Me.picGo.TabIndex = 38
        Me.picGo.TabStop = False
        '
        'picLock
        '
        Me.picLock.Image = Global.BrianWebBrowser.My.Resources.Resources.wm_lock
        Me.picLock.Location = New System.Drawing.Point(310, 29)
        Me.picLock.Name = "picLock"
        Me.picLock.Size = New System.Drawing.Size(25, 25)
        Me.picLock.TabIndex = 37
        Me.picLock.TabStop = False
        '
        'picHome
        '
        Me.picHome.Image = Global.BrianWebBrowser.My.Resources.Resources.wm_home
        Me.picHome.Location = New System.Drawing.Point(142, 27)
        Me.picHome.Name = "picHome"
        Me.picHome.Size = New System.Drawing.Size(25, 25)
        Me.picHome.TabIndex = 36
        Me.picHome.TabStop = False
        '
        'picStop
        '
        Me.picStop.Image = Global.BrianWebBrowser.My.Resources.Resources.wm_stop
        Me.picStop.Location = New System.Drawing.Point(111, 27)
        Me.picStop.Name = "picStop"
        Me.picStop.Size = New System.Drawing.Size(25, 25)
        Me.picStop.TabIndex = 35
        Me.picStop.TabStop = False
        '
        'picRefresh
        '
        Me.picRefresh.Image = Global.BrianWebBrowser.My.Resources.Resources.wm_refresh
        Me.picRefresh.Location = New System.Drawing.Point(80, 27)
        Me.picRefresh.Name = "picRefresh"
        Me.picRefresh.Size = New System.Drawing.Size(25, 25)
        Me.picRefresh.TabIndex = 34
        Me.picRefresh.TabStop = False
        '
        'picBack
        '
        Me.picBack.Image = Global.BrianWebBrowser.My.Resources.Resources.wm_back
        Me.picBack.Location = New System.Drawing.Point(16, 27)
        Me.picBack.Name = "picBack"
        Me.picBack.Size = New System.Drawing.Size(25, 25)
        Me.picBack.TabIndex = 32
        Me.picBack.TabStop = False
        '
        'picForward
        '
        Me.picForward.Image = Global.BrianWebBrowser.My.Resources.Resources.wm_forward
        Me.picForward.Location = New System.Drawing.Point(47, 27)
        Me.picForward.Name = "picForward"
        Me.picForward.Size = New System.Drawing.Size(25, 25)
        Me.picForward.TabIndex = 33
        Me.picForward.TabStop = False
        '
        'frmBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.picFavorites)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.rdoBing)
        Me.Controls.Add(Me.rdoYahoo)
        Me.Controls.Add(Me.rdoGoogle)
        Me.Controls.Add(Me.picSearch)
        Me.Controls.Add(Me.picGo)
        Me.Controls.Add(Me.picLock)
        Me.Controls.Add(Me.picHome)
        Me.Controls.Add(Me.picStop)
        Me.Controls.Add(Me.picRefresh)
        Me.Controls.Add(Me.picBack)
        Me.Controls.Add(Me.cboURL)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.picForward)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.WebBrowser)
        Me.KeyPreview = True
        Me.Name = "frmBrowser"
        Me.Text = "Dawson Browser"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        CType(Me.picFavorites, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picForward, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picRefresh As System.Windows.Forms.PictureBox
    Friend WithEvents picBack As System.Windows.Forms.PictureBox
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WebsitePropertiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveTabToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddTabToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrinTPreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cboURL As System.Windows.Forms.ComboBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents picForward As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents WebBrowser As System.Windows.Forms.TabControl
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents picStop As System.Windows.Forms.PictureBox
    Friend WithEvents picHome As System.Windows.Forms.PictureBox
    Friend WithEvents picLock As System.Windows.Forms.PictureBox
    Friend WithEvents picGo As System.Windows.Forms.PictureBox
    Friend WithEvents picSearch As System.Windows.Forms.PictureBox
    Friend WithEvents rdoYahoo As System.Windows.Forms.RadioButton
    Friend WithEvents rdoGoogle As System.Windows.Forms.RadioButton
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents rdoBing As System.Windows.Forms.RadioButton
    Friend WithEvents picFavorites As System.Windows.Forms.PictureBox

End Class
