<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LateNoticesfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LateNoticesfrm))
        Me.rtbLateNotice = New System.Windows.Forms.RichTextBox()
        Me.Printrtb_btn = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.unitNumL_txt = New System.Windows.Forms.TextBox()
        Me.newrentdate_txt = New System.Windows.Forms.TextBox()
        Me.duedateL_txt = New System.Windows.Forms.TextBox()
        Me.UnitNum_lbl = New System.Windows.Forms.Label()
        Me.newrentdate_lbl = New System.Windows.Forms.Label()
        Me.DueDate_lbl = New System.Windows.Forms.Label()
        Me.id_lbl = New System.Windows.Forms.Label()
        Me.AmtPaid_lbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.currentdate_txt = New System.Windows.Forms.TextBox()
        Me.newduedate_lbl = New System.Windows.Forms.Label()
        Me.Test_lbl = New System.Windows.Forms.Label()
        Me.AmtDue_txt = New System.Windows.Forms.TextBox()
        Me.rentamountL_txt = New System.Windows.Forms.TextBox()
        Me.dgLate = New System.Windows.Forms.DataGridView()
        Me.cusLname_txt = New System.Windows.Forms.TextBox()
        Me.Email_lbl = New System.Windows.Forms.Label()
        Me.email_txt = New System.Windows.Forms.TextBox()
        Me.Zip_lbl = New System.Windows.Forms.Label()
        Me.zip_txt = New System.Windows.Forms.TextBox()
        Me.State_lbl = New System.Windows.Forms.Label()
        Me.state_txt = New System.Windows.Forms.TextBox()
        Me.City_lbl = New System.Windows.Forms.Label()
        Me.city_txt = New System.Windows.Forms.TextBox()
        Me.Address_lbl = New System.Windows.Forms.Label()
        Me.address_txt = New System.Windows.Forms.TextBox()
        Me.Customer_lbl = New System.Windows.Forms.Label()
        Me.cusFname_txt = New System.Windows.Forms.TextBox()
        Me.rentdata_lbl = New System.Windows.Forms.Label()
        Me.rentdate_txt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgLate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rtbLateNotice
        '
        Me.rtbLateNotice.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbLateNotice.Location = New System.Drawing.Point(12, 370)
        Me.rtbLateNotice.Name = "rtbLateNotice"
        Me.rtbLateNotice.ReadOnly = True
        Me.rtbLateNotice.Size = New System.Drawing.Size(656, 378)
        Me.rtbLateNotice.TabIndex = 0
        Me.rtbLateNotice.Text = ""
        '
        'Printrtb_btn
        '
        Me.Printrtb_btn.Location = New System.Drawing.Point(86, 109)
        Me.Printrtb_btn.Name = "Printrtb_btn"
        Me.Printrtb_btn.Size = New System.Drawing.Size(99, 23)
        Me.Printrtb_btn.TabIndex = 87
        Me.Printrtb_btn.Text = "Print Late Notice"
        Me.Printrtb_btn.UseVisualStyleBackColor = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(333, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Late Notice"
        '
        'unitNumL_txt
        '
        Me.unitNumL_txt.Location = New System.Drawing.Point(21, 295)
        Me.unitNumL_txt.Name = "unitNumL_txt"
        Me.unitNumL_txt.Size = New System.Drawing.Size(100, 20)
        Me.unitNumL_txt.TabIndex = 73
        '
        'newrentdate_txt
        '
        Me.newrentdate_txt.Location = New System.Drawing.Point(127, 333)
        Me.newrentdate_txt.Name = "newrentdate_txt"
        Me.newrentdate_txt.Size = New System.Drawing.Size(100, 20)
        Me.newrentdate_txt.TabIndex = 74
        '
        'duedateL_txt
        '
        Me.duedateL_txt.Location = New System.Drawing.Point(441, 333)
        Me.duedateL_txt.Name = "duedateL_txt"
        Me.duedateL_txt.Size = New System.Drawing.Size(100, 20)
        Me.duedateL_txt.TabIndex = 76
        '
        'UnitNum_lbl
        '
        Me.UnitNum_lbl.AutoSize = True
        Me.UnitNum_lbl.Location = New System.Drawing.Point(40, 280)
        Me.UnitNum_lbl.Name = "UnitNum_lbl"
        Me.UnitNum_lbl.Size = New System.Drawing.Size(63, 13)
        Me.UnitNum_lbl.TabIndex = 80
        Me.UnitNum_lbl.Text = "UnitNumber"
        '
        'newrentdate_lbl
        '
        Me.newrentdate_lbl.AutoSize = True
        Me.newrentdate_lbl.Location = New System.Drawing.Point(143, 318)
        Me.newrentdate_lbl.Name = "newrentdate_lbl"
        Me.newrentdate_lbl.Size = New System.Drawing.Size(81, 13)
        Me.newrentdate_lbl.TabIndex = 81
        Me.newrentdate_lbl.Text = "New Rent Date"
        '
        'DueDate_lbl
        '
        Me.DueDate_lbl.AutoSize = True
        Me.DueDate_lbl.Location = New System.Drawing.Point(445, 318)
        Me.DueDate_lbl.Name = "DueDate_lbl"
        Me.DueDate_lbl.Size = New System.Drawing.Size(78, 13)
        Me.DueDate_lbl.TabIndex = 82
        Me.DueDate_lbl.Text = "Next Due Date"
        '
        'id_lbl
        '
        Me.id_lbl.AutoSize = True
        Me.id_lbl.Location = New System.Drawing.Point(512, 356)
        Me.id_lbl.Name = "id_lbl"
        Me.id_lbl.Size = New System.Drawing.Size(39, 13)
        Me.id_lbl.TabIndex = 79
        Me.id_lbl.Text = "Label1"
        Me.id_lbl.Visible = False
        '
        'AmtPaid_lbl
        '
        Me.AmtPaid_lbl.AutoSize = True
        Me.AmtPaid_lbl.Location = New System.Drawing.Point(561, 318)
        Me.AmtPaid_lbl.Name = "AmtPaid_lbl"
        Me.AmtPaid_lbl.Size = New System.Drawing.Size(66, 13)
        Me.AmtPaid_lbl.TabIndex = 86
        Me.AmtPaid_lbl.Text = "Amount Due"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 318)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Rent Amount"
        '
        'currentdate_txt
        '
        Me.currentdate_txt.Location = New System.Drawing.Point(441, 295)
        Me.currentdate_txt.Name = "currentdate_txt"
        Me.currentdate_txt.Size = New System.Drawing.Size(100, 20)
        Me.currentdate_txt.TabIndex = 77
        '
        'newduedate_lbl
        '
        Me.newduedate_lbl.AutoSize = True
        Me.newduedate_lbl.Location = New System.Drawing.Point(455, 280)
        Me.newduedate_lbl.Name = "newduedate_lbl"
        Me.newduedate_lbl.Size = New System.Drawing.Size(67, 13)
        Me.newduedate_lbl.TabIndex = 84
        Me.newduedate_lbl.Text = "Current Date"
        '
        'Test_lbl
        '
        Me.Test_lbl.AutoSize = True
        Me.Test_lbl.Location = New System.Drawing.Point(612, 356)
        Me.Test_lbl.Name = "Test_lbl"
        Me.Test_lbl.Size = New System.Drawing.Size(39, 13)
        Me.Test_lbl.TabIndex = 85
        Me.Test_lbl.Text = "Label1"
        '
        'AmtDue_txt
        '
        Me.AmtDue_txt.Location = New System.Drawing.Point(547, 333)
        Me.AmtDue_txt.Name = "AmtDue_txt"
        Me.AmtDue_txt.Size = New System.Drawing.Size(100, 20)
        Me.AmtDue_txt.TabIndex = 78
        '
        'rentamountL_txt
        '
        Me.rentamountL_txt.Location = New System.Drawing.Point(21, 333)
        Me.rentamountL_txt.Name = "rentamountL_txt"
        Me.rentamountL_txt.Size = New System.Drawing.Size(100, 20)
        Me.rentamountL_txt.TabIndex = 75
        '
        'dgLate
        '
        Me.dgLate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgLate.Location = New System.Drawing.Point(12, 138)
        Me.dgLate.Name = "dgLate"
        Me.dgLate.Size = New System.Drawing.Size(655, 133)
        Me.dgLate.TabIndex = 104
        '
        'cusLname_txt
        '
        Me.cusLname_txt.Enabled = False
        Me.cusLname_txt.Location = New System.Drawing.Point(217, 5)
        Me.cusLname_txt.Name = "cusLname_txt"
        Me.cusLname_txt.Size = New System.Drawing.Size(102, 20)
        Me.cusLname_txt.TabIndex = 118
        '
        'Email_lbl
        '
        Me.Email_lbl.AutoSize = True
        Me.Email_lbl.Location = New System.Drawing.Point(333, 38)
        Me.Email_lbl.Name = "Email_lbl"
        Me.Email_lbl.Size = New System.Drawing.Size(35, 13)
        Me.Email_lbl.TabIndex = 117
        Me.Email_lbl.Text = "E-mail"
        '
        'email_txt
        '
        Me.email_txt.Enabled = False
        Me.email_txt.Location = New System.Drawing.Point(399, 31)
        Me.email_txt.Name = "email_txt"
        Me.email_txt.Size = New System.Drawing.Size(258, 20)
        Me.email_txt.TabIndex = 116
        '
        'Zip_lbl
        '
        Me.Zip_lbl.AutoSize = True
        Me.Zip_lbl.Location = New System.Drawing.Point(333, 12)
        Me.Zip_lbl.Name = "Zip_lbl"
        Me.Zip_lbl.Size = New System.Drawing.Size(22, 13)
        Me.Zip_lbl.TabIndex = 115
        Me.Zip_lbl.Text = "Zip"
        '
        'zip_txt
        '
        Me.zip_txt.Enabled = False
        Me.zip_txt.Location = New System.Drawing.Point(399, 5)
        Me.zip_txt.Name = "zip_txt"
        Me.zip_txt.Size = New System.Drawing.Size(258, 20)
        Me.zip_txt.TabIndex = 114
        '
        'State_lbl
        '
        Me.State_lbl.AutoSize = True
        Me.State_lbl.Location = New System.Drawing.Point(20, 90)
        Me.State_lbl.Name = "State_lbl"
        Me.State_lbl.Size = New System.Drawing.Size(32, 13)
        Me.State_lbl.TabIndex = 113
        Me.State_lbl.Text = "State"
        '
        'state_txt
        '
        Me.state_txt.Enabled = False
        Me.state_txt.Location = New System.Drawing.Point(86, 83)
        Me.state_txt.Name = "state_txt"
        Me.state_txt.Size = New System.Drawing.Size(233, 20)
        Me.state_txt.TabIndex = 112
        '
        'City_lbl
        '
        Me.City_lbl.AutoSize = True
        Me.City_lbl.Location = New System.Drawing.Point(20, 64)
        Me.City_lbl.Name = "City_lbl"
        Me.City_lbl.Size = New System.Drawing.Size(24, 13)
        Me.City_lbl.TabIndex = 111
        Me.City_lbl.Text = "City"
        '
        'city_txt
        '
        Me.city_txt.Enabled = False
        Me.city_txt.Location = New System.Drawing.Point(86, 57)
        Me.city_txt.Name = "city_txt"
        Me.city_txt.Size = New System.Drawing.Size(233, 20)
        Me.city_txt.TabIndex = 110
        '
        'Address_lbl
        '
        Me.Address_lbl.AutoSize = True
        Me.Address_lbl.Location = New System.Drawing.Point(20, 38)
        Me.Address_lbl.Name = "Address_lbl"
        Me.Address_lbl.Size = New System.Drawing.Size(45, 13)
        Me.Address_lbl.TabIndex = 109
        Me.Address_lbl.Text = "Address"
        '
        'address_txt
        '
        Me.address_txt.Enabled = False
        Me.address_txt.Location = New System.Drawing.Point(86, 31)
        Me.address_txt.Name = "address_txt"
        Me.address_txt.Size = New System.Drawing.Size(233, 20)
        Me.address_txt.TabIndex = 108
        '
        'Customer_lbl
        '
        Me.Customer_lbl.AutoSize = True
        Me.Customer_lbl.Location = New System.Drawing.Point(20, 12)
        Me.Customer_lbl.Name = "Customer_lbl"
        Me.Customer_lbl.Size = New System.Drawing.Size(51, 13)
        Me.Customer_lbl.TabIndex = 107
        Me.Customer_lbl.Text = "Customer"
        '
        'cusFname_txt
        '
        Me.cusFname_txt.Enabled = False
        Me.cusFname_txt.Location = New System.Drawing.Point(86, 5)
        Me.cusFname_txt.Name = "cusFname_txt"
        Me.cusFname_txt.Size = New System.Drawing.Size(125, 20)
        Me.cusFname_txt.TabIndex = 106
        '
        'rentdata_lbl
        '
        Me.rentdata_lbl.AutoSize = True
        Me.rentdata_lbl.Location = New System.Drawing.Point(152, 280)
        Me.rentdata_lbl.Name = "rentdata_lbl"
        Me.rentdata_lbl.Size = New System.Drawing.Size(56, 13)
        Me.rentdata_lbl.TabIndex = 120
        Me.rentdata_lbl.Text = "Rent Date"
        '
        'rentdate_txt
        '
        Me.rentdate_txt.Location = New System.Drawing.Point(127, 295)
        Me.rentdate_txt.Name = "rentdate_txt"
        Me.rentdate_txt.Size = New System.Drawing.Size(100, 20)
        Me.rentdate_txt.TabIndex = 119
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(208, 109)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 23)
        Me.Button1.TabIndex = 121
        Me.Button1.Text = "Email Late Notice"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LateNoticesfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 760)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.rentdata_lbl)
        Me.Controls.Add(Me.rentdate_txt)
        Me.Controls.Add(Me.cusLname_txt)
        Me.Controls.Add(Me.Email_lbl)
        Me.Controls.Add(Me.email_txt)
        Me.Controls.Add(Me.Zip_lbl)
        Me.Controls.Add(Me.zip_txt)
        Me.Controls.Add(Me.State_lbl)
        Me.Controls.Add(Me.state_txt)
        Me.Controls.Add(Me.City_lbl)
        Me.Controls.Add(Me.city_txt)
        Me.Controls.Add(Me.Address_lbl)
        Me.Controls.Add(Me.address_txt)
        Me.Controls.Add(Me.Customer_lbl)
        Me.Controls.Add(Me.cusFname_txt)
        Me.Controls.Add(Me.dgLate)
        Me.Controls.Add(Me.Printrtb_btn)
        Me.Controls.Add(Me.AmtPaid_lbl)
        Me.Controls.Add(Me.AmtDue_txt)
        Me.Controls.Add(Me.Test_lbl)
        Me.Controls.Add(Me.newduedate_lbl)
        Me.Controls.Add(Me.currentdate_txt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rentamountL_txt)
        Me.Controls.Add(Me.id_lbl)
        Me.Controls.Add(Me.DueDate_lbl)
        Me.Controls.Add(Me.newrentdate_lbl)
        Me.Controls.Add(Me.UnitNum_lbl)
        Me.Controls.Add(Me.duedateL_txt)
        Me.Controls.Add(Me.newrentdate_txt)
        Me.Controls.Add(Me.unitNumL_txt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rtbLateNotice)
        Me.Name = "LateNoticesfrm"
        Me.Text = "Late Notices"
        CType(Me.dgLate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rtbLateNotice As RichTextBox
    Friend WithEvents Printrtb_btn As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Label1 As Label
    Friend WithEvents unitNumL_txt As TextBox
    Friend WithEvents newrentdate_txt As TextBox
    Friend WithEvents duedateL_txt As TextBox
    Friend WithEvents UnitNum_lbl As Label
    Friend WithEvents newrentdate_lbl As Label
    Friend WithEvents DueDate_lbl As Label
    Friend WithEvents id_lbl As Label
    Friend WithEvents AmtPaid_lbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents currentdate_txt As TextBox
    Friend WithEvents newduedate_lbl As Label
    Friend WithEvents Test_lbl As Label
    Friend WithEvents AmtDue_txt As TextBox
    Friend WithEvents rentamountL_txt As TextBox
    Friend WithEvents dgLate As DataGridView
    Friend WithEvents cusLname_txt As TextBox
    Friend WithEvents Email_lbl As Label
    Friend WithEvents email_txt As TextBox
    Friend WithEvents Zip_lbl As Label
    Friend WithEvents zip_txt As TextBox
    Friend WithEvents State_lbl As Label
    Friend WithEvents state_txt As TextBox
    Friend WithEvents City_lbl As Label
    Friend WithEvents city_txt As TextBox
    Friend WithEvents Address_lbl As Label
    Friend WithEvents address_txt As TextBox
    Friend WithEvents Customer_lbl As Label
    Friend WithEvents cusFname_txt As TextBox
    Friend WithEvents rentdata_lbl As Label
    Friend WithEvents rentdate_txt As TextBox
    Friend WithEvents Button1 As Button
End Class
