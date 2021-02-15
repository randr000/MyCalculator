Option Explicit On

Imports NCalc

Public Class Calculator

    Private isAddition As Boolean = False
    Private isSubtraction As Boolean = False
    Private isMultiplication As Boolean = False
    Private isDivision As Boolean = False
    Private isNewCalc As Boolean = True
    Private mathExp As String
    Private acceptableChars As String() = {"(", ")", "+", "-", "/", "*", ".", "0", "1",
                                            "2", "3", "4", "5", "6", "7", "8", "9", ControlChars.Back}

    Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.Show()
        Me.OutputBox.Focus()

    End Sub


    Private Sub SetOutputText(ByVal newTxt As String)
        If isNewCalc Then
            OutputBox.Text = newTxt
            isNewCalc = False
        Else
            OutputBox.Text += newTxt
        End If

        OutputBox.Focus()

    End Sub

    Private Sub OutputBox_GotFocus(sender As Object, e As EventArgs) Handles OutputBox.GotFocus

        OutputBox.SelectionStart = OutputBox.Text.Length + 1

    End Sub

    Private Sub OutputBox_KeyDown(sender As Object, e As KeyEventArgs) Handles OutputBox.KeyDown
        ' Mimics the acion when a user clicks on the equals sign when they hit Enter

        If e.KeyCode = Keys.Enter Then

            CalcExpr.PerformClick()

        End If

    End Sub

    Private Sub OutputBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles OutputBox.KeyPress

        If acceptableChars.Contains(e.KeyChar) = False Then

            e.Handled = True

        ElseIf isNewCalc Then

            OutputBox.Text = ""
            isNewCalc = False

        End If

    End Sub

    Private Sub OutputBox_KeyUp(sender As Object, e As KeyEventArgs) Handles OutputBox.KeyUp
        ' This takes away the default 0 immediately when a user manually enters an acceptable character
        ' When this was added to the OutputBox_KeyPress event, the 0 only dissappeared after the 2nd character was entered

        If OutputBox.Text.Length() = 2 And isNewCalc Then

            OutputBox.Text = Strings.Right(OutputBox.Text, 1)
            isNewCalc = False
            OutputBox.SelectionStart = OutputBox.Text.Length + 1

        End If

    End Sub

    Private Function AddSpaces(ByVal str As String) As String
        ' Add a leading and trailing space to the +, -, /, & * symbols
        Return " " + str + " "

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        SetOutputText(sender.Text)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        SetOutputText(sender.Text)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        SetOutputText(sender.Text)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        SetOutputText(sender.Text)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        SetOutputText(sender.Text)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        SetOutputText(sender.Text)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        SetOutputText(sender.Text)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        SetOutputText(sender.Text)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        SetOutputText(sender.Text)

    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click

        SetOutputText(sender.Text)

    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click

        OutputBox.Text = "0"
        mathExp = ""
        isNewCalc = True
        OutputBox.Focus()

    End Sub

    Private Sub DecimalPoint_Click(sender As Object, e As EventArgs) Handles DecimalPoint.Click

        SetOutputText(sender.Text)

    End Sub

    Private Sub OpenParentheses_Click(sender As Object, e As EventArgs) Handles OpenParentheses.Click

        SetOutputText(sender.Text)

    End Sub

    Private Sub CloseParentheses_Click(sender As Object, e As EventArgs) Handles CloseParentheses.Click

        SetOutputText(sender.Text)

    End Sub

    Private Sub Addition_Click(sender As Object, e As EventArgs) Handles Addition.Click

        SetOutputText(AddSpaces(sender.Text))

    End Sub

    Private Sub Subtract_Click(sender As Object, e As EventArgs) Handles Subtract.Click

        SetOutputText(AddSpaces(sender.Text))

    End Sub

    Private Sub Multiply_Click(sender As Object, e As EventArgs) Handles Multiply.Click

        SetOutputText(AddSpaces(sender.Text))

    End Sub

    Private Sub Divide_Click(sender As Object, e As EventArgs) Handles Divide.Click

        SetOutputText(AddSpaces(sender.Text))

    End Sub

    Private Sub Exponent_Click(sender As Object, e As EventArgs) Handles Exponent.Click

        SetOutputText(sender.Text)

    End Sub

    Private Sub CalcExpr_Click(sender As Object, e As EventArgs) Handles CalcExpr.Click

        If isNewCalc Then

            OutputBox.Text = "0"

        Else

            Dim expr As New Expression(OutputBox.Text)
            Dim exprResult As Decimal

            Try

                exprResult = expr.Evaluate()
                SetOutputText(AddSpaces(sender.Text) & exprResult.ToString("###,##0.####################"))
                isNewCalc = True

            Catch ex As Exception

                Call Error_Messages(1, ex.Message)

            End Try

        End If

        OutputBox.Focus()
        OutputBox.SelectionStart = OutputBox.Text.Length + 1

    End Sub

    Private Sub HelpInfo_Click(sender As Object, e As EventArgs) Handles HelpInfo.Click

        Call Help_Messages(1)
        OutputBox.Focus()

    End Sub

    Sub Error_Messages(ByVal msgNum As Integer, ByVal str As String)

        Select Case msgNum
            Case 1
                MsgBox("Error in function. Please go back and revise." & vbCrLf &
                       "Exception Message: " & str)
        End Select

    End Sub

    Sub Help_Messages(ByVal msgNum As Integer)

        Select Case msgNum
            Case 1
                MsgBox("For multiplication, you must include a ""*"". 2(2) will produce an error instead of 4." & vbCrLf & vbCrLf &
                       "For exponents, use the ""Pow( , )"" button. Using ""**"" or ""^"" will not work." & vbCrLf &
                       "Use the following format: Pow(base, exponent). Mannually typing in ""Pow( , )"" will not work.")
        End Select

    End Sub


End Class
