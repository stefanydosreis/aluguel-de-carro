Public Class FrmFuncionario
    Private Sub FUNCIONARIOSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FUNCIONARIOSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FUNCIONARIOSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub FrmFuncionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DataSet1.FUNCIONARIOS'. Você pode movê-la ou removê-la conforme necessário.
        Me.FUNCIONARIOSTableAdapter.Fill(Me.DataSet1.FUNCIONARIOS)

    End Sub

    Private Sub FOTOPictureBox_Click(sender As Object, e As EventArgs) Handles FOTOPictureBox.Click
        Dim OFD As New OpenFileDialog
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            FOTOPictureBox.ImageLocation = OFD.FileName

        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        CPFMaskedTextBox.Focus()
    End Sub
End Class