<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bijele
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
        Me.txt_king = New System.Windows.Forms.TextBox()
        Me.txt_queen = New System.Windows.Forms.TextBox()
        Me.txt_rook = New System.Windows.Forms.TextBox()
        Me.txt_bisho = New System.Windows.Forms.TextBox()
        Me.txt_knight = New System.Windows.Forms.TextBox()
        Me.txt_pawn = New System.Windows.Forms.TextBox()
        Me.btn_answer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_king
        '
        Me.txt_king.Location = New System.Drawing.Point(44, 12)
        Me.txt_king.Name = "txt_king"
        Me.txt_king.Size = New System.Drawing.Size(150, 31)
        Me.txt_king.TabIndex = 0
        '
        'txt_queen
        '
        Me.txt_queen.Location = New System.Drawing.Point(44, 93)
        Me.txt_queen.Name = "txt_queen"
        Me.txt_queen.Size = New System.Drawing.Size(150, 31)
        Me.txt_queen.TabIndex = 1
        '
        'txt_rook
        '
        Me.txt_rook.Location = New System.Drawing.Point(44, 171)
        Me.txt_rook.Name = "txt_rook"
        Me.txt_rook.Size = New System.Drawing.Size(150, 31)
        Me.txt_rook.TabIndex = 2
        '
        'txt_bisho
        '
        Me.txt_bisho.Location = New System.Drawing.Point(44, 237)
        Me.txt_bisho.Name = "txt_bisho"
        Me.txt_bisho.Size = New System.Drawing.Size(150, 31)
        Me.txt_bisho.TabIndex = 3
        '
        'txt_knight
        '
        Me.txt_knight.Location = New System.Drawing.Point(44, 313)
        Me.txt_knight.Name = "txt_knight"
        Me.txt_knight.Size = New System.Drawing.Size(150, 31)
        Me.txt_knight.TabIndex = 4
        '
        'txt_pawn
        '
        Me.txt_pawn.Location = New System.Drawing.Point(44, 377)
        Me.txt_pawn.Name = "txt_pawn"
        Me.txt_pawn.Size = New System.Drawing.Size(150, 31)
        Me.txt_pawn.TabIndex = 5
        '
        'btn_answer
        '
        Me.btn_answer.Location = New System.Drawing.Point(476, 167)
        Me.btn_answer.Name = "btn_answer"
        Me.btn_answer.Size = New System.Drawing.Size(112, 34)
        Me.btn_answer.TabIndex = 6
        Me.btn_answer.Text = "Answer"
        Me.btn_answer.UseVisualStyleBackColor = True
        '
        'bijele
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_answer)
        Me.Controls.Add(Me.txt_pawn)
        Me.Controls.Add(Me.txt_knight)
        Me.Controls.Add(Me.txt_bisho)
        Me.Controls.Add(Me.txt_rook)
        Me.Controls.Add(Me.txt_queen)
        Me.Controls.Add(Me.txt_king)
        Me.Name = "bijele"
        Me.Text = "bijele"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_king As TextBox
    Friend WithEvents txt_queen As TextBox
    Friend WithEvents txt_rook As TextBox
    Friend WithEvents txt_bisho As TextBox
    Friend WithEvents txt_knight As TextBox
    Friend WithEvents txt_pawn As TextBox
    Friend WithEvents btn_answer As Button
End Class
