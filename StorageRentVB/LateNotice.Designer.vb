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
        CType(Me.dgLate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(204, 111)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 23)
        Me.Button1.TabIndex = 154
        Me.Button1.Text = "Email Late Notice"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'rentdata_lbl
        '
        Me.rentdata_lbl.AutoSize = True
        Me.rentdata_lbl.Location = New System.Drawing.Point(148, 282)
        Me.rentdata_lbl.Name = "rentdata_lbl"
        Me.rentdata_lbl.Size = New System.Drawing.Size(56, 13)
        Me.rentdata_lbl.TabIndex = 153
        Me.rentdata_lbl.Text = "Rent Date"
        '
        'rentdate_txt
        '
        Me.rentdate_txt.Location = New System.Drawing.Point(123, 297)
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
        Me.Email_lbl.Location = New System.Drawing.Point(329, 40)
        Me.Email_lbl.Name = "Email_lbl"
        Me.Email_lbl.Size = New System.Drawing.Size(35, 13)
        Me.Email_lbl.TabIndex = 150
        Me.Email_lbl.Text = "E-mail"
        '
        'email_txt
        '
        Me.email_txt.Enabled = False
        Me.email_txt.Location = New System.Drawing.Point(395, 33)
        Me.email_txt.Name = "email_txt"
        Me.email_txt.Size = New System.Drawing.Size(258, 20)
        Me.email_txt.TabIndex = 149
        '
        'Zip_lbl
        '
        Me.Zip_lbl.AutoSize = True
        Me.Zip_lbl.Location = New System.Drawing.Point(329, 14)
        Me.Zip_lbl.Name = "Zip_lbl"
        Me.Zip_lbl.Size = New System.Drawing.Size(22, 13)
        Me.Zip_lbl.TabIndex = 148
        Me.Zip_lbl.Text = "Zip"
        '
        'zip_txt
        '
        Me.zip_txt.Enabled = False
        Me.zip_txt.Location = New System.Drawing.Point(395, 7)
        Me.zip_txt.Name = "zip_txt"
        Me.zip_txt.Size = New System.Drawing.Size(258, 20)
        Me.zip_txt.TabIndex = 147
        '
        'State_lbl
        '
        Me.State_lbl.AutoSize = True
        Me.State_lbl.Location = New System.Drawing.Point(16, 92)
        Me.State_lbl.Name = "State_lbl"
        Me.State_lbl.Size = New System.Drawing.Size(32, 13)
        Me.State_lbl.TabIndex = 146
        Me.State_lbl.Text = "State"
        '
        'state_txt
        '
        Me.state_txt.Enabled = False
        Me.state_txt.Location = New System.Drawing.Point(82, 85)
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
        Me.dgLate.Location = New System.Drawing.Point(8, 140)
        Me.dgLate.Name = "dgLate"
        Me.dgLate.Size = New System.Drawing.Size(655, 133)
        Me.dgLate.TabIndex = 138
        '
        'Printrtb_btn
        '
        Me.Printrtb_btn.Location = New System.Drawing.Point(82, 111)
        Me.Printrtb_btn.Name = "Printrtb_btn"
        Me.Printrtb_btn.Size = New System.Drawing.Size(99, 23)
        Me.Printrtb_btn.TabIndex = 137
        Me.Printrtb_btn.Text = "Print Late Notice"
        Me.Printrtb_btn.UseVisualStyleBackColor = True
        '
        'AmtPaid_lbl
        '
        Me.AmtPaid_lbl.AutoSize = True
        Me.AmtPaid_lbl.Location = New System.Drawing.Point(557, 320)
        Me.AmtPaid_lbl.Name = "AmtPaid_lbl"
        Me.AmtPaid_lbl.Size = New System.Drawing.Size(66, 13)
        Me.AmtPaid_lbl.TabIndex = 136
        Me.AmtPaid_lbl.Text = "Amount Due"
        '
        'AmtDue_txt
        '
        Me.AmtDue_txt.Location = New System.Drawing.Point(543, 335)
        Me.AmtDue_txt.Name = "AmtDue_txt"
        Me.AmtDue_txt.Size = New System.Drawing.Size(100, 20)
        Me.AmtDue_txt.TabIndex = 128
        '
        'Test_lbl
        '
        Me.Test_lbl.AutoSize = True
        Me.Test_lbl.Location = New System.Drawing.Point(608, 358)
        Me.Test_lbl.Name = "Test_lbl"
        Me.Test_lbl.Size = New System.Drawing.Size(39, 13)
        Me.Test_lbl.TabIndex = 135
        Me.Test_lbl.Text = "Label1"
        '
        'newduedate_lbl
        '
        Me.newduedate_lbl.AutoSize = True
        Me.newduedate_lbl.Location = New System.Drawing.Point(451, 282)
        Me.newduedate_lbl.Name = "newduedate_lbl"
        Me.newduedate_lbl.Size = New System.Drawing.Size(67, 13)
        Me.newduedate_lbl.TabIndex = 134
        Me.newduedate_lbl.Text = "Current Date"
        '
        'currentdate_txt
        '
        Me.currentdate_txt.Location = New System.Drawing.Point(437, 297)
        Me.currentdate_txt.Name = "currentdate_txt"
        Me.currentdate_txt.Size = New System.Drawing.Size(100, 20)
        Me.currentdate_txt.TabIndex = 127
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 320)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 133
        Me.Label2.Text = "Rent Amount"
        '
        'rentamountL_txt
        '
        Me.rentamountL_txt.Location = New System.Drawing.Point(17, 335)
        Me.rentamountL_txt.Name = "rentamountL_txt"
        Me.rentamountL_txt.Size = New System.Drawing.Size(100, 20)
        Me.rentamountL_txt.TabIndex = 125
        '
        'id_lbl
        '
        Me.id_lbl.AutoSize = True
        Me.id_lbl.Location = New System.Drawing.Point(508, 358)
        Me.id_lbl.Name = "id_lbl"
        Me.id_lbl.Size = New System.Drawing.Size(39, 13)
        Me.id_lbl.TabIndex = 129
        Me.id_lbl.Text = "Label1"
        Me.id_lbl.Visible = False
        '
        'DueDate_lbl
        '
        Me.DueDate_lbl.AutoSize = True
        Me.DueDate_lbl.Location = New System.Drawing.Point(441, 320)
        Me.DueDate_lbl.Name = "DueDate_lbl"
        Me.DueDate_lbl.Size = New System.Drawing.Size(78, 13)
        Me.DueDate_lbl.TabIndex = 132
        Me.DueDate_lbl.Text = "Next Due Date"
        '
        'newrentdate_lbl
        '
        Me.newrentdate_lbl.AutoSize = True
        Me.newrentdate_lbl.Location = New System.Drawing.Point(139, 320)
        Me.newrentdate_lbl.Name = "newrentdate_lbl"
        Me.newrentdate_lbl.Size = New System.Drawing.Size(81, 13)
        Me.newrentdate_lbl.TabIndex = 131
        Me.newrentdate_lbl.Text = "New Rent Date"
        '
        'UnitNum_lbl
        '
        Me.UnitNum_lbl.AutoSize = True
        Me.UnitNum_lbl.Location = New System.Drawing.Point(36, 282)
        Me.UnitNum_lbl.Name = "UnitNum_lbl"
        Me.UnitNum_lbl.Size = New System.Drawing.Size(63, 13)
        Me.UnitNum_lbl.TabIndex = 130
        Me.UnitNum_lbl.Text = "UnitNumber"
        '
        'duedateL_txt
        '
        Me.duedateL_txt.Location = New System.Drawing.Point(437, 335)
        Me.duedateL_txt.Name = "duedateL_txt"
        Me.duedateL_txt.Size = New System.Drawing.Size(100, 20)
        Me.duedateL_txt.TabIndex = 126
        '
        'newrentdate_txt
        '
        Me.newrentdate_txt.Location = New System.Drawing.Point(123, 335)
        Me.newrentdate_txt.Name = "newrentdate_txt"
        Me.newrentdate_txt.Size = New System.Drawing.Size(100, 20)
        Me.newrentdate_txt.TabIndex = 124
        '
        'unitNumL_txt
        '
        Me.unitNumL_txt.Location = New System.Drawing.Point(17, 297)
        Me.unitNumL_txt.Name = "unitNumL_txt"
        Me.unitNumL_txt.Size = New System.Drawing.Size(100, 20)
        Me.unitNumL_txt.TabIndex = 123
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(329, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 122
        Me.Label1.Text = "Late Notice"
        '
        'rtbLateNotice
        '
        Me.rtbLateNotice.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbLateNotice.Location = New System.Drawing.Point(12, 374)
        Me.rtbLateNotice.Name = "rtbLateNotice"
        Me.rtbLateNotice.ReadOnly = True
        Me.rtbLateNotice.Size = New System.Drawing.Size(644, 242)
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
        'LateNotice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 661)
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
End Class
