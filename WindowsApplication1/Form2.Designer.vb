<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.CalcInputPanel1 = New WindowsApplication1.CalcInputPanel()
        Me.AdminPanel1 = New WindowsApplication1.AdminPanel()
        Me.SuspendLayout()
        '
        'CalcInputPanel1
        '
        Me.CalcInputPanel1.BackColor = System.Drawing.SystemColors.Control
        Me.CalcInputPanel1.Location = New System.Drawing.Point(183, 461)
        Me.CalcInputPanel1.Name = "CalcInputPanel1"
        Me.CalcInputPanel1.Size = New System.Drawing.Size(334, 257)
        Me.CalcInputPanel1.TabIndex = 0
        '
        'AdminPanel1
        '
        Me.AdminPanel1.Location = New System.Drawing.Point(2, 3)
        Me.AdminPanel1.Name = "AdminPanel1"
        Me.AdminPanel1.Size = New System.Drawing.Size(1007, 73)
        Me.AdminPanel1.TabIndex = 1
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.AdminPanel1)
        Me.Controls.Add(Me.CalcInputPanel1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CalcInputPanel1 As WindowsApplication1.CalcInputPanel
    Friend WithEvents AdminPanel1 As WindowsApplication1.AdminPanel
End Class
