<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.txt_row = New System.Windows.Forms.TextBox()
        Me.txt_column = New System.Windows.Forms.TextBox()
        Me.btn_rect = New System.Windows.Forms.Button()
        Me.lbl_star = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_row
        '
        Me.txt_row.Location = New System.Drawing.Point(217, 12)
        Me.txt_row.Name = "txt_row"
        Me.txt_row.Size = New System.Drawing.Size(150, 31)
        Me.txt_row.TabIndex = 0
        '
        'txt_column
        '
        Me.txt_column.Location = New System.Drawing.Point(217, 74)
        Me.txt_column.Name = "txt_column"
        Me.txt_column.Size = New System.Drawing.Size(150, 31)
        Me.txt_column.TabIndex = 1
        '
        'btn_rect
        '
        Me.btn_rect.Location = New System.Drawing.Point(203, 275)
        Me.btn_rect.Name = "btn_rect"
        Me.btn_rect.Size = New System.Drawing.Size(224, 76)
        Me.btn_rect.TabIndex = 2
        Me.btn_rect.Text = "create rectangle"
        Me.btn_rect.UseVisualStyleBackColor = True
        '
        'lbl_star
        '
        Me.lbl_star.AutoSize = True
        Me.lbl_star.Location = New System.Drawing.Point(189, 160)
        Me.lbl_star.Name = "lbl_star"
        Me.lbl_star.Size = New System.Drawing.Size(0, 25)
        Me.lbl_star.TabIndex = 3
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_star)
        Me.Controls.Add(Me.btn_rect)
        Me.Controls.Add(Me.txt_column)
        Me.Controls.Add(Me.txt_row)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_row As TextBox
    Friend WithEvents txt_column As TextBox
    Friend WithEvents btn_rect As Button
    Friend WithEvents lbl_star As Label
End Class
