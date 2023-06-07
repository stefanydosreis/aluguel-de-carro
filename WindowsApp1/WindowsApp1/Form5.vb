Public Class FrmAluguel
    Private Sub ALUGUELBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ALUGUELBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ALUGUELBindingSource.EndEdit()
        Me.CARROSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub FrmAluguel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DataSet1.CARROS'. Você pode movê-la ou removê-la conforme necessário.
        Me.CARROSTableAdapter.Fill(Me.DataSet1.CARROS)
        'TODO: esta linha de código carrega dados na tabela 'DataSet1.CLIENTES'. Você pode movê-la ou removê-la conforme necessário.
        Me.CLIENTESTableAdapter.Fill(Me.DataSet1.CLIENTES)
        'TODO: esta linha de código carrega dados na tabela 'DataSet1.FUNCIONARIOS'. Você pode movê-la ou removê-la conforme necessário.
        Me.FUNCIONARIOSTableAdapter.Fill(Me.DataSet1.FUNCIONARIOS)
        'TODO: esta linha de código carrega dados na tabela 'DataSet1.ALUGUEL'. Você pode movê-la ou removê-la conforme necessário.
        Me.ALUGUELTableAdapter.Fill(Me.DataSet1.ALUGUEL)

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        DTALUGUELMaskedTextBox.Focus()
    End Sub

    Private Sub CPF_FUNCLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PLACA_CARComboBox_Leave(sender As Object, e As EventArgs) Handles PLACA_CARComboBox.Leave
        If DISPONIBILIDADETextBox.Text = "Alugado" Then
            MsgBox("Esse carro não está disponível. Selecione outro carro.",
            MsgBoxStyle.Critical)
            PLACA_CARComboBox.Focus()
        End If
    End Sub

    Private Sub PLACA_CARLabel_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub ENTREGAComboBox_Leave(sender As Object, e As EventArgs) Handles ENTREGAComboBox.Leave
        If ENTREGAComboBox.Text = "Sim" Then
            DISPONIBILIDADETextBox.Text = "Disponível"
        Else
            DISPONIBILIDADETextBox.Text = "Alugado"
        End If

    End Sub
End Class