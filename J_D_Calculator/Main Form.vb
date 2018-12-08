' Name:         Concert Project
' Purpose:      Displays the subtotal, discount, and total due for concert tickets.
' Programmer:   <your name> on <current date>

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private strConcatenatedNumber As String
    Private strCurrentNumber As String
    Private dblTotal As Double

    Private Function GetSum(ByVal dblNum As Double) As Double

        dblTotal = dblNum + dblTotal
        Return dblTotal
    End Function

    Private Function GetSubtraction(ByVal dblNum As Double) As Double

        If dblTotal = 0 Then
            dblNum = -(dblNum)
        End If

        dblTotal = dblTotal - dblNum
        Return dblTotal
    End Function

    Private Function GetMultiplication(ByVal dblNum As Double) As Double

        If dblTotal = 0 Then
            dblTotal = 1
        End If

        dblTotal = dblNum * dblTotal
        Return dblTotal
    End Function

    Private Function GetDivision(ByVal dblNum As Double) As Double

        dblTotal = dblTotal / dblNum
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

    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtOuput.Text = String.Empty
        strConcatenatedNumber = Nothing
        strCurrentNumber = Nothing
        dblTotal = Nothing
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles _
        btnEquals.Click, btnAddition.Click, btnSubtraction.Click, btnMultiplication.Click,
             btnDivision.Click

        Dim dblTotal As Double
        Dim dblNumber As Double
        Dim btnCurrent As Button = CType(sender, Button)

        Select Case btnCurrent.Name
            Case = "btnAddition"
                strCurrentNumber = txtOuput.Text
                strConcatenatedNumber = Nothing
                txtOuput.Text = String.Empty
                Double.TryParse(strCurrentNumber, dblNumber)
                dblTotal = GetSum(dblNumber)
            Case = "btnSubtraction"
                strCurrentNumber = txtOuput.Text
                strConcatenatedNumber = Nothing
                txtOuput.Text = String.Empty
                Double.TryParse(strCurrentNumber, dblNumber)
                dblTotal = GetSubtraction(dblNumber)
            Case = "btnMultiplication"
                strCurrentNumber = txtOuput.Text
                strConcatenatedNumber = Nothing
                txtOuput.Text = String.Empty
                Double.TryParse(strCurrentNumber, dblNumber)
                dblTotal = GetMultiplication(dblNumber)
            Case = "btnDivision"
                strCurrentNumber = txtOuput.Text
                strConcatenatedNumber = Nothing
                txtOuput.Text = String.Empty
                Double.TryParse(strCurrentNumber, dblNumber)
                dblTotal = GetDivision(dblNumber)
        End Select
        txtOuput.Text = dblTotal.ToString
    End Sub
End Class