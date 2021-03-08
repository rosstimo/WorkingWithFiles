<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WorkingWithFilesForm
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
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.DisplayListBox = New System.Windows.Forms.ListBox()
        Me.OutputGroupBox = New System.Windows.Forms.GroupBox()
        Me.InputGroupBox = New System.Windows.Forms.GroupBox()
        Me.GoButton = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.OutputGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'DisplayListBox
        '
        Me.DisplayListBox.FormattingEnabled = True
        Me.DisplayListBox.ItemHeight = 20
        Me.DisplayListBox.Location = New System.Drawing.Point(6, 25)
        Me.DisplayListBox.Name = "DisplayListBox"
        Me.DisplayListBox.Size = New System.Drawing.Size(384, 264)
        Me.DisplayListBox.TabIndex = 0
        '
        'OutputGroupBox
        '
        Me.OutputGroupBox.Controls.Add(Me.DisplayListBox)
        Me.OutputGroupBox.Location = New System.Drawing.Point(353, 44)
        Me.OutputGroupBox.Name = "OutputGroupBox"
        Me.OutputGroupBox.Size = New System.Drawing.Size(396, 294)
        Me.OutputGroupBox.TabIndex = 1
        Me.OutputGroupBox.TabStop = False
        Me.OutputGroupBox.Text = "Names"
        '
        'InputGroupBox
        '
        Me.InputGroupBox.Location = New System.Drawing.Point(19, 44)
        Me.InputGroupBox.Name = "InputGroupBox"
        Me.InputGroupBox.Size = New System.Drawing.Size(328, 294)
        Me.InputGroupBox.TabIndex = 2
        Me.InputGroupBox.TabStop = False
        Me.InputGroupBox.Text = "User Info"
        '
        'GoButton
        '
        Me.GoButton.Location = New System.Drawing.Point(218, 344)
        Me.GoButton.Name = "GoButton"
        Me.GoButton.Size = New System.Drawing.Size(173, 94)
        Me.GoButton.TabIndex = 3
        Me.GoButton.Text = "&Go"
        Me.GoButton.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(397, 344)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(173, 94)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(576, 344)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(173, 94)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'WorkingWithFilesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GoButton)
        Me.Controls.Add(Me.InputGroupBox)
        Me.Controls.Add(Me.OutputGroupBox)
        Me.Name = "WorkingWithFilesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Files are great!"
        Me.OutputGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents DisplayListBox As ListBox
    Friend WithEvents OutputGroupBox As GroupBox
    Friend WithEvents InputGroupBox As GroupBox
    Friend WithEvents GoButton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
