<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnBeef = New System.Windows.Forms.Button()
        Me.btnSelectMeal = New System.Windows.Forms.Button()
        Me.btnVeggie = New System.Windows.Forms.Button()
        Me.lblFarmBurgerSpecials = New System.Windows.Forms.Label()
        Me.lblInstruct = New System.Windows.Forms.Label()
        Me.lblConfirmed = New System.Windows.Forms.Label()
        Me.picPrimeBeef = New System.Windows.Forms.PictureBox()
        Me.picVeggie = New System.Windows.Forms.PictureBox()
        CType(Me.picPrimeBeef, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVeggie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(362, 391)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(93, 23)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnBeef
        '
        Me.btnBeef.Location = New System.Drawing.Point(133, 296)
        Me.btnBeef.Name = "btnBeef"
        Me.btnBeef.Size = New System.Drawing.Size(75, 23)
        Me.btnBeef.TabIndex = 1
        Me.btnBeef.Text = "Prime Beef"
        Me.btnBeef.UseVisualStyleBackColor = True
        '
        'btnSelectMeal
        '
        Me.btnSelectMeal.Location = New System.Drawing.Point(371, 296)
        Me.btnSelectMeal.Name = "btnSelectMeal"
        Me.btnSelectMeal.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectMeal.TabIndex = 2
        Me.btnSelectMeal.Text = "Select Meal"
        Me.btnSelectMeal.UseVisualStyleBackColor = True
        '
        'btnVeggie
        '
        Me.btnVeggie.Location = New System.Drawing.Point(625, 296)
        Me.btnVeggie.Name = "btnVeggie"
        Me.btnVeggie.Size = New System.Drawing.Size(75, 23)
        Me.btnVeggie.TabIndex = 3
        Me.btnVeggie.Text = "Veggie"
        Me.btnVeggie.UseVisualStyleBackColor = True
        '
        'lblFarmBurgerSpecials
        '
        Me.lblFarmBurgerSpecials.AutoSize = True
        Me.lblFarmBurgerSpecials.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblFarmBurgerSpecials.Location = New System.Drawing.Point(261, 45)
        Me.lblFarmBurgerSpecials.Name = "lblFarmBurgerSpecials"
        Me.lblFarmBurgerSpecials.Size = New System.Drawing.Size(233, 25)
        Me.lblFarmBurgerSpecials.TabIndex = 4
        Me.lblFarmBurgerSpecials.Text = "Farm Burger Specials"
        Me.lblFarmBurgerSpecials.UseMnemonic = False
        '
        'lblInstruct
        '
        Me.lblInstruct.AutoSize = True
        Me.lblInstruct.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblInstruct.Location = New System.Drawing.Point(250, 334)
        Me.lblInstruct.Name = "lblInstruct"
        Me.lblInstruct.Size = New System.Drawing.Size(316, 14)
        Me.lblInstruct.TabIndex = 5
        Me.lblInstruct.Text = "Choose a burger and then click the Select Meal button. "
        '
        'lblConfirmed
        '
        Me.lblConfirmed.AutoSize = True
        Me.lblConfirmed.Location = New System.Drawing.Point(338, 362)
        Me.lblConfirmed.Name = "lblConfirmed"
        Me.lblConfirmed.Size = New System.Drawing.Size(140, 15)
        Me.lblConfirmed.TabIndex = 6
        Me.lblConfirmed.Text = "Enjoy your burger special"
        '
        'picPrimeBeef
        '
        Me.picPrimeBeef.Location = New System.Drawing.Point(77, 130)
        Me.picPrimeBeef.Name = "picPrimeBeef"
        Me.picPrimeBeef.Size = New System.Drawing.Size(187, 160)
        Me.picPrimeBeef.TabIndex = 7
        Me.picPrimeBeef.TabStop = False
        '
        'picVeggie
        '
        Me.picVeggie.Location = New System.Drawing.Point(569, 130)
        Me.picVeggie.Name = "picVeggie"
        Me.picVeggie.Size = New System.Drawing.Size(187, 160)
        Me.picVeggie.TabIndex = 8
        Me.picVeggie.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.picVeggie)
        Me.Controls.Add(Me.picPrimeBeef)
        Me.Controls.Add(Me.lblConfirmed)
        Me.Controls.Add(Me.lblInstruct)
        Me.Controls.Add(Me.lblFarmBurgerSpecials)
        Me.Controls.Add(Me.btnVeggie)
        Me.Controls.Add(Me.btnSelectMeal)
        Me.Controls.Add(Me.btnBeef)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "Form1"
        Me.Text = "Burger Specials"
        CType(Me.picPrimeBeef, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVeggie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnBeef As Button
    Friend WithEvents btnSelectMeal As Button
    Friend WithEvents btnVeggie As Button
    Friend WithEvents lblFarmBurgerSpecials As Label
    Friend WithEvents lblInstruct As Label
    Friend WithEvents lblConfirmed As Label
    Friend WithEvents picPrimeBeef As PictureBox
    Friend WithEvents picVeggie As PictureBox
End Class
