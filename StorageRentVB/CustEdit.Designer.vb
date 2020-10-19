<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustEdit
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
        Me.cusLname_txt = New System.Windows.Forms.TextBox()
        Me.id_lbl = New System.Windows.Forms.Label()
        Me.Save_btn = New System.Windows.Forms.Button()
        Me.Phone_lbl = New System.Windows.Forms.Label()
        Me.Phone_txt = New System.Windows.Forms.TextBox()
        Me.DLSS_txt = New System.Windows.Forms.TextBox()
        Me.DLSS_lbl = New System.Windows.Forms.Label()
        Me.AddNew_btn = New System.Windows.Forms.Button()
        Me.SaveNew_btn = New System.Windows.Forms.Button()
        Me.rentergrid2 = New System.Windows.Forms.DataGridView()
        Me.StallAdd = New System.Windows.Forms.Button()
        CType(Me.rentergrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Email_lbl
        '
        Me.Email_lbl.AutoSize = True
        Me.Email_lbl.Location = New System.Drawing.Point(12, 149)
        Me.Email_lbl.Name = "Email_lbl"
        Me.Email_lbl.Size = New System.Drawing.Size(35, 13)
        Me.Email_lbl.TabIndex = 24
        Me.Email_lbl.Text = "E-mail"
        '
        'email_txt
        '
        Me.email_txt.Enabled = False
        Me.email_txt.Location = New System.Drawing.Point(78, 142)
        Me.email_txt.Name = "email_txt"
        Me.email_txt.Size = New System.Drawing.Size(224, 20)
        Me.email_txt.TabIndex = 8
        '
        'Zip_lbl
        '
        Me.Zip_lbl.AutoSize = True
        Me.Zip_lbl.Location = New System.Drawing.Point(121, 93)
        Me.Zip_lbl.Name = "Zip_lbl"
        Me.Zip_lbl.Size = New System.Drawing.Size(22, 13)
        Me.Zip_lbl.TabIndex = 22
        Me.Zip_lbl.Text = "Zip"
        '
        'zip_txt
        '
        Me.zip_txt.Enabled = False
        Me.zip_txt.Location = New System.Drawing.Point(148, 89)
        Me.zip_txt.Name = "zip_txt"
        Me.zip_txt.Size = New System.Drawing.Size(154, 20)
        Me.zip_txt.TabIndex = 6
        '
        'State_lbl
        '
        Me.State_lbl.AutoSize = True
        Me.State_lbl.Location = New System.Drawing.Point(12, 97)
        Me.State_lbl.Name = "State_lbl"
        Me.State_lbl.Size = New System.Drawing.Size(32, 13)
        Me.State_lbl.TabIndex = 20
        Me.State_lbl.Text = "State"
        '
        'state_txt
        '
        Me.state_txt.Enabled = False
        Me.state_txt.Location = New System.Drawing.Point(78, 90)
        Me.state_txt.Name = "state_txt"
        Me.state_txt.Size = New System.Drawing.Size(30, 20)
        Me.state_txt.TabIndex = 5
        '
        'City_lbl
        '
        Me.City_lbl.AutoSize = True
        Me.City_lbl.Location = New System.Drawing.Point(12, 71)
        Me.City_lbl.Name = "City_lbl"
        Me.City_lbl.Size = New System.Drawing.Size(24, 13)
        Me.City_lbl.TabIndex = 18
        Me.City_lbl.Text = "City"
        '
        'city_txt
        '
        Me.city_txt.Enabled = False
        Me.city_txt.Location = New System.Drawing.Point(78, 64)
        Me.city_txt.Name = "city_txt"
        Me.city_txt.Size = New System.Drawing.Size(224, 20)
        Me.city_txt.TabIndex = 4
        '
        'Address_lbl
        '
        Me.Address_lbl.AutoSize = True
        Me.Address_lbl.Location = New System.Drawing.Point(12, 45)
        Me.Address_lbl.Name = "Address_lbl"
        Me.Address_lbl.Size = New System.Drawing.Size(45, 13)
        Me.Address_lbl.TabIndex = 16
        Me.Address_lbl.Text = "Address"
        '
        'address_txt
        '
        Me.address_txt.Enabled = False
        Me.address_txt.Location = New System.Drawing.Point(78, 38)
        Me.address_txt.Name = "address_txt"
        Me.address_txt.Size = New System.Drawing.Size(224, 20)
        Me.address_txt.TabIndex = 3
        '
        'Customer_lbl
        '
        Me.Customer_lbl.AutoSize = True
        Me.Customer_lbl.Location = New System.Drawing.Point(12, 19)
        Me.Customer_lbl.Name = "Customer_lbl"
        Me.Customer_lbl.Size = New System.Drawing.Size(51, 13)
        Me.Customer_lbl.TabIndex = 14
        Me.Customer_lbl.Text = "Customer"
        '
        'cusFname_txt
        '
        Me.cusFname_txt.Enabled = False
        Me.cusFname_txt.Location = New System.Drawing.Point(78, 12)
        Me.cusFname_txt.Name = "cusFname_txt"
        Me.cusFname_txt.Size = New System.Drawing.Size(91, 20)
        Me.cusFname_txt.TabIndex = 1
        '
        'cusLname_txt
        '
        Me.cusLname_txt.Enabled = False
        Me.cusLname_txt.Location = New System.Drawing.Point(175, 12)
        Me.cusLname_txt.Name = "cusLname_txt"
        Me.cusLname_txt.Size = New System.Drawing.Size(127, 20)
        Me.cusLname_txt.TabIndex = 2
        '
        'id_lbl
        '
        Me.id_lbl.AutoSize = True
        Me.id_lbl.Location = New System.Drawing.Point(18, 448)
        Me.id_lbl.Name = "id_lbl"
        Me.id_lbl.Size = New System.Drawing.Size(39, 13)
        Me.id_lbl.TabIndex = 26
        Me.id_lbl.Text = "Label1"
        Me.id_lbl.Visible = False
        '
        'Save_btn
        '
        Me.Save_btn.Location = New System.Drawing.Point(12, 202)
        Me.Save_btn.Name = "Save_btn"
        Me.Save_btn.Size = New System.Drawing.Size(69, 23)
        Me.Save_btn.TabIndex = 27
        Me.Save_btn.Text = "Update"
        Me.Save_btn.UseVisualStyleBackColor = True
        '
        'Phone_lbl
        '
        Me.Phone_lbl.AutoSize = True
        Me.Phone_lbl.Location = New System.Drawing.Point(12, 123)
        Me.Phone_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Phone_lbl.Name = "Phone_lbl"
        Me.Phone_lbl.Size = New System.Drawing.Size(38, 13)
        Me.Phone_lbl.TabIndex = 28
        Me.Phone_lbl.Text = "Phone"
        '
        'Phone_txt
        '
        Me.Phone_txt.Location = New System.Drawing.Point(78, 119)
        Me.Phone_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.Phone_txt.Name = "Phone_txt"
        Me.Phone_txt.Size = New System.Drawing.Size(224, 20)
        Me.Phone_txt.TabIndex = 7
        '
        'DLSS_txt
        '
        Me.DLSS_txt.Location = New System.Drawing.Point(78, 169)
        Me.DLSS_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.DLSS_txt.Name = "DLSS_txt"
        Me.DLSS_txt.Size = New System.Drawing.Size(224, 20)
        Me.DLSS_txt.TabIndex = 9
        '
        'DLSS_lbl
        '
        Me.DLSS_lbl.AutoSize = True
        Me.DLSS_lbl.Location = New System.Drawing.Point(10, 173)
        Me.DLSS_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DLSS_lbl.Name = "DLSS_lbl"
        Me.DLSS_lbl.Size = New System.Drawing.Size(56, 13)
        Me.DLSS_lbl.TabIndex = 31
        Me.DLSS_lbl.Text = "DL / SS #"
        '
        'AddNew_btn
        '
        Me.AddNew_btn.Location = New System.Drawing.Point(147, 202)
        Me.AddNew_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.AddNew_btn.Name = "AddNew_btn"
        Me.AddNew_btn.Size = New System.Drawing.Size(75, 23)
        Me.AddNew_btn.TabIndex = 32
        Me.AddNew_btn.Text = "Add Renter"
        Me.AddNew_btn.UseVisualStyleBackColor = True
        '
        'SaveNew_btn
        '
        Me.SaveNew_btn.Location = New System.Drawing.Point(227, 202)
        Me.SaveNew_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.SaveNew_btn.Name = "SaveNew_btn"
        Me.SaveNew_btn.Size = New System.Drawing.Size(75, 23)
        Me.SaveNew_btn.TabIndex = 33
        Me.SaveNew_btn.Text = "Save Renter"
        Me.SaveNew_btn.UseVisualStyleBackColor = True
        '
        'rentergrid2
        '
        Me.rentergrid2.AllowUserToAddRows = False
        Me.rentergrid2.AllowUserToDeleteRows = False
        Me.rentergrid2.AllowUserToResizeColumns = False
        Me.rentergrid2.AllowUserToResizeRows = False
        Me.rentergrid2.BackgroundColor = System.Drawing.SystemColors.Menu
        Me.rentergrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.rentergrid2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.rentergrid2.Location = New System.Drawing.Point(13, 232)
        Me.rentergrid2.Margin = New System.Windows.Forms.Padding(0)
        Me.rentergrid2.MultiSelect = False
        Me.rentergrid2.Name = "rentergrid2"
        Me.rentergrid2.RowHeadersWidth = 51
        Me.rentergrid2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.rentergrid2.Size = New System.Drawing.Size(289, 214)
        Me.rentergrid2.TabIndex = 34
        '
        'StallAdd
        '
        Me.StallAdd.Location = New System.Drawing.Point(83, 202)
        Me.StallAdd.Name = "StallAdd"
        Me.StallAdd.Size = New System.Drawing.Size(60, 23)
        Me.StallAdd.TabIndex = 35
        Me.StallAdd.Text = "Add Stall"
        Me.StallAdd.UseVisualStyleBackColor = True
        '
        'CustEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 470)
        Me.Controls.Add(Me.StallAdd)
        Me.Controls.Add(Me.rentergrid2)
        Me.Controls.Add(Me.SaveNew_btn)
        Me.Controls.Add(Me.AddNew_btn)
        Me.Controls.Add(Me.DLSS_lbl)
        Me.Controls.Add(Me.DLSS_txt)
        Me.Controls.Add(Me.Phone_txt)
        Me.Controls.Add(Me.Phone_lbl)
        Me.Controls.Add(Me.Save_btn)
        Me.Controls.Add(Me.id_lbl)
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
        Me.Name = "CustEdit"
        Me.Text = "Huff Mini Storage - Edit Renter"
        CType(Me.rentergrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
    Friend WithEvents cusLname_txt As TextBox
    Friend WithEvents id_lbl As Label
    Friend WithEvents Save_btn As Button
    Friend WithEvents Phone_lbl As Label
    Friend WithEvents Phone_txt As TextBox
    Friend WithEvents DLSS_txt As TextBox
    Friend WithEvents DLSS_lbl As Label
    Friend WithEvents AddNew_btn As Button
    Friend WithEvents SaveNew_btn As Button
    Friend WithEvents rentergrid2 As DataGridView
    Friend WithEvents StallAdd As Button
End Class
