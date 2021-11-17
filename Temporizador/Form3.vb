Public Class Form3

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pantalla As System.Windows.Forms.Screen = System.Windows.Forms.Screen.PrimaryScreen
        ' MsgBox(pantalla.Bounds.Width.ToString() + "x" + pantalla.Bounds.Height.ToString())
        Me.Top = pantalla.Bounds.Height.ToString() - Me.Height
        Me.Left = Form1.Left - (Me.Width)

        Dim date2 As Date = Date.Parse(My.Settings.FechaDestino)
        Dim date1 As Date = Now.Date



             Dim meses As Integer = 0

        ' Dim fechaIni As Date = "18/04/2019" 'fecha inicial

        Dim dias As Integer = 0
        dias = DateDiff(DateInterval.Day, date2, date1)

        meses = DateDiff(DateInterval.Month, date2, date1)
        Dim residuo As Decimal = dias Mod 30
        '  If (dias Mod 30 = 0) Then
        Label4.Text = meses * -1
        Label3.Text = residuo * -1

        ' Else
        ' meses += 1
        ' Label4.Text = meses * -1
        '  Label3.Text = residuo * -1

        '   End If






    End Sub



    Private Sub Label2_Click(sender As Object, e As EventArgs)

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

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
