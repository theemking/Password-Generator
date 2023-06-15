Public Class Form1
    Dim RandNumber As Integer
    Dim RandNumber1 As Integer
    Dim PassWord1() As Integer = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9}

    Dim RandWord As String ' = "The Array"

    Dim RandPassword As New Random
    Dim RandPassNumb As New Random

    Function RandPass1(pass() As Integer)

        For i = 0 To 4
            ' pass(i)
        Next

        Return pass
    End Function

    Private Sub GenPassBnt_Click(sender As Object, e As EventArgs) Handles GenPassBnt.Click
        ' RandNumber = RandPassNumb.Next(100, 999)
        ' RandNumber1 = RandPassNumb.NextDouble()

        ListBox1.Items.Add("The Array")
        ListBox1.Items.Add(RandPass1(PassWord1))

        'RandWord = RandPassword.Next()

        'ListBox1.Items.Add(RandNumber)
        'ListBox1.Items.Add(RandNumber1)

        'ListBox1.Items.Add(RandWord)
    End Sub


    Private Sub ExitBNT_Click(sender As Object, e As EventArgs) Handles ExitBNT.Click
        Me.Close()

    End Sub

    Private Sub Resetbnt_Click(sender As Object, e As EventArgs) Handles Resetbnt.Click
        ListBox1.Items.Clear()
    End Sub
End Class
