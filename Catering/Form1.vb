Public Class Form1
    Private Sub ResetForm()
        rbCheese.Checked = True
        rbPrePay.Checked = True
        txtLoyaltyPoints.Text = ""
        lblResults.Text = ""
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblResults.AutoSize = False

        ResetForm()
    End Sub

    Private Sub lblHeader_Click(sender As Object, e As EventArgs) Handles lblHeader.Click

    End Sub

    Private Sub rbCheese_CheckedChanged(sender As Object, e As EventArgs) Handles rbCheese.CheckedChanged

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim price As Double = 0
        Dim food As String = ""
        Dim payment As String = ""

        If rbCheese.Checked Then
            price = 49.99
            food = "Gourmet Cheese Platter"
        ElseIf rbPinwheel.Checked Then
            price = 59.99
            food = "Pinwheel Wraps Platter"
        ElseIf rbVeggie.Checked Then
            price = 29.99
            food = "Veggie Platter"
        ElseIf rbSausage.Checked Then
            price = 49.99
            food = "Sausage and Cheese Platter"
        ElseIf rbFruit.Checked Then
            price = 29.99
            food = "Fruit Platter"
        End If

        If rbPrePay.Checked Then
            payment = "Pre-Pay"
        ElseIf rbPickupPay.Checked Then
            payment = "Pay Upon Pickup"
        End If

        Dim loyaltyPoints As Integer
        If Integer.TryParse(txtLoyaltyPoints.Text, loyaltyPoints) AndAlso loyaltyPoints >= 0 Then
            Dim discount As Double = Math.Min((loyaltyPoints \ 10) * 0.05, 1)
            Dim discountedPrice As Double = price * (1 - discount)

            lblResults.Text = String.Format("Your order {0} costs ${1:0.00} using {2} after discount of {3} loyalty points.", food, discountedPrice, payment, loyaltyPoints)
        Else
            MessageBox.Show("Invalid loyalty points entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtLoyaltyPoints.Text = ""
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ResetForm()
    End Sub

    Private Sub rbVeggie_CheckedChanged(sender As Object, e As EventArgs) Handles rbVeggie.CheckedChanged

    End Sub

    Private Sub rbSausage_CheckedChanged(sender As Object, e As EventArgs) Handles rbSausage.CheckedChanged

    End Sub

    Private Sub lblResults_Click(sender As Object, e As EventArgs) Handles lblResults.Click

    End Sub
End Class
