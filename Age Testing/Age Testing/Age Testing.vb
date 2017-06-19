Public Class Form1

    Private Sub Bn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bn1.Click
        Dim age As integer
        Dim msg As string
        try
            age = cint(Tb1.Text)
            msg = Tb2.Text

            If age <= 13 and age > 0 Then
                Tb2.Text = "you are a child"
            ElseIf age <= 21 and age > 13 Then
                Tb2.Text = "you are a teenager"
            ElseIf age <= 65 and age > 21 Then
                Tb2.Text = "you are an adult"
            ElseIf age > 65 and age <=200 Then
                Tb2.Text = "you are old"
            Else
                Tb2.Text = "you can't exist!"
            End If
        catch ex as exeption
            msgbox("Error: " & ex.message,vbcritical,"Error message")
        End Try
    End Sub
End Class
