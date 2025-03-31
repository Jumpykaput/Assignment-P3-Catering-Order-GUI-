Public Class frmCateringOrder
    ' Prices for each platter
    Private Const CHEESE_PRICE As Decimal = 49.99
    Private Const PINWHEEL_PRICE As Decimal = 59.99
    Private Const VEGGIE_PRICE As Decimal = 29.99
    Private Const SAUSAGE_CHEESE_PRICE As Decimal = 49.99
    Private Const FRUIT_PRICE As Decimal = 29.99
    Private Const PREPAY_DISCOUNT As Decimal = 0.1
    Private Const LOYALTY_DISCOUNT_RATE As Decimal = 0.5 ' 50 cents per loyalty point

    Private Sub frmCateringOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnClear.PerformClick() ' Reset form on load
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPoints.Clear()
        lblResult.Text = ""
        rdoCheese.Checked = True ' Default selection
        rdoPrePay.Checked = True ' Default payment method
        txtPoints.Focus()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim platterPrice As Decimal = 0
        Dim discount As Decimal = 0
        Dim loyaltyPoints As Integer = 0
        Dim finalPrice As Decimal
        Dim paymentMethod As String

        ' Determine selected platter price
        If rdoCheese.Checked Then
            platterPrice = CHEESE_PRICE
        ElseIf rdoPinwheel.Checked Then
            platterPrice = PINWHEEL_PRICE
        ElseIf rdoVeggie.Checked Then
            platterPrice = VEGGIE_PRICE
        ElseIf rdoSausageCheese.Checked Then
            platterPrice = SAUSAGE_CHEESE_PRICE
        ElseIf rdoFruit.Checked Then
            platterPrice = FRUIT_PRICE
        End If

        ' Validate loyalty points input
        If Not Integer.TryParse(txtPoints.Text, loyaltyPoints) OrElse loyaltyPoints < 0 Then
            MessageBox.Show("Invalid loyalty points entry. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPoints.Clear()
            txtPoints.Focus()
            Exit Sub
        End If

        ' Apply loyalty discount
        discount = loyaltyPoints * LOYALTY_DISCOUNT_RATE
        If discount >= platterPrice Then
            MessageBox.Show("Loyalty discount cannot exceed the order price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPoints.Clear()
            txtPoints.Focus()
            Exit Sub
        End If

        ' Apply payment method discount
        If rdoPrePay.Checked Then
            platterPrice *= (1 - PREPAY_DISCOUNT)
            paymentMethod = "Pre-Pay"
        ElseIf rdoPayUponPickup.Checked Then
            paymentMethod = "Pay upon Pickup"
        End If

        ' Final price after discounts
        finalPrice = platterPrice - discount
        lblResult.Text = $"Your order {GetSelectedPlatter()} costs ${finalPrice:F2} using {paymentMethod} after discount of {loyaltyPoints} loyalty points."
    End Sub

    Private Function GetSelectedPlatter() As String
        If rdoCheese.Checked Then Return "Gourmet Cheese Platter"
        If rdoPinwheel.Checked Then Return "Pinwheel Wraps Platter"
        If rdoVeggie.Checked Then Return "Veggie Platter"
        If rdoSausageCheese.Checked Then Return "Sausage and Cheese Platter"
        If rdoFruit.Checked Then Return "Fruit Platter"
        Return "Unknown Platter"
    End Function

    Private Sub grpPlatter_Enter(sender As Object, e As EventArgs) Handles grpPlatter.Enter

    End Sub

    Private Sub txtPoints_TextChanged(sender As Object, e As EventArgs) Handles txtPoints.TextChanged

    End Sub

    Private Sub lblResult_Click(sender As Object, e As EventArgs) Handles lblResult.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub lblTitle2_Click(sender As Object, e As EventArgs) Handles lblTitle2.Click

    End Sub

    Private Sub lblTitle1_Click(sender As Object, e As EventArgs) Handles lblTitle1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub grpPayment_Enter(sender As Object, e As EventArgs) Handles grpPayment.Enter

    End Sub
End Class
