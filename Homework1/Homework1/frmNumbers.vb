'Author: Julie Rapson
'Date: 02/09/2023
'Program name: Homework1 - French Numbers
'Notes: First version of a small application that shows you the French word for the number you click on 
'the form. The exit button will close the program.
Public Class frmNumbers
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblInstructions.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'This is used to exit the application
        Close()
    End Sub

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        'Set this to on click make the lable visible and show a specific text.
        lblFrench.Visible = True
        lblFrench.Text = "un"
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        'Set this to on click make the lable visible and show a specific text.
        lblFrench.Visible = True
        lblFrench.Text = "deux"
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        'Set this to on click make the lable visible and show a specific text.
        lblFrench.Visible = True
        lblFrench.Text = "trois"
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        'Set this to on click make the lable visible and show a specific text.
        lblFrench.Visible = True
        lblFrench.Text = "quatre"
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        'Set this to on click make the lable visible and show a specific text.
        lblFrench.Visible = True
        lblFrench.Text = "cinq"
    End Sub
End Class
