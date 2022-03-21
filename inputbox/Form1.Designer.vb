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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.labelname = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(587, 264)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "CLICK HERE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(287, 197)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(400, 20)
        Me.txtName.TabIndex = 1
        '
        'labelname
        '
        Me.labelname.AutoSize = True
        Me.labelname.Location = New System.Drawing.Point(149, 204)
        Me.labelname.Name = "labelname"
        Me.labelname.Size = New System.Drawing.Size(115, 13)
        Me.labelname.TabIndex = 2
        Me.labelname.Text = "ENTER YOUR NAME:"
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(177, 264)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(53, 13)
        Me.lblOutput.TabIndex = 3
        Me.lblOutput.Text = "RESULT:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 450)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.labelname)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents labelname As Label
    Friend WithEvents lblOutput As Label
End Class
