﻿Imports System.Runtime.InteropServices
Imports Google.Apis
Imports MySql.Data.MySqlClient

Public Class ChangePasswordEmployee

    Dim Gmail As String


    Private Sub ChangePass()

        sqlUMTCAdapter = New MySqlDataAdapter
        DataUMTC = New DataTable
        Try
            If action = "change" Then

                With command
                    .Parameters.Clear()
                    .CommandText = "prc_ChangePasswordEmployee"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@p_user", EmployeeId)
                    .Parameters.AddWithValue("@p_oldPass", txtoldpass.Text)
                    .Parameters.AddWithValue("@p_new_password", txtnewpass.Text)
                    .Parameters.AddWithValue("@p_confirm_password", txtconfirmpass.Text)
                    sqlUMTCAdapter.SelectCommand = command
                    DataUMTC.Clear()
                    sqlUMTCAdapter.Fill(DataUMTC)

                    If DataUMTC.Rows.Count > 0 Then

                        MessageBox.Show(DataUMTC.Rows(0)("message").ToString())
                    End If



                    Me.Dispose()
                    DashBoard.Show()

                End With


            Else
                With command
                    .Parameters.Clear()
                    .CommandText = "prc_ChangePasswordEmployee"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@p_user", UserId)
                    .Parameters.AddWithValue("@p_oldPass", txtoldpass.Text)
                    .Parameters.AddWithValue("@p_new_password", txtnewpass.Text)
                    .Parameters.AddWithValue("@p_confirm_password", txtconfirmpass.Text)
                    sqlUMTCAdapter.SelectCommand = command
                    DataUMTC.Clear()
                    sqlUMTCAdapter.Fill(DataUMTC)

                    If DataUMTC.Rows.Count > 0 Then

                        MessageBox.Show(DataUMTC.Rows(0)("message").ToString())
                    End If



                    Me.Dispose()
                    S_dashboard.Show()

                End With
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to change the password?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


        If result = DialogResult.Yes Then

            action = "change"
            ChangePass()
        Else

            ChangePass()
        End If


    End Sub

    Private Sub ChangePasswordEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CheckDatabaseConnection()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Dispose()
    End Sub
End Class