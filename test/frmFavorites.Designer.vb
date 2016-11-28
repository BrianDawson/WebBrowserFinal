<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFavorites
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
        Me.lstFavorites = New System.Windows.Forms.ListBox()
        Me.btnAddFavorite = New System.Windows.Forms.Button()
        Me.btnDeleteSelected = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstFavorites
        '
        Me.lstFavorites.FormattingEnabled = True
        Me.lstFavorites.Location = New System.Drawing.Point(13, 13)
        Me.lstFavorites.Name = "lstFavorites"
        Me.lstFavorites.Size = New System.Drawing.Size(273, 485)
        Me.lstFavorites.TabIndex = 0
        Me.lstFavorites.UseWaitCursor = True
        '
        'btnAddFavorite
        '
        Me.btnAddFavorite.AutoSize = True
        Me.btnAddFavorite.Location = New System.Drawing.Point(13, 504)
        Me.btnAddFavorite.Name = "btnAddFavorite"
        Me.btnAddFavorite.Size = New System.Drawing.Size(94, 23)
        Me.btnAddFavorite.TabIndex = 1
        Me.btnAddFavorite.Text = "Add Favorite"
        Me.btnAddFavorite.UseVisualStyleBackColor = True
        Me.btnAddFavorite.UseWaitCursor = True
        '
        'btnDeleteSelected
        '
        Me.btnDeleteSelected.Location = New System.Drawing.Point(113, 504)
        Me.btnDeleteSelected.Name = "btnDeleteSelected"
        Me.btnDeleteSelected.Size = New System.Drawing.Size(92, 23)
        Me.btnDeleteSelected.TabIndex = 2
        Me.btnDeleteSelected.Text = "DeleteSelected"
        Me.btnDeleteSelected.UseVisualStyleBackColor = True
        Me.btnDeleteSelected.UseWaitCursor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(211, 504)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        Me.btnClose.UseWaitCursor = True
        '
        'frmFavorites
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 535)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDeleteSelected)
        Me.Controls.Add(Me.btnAddFavorite)
        Me.Controls.Add(Me.lstFavorites)
        Me.Name = "frmFavorites"
        Me.Text = "Favorites"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstFavorites As System.Windows.Forms.ListBox
    Friend WithEvents btnAddFavorite As System.Windows.Forms.Button
    Friend WithEvents btnDeleteSelected As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
