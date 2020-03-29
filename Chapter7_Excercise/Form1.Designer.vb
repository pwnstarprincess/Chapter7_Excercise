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
        Me.TranslateButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EnglishBox = New System.Windows.Forms.TextBox()
        Me.TexteseBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TranslateButton
        '
        Me.TranslateButton.Location = New System.Drawing.Point(230, 75)
        Me.TranslateButton.Name = "TranslateButton"
        Me.TranslateButton.Size = New System.Drawing.Size(241, 64)
        Me.TranslateButton.TabIndex = 0
        Me.TranslateButton.Text = "Translate Sentence"
        Me.TranslateButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "English Sentence:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Textese Sentence:"
        '
        'EnglishBox
        '
        Me.EnglishBox.Location = New System.Drawing.Point(196, 25)
        Me.EnglishBox.Name = "EnglishBox"
        Me.EnglishBox.Size = New System.Drawing.Size(275, 26)
        Me.EnglishBox.TabIndex = 3
        '
        'TexteseBox
        '
        Me.TexteseBox.Location = New System.Drawing.Point(196, 169)
        Me.TexteseBox.Name = "TexteseBox"
        Me.TexteseBox.ReadOnly = True
        Me.TexteseBox.Size = New System.Drawing.Size(275, 26)
        Me.TexteseBox.TabIndex = 0
        Me.TexteseBox.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 214)
        Me.Controls.Add(Me.TexteseBox)
        Me.Controls.Add(Me.EnglishBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TranslateButton)
        Me.Name = "Form1"
        Me.Text = "Textese Translator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TranslateButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents EnglishBox As TextBox
    Friend WithEvents TexteseBox As TextBox
End Class
