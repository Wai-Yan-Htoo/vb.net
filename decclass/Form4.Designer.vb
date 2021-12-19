<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.btn_edge = New System.Windows.Forms.Button()
        Me.btn_chrome = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_edge
        '
        Me.btn_edge.Location = New System.Drawing.Point(79, 101)
        Me.btn_edge.Name = "btn_edge"
        Me.btn_edge.Size = New System.Drawing.Size(125, 76)
        Me.btn_edge.TabIndex = 0
        Me.btn_edge.Text = "Edge"
        Me.btn_edge.UseVisualStyleBackColor = True
        '
        'btn_chrome
        '
        Me.btn_chrome.Location = New System.Drawing.Point(475, 101)
        Me.btn_chrome.Name = "btn_chrome"
        Me.btn_chrome.Size = New System.Drawing.Size(125, 76)
        Me.btn_chrome.TabIndex = 1
        Me.btn_chrome.Text = "Chrome"
        Me.btn_chrome.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_chrome)
        Me.Controls.Add(Me.btn_edge)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_edge As Button
    Friend WithEvents btn_chrome As Button
End Class
