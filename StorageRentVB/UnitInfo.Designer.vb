<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UnitInfo
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
        Me.id_lbl = New System.Windows.Forms.Label()
        Me.unitNum_txt = New System.Windows.Forms.TextBox()
        Me.rentdate_txt = New System.Windows.Forms.TextBox()
        Me.duedate_txt = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AmtPaid_lbl = New System.Windows.Forms.Label()
        Me.AmtPaid_txt = New System.Windows.Forms.TextBox()
        Me.Test_lbl = New System.Windows.Forms.Label()
        Me.RBCard_rbtn = New System.Windows.Forms.RadioButton()
        Me.RBCash_rbtn = New System.Windows.Forms.RadioButton()
        Me.RBCheck_rbtn = New System.Windows.Forms.RadioButton()
        Me.newduedate_lbl = New System.Windows.Forms.Label()
        Me.newduedate_txt = New System.Windows.Forms.TextBox()
        Me.Payment_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rentamount_txt = New System.Windows.Forms.TextBox()
        Me.DueDate_lbl = New System.Windows.Forms.Label()
        Me.rentdata_lbl = New System.Windows.Forms.Label()
        Me.UnitNum_lbl = New System.Windows.Forms.Label()
        Me.AddUnit_btn = New System.Windows.Forms.Button()
        Me.updateunit_btn = New System.Windows.Forms.Button()
        Me.delunit_btn = New System.Windows.Forms.Button()
        Me.StallGrid2 = New System.Windows.Forms.DataGridView()
        Me.StallNum_lbl = New System.Windows.Forms.Label()
        Me.RentAmt_lbl = New System.Windows.Forms.Label()
        Me.DateRented_lbl = New System.Windows.Forms.Label()
        Me.DateDue_lbl = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.StallGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cusLname_txt
        '
        Me.cusLname_txt.Enabled = False
        Me.cusLname_txt.Location = New System.Drawing.Point(213, 12)
        Me.cusLname_txt.Name = "cusLname_txt"
        Me.cusLname_txt.Size = New System.Drawing.Size(127, 20)
        Me.cusLname_txt.TabIndex = 38
        '
        'Email_lbl
        '
        Me.Email_lbl.AutoSize = True
        Me.Email_lbl.Location = New System.Drawing.Point(16, 149)
        Me.Email_lbl.Name = "Email_lbl"
        Me.Email_lbl.Size = New System.Drawing.Size(35, 13)
        Me.Email_lbl.TabIndex = 37
        Me.Email_lbl.Text = "E-mail"
        '
        'email_txt
        '
        Me.email_txt.Enabled = False
        Me.email_txt.Location = New System.Drawing.Point(82, 142)
        Me.email_txt.Name = "email_txt"
        Me.email_txt.Size = New System.Drawing.Size(258, 20)
        Me.email_txt.TabIndex = 36
        '
        'Zip_lbl
        '
        Me.Zip_lbl.AutoSize = True
        Me.Zip_lbl.Location = New System.Drawing.Point(16, 123)
        Me.Zip_lbl.Name = "Zip_lbl"
        Me.Zip_lbl.Size = New System.Drawing.Size(22, 13)
        Me.Zip_lbl.TabIndex = 35
        Me.Zip_lbl.Text = "Zip"
        '
        'zip_txt
        '
        Me.zip_txt.Enabled = False
        Me.zip_txt.Location = New System.Drawing.Point(82, 116)
        Me.zip_txt.Name = "zip_txt"
        Me.zip_txt.Size = New System.Drawing.Size(258, 20)
        Me.zip_txt.TabIndex = 34
        '
        'State_lbl
        '
        Me.State_lbl.AutoSize = True
        Me.State_lbl.Location = New System.Drawing.Point(16, 97)
        Me.State_lbl.Name = "State_lbl"
        Me.State_lbl.Size = New System.Drawing.Size(32, 13)
        Me.State_lbl.TabIndex = 33
        Me.State_lbl.Text = "State"
        '
        'state_txt
        '
        Me.state_txt.Enabled = False
        Me.state_txt.Location = New System.Drawing.Point(82, 90)
        Me.state_txt.Name = "state_txt"
        Me.state_txt.Size = New System.Drawing.Size(258, 20)
        Me.state_txt.TabIndex = 32
        '
        'City_lbl
        '
        Me.City_lbl.AutoSize = True
        Me.City_lbl.Location = New System.Drawing.Point(16, 71)
        Me.City_lbl.Name = "City_lbl"
        Me.City_lbl.Size = New System.Drawing.Size(24, 13)
        Me.City_lbl.TabIndex = 31
        Me.City_lbl.Text = "City"
        '
        'city_txt
        '
        Me.city_txt.Enabled = False
        Me.city_txt.Location = New System.Drawing.Point(82, 64)
        Me.city_txt.Name = "city_txt"
        Me.city_txt.Size = New System.Drawing.Size(258, 20)
        Me.city_txt.TabIndex = 30
        '
        'Address_lbl
        '
        Me.Address_lbl.AutoSize = True
        Me.Address_lbl.Location = New System.Drawing.Point(16, 45)
        Me.Address_lbl.Name = "Address_lbl"
        Me.Address_lbl.Size = New System.Drawing.Size(45, 13)
        Me.Address_lbl.TabIndex = 29
        Me.Address_lbl.Text = "Address"
        '
        'address_txt
        '
        Me.address_txt.Enabled = False
        Me.address_txt.Location = New System.Drawing.Point(82, 38)
        Me.address_txt.Name = "address_txt"
        Me.address_txt.Size = New System.Drawing.Size(258, 20)
        Me.address_txt.TabIndex = 28
        '
        'Customer_lbl
        '
        Me.Customer_lbl.AutoSize = True
        Me.Customer_lbl.Location = New System.Drawing.Point(16, 19)
        Me.Customer_lbl.Name = "Customer_lbl"
        Me.Customer_lbl.Size = New System.Drawing.Size(51, 13)
        Me.Customer_lbl.TabIndex = 27
        Me.Customer_lbl.Text = "Customer"
        '
        'cusFname_txt
        '
        Me.cusFname_txt.Enabled = False
        Me.cusFname_txt.Location = New System.Drawing.Point(82, 12)
        Me.cusFname_txt.Name = "cusFname_txt"
        Me.cusFname_txt.Size = New System.Drawing.Size(125, 20)
        Me.cusFname_txt.TabIndex = 26
        '
        'id_lbl
        '
        Me.id_lbl.AutoSize = True
        Me.id_lbl.Location = New System.Drawing.Point(25, 147)
        Me.id_lbl.Name = "id_lbl"
        Me.id_lbl.Size = New System.Drawing.Size(39, 13)
        Me.id_lbl.TabIndex = 39
        Me.id_lbl.Text = "Label1"
        Me.id_lbl.Visible = False
        '
        'unitNum_txt
        '
        Me.unitNum_txt.Location = New System.Drawing.Point(7, 26)
        Me.unitNum_txt.Name = "unitNum_txt"
        Me.unitNum_txt.Size = New System.Drawing.Size(100, 20)
        Me.unitNum_txt.TabIndex = 1
        '
        'rentdate_txt
        '
        Me.rentdate_txt.Location = New System.Drawing.Point(113, 26)
        Me.rentdate_txt.Name = "rentdate_txt"
        Me.rentdate_txt.Size = New System.Drawing.Size(100, 20)
        Me.rentdate_txt.TabIndex = 2
        '
        'duedate_txt
        '
        Me.duedate_txt.Location = New System.Drawing.Point(7, 95)
        Me.duedate_txt.Name = "duedate_txt"
        Me.duedate_txt.Size = New System.Drawing.Size(100, 20)
        Me.duedate_txt.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.AmtPaid_lbl)
        Me.Panel1.Controls.Add(Me.AmtPaid_txt)
        Me.Panel1.Controls.Add(Me.Test_lbl)
        Me.Panel1.Controls.Add(Me.RBCard_rbtn)
        Me.Panel1.Controls.Add(Me.RBCash_rbtn)
        Me.Panel1.Controls.Add(Me.RBCheck_rbtn)
        Me.Panel1.Controls.Add(Me.newduedate_lbl)
        Me.Panel1.Controls.Add(Me.newduedate_txt)
        Me.Panel1.Controls.Add(Me.Payment_btn)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.rentamount_txt)
        Me.Panel1.Controls.Add(Me.id_lbl)
        Me.Panel1.Controls.Add(Me.DueDate_lbl)
        Me.Panel1.Controls.Add(Me.rentdata_lbl)
        Me.Panel1.Controls.Add(Me.UnitNum_lbl)
        Me.Panel1.Controls.Add(Me.duedate_txt)
        Me.Panel1.Controls.Add(Me.rentdate_txt)
        Me.Panel1.Controls.Add(Me.unitNum_txt)
        Me.Panel1.Location = New System.Drawing.Point(18, 325)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(321, 179)
        Me.Panel1.TabIndex = 43
        '
        'AmtPaid_lbl
        '
        Me.AmtPaid_lbl.AutoSize = True
        Me.AmtPaid_lbl.Location = New System.Drawing.Point(231, 79)
        Me.AmtPaid_lbl.Name = "AmtPaid_lbl"
        Me.AmtPaid_lbl.Size = New System.Drawing.Size(67, 13)
        Me.AmtPaid_lbl.TabIndex = 72
        Me.AmtPaid_lbl.Text = "Amount Paid"
        '
        'AmtPaid_txt
        '
        Me.AmtPaid_txt.Location = New System.Drawing.Point(218, 95)
        Me.AmtPaid_txt.Name = "AmtPaid_txt"
        Me.AmtPaid_txt.Size = New System.Drawing.Size(100, 20)
        Me.AmtPaid_txt.TabIndex = 6
        '
        'Test_lbl
        '
        Me.Test_lbl.AutoSize = True
        Me.Test_lbl.Location = New System.Drawing.Point(240, 147)
        Me.Test_lbl.Name = "Test_lbl"
        Me.Test_lbl.Size = New System.Drawing.Size(39, 13)
        Me.Test_lbl.TabIndex = 70
        Me.Test_lbl.Text = "Label1"
        '
        'RBCard_rbtn
        '
        Me.RBCard_rbtn.AutoSize = True
        Me.RBCard_rbtn.Location = New System.Drawing.Point(146, 121)
        Me.RBCard_rbtn.Name = "RBCard_rbtn"
        Me.RBCard_rbtn.Size = New System.Drawing.Size(47, 17)
        Me.RBCard_rbtn.TabIndex = 69
        Me.RBCard_rbtn.TabStop = True
        Me.RBCard_rbtn.Text = "Card"
        Me.RBCard_rbtn.UseVisualStyleBackColor = True
        '
        'RBCash_rbtn
        '
        Me.RBCash_rbtn.AutoSize = True
        Me.RBCash_rbtn.Location = New System.Drawing.Point(90, 121)
        Me.RBCash_rbtn.Name = "RBCash_rbtn"
        Me.RBCash_rbtn.Size = New System.Drawing.Size(49, 17)
        Me.RBCash_rbtn.TabIndex = 68
        Me.RBCash_rbtn.TabStop = True
        Me.RBCash_rbtn.Text = "Cash"
        Me.RBCash_rbtn.UseVisualStyleBackColor = True
        '
        'RBCheck_rbtn
        '
        Me.RBCheck_rbtn.AutoSize = True
        Me.RBCheck_rbtn.Location = New System.Drawing.Point(28, 121)
        Me.RBCheck_rbtn.Name = "RBCheck_rbtn"
        Me.RBCheck_rbtn.Size = New System.Drawing.Size(56, 17)
        Me.RBCheck_rbtn.TabIndex = 67
        Me.RBCheck_rbtn.TabStop = True
        Me.RBCheck_rbtn.Text = "Check"
        Me.RBCheck_rbtn.UseVisualStyleBackColor = True
        '
        'newduedate_lbl
        '
        Me.newduedate_lbl.AutoSize = True
        Me.newduedate_lbl.Location = New System.Drawing.Point(126, 79)
        Me.newduedate_lbl.Name = "newduedate_lbl"
        Me.newduedate_lbl.Size = New System.Drawing.Size(78, 13)
        Me.newduedate_lbl.TabIndex = 50
        Me.newduedate_lbl.Text = "New Due Date"
        '
        'newduedate_txt
        '
        Me.newduedate_txt.Location = New System.Drawing.Point(113, 95)
        Me.newduedate_txt.Name = "newduedate_txt"
        Me.newduedate_txt.Size = New System.Drawing.Size(100, 20)
        Me.newduedate_txt.TabIndex = 5
        '
        'Payment_btn
        '
        Me.Payment_btn.Location = New System.Drawing.Point(113, 142)
        Me.Payment_btn.Name = "Payment_btn"
        Me.Payment_btn.Size = New System.Drawing.Size(100, 23)
        Me.Payment_btn.TabIndex = 48
        Me.Payment_btn.Text = "Rent Payment"
        Me.Payment_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(240, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Rent Amount"
        '
        'rentamount_txt
        '
        Me.rentamount_txt.Location = New System.Drawing.Point(216, 26)
        Me.rentamount_txt.Name = "rentamount_txt"
        Me.rentamount_txt.Size = New System.Drawing.Size(100, 20)
        Me.rentamount_txt.TabIndex = 3
        '
        'DueDate_lbl
        '
        Me.DueDate_lbl.AutoSize = True
        Me.DueDate_lbl.Location = New System.Drawing.Point(10, 79)
        Me.DueDate_lbl.Name = "DueDate_lbl"
        Me.DueDate_lbl.Size = New System.Drawing.Size(78, 13)
        Me.DueDate_lbl.TabIndex = 45
        Me.DueDate_lbl.Text = "Next Due Date"
        '
        'rentdata_lbl
        '
        Me.rentdata_lbl.AutoSize = True
        Me.rentdata_lbl.Location = New System.Drawing.Point(137, 10)
        Me.rentdata_lbl.Name = "rentdata_lbl"
        Me.rentdata_lbl.Size = New System.Drawing.Size(56, 13)
        Me.rentdata_lbl.TabIndex = 44
        Me.rentdata_lbl.Text = "Rent Date"
        '
        'UnitNum_lbl
        '
        Me.UnitNum_lbl.AutoSize = True
        Me.UnitNum_lbl.Location = New System.Drawing.Point(25, 10)
        Me.UnitNum_lbl.Name = "UnitNum_lbl"
        Me.UnitNum_lbl.Size = New System.Drawing.Size(63, 13)
        Me.UnitNum_lbl.TabIndex = 43
        Me.UnitNum_lbl.Text = "UnitNumber"
        '
        'AddUnit_btn
        '
        Me.AddUnit_btn.Location = New System.Drawing.Point(25, 510)
        Me.AddUnit_btn.Name = "AddUnit_btn"
        Me.AddUnit_btn.Size = New System.Drawing.Size(100, 23)
        Me.AddUnit_btn.TabIndex = 44
        Me.AddUnit_btn.Text = "Add Unit"
        Me.AddUnit_btn.UseVisualStyleBackColor = True
        '
        'updateunit_btn
        '
        Me.updateunit_btn.Location = New System.Drawing.Point(131, 510)
        Me.updateunit_btn.Name = "updateunit_btn"
        Me.updateunit_btn.Size = New System.Drawing.Size(100, 23)
        Me.updateunit_btn.TabIndex = 45
        Me.updateunit_btn.Text = "Update Unit"
        Me.updateunit_btn.UseVisualStyleBackColor = True
        '
        'delunit_btn
        '
        Me.delunit_btn.Location = New System.Drawing.Point(237, 510)
        Me.delunit_btn.Name = "delunit_btn"
        Me.delunit_btn.Size = New System.Drawing.Size(100, 23)
        Me.delunit_btn.TabIndex = 46
        Me.delunit_btn.Text = "Delete Unit"
        Me.delunit_btn.UseVisualStyleBackColor = True
        '
        'StallGrid2
        '
        Me.StallGrid2.AllowUserToAddRows = False
        Me.StallGrid2.AllowUserToDeleteRows = False
        Me.StallGrid2.AllowUserToResizeColumns = False
        Me.StallGrid2.AllowUserToResizeRows = False
        Me.StallGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StallGrid2.Location = New System.Drawing.Point(18, 202)
        Me.StallGrid2.Name = "StallGrid2"
        Me.StallGrid2.Size = New System.Drawing.Size(320, 117)
        Me.StallGrid2.TabIndex = 47
        '
        'StallNum_lbl
        '
        Me.StallNum_lbl.AutoSize = True
        Me.StallNum_lbl.Location = New System.Drawing.Point(22, 186)
        Me.StallNum_lbl.Name = "StallNum_lbl"
        Me.StallNum_lbl.Size = New System.Drawing.Size(66, 13)
        Me.StallNum_lbl.TabIndex = 48
        Me.StallNum_lbl.Text = "Unit Number"
        '
        'RentAmt_lbl
        '
        Me.RentAmt_lbl.AutoSize = True
        Me.RentAmt_lbl.Location = New System.Drawing.Point(96, 186)
        Me.RentAmt_lbl.Name = "RentAmt_lbl"
        Me.RentAmt_lbl.Size = New System.Drawing.Size(69, 13)
        Me.RentAmt_lbl.TabIndex = 49
        Me.RentAmt_lbl.Text = "Rent Amount"
        '
        'DateRented_lbl
        '
        Me.DateRented_lbl.AutoSize = True
        Me.DateRented_lbl.Location = New System.Drawing.Point(172, 186)
        Me.DateRented_lbl.Name = "DateRented_lbl"
        Me.DateRented_lbl.Size = New System.Drawing.Size(68, 13)
        Me.DateRented_lbl.TabIndex = 50
        Me.DateRented_lbl.Text = "Date Rented"
        '
        'DateDue_lbl
        '
        Me.DateDue_lbl.AutoSize = True
        Me.DateDue_lbl.Location = New System.Drawing.Point(258, 186)
        Me.DateDue_lbl.Name = "DateDue_lbl"
        Me.DateDue_lbl.Size = New System.Drawing.Size(53, 13)
        Me.DateDue_lbl.TabIndex = 51
        Me.DateDue_lbl.Text = "Date Due"
        '
        'UnitInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 545)
        Me.Controls.Add(Me.DateDue_lbl)
        Me.Controls.Add(Me.DateRented_lbl)
        Me.Controls.Add(Me.RentAmt_lbl)
        Me.Controls.Add(Me.StallNum_lbl)
        Me.Controls.Add(Me.StallGrid2)
        Me.Controls.Add(Me.delunit_btn)
        Me.Controls.Add(Me.updateunit_btn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.AddUnit_btn)
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
        Me.Name = "UnitInfo"
        Me.Text = "Huff Mini Storage -Rent Payment"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.StallGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
    Friend WithEvents id_lbl As Label
    Friend WithEvents unitNum_txt As TextBox
    Friend WithEvents rentdate_txt As TextBox
    Friend WithEvents duedate_txt As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents AddUnit_btn As Button
    Friend WithEvents DueDate_lbl As Label
    Friend WithEvents rentdata_lbl As Label
    Friend WithEvents UnitNum_lbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents rentamount_txt As TextBox
    Friend WithEvents updateunit_btn As Button
    Friend WithEvents delunit_btn As Button
    Friend WithEvents StallGrid2 As DataGridView
    Friend WithEvents Payment_btn As Button
    Friend WithEvents newduedate_lbl As Label
    Friend WithEvents newduedate_txt As TextBox
    Friend WithEvents RBCard_rbtn As RadioButton
    Friend WithEvents RBCash_rbtn As RadioButton
    Friend WithEvents RBCheck_rbtn As RadioButton
    Friend WithEvents Test_lbl As Label
    Friend WithEvents AmtPaid_lbl As Label
    Friend WithEvents AmtPaid_txt As TextBox
    Friend WithEvents StallNum_lbl As Label
    Friend WithEvents RentAmt_lbl As Label
    Friend WithEvents DateRented_lbl As Label
    Friend WithEvents DateDue_lbl As Label
End Class
