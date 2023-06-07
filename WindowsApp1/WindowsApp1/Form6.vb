Public Class FrmConsultaDisponivel
    Private Sub CARROSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CARROSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CARROSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub FrmConsultaDisponivel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DataSet1.CARROS'. Você pode movê-la ou removê-la conforme necessário.
        Me.CARROSTableAdapter.Fill(Me.DataSet1.CARROS)

    End Sub
End Class