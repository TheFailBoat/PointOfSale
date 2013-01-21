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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'CalcInputPanel1
        '
        Me.CalcInputPanel1.BackColor = System.Drawing.SystemColors.Control
        Me.CalcInputPanel1.Location = New System.Drawing.Point(35, 461)
        Me.CalcInputPanel1.Name = "CalcInputPanel1"
        Me.CalcInputPanel1.Size = New System.Drawing.Size(334, 257)
        Me.CalcInputPanel1.TabIndex = 0
        '
        'AdminPanel1
        '
        Me.AdminPanel1.Location = New System.Drawing.Point(35, 12)
        Me.AdminPanel1.Name = "AdminPanel1"
        Me.AdminPanel1.Size = New System.Drawing.Size(949, 73)
        Me.AdminPanel1.TabIndex = 1
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(562, 91)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(434, 368)
        Me.ListBox1.TabIndex = 2
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.AdminPanel1)
        Me.Controls.Add(Me.CalcInputPanel1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CalcInputPanel1 As WindowsApplication1.CalcInputPanel
    Friend WithEvents AdminPanel1 As WindowsApplication1.AdminPanel
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
End Class
