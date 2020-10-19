<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HMSMain
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
        Me.customer_txt = New System.Windows.Forms.TextBox()
        Me.Customer_lbl = New System.Windows.Forms.Label()
        Me.Address_lbl = New System.Windows.Forms.Label()
        Me.address_txt = New System.Windows.Forms.TextBox()
        Me.City_lbl = New System.Windows.Forms.Label()
        Me.city_txt = New System.Windows.Forms.TextBox()
        Me.State_lbl = New System.Windows.Forms.Label()
        Me.state_txt = New System.Windows.Forms.TextBox()
        Me.Zip_lbl = New System.Windows.Forms.Label()
        Me.zip_txt = New System.Windows.Forms.TextBox()
        Me.Email_lbl = New System.Windows.Forms.Label()
        Me.email_txt = New System.Windows.Forms.TextBox()
        Me.updateunit_btn = New System.Windows.Forms.Button()
        Me.rentergrid1 = New System.Windows.Forms.DataGridView()
        Me.StallGrid1 = New System.Windows.Forms.DataGridView()
        Me.CusNew_btn = New System.Windows.Forms.Button()
        Me.CusEdit_btn = New System.Windows.Forms.Button()
        Me.CusDelete_btn = New System.Windows.Forms.Button()
        Me.CusPayment_btn = New System.Windows.Forms.Button()
        Me.PayGrid1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.id_lbl = New System.Windows.Forms.Label()
        Me.DLSS_lbl = New System.Windows.Forms.Label()
        Me.DLSS_txt = New System.Windows.Forms.TextBox()
        Me.Phone_txt = New System.Windows.Forms.TextBox()
        Me.Phone_lbl = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.rentergrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StallGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'customer_txt
        '
        Me.customer_txt.Enabled = False
        Me.customer_txt.Location = New System.Drawing.Point(77, 56)
        Me.customer_txt.Name = "customer_txt"
        Me.customer_txt.Size = New System.Drawing.Size(255, 20)
        Me.customer_txt.TabIndex = 1
        '
        'Customer_lbl
        '
        Me.Customer_lbl.AutoSize = True
        Me.Customer_lbl.Location = New System.Drawing.Point(11, 63)
        Me.Customer_lbl.Name = "Customer_lbl"
        Me.Customer_lbl.Size = New System.Drawing.Size(51, 13)
        Me.Customer_lbl.TabIndex = 2
        Me.Customer_lbl.Text = "Customer"
        '
        'Address_lbl
        '
        Me.Address_lbl.AutoSize = True
        Me.Address_lbl.Location = New System.Drawing.Point(11, 89)
        Me.Address_lbl.Name = "Address_lbl"
        Me.Address_lbl.Size = New System.Drawing.Size(45, 13)
        Me.Address_lbl.TabIndex = 4
        Me.Address_lbl.Text = "Address"
        '
        'address_txt
        '
        Me.address_txt.Enabled = False
        Me.address_txt.Location = New System.Drawing.Point(77, 82)
        Me.address_txt.Name = "address_txt"
        Me.address_txt.Size = New System.Drawing.Size(255, 20)
        Me.address_txt.TabIndex = 3
        '
        'City_lbl
        '
        Me.City_lbl.AutoSize = True
        Me.City_lbl.Location = New System.Drawing.Point(11, 115)
        Me.City_lbl.Name = "City_lbl"
        Me.City_lbl.Size = New System.Drawing.Size(24, 13)
        Me.City_lbl.TabIndex = 6
        Me.City_lbl.Text = "City"
        '
        'city_txt
        '
        Me.city_txt.Enabled = False
        Me.city_txt.Location = New System.Drawing.Point(77, 108)
        Me.city_txt.Name = "city_txt"
        Me.city_txt.Size = New System.Drawing.Size(255, 20)
        Me.city_txt.TabIndex = 5
        '
        'State_lbl
        '
        Me.State_lbl.AutoSize = True
        Me.State_lbl.Location = New System.Drawing.Point(11, 140)
        Me.State_lbl.Name = "State_lbl"
        Me.State_lbl.Size = New System.Drawing.Size(32, 13)
        Me.State_lbl.TabIndex = 8
        Me.State_lbl.Text = "State"
        '
        'state_txt
        '
        Me.state_txt.Enabled = False
        Me.state_txt.Location = New System.Drawing.Point(77, 134)
        Me.state_txt.Name = "state_txt"
        Me.state_txt.Size = New System.Drawing.Size(41, 20)
        Me.state_txt.TabIndex = 7
        '
        'Zip_lbl
        '
        Me.Zip_lbl.AutoSize = True
        Me.Zip_lbl.Location = New System.Drawing.Point(123, 137)
        Me.Zip_lbl.Name = "Zip_lbl"
        Me.Zip_lbl.Size = New System.Drawing.Size(22, 13)
        Me.Zip_lbl.TabIndex = 10
        Me.Zip_lbl.Text = "Zip"
        '
        'zip_txt
        '
        Me.zip_txt.Enabled = False
        Me.zip_txt.Location = New System.Drawing.Point(150, 133)
        Me.zip_txt.Name = "zip_txt"
        Me.zip_txt.Size = New System.Drawing.Size(182, 20)
        Me.zip_txt.TabIndex = 9
        '
        'Email_lbl
        '
        Me.Email_lbl.AutoSize = True
        Me.Email_lbl.Location = New System.Drawing.Point(11, 193)
        Me.Email_lbl.Name = "Email_lbl"
        Me.Email_lbl.Size = New System.Drawing.Size(35, 13)
        Me.Email_lbl.TabIndex = 12
        Me.Email_lbl.Text = "E-mail"
        '
        'email_txt
        '
        Me.email_txt.Enabled = False
        Me.email_txt.Location = New System.Drawing.Point(77, 186)
        Me.email_txt.Name = "email_txt"
        Me.email_txt.Size = New System.Drawing.Size(255, 20)
        Me.email_txt.TabIndex = 11
        '
        'updateunit_btn
        '
        Me.updateunit_btn.Location = New System.Drawing.Point(450, 28)
        Me.updateunit_btn.Name = "updateunit_btn"
        Me.updateunit_btn.Size = New System.Drawing.Size(88, 23)
        Me.updateunit_btn.TabIndex = 14
        Me.updateunit_btn.Text = "Unit Information"
        Me.updateunit_btn.UseVisualStyleBackColor = True
        '
        'rentergrid1
        '
        Me.rentergrid1.AllowUserToAddRows = False
        Me.rentergrid1.AllowUserToDeleteRows = False
        Me.rentergrid1.AllowUserToResizeColumns = False
        Me.rentergrid1.AllowUserToResizeRows = False
        Me.rentergrid1.BackgroundColor = System.Drawing.SystemColors.Menu
        Me.rentergrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.rentergrid1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.rentergrid1.Location = New System.Drawing.Point(424, 252)
        Me.rentergrid1.Margin = New System.Windows.Forms.Padding(0)
        Me.rentergrid1.MultiSelect = False
        Me.rentergrid1.Name = "rentergrid1"
        Me.rentergrid1.RowHeadersWidth = 51
        Me.rentergrid1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.rentergrid1.Size = New System.Drawing.Size(135, 167)
        Me.rentergrid1.TabIndex = 16
        '
        'StallGrid1
        '
        Me.StallGrid1.AllowUserToAddRows = False
        Me.StallGrid1.AllowUserToDeleteRows = False
        Me.StallGrid1.AllowUserToResizeColumns = False
        Me.StallGrid1.AllowUserToResizeRows = False
        Me.StallGrid1.BackgroundColor = System.Drawing.SystemColors.MenuBar
        Me.StallGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StallGrid1.Location = New System.Drawing.Point(338, 80)
        Me.StallGrid1.Name = "StallGrid1"
        Me.StallGrid1.RowHeadersWidth = 51
        Me.StallGrid1.Size = New System.Drawing.Size(221, 150)
        Me.StallGrid1.TabIndex = 18
        '
        'CusNew_btn
        '
        Me.CusNew_btn.Location = New System.Drawing.Point(14, 28)
        Me.CusNew_btn.Name = "CusNew_btn"
        Me.CusNew_btn.Size = New System.Drawing.Size(75, 23)
        Me.CusNew_btn.TabIndex = 20
        Me.CusNew_btn.Text = "New"
        Me.CusNew_btn.UseVisualStyleBackColor = True
        '
        'CusEdit_btn
        '
        Me.CusEdit_btn.Location = New System.Drawing.Point(95, 28)
        Me.CusEdit_btn.Name = "CusEdit_btn"
        Me.CusEdit_btn.Size = New System.Drawing.Size(75, 23)
        Me.CusEdit_btn.TabIndex = 21
        Me.CusEdit_btn.Text = "Edit"
        Me.CusEdit_btn.UseVisualStyleBackColor = True
        '
        'CusDelete_btn
        '
        Me.CusDelete_btn.Location = New System.Drawing.Point(257, 28)
        Me.CusDelete_btn.Name = "CusDelete_btn"
        Me.CusDelete_btn.Size = New System.Drawing.Size(75, 23)
        Me.CusDelete_btn.TabIndex = 22
        Me.CusDelete_btn.Text = "Delete"
        Me.CusDelete_btn.UseVisualStyleBackColor = True
        '
        'CusPayment_btn
        '
        Me.CusPayment_btn.Location = New System.Drawing.Point(176, 28)
        Me.CusPayment_btn.Name = "CusPayment_btn"
        Me.CusPayment_btn.Size = New System.Drawing.Size(75, 23)
        Me.CusPayment_btn.TabIndex = 23
        Me.CusPayment_btn.Text = "Payment"
        Me.CusPayment_btn.UseVisualStyleBackColor = True
        '
        'PayGrid1
        '
        Me.PayGrid1.AllowUserToAddRows = False
        Me.PayGrid1.AllowUserToDeleteRows = False
        Me.PayGrid1.AllowUserToResizeColumns = False
        Me.PayGrid1.AllowUserToResizeRows = False
        Me.PayGrid1.BackgroundColor = System.Drawing.SystemColors.Menu
        Me.PayGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PayGrid1.Location = New System.Drawing.Point(14, 252)
        Me.PayGrid1.Name = "PayGrid1"
        Me.PayGrid1.RowHeadersWidth = 51
        Me.PayGrid1.Size = New System.Drawing.Size(407, 165)
        Me.PayGrid1.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Unit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(101, 234)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Method"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(192, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = " Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(268, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Amount"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(350, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Unit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(400, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Unit Rent"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(470, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Due Date"
        '
        'id_lbl
        '
        Me.id_lbl.AutoSize = True
        Me.id_lbl.Location = New System.Drawing.Point(373, 234)
        Me.id_lbl.Name = "id_lbl"
        Me.id_lbl.Size = New System.Drawing.Size(17, 13)
        Me.id_lbl.TabIndex = 19
        Me.id_lbl.Text = "lbl"
        '
        'DLSS_lbl
        '
        Me.DLSS_lbl.AutoSize = True
        Me.DLSS_lbl.Location = New System.Drawing.Point(10, 217)
        Me.DLSS_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DLSS_lbl.Name = "DLSS_lbl"
        Me.DLSS_lbl.Size = New System.Drawing.Size(56, 13)
        Me.DLSS_lbl.TabIndex = 35
        Me.DLSS_lbl.Text = "DL / SS #"
        '
        'DLSS_txt
        '
        Me.DLSS_txt.Enabled = False
        Me.DLSS_txt.Location = New System.Drawing.Point(77, 213)
        Me.DLSS_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.DLSS_txt.Name = "DLSS_txt"
        Me.DLSS_txt.Size = New System.Drawing.Size(255, 20)
        Me.DLSS_txt.TabIndex = 34
        '
        'Phone_txt
        '
        Me.Phone_txt.Enabled = False
        Me.Phone_txt.Location = New System.Drawing.Point(77, 162)
        Me.Phone_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.Phone_txt.Name = "Phone_txt"
        Me.Phone_txt.Size = New System.Drawing.Size(255, 20)
        Me.Phone_txt.TabIndex = 33
        '
        'Phone_lbl
        '
        Me.Phone_lbl.AutoSize = True
        Me.Phone_lbl.Location = New System.Drawing.Point(11, 166)
        Me.Phone_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Phone_lbl.Name = "Phone_lbl"
        Me.Phone_lbl.Size = New System.Drawing.Size(38, 13)
        Me.Phone_lbl.TabIndex = 32
        Me.Phone_lbl.Text = "Phone"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(353, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 23)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "Late Notices"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DatabaseToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(578, 24)
        Me.MenuStrip1.TabIndex = 37
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PaymentToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'PaymentToolStripMenuItem
        '
        Me.PaymentToolStripMenuItem.Name = "PaymentToolStripMenuItem"
        Me.PaymentToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.PaymentToolStripMenuItem.Text = "Payment"
        '
        'DatabaseToolStripMenuItem
        '
        Me.DatabaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewEntryToolStripMenuItem})
        Me.DatabaseToolStripMenuItem.Name = "DatabaseToolStripMenuItem"
        Me.DatabaseToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.DatabaseToolStripMenuItem.Text = "Database"
        '
        'NewEntryToolStripMenuItem
        '
        Me.NewEntryToolStripMenuItem.Name = "NewEntryToolStripMenuItem"
        Me.NewEntryToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.NewEntryToolStripMenuItem.Text = "New Entry"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'HMSMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 431)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DLSS_lbl)
        Me.Controls.Add(Me.DLSS_txt)
        Me.Controls.Add(Me.Phone_txt)
        Me.Controls.Add(Me.Phone_lbl)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PayGrid1)
        Me.Controls.Add(Me.CusPayment_btn)
        Me.Controls.Add(Me.CusDelete_btn)
        Me.Controls.Add(Me.CusEdit_btn)
        Me.Controls.Add(Me.CusNew_btn)
        Me.Controls.Add(Me.id_lbl)
        Me.Controls.Add(Me.StallGrid1)
        Me.Controls.Add(Me.rentergrid1)
        Me.Controls.Add(Me.updateunit_btn)
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
        Me.Controls.Add(Me.customer_txt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "HMSMain"
        Me.Text = "Huff Mini Storage - Main"
        CType(Me.rentergrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StallGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents customer_txt As TextBox
    Friend WithEvents Customer_lbl As Label
    Friend WithEvents Address_lbl As Label
    Friend WithEvents address_txt As TextBox
    Friend WithEvents City_lbl As Label
    Friend WithEvents city_txt As TextBox
    Friend WithEvents State_lbl As Label
    Friend WithEvents state_txt As TextBox
    Friend WithEvents Zip_lbl As Label
    Friend WithEvents zip_txt As TextBox
    Friend WithEvents Email_lbl As Label
    Friend WithEvents email_txt As TextBox
    Friend WithEvents updateunit_btn As Button
    Friend WithEvents rentergrid1 As DataGridView
    Friend WithEvents StallGrid1 As DataGridView
    Friend WithEvents CusNew_btn As Button
    Friend WithEvents CusEdit_btn As Button
    Friend WithEvents CusDelete_btn As Button
    Friend WithEvents CusPayment_btn As Button
    Friend WithEvents PayGrid1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents id_lbl As Label
    Friend WithEvents DLSS_lbl As Label
    Friend WithEvents DLSS_txt As TextBox
    Friend WithEvents Phone_txt As TextBox
    Friend WithEvents Phone_lbl As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaymentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewEntryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
End Class
