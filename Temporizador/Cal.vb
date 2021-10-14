Public Class Cal

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        My.Settings.FechaDestino = DateTimePicker1.Text
        My.Settings.Save()
        Dim pantalla As System.Windows.Forms.Screen = System.Windows.Forms.Screen.PrimaryScreen
        ' MsgBox(pantalla.Bounds.Width.ToString() + "x" + pantalla.Bounds.Height.ToString())
        Form1.Top = pantalla.Bounds.Height.ToString() - Form1.Height
        Form1.Left = pantalla.Bounds.Width.ToString() - Form1.Width
        Dim date2 As Date = Date.Parse(My.Settings.FechaDestino)
        Dim date1 As Date = Now.Date
        Dim days As Long = DateDiff(DateInterval.Day, date1, date2)
        Form1.Label3.Text = days

        Me.Hide()
    End Sub
End Class