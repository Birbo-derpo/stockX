﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConfirmReserve
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_tobranch = New System.Windows.Forms.ComboBox()
        Me.Btn_ConfirmReserve = New System.Windows.Forms.Button()
        Me.chkAuto = New System.Windows.Forms.CheckBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cmbSearchType = New System.Windows.Forms.ComboBox()
        Me.grdMotorcycle = New System.Windows.Forms.DataGridView()
        Me.Btn_back = New System.Windows.Forms.Button()
        Me.dt = New System.Windows.Forms.DateTimePicker()
        Me.Column8 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grdMotorcycle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(675, 100)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "BRANCH:"
        '
        'cmb_tobranch
        '
        Me.cmb_tobranch.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tobranch.FormattingEnabled = True
        Me.cmb_tobranch.Items.AddRange(New Object() {"Bajada", "Davao", "Digos", "Kidapawan", "Tagum", "General Santos"})
        Me.cmb_tobranch.Location = New System.Drawing.Point(754, 98)
        Me.cmb_tobranch.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_tobranch.Name = "cmb_tobranch"
        Me.cmb_tobranch.Size = New System.Drawing.Size(164, 24)
        Me.cmb_tobranch.TabIndex = 27
        '
        'Btn_ConfirmReserve
        '
        Me.Btn_ConfirmReserve.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_ConfirmReserve.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_ConfirmReserve.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ConfirmReserve.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_ConfirmReserve.Location = New System.Drawing.Point(825, 356)
        Me.Btn_ConfirmReserve.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_ConfirmReserve.Name = "Btn_ConfirmReserve"
        Me.Btn_ConfirmReserve.Size = New System.Drawing.Size(93, 27)
        Me.Btn_ConfirmReserve.TabIndex = 26
        Me.Btn_ConfirmReserve.Text = "RESERVE"
        Me.Btn_ConfirmReserve.UseVisualStyleBackColor = False
        '
        'chkAuto
        '
        Me.chkAuto.AutoSize = True
        Me.chkAuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAuto.Location = New System.Drawing.Point(127, 84)
        Me.chkAuto.Margin = New System.Windows.Forms.Padding(2)
        Me.chkAuto.Name = "chkAuto"
        Me.chkAuto.Size = New System.Drawing.Size(132, 21)
        Me.chkAuto.TabIndex = 25
        Me.chkAuto.Text = "Auto Complete"
        Me.chkAuto.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Firebrick
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSearch.Location = New System.Drawing.Point(403, 30)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(93, 27)
        Me.btnSearch.TabIndex = 24
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(124, 33)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(275, 23)
        Me.txtSearch.TabIndex = 23
        '
        'cmbSearchType
        '
        Me.cmbSearchType.AutoCompleteCustomSource.AddRange(New String() {"Model", "Invoice", "Date", "Color", "Price", "Engine Number", "Frame Number"})
        Me.cmbSearchType.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearchType.FormattingEnabled = True
        Me.cmbSearchType.Items.AddRange(New Object() {"Model", "Invoice", "Date", "Color", "Price", "Engine Number", "Frame Number"})
        Me.cmbSearchType.Location = New System.Drawing.Point(124, 58)
        Me.cmbSearchType.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbSearchType.Name = "cmbSearchType"
        Me.cmbSearchType.Size = New System.Drawing.Size(275, 24)
        Me.cmbSearchType.TabIndex = 22
        '
        'grdMotorcycle
        '
        Me.grdMotorcycle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdMotorcycle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column8, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.grdMotorcycle.Location = New System.Drawing.Point(127, 128)
        Me.grdMotorcycle.Margin = New System.Windows.Forms.Padding(2)
        Me.grdMotorcycle.Name = "grdMotorcycle"
        Me.grdMotorcycle.ReadOnly = True
        Me.grdMotorcycle.RowHeadersWidth = 51
        Me.grdMotorcycle.RowTemplate.Height = 24
        Me.grdMotorcycle.Size = New System.Drawing.Size(791, 217)
        Me.grdMotorcycle.TabIndex = 21
        '
        'Btn_back
        '
        Me.Btn_back.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_back.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_back.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_back.Location = New System.Drawing.Point(127, 356)
        Me.Btn_back.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_back.Name = "Btn_back"
        Me.Btn_back.Size = New System.Drawing.Size(93, 27)
        Me.Btn_back.TabIndex = 29
        Me.Btn_back.Text = "BACK"
        Me.Btn_back.UseVisualStyleBackColor = False
        '
        'dt
        '
        Me.dt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt.Location = New System.Drawing.Point(648, 33)
        Me.dt.Margin = New System.Windows.Forms.Padding(2)
        Me.dt.Name = "dt"
        Me.dt.Size = New System.Drawing.Size(270, 23)
        Me.dt.TabIndex = 56
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "Check_state"
        Me.Column8.HeaderText = "Check select"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 125
        '
        'Column1
        '
        Me.Column1.HeaderText = "Invoice Number"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Date added"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Model"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Color"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Price"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 125
        '
        'Column6
        '
        Me.Column6.HeaderText = "Engine Number"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 125
        '
        'Column7
        '
        Me.Column7.HeaderText = "Frame Number"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 125
        '
        'ConfirmReserve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 429)
        Me.Controls.Add(Me.dt)
        Me.Controls.Add(Me.Btn_back)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_tobranch)
        Me.Controls.Add(Me.Btn_ConfirmReserve)
        Me.Controls.Add(Me.chkAuto)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cmbSearchType)
        Me.Controls.Add(Me.grdMotorcycle)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ConfirmReserve"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ConfirmReserve"
        CType(Me.grdMotorcycle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_tobranch As ComboBox
    Friend WithEvents Btn_ConfirmReserve As Button
    Friend WithEvents chkAuto As CheckBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cmbSearchType As ComboBox
    Friend WithEvents grdMotorcycle As DataGridView
    Friend WithEvents Btn_back As Button
    Friend WithEvents dt As DateTimePicker
    Friend WithEvents Column8 As DataGridViewCheckBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
