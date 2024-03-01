﻿Imports MySql.Data.MySqlClient

Public Class MainBranchInventory
    Private datUMTC As DataTable
    Dim invoice As String

    'dataloader
    Private Sub MainBranchInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckDatabaseConnection()
        PrcDisplayUnits()
    End Sub

    Private Sub PrcDisplayUnits()
        Try
            sqlUMTCAdapter = New MySqlDataAdapter
            datUMTC = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prc_DisplayStock"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_filter", "")
                .Parameters.AddWithValue("@p_search", "")
                .Parameters.AddWithValue("@p_GBranch", "Main")
                sqlUMTCAdapter.SelectCommand = command
                datUMTC.Clear()
                sqlUMTCAdapter.Fill(datUMTC)
                lblTotal.Text = "TOTAL RECORDS: " & datUMTC.Rows.Count
                If datUMTC.Rows.Count > 0 Then
                    Grd_Motorcycle.RowCount = datUMTC.Rows.Count
                    row = 0
                    While Not datUMTC.Rows.Count - 1 < row
                        Grd_Motorcycle.Rows(row).Cells(0).Value = datUMTC.Rows(row).Item("Invoice").ToString
                        Grd_Motorcycle.Rows(row).Cells(1).Value = Format(Convert.ToDateTime(datUMTC.Rows(row).Item("Datearrive").ToString), "MMM dd, yyyy")
                        Grd_Motorcycle.Rows(row).Cells(2).Value = datUMTC.Rows(row).Item("Model").ToString
                        Grd_Motorcycle.Rows(row).Cells(3).Value = datUMTC.Rows(row).Item("Color").ToString
                        Grd_Motorcycle.Rows(row).Cells(4).Value = datUMTC.Rows(row).Item("Price").ToString
                        Grd_Motorcycle.Rows(row).Cells(5).Value = datUMTC.Rows(row).Item("EngineNum").ToString
                        Grd_Motorcycle.Rows(row).Cells(6).Value = datUMTC.Rows(row).Item("Framenum").ToString
                        Grd_Motorcycle.Rows(row).Cells(7).Value = datUMTC.Rows(row).Item("Stat").ToString
                        Grd_Motorcycle.Rows(row).Cells(8).Value = datUMTC.Rows(row).Item("Brnch").ToString

                        row = row + 1

                    End While
                    sqlUMTCAdapter.Dispose()
                    datUMTC.Dispose()
                Else
                    MessageBox.Show("No Available Records", "Records", MessageBoxButtons.OK, MessageBoxIcon.Question)
                End If
            End With

            sqlUMTCAdapter.Dispose()
            datUMTC.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    'dataloader end

    'filter
    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles Txt_Search.TextChanged
        If Chk_Auto.Checked = True Then
            PrcDisplayMotorcycleWithAutoCompleteInMainInventory()
        Else

        End If
    End Sub

    Private Sub PrcDisplayMotorcycleWithAutoCompleteInMainInventory()
        sqlUMTCAdapter = New MySqlDataAdapter
        datUMTC = New DataTable
        Try

            With command
                .Parameters.Clear()
                .CommandText = "prc_DisplayStock"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_filter", cmbSearchType.Text)
                .Parameters.AddWithValue("@p_search", Txt_Search.Text)
                .Parameters.AddWithValue("@p_GBranch", "Main")
                sqlUMTCAdapter.SelectCommand = command
                datUMTC.Clear()
                sqlUMTCAdapter.Fill(datUMTC)
                lblTotal.Text = "TOTAL RECORDS: " & datUMTC.Rows.Count
                If datUMTC.Rows.Count > 0 Then
                    Grd_Motorcycle.RowCount = datUMTC.Rows.Count
                    row = 0
                    While Not datUMTC.Rows.Count - 1 < row

                        Grd_Motorcycle.Rows(row).Cells(0).Value = datUMTC.Rows(row).Item("Invoice").ToString
                        Grd_Motorcycle.Rows(row).Cells(1).Value = Format(Convert.ToDateTime(datUMTC.Rows(row).Item("Datearrive").ToString), "MMM dd, yyyy")
                        Grd_Motorcycle.Rows(row).Cells(2).Value = datUMTC.Rows(row).Item("Model").ToString
                        Grd_Motorcycle.Rows(row).Cells(3).Value = datUMTC.Rows(row).Item("Color").ToString
                        Grd_Motorcycle.Rows(row).Cells(4).Value = datUMTC.Rows(row).Item("Price").ToString
                        Grd_Motorcycle.Rows(row).Cells(5).Value = datUMTC.Rows(row).Item("EngineNum").ToString
                        Grd_Motorcycle.Rows(row).Cells(6).Value = datUMTC.Rows(row).Item("FrameNum").ToString
                        Grd_Motorcycle.Rows(row).Cells(7).Value = datUMTC.Rows(row).Item("Stat").ToString
                        Grd_Motorcycle.Rows(row).Cells(8).Value = datUMTC.Rows(row).Item("Brnch").ToString

                        row = row + 1
                    End While

                End If
            End With
            sqlUMTCAdapter.Dispose()
            datUMTC.Dispose()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub
    'filter end

    'button
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            With command
                .Parameters.Clear()
                .CommandText = "prc_AddMotorcycle"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_invoice", Txt_InvoiceNo.Text)
                .Parameters.AddWithValue("@p_dd", Format(dt.Value, "yyyy-MM-dd"))
                .Parameters.AddWithValue("@p_model", Cmb_Model.Text)
                .Parameters.AddWithValue("@p_color", Cmb_Color.Text)
                .Parameters.AddWithValue("@p_price", Txt_Price.Text)
                .Parameters.AddWithValue("@p_engine", Txt_EngineNo.Text)
                .Parameters.AddWithValue("@p_frame", Txt_FrameNo.Text)
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show("Unit Successfully Added", "Saving Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        PrcDisplayUnits()
    End Sub

    Private Sub Btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click

        Try
            With command
                .Parameters.Clear()
                .CommandText = "prc_DeleteUnitbyEngineNumber"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_invoice", invoice)
                .ExecuteNonQuery()
            End With
            MessageBox.Show("unit Successfully Deleted", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PrcDisplayUnits()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            With command
                .Parameters.Clear()
                .CommandText = "prc_UpdateMotorcycleByEngineNumber"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_invoice", Txt_InvoiceNo.Text)
                .Parameters.AddWithValue("@p_dd", Format(dt.Value, "yyyy-MM-dd"))
                .Parameters.AddWithValue("@p_model", Cmb_Model.Text)
                .Parameters.AddWithValue("@p_color", Cmb_Color.Text)
                .Parameters.AddWithValue("@p_price", Txt_Price.Text)
                .Parameters.AddWithValue("@p_engine", Txt_EngineNo.Text)
                .Parameters.AddWithValue("@p_frame", Txt_FrameNo.Text)
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show("Unit Successfully Edited", "Saving Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        PrcDisplayUnits()

    End Sub
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        sqlUMTCAdapter = New MySqlDataAdapter
        datUMTC = New DataTable
        Try

            With command
                .Parameters.Clear()
                .CommandText = "prc_DisplayStock"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_filter", cmbSearchType.Text)
                .Parameters.AddWithValue("@p_search", Txt_Search.Text)
                .Parameters.AddWithValue("@p_GBranch", "Main")
                sqlUMTCAdapter.SelectCommand = command
                datUMTC.Clear()
                sqlUMTCAdapter.Fill(datUMTC)
                lblTotal.Text = "TOTAL RECORDS: " & datUMTC.Rows.Count
                If datUMTC.Rows.Count > 0 Then
                    Grd_Motorcycle.RowCount = datUMTC.Rows.Count
                    row = 0
                    While Not datUMTC.Rows.Count - 1 < row
                        Grd_Motorcycle.Rows(row).Cells(0).Value = datUMTC.Rows(row).Item("Invoice").ToString
                        Grd_Motorcycle.Rows(row).Cells(1).Value = Format(Convert.ToDateTime(datUMTC.Rows(row).Item("Datearrive").ToString), "MMM dd, yyyy")
                        Grd_Motorcycle.Rows(row).Cells(2).Value = datUMTC.Rows(row).Item("Model").ToString
                        Grd_Motorcycle.Rows(row).Cells(3).Value = datUMTC.Rows(row).Item("Color").ToString
                        Grd_Motorcycle.Rows(row).Cells(4).Value = datUMTC.Rows(row).Item("Price").ToString
                        Grd_Motorcycle.Rows(row).Cells(5).Value = datUMTC.Rows(row).Item("EngineNum").ToString
                        Grd_Motorcycle.Rows(row).Cells(6).Value = datUMTC.Rows(row).Item("FrameNum").ToString
                        Grd_Motorcycle.Rows(row).Cells(7).Value = datUMTC.Rows(row).Item("Stat").ToString
                        Grd_Motorcycle.Rows(row).Cells(8).Value = datUMTC.Rows(row).Item("Brnch").ToString

                        row = row + 1

                    End While
                    Txt_Search.Clear()
                    cmbSearchType.SelectedIndex = -1

                Else
                    MessageBox.Show("No Available Records", "Records", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End With
            sqlUMTCAdapter.Dispose()
            datUMTC.Dispose()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub
    Private Sub Btn_Toreservation_Click(sender As Object, e As EventArgs) Handles Btn_ReservationPage.Click
        ConfirmReserve.ShowDialog()
    End Sub
    'button end

    Private Sub Btn_AvStock_Click(sender As Object, e As EventArgs) Handles Btn_AvStock.Click
        Me.Show()
    End Sub

    Private Sub Btn_Reserved_Click(sender As Object, e As EventArgs) Handles Btn_Reserved.Click
        Reserve.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Transit_Click(sender As Object, e As EventArgs) Handles Btn_Transit.Click
        TRANSIT.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DashBoard.Show()
        Me.Close()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Cmb_Color_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_Color.SelectedIndexChanged

    End Sub

End Class