<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class datavalidation
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
        Me.txt_data = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_check = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_data
        '
        Me.txt_data.Location = New System.Drawing.Point(402, 55)
        Me.txt_data.Name = "txt_data"
        Me.txt_data.Size = New System.Drawing.Size(150, 31)
        Me.txt_data.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(200, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter between 20 - 45"
        '
        'btn_check
        '
        Me.btn_check.Location = New System.Drawing.Point(320, 175)
        Me.btn_check.Name = "btn_check"
        Me.btn_check.Size = New System.Drawing.Size(155, 45)
        Me.btn_check.TabIndex = 2
        Me.btn_check.Text = "check"
        Me.btn_check.UseVisualStyleBackColor = True
        '
        'datavalidation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_check)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_data)
        Me.Name = "datavalidation"
        Me.Text = "datavalidation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_data As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_check As Button
End Class
