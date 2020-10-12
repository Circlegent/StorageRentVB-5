<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LateNotice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LateNotice))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.rentdata_lbl = New System.Windows.Forms.Label()
        Me.rentdate_txt = New System.Windows.Forms.TextBox()
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
        Me.dgLate = New System.Windows.Forms.DataGridView()
        Me.Printrtb_btn = New System.Windows.Forms.Button()
        Me.AmtPaid_lbl = New System.Windows.Forms.Label()
        Me.AmtDue_txt = New System.Windows.Forms.TextBox()
        Me.Test_lbl = New System.Windows.Forms.Label()
        Me.newduedate_lbl = New System.Windows.Forms.Label()
        Me.currentdate_txt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rentamountL_txt = New System.Windows.Forms.TextBox()
        Me.id_lbl = New System.Windows.Forms.Label()
        Me.DueDate_lbl = New System.Windows.Forms.Label()
        Me.newrentdate_lbl = New System.Windows.Forms.Label()
        Me.UnitNum_lbl = New System.Windows.Forms.Label()
        Me.duedateL_txt = New System.Windows.Forms.TextBox()
        Me.newrentdate_txt = New System.Windows.Forms.TextBox()
        Me.unitNumL_txt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rtbLateNotice = New System.Windows.Forms.RichTextBox()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PayGrid2 = New System.Windows.Forms.DataGridView()
        Me.PrtRpt_btn = New System.Windows.Forms.Button()
        Me.eRcpt_btn = New System.Windows.Forms.Button()
        Me.unitNumL1_txt = New System.Windows.Forms.TextBox()
        Me.PayAmt_txt = New System.Windows.Forms.TextBox()
        Me.unitPayment_txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PayMeth_txt = New System.Windows.Forms.Label()
        Me.rtbRcpt = New System.Windows.Forms.RichTextBox()
        Me.PrintPreviewDialog2 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.rcptDueDate_txt = New System.Windows.Forms.TextBox()
        Me.rcptDueDate_lbl = New System.Windows.Forms.Label()
        Me.Paytemp = New System.Windows.Forms.TextBox()
        CType(Me.dgLate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(160, 224)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 23)
        Me.Button1.TabIndex = 154
        Me.Button1.Text = "Email Late Notice"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'rentdata_lbl
        '
        Me.rentdata_lbl.AutoSize = True
        Me.rentdata_lbl.Location = New System.Drawing.Point(143, 251)
        Me.rentdata_lbl.Name = "rentdata_lbl"
        Me.rentdata_lbl.Size = New System.Drawing.Size(56, 13)
        Me.rentdata_lbl.TabIndex = 153
        Me.rentdata_lbl.Text = "Rent Date"
        '
        'rentdate_txt
        '
        Me.rentdate_txt.Location = New System.Drawing.Point(118, 266)
        Me.rentdate_txt.Name = "rentdate_txt"
        Me.rentdate_txt.Size = New System.Drawing.Size(100, 20)
        Me.rentdate_txt.TabIndex = 152
        '
        'cusLname_txt
        '
        Me.cusLname_txt.Enabled = False
        Me.cusLname_txt.Location = New System.Drawing.Point(213, 7)
        Me.cusLname_txt.Name = "cusLname_txt"
        Me.cusLname_txt.Size = New System.Drawing.Size(102, 20)
        Me.cusLname_txt.TabIndex = 151
        '
        'Email_lbl
        '
        Me.Email_lbl.AutoSize = True
        Me.Email_lbl.Location = New System.Drawing.Point(329, 66)
        Me.Email_lbl.Name = "Email_lbl"
        Me.Email_lbl.Size = New System.Drawing.Size(35, 13)
        Me.Email_lbl.TabIndex = 150
        Me.Email_lbl.Text = "E-mail"
        '
        'email_txt
        '
        Me.email_txt.Enabled = False
        Me.email_txt.Location = New System.Drawing.Point(395, 59)
        Me.email_txt.Name = "email_txt"
        Me.email_txt.Size = New System.Drawing.Size(258, 20)
        Me.email_txt.TabIndex = 149
        '
        'Zip_lbl
        '
        Me.Zip_lbl.AutoSize = True
        Me.Zip_lbl.Location = New System.Drawing.Point(329, 40)
        Me.Zip_lbl.Name = "Zip_lbl"
        Me.Zip_lbl.Size = New System.Drawing.Size(22, 13)
        Me.Zip_lbl.TabIndex = 148
        Me.Zip_lbl.Text = "Zip"
        '
        'zip_txt
        '
        Me.zip_txt.Enabled = False
        Me.zip_txt.Location = New System.Drawing.Point(395, 33)
        Me.zip_txt.Name = "zip_txt"
        Me.zip_txt.Size = New System.Drawing.Size(258, 20)
        Me.zip_txt.TabIndex = 147
        '
        'State_lbl
        '
        Me.State_lbl.AutoSize = True
        Me.State_lbl.Location = New System.Drawing.Point(329, 14)
        Me.State_lbl.Name = "State_lbl"
        Me.State_lbl.Size = New System.Drawing.Size(32, 13)
        Me.State_lbl.TabIndex = 146
        Me.State_lbl.Text = "State"
        '
        'state_txt
        '
        Me.state_txt.Enabled = False
        Me.state_txt.Location = New System.Drawing.Point(395, 7)
        Me.state_txt.Name = "state_txt"
        Me.state_txt.Size = New System.Drawing.Size(233, 20)
        Me.state_txt.TabIndex = 145
        '
        'City_lbl
        '
        Me.City_lbl.AutoSize = True
        Me.City_lbl.Location = New System.Drawing.Point(16, 66)
        Me.City_lbl.Name = "City_lbl"
        Me.City_lbl.Size = New System.Drawing.Size(24, 13)
        Me.City_lbl.TabIndex = 144
        Me.City_lbl.Text = "City"
        '
        'city_txt
        '
        Me.city_txt.Enabled = False
        Me.city_txt.Location = New System.Drawing.Point(82, 59)
        Me.city_txt.Name = "city_txt"
        Me.city_txt.Size = New System.Drawing.Size(233, 20)
        Me.city_txt.TabIndex = 143
        '
        'Address_lbl
        '
        Me.Address_lbl.AutoSize = True
        Me.Address_lbl.Location = New System.Drawing.Point(16, 40)
        Me.Address_lbl.Name = "Address_lbl"
        Me.Address_lbl.Size = New System.Drawing.Size(45, 13)
        Me.Address_lbl.TabIndex = 142
        Me.Address_lbl.Text = "Address"
        '
        'address_txt
        '
        Me.address_txt.Enabled = False
        Me.address_txt.Location = New System.Drawing.Point(82, 33)
        Me.address_txt.Name = "address_txt"
        Me.address_txt.Size = New System.Drawing.Size(233, 20)
        Me.address_txt.TabIndex = 141
        '
        'Customer_lbl
        '
        Me.Customer_lbl.AutoSize = True
        Me.Customer_lbl.Location = New System.Drawing.Point(16, 14)
        Me.Customer_lbl.Name = "Customer_lbl"
        Me.Customer_lbl.Size = New System.Drawing.Size(51, 13)
        Me.Customer_lbl.TabIndex = 140
        Me.Customer_lbl.Text = "Customer"
        '
        'cusFname_txt
        '
        Me.cusFname_txt.Enabled = False
        Me.cusFname_txt.Location = New System.Drawing.Point(82, 7)
        Me.cusFname_txt.Name = "cusFname_txt"
        Me.cusFname_txt.Size = New System.Drawing.Size(125, 20)
        Me.cusFname_txt.TabIndex = 139
        '
        'dgLate
        '
        Me.dgLate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgLate.Location = New System.Drawing.Point(12, 85)
        Me.dgLate.Name = "dgLate"
        Me.dgLate.Size = New System.Drawing.Size(380, 133)
        Me.dgLate.TabIndex = 138
        '
        'Printrtb_btn
        '
        Me.Printrtb_btn.Location = New System.Drawing.Point(12, 224)
        Me.Printrtb_btn.Name = "Printrtb_btn"
        Me.Printrtb_btn.Size = New System.Drawing.Size(142, 23)
        Me.Printrtb_btn.TabIndex = 137
        Me.Printrtb_btn.Text = "Print Late Notice"
        Me.Printrtb_btn.UseVisualStyleBackColor = True
        '
        'AmtPaid_lbl
        '
        Me.AmtPaid_lbl.AutoSize = True
        Me.AmtPaid_lbl.Location = New System.Drawing.Point(329, 291)
        Me.AmtPaid_lbl.Name = "AmtPaid_lbl"
        Me.AmtPaid_lbl.Size = New System.Drawing.Size(66, 13)
        Me.AmtPaid_lbl.TabIndex = 136
        Me.AmtPaid_lbl.Text = "Amount Due"
        '
        'AmtDue_txt
        '
        Me.AmtDue_txt.Location = New System.Drawing.Point(315, 306)
        Me.AmtDue_txt.Name = "AmtDue_txt"
        Me.AmtDue_txt.Size = New System.Drawing.Size(100, 20)
        Me.AmtDue_txt.TabIndex = 128
        '
        'Test_lbl
        '
        Me.Test_lbl.AutoSize = True
        Me.Test_lbl.Location = New System.Drawing.Point(329, 234)
        Me.Test_lbl.Name = "Test_lbl"
        Me.Test_lbl.Size = New System.Drawing.Size(39, 13)
        Me.Test_lbl.TabIndex = 135
        Me.Test_lbl.Text = "Label1"
        '
        'newduedate_lbl
        '
        Me.newduedate_lbl.AutoSize = True
        Me.newduedate_lbl.Location = New System.Drawing.Point(238, 251)
        Me.newduedate_lbl.Name = "newduedate_lbl"
        Me.newduedate_lbl.Size = New System.Drawing.Size(67, 13)
        Me.newduedate_lbl.TabIndex = 134
        Me.newduedate_lbl.Text = "Current Date"
        '
        'currentdate_txt
        '
        Me.currentdate_txt.Location = New System.Drawing.Point(224, 266)
        Me.currentdate_txt.Name = "currentdate_txt"
        Me.currentdate_txt.Size = New System.Drawing.Size(89, 20)
        Me.currentdate_txt.TabIndex = 127
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 289)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 133
        Me.Label2.Text = "Rent Amount"
        '
        'rentamountL_txt
        '
        Me.rentamountL_txt.Location = New System.Drawing.Point(12, 304)
        Me.rentamountL_txt.Name = "rentamountL_txt"
        Me.rentamountL_txt.Size = New System.Drawing.Size(100, 20)
        Me.rentamountL_txt.TabIndex = 125
        '
        'id_lbl
        '
        Me.id_lbl.AutoSize = True
        Me.id_lbl.Location = New System.Drawing.Point(368, 234)
        Me.id_lbl.Name = "id_lbl"
        Me.id_lbl.Size = New System.Drawing.Size(39, 13)
        Me.id_lbl.TabIndex = 129
        Me.id_lbl.Text = "Label1"
        Me.id_lbl.Visible = False
        '
        'DueDate_lbl
        '
        Me.DueDate_lbl.AutoSize = True
        Me.DueDate_lbl.Location = New System.Drawing.Point(228, 291)
        Me.DueDate_lbl.Name = "DueDate_lbl"
        Me.DueDate_lbl.Size = New System.Drawing.Size(78, 13)
        Me.DueDate_lbl.TabIndex = 132
        Me.DueDate_lbl.Text = "Next Due Date"
        '
        'newrentdate_lbl
        '
        Me.newrentdate_lbl.AutoSize = True
        Me.newrentdate_lbl.Location = New System.Drawing.Point(134, 291)
        Me.newrentdate_lbl.Name = "newrentdate_lbl"
        Me.newrentdate_lbl.Size = New System.Drawing.Size(81, 13)
        Me.newrentdate_lbl.TabIndex = 131
        Me.newrentdate_lbl.Text = "New Rent Date"
        '
        'UnitNum_lbl
        '
        Me.UnitNum_lbl.AutoSize = True
        Me.UnitNum_lbl.Location = New System.Drawing.Point(31, 251)
        Me.UnitNum_lbl.Name = "UnitNum_lbl"
        Me.UnitNum_lbl.Size = New System.Drawing.Size(63, 13)
        Me.UnitNum_lbl.TabIndex = 130
        Me.UnitNum_lbl.Text = "UnitNumber"
        '
        'duedateL_txt
        '
        Me.duedateL_txt.Location = New System.Drawing.Point(224, 306)
        Me.duedateL_txt.Name = "duedateL_txt"
        Me.duedateL_txt.Size = New System.Drawing.Size(89, 20)
        Me.duedateL_txt.TabIndex = 126
        '
        'newrentdate_txt
        '
        Me.newrentdate_txt.Location = New System.Drawing.Point(118, 306)
        Me.newrentdate_txt.Name = "newrentdate_txt"
        Me.newrentdate_txt.Size = New System.Drawing.Size(100, 20)
        Me.newrentdate_txt.TabIndex = 124
        '
        'unitNumL_txt
        '
        Me.unitNumL_txt.Location = New System.Drawing.Point(12, 266)
        Me.unitNumL_txt.Name = "unitNumL_txt"
        Me.unitNumL_txt.Size = New System.Drawing.Size(100, 20)
        Me.unitNumL_txt.TabIndex = 123
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(330, 266)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 122
        Me.Label1.Text = "Late Notice"
        '
        'rtbLateNotice
        '
        Me.rtbLateNotice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rtbLateNotice.Location = New System.Drawing.Point(21, 340)
        Me.rtbLateNotice.Name = "rtbLateNotice"
        Me.rtbLateNotice.ReadOnly = True
        Me.rtbLateNotice.Size = New System.Drawing.Size(380, 67)
        Me.rtbLateNotice.TabIndex = 156
        Me.rtbLateNotice.Text = ""
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
        'PayGrid2
        '
        Me.PayGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PayGrid2.Location = New System.Drawing.Point(413, 82)
        Me.PayGrid2.Name = "PayGrid2"
        Me.PayGrid2.Size = New System.Drawing.Size(418, 133)
        Me.PayGrid2.TabIndex = 157
        '
        'PrtRpt_btn
        '
        Me.PrtRpt_btn.Location = New System.Drawing.Point(413, 224)
        Me.PrtRpt_btn.Name = "PrtRpt_btn"
        Me.PrtRpt_btn.Size = New System.Drawing.Size(160, 23)
        Me.PrtRpt_btn.TabIndex = 158
        Me.PrtRpt_btn.Text = "Print Receipt"
        Me.PrtRpt_btn.UseVisualStyleBackColor = True
        '
        'eRcpt_btn
        '
        Me.eRcpt_btn.Location = New System.Drawing.Point(579, 224)
        Me.eRcpt_btn.Name = "eRcpt_btn"
        Me.eRcpt_btn.Size = New System.Drawing.Size(158, 23)
        Me.eRcpt_btn.TabIndex = 159
        Me.eRcpt_btn.Text = "Email Receipt"
        Me.eRcpt_btn.UseVisualStyleBackColor = True
        '
        'unitNumL1_txt
        '
        Me.unitNumL1_txt.Location = New System.Drawing.Point(414, 269)
        Me.unitNumL1_txt.Name = "unitNumL1_txt"
        Me.unitNumL1_txt.Size = New System.Drawing.Size(100, 20)
        Me.unitNumL1_txt.TabIndex = 160
        '
        'PayAmt_txt
        '
        Me.PayAmt_txt.Location = New System.Drawing.Point(625, 269)
        Me.PayAmt_txt.Name = "PayAmt_txt"
        Me.PayAmt_txt.Size = New System.Drawing.Size(100, 20)
        Me.PayAmt_txt.TabIndex = 161
        '
        'unitPayment_txt
        '
        Me.unitPayment_txt.Location = New System.Drawing.Point(520, 269)
        Me.unitPayment_txt.Name = "unitPayment_txt"
        Me.unitPayment_txt.Size = New System.Drawing.Size(100, 20)
        Me.unitPayment_txt.TabIndex = 162
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(432, 254)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 164
        Me.Label3.Text = "UnitNumber"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(635, 254)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 165
        Me.Label4.Text = "Payment Amount"
        '
        'PayMeth_txt
        '
        Me.PayMeth_txt.AutoSize = True
        Me.PayMeth_txt.Location = New System.Drawing.Point(532, 254)
        Me.PayMeth_txt.Name = "PayMeth_txt"
        Me.PayMeth_txt.Size = New System.Drawing.Size(75, 13)
        Me.PayMeth_txt.TabIndex = 166
        Me.PayMeth_txt.Text = "Payment Type"
        '
        'rtbRcpt
        '
        Me.rtbRcpt.Location = New System.Drawing.Point(422, 341)
        Me.rtbRcpt.Name = "rtbRcpt"
        Me.rtbRcpt.Size = New System.Drawing.Size(409, 67)
        Me.rtbRcpt.TabIndex = 167
        Me.rtbRcpt.Text = ""
        '
        'PrintPreviewDialog2
        '
        Me.PrintPreviewDialog2.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog2.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog2.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog2.Document = Me.PrintDocument2
        Me.PrintPreviewDialog2.Enabled = True
        Me.PrintPreviewDialog2.Icon = CType(resources.GetObject("PrintPreviewDialog2.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog2.Name = "PrintPreviewDialog2"
        Me.PrintPreviewDialog2.Visible = False
        '
        'PrintDocument2
        '
        '
        'rcptDueDate_txt
        '
        Me.rcptDueDate_txt.Location = New System.Drawing.Point(731, 269)
        Me.rcptDueDate_txt.Name = "rcptDueDate_txt"
        Me.rcptDueDate_txt.Size = New System.Drawing.Size(100, 20)
        Me.rcptDueDate_txt.TabIndex = 168
        '
        'rcptDueDate_lbl
        '
        Me.rcptDueDate_lbl.AutoSize = True
        Me.rcptDueDate_lbl.Location = New System.Drawing.Point(747, 254)
        Me.rcptDueDate_lbl.Name = "rcptDueDate_lbl"
        Me.rcptDueDate_lbl.Size = New System.Drawing.Size(78, 13)
        Me.rcptDueDate_lbl.TabIndex = 169
        Me.rcptDueDate_lbl.Text = "New Due Date"
        '
        'Paytemp
        '
        Me.Paytemp.Location = New System.Drawing.Point(701, 56)
        Me.Paytemp.Name = "Paytemp"
        Me.Paytemp.Size = New System.Drawing.Size(100, 20)
        Me.Paytemp.TabIndex = 170
        '
        'LateNotice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 412)
        Me.Controls.Add(Me.Paytemp)
        Me.Controls.Add(Me.rcptDueDate_lbl)
        Me.Controls.Add(Me.rcptDueDate_txt)
        Me.Controls.Add(Me.rtbRcpt)
        Me.Controls.Add(Me.PayMeth_txt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.unitPayment_txt)
        Me.Controls.Add(Me.PayAmt_txt)
        Me.Controls.Add(Me.unitNumL1_txt)
        Me.Controls.Add(Me.eRcpt_btn)
        Me.Controls.Add(Me.PrtRpt_btn)
        Me.Controls.Add(Me.PayGrid2)
        Me.Controls.Add(Me.rtbLateNotice)
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
        Me.Name = "LateNotice"
        Me.Text = "Late Notices"
        CType(Me.dgLate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents rentdata_lbl As Label
    Friend WithEvents rentdate_txt As TextBox
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
    Friend WithEvents dgLate As DataGridView
    Friend WithEvents Printrtb_btn As Button
    Friend WithEvents AmtPaid_lbl As Label
    Friend WithEvents AmtDue_txt As TextBox
    Friend WithEvents Test_lbl As Label
    Friend WithEvents newduedate_lbl As Label
    Friend WithEvents currentdate_txt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents rentamountL_txt As TextBox
    Friend WithEvents id_lbl As Label
    Friend WithEvents DueDate_lbl As Label
    Friend WithEvents newrentdate_lbl As Label
    Friend WithEvents UnitNum_lbl As Label
    Friend WithEvents duedateL_txt As TextBox
    Friend WithEvents newrentdate_txt As TextBox
    Friend WithEvents unitNumL_txt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents rtbLateNotice As RichTextBox
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PayGrid2 As DataGridView
    Friend WithEvents PrtRpt_btn As Button
    Friend WithEvents eRcpt_btn As Button
    Friend WithEvents unitNumL1_txt As TextBox
    Friend WithEvents PayAmt_txt As TextBox
    Friend WithEvents unitPayment_txt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PayMeth_txt As Label
    Friend WithEvents rtbRcpt As RichTextBox
    Friend WithEvents PrintPreviewDialog2 As PrintPreviewDialog
    Friend WithEvents PrintDocument2 As Printing.PrintDocument
    Friend WithEvents rcptDueDate_txt As TextBox
    Friend WithEvents rcptDueDate_lbl As Label
    Friend WithEvents Paytemp As TextBox
End Class
