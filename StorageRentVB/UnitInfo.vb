Imports System.Data.SqlClient

Public Class UnitInfo

    Public Property CusID As String = HMSStart.CusID
    Public Property StallName As String = CustEdit.StallName
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RBCheck_rbtn.Checked = True
        ShowUserData()
    End Sub
    Private Sub ShowUserData()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        unitNum_txt.Text = StallName
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID,Fname, Lname, Address, City, State, Zip, Email FROM StorageDB WHERE ID = '" & CusID & "'"
        Dim Data2 As SqlDataReader = cmd.ExecuteReader()

        While Data2.Read()
            CusID = Convert.ToString(Data2("ID"))
            Me.cusFname_txt.Text = Convert.ToString(Data2("Fname"))
            Me.cusLname_txt.Text = Convert.ToString(Data2("Lname"))
            Me.address_txt.Text = Convert.ToString(Data2("Address"))
            Me.city_txt.Text = Convert.ToString(Data2("City"))
            Me.state_txt.Text = Convert.ToString(Data2("State"))
            Me.zip_txt.Text = Convert.ToString(Data2("Zip"))
            Me.email_txt.Text = Convert.ToString(Data2("Email"))
        End While

        Dim UserData1 As DataTable = ExecuteSQL("Select ID, StallNum, Rent, DateRented, DueDate FROM StallNum WHERE ID = '" & CusID & "'")

        With StallGrid2
            .DataSource = UserData1
            .Columns(0).HeaderText = "ID"
            .Columns(1).HeaderText = "StallNum"
            .Columns(2).HeaderText = "Rent"
            .Columns(3).HeaderText = "Due Date"
            .Columns(0).Width = 75
            .Columns(1).Width = 67
            .Columns(2).Width = 75
            .Columns(3).Width = 75
            StallGrid2.ColumnHeadersVisible = False
            StallGrid2.RowHeadersVisible = False
            StallGrid2.Columns("ID").Visible = False

        End With

    End Sub

    Private Sub AddUnit_btn_Click(sender As Object, e As EventArgs) Handles AddUnit_btn.Click
        Dim InsertQuery As String = "Insert INTO StallNum (ID, Rent, StallNum, DateRented, DueDate) Values (@ID, @Rent, @StallNum, @DateRented, @DueDate)"
        Dim con As New SqlConnection()
        Dim cmd As New SqlCommand(InsertQuery)
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        Try

            cmd.Parameters.AddWithValue("@ID", CusID)
            cmd.Parameters.AddWithValue("@Rent", rentamount_txt.Text)
            cmd.Parameters.AddWithValue("@StallNum", unitNum_txt.Text)
            cmd.Parameters.AddWithValue("@DateRented", rentdate_txt.Text)
            cmd.Parameters.AddWithValue("@DueDate", duedate_txt.Text)


            cmd.ExecuteNonQuery()

            MsgBox("Data Saved")

        Catch ex As SqlException
            MsgBox("Error has occurred!")
        Finally
            con.Close()
        End Try

        'HMSMain.Reload()
        Me.Close()

    End Sub

    Private Sub updateunit_btn_Click(sender As Object, e As EventArgs) Handles updateunit_btn.Click
        Dim updateQuery As String = "UPDATE dbo.StallNum SET ID = @ID, Rent = @Rent, StallNum = @StallNum, DateRented = @DateRented, DueDate = @DueDate WHERE ID = @ID AND StallNum = @StallNum"
        Dim con As New SqlConnection()
        Dim cmd As New SqlCommand(updateQuery)
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        Try

            cmd.Parameters.AddWithValue("@ID", id_lbl.Text)
            cmd.Parameters.AddWithValue("@Rent", rentamount_txt.Text)
            cmd.Parameters.AddWithValue("@StallNum", unitNum_txt.Text)
            cmd.Parameters.AddWithValue("@DateRented", rentdate_txt.Text)
            cmd.Parameters.AddWithValue("@DueDate", duedate_txt.Text)

            cmd.ExecuteNonQuery()

            MsgBox("Data Updated and Saved")

        Catch ex As SqlException
            MsgBox("Error has occurred!")
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub StallGrid2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles StallGrid2.CellContentClick
        Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim UserData As DataTable = ExecuteSQL("Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE ID = '" & id_lbl.Text & "'")

        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = StallGrid2.Rows(index)
        id_lbl.Text = selectedRow.Cells(0).Value.ToString()
        unitNum_txt.Text = selectedRow.Cells(1).Value.ToString()
        rentamount_txt.Text = selectedRow.Cells(2).Value.ToString()
        rentdate_txt.Text = selectedRow.Cells(3).Value.ToString()
        duedate_txt.Text = selectedRow.Cells(4).Value.ToString()
    End Sub

    Private Sub Payment_btn_Click(sender As Object, e As EventArgs) Handles Payment_btn.Click
        Dim UserData3 As DataTable = ExecuteSQL("Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE ID = '" & id_lbl.Text & "'")
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim FirstDate As Date    ' Declare variables.
        Dim IntervalType As String
        Dim Number As Integer
        Dim Msg As String
        Dim PaymentMethod As String
        Dim CheckNumber As String


        If RBCheck_rbtn.Checked = True Then
            PaymentMethod = "Check"
            CheckNumber = InputBox("Enter number of check.")
        ElseIf RBCash_rbtn.Checked = True Then
            PaymentMethod = "Cash"
            MessageBox.Show("You selected Cash payment.")
        ElseIf RBCard_rbtn.Checked = True Then
            PaymentMethod = "Card"
            MessageBox.Show("You selected Card payment.")
            Dim webAddress As String = "https://squareup.com/terminal/"
            Process.Start(webAddress)
        End If

        IntervalType = "m"    ' "m" specifies months as interval.
        FirstDate = Date.Parse(duedate_txt.Text)
        Number = InputBox("Enter number of months to add")
        Msg = "New date: " & DateAdd(IntervalType, Number, FirstDate)
        Dim NewDueDate As Date = DateAdd(IntervalType, Number, FirstDate)
        newduedate_txt.Text = NewDueDate
        MsgBox(Msg)
        AmtPaid_txt.Text = Number * rentamount_txt.Text
#Disable Warning BC42104 ' Variable is used before it has been assigned a value
#Disable Warning BC42104 ' Variable is used before it has been assigned a value
        Test_lbl.Text = PaymentMethod + CheckNumber
#Enable Warning BC42104 ' Variable is used before it has been assigned a value
#Enable Warning BC42104 ' Variable is used before it has been assigned a value
        Dim updateQuery As String = "UPDATE dbo.StallNum SET DueDate = @DueDate WHERE StallNum = @StallNum"
        Dim con1 As New SqlConnection()
        Dim cmd1 As New SqlCommand(updateQuery)
        con1.ConnectionString = StringConnection
        con1.Open()
        cmd1.Connection = con1
        Try

            cmd1.Parameters.AddWithValue("@ID", id_lbl.Text)
            cmd1.Parameters.AddWithValue("@DueDate", DateTime.Parse(NewDueDate))
            cmd1.Parameters.AddWithValue("@StallNum", unitNum_txt.Text)

            cmd1.ExecuteNonQuery()

        Catch ex As SqlException
            MsgBox("Error has occurred!")
        Finally
            con.Close()
        End Try
        Dim updateQuery2 As String = "Insert INTO dbo.PayHistory (ID, StallNum, PayMeth, PayDate, PayAmount, PaidTillDate) Values (@ID, @StallNum, @PayMeth, @PayDate, @PayAmount, @PaidTillDate)"
        Dim con2 As New SqlConnection()
        Dim cmd2 As New SqlCommand(updateQuery2)
        con2.ConnectionString = StringConnection
        con2.Open()
        cmd2.Connection = con1
        Try

            cmd2.Parameters.AddWithValue("@ID", id_lbl.Text)
            cmd2.Parameters.AddWithValue("@StallNum", unitNum_txt.Text)
            cmd2.Parameters.AddWithValue("@PayMeth", Test_lbl.Text)
            cmd2.Parameters.AddWithValue("@PayDate", DateTime.Now)
            cmd2.Parameters.AddWithValue("@PayAmount", AmtPaid_txt.Text)
            cmd2.Parameters.AddWithValue("@PaidTillDate", newduedate_txt.Text)

            cmd2.ExecuteNonQuery()

            MsgBox("Payment Data Saved")
        Catch ex As SqlException
            MsgBox("Error has occurred!")
        Finally
            con.Close()
        End Try



    End Sub

    Private Sub delunit_btn_Click(sender As Object, e As EventArgs) Handles delunit_btn.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Delete FROM StallNum WHERE ID = @id AND StallNum = '" & unitNum_txt.Text & "'"
        cmd.Parameters.Add("@id", SqlDbType.Int).Value = CusID


        Dim answer1 As MsgBoxResult
        answer1 = MsgBox("Do you wish to delete Stall?", MsgBoxStyle.YesNo)
        If answer1 = MsgBoxResult.Yes Then
            cmd.ExecuteNonQuery()
        End If

        'Me.Reload()
    End Sub
End Class