<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageUnitsShippedByEmployee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblOutput1 = New System.Windows.Forms.Label()
        Me.txtDisplay1 = New System.Windows.Forms.TextBox()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblOutput2 = New System.Windows.Forms.Label()
        Me.txtDisplay2 = New System.Windows.Forms.TextBox()
        Me.lblOutput3 = New System.Windows.Forms.Label()
        Me.txtDisplay3 = New System.Windows.Forms.TextBox()
        Me.lblOutputOverall = New System.Windows.Forms.Label()
        Me.lblEmployee1 = New System.Windows.Forms.Label()
        Me.lblEmployee2 = New System.Windows.Forms.Label()
        Me.lblEmployee3 = New System.Windows.Forms.Label()
        Me.ttToopTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblOutput1
        '
        Me.lblOutput1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput1.Location = New System.Drawing.Point(14, 255)
        Me.lblOutput1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOutput1.Name = "lblOutput1"
        Me.lblOutput1.Size = New System.Drawing.Size(179, 23)
        Me.lblOutput1.TabIndex = 5
        Me.lblOutput1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDisplay1
        '
        Me.txtDisplay1.BackColor = System.Drawing.SystemColors.Window
        Me.txtDisplay1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisplay1.Location = New System.Drawing.Point(14, 98)
        Me.txtDisplay1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDisplay1.Multiline = True
        Me.txtDisplay1.Name = "txtDisplay1"
        Me.txtDisplay1.ReadOnly = True
        Me.txtDisplay1.Size = New System.Drawing.Size(180, 156)
        Me.txtDisplay1.TabIndex = 4
        Me.txtDisplay1.TabStop = False
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay.Location = New System.Drawing.Point(11, 9)
        Me.lblDay.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(46, 18)
        Me.lblDay.TabIndex = 0
        Me.lblDay.Text = "Day 1"
        Me.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttToopTip.SetToolTip(Me.lblDay, "Which day the value is going to be stored into")
        '
        'lblUnits
        '
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnits.Location = New System.Drawing.Point(11, 38)
        Me.lblUnits.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(46, 18)
        Me.lblUnits.TabIndex = 1
        Me.lblUnits.Text = "&Units:"
        Me.lblUnits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttToopTip.SetToolTip(Me.lblUnits, "Units shipped by the employee")
        '
        'txtInput
        '
        Me.txtInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(70, 36)
        Me.txtInput.Margin = New System.Windows.Forms.Padding(2)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(66, 24)
        Me.txtInput.TabIndex = 2
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(441, 320)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(179, 27)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        Me.ttToopTip.SetToolTip(Me.btnExit, "Quit program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.Location = New System.Drawing.Point(11, 320)
        Me.btnEnter.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(179, 27)
        Me.btnEnter.TabIndex = 13
        Me.btnEnter.Text = "&Enter"
        Me.ttToopTip.SetToolTip(Me.btnEnter, "Calculate Average")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(228, 320)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(180, 27)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "&Reset"
        Me.ttToopTip.SetToolTip(Me.btnReset, "Reset the form")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblOutput2
        '
        Me.lblOutput2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput2.Location = New System.Drawing.Point(229, 255)
        Me.lblOutput2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOutput2.Name = "lblOutput2"
        Me.lblOutput2.Size = New System.Drawing.Size(179, 23)
        Me.lblOutput2.TabIndex = 8
        Me.lblOutput2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDisplay2
        '
        Me.txtDisplay2.BackColor = System.Drawing.SystemColors.Window
        Me.txtDisplay2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisplay2.Location = New System.Drawing.Point(229, 98)
        Me.txtDisplay2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDisplay2.Multiline = True
        Me.txtDisplay2.Name = "txtDisplay2"
        Me.txtDisplay2.ReadOnly = True
        Me.txtDisplay2.Size = New System.Drawing.Size(180, 156)
        Me.txtDisplay2.TabIndex = 7
        Me.txtDisplay2.TabStop = False
        '
        'lblOutput3
        '
        Me.lblOutput3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput3.Location = New System.Drawing.Point(440, 255)
        Me.lblOutput3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOutput3.Name = "lblOutput3"
        Me.lblOutput3.Size = New System.Drawing.Size(179, 23)
        Me.lblOutput3.TabIndex = 11
        Me.lblOutput3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDisplay3
        '
        Me.txtDisplay3.BackColor = System.Drawing.SystemColors.Window
        Me.txtDisplay3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisplay3.Location = New System.Drawing.Point(440, 98)
        Me.txtDisplay3.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDisplay3.Multiline = True
        Me.txtDisplay3.Name = "txtDisplay3"
        Me.txtDisplay3.ReadOnly = True
        Me.txtDisplay3.Size = New System.Drawing.Size(180, 156)
        Me.txtDisplay3.TabIndex = 10
        Me.txtDisplay3.TabStop = False
        '
        'lblOutputOverall
        '
        Me.lblOutputOverall.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutputOverall.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutputOverall.Location = New System.Drawing.Point(15, 289)
        Me.lblOutputOverall.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOutputOverall.Name = "lblOutputOverall"
        Me.lblOutputOverall.Size = New System.Drawing.Size(605, 23)
        Me.lblOutputOverall.TabIndex = 12
        Me.lblOutputOverall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployee1
        '
        Me.lblEmployee1.AutoSize = True
        Me.lblEmployee1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployee1.Location = New System.Drawing.Point(60, 73)
        Me.lblEmployee1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmployee1.Name = "lblEmployee1"
        Me.lblEmployee1.Size = New System.Drawing.Size(86, 18)
        Me.lblEmployee1.TabIndex = 3
        Me.lblEmployee1.Text = "Employee 1"
        Me.lblEmployee1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttToopTip.SetToolTip(Me.lblEmployee1, "Employee 1")
        '
        'lblEmployee2
        '
        Me.lblEmployee2.AutoSize = True
        Me.lblEmployee2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployee2.Location = New System.Drawing.Point(273, 73)
        Me.lblEmployee2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmployee2.Name = "lblEmployee2"
        Me.lblEmployee2.Size = New System.Drawing.Size(86, 18)
        Me.lblEmployee2.TabIndex = 6
        Me.lblEmployee2.Text = "Employee 2"
        Me.lblEmployee2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttToopTip.SetToolTip(Me.lblEmployee2, "Employee 2")
        '
        'lblEmployee3
        '
        Me.lblEmployee3.AutoSize = True
        Me.lblEmployee3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployee3.Location = New System.Drawing.Point(486, 73)
        Me.lblEmployee3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmployee3.Name = "lblEmployee3"
        Me.lblEmployee3.Size = New System.Drawing.Size(86, 18)
        Me.lblEmployee3.TabIndex = 9
        Me.lblEmployee3.Text = "Employee 3"
        Me.lblEmployee3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttToopTip.SetToolTip(Me.lblEmployee3, "Employee 3")
        '
        'frmAverageUnitsShippedByEmployee
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(634, 363)
        Me.Controls.Add(Me.lblEmployee3)
        Me.Controls.Add(Me.lblEmployee2)
        Me.Controls.Add(Me.lblEmployee1)
        Me.Controls.Add(Me.lblOutputOverall)
        Me.Controls.Add(Me.lblOutput3)
        Me.Controls.Add(Me.txtDisplay3)
        Me.Controls.Add(Me.lblOutput2)
        Me.Controls.Add(Me.txtDisplay2)
        Me.Controls.Add(Me.lblOutput1)
        Me.Controls.Add(Me.txtDisplay1)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.btnReset)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(650, 402)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(650, 402)
        Me.Name = "frmAverageUnitsShippedByEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped By Employee"
        Me.ttToopTip.SetToolTip(Me, "Nice")
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblOutput1 As Label
    Friend WithEvents txtDisplay1 As TextBox
    Friend WithEvents lblDay As Label
    Friend WithEvents lblUnits As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lblOutput2 As Label
    Friend WithEvents txtDisplay2 As TextBox
    Friend WithEvents lblOutput3 As Label
    Friend WithEvents txtDisplay3 As TextBox
    Friend WithEvents lblOutputOverall As Label
    Friend WithEvents lblEmployee1 As Label
    Friend WithEvents lblEmployee2 As Label
    Friend WithEvents lblEmployee3 As Label
    Friend WithEvents ttToopTip As ToolTip
End Class
