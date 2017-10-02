' Project Name: Tea Time Company
' Purpose : To calculate if shipping is charged on an order or not
'Programmer: Andrew Kuykendall on 10/01/2017 - Row 2

Option Explicit On
Option Infer Off
Option Strict On

Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' declare variables and constants
        Const decShipping As Decimal = 15
        Dim decPounds As Decimal
        Dim decPrice As Decimal
        Dim decTotalCost As Decimal
        Dim dlgButton As DialogResult
        Decimal.TryParse(txtPounds.Text, decPounds)
        Decimal.TryParse(txtPrice.Text, decPrice)

        ' calculate Cost of Tea
        decTotalCost = decPrice * decPounds

        ' Determine if charging shipping 
        dlgButton = MessageBox.Show("Should the customer be charged a $15 shipping fee?", "Shipping Charge", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If dlgButton = DialogResult.Yes Then

            decTotalCost = decShipping + decTotalCost

        Else
            decTotalCost = decTotalCost

        End If
        ' Display formatting
        lblTotalCost.Text = decTotalCost.ToString("C2")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim dlgExit As DialogResult
        dlgExit = MessageBox.Show("Would you like to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If dlgExit = DialogResult.Yes Then
            Me.Close()

        End If

    End Sub

    Private Sub txtPounds_Enter(sender As Object, e As EventArgs) Handles txtPounds.Enter
        txtPounds.SelectAll()

    End Sub

    Private Sub txtPounds_TextChanged(sender As Object, e As EventArgs) Handles txtPounds.TextChanged, txtPrice.TextChanged
        ' clear total amount
        lblTotalCost.Text = String.Empty

    End Sub

    Private Sub txtPrice_Enter(sender As Object, e As EventArgs) Handles txtPrice.Enter
        txtPrice.SelectAll()
    End Sub
End Class
