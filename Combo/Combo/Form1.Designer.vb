﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MathType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Number2 = New System.Windows.Forms.TextBox()
        Me.Number1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MathBtn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OutputLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'MathType
        '
        Me.MathType.FormattingEnabled = True
        Me.MathType.Items.AddRange(New Object() {"+", "-", "*", "÷"})
        Me.MathType.Location = New System.Drawing.Point(118, 50)
        Me.MathType.Name = "MathType"
        Me.MathType.Size = New System.Drawing.Size(36, 21)
        Me.MathType.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(95, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Choose a symbol"
        '
        'Number2
        '
        Me.Number2.Location = New System.Drawing.Point(160, 50)
        Me.Number2.Name = "Number2"
        Me.Number2.Size = New System.Drawing.Size(100, 20)
        Me.Number2.TabIndex = 2
        '
        'Number1
        '
        Me.Number1.Location = New System.Drawing.Point(12, 51)
        Me.Number1.Name = "Number1"
        Me.Number1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.Number1.Size = New System.Drawing.Size(100, 20)
        Me.Number1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(188, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Number 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Number 1"
        '
        'MathBtn
        '
        Me.MathBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MathBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MathBtn.Location = New System.Drawing.Point(266, 50)
        Me.MathBtn.Name = "MathBtn"
        Me.MathBtn.Size = New System.Drawing.Size(80, 20)
        Me.MathBtn.TabIndex = 6
        Me.MathBtn.Text = "="
        Me.MathBtn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(263, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Click to do math"
        '
        'OutputLabel
        '
        Me.OutputLabel.AutoSize = True
        Me.OutputLabel.Location = New System.Drawing.Point(352, 53)
        Me.OutputLabel.Name = "OutputLabel"
        Me.OutputLabel.Size = New System.Drawing.Size(29, 13)
        Me.OutputLabel.TabIndex = 8
        Me.OutputLabel.Text = "NaN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(49, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(279, 26)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Calculator. It's super simple"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 81)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.OutputLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.MathBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Number1)
        Me.Controls.Add(Me.Number2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MathType)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.Text = "Calculator, but simple"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MathType As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Number2 As TextBox
    Friend WithEvents Number1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MathBtn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents OutputLabel As Label
    Friend WithEvents Label5 As Label
End Class
