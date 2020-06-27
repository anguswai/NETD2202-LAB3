' Name: Angus Wai (100719558)
' Date: 2020-05-30
' Description: Windows application that calculates the average number of units shipped by three employees per week

Option Strict On

Public Class frmAverageUnitsShippedByEmployee
    ' Declare variables
    Dim unitsShipped(6) As Integer
    Dim day As Integer = 1
    Dim i As Integer
    Dim total As Integer
    Dim average As Double

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        ' This if statement makes sure no further data can be entered in case it gets past day 7
        If day <= 7 Then
            ' Check if user input is a whole number
            If yoIsThisAWholeNumber(txtInput.Text) Then
                ' Check if user input is between 0 and 5000
                If (CInt(txtInput.Text) >= 0) And (CInt(txtInput.Text) <= 5000) Then
                    ' Save the user input into unitsShipped
                    unitsShipped(day - 1) = Convert.ToInt32(txtInput.Text)

                    ' Display all entries in txtDisplay
                    ' Displaying in this way is not efficient, but I could not
                    '   find any way to display existing entries with a for loop
                    If day = 1 Then
                        txtDisplay.Text = Convert.ToString(unitsShipped(0))
                    ElseIf day = 2 Then
                        txtDisplay.Text = Convert.ToString(unitsShipped(0)) & vbNewLine & Convert.ToString(unitsShipped(1))
                    ElseIf day = 3 Then
                        txtDisplay.Text = Convert.ToString(unitsShipped(0)) & vbNewLine & Convert.ToString(unitsShipped(1)) & vbNewLine & Convert.ToString(unitsShipped(2))
                    ElseIf day = 4 Then
                        txtDisplay.Text = Convert.ToString(unitsShipped(0)) & vbNewLine & Convert.ToString(unitsShipped(1)) & vbNewLine & Convert.ToString(unitsShipped(2)) & vbNewLine & Convert.ToString(unitsShipped(3))
                    ElseIf day = 5 Then
                        txtDisplay.Text = Convert.ToString(unitsShipped(0)) & vbNewLine & Convert.ToString(unitsShipped(1)) & vbNewLine & Convert.ToString(unitsShipped(2)) & vbNewLine & Convert.ToString(unitsShipped(3)) & vbNewLine & Convert.ToString(unitsShipped(4))
                    ElseIf day = 6 Then
                        txtDisplay.Text = Convert.ToString(unitsShipped(0)) & vbNewLine & Convert.ToString(unitsShipped(1)) & vbNewLine & Convert.ToString(unitsShipped(2)) & vbNewLine & Convert.ToString(unitsShipped(3)) & vbNewLine & Convert.ToString(unitsShipped(4)) & vbNewLine & Convert.ToString(unitsShipped(5))
                    Else ' Calculation starts after the user entered units shipped for day 7
                        txtDisplay.Text = Convert.ToString(unitsShipped(0)) & vbNewLine & Convert.ToString(unitsShipped(1)) & vbNewLine & Convert.ToString(unitsShipped(2)) & vbNewLine & Convert.ToString(unitsShipped(3)) & vbNewLine & Convert.ToString(unitsShipped(4)) & vbNewLine & Convert.ToString(unitsShipped(5)) & vbNewLine & Convert.ToString(unitsShipped(6))
                        ' Disable user's ability to enter data
                        txtInput.ReadOnly = True
                        btnEnter.Enabled = False
                        txtInput.TabStop = False
                        btnEnter.TabStop = False

                        ' Calculate and output average units shipped
                        For i = 0 To day - 1
                            total = total + unitsShipped(i)
                        Next
                        average = Math.Round((total / day), 2)
                        lblOutput.Text = "Average per day: " + Convert.ToString(average)

                        ' This makes it stay at day 7 after the user has input a value
                        '   due to how I coded this Windows application (see line 57)
                        day = day - 1
                    End If
                    ' Change day and clear txtInput after user presses enter
                    day = day + 1
                    lblDay.Text = "Day " + Convert.ToString(day)
                    txtInput.Text = ""
                Else
                    ' Error message
                    MsgBox("ERROR: Units shipped must be between 0 and 5000")
                    txtInput.Focus()
                End If
            Else
                ' Error message
                MsgBox("ERROR: Units shipped must be a whole number")
                txtInput.Focus()
            End If
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' Reset variables
        total = 0
        average = 0
        day = 1
        ' Reset Day
        lblDay.Text = "Day " + Convert.ToString(day)
        txtDisplay.Text = ""
        ' Enable user's ability to enter data
        txtInput.ReadOnly = False
        btnEnter.Enabled = True
        txtInput.TabStop = True
        btnEnter.TabStop = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    ' This function returns true if testSubject is an integer, and returns false otherwise
    ' This function is inspired by a YouTube video I found: https://www.youtube.com/watch?v=6Ps0sFenUA8
    Function yoIsThisAWholeNumber(ByVal testSubject As String) As Boolean
        Try
            Convert.ToInt32(testSubject)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class