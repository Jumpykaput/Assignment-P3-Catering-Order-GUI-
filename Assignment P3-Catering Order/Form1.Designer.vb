<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCateringOrder
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTitle1 = New System.Windows.Forms.Label()
        Me.lblTitle2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtPoints = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.grpPlatter = New System.Windows.Forms.GroupBox()
        Me.rdoFruit = New System.Windows.Forms.RadioButton()
        Me.rdoSausageCheese = New System.Windows.Forms.RadioButton()
        Me.rdoVeggie = New System.Windows.Forms.RadioButton()
        Me.rdoPinwheel = New System.Windows.Forms.RadioButton()
        Me.rdoCheese = New System.Windows.Forms.RadioButton()
        Me.grpPayment = New System.Windows.Forms.GroupBox()
        Me.rdoPayUponPickup = New System.Windows.Forms.RadioButton()
        Me.rdoPrePay = New System.Windows.Forms.RadioButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPlatter.SuspendLayout()
        Me.grpPayment.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Assignment_P3_Catering_Order.My.Resources.Resources.platter
        Me.PictureBox1.Location = New System.Drawing.Point(477, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(306, 215)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblTitle1
        '
        Me.lblTitle1.AutoSize = True
        Me.lblTitle1.Font = New System.Drawing.Font("Lucida Sans", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle1.Location = New System.Drawing.Point(83, 23)
        Me.lblTitle1.Name = "lblTitle1"
        Me.lblTitle1.Size = New System.Drawing.Size(111, 26)
        Me.lblTitle1.TabIndex = 1
        Me.lblTitle1.Text = "Catering"
        '
        'lblTitle2
        '
        Me.lblTitle2.AutoSize = True
        Me.lblTitle2.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle2.Location = New System.Drawing.Point(85, 58)
        Me.lblTitle2.Name = "lblTitle2"
        Me.lblTitle2.Size = New System.Drawing.Size(100, 17)
        Me.lblTitle2.TabIndex = 2
        Me.lblTitle2.Text = "Star Market"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(491, 256)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Loyalty Points:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 368)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Please Pay:"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(203, 370)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(0, 17)
        Me.lblResult.TabIndex = 5
        '
        'txtPoints
        '
        Me.txtPoints.Location = New System.Drawing.Point(617, 254)
        Me.txtPoints.Name = "txtPoints"
        Me.txtPoints.Size = New System.Drawing.Size(41, 22)
        Me.txtPoints.TabIndex = 6
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Wheat
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(477, 325)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(100, 32)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Wheat
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(662, 325)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 32)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'grpPlatter
        '
        Me.grpPlatter.BackColor = System.Drawing.Color.OldLace
        Me.grpPlatter.Controls.Add(Me.rdoFruit)
        Me.grpPlatter.Controls.Add(Me.rdoSausageCheese)
        Me.grpPlatter.Controls.Add(Me.rdoVeggie)
        Me.grpPlatter.Controls.Add(Me.rdoPinwheel)
        Me.grpPlatter.Controls.Add(Me.rdoCheese)
        Me.grpPlatter.Location = New System.Drawing.Point(28, 78)
        Me.grpPlatter.Name = "grpPlatter"
        Me.grpPlatter.Size = New System.Drawing.Size(247, 181)
        Me.grpPlatter.TabIndex = 9
        Me.grpPlatter.TabStop = False
        '
        'rdoFruit
        '
        Me.rdoFruit.AutoSize = True
        Me.rdoFruit.Location = New System.Drawing.Point(15, 135)
        Me.rdoFruit.Name = "rdoFruit"
        Me.rdoFruit.Size = New System.Drawing.Size(94, 20)
        Me.rdoFruit.TabIndex = 15
        Me.rdoFruit.TabStop = True
        Me.rdoFruit.Text = "Fruit $29.99"
        Me.rdoFruit.UseVisualStyleBackColor = True
        '
        'rdoSausageCheese
        '
        Me.rdoSausageCheese.AutoSize = True
        Me.rdoSausageCheese.Location = New System.Drawing.Point(15, 109)
        Me.rdoSausageCheese.Name = "rdoSausageCheese"
        Me.rdoSausageCheese.Size = New System.Drawing.Size(200, 20)
        Me.rdoSausageCheese.TabIndex = 14
        Me.rdoSausageCheese.TabStop = True
        Me.rdoSausageCheese.Text = "Sausage and Cheese $49.99"
        Me.rdoSausageCheese.UseVisualStyleBackColor = True
        '
        'rdoVeggie
        '
        Me.rdoVeggie.AutoSize = True
        Me.rdoVeggie.Location = New System.Drawing.Point(15, 83)
        Me.rdoVeggie.Name = "rdoVeggie"
        Me.rdoVeggie.Size = New System.Drawing.Size(113, 20)
        Me.rdoVeggie.TabIndex = 13
        Me.rdoVeggie.TabStop = True
        Me.rdoVeggie.Text = "Veggie $29.99"
        Me.rdoVeggie.UseVisualStyleBackColor = True
        '
        'rdoPinwheel
        '
        Me.rdoPinwheel.AutoSize = True
        Me.rdoPinwheel.Location = New System.Drawing.Point(15, 57)
        Me.rdoPinwheel.Name = "rdoPinwheel"
        Me.rdoPinwheel.Size = New System.Drawing.Size(166, 20)
        Me.rdoPinwheel.TabIndex = 12
        Me.rdoPinwheel.TabStop = True
        Me.rdoPinwheel.Text = "Pinwheel Wraps $59.99"
        Me.rdoPinwheel.UseVisualStyleBackColor = True
        '
        'rdoCheese
        '
        Me.rdoCheese.AutoSize = True
        Me.rdoCheese.Location = New System.Drawing.Point(15, 31)
        Me.rdoCheese.Name = "rdoCheese"
        Me.rdoCheese.Size = New System.Drawing.Size(170, 20)
        Me.rdoCheese.TabIndex = 11
        Me.rdoCheese.TabStop = True
        Me.rdoCheese.Text = "Gourmet Cheese $49.99"
        Me.rdoCheese.UseVisualStyleBackColor = True
        '
        'grpPayment
        '
        Me.grpPayment.BackColor = System.Drawing.Color.OldLace
        Me.grpPayment.Controls.Add(Me.rdoPayUponPickup)
        Me.grpPayment.Controls.Add(Me.rdoPrePay)
        Me.grpPayment.Location = New System.Drawing.Point(68, 277)
        Me.grpPayment.Name = "grpPayment"
        Me.grpPayment.Size = New System.Drawing.Size(177, 68)
        Me.grpPayment.TabIndex = 10
        Me.grpPayment.TabStop = False
        '
        'rdoPayUponPickup
        '
        Me.rdoPayUponPickup.AutoSize = True
        Me.rdoPayUponPickup.Location = New System.Drawing.Point(6, 36)
        Me.rdoPayUponPickup.Name = "rdoPayUponPickup"
        Me.rdoPayUponPickup.Size = New System.Drawing.Size(129, 20)
        Me.rdoPayUponPickup.TabIndex = 13
        Me.rdoPayUponPickup.TabStop = True
        Me.rdoPayUponPickup.Text = "Pay upon Pickup"
        Me.rdoPayUponPickup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoPayUponPickup.UseVisualStyleBackColor = True
        '
        'rdoPrePay
        '
        Me.rdoPrePay.AutoSize = True
        Me.rdoPrePay.Location = New System.Drawing.Point(6, 10)
        Me.rdoPrePay.Name = "rdoPrePay"
        Me.rdoPrePay.Size = New System.Drawing.Size(77, 20)
        Me.rdoPrePay.TabIndex = 12
        Me.rdoPrePay.TabStop = True
        Me.rdoPrePay.Text = "Pre-Pay"
        Me.rdoPrePay.UseVisualStyleBackColor = True
        '
        'frmCateringOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(796, 456)
        Me.Controls.Add(Me.grpPayment)
        Me.Controls.Add(Me.grpPlatter)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtPoints)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTitle2)
        Me.Controls.Add(Me.lblTitle1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmCateringOrder"
        Me.Text = "Catering"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPlatter.ResumeLayout(False)
        Me.grpPlatter.PerformLayout()
        Me.grpPayment.ResumeLayout(False)
        Me.grpPayment.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTitle1 As Label
    Friend WithEvents lblTitle2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents txtPoints As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents grpPlatter As GroupBox
    Friend WithEvents grpPayment As GroupBox
    Friend WithEvents rdoCheese As RadioButton
    Friend WithEvents rdoFruit As RadioButton
    Friend WithEvents rdoSausageCheese As RadioButton
    Friend WithEvents rdoVeggie As RadioButton
    Friend WithEvents rdoPinwheel As RadioButton
    Friend WithEvents rdoPayUponPickup As RadioButton
    Friend WithEvents rdoPrePay As RadioButton
End Class
