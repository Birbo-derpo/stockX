﻿Imports MySql.Data.MySqlClient

Public Class Customer
    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Login_stat <> True Then
            Login.Show()
            Me.Close()
        Else
            CheckDatabaseConnection()
            PrcDisplayAllCustomers()
        End If

    End Sub

    'dataloader
    Private Sub PrcDisplayAllCustomers()
        Try
            sqlUMTCAdapter = New MySqlDataAdapter
            DataUMTC = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prc_DisplayCustomers"
                .CommandType = CommandType.StoredProcedure
                sqlUMTCAdapter.SelectCommand = command
                DataUMTC.Clear()
                sqlUMTCAdapter.Fill(DataUMTC)
                If DataUMTC.Rows.Count > 0 Then
                    grd_AllCustomer.RowCount = DataUMTC.Rows.Count
                    row = 0
                    While Not DataUMTC.Rows.Count - 1 < row

                        grd_AllCustomer.Rows(row).Cells(0).Value = DataUMTC.Rows(row).Item("L_name").ToString
                        grd_AllCustomer.Rows(row).Cells(1).Value = DataUMTC.Rows(row).Item("F_name").ToString
                        grd_AllCustomer.Rows(row).Cells(2).Value = DataUMTC.Rows(row).Item("Stat").ToString
                        grd_AllCustomer.Rows(row).Cells(3).Value = DataUMTC.Rows(row).Item("Model").ToString
                        grd_AllCustomer.Rows(row).Cells(4).Value = DataUMTC.Rows(row).Item("Color").ToString
                        grd_AllCustomer.Rows(row).Cells(5).Value = DataUMTC.Rows(row).Item("Brnch").ToString
                        grd_AllCustomer.Rows(row).Cells(6).Value = DataUMTC.Rows(row).Item("EngineNum").ToString
                        grd_AllCustomer.Rows(row).Cells(7).Value = DataUMTC.Rows(row).Item("FrameNum").ToString
                        grd_AllCustomer.Rows(row).Cells(8).Value = DataUMTC.Rows(row).Item("TypeOP").ToString
                        grd_AllCustomer.Rows(row).Cells(9).Value = DataUMTC.Rows(row).Item("TermOP").ToString
                        grd_AllCustomer.Rows(row).Cells(10).Value = DataUMTC.Rows(row).Item("Amount_paid").ToString
                        grd_AllCustomer.Rows(row).Cells(11).Value = DataUMTC.Rows(row).Item("Price").ToString
                        grd_AllCustomer.Rows(row).Cells(12).Value = Format(Convert.ToDateTime(DataUMTC.Rows(row).Item("Date_ordered").ToString), "MMM dd, yyyy")
                        grd_AllCustomer.Rows(row).Cells(13).Value = DataUMTC.Rows(row).Item("SIV").ToString
                        grd_AllCustomer.Rows(row).Cells(14).Value = DataUMTC.Rows(row).Item("Payment_Status").ToString
                        grd_AllCustomer.Rows(row).Cells(15).Value = DataUMTC.Rows(row).Item("id").ToString

                        row = row + 1
                    End While
                Else
                    MessageBox.Show("No Available Records", "Records", MessageBoxButtons.OK, MessageBoxIcon.Question)
                End If
            End With

            sqlUMTCAdapter.Dispose()
            DataUMTC.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub AutofillSearch()
        sqlUMTCAdapter = New MySqlDataAdapter
        DataUMTC = New DataTable
        Try

            With command
                .Parameters.Clear()
                .CommandText = "prc_SearchCustomer"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_search", Txt_Search.Text)
                .Parameters.AddWithValue("@p_filter", Cmb_Filter.Text)
                sqlUMTCAdapter.SelectCommand = command
                DataUMTC.Clear()
                sqlUMTCAdapter.Fill(DataUMTC)
                If DataUMTC.Rows.Count > 0 And Cmb_Filter.Text <> "" Then
                    grd_AllCustomer.RowCount = DataUMTC.Rows.Count
                    row = 0
                    While Not DataUMTC.Rows.Count - 1 < row

                        grd_AllCustomer.Rows(row).Cells(0).Value = DataUMTC.Rows(row).Item("L_name").ToString
                        grd_AllCustomer.Rows(row).Cells(1).Value = DataUMTC.Rows(row).Item("F_name").ToString
                        grd_AllCustomer.Rows(row).Cells(2).Value = DataUMTC.Rows(row).Item("Stat").ToString
                        grd_AllCustomer.Rows(row).Cells(3).Value = DataUMTC.Rows(row).Item("Model").ToString
                        grd_AllCustomer.Rows(row).Cells(4).Value = DataUMTC.Rows(row).Item("Color").ToString
                        grd_AllCustomer.Rows(row).Cells(5).Value = DataUMTC.Rows(row).Item("Brnch").ToString
                        grd_AllCustomer.Rows(row).Cells(6).Value = DataUMTC.Rows(row).Item("EngineNum").ToString
                        grd_AllCustomer.Rows(row).Cells(7).Value = DataUMTC.Rows(row).Item("FrameNum").ToString
                        grd_AllCustomer.Rows(row).Cells(8).Value = DataUMTC.Rows(row).Item("TypeOP").ToString
                        grd_AllCustomer.Rows(row).Cells(9).Value = DataUMTC.Rows(row).Item("TermOP").ToString
                        grd_AllCustomer.Rows(row).Cells(10).Value = DataUMTC.Rows(row).Item("Amount_paid").ToString
                        grd_AllCustomer.Rows(row).Cells(11).Value = DataUMTC.Rows(row).Item("Price").ToString
                        grd_AllCustomer.Rows(row).Cells(12).Value = Format(Convert.ToDateTime(DataUMTC.Rows(row).Item("Date_ordered").ToString), "MMM dd, yyyy")
                        grd_AllCustomer.Rows(row).Cells(13).Value = DataUMTC.Rows(row).Item("SIV").ToString
                        grd_AllCustomer.Rows(row).Cells(14).Value = DataUMTC.Rows(row).Item("Payment_Status").ToString
                        grd_AllCustomer.Rows(row).Cells(15).Value = DataUMTC.Rows(row).Item("id").ToString


                        row = row + 1
                    End While

                End If
            End With
            sqlUMTCAdapter.Dispose()
            DataUMTC.Dispose()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub
    'dataloader end

    'buttons
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        sqlUMTCAdapter = New MySqlDataAdapter
        DataUMTC = New DataTable
        Try

            With command
                .Parameters.Clear()
                .CommandText = "prc_SearchCustomer"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_search", Txt_Search.Text)
                .Parameters.AddWithValue("@p_filter", Cmb_Filter.Text)
                sqlUMTCAdapter.SelectCommand = command
                DataUMTC.Clear()
                sqlUMTCAdapter.Fill(DataUMTC)
                If DataUMTC.Rows.Count > 0 And Cmb_Filter.Text <> "" Then
                    grd_AllCustomer.RowCount = DataUMTC.Rows.Count
                    row = 0
                    While Not DataUMTC.Rows.Count - 1 < row

                        grd_AllCustomer.Rows(row).Cells(0).Value = DataUMTC.Rows(row).Item("L_name").ToString
                        grd_AllCustomer.Rows(row).Cells(1).Value = DataUMTC.Rows(row).Item("F_name").ToString
                        grd_AllCustomer.Rows(row).Cells(2).Value = DataUMTC.Rows(row).Item("Stat").ToString
                        grd_AllCustomer.Rows(row).Cells(3).Value = DataUMTC.Rows(row).Item("Model").ToString
                        grd_AllCustomer.Rows(row).Cells(4).Value = DataUMTC.Rows(row).Item("Color").ToString
                        grd_AllCustomer.Rows(row).Cells(5).Value = DataUMTC.Rows(row).Item("Brnch").ToString
                        grd_AllCustomer.Rows(row).Cells(6).Value = DataUMTC.Rows(row).Item("EngineNum").ToString
                        grd_AllCustomer.Rows(row).Cells(7).Value = DataUMTC.Rows(row).Item("FrameNum").ToString
                        grd_AllCustomer.Rows(row).Cells(8).Value = DataUMTC.Rows(row).Item("TypeOP").ToString
                        grd_AllCustomer.Rows(row).Cells(9).Value = DataUMTC.Rows(row).Item("TermOP").ToString
                        grd_AllCustomer.Rows(row).Cells(10).Value = DataUMTC.Rows(row).Item("Amount_paid").ToString
                        grd_AllCustomer.Rows(row).Cells(11).Value = DataUMTC.Rows(row).Item("Price").ToString
                        grd_AllCustomer.Rows(row).Cells(12).Value = Format(Convert.ToDateTime(DataUMTC.Rows(row).Item("Date_ordered").ToString), "MMM dd, yyyy")
                        grd_AllCustomer.Rows(row).Cells(13).Value = DataUMTC.Rows(row).Item("SIV").ToString
                        grd_AllCustomer.Rows(row).Cells(14).Value = DataUMTC.Rows(row).Item("Payment_Status").ToString
                        grd_AllCustomer.Rows(row).Cells(15).Value = DataUMTC.Rows(row).Item("id").ToString

                        row = row + 1
                    End While

                End If
            End With
            sqlUMTCAdapter.Dispose()
            DataUMTC.Dispose()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub
    Private Sub Btn_Dashboard_Click(sender As Object, e As EventArgs) Handles Btn_Dashboard.Click
        DashBoard.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Edit.Click

        With UpdateStocks
            action = "edit"
            .lbl_branch.Text = grd_AllCustomer.CurrentRow.Cells(5).Value
            .Lbl_Stat.Text = grd_AllCustomer.CurrentRow.Cells(2).Value

            .Txt_SIN.Text = grd_AllCustomer.CurrentRow.Cells(12).Value
            .Txt_Fname.Text = grd_AllCustomer.CurrentRow.Cells(1).Value
            .Txt_Lname.Text = grd_AllCustomer.CurrentRow.Cells(0).Value
            .Txt_Amount.Text = grd_AllCustomer.CurrentRow.Cells(10).Value
            .Cmb_Type.Text = grd_AllCustomer.CurrentRow.Cells(8).Value
            .Cmb_Term.Text = grd_AllCustomer.CurrentRow.Cells(9).Value
            .Cmb_Stat.Text = grd_AllCustomer.CurrentRow.Cells(2).Value

            .Txt_SIN.Text = grd_AllCustomer.CurrentRow.Cells(13).Value
            .Txt_Model.Text = grd_AllCustomer.CurrentRow.Cells(3).Value
            .Txt_Color.Text = grd_AllCustomer.CurrentRow.Cells(4).Value
            .Txt_Price.Text = grd_AllCustomer.CurrentRow.Cells(11).Value
            .Txt_EngineNumber.Text = grd_AllCustomer.CurrentRow.Cells(6).Value
            .Txt_FrameNumber.Text = grd_AllCustomer.CurrentRow.Cells(7).Value
            .ShowDialog()
        End With
        PrcDisplayAllCustomers()
    End Sub
    'buttons end

    'features
    Private Sub Txt_Search_TextChanged(sender As Object, e As EventArgs) Handles Txt_Search.TextChanged
        If Chk_Auto.Checked = True Then
            AutofillSearch()
        Else

        End If
    End Sub

    Private Sub Get_id(sender As Object, e As DataGridViewCellEventArgs) Handles grd_AllCustomer.CellClick
        Cust_id = grd_AllCustomer.CurrentRow.Cells(15).Value
    End Sub

    Private Sub Btn_FullPaid_Click(sender As Object, e As EventArgs) Handles Btn_FullPaid.Click
        With command
            .Parameters.Clear()
            .CommandText = "prc_editTransac"
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@p_id", grd_AllCustomer.CurrentRow.Cells(15).Value)
            .Parameters.AddWithValue("@p_FName", grd_AllCustomer.CurrentRow.Cells(1).Value)
            .Parameters.AddWithValue("@p_LName", grd_AllCustomer.CurrentRow.Cells(0).Value)
            .Parameters.AddWithValue("@p_Amount", CDbl(grd_AllCustomer.CurrentRow.Cells(11).Value))
            .Parameters.AddWithValue("@p_TermOP", grd_AllCustomer.CurrentRow.Cells(9).Value)
            .Parameters.AddWithValue("@p_TypeOP", grd_AllCustomer.CurrentRow.Cells(8).Value)
            .Parameters.AddWithValue("@p_SIV", grd_AllCustomer.CurrentRow.Cells(13).Value)
            .Parameters.AddWithValue("@p_dd", Format(dt.Value, "yyyy-MM-dd"))
            .Parameters.AddWithValue("@p_PaymentStatus", "Fully Paid")
        End With
        With command
            .Parameters.Clear()
            .CommandText = "prc_Record"
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@p_Action", "Edit Transferred unit")
            .Parameters.AddWithValue("@p_d", todaysdate) 'H:mm:ss  this snip of code is in case if the record with time works 
            .Parameters.AddWithValue("@p_Unit", grd_AllCustomer.CurrentRow.Cells(6).Value)
            .Parameters.AddWithValue("@p_branch", grd_AllCustomer.CurrentRow.Cells(5).Value)
            .Parameters.AddWithValue("@p_FromState", grd_AllCustomer.CurrentRow.Cells(2).Value)
            .Parameters.AddWithValue("@p_ToState", "Released")
            .Parameters.AddWithValue("@p_Customer", grd_AllCustomer.CurrentRow.Cells(1).Value + " " + grd_AllCustomer.CurrentRow.Cells(0).Value)
            .Parameters.AddWithValue("@p_Employee", Username)
            .ExecuteNonQuery()
        End With

        If Txt_Search.Text <> "" Then
            AutofillSearch()
        Else
            PrcDisplayAllCustomers()
        End If
    End Sub

    'features end
End Class