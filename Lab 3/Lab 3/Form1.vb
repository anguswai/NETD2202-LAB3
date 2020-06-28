' Name: Angus Wai (100719558)
' Date: 2020-05-30
' Description: Windows application that calculates the average number of units shipped by three employees per week

' Part of the code is the same as Lab 1
Option Strict On

Public Class frmAverageUnitsShippedByEmployee
    ' Declare variables
    Dim unitsShipped(2, 6) As Integer
    Dim day As Integer = 1
    Dim total As Integer
    Dim average As Double
    Dim employee As Integer = 0

    Dim textboxList As TextBox()
    Dim labelList As Label()

    Private Sub frmAverageUnitsShippedByEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        textboxList = {txtDisplay1, txtDisplay2, txtDisplay3}
        labelList = {lblOutput1, lblOutput2, lblOutput3}
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        textboxList(employee).Text = String.Empty
        ' This if statement makes sure no further data can be entered in case it gets past day 7
        If day <= 7 Then
            ' Check if user input is a whole number
            If yoIsThisAWholeNumber(txtInput.Text) Then
                ' Check if user input is between 0 and 5000
                If (CInt(txtInput.Text) >= 0) And (CInt(txtInput.Text) <= 5000) Then
                    ' Save the user input into unitsShipped
                    unitsShipped(employee, day - 1) = Convert.ToInt32(txtInput.Text)

                    ' Display all entries in txtDisplay
                    For i = 0 To day - 1
                        textboxList(employee).Text &= Convert.ToString(unitsShipped(employee, i)) & vbNewLine
                        If day > 6 Then
                            ' Calculate and output average units shipped
                            For j = 0 To day - 1
                                total = total + unitsShipped(employee, j)
                            Next
                            average = Math.Round((total / day), 2)
                            labelList(employee).Text = "Average: " + Convert.ToString(average)
                            total = 0
                            If employee < 2 Then
                                employee += 1
                            ElseIf employee = 2 Then
                                lblDay.Text = "Day " + Convert.ToString(7)

                                ' Disable user's ability to enter data
                                txtInput.ReadOnly = True
                                btnEnter.Enabled = False
                                txtInput.TabStop = False
                                btnEnter.TabStop = False
                            End If
                            day = 0
                        End If
                    Next
                    day += 1

                    ' Change day and clear txtInput after user presses enter

                    lblDay.Text = "Day " + Convert.ToString(day)
                    txtInput.Text = String.Empty
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
        employee = 0
        ' Reset Day
        lblDay.Text = "Day " + Convert.ToString(day)
        For Each textboxToSet As TextBox In textboxList
            textboxToSet.Text = String.Empty
        Next
        For Each labelToSet As Label In labelList
            labelToSet.Text = String.Empty
        Next
        txtInput.Text = String.Empty
        ' Enable user's ability to enter data
        txtInput.ReadOnly = False
        btnEnter.Enabled = True
        txtInput.TabStop = True
        btnEnter.TabStop = True
        ' Focus back to the top
        txtInput.Focus()
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