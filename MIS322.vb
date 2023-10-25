Imports System
Imports Microsoft.VisualBasic

Public Class MIS322

    'Tim Hutkowski
    'MIS 322
    '
    '

    Option Explicit On
    Option Strict On

    Private Sub 
    'Check if textbox is blank and display errpr message
        If customerNameTextBox.Text = “” Then
            MessageBox.Show(“Customer name is blank.”)
            Exit Sub
        End If


        'Check if values enetered are numeric and acceptable for our needs
        Try
            quantity = Convert.ToInt32(quantityTextBox.Text)
            price = Convert.ToDouble(priceTextBox.Text)

        Catch fe As FormatException
            message = "Numbers are not valid.Quanity must be whole number. Price accepts floats "
            MessageBox.Show(message, "Invalid Numbers")
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
            Exit Sub
        End Try
    End Sub


    'Rnadom number for a range
    Dim rnd As New Random
    lower = Convert.ToInt32(lowerTextBox.Text)
    upper = Convert.ToInt32(upperTextBox.Text) + 1
    result = rnd.Next(lower, upper)
End Class
