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
        Me.components = New System.ComponentModel.Container()
        Me.txtData = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'txtData
        '
        Me.txtData.Location = New System.Drawing.Point(218, 46)
        Me.txtData.Multiline = True
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(252, 117)
        Me.txtData.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(218, 169)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(252, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "START"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtData)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtData As Windows.Forms.TextBox
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Windows.Forms.Timer
End Class
