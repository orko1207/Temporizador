Public Class Form1

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pantalla As System.Windows.Forms.Screen = System.Windows.Forms.Screen.PrimaryScreen
        ' MsgBox(pantalla.Bounds.Width.ToString() + "x" + pantalla.Bounds.Height.ToString())
        Me.Top = pantalla.Bounds.Height.ToString() - Me.Height
        Me.Left = pantalla.Bounds.Width.ToString() - Me.Width
        Dim date2 As Date = Date.Parse(My.Settings.FechaDestino)
        Dim date1 As Date = Now.Date
        Dim days As Long = DateDiff(DateInterval.Day, date1, date2)
        Label3.Text = days
    End Sub


   
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        ContextMenuStrip1.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CambiarFechaDestinoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarFechaDestinoToolStripMenuItem.Click
        Cal.Show()
    End Sub
End Class
