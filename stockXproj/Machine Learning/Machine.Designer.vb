﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Machine
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
        Me.Create = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cmb_Branch = New System.Windows.Forms.ComboBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Create
        '
        Me.Create.BackColor = System.Drawing.Color.Firebrick
        Me.Create.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Create.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Create.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Create.Location = New System.Drawing.Point(923, 92)
        Me.Create.Name = "Create"
        Me.Create.Size = New System.Drawing.Size(115, 41)
        Me.Create.TabIndex = 26
        Me.Create.Text = "PREDICT"
        Me.Create.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bodoni MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 27)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "RESULT:"
        '
        'Cmb_Branch
        '
        Me.Cmb_Branch.AutoCompleteCustomSource.AddRange(New String() {"Model", "Invoice", "Date", "Color", "Price", "Engine Number", "Frame Number"})
        Me.Cmb_Branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Branch.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Branch.FormattingEnabled = True
        Me.Cmb_Branch.Items.AddRange(New Object() {"Bajada", "Davao", "Digos", "Kidapawan", "Tagum", "General Santos"})
        Me.Cmb_Branch.Location = New System.Drawing.Point(764, 33)
        Me.Cmb_Branch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cmb_Branch.Name = "Cmb_Branch"
        Me.Cmb_Branch.Size = New System.Drawing.Size(361, 31)
        Me.Cmb_Branch.TabIndex = 66
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(6, 33)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(706, 919)
        Me.RichTextBox1.TabIndex = 67
        Me.RichTextBox1.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bodoni MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(718, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 27)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "ACCURACY:"
        '
        'Machine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1224, 953)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cmb_Branch)
        Me.Controls.Add(Me.Create)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Name = "Machine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Machine"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Create As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Cmb_Branch As ComboBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label2 As Label
End Class
