﻿Imports MySql.Data.MySqlClient

Public Class addMotorcycle
    Private datUMTC As DataTable
    Dim selectedModel, selectedColor As String

    Public Sub DisplayModel()
        Try
            sqlUMTCAdapter = New MySqlDataAdapter()
            datUMTC = New DataTable()
            Cmb_Model.Items.Clear()

            With command
                .Parameters.Clear()
                .CommandText = "prc_DisplayModel"
                .CommandType = CommandType.StoredProcedure

                sqlUMTCAdapter.SelectCommand = command
                datUMTC.Clear()
                sqlUMTCAdapter.Fill(datUMTC)
            End With

            ' Check if DataTable has rows
            If datUMTC.Rows.Count > 0 Then
                Dim uniqueModels As New HashSet(Of String)()

                For Each row As DataRow In datUMTC.Rows
                    Dim model As String = row("Model").ToString()
                    If Not uniqueModels.Contains(model) Then
                        uniqueModels.Add(model)
                    End If
                Next

                ' Sort the models alphabetically
                Dim sortedModels = uniqueModels.OrderBy(Function(model) model).ToList()

                ' Add sorted models to ComboBox
                For Each model As String In sortedModels
                    Cmb_Model.Items.Add(model)
                Next
            End If

            ' Dispose resources
            sqlUMTCAdapter.Dispose()
            datUMTC.Dispose()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub DisplayColor()
        ' Ensure there's a selected model in the ComboBox
        If Not String.IsNullOrEmpty(Cmb_Model.Text) Then
            ' Clear existing items in ComboBox
            Cmb_Color.Items.Clear()

            sqlUMTCAdapter = New MySqlDataAdapter()
            datUMTC = New DataTable()

            With command
                .Parameters.Clear()
                .CommandText = "prc_DisplayAllColors"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_model", Cmb_Model.Text)
                sqlUMTCAdapter.SelectCommand = command
                datUMTC.Clear()
                sqlUMTCAdapter.Fill(datUMTC)
            End With

            If datUMTC.Rows.Count > 0 Then
                ' Iterate through each row in the DataTable
                For Each row As DataRow In datUMTC.Rows
                    ' Check if the "Model" column value matches the selected model
                    If row("Model").ToString() = Cmb_Model.Text Then
                        ' Assuming that the color information is in a column named "Color"
                        ' and price information is in a column named "Price"
                        Cmb_Color.Items.Add(row("Color").ToString())

                        txtPrice.Text = row("Price").ToString()
                        txtPrice.ReadOnly = True
                    End If
                Next
            End If

            ' Dispose resources
            sqlUMTCAdapter.Dispose()
            datUMTC.Dispose()

        End If
    End Sub

    Private Sub addMotorcycle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Login_stat <> True Then
            Login.Show()
            Me.Close()
        Else
            CheckDatabaseConnection()
            DisplayModel()
            DisplayColor()
        End If
    End Sub

    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click
        If Cmb_Model.Text <> "" And Cmb_Color.Text <> "" And txtPrice.Text <> "" And txtEngineNumber.Text <> "" And txtFrameNumber.Text <> "" And txtInvoiceNumber.Text <> "" Then
            Try
                If action = "Insert" And fncCheckEngineNo(txtEngineNumber.Text) = False Then

                    With command
                        .Parameters.Clear()
                        .CommandText = "prc_AddMotorcycle"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("@p_invoice", txtInvoiceNumber.Text)
                        .Parameters.AddWithValue("@p_dd", Format(dt.Value, "yyyy-MM-dd"))
                        .Parameters.AddWithValue("@p_model", Cmb_Model.Text)
                        .Parameters.AddWithValue("@p_color", Cmb_Color.Text)
                        .Parameters.AddWithValue("@p_price", txtPrice.Text)
                        .Parameters.AddWithValue("@p_engine", txtEngineNumber.Text)
                        .Parameters.AddWithValue("@p_frame", txtFrameNumber.Text)
                        .ExecuteNonQuery()
                    End With

                    With command
                        .Parameters.Clear()
                        .CommandText = "prc_Record"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("@p_Action", "Add Unit")
                        .Parameters.AddWithValue("@p_d", Format(dt.Value, "yyyy-MM-dd"))
                        .Parameters.AddWithValue("@p_Unit", txtEngineNumber.Text)
                        .Parameters.AddWithValue("@p_branch", "Main")
                        .Parameters.AddWithValue("@p_FromState", "none")
                        .Parameters.AddWithValue("@p_ToState", "Available")
                        .Parameters.AddWithValue("@p_Customer", "none")
                        .Parameters.AddWithValue("@p_Employee", Username)
                        .ExecuteNonQuery()
                    End With
                    MessageBox.Show("Record Successfully Saved", "Saving Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf action = "Edit" Then

                    With command
                        .Parameters.Clear()
                        .CommandText = "prc_UpdateMotorcycleByEngineNumber"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("@p_invoice", txtInvoiceNumber.Text)
                        .Parameters.AddWithValue("@p_dd", Format(dt.Value, "yyyy-MM-dd"))
                        .Parameters.AddWithValue("@p_model", Cmb_Model.Text)
                        .Parameters.AddWithValue("@p_color", Cmb_Color.Text)
                        .Parameters.AddWithValue("@p_price", txtPrice.Text)
                        .Parameters.AddWithValue("@p_engine", txtEngineNumber.Text)
                        .Parameters.AddWithValue("@p_frame", txtFrameNumber.Text)
                        .ExecuteNonQuery()

                        Dim result As DialogResult = MessageBox.Show("Are you sure you want to edit Motorcycle?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                        If result = DialogResult.Yes Then
                            MainBranchInventory.Show()
                            Me.Close()
                        Else
                            Me.ShowDialog()
                        End If
                    End With
                    With command
                        .Parameters.Clear()
                        .CommandText = "prc_Record"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("@p_Action", "Edit Unit")
                        .Parameters.AddWithValue("@p_d", Format(dt.Value, "yyyy-MM-dd"))
                        .Parameters.AddWithValue("@p_Unit", txtEngineNumber.Text)
                        .Parameters.AddWithValue("@p_branch", "Main")
                        .Parameters.AddWithValue("@p_FromState", "none")
                        .Parameters.AddWithValue("@p_ToState", "Available")
                        .Parameters.AddWithValue("@p_Customer", "none")
                        .Parameters.AddWithValue("@p_Employee", Username)
                        .ExecuteNonQuery()
                    End With
                    MessageBox.Show("Record Successfully Saved", "Saving Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Engine/Frame number already existed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show("" & ex.Message)
            End Try
        Else
            MessageBox.Show("Credentials missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button_Clear_Click(sender As Object, e As EventArgs) Handles Btn_Clear.Click
        txtEngineNumber.Clear()
        txtFrameNumber.Clear()
        txtInvoiceNumber.Clear()
        txtPrice.Clear()
    End Sub

    Private Sub Btn_close_Click(sender As Object, e As EventArgs) Handles Btn_close.Click
        Me.Dispose()
    End Sub

    Private Sub Btn_AddCateg_Click(sender As Object, e As EventArgs) Handles Btn_AddCateg.Click
        addnewunits.ShowDialog()
        txtEngineNumber.Clear()
        txtFrameNumber.Clear()
        txtInvoiceNumber.Clear()
        txtPrice.Clear()
        Cmb_Color.SelectedIndex = -1
        Cmb_Model.SelectedIndex = -1
        DisplayModel()
        DisplayColor()
    End Sub

    'function methods
    Function fncCheckEngineNo(p_search As String) As Boolean
        Dim result As String

        sqlUMTCAdapter = New MySqlDataAdapter
        DataUMTC = New DataTable

        With command
            .Parameters.Clear()
            .CommandText = "prc_FindStockDuplicate"
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@p_search", p_search)
            sqlUMTCAdapter.SelectCommand = command
            DataUMTC.Clear()
            sqlUMTCAdapter.Fill(DataUMTC)

            If DataUMTC.Rows.Count > 0 Then
                result = True
            Else
                result = False
            End If
        End With
        sqlUMTCAdapter.Dispose()
        DataUMTC.Dispose()
        Try
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
        Return result
    End Function
    'end function

    Private Sub Cmb_Model_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_Model.SelectedIndexChanged
        Cmb_Color.SelectedIndex = -1
        txtPrice.Clear()

        If Cmb_Model.SelectedItem IsNot Nothing Then
            selectedModel = Cmb_Model.SelectedItem.ToString()
            DisplayColor()
        End If
    End Sub

    Private Sub Cmb_Color_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_Color.SelectedIndexChanged
        If Cmb_Color.SelectedItem IsNot Nothing Then
            selectedColor = Cmb_Color.SelectedItem.ToString()
        End If
    End Sub
End Class
