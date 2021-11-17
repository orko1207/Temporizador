Imports System.Threading

Public Class Form1
    Dim daysTot As Long
    Dim days As Long
    Dim fact As Double
    Dim factot As Integer
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pantalla As System.Windows.Forms.Screen = System.Windows.Forms.Screen.PrimaryScreen
        ' MsgBox(pantalla.Bounds.Width.ToString() + "x" + pantalla.Bounds.Height.ToString())
        Me.Top = (pantalla.Bounds.Height.ToString() - Me.Height) - 50
        Me.Left = (pantalla.Bounds.Width.ToString() - Me.Width) - 50
        Dim date2 As Date = Date.Parse(My.Settings.FechaDestino)
        Dim date1 As Date = Now.Date
        Dim date3 As Date = Date.Parse(My.Settings.FechaOrigen)
        days = DateDiff(DateInterval.Day, date1, date2)
        daysTot = DateDiff(DateInterval.Day, date3, date2)

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

    Private Sub Label2_MouseEnter(sender As Object, e As EventArgs) Handles Label2.MouseEnter
        Form2.Show()
        Form3.Show()

        Dim pincel As New Pen(Color.Green, 10)
        Dim arco As Graphics
        arco = GraphicTemp.Panel1.CreateGraphics()
        fact = 360 / daysTot
        factot = (days * fact)
        arco.DrawArc(pincel, New Rectangle(5, 5, 200, 200), -90, factot)
        GraphicTemp.Show()
    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave

        Timer1.Start()
    End Sub

    Private Sub Label3_MouseEnter(sender As Object, e As EventArgs) Handles Label3.MouseEnter


        Form2.Show()
        Form3.Show()

        Dim pincel As New Pen(Color.Green, 10)
        Dim arco As Graphics
        arco = GraphicTemp.Panel1.CreateGraphics()
        fact = 360 / daysTot
        factot = (days * fact)
        arco.DrawArc(pincel, New Rectangle(5, 5, 200, 200), -90, factot)
        GraphicTemp.Show()
    End Sub

    Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles Label3.MouseLeave
        Timer1.Start()
      
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Form2.Hide()
        Form3.Hide()
        'GraphicTemp.Hide()
    End Sub
End Class
