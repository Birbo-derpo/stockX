﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reserve
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reserve))
        Me.Btn_AddReserve = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Grd_MotorcycleReserved = New System.Windows.Forms.DataGridView()
        Me.Column10 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Btn_Add_MT = New System.Windows.Forms.Button()
        Me.cmb_branch = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_MTN = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Btn_AvStock = New System.Windows.Forms.Button()
        Me.Btn_Reserved = New System.Windows.Forms.Button()
        Me.Btn_Transit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dt = New System.Windows.Forms.DateTimePicker()
        Me.Btn_CancelReserve = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.Grd_MotorcycleReserved, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_AddReserve
        '
        Me.Btn_AddReserve.Location = New System.Drawing.Point(744, 382)
        Me.Btn_AddReserve.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_AddReserve.Name = "Btn_AddReserve"
        Me.Btn_AddReserve.Size = New System.Drawing.Size(107, 50)
        Me.Btn_AddReserve.TabIndex = 29
        Me.Btn_AddReserve.Text = "Reserve"
        Me.Btn_AddReserve.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1445, 258)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 27)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "BRANCH:"
        '
        'Grd_MotorcycleReserved
        '
        Me.Grd_MotorcycleReserved.AllowUserToAddRows = False
        Me.Grd_MotorcycleReserved.AllowUserToDeleteRows = False
        Me.Grd_MotorcycleReserved.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grd_MotorcycleReserved.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column10, Me.Column9, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.Grd_MotorcycleReserved.Location = New System.Drawing.Point(245, 313)
        Me.Grd_MotorcycleReserved.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Grd_MotorcycleReserved.Name = "Grd_MotorcycleReserved"
        Me.Grd_MotorcycleReserved.RowHeadersWidth = 51
        Me.Grd_MotorcycleReserved.RowTemplate.Height = 24
        Me.Grd_MotorcycleReserved.Size = New System.Drawing.Size(1686, 581)
        Me.Grd_MotorcycleReserved.TabIndex = 34
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column10.HeaderText = "TO DELIVER"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column9.HeaderText = "BRANCH"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "INVOICE NUMBER"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "RESERVED DATE"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "MODEL"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "COLOR"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "PRICE"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.HeaderText = "ENGINE NUMBER"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column7.HeaderText = "FRAME NUMBER"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column8.HeaderText = "STATUS"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Btn_Add_MT
        '
        Me.Btn_Add_MT.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_Add_MT.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Add_MT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_Add_MT.Location = New System.Drawing.Point(243, 898)
        Me.Btn_Add_MT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Add_MT.Name = "Btn_Add_MT"
        Me.Btn_Add_MT.Size = New System.Drawing.Size(159, 57)
        Me.Btn_Add_MT.TabIndex = 35
        Me.Btn_Add_MT.Text = "ADD MT NO."
        Me.Btn_Add_MT.UseVisualStyleBackColor = False
        '
        'cmb_branch
        '
        Me.cmb_branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_branch.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_branch.FormattingEnabled = True
        Me.cmb_branch.Items.AddRange(New Object() {"Bajada", "Davao", "Digos", "Kidapawan", "Tagum", "General Santos"})
        Me.cmb_branch.Location = New System.Drawing.Point(1572, 255)
        Me.cmb_branch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_branch.Name = "cmb_branch"
        Me.cmb_branch.Size = New System.Drawing.Size(359, 31)
        Me.cmb_branch.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(246, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(364, 27)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "MERCHANDISE TRANSFER NO:"
        '
        'txt_MTN
        '
        Me.txt_MTN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_MTN.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MTN.Location = New System.Drawing.Point(629, 211)
        Me.txt_MTN.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_MTN.Name = "txt_MTN"
        Me.txt_MTN.Size = New System.Drawing.Size(527, 34)
        Me.txt_MTN.TabIndex = 42
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MistyRose
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Btn_AvStock)
        Me.GroupBox1.Controls.Add(Me.Btn_Reserved)
        Me.GroupBox1.Controls.Add(Me.Btn_Transit)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(-3, 313)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(247, 581)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Snow
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(19, 176)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(211, 62)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "AVAILABLE UNITS"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Btn_AvStock
        '
        Me.Btn_AvStock.BackColor = System.Drawing.Color.Snow
        Me.Btn_AvStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_AvStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AvStock.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btn_AvStock.Location = New System.Drawing.Point(19, 110)
        Me.Btn_AvStock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_AvStock.Name = "Btn_AvStock"
        Me.Btn_AvStock.Size = New System.Drawing.Size(211, 62)
        Me.Btn_AvStock.TabIndex = 33
        Me.Btn_AvStock.Text = "ALL UNITS"
        Me.Btn_AvStock.UseVisualStyleBackColor = False
        '
        'Btn_Reserved
        '
        Me.Btn_Reserved.BackColor = System.Drawing.Color.Snow
        Me.Btn_Reserved.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Reserved.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Reserved.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btn_Reserved.Location = New System.Drawing.Point(19, 242)
        Me.Btn_Reserved.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Reserved.Name = "Btn_Reserved"
        Me.Btn_Reserved.Size = New System.Drawing.Size(211, 62)
        Me.Btn_Reserved.TabIndex = 32
        Me.Btn_Reserved.Text = "RESERVED UNITS"
        Me.Btn_Reserved.UseVisualStyleBackColor = False
        '
        'Btn_Transit
        '
        Me.Btn_Transit.BackColor = System.Drawing.Color.Snow
        Me.Btn_Transit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Transit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Transit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btn_Transit.Location = New System.Drawing.Point(19, 310)
        Me.Btn_Transit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Transit.Name = "Btn_Transit"
        Me.Btn_Transit.Size = New System.Drawing.Size(211, 62)
        Me.Btn_Transit.TabIndex = 34
        Me.Btn_Transit.Text = "TRANSIT UNITS"
        Me.Btn_Transit.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Firebrick
        Me.Button1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(39, 898)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 57)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "DASHBOARD"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'dt
        '
        Me.dt.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt.Location = New System.Drawing.Point(1572, 219)
        Me.dt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dt.Name = "dt"
        Me.dt.Size = New System.Drawing.Size(359, 27)
        Me.dt.TabIndex = 57
        '
        'Btn_CancelReserve
        '
        Me.Btn_CancelReserve.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_CancelReserve.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_CancelReserve.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_CancelReserve.Location = New System.Drawing.Point(1799, 898)
        Me.Btn_CancelReserve.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_CancelReserve.Name = "Btn_CancelReserve"
        Me.Btn_CancelReserve.Size = New System.Drawing.Size(159, 57)
        Me.Btn_CancelReserve.TabIndex = 62
        Me.Btn_CancelReserve.Text = "CANCEL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RESERVATION" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Btn_CancelReserve.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(245, 2)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1788, 190)
        Me.PictureBox2.TabIndex = 87
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(247, 192)
        Me.PictureBox1.TabIndex = 88
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Book Antiqua", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(206, 80)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "RESERVED " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    UNITS"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(73, 280)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(100, 20)
        Me.CheckBox2.TabIndex = 91
        Me.CheckBox2.Text = "CHECK ALL"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(141, 9)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(100, 20)
        Me.CheckBox1.TabIndex = 91
        Me.CheckBox1.Text = "CHECK ALL"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Reserve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(1924, 977)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Btn_CancelReserve)
        Me.Controls.Add(Me.dt)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_MTN)
        Me.Controls.Add(Me.cmb_branch)
        Me.Controls.Add(Me.Btn_Add_MT)
        Me.Controls.Add(Me.Grd_MotorcycleReserved)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Reserve"
        Me.Text = "Reserve"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Grd_MotorcycleReserved, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_AddReserve As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Grd_MotorcycleReserved As DataGridView
    Friend WithEvents Btn_Add_MT As Button
    Friend WithEvents cmb_branch As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_MTN As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Btn_AvStock As Button
    Friend WithEvents Btn_Reserved As Button
    Friend WithEvents Btn_Transit As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents dt As DateTimePicker
    Friend WithEvents Button2 As Button
    Friend WithEvents Btn_CancelReserve As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Column10 As DataGridViewCheckBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
End Class
