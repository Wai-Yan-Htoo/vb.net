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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_first_number = New System.Windows.Forms.TextBox()
        Me.txt_second_number = New System.Windows.Forms.TextBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_division = New System.Windows.Forms.Button()
        Me.btn_substract = New System.Windows.Forms.Button()
        Me.btn_multiply = New System.Windows.Forms.Button()
        Me.lbl_answer = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lb_befor_sort = New System.Windows.Forms.Label()
        Me.lb_after_sort = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Second Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Answer: "
        '
        'txt_first_number
        '
        Me.txt_first_number.Location = New System.Drawing.Point(207, 27)
        Me.txt_first_number.Name = "txt_first_number"
        Me.txt_first_number.Size = New System.Drawing.Size(150, 31)
        Me.txt_first_number.TabIndex = 3
        '
        'txt_second_number
        '
        Me.txt_second_number.Location = New System.Drawing.Point(207, 101)
        Me.txt_second_number.Name = "txt_second_number"
        Me.txt_second_number.Size = New System.Drawing.Size(150, 31)
        Me.txt_second_number.TabIndex = 4
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_add.Location = New System.Drawing.Point(48, 305)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(66, 54)
        Me.btn_add.TabIndex = 5
        Me.btn_add.Text = "+"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_division
        '
        Me.btn_division.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_division.Location = New System.Drawing.Point(37, 382)
        Me.btn_division.Name = "btn_division"
        Me.btn_division.Size = New System.Drawing.Size(66, 53)
        Me.btn_division.TabIndex = 6
        Me.btn_division.Text = "/"
        Me.btn_division.UseVisualStyleBackColor = True
        '
        'btn_substract
        '
        Me.btn_substract.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_substract.Location = New System.Drawing.Point(129, 305)
        Me.btn_substract.Name = "btn_substract"
        Me.btn_substract.Size = New System.Drawing.Size(72, 54)
        Me.btn_substract.TabIndex = 7
        Me.btn_substract.Text = "-"
        Me.btn_substract.UseVisualStyleBackColor = True
        '
        'btn_multiply
        '
        Me.btn_multiply.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_multiply.Location = New System.Drawing.Point(129, 375)
        Me.btn_multiply.Name = "btn_multiply"
        Me.btn_multiply.Size = New System.Drawing.Size(72, 53)
        Me.btn_multiply.TabIndex = 8
        Me.btn_multiply.Text = "*"
        Me.btn_multiply.UseVisualStyleBackColor = True
        '
        'lbl_answer
        '
        Me.lbl_answer.AutoSize = True
        Me.lbl_answer.Location = New System.Drawing.Point(207, 197)
        Me.lbl_answer.Name = "lbl_answer"
        Me.lbl_answer.Size = New System.Drawing.Size(22, 25)
        Me.lbl_answer.TabIndex = 9
        Me.lbl_answer.Text = "0"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(12, 461)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 53)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "next form"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(14, 547)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(154, 54)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Array"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button3.Location = New System.Drawing.Point(442, 396)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(154, 54)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "sort"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(288, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 25)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Before sorting"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(288, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 25)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "After sorting"
        '
        'lb_befor_sort
        '
        Me.lb_befor_sort.AutoSize = True
        Me.lb_befor_sort.Location = New System.Drawing.Point(428, 212)
        Me.lb_befor_sort.Name = "lb_befor_sort"
        Me.lb_befor_sort.Size = New System.Drawing.Size(213, 25)
        Me.lb_befor_sort.TabIndex = 15
        Me.lb_befor_sort.Text = "10, 2, 5, 6, 1, 4, 3, 7, 11, 9"
        '
        'lb_after_sort
        '
        Me.lb_after_sort.AutoSize = True
        Me.lb_after_sort.Location = New System.Drawing.Point(428, 288)
        Me.lb_after_sort.Name = "lb_after_sort"
        Me.lb_after_sort.Size = New System.Drawing.Size(0, 25)
        Me.lb_after_sort.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(689, 628)
        Me.Controls.Add(Me.lb_after_sort)
        Me.Controls.Add(Me.lb_befor_sort)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_answer)
        Me.Controls.Add(Me.btn_multiply)
        Me.Controls.Add(Me.btn_substract)
        Me.Controls.Add(Me.btn_division)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.txt_second_number)
        Me.Controls.Add(Me.txt_first_number)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "First Application"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_first_number As TextBox
    Friend WithEvents txt_second_number As TextBox
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_division As Button
    Friend WithEvents btn_substract As Button
    Friend WithEvents btn_multiply As Button
    Friend WithEvents lbl_answer As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lb_befor_sort As Label
    Friend WithEvents lb_after_sort As Label
End Class
