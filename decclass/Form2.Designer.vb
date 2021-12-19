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
        Me.btn_evenodd = New System.Windows.Forms.Button()
        Me.txt_number = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_evenodd
        '
        Me.btn_evenodd.Location = New System.Drawing.Point(154, 180)
        Me.btn_evenodd.Name = "btn_evenodd"
        Me.btn_evenodd.Size = New System.Drawing.Size(136, 96)
        Me.btn_evenodd.TabIndex = 0
        Me.btn_evenodd.Text = "even or odd"
        Me.btn_evenodd.UseVisualStyleBackColor = True
        '
        'txt_number
        '
        Me.txt_number.Location = New System.Drawing.Point(140, 26)
        Me.txt_number.Name = "txt_number"
        Me.txt_number.Size = New System.Drawing.Size(150, 31)
        Me.txt_number.TabIndex = 1
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 424)
        Me.Controls.Add(Me.txt_number)
        Me.Controls.Add(Me.btn_evenodd)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_evenodd As Button
    Friend WithEvents txt_number As TextBox
End Class
