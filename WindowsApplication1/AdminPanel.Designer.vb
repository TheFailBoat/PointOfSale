<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminPanel
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.AdminPanelDelete = New System.Windows.Forms.Button()
        Me.AdminPanelAddNote = New System.Windows.Forms.Button()
        Me.AdminPanelAdmin = New System.Windows.Forms.Button()
        Me.AdminPanelTableSelect = New System.Windows.Forms.Button()
        Me.AdminPanelTheDate = New System.Windows.Forms.Label()
        Me.AdminPanelBillNumber = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'AdminPanelDelete
        '
        Me.AdminPanelDelete.Location = New System.Drawing.Point(3, 3)
        Me.AdminPanelDelete.Name = "AdminPanelDelete"
        Me.AdminPanelDelete.Size = New System.Drawing.Size(135, 67)
        Me.AdminPanelDelete.TabIndex = 0
        Me.AdminPanelDelete.Text = "Delete Item"
        Me.AdminPanelDelete.UseVisualStyleBackColor = True
        '
        'AdminPanelAddNote
        '
        Me.AdminPanelAddNote.Location = New System.Drawing.Point(144, 3)
        Me.AdminPanelAddNote.Name = "AdminPanelAddNote"
        Me.AdminPanelAddNote.Size = New System.Drawing.Size(135, 67)
        Me.AdminPanelAddNote.TabIndex = 1
        Me.AdminPanelAddNote.Text = "Add Note"
        Me.AdminPanelAddNote.UseVisualStyleBackColor = True
        '
        'AdminPanelAdmin
        '
        Me.AdminPanelAdmin.Location = New System.Drawing.Point(285, 3)
        Me.AdminPanelAdmin.Name = "AdminPanelAdmin"
        Me.AdminPanelAdmin.Size = New System.Drawing.Size(135, 67)
        Me.AdminPanelAdmin.TabIndex = 2
        Me.AdminPanelAdmin.Text = "Admin Functions"
        Me.AdminPanelAdmin.UseVisualStyleBackColor = True
        '
        'AdminPanelTableSelect
        '
        Me.AdminPanelTableSelect.Location = New System.Drawing.Point(525, 3)
        Me.AdminPanelTableSelect.Name = "AdminPanelTableSelect"
        Me.AdminPanelTableSelect.Size = New System.Drawing.Size(135, 67)
        Me.AdminPanelTableSelect.TabIndex = 3
        Me.AdminPanelTableSelect.Text = "Table #"
        Me.AdminPanelTableSelect.UseVisualStyleBackColor = True
        '
        'AdminPanelTheDate
        '
        Me.AdminPanelTheDate.AutoSize = True
        Me.AdminPanelTheDate.Location = New System.Drawing.Point(678, 30)
        Me.AdminPanelTheDate.Name = "AdminPanelTheDate"
        Me.AdminPanelTheDate.Size = New System.Drawing.Size(127, 13)
        Me.AdminPanelTheDate.TabIndex = 4
        Me.AdminPanelTheDate.Text = "THE DATE GOES HERE"
        '
        'AdminPanelBillNumber
        '
        Me.AdminPanelBillNumber.AutoSize = True
        Me.AdminPanelBillNumber.Location = New System.Drawing.Point(811, 30)
        Me.AdminPanelBillNumber.Name = "AdminPanelBillNumber"
        Me.AdminPanelBillNumber.Size = New System.Drawing.Size(127, 13)
        Me.AdminPanelBillNumber.TabIndex = 5
        Me.AdminPanelBillNumber.Text = "THE BILL# GOES HERE"
        '
        'AdminPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.AdminPanelBillNumber)
        Me.Controls.Add(Me.AdminPanelTheDate)
        Me.Controls.Add(Me.AdminPanelTableSelect)
        Me.Controls.Add(Me.AdminPanelAdmin)
        Me.Controls.Add(Me.AdminPanelAddNote)
        Me.Controls.Add(Me.AdminPanelDelete)
        Me.Name = "AdminPanel"
        Me.Size = New System.Drawing.Size(949, 73)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AdminPanelDelete As System.Windows.Forms.Button
    Friend WithEvents AdminPanelAddNote As System.Windows.Forms.Button
    Friend WithEvents AdminPanelAdmin As System.Windows.Forms.Button
    Friend WithEvents AdminPanelTableSelect As System.Windows.Forms.Button
    Friend WithEvents AdminPanelTheDate As System.Windows.Forms.Label
    Friend WithEvents AdminPanelBillNumber As System.Windows.Forms.Label

End Class
