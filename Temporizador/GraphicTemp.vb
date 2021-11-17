Public Class GraphicTemp

    Private Sub GraphicTemp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = (Form1.Top - Form1.Label3.Top) - 50
        Me.Left = (Form1.Left - Form1.Label3.Left) + 45
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)
        'Label3.Text = Form1.days
    End Sub

    Private Sub Panel1_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
       
    End Sub
End Class