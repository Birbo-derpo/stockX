﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class S_AllStock
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(S_AllStock))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_branch = New System.Windows.Forms.ComboBox()
        Me.Btn_Dashboard = New System.Windows.Forms.Button()
        Me.Btn_AddCust = New System.Windows.Forms.Button()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Grd_Stock = New System.Windows.Forms.DataGridView()
        Me.Btn_AllStock = New System.Windows.Forms.Button()
        Me.Btn_Released = New System.Windows.Forms.Button()
        Me.Btn_Deposited = New System.Windows.Forms.Button()
        Me.Btn_Repossess = New System.Windows.Forms.Button()
        Me.Chk_Auto = New System.Windows.Forms.CheckBox()
        Me.Btn_Search = New System.Windows.Forms.Button()
        Me.Txt_Search = New System.Windows.Forms.TextBox()
        Me.cmbSearchType = New System.Windows.Forms.ComboBox()
        Me.Btn_AllUnits = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Lbl_Branch = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.Grd_Stock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1440, 264)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 29)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "BRANCH:"
        '
        'cmb_branch
        '
        Me.cmb_branch.AutoCompleteCustomSource.AddRange(New String() {"Bajada", "Davao", "Digos", "Kidapawan", "Tagum", "General Santos"})
        Me.cmb_branch.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_branch.FormattingEnabled = True
        Me.cmb_branch.Items.AddRange(New Object() {"Bajada", "Davao", "Digos", "Kidapawan", "Tagum", "General Santos"})
        Me.cmb_branch.Location = New System.Drawing.Point(1572, 257)
        Me.cmb_branch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_branch.Name = "cmb_branch"
        Me.cmb_branch.Size = New System.Drawing.Size(361, 39)
        Me.cmb_branch.TabIndex = 78
        '
        'Btn_Dashboard
        '
        Me.Btn_Dashboard.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Dashboard.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Dashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Dashboard.Location = New System.Drawing.Point(245, 828)
        Me.Btn_Dashboard.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Dashboard.Name = "Btn_Dashboard"
        Me.Btn_Dashboard.Size = New System.Drawing.Size(177, 69)
        Me.Btn_Dashboard.TabIndex = 77
        Me.Btn_Dashboard.Text = "DASHBOARD"
        Me.Btn_Dashboard.UseVisualStyleBackColor = False
        '
        'Btn_AddCust
        '
        Me.Btn_AddCust.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_AddCust.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_AddCust.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AddCust.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_AddCust.Location = New System.Drawing.Point(428, 828)
        Me.Btn_AddCust.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_AddCust.Name = "Btn_AddCust"
        Me.Btn_AddCust.Size = New System.Drawing.Size(177, 69)
        Me.Btn_AddCust.TabIndex = 72
        Me.Btn_AddCust.Text = "ADD CUSTOMER"
        Me.Btn_AddCust.UseVisualStyleBackColor = False
        '
        'Column8
        '
        Me.Column8.HeaderText = "STATUS"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 125
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "FRAME NO."
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "ENGINE NO."
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column9.HeaderText = "COLOR"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.HeaderText = "PRICE"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "MODEL"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "DATE ARRIVED"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "MT NUMBER"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        '
        'Column7
        '
        Me.Column7.HeaderText = "BRANCH"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 125
        '
        'Grd_Stock
        '
        Me.Grd_Stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grd_Stock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column1, Me.Column2, Me.Column3, Me.Column6, Me.Column9, Me.Column4, Me.Column5, Me.Column8})
        Me.Grd_Stock.Location = New System.Drawing.Point(245, 313)
        Me.Grd_Stock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Grd_Stock.Name = "Grd_Stock"
        Me.Grd_Stock.RowHeadersWidth = 51
        Me.Grd_Stock.RowTemplate.Height = 24
        Me.Grd_Stock.Size = New System.Drawing.Size(1688, 505)
        Me.Grd_Stock.TabIndex = 71
        '
        'Btn_AllStock
        '
        Me.Btn_AllStock.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_AllStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AllStock.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_AllStock.Location = New System.Drawing.Point(5, 142)
        Me.Btn_AllStock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_AllStock.Name = "Btn_AllStock"
        Me.Btn_AllStock.Size = New System.Drawing.Size(241, 63)
        Me.Btn_AllStock.TabIndex = 26
        Me.Btn_AllStock.Text = "AVAILABLE UNITS"
        Me.Btn_AllStock.UseVisualStyleBackColor = False
        '
        'Btn_Released
        '
        Me.Btn_Released.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_Released.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Released.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Released.Location = New System.Drawing.Point(5, 209)
        Me.Btn_Released.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Released.Name = "Btn_Released"
        Me.Btn_Released.Size = New System.Drawing.Size(241, 63)
        Me.Btn_Released.TabIndex = 23
        Me.Btn_Released.Text = "RELEASED UNITS"
        Me.Btn_Released.UseVisualStyleBackColor = False
        '
        'Btn_Deposited
        '
        Me.Btn_Deposited.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_Deposited.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Deposited.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Deposited.Location = New System.Drawing.Point(5, 276)
        Me.Btn_Deposited.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Deposited.Name = "Btn_Deposited"
        Me.Btn_Deposited.Size = New System.Drawing.Size(241, 63)
        Me.Btn_Deposited.TabIndex = 25
        Me.Btn_Deposited.Text = "DEPOSITED UNITS"
        Me.Btn_Deposited.UseVisualStyleBackColor = False
        '
        'Btn_Repossess
        '
        Me.Btn_Repossess.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_Repossess.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Repossess.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Repossess.Location = New System.Drawing.Point(5, 343)
        Me.Btn_Repossess.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Repossess.Name = "Btn_Repossess"
        Me.Btn_Repossess.Size = New System.Drawing.Size(241, 63)
        Me.Btn_Repossess.TabIndex = 24
        Me.Btn_Repossess.TabStop = False
        Me.Btn_Repossess.Text = "REPOSSESED UNITS"
        Me.Btn_Repossess.UseVisualStyleBackColor = False
        '
        'Chk_Auto
        '
        Me.Chk_Auto.AutoSize = True
        Me.Chk_Auto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Auto.Location = New System.Drawing.Point(627, 133)
        Me.Chk_Auto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Chk_Auto.Name = "Chk_Auto"
        Me.Chk_Auto.Size = New System.Drawing.Size(148, 24)
        Me.Chk_Auto.TabIndex = 76
        Me.Chk_Auto.Text = "AutoComplete"
        Me.Chk_Auto.UseVisualStyleBackColor = True
        '
        'Btn_Search
        '
        Me.Btn_Search.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Search.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Search.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Search.Location = New System.Drawing.Point(779, 80)
        Me.Btn_Search.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(124, 42)
        Me.Btn_Search.TabIndex = 75
        Me.Btn_Search.Text = "SEARCH"
        Me.Btn_Search.UseVisualStyleBackColor = False
        '
        'Txt_Search
        '
        Me.Txt_Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Search.Location = New System.Drawing.Point(245, 80)
        Me.Txt_Search.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_Search.Name = "Txt_Search"
        Me.Txt_Search.Size = New System.Drawing.Size(527, 41)
        Me.Txt_Search.TabIndex = 74
        '
        'cmbSearchType
        '
        Me.cmbSearchType.AutoCompleteCustomSource.AddRange(New String() {"Model", "Invoice", "Date", "Color", "Price", "Engine Number", "Frame Number"})
        Me.cmbSearchType.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearchType.FormattingEnabled = True
        Me.cmbSearchType.Items.AddRange(New Object() {"Model", "Invoice", "Date", "Color", "Price", "Engine Number", "Frame Number"})
        Me.cmbSearchType.Location = New System.Drawing.Point(245, 124)
        Me.cmbSearchType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbSearchType.Name = "cmbSearchType"
        Me.cmbSearchType.Size = New System.Drawing.Size(376, 39)
        Me.cmbSearchType.TabIndex = 73
        '
        'Btn_AllUnits
        '
        Me.Btn_AllUnits.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_AllUnits.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AllUnits.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_AllUnits.Location = New System.Drawing.Point(5, 75)
        Me.Btn_AllUnits.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_AllUnits.Name = "Btn_AllUnits"
        Me.Btn_AllUnits.Size = New System.Drawing.Size(241, 62)
        Me.Btn_AllUnits.TabIndex = 33
        Me.Btn_AllUnits.Text = "ALL UNITS"
        Me.Btn_AllUnits.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MistyRose
        Me.GroupBox1.Controls.Add(Me.Btn_AllUnits)
        Me.GroupBox1.Controls.Add(Me.Btn_AllStock)
        Me.GroupBox1.Controls.Add(Me.Btn_Released)
        Me.GroupBox1.Controls.Add(Me.Btn_Deposited)
        Me.GroupBox1.Controls.Add(Me.Btn_Repossess)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(-8, 313)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(247, 505)
        Me.GroupBox1.TabIndex = 80
        Me.GroupBox1.TabStop = False
        '
        'Lbl_Branch
        '
        Me.Lbl_Branch.AutoSize = True
        Me.Lbl_Branch.Location = New System.Drawing.Point(-5, 26)
        Me.Lbl_Branch.Name = "Lbl_Branch"
        Me.Lbl_Branch.Size = New System.Drawing.Size(75, 16)
        Me.Lbl_Branch.TabIndex = 70
        Me.Lbl_Branch.Text = "X BRANCH"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(247, 213)
        Me.PictureBox1.TabIndex = 81
        Me.PictureBox1.TabStop = False
        '
        'S_AllStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 922)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_branch)
        Me.Controls.Add(Me.Btn_Dashboard)
        Me.Controls.Add(Me.Btn_AddCust)
        Me.Controls.Add(Me.Grd_Stock)
        Me.Controls.Add(Me.Chk_Auto)
        Me.Controls.Add(Me.Btn_Search)
        Me.Controls.Add(Me.Txt_Search)
        Me.Controls.Add(Me.cmbSearchType)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Lbl_Branch)
        Me.Name = "S_AllStock"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Grd_Stock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_branch As ComboBox
    Friend WithEvents Btn_Dashboard As Button
    Friend WithEvents Btn_AddCust As Button
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Grd_Stock As DataGridView
    Friend WithEvents Btn_AllStock As Button
    Friend WithEvents Btn_Released As Button
    Friend WithEvents Btn_Deposited As Button
    Friend WithEvents Btn_Repossess As Button
    Friend WithEvents Chk_Auto As CheckBox
    Friend WithEvents Btn_Search As Button
    Friend WithEvents Txt_Search As TextBox
    Friend WithEvents cmbSearchType As ComboBox
    Friend WithEvents Btn_AllUnits As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Lbl_Branch As Label
End Class