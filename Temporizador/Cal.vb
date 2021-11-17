Public Class Cal

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        My.Settings.FechaDestino = DateTimePicker2.Text
        My.Settings.FechaOrigen = DateTimePicker1.Text
        Dim pantalla As System.Windows.Forms.Screen = System.Windows.Forms.Screen.PrimaryScreen
        ' MsgBox(pantalla.Bounds.Width.ToString() + "x" + pantalla.Bounds.Height.ToString())
        Me.Top = (pantalla.Bounds.Height.ToString() - Me.Height) - 50
        Me.Left = (pantalla.Bounds.Width.ToString() - Me.Width) - 50
        Dim date2 As Date = Date.Parse(My.Settings.FechaDestino)
        Dim date1 As Date = Now.Date
        Dim date3 As Date = Date.Parse(My.Settings.FechaOrigen)
        Dim days As Long = DateDiff(DateInterval.Day, date1, date2)
        Dim daysTot As Long = DateDiff(DateInterval.Day, date3, date2)
        Form3.Label1.Text = days
        My.Settings.Save()
        Me.Hide()
    End Sub

    Private Sub Cal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class