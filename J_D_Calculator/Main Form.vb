' Name:         Concert Project
' Purpose:      Displays the subtotal, discount, and total due for concert tickets.
' Programmer:   <your name> on <current date>

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private strCurrentNumber As String
    Private decTotalSum As Decimal

    Private Function GetSum(ByVal decNum As Decimal) As Decimal

        decTotalSum = decTotalSum + decNum
        Return decTotalSum
    End Function

    Private Sub btn_click(sender As Object, e As EventArgs) Handles _
            btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click,
            btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn0.Click

        Dim strNumber As String
        Dim btnCurrent As Button = CType(sender, Button)

        strNumber = btnCurrent.Tag.ToString
        strCurrentNumber = strCurrentNumber & strNumber
        txtOuput.Text = strCurrentNumber

    End Sub

    Private Sub btnMathProcedure(sender As Object, e As EventArgs) Handles _
            btnAddition.Click, btnSubtraction.Click, btnMultiplication.Click, btnDivision.Click, btnEquals.Click

        Dim decCurrentNumber As Decimal
        Dim decProcedure As Decimal
        Dim btnCurrent As Button = CType(sender, Button)

        Decimal.TryParse(strCurrentNumber, decCurrentNumber)

        If btnCurrent.Name = "btnAddition" Then
            decProcedure = GetSum(decCurrentNumber)
        End If
        txtOuput.Text = decProcedure.ToString
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtOuput.Text = String.Empty
        strCurrentNumber = Nothing
        decTotalSum = Nothing
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
