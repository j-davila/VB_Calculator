' Name:         Calculator
' Purpose:      Lets users perform calculations with numbers for basic operations.
' Programmer:   José L Dávila

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private strConcatenatedNumber As String
    Private strCurrentNumber As String
    Private strCurrentNumber2 As String
    Private dblTotal As Double
    Private intButtonPress As Integer = 0

    Private Function GetSum(ByVal dblNum As Double, ByVal dblNum2 As Double) As Double
        If dblTotal = 0 Then
            dblTotal = dblNum + dblNum2
        Else
            dblTotal = dblNum + dblTotal
        End If
        Return dblTotal
    End Function

    Private Function GetSubtraction(ByVal dblNum As Double, ByVal dblNum2 As Double) As Double

        If dblTotal = 0 Then
            dblTotal = dblNum2 - dblNum
        Else
            dblTotal = dblTotal - dblNum
        End If
        Return dblTotal
    End Function

    Private Function GetMultiplication(ByVal dblNum As Double, ByVal dblNum2 As Double) As Double

        dblTotal = dblNum * dblNum2
        Return dblTotal
    End Function

    Private Function GetDivision(ByVal dblNum As Double, ByVal dblNum2 As Double) As Double

        dblTotal = dblNum2 / dblNum
        Return dblTotal
    End Function
    Private Sub btn_click(sender As Object, e As EventArgs) Handles _
            btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click,
            btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn0.Click

        Dim strNumber As String
        Dim btnCurrent As Button = CType(sender, Button)

        strNumber = btnCurrent.Tag.ToString
        strConcatenatedNumber = strConcatenatedNumber & strNumber
        txtOuput.Text = strConcatenatedNumber
        strCurrentNumber = txtOuput.Text
    End Sub

    Private Sub btnOperators_Click(sender As Object, e As EventArgs) Handles _
             btnAddition.Click, btnSubtraction.Click, btnMultiplication.Click,
             btnDivision.Click

        Dim btnCurrent As Button = CType(sender, Button)

        Select Case btnCurrent.Name
            Case = "btnAddition"
                intButtonPress = 1
                strCurrentNumber = strCurrentNumber2
                strCurrentNumber2 = txtOuput.Text
                strConcatenatedNumber = Nothing
            Case = "btnSubtraction"
                intButtonPress = 2
                strCurrentNumber = strCurrentNumber2
                strCurrentNumber2 = txtOuput.Text
                strConcatenatedNumber = Nothing
            Case = "btnMultiplication"
                intButtonPress = 3
                strCurrentNumber = strCurrentNumber2
                strCurrentNumber2 = txtOuput.Text
                strConcatenatedNumber = Nothing
            Case = "btnDivision"
                intButtonPress = 4
                strCurrentNumber = strCurrentNumber2
                strCurrentNumber2 = txtOuput.Text
                strConcatenatedNumber = Nothing
        End Select
    End Sub

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        Dim dblNumber As Double
        Dim dblNumber2 As Double

        Select Case intButtonPress
            Case = 1
                Double.TryParse(strCurrentNumber, dblNumber)
                Double.TryParse(strCurrentNumber2, dblNumber2)
                dblTotal = GetSum(dblNumber, dblNumber2)
            Case = 2
                Double.TryParse(strCurrentNumber, dblNumber)
                Double.TryParse(strCurrentNumber2, dblNumber2)
                dblTotal = GetSubtraction(dblNumber, dblNumber2)
            Case = 3
                Double.TryParse(strCurrentNumber, dblNumber)
                Double.TryParse(strCurrentNumber2, dblNumber2)
                dblTotal = GetMultiplication(dblNumber, dblNumber2)
            Case = 4
                Double.TryParse(strCurrentNumber, dblNumber)
                Double.TryParse(strCurrentNumber2, dblNumber2)
                dblTotal = GetDivision(dblNumber, dblNumber2)
        End Select
        txtOuput.Text = dblTotal.ToString
        strCurrentNumber = Nothing
        strCurrentNumber2 = Nothing
        strConcatenatedNumber = Nothing
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtOuput.Text = String.Empty
        strConcatenatedNumber = Nothing
        strCurrentNumber = Nothing
        strCurrentNumber2 = Nothing
        dblTotal = Nothing
    End Sub
End Class