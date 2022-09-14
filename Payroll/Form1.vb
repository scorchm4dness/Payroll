Public Class frmPayroll
    Dim tax, phil, salary, sss, OTrate, total, totalDeduc, RatePerDay As Integer

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        sss = Val(txtWGP.Text) * 0.05
        txtSSS.Text = sss
        phil = Val(txtWGP.Text) * 0.03
        txtPhil.Text = phil
        tax = Val(txtWGP.Text) * 0.1
        txtTax.Text = tax

        totalDeduc = sss + phil + tax
        txtTotalDeduction.Text = totalDeduc

        total = Val(txtWGP.Text) - Val(totalDeduc) + Val(txtTotalOTPay.Text)
        txtTakeHomePay.Text = txtTakeHomePay.Text & " " & total

        salary = txtTakeHomePay.Text - txtTotalDeduction.Text
        txtNet.Text = salary
        

    End Sub

    Private Sub txtWGP_TextChanged(sender As Object, e As EventArgs) Handles txtWGP.TextChanged
        sss = Val(txtWGP.Text) * 0.05
        txtSSS.Text = sss
        phil = Val(txtWGP.Text) * 0.03
        txtPhil.Text = phil
        tax = Val(txtWGP.Text) * 0.1
        txtTax.Text = tax
    End Sub

    Private Sub txtOT_TextChanged(sender As Object, e As EventArgs) Handles txtOT.TextChanged
        OTrate = Val(txtOT.Text) * 250
        RatePerDay = OTrate + Val(txtRPD.Text)
        txtTotalOTPay.Text = OTrate
    End Sub

    Private Sub txtRPD_TextChanged(sender As Object, e As EventArgs) Handles txtRPD.TextChanged
        RatePerDay = Val(txtRPD.Text) * 5
        txtWGP.Text = RatePerDay
    End Sub
End Class
