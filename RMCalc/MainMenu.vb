Public Class MainMenu
    Private Shared prjno As Integer
    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        Dim frmAbout As New About
        frmAbout.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CreateProjectToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'prjno += 1
        'Dim prj As New ProjectForm With {.Text = "RM Calc Beta 0.1 - Untitled " + CStr(prjno)}
        'prj.MdiParent = Me
        'prj.Show()
    End Sub
End Class
