Public Class frmLogin
    Dim bsnNegocio As New BsnNegocio()
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim user As New Usuario
        user.User = txtUser.Text
        user.Password = txtPassword.Text
        dgvExample.DataSource = bsnNegocio.Login(user)


        dgvExample.Rows(0).Selected = True

        Dim confUser As String
        Dim confPassword As String

        Try
            confUser = dgvExample.SelectedRows.Item(0).Cells(1).Value.ToString()
            confPassword = dgvExample.SelectedRows.Item(0).Cells(2).Value.ToString()

            If (txtUser.Text = confUser And txtPassword.Text = confPassword) Then
                Me.Hide()
                Principal.Show()
            Else
                txtUser.Text = ""
                txtPassword.Text = ""
            End If

            Exit Try
        Catch
            MsgBox("Usuario no es valido.", MsgBoxStyle.Information, "Alerta")
            Exit Try
        End Try
    End Sub

End Class
