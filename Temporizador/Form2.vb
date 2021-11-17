Public Class Form2

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pantalla As System.Windows.Forms.Screen = System.Windows.Forms.Screen.PrimaryScreen
        ' MsgBox(pantalla.Bounds.Width.ToString() + "x" + pantalla.Bounds.Height.ToString())
        Me.Top = (Form1.Top - Me.Height) - 50
        Me.Left = pantalla.Bounds.Width.ToString() - Me.Width




        Dim date2 As Date = Date.Parse(My.Settings.FechaDestino)
        Dim date1 As Date = Now.Date

        Dim semanas As Integer = 0
        Dim dias As Integer = 0

        dias = DateDiff(DateInterval.Day, date1, date2)
        semanas = DateDiff(DateInterval.Weekday, date2, date1)
        Dim residuo As Decimal = dias Mod 7


        Label3.Text = semanas * -1
        Label1.Text = residuo


    End Sub


   
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub



    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CambiarFechaDestinoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Cal.Show()
    End Sub

    Private Sub Form2_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave

    End Sub
End Class
