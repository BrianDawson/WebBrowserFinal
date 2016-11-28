Public Class frmFavorites
    Dim fromBrowser As frmBrowser

    Private Sub Bookmarks_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        For Each item In My.Settings.Bookmarks
            lstFavorites.Items.Add(item)
        Next
        Me.Visible = False
    End Sub

    'Add Favorite
    Private Sub ButtonAddFavorite_Click(sender As System.Object, e As System.EventArgs) Handles btnAddFavorite.Click
        My.Settings.Bookmarks.Add(frmBrowser.cboURL.Text)
        lstFavorites.Items.Add(frmBrowser.cboURL.Text)
    End Sub

    'Remove Button
    Private Sub btnDeleteSelected_Click(sender As System.Object, e As System.EventArgs) Handles btnDeleteSelected.Click
        My.Settings.Bookmarks.Remove(lstFavorites.SelectedItem)
        lstFavorites.Items.Remove(lstFavorites.SelectedItem)
    End Sub

    'Select Item From List
    Private Sub lstFavorites_Click(sender As Object, e As EventArgs) Handles lstFavorites.DoubleClick
        CType(frmBrowser.WebBrowser.SelectedTab.Controls.Item(0), WebBrowser).Navigate(lstFavorites.SelectedItem)
        Me.Close()
    End Sub
End Class