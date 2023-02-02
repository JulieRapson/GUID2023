<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBurgerSpecials
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.picBeef = New System.Windows.Forms.PictureBox()
        Me.picVeggie = New System.Windows.Forms.PictureBox()
        Me.btnBeef = New System.Windows.Forms.Button()
        Me.btnMeal = New System.Windows.Forms.Button()
        Me.btnVeggie = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblConfirmation = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picBeef, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVeggie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeading.Location = New System.Drawing.Point(233, 31)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(248, 27)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Farm Burger Specials"
        '
        'picBeef
        '
        Me.picBeef.Location = New System.Drawing.Point(63, 88)
        Me.picBeef.Name = "picBeef"
        Me.picBeef.Size = New System.Drawing.Size(250, 250)
        Me.picBeef.TabIndex = 1
        Me.picBeef.TabStop = False
        '
        'picVeggie
        '
        Me.picVeggie.Location = New System.Drawing.Point(402, 88)
        Me.picVeggie.Name = "picVeggie"
        Me.picVeggie.Size = New System.Drawing.Size(250, 250)
        Me.picVeggie.TabIndex = 2
        Me.picVeggie.TabStop = False
        '
        'btnBeef
        '
        Me.btnBeef.Location = New System.Drawing.Point(140, 376)
        Me.btnBeef.Name = "btnBeef"
        Me.btnBeef.Size = New System.Drawing.Size(75, 30)
        Me.btnBeef.TabIndex = 3
        Me.btnBeef.Text = "Prime Beef"
        Me.btnBeef.UseVisualStyleBackColor = True
        '
        'btnMeal
        '
        Me.btnMeal.Location = New System.Drawing.Point(320, 375)
        Me.btnMeal.Name = "btnMeal"
        Me.btnMeal.Size = New System.Drawing.Size(75, 30)
        Me.btnMeal.TabIndex = 4
        Me.btnMeal.Text = "Select Meal"
        Me.btnMeal.UseVisualStyleBackColor = True
        '
        'btnVeggie
        '
        Me.btnVeggie.Location = New System.Drawing.Point(500, 375)
        Me.btnVeggie.Name = "btnVeggie"
        Me.btnVeggie.Size = New System.Drawing.Size(75, 30)
        Me.btnVeggie.TabIndex = 5
        Me.btnVeggie.Text = "Veggie"
        Me.btnVeggie.UseVisualStyleBackColor = True
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(186, 423)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(308, 14)
        Me.lblInstructions.TabIndex = 6
        Me.lblInstructions.Text = "Choose a burger and then click the Select Meal button"
        '
        'lblConfirmation
        '
        Me.lblConfirmation.AutoSize = True
        Me.lblConfirmation.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmation.Location = New System.Drawing.Point(268, 452)
        Me.lblConfirmation.Name = "lblConfirmation"
        Me.lblConfirmation.Size = New System.Drawing.Size(144, 14)
        Me.lblConfirmation.TabIndex = 7
        Me.lblConfirmation.Text = "Enjoy your burger special"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(320, 494)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(85, 30)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmBurgerSpecials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 562)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblConfirmation)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnVeggie)
        Me.Controls.Add(Me.btnMeal)
        Me.Controls.Add(Me.btnBeef)
        Me.Controls.Add(Me.picVeggie)
        Me.Controls.Add(Me.picBeef)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmBurgerSpecials"
        Me.Text = "Burger Specials"
        CType(Me.picBeef, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVeggie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents picBeef As PictureBox
    Friend WithEvents picVeggie As PictureBox
    Friend WithEvents btnBeef As Button
    Friend WithEvents btnMeal As Button
    Friend WithEvents btnVeggie As Button
    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblConfirmation As Label
    Friend WithEvents btnExit As Button
End Class
