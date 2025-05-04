Imports Microsoft.VisualBasic.Financial
Imports Windows.Win32.UI.Input
Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Ensure that a valid car is selected
        If cmbCars.SelectedItem Is Nothing OrElse cmbCars.Text = "Please Select" Then
            MessageBox.Show("Please select a valid car model before calculating.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Clear existing rows and columns
        dgvPayments.Rows.Clear()
        dgvPayments.Columns.Clear()

        ' Add table columns
        dgvPayments.Columns.Add("InterestRate", "Interest Rate (%)")
        dgvPayments.Columns.Add("3Years", "3 Years (Monthly Payment)")
        dgvPayments.Columns.Add("4Years", "4 Years (Monthly Payment)")
        dgvPayments.Columns.Add("5Years", "5 Years (Monthly Payment)")

        ' Define car price based on selected car
        Dim carPrice As Double
        Select Case cmbCars.SelectedItem?.ToString() ' Use safe navigation to avoid NullReferenceException
            Case "Toyota Vios"
                carPrice = 1000000
            Case "Honda Civic"
                carPrice = 1100000
            Case "Hyundai Accent"
                carPrice = 1200000
            Case "Mitsubishi Mirage"
                carPrice = 1300000
            Case Else
                MessageBox.Show("Please select a car model.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
        End Select

        ' Loop through interest rates (5% to 10%) and calculate payments
        For rate As Double = 5 To 10 Step 1
            Dim monthlyInterestRate As Double = (rate / 100) / 12 ' Convert annual interest rate to monthly
            Dim payment3Years As Double = -Pmt(monthlyInterestRate, 3 * 12, carPrice)
            Dim payment4Years As Double = -Pmt(monthlyInterestRate, 4 * 12, carPrice)
            Dim payment5Years As Double = -Pmt(monthlyInterestRate, 5 * 12, carPrice)

            ' Add calculated results to DataGridView
            dgvPayments.Rows.Add(rate.ToString("N0") & "%", payment3Years.ToString("C2"), payment4Years.ToString("C2"), payment5Years.ToString("C2"))
        Next

        lblDisplayCar.Text = "Car Selected: " & cmbCars.SelectedItem.ToString() & vbCrLf &
                             "SRP: " & carPrice.ToString("C2")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear all fields
        cmbCars.Text = ""
        lblDisplayCar.Text = ""
        dgvPayments.Rows.Clear()
        dgvPayments.Columns.Clear()
        pbxCars.Image = Nothing ' Clear the PictureBox image
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub cmbCars_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCars.SelectedIndexChanged

        Select Case cmbCars.SelectedItem?.ToString()
            Case "Toyota Vios"
                pbxCars.Image = New Bitmap(Image.FromFile("C:\Users\krizi\OneDrive\Desktop\CS\Second Year - 2nd Semester\COMPROG 3 Lab (Computer Programming 3 Lab)\COMPROG 3 - FT ACTIVITY - FINANCING CARS DESIGN\Toyota Vios.jpg"), New Size(235, 137))
            Case "Honda Civic"
                pbxCars.Image = New Bitmap(Image.FromFile("C:\Users\krizi\OneDrive\Desktop\CS\Second Year - 2nd Semester\COMPROG 3 Lab (Computer Programming 3 Lab)\COMPROG 3 - FT ACTIVITY - FINANCING CARS DESIGN\Honda Civic.jpg"), New Size(235, 137))
            Case "Hyundai Accent"
                pbxCars.Image = New Bitmap(Image.FromFile("C:\Users\krizi\OneDrive\Desktop\CS\Second Year - 2nd Semester\COMPROG 3 Lab (Computer Programming 3 Lab)\COMPROG 3 - FT ACTIVITY - FINANCING CARS DESIGN\Hyundai Accent.jpg"), New Size(235, 137))
            Case "Mitsubishi Mirage"
                pbxCars.Image = New Bitmap(Image.FromFile("C:\Users\krizi\OneDrive\Desktop\CS\Second Year - 2nd Semester\COMPROG 3 Lab (Computer Programming 3 Lab)\COMPROG 3 - FT ACTIVITY - FINANCING CARS DESIGN\Mitsubishi Mirage.jpg"), New Size(235, 137))
            Case Else
                pbxCars.Image = Nothing ' Clears PictureBox if no valid selection is made
        End Select

    End Sub
End Class
