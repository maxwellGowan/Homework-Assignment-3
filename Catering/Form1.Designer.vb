<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.rbCheese = New System.Windows.Forms.RadioButton()
        Me.rbPinwheel = New System.Windows.Forms.RadioButton()
        Me.rbVeggie = New System.Windows.Forms.RadioButton()
        Me.rbSausage = New System.Windows.Forms.RadioButton()
        Me.rbFruit = New System.Windows.Forms.RadioButton()
        Me.lblLoyalty = New System.Windows.Forms.Label()
        Me.txtLoyaltyPoints = New System.Windows.Forms.TextBox()
        Me.rbPrePay = New System.Windows.Forms.RadioButton()
        Me.rbPickupPay = New System.Windows.Forms.RadioButton()
        Me.lblPay = New System.Windows.Forms.Label()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.grpFood = New System.Windows.Forms.GroupBox()
        Me.grpPay = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFood.SuspendLayout()
        Me.grpPay.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(123, 5)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(112, 29)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Catering"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(124, 34)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(103, 20)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Star Market"
        '
        'rbCheese
        '
        Me.rbCheese.AutoSize = True
        Me.rbCheese.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCheese.Location = New System.Drawing.Point(6, 19)
        Me.rbCheese.Name = "rbCheese"
        Me.rbCheese.Size = New System.Drawing.Size(202, 24)
        Me.rbCheese.TabIndex = 3
        Me.rbCheese.TabStop = True
        Me.rbCheese.Text = "Gourmet Cheese $49.99"
        Me.rbCheese.UseVisualStyleBackColor = True
        '
        'rbPinwheel
        '
        Me.rbPinwheel.AutoSize = True
        Me.rbPinwheel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPinwheel.Location = New System.Drawing.Point(6, 42)
        Me.rbPinwheel.Name = "rbPinwheel"
        Me.rbPinwheel.Size = New System.Drawing.Size(193, 24)
        Me.rbPinwheel.TabIndex = 4
        Me.rbPinwheel.TabStop = True
        Me.rbPinwheel.Text = "Pinwheel Wraps $59.99"
        Me.rbPinwheel.UseVisualStyleBackColor = True
        '
        'rbVeggie
        '
        Me.rbVeggie.AutoSize = True
        Me.rbVeggie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbVeggie.Location = New System.Drawing.Point(6, 65)
        Me.rbVeggie.Name = "rbVeggie"
        Me.rbVeggie.Size = New System.Drawing.Size(130, 24)
        Me.rbVeggie.TabIndex = 5
        Me.rbVeggie.TabStop = True
        Me.rbVeggie.Text = "Veggie $29.99"
        Me.rbVeggie.UseVisualStyleBackColor = True
        '
        'rbSausage
        '
        Me.rbSausage.AutoSize = True
        Me.rbSausage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSausage.Location = New System.Drawing.Point(6, 88)
        Me.rbSausage.Name = "rbSausage"
        Me.rbSausage.Size = New System.Drawing.Size(234, 24)
        Me.rbSausage.TabIndex = 6
        Me.rbSausage.TabStop = True
        Me.rbSausage.Text = "Sausage and Cheese $49.99"
        Me.rbSausage.UseVisualStyleBackColor = True
        '
        'rbFruit
        '
        Me.rbFruit.AutoSize = True
        Me.rbFruit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFruit.Location = New System.Drawing.Point(6, 111)
        Me.rbFruit.Name = "rbFruit"
        Me.rbFruit.Size = New System.Drawing.Size(112, 24)
        Me.rbFruit.TabIndex = 7
        Me.rbFruit.TabStop = True
        Me.rbFruit.Text = "Fruit $29.99"
        Me.rbFruit.UseVisualStyleBackColor = True
        '
        'lblLoyalty
        '
        Me.lblLoyalty.AutoSize = True
        Me.lblLoyalty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoyalty.Location = New System.Drawing.Point(463, 263)
        Me.lblLoyalty.Name = "lblLoyalty"
        Me.lblLoyalty.Size = New System.Drawing.Size(120, 20)
        Me.lblLoyalty.TabIndex = 8
        Me.lblLoyalty.Text = "Loyalty Points"
        '
        'txtLoyaltyPoints
        '
        Me.txtLoyaltyPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoyaltyPoints.Location = New System.Drawing.Point(643, 263)
        Me.txtLoyaltyPoints.Name = "txtLoyaltyPoints"
        Me.txtLoyaltyPoints.Size = New System.Drawing.Size(58, 26)
        Me.txtLoyaltyPoints.TabIndex = 9
        '
        'rbPrePay
        '
        Me.rbPrePay.AutoSize = True
        Me.rbPrePay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPrePay.Location = New System.Drawing.Point(6, 19)
        Me.rbPrePay.Name = "rbPrePay"
        Me.rbPrePay.Size = New System.Drawing.Size(82, 24)
        Me.rbPrePay.TabIndex = 11
        Me.rbPrePay.TabStop = True
        Me.rbPrePay.Text = "Pre-Pay"
        Me.rbPrePay.UseVisualStyleBackColor = True
        '
        'rbPickupPay
        '
        Me.rbPickupPay.AutoSize = True
        Me.rbPickupPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPickupPay.Location = New System.Drawing.Point(6, 42)
        Me.rbPickupPay.Name = "rbPickupPay"
        Me.rbPickupPay.Size = New System.Drawing.Size(144, 24)
        Me.rbPickupPay.TabIndex = 12
        Me.rbPickupPay.TabStop = True
        Me.rbPickupPay.Text = "Pay upon Pickup"
        Me.rbPickupPay.UseVisualStyleBackColor = True
        '
        'lblPay
        '
        Me.lblPay.AutoSize = True
        Me.lblPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPay.Location = New System.Drawing.Point(89, 427)
        Me.lblPay.Name = "lblPay"
        Me.lblPay.Size = New System.Drawing.Size(138, 25)
        Me.lblPay.TabIndex = 13
        Me.lblPay.Text = "Please Pay:"
        '
        'lblResults
        '
        Me.lblResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResults.Location = New System.Drawing.Point(256, 427)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(476, 77)
        Me.lblResults.TabIndex = 14
        Me.lblResults.Text = "placeholder text"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(408, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(370, 215)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(504, 355)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(98, 35)
        Me.btnCalculate.TabIndex = 16
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(643, 355)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(89, 35)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'grpFood
        '
        Me.grpFood.BackColor = System.Drawing.Color.MistyRose
        Me.grpFood.Controls.Add(Me.rbCheese)
        Me.grpFood.Controls.Add(Me.rbPinwheel)
        Me.grpFood.Controls.Add(Me.rbVeggie)
        Me.grpFood.Controls.Add(Me.rbSausage)
        Me.grpFood.Controls.Add(Me.rbFruit)
        Me.grpFood.Location = New System.Drawing.Point(53, 85)
        Me.grpFood.Name = "grpFood"
        Me.grpFood.Size = New System.Drawing.Size(288, 151)
        Me.grpFood.TabIndex = 18
        Me.grpFood.TabStop = False
        '
        'grpPay
        '
        Me.grpPay.BackColor = System.Drawing.Color.MistyRose
        Me.grpPay.Controls.Add(Me.rbPrePay)
        Me.grpPay.Controls.Add(Me.rbPickupPay)
        Me.grpPay.Location = New System.Drawing.Point(98, 263)
        Me.grpPay.Name = "grpPay"
        Me.grpPay.Size = New System.Drawing.Size(157, 71)
        Me.grpPay.TabIndex = 19
        Me.grpPay.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(800, 513)
        Me.Controls.Add(Me.grpPay)
        Me.Controls.Add(Me.grpFood)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.lblPay)
        Me.Controls.Add(Me.txtLoyaltyPoints)
        Me.Controls.Add(Me.lblLoyalty)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblHeader)
        Me.Name = "Form1"
        Me.Text = "Catering"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFood.ResumeLayout(False)
        Me.grpFood.PerformLayout()
        Me.grpPay.ResumeLayout(False)
        Me.grpPay.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents lblName As Label
    Friend WithEvents rbCheese As RadioButton
    Friend WithEvents rbPinwheel As RadioButton
    Friend WithEvents rbVeggie As RadioButton
    Friend WithEvents rbSausage As RadioButton
    Friend WithEvents rbFruit As RadioButton
    Friend WithEvents lblLoyalty As Label
    Friend WithEvents txtLoyaltyPoints As TextBox
    Friend WithEvents rbPrePay As RadioButton
    Friend WithEvents rbPickupPay As RadioButton
    Friend WithEvents lblPay As Label
    Friend WithEvents lblResults As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents grpFood As GroupBox
    Friend WithEvents grpPay As GroupBox
End Class
