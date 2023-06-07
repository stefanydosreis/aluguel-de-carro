Public Class FrmCarro
    Private Sub CARROSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CARROSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub CARROSBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles CARROSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CARROSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DataSet1.CARROS'. Você pode movê-la ou removê-la conforme necessário.
        Me.CARROSTableAdapter.Fill(Me.DataSet1.CARROS)

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        PLACAMaskedTextBox.Focus()
    End Sub

    Private Sub FOTOPictureBox_Click(sender As Object, e As EventArgs) Handles FOTOPictureBox.Click
        Dim OFD As New OpenFileDialog
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then

            FOTOPictureBox.ImageLocation = OFD.FileName
        End If
    End Sub

    Private Sub DISPONIBILIDADETextBox_TextChanged(sender As Object, e As EventArgs) Handles DISPONIBILIDADETextBox.TextChanged

    End Sub

    Private Sub PLACAMaskedTextBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles PLACAMaskedTextBox.MaskInputRejected

    End Sub

    Private Sub PLACAMaskedTextBox_TextChanged(sender As Object, e As EventArgs) Handles PLACAMaskedTextBox.TextChanged
        DISPONIBILIDADETextBox.Text = "Disponível"
    End Sub

    Private Sub FABRICANTELabel_Click(sender As Object, e As EventArgs)

    End Sub
End Class