'Program name: Burger Specials.
'Developer: Julie Rapson
'Date: Edited on 2/9/2023 --- added button functionality and pictures
'Purpose: Application to give a user two choices of burgers. They can choose one and exit out of the program
'test git push comment'
Public Class frmBurgers
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblConfirmation_Click(sender As Object, e As EventArgs) Handles lblConfirmation.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblHeading.Click

    End Sub

    Private Sub btnPrime_Click(sender As Object, e As EventArgs) Handles btnPrime.Click
        'This code is executed when the user clicks the Prime beef button. It displays the
        ' prime picture, hides the veggie picture and enables the select meal button.
        picPrime.Visible = True 'show the prime picture
        picVeggie.Visible = False 'do not show the veggie picture
        btnSelectMeal.Enabled = True 'enable the select meal button
        lblConfirmation.Visible = False 'Don't show the enjoy meal text
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'When the user clicks this exit button, the program will end
        Close()
    End Sub

    Private Sub btnVeggie_Click(sender As Object, e As EventArgs) Handles btnVeggie.Click
        picVeggie.Visible = True 'Show the veggie picture
        picPrime.Visible = False 'Hide the prime beef picture
        btnSelectMeal.Enabled = True 'Enable the select meal button
        lblConfirmation.Visible = False 'Don't show the enjoy meal text
    End Sub

    Private Sub btnSelectMeal_Click(sender As Object, e As EventArgs) Handles btnSelectMeal.Click
        lblConfirmation.Visible = True 'Show this message only when the person selects a meal
        lblInstructions.Visible = False 'Hide this message now that it is no longer relevant
        btnExit.Enabled = True 'Enable the exit button when meal is selected
        btnSelectMeal.Enabled = False 'Disabled because selection was made - stuck with the one you got!
        btnPrime.Enabled = False 'Disabled because selection was made
        btnVeggie.Enabled = False 'Disabled because selection was made
    End Sub

    Private Sub picPrime_Click(sender As Object, e As EventArgs) Handles picPrime.Click

    End Sub
End Class
