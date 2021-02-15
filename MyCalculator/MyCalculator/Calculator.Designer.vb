<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calculator))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button0 = New System.Windows.Forms.Button()
        Me.CalcExpr = New System.Windows.Forms.Button()
        Me.Addition = New System.Windows.Forms.Button()
        Me.Subtract = New System.Windows.Forms.Button()
        Me.Multiply = New System.Windows.Forms.Button()
        Me.Divide = New System.Windows.Forms.Button()
        Me.Clear = New System.Windows.Forms.Button()
        Me.OutputBox = New System.Windows.Forms.TextBox()
        Me.DecimalPoint = New System.Windows.Forms.Button()
        Me.Exponent = New System.Windows.Forms.Button()
        Me.OpenParentheses = New System.Windows.Forms.Button()
        Me.CloseParentheses = New System.Windows.Forms.Button()
        Me.HelpInfo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        resources.ApplyResources(Me.Button3, "Button3")
        Me.Button3.Name = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        resources.ApplyResources(Me.Button4, "Button4")
        Me.Button4.Name = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        resources.ApplyResources(Me.Button5, "Button5")
        Me.Button5.Name = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        resources.ApplyResources(Me.Button6, "Button6")
        Me.Button6.Name = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        resources.ApplyResources(Me.Button7, "Button7")
        Me.Button7.Name = "Button7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        resources.ApplyResources(Me.Button8, "Button8")
        Me.Button8.Name = "Button8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        resources.ApplyResources(Me.Button9, "Button9")
        Me.Button9.Name = "Button9"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button0
        '
        resources.ApplyResources(Me.Button0, "Button0")
        Me.Button0.Name = "Button0"
        Me.Button0.UseVisualStyleBackColor = True
        '
        'CalcExpr
        '
        resources.ApplyResources(Me.CalcExpr, "CalcExpr")
        Me.CalcExpr.Name = "CalcExpr"
        Me.CalcExpr.UseVisualStyleBackColor = True
        '
        'Addition
        '
        resources.ApplyResources(Me.Addition, "Addition")
        Me.Addition.Name = "Addition"
        Me.Addition.UseVisualStyleBackColor = True
        '
        'Subtract
        '
        resources.ApplyResources(Me.Subtract, "Subtract")
        Me.Subtract.Name = "Subtract"
        Me.Subtract.UseVisualStyleBackColor = True
        '
        'Multiply
        '
        resources.ApplyResources(Me.Multiply, "Multiply")
        Me.Multiply.Name = "Multiply"
        Me.Multiply.UseVisualStyleBackColor = True
        '
        'Divide
        '
        resources.ApplyResources(Me.Divide, "Divide")
        Me.Divide.Name = "Divide"
        Me.Divide.UseVisualStyleBackColor = True
        '
        'Clear
        '
        resources.ApplyResources(Me.Clear, "Clear")
        Me.Clear.Name = "Clear"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'OutputBox
        '
        resources.ApplyResources(Me.OutputBox, "OutputBox")
        Me.OutputBox.Name = "OutputBox"
        '
        'DecimalPoint
        '
        resources.ApplyResources(Me.DecimalPoint, "DecimalPoint")
        Me.DecimalPoint.Name = "DecimalPoint"
        Me.DecimalPoint.UseVisualStyleBackColor = True
        '
        'Exponent
        '
        resources.ApplyResources(Me.Exponent, "Exponent")
        Me.Exponent.Name = "Exponent"
        Me.Exponent.UseVisualStyleBackColor = True
        '
        'OpenParentheses
        '
        resources.ApplyResources(Me.OpenParentheses, "OpenParentheses")
        Me.OpenParentheses.Name = "OpenParentheses"
        Me.OpenParentheses.UseVisualStyleBackColor = True
        '
        'CloseParentheses
        '
        resources.ApplyResources(Me.CloseParentheses, "CloseParentheses")
        Me.CloseParentheses.Name = "CloseParentheses"
        Me.CloseParentheses.UseVisualStyleBackColor = True
        '
        'HelpInfo
        '
        resources.ApplyResources(Me.HelpInfo, "HelpInfo")
        Me.HelpInfo.Name = "HelpInfo"
        Me.HelpInfo.UseVisualStyleBackColor = True
        '
        'Calculator
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.HelpInfo)
        Me.Controls.Add(Me.CloseParentheses)
        Me.Controls.Add(Me.OpenParentheses)
        Me.Controls.Add(Me.Exponent)
        Me.Controls.Add(Me.DecimalPoint)
        Me.Controls.Add(Me.OutputBox)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Divide)
        Me.Controls.Add(Me.Multiply)
        Me.Controls.Add(Me.Subtract)
        Me.Controls.Add(Me.Addition)
        Me.Controls.Add(Me.CalcExpr)
        Me.Controls.Add(Me.Button0)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button0 As Button
    Friend WithEvents CalcExpr As Button
    Friend WithEvents Addition As Button
    Friend WithEvents Subtract As Button
    Friend WithEvents Multiply As Button
    Friend WithEvents Divide As Button
    Friend WithEvents Clear As Button
    Friend WithEvents OutputBox As TextBox
    Friend WithEvents DecimalPoint As Button
    Friend WithEvents Exponent As Button
    Friend WithEvents OpenParentheses As Button
    Friend WithEvents CloseParentheses As Button
    Friend WithEvents HelpInfo As Button
End Class
