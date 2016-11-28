Public Class frmBrowser
    Dim int As Integer = 0

    'Progress Bar
    Private Sub Loading(ByVal sender As Object, ByVal e As Windows.Forms.WebBrowserProgressChangedEventArgs)
        ToolStripProgressBar1.Maximum = e.MaximumProgress
        ToolStripProgressBar1.Value = e.MaximumProgress
    End Sub

    'Changes Tab Title
    Private Sub Done(ByVal sender As Object, ByVal e As Windows.Forms.WebBrowserDocumentCompletedEventArgs)
        WebBrowser.SelectedTab.Text = CType(WebBrowser.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle
        cboURL.Text = CType(WebBrowser.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString
    End Sub

    Private Sub frmBrowser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Browser As New WebBrowser
        WebBrowser.TabPages.Add("New Page")
        Browser.Name = "Web Browser"
        Browser.Dock = DockStyle.Fill
        WebBrowser.SelectedTab.Controls.Add(Browser)
        AddHandler Browser.ProgressChanged, AddressOf Loading
        AddHandler Browser.DocumentCompleted, AddressOf Done
        int = int + 1
        CType(WebBrowser.SelectedTab.Controls.Item(0), WebBrowser).GoHome()
    End Sub

    Private Sub AddTabToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddTabToolStripMenuItem.Click
        Dim Browser As New WebBrowser
        WebBrowser.TabPages.Add("New Page")
        WebBrowser.SelectTab(int)
        Browser.Name = "Web Browser"
        Browser.Dock = DockStyle.Fill
        WebBrowser.SelectedTab.Controls.Add(Browser)
        AddHandler Browser.ProgressChanged, AddressOf Loading
        AddHandler Browser.DocumentCompleted, AddressOf Done
        int = int + 1
        CType(WebBrowser.SelectedTab.Controls.Item(0), WebBrowser).GoHome()
    End Sub

    'Remove Selected Tab
    Private Sub RemoveTabToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveTabToolStripMenuItem.Click
        If Not WebBrowser.TabPages.Count = 1 Then
            WebBrowser.TabPages.RemoveAt(WebBrowser.SelectedIndex)
            WebBrowser.SelectTab(WebBrowser.TabPages.Count - 1)
            int = int - 1
        End If
    End Sub

    'Show Internet Properties
    Private Sub WebsitePropertiesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WebsitePropertiesToolStripMenuItem.Click
        CType(WebBrowser.SelectedTab.Controls.Item(0), WebBrowser).ShowPropertiesDialog()
    End Sub

    'Go Back Button
    Private Sub picBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picBack.Click
        CType(WebBrowser.SelectedTab.Controls.Item(0), WebBrowser).GoBack()
    End Sub

    'Go Forward Button
    Private Sub picForward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picForward.Click
        CType(WebBrowser.SelectedTab.Controls.Item(0), WebBrowser).GoForward()
    End Sub

    'Refresh Button
    Private Sub picRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRefresh.Click
        CType(WebBrowser.SelectedTab.Controls.Item(0), WebBrowser).Refresh()
    End Sub

    'Stop Button
    Private Sub picStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picStop.Click
        CType(WebBrowser.SelectedTab.Controls.Item(0), WebBrowser).Stop()
    End Sub

    'Go Home Button
    Private Sub picHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picHome.Click
        CType(WebBrowser.SelectedTab.Controls.Item(0), WebBrowser).GoHome()
    End Sub

    'Goes To URL With Enter
    Private Sub frmBrowser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            CType(WebBrowser.SelectedTab.Controls.Item(0), WebBrowser).Navigate(cboURL.Text)
            cboURL.Items.Add(cboURL.Text)
        End If
    End Sub

    'Timer
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ToolStripProgressBar1.Text = CType(WebBrowser.SelectedTab.Controls.Item(0), WebBrowser).StatusText
    End Sub

    'Exits Program
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    'Search Funbction
    Private Sub picSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles picSearch.Click
        If rdoGoogle.Checked Then
            CType(WebBrowser.SelectedTab.Controls.Item(0), WebBrowser).Navigate("https://www.google.com/search?q=" & txtSearch.Text)
        ElseIf rdoYahoo.Checked Then
            CType(WebBrowser.SelectedTab.Controls.Item(0), WebBrowser).Navigate("https://www.yahoo.com/search?q=" & txtSearch.Text)
        ElseIf rdoBing.Checked Then
            CType(WebBrowser.SelectedTab.Controls.Item(0), WebBrowser).Navigate("https://www.bing.com/search?q=" & txtSearch.Text)
        ElseIf rdoGoogle.AutoCheck Then
            CType(WebBrowser.SelectedTab.Controls.Item(0), WebBrowser).Navigate("https://www.google.com/search?q=" & txtSearch.Text)
        End If
    End Sub

    'Print Button
    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        PrintForm1.Print()
    End Sub

    Private Sub PrintToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles PrinTPreviewToolStripMenuItem.Click
        PrintDialog1.ShowDialog()
    End Sub

    'Lock Button
    Private Sub picLock_Click(sender As Object, e As EventArgs) Handles picLock.Click
        Dim strPassword = "1234"
        Dim strInputBox As String
        Dim blnPasswrod As Boolean

        Me.Opacity = 0.1

        strInputBox = InputBox("Please enter your password!")
        Do While blnPasswrod = False
            If strInputBox = "1234" Then
                Me.Opacity = 1
                blnPasswrod = True
            Else
                MessageBox.Show("Incorrect Password!")
                blnPasswrod = False
                strInputBox = InputBox("Please enter your password!")
            End If
        Loop

    End Sub

    'Favorites Button
    Private Sub picFavorites_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles picFavorites.Click
        Dim frmFavorites As New frmFavorites
        frmFavorites.Show()

        frmFavorites.Location = Me.PointToScreen(New Point(frmFavorites.btnAddFavorite.Location.X + frmFavorites.btnAddFavorite.Width, frmFavorites.btnDeleteSelected.Location.Y))
    End Sub
End Class
