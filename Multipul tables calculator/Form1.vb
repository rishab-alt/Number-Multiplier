Public Class Form1
    Dim num1 As Integer
    Dim num3 As Integer
    Dim ans As Object

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        num1 = 1
        For num2 = 0 To 12
            num3 = num1 * num2
            ans = ans + CStr(num1) & "x" & CStr(num2) & "=" & CStr(num3)
            ans = ans & vbCrLf
            TextBox1.Text = ans
        Next Num2

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        num1 = 2
        For num2 = 0 To 12
            num3 = num1 * num2
            ans = ans + CStr(num1) & "x" & CStr(num2) & "=" & CStr(num3)
            ans = ans & vbCrLf
            TextBox1.Text = ans
        Next num2
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        num1 = 3
        For num2 = 0 To 12
            num3 = num1 * num2
            ans = ans + CStr(num1) & "x" & CStr(num2) & "=" & CStr(num3)
            ans = ans & vbCrLf
            TextBox1.Text = ans
        Next num2
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        num1 = 4
        For num2 = 0 To 12
            num3 = num1 * num2
            ans = ans + CStr(num1) & "x" & CStr(num2) & "=" & CStr(num3)
            ans = ans & vbCrLf
            TextBox1.Text = ans
        Next num2
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        num1 = 5
        For num2 = 0 To 12
            num3 = num1 * num2
            ans = ans + CStr(num1) & "x" & CStr(num2) & "=" & CStr(num3)
            ans = ans & vbCrLf
            TextBox1.Text = ans
        Next num2
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        num1 = 6
        For num2 = 0 To 12
            num3 = num1 * num2
            ans = ans + CStr(num1) & "x" & CStr(num2) & "=" & CStr(num3)
            ans = ans & vbCrLf
            TextBox1.Text = ans
        Next num2
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        num1 = 7
        For num2 = 0 To 12
            num3 = num1 * num2
            ans = ans + CStr(num1) & "x" & CStr(num2) & "=" & CStr(num3)
            ans = ans & vbCrLf
            TextBox1.Text = ans
        Next num2
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        num1 = 8
        For num2 = 0 To 12
            num3 = num1 * num2
            ans = ans + CStr(num1) & "x" & CStr(num2) & "=" & CStr(num3)
            ans = ans & vbCrLf
            TextBox1.Text = ans
        Next num2
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        num1 = 9
        For num2 = 0 To 12
            num3 = num1 * num2
            ans = ans + CStr(num1) & "x" & CStr(num2) & "=" & CStr(num3)
            ans = ans & vbCrLf
            TextBox1.Text = ans
        Next num2
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        num1 = 10
        For num2 = 0 To 12
            num3 = num1 * num2
            ans = ans + CStr(num1) & "x" & CStr(num2) & "=" & CStr(num3)
            ans = ans & vbCrLf
            TextBox1.Text = ans
        Next num2
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        num1 = 11
        For num2 = 0 To 12
            num3 = num1 * num2
            ans = ans + CStr(num1) & "x" & CStr(num2) & "=" & CStr(num3)
            ans = ans & vbCrLf
            TextBox1.Text = ans
        Next num2
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        num1 = 12
        For num2 = 0 To 12
            num3 = num1 * num2
            ans = ans + CStr(num1) & "x" & CStr(num2) & "=" & CStr(num3)
            ans = ans & vbCrLf
            TextBox1.Text = ans
        Next num2
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox1.Text = ""
        ans = ""
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Close()
    End Sub
End Class
