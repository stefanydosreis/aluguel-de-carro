Public Class FrmCliente
    Private Sub CLIENTESBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CLIENTESBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CLIENTESBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub FrmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DataSet1.CLIENTES'. Você pode movê-la ou removê-la conforme necessário.
        Me.CLIENTESTableAdapter.Fill(Me.DataSet1.CLIENTES)

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        CPFMaskedTextBox.Focus()
    End Sub

    Private Sub FOTOPictureBox_Click(sender As Object, e As EventArgs) Handles FOTOPictureBox.Click
        Dim OFD As New OpenFileDialog
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            FOTOPictureBox.ImageLocation = OFD.FileName
        End If
    End Sub
End Class