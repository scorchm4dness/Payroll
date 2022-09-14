<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayroll
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
        Me.txtNet = New System.Windows.Forms.TextBox()
        Me.lblNet = New System.Windows.Forms.Label()
        Me.txtWGP = New System.Windows.Forms.TextBox()
        Me.lblWGP = New System.Windows.Forms.Label()
        Me.txtEmployeeName = New System.Windows.Forms.TextBox()
        Me.lblEmployeeName = New System.Windows.Forms.Label()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.lblTotalDeduction = New System.Windows.Forms.Label()
        Me.txtTotalDeduction = New System.Windows.Forms.TextBox()
        Me.txtSSS = New System.Windows.Forms.TextBox()
        Me.txtPhil = New System.Windows.Forms.TextBox()
        Me.txtTotalOTPay = New System.Windows.Forms.TextBox()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.txtTakeHomePay = New System.Windows.Forms.TextBox()
        Me.lblSSS = New System.Windows.Forms.Label()
        Me.lblPhil = New System.Windows.Forms.Label()
        Me.txtOT = New System.Windows.Forms.TextBox()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblDeduction = New System.Windows.Forms.Label()
        Me.txtRPD = New System.Windows.Forms.TextBox()
        Me.lblOT = New System.Windows.Forms.Label()
        Me.lblRPD = New System.Windows.Forms.Label()
        Me.lblTotalOTPay = New System.Windows.Forms.Label()
        Me.lblTakeHomePay = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblPayslip = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNet
        '
        Me.txtNet.Enabled = False
        Me.txtNet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNet.Location = New System.Drawing.Point(884, 335)
        Me.txtNet.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNet.Name = "txtNet"
        Me.txtNet.Size = New System.Drawing.Size(88, 30)
        Me.txtNet.TabIndex = 94
        '
        'lblNet
        '
        Me.lblNet.AutoSize = True
        Me.lblNet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNet.Location = New System.Drawing.Point(695, 337)
        Me.lblNet.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(185, 29)
        Me.lblNet.TabIndex = 103
        Me.lblNet.Text = "NET SALARY :"
        '
        'txtWGP
        '
        Me.txtWGP.Location = New System.Drawing.Point(243, 291)
        Me.txtWGP.Name = "txtWGP"
        Me.txtWGP.Size = New System.Drawing.Size(88, 26)
        Me.txtWGP.TabIndex = 102
        '
        'lblWGP
        '
        Me.lblWGP.AutoSize = True
        Me.lblWGP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWGP.Location = New System.Drawing.Point(69, 291)
        Me.lblWGP.Name = "lblWGP"
        Me.lblWGP.Size = New System.Drawing.Size(168, 22)
        Me.lblWGP.TabIndex = 101
        Me.lblWGP.Text = "Weekly Gross Pay: "
        '
        'txtEmployeeName
        '
        Me.txtEmployeeName.Location = New System.Drawing.Point(243, 150)
        Me.txtEmployeeName.Name = "txtEmployeeName"
        Me.txtEmployeeName.Size = New System.Drawing.Size(88, 26)
        Me.txtEmployeeName.TabIndex = 100
        '
        'lblEmployeeName
        '
        Me.lblEmployeeName.AutoSize = True
        Me.lblEmployeeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeName.Location = New System.Drawing.Point(77, 151)
        Me.lblEmployeeName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmployeeName.Name = "lblEmployeeName"
        Me.lblEmployeeName.Size = New System.Drawing.Size(146, 22)
        Me.lblEmployeeName.TabIndex = 99
        Me.lblEmployeeName.Text = "Employee Name:"
        '
        'btnCompute
        '
        Me.btnCompute.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnCompute.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCompute.Location = New System.Drawing.Point(414, 379)
        Me.btnCompute.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(153, 55)
        Me.btnCompute.TabIndex = 98
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.UseVisualStyleBackColor = False
        '
        'lblTotalDeduction
        '
        Me.lblTotalDeduction.AutoSize = True
        Me.lblTotalDeduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDeduction.Location = New System.Drawing.Point(334, 338)
        Me.lblTotalDeduction.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalDeduction.Name = "lblTotalDeduction"
        Me.lblTotalDeduction.Size = New System.Drawing.Size(270, 29)
        Me.lblTotalDeduction.TabIndex = 95
        Me.lblTotalDeduction.Text = "TOTAL DEDUCTION :"
        '
        'txtTotalDeduction
        '
        Me.txtTotalDeduction.Enabled = False
        Me.txtTotalDeduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDeduction.Location = New System.Drawing.Point(603, 338)
        Me.txtTotalDeduction.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTotalDeduction.Name = "txtTotalDeduction"
        Me.txtTotalDeduction.Size = New System.Drawing.Size(88, 30)
        Me.txtTotalDeduction.TabIndex = 94
        '
        'txtSSS
        '
        Me.txtSSS.Enabled = False
        Me.txtSSS.Location = New System.Drawing.Point(767, 268)
        Me.txtSSS.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSSS.Name = "txtSSS"
        Me.txtSSS.Size = New System.Drawing.Size(88, 26)
        Me.txtSSS.TabIndex = 93
        '
        'txtPhil
        '
        Me.txtPhil.Enabled = False
        Me.txtPhil.Location = New System.Drawing.Point(767, 236)
        Me.txtPhil.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPhil.Name = "txtPhil"
        Me.txtPhil.Size = New System.Drawing.Size(88, 26)
        Me.txtPhil.TabIndex = 92
        '
        'txtTotalOTPay
        '
        Me.txtTotalOTPay.Location = New System.Drawing.Point(243, 256)
        Me.txtTotalOTPay.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTotalOTPay.Name = "txtTotalOTPay"
        Me.txtTotalOTPay.Size = New System.Drawing.Size(88, 26)
        Me.txtTotalOTPay.TabIndex = 86
        '
        'txtTax
        '
        Me.txtTax.Enabled = False
        Me.txtTax.Location = New System.Drawing.Point(767, 204)
        Me.txtTax.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(88, 26)
        Me.txtTax.TabIndex = 91
        '
        'txtTakeHomePay
        '
        Me.txtTakeHomePay.Enabled = False
        Me.txtTakeHomePay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTakeHomePay.Location = New System.Drawing.Point(241, 336)
        Me.txtTakeHomePay.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTakeHomePay.Name = "txtTakeHomePay"
        Me.txtTakeHomePay.Size = New System.Drawing.Size(88, 30)
        Me.txtTakeHomePay.TabIndex = 97
        '
        'lblSSS
        '
        Me.lblSSS.AutoSize = True
        Me.lblSSS.Location = New System.Drawing.Point(632, 272)
        Me.lblSSS.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSSS.Name = "lblSSS"
        Me.lblSSS.Size = New System.Drawing.Size(69, 20)
        Me.lblSSS.TabIndex = 90
        Me.lblSSS.Text = "SSS 5%"
        '
        'lblPhil
        '
        Me.lblPhil.AutoSize = True
        Me.lblPhil.Location = New System.Drawing.Point(609, 242)
        Me.lblPhil.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPhil.Name = "lblPhil"
        Me.lblPhil.Size = New System.Drawing.Size(105, 20)
        Me.lblPhil.TabIndex = 89
        Me.lblPhil.Text = "Philhealth 3%"
        '
        'txtOT
        '
        Me.txtOT.Location = New System.Drawing.Point(243, 221)
        Me.txtOT.Margin = New System.Windows.Forms.Padding(2)
        Me.txtOT.Name = "txtOT"
        Me.txtOT.Size = New System.Drawing.Size(88, 26)
        Me.txtOT.TabIndex = 85
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(593, 206)
        Me.lblTax.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(136, 20)
        Me.lblTax.TabIndex = 88
        Me.lblTax.Text = "TAX 10% of WGP"
        '
        'lblDeduction
        '
        Me.lblDeduction.AutoSize = True
        Me.lblDeduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeduction.ForeColor = System.Drawing.Color.DarkRed
        Me.lblDeduction.Location = New System.Drawing.Point(632, 172)
        Me.lblDeduction.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDeduction.Name = "lblDeduction"
        Me.lblDeduction.Size = New System.Drawing.Size(248, 22)
        Me.lblDeduction.TabIndex = 87
        Me.lblDeduction.Text = "DEDUCTION OF SALARY:"
        '
        'txtRPD
        '
        Me.txtRPD.Location = New System.Drawing.Point(243, 184)
        Me.txtRPD.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRPD.Name = "txtRPD"
        Me.txtRPD.Size = New System.Drawing.Size(88, 26)
        Me.txtRPD.TabIndex = 83
        '
        'lblOT
        '
        Me.lblOT.AutoSize = True
        Me.lblOT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOT.Location = New System.Drawing.Point(78, 228)
        Me.lblOT.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOT.Name = "lblOT"
        Me.lblOT.Size = New System.Drawing.Size(145, 22)
        Me.lblOT.TabIndex = 82
        Me.lblOT.Text = "Overtime Hours :"
        '
        'lblRPD
        '
        Me.lblRPD.AutoSize = True
        Me.lblRPD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRPD.Location = New System.Drawing.Point(99, 188)
        Me.lblRPD.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRPD.Name = "lblRPD"
        Me.lblRPD.Size = New System.Drawing.Size(123, 22)
        Me.lblRPD.TabIndex = 81
        Me.lblRPD.Text = "Rate Per Day:"
        '
        'lblTotalOTPay
        '
        Me.lblTotalOTPay.AutoSize = True
        Me.lblTotalOTPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalOTPay.Location = New System.Drawing.Point(100, 260)
        Me.lblTotalOTPay.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalOTPay.Name = "lblTotalOTPay"
        Me.lblTotalOTPay.Size = New System.Drawing.Size(123, 22)
        Me.lblTotalOTPay.TabIndex = 84
        Me.lblTotalOTPay.Text = "Total OT Pay:"
        '
        'lblTakeHomePay
        '
        Me.lblTakeHomePay.AutoSize = True
        Me.lblTakeHomePay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTakeHomePay.Location = New System.Drawing.Point(3, 336)
        Me.lblTakeHomePay.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTakeHomePay.Name = "lblTakeHomePay"
        Me.lblTakeHomePay.Size = New System.Drawing.Size(234, 29)
        Me.lblTakeHomePay.TabIndex = 96
        Me.lblTakeHomePay.Text = "TAKE HOME PAY :"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Payroll.My.Resources.Resources.payrollICON
        Me.PictureBox2.Location = New System.Drawing.Point(733, 68)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(125, 58)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 80
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Payroll.My.Resources.Resources.payrollICON
        Me.PictureBox1.Location = New System.Drawing.Point(154, 68)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(104, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 79
        Me.PictureBox1.TabStop = False
        '
        'lblPayslip
        '
        Me.lblPayslip.AutoSize = True
        Me.lblPayslip.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayslip.Location = New System.Drawing.Point(359, 68)
        Me.lblPayslip.Name = "lblPayslip"
        Me.lblPayslip.Size = New System.Drawing.Size(285, 42)
        Me.lblPayslip.TabIndex = 78
        Me.lblPayslip.Text = "Payslip System"
        '
        'frmPayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 456)
        Me.Controls.Add(Me.txtNet)
        Me.Controls.Add(Me.lblNet)
        Me.Controls.Add(Me.txtWGP)
        Me.Controls.Add(Me.lblWGP)
        Me.Controls.Add(Me.txtEmployeeName)
        Me.Controls.Add(Me.lblEmployeeName)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.lblTotalDeduction)
        Me.Controls.Add(Me.txtTotalDeduction)
        Me.Controls.Add(Me.txtSSS)
        Me.Controls.Add(Me.txtPhil)
        Me.Controls.Add(Me.txtTotalOTPay)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.txtTakeHomePay)
        Me.Controls.Add(Me.lblSSS)
        Me.Controls.Add(Me.lblPhil)
        Me.Controls.Add(Me.txtOT)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblDeduction)
        Me.Controls.Add(Me.txtRPD)
        Me.Controls.Add(Me.lblOT)
        Me.Controls.Add(Me.lblRPD)
        Me.Controls.Add(Me.lblTotalOTPay)
        Me.Controls.Add(Me.lblTakeHomePay)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblPayslip)
        Me.Name = "frmPayroll"
        Me.Text = "Payroll"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNet As System.Windows.Forms.TextBox
    Friend WithEvents lblNet As System.Windows.Forms.Label
    Friend WithEvents txtWGP As System.Windows.Forms.TextBox
    Friend WithEvents lblWGP As System.Windows.Forms.Label
    Friend WithEvents txtEmployeeName As System.Windows.Forms.TextBox
    Friend WithEvents lblEmployeeName As System.Windows.Forms.Label
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents lblTotalDeduction As System.Windows.Forms.Label
    Friend WithEvents txtTotalDeduction As System.Windows.Forms.TextBox
    Friend WithEvents txtSSS As System.Windows.Forms.TextBox
    Friend WithEvents txtPhil As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalOTPay As System.Windows.Forms.TextBox
    Friend WithEvents txtTax As System.Windows.Forms.TextBox
    Friend WithEvents txtTakeHomePay As System.Windows.Forms.TextBox
    Friend WithEvents lblSSS As System.Windows.Forms.Label
    Friend WithEvents lblPhil As System.Windows.Forms.Label
    Friend WithEvents txtOT As System.Windows.Forms.TextBox
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblDeduction As System.Windows.Forms.Label
    Friend WithEvents txtRPD As System.Windows.Forms.TextBox
    Friend WithEvents lblOT As System.Windows.Forms.Label
    Friend WithEvents lblRPD As System.Windows.Forms.Label
    Friend WithEvents lblTotalOTPay As System.Windows.Forms.Label
    Friend WithEvents lblTakeHomePay As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblPayslip As System.Windows.Forms.Label

End Class
