Imports System.Data.SqlClient


Public Class HMSMain
    Private dataST As DataSet
    Private sql As String
    Private App As String
    Public Property Flag As String
    Public Function Reload()
        ShowUserData()
        customer_txt.Select()
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowUserData()
        customer_txt.Select()

    End Sub

    Private Sub ShowUserData()

        Dim UserData As DataTable = ExecuteSQL("Select ID,  (Fname + ' ' + Lname) AS Customer FROM StorageDB")

        With rentergrid1

            .DataSource = UserData
            .Columns(0).HeaderText = "ID"
            .Columns(1).HeaderText = "Customer"
            .Columns(0).Width = 50
            .Columns(1).Width = 244
            rentergrid1.ColumnHeadersVisible = False
            rentergrid1.RowHeadersVisible = False
            rentergrid1.Columns("ID").Visible = False
        End With
        rentergrid1_CellClick(rentergrid1, New DataGridViewCellEventArgs(0, 0))
        rentergrid1.Rows(0).Selected = True
    End Sub

    Private Sub end_btn_Click(sender As Object, e As EventArgs) Handles end_btn.Click
        End
    End Sub
    Private Sub rentergrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles rentergrid1.CellClick
        Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = rentergrid1.Rows(index)
        id_lbl.Text = selectedRow.Cells(0).Value.ToString()
        customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select Fname, Lname, Address, City, State, Zip, PhoneNum, LicenseNum, Email FROM StorageDB WHERE ID = '" & id_lbl.Text & "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            Me.address_txt.Text = Convert.ToString(Data1("Address"))
            Me.city_txt.Text = Convert.ToString(Data1("City"))
            Me.state_txt.Text = Convert.ToString(Data1("State"))
            Me.zip_txt.Text = Convert.ToString(Data1("Zip"))
            Me.Phone_txt.Text = Convert.ToString(Data1("PhoneNum"))
            Me.DLSS_txt.Text = Convert.ToString(Data1("LicenseNum"))
            Me.email_txt.Text = Convert.ToString(Data1("Email"))
        End While

        Dim UserData1 As DataTable = ExecuteSQL("Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE ID = '" & id_lbl.Text & "'")

        With StallGrid1
            .DataSource = UserData1
            .Columns(0).HeaderText = "ID"
            .Columns(1).HeaderText = "StallNum"
            .Columns(2).HeaderText = "Rent"
            .Columns(3).HeaderText = "DueDate"
            .Columns(4).HeaderText = "DateRented"
            .Columns(0).Width = 60
            .Columns(1).Width = 60
            .Columns(2).Width = 58
            .Columns(3).Width = 100
            .Columns(4).Width = 10
            StallGrid1.ColumnHeadersVisible = False
            StallGrid1.RowHeadersVisible = False
            StallGrid1.Columns("ID").Visible = False
            StallGrid1.Columns("DateRented").Visible = False
        End With
        Dim strExt As String
        ' We set up the For Next loop to iterate the DataGridView rows
        For Each row As DataGridViewRow In Me.StallGrid1.Rows
            ' Get the READY value from each row as we loop
            strExt = row.Cells(3).Value
            '  Apply the color formatting based on your conditions
            If strExt < Date.Today Then
                row.DefaultCellStyle.ForeColor = Color.Red
            Else
                row.DefaultCellStyle.ForeColor = Color.Green
            End If
        Next
        Dim PayData1 As DataTable = ExecuteSQL("Select ID, StallNum, PayMeth, PayDate, PayAmount FROM PayHistory WHERE ID = '" & id_lbl.Text & "'")

        With PayGrid1
            .DataSource = PayData1
            .Columns(0).HeaderText = "ID"
            .Columns(1).HeaderText = "StallNum"
            .Columns(2).HeaderText = "PayMeth"
            .Columns(3).HeaderText = "PayDate"
            .Columns(4).HeaderText = "PayAmount"
            .Columns(0).Width = 30
            .Columns(1).Width = 68
            .Columns(2).Width = 70
            .Columns(3).Width = 110
            .Columns(4).Width = 67
            PayGrid1.ColumnHeadersVisible = False
            PayGrid1.RowHeadersVisible = False
            PayGrid1.Columns("ID").Visible = False
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles CusEdit_btn.Click

        Dim obj As New CustEdit
        obj.AddNew_btn.Visible = False
        obj.SaveNew_btn.Visible = False
        obj.CusID = id_lbl.Text
        obj.cusFname_txt.Select()
        obj.Show()

    End Sub

    Private Sub CusDelete_btn_Click(sender As Object, e As EventArgs) Handles CusDelete_btn.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Delete FROM StorageDB WHERE ID = @id"
        cmd.Parameters.Add("@id", SqlDbType.Int).Value = id_lbl.Text


        Dim answer1 As MsgBoxResult
        answer1 = MsgBox("Do you wish to delete customer?", MsgBoxStyle.YesNo)
        If answer1 = MsgBoxResult.Yes Then
            cmd.ExecuteNonQuery()
        End If

        Me.Reload()
    End Sub

    Private Sub updateunit_btn_Click(sender As Object, e As EventArgs) Handles updateunit_btn.Click
        Flag = "0"
        Dim obj4 As New UnitInfo

        obj4.RBCheck_rbtn.Visible = False
        obj4.RBCash_rbtn.Visible = False
        obj4.RBCard_rbtn.Visible = False
        obj4.Payment_btn.Visible = False
        obj4.unitNum_txt.Select()
        obj4.CusID = id_lbl.Text
        obj4.Show()
        obj4.Text = "Huff Mini Storage - Unit Info"
    End Sub

    Private Sub CusPayment_btn_Click(sender As Object, e As EventArgs) Handles CusPayment_btn.Click
        Dim obj3 As New UnitInfo
        obj3.CusID = id_lbl.Text
        obj3.Show()
    End Sub

    Private Sub CusNew_btn_Click(sender As Object, e As EventArgs) Handles CusNew_btn.Click
        Dim obj5 As New CustEdit
        obj5.Text = "Huff Mini Storage - New Renter"
        obj5.Save_btn.Visible = False
        obj5.CusID = id_lbl.Text
        obj5.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim obj5 As New LateNotice

        ' obj5.RBCheck_rbtn.Visible = False
        ' obj5.RBCash_rbtn.Visible = False
        ' obj5.RBCard_rbtn.Visible = False
        ' obj5.Payment_btn.Visible = False
        ' obj5.unitNum_txt.Select()
        obj5.CusID = id_lbl.Text
        obj5.Show()
    End Sub
End Class
