<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GenPassBnt = New System.Windows.Forms.Button()
        Me.Resetbnt = New System.Windows.Forms.Button()
        Me.ExitBNT = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'GenPassBnt
        '
        Me.GenPassBnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenPassBnt.Location = New System.Drawing.Point(12, 298)
        Me.GenPassBnt.Name = "GenPassBnt"
        Me.GenPassBnt.Size = New System.Drawing.Size(124, 94)
        Me.GenPassBnt.TabIndex = 0
        Me.GenPassBnt.Text = "Generate Password"
        Me.GenPassBnt.UseVisualStyleBackColor = True
        '
        'Resetbnt
        '
        Me.Resetbnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resetbnt.Location = New System.Drawing.Point(152, 325)
        Me.Resetbnt.Name = "Resetbnt"
        Me.Resetbnt.Size = New System.Drawing.Size(75, 40)
        Me.Resetbnt.TabIndex = 1
        Me.Resetbnt.Text = "Reset"
        Me.Resetbnt.UseVisualStyleBackColor = True
        '
        'ExitBNT
        '
        Me.ExitBNT.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBNT.Location = New System.Drawing.Point(239, 325)
        Me.ExitBNT.Name = "ExitBNT"
        Me.ExitBNT.Size = New System.Drawing.Size(75, 45)
        Me.ExitBNT.TabIndex = 2
        Me.ExitBNT.Text = "Exit"
        Me.ExitBNT.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(74, 32)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(197, 251)
        Me.ListBox1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 404)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ExitBNT)
        Me.Controls.Add(Me.Resetbnt)
        Me.Controls.Add(Me.GenPassBnt)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GenPassBnt As System.Windows.Forms.Button
    Friend WithEvents Resetbnt As System.Windows.Forms.Button
    Friend WithEvents ExitBNT As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox

End Class
