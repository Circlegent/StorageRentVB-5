Imports System.Data.SqlClient
Public Class CustEdit
    Public Property CusID As String

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowUserData()
        cusFname_txt.Enabled = True
        cusLname_txt.Enabled = True
        address_txt.Enabled = True
        city_txt.Enabled = True
        state_txt.Enabled = True
        zip_txt.Enabled = True
        email_txt.Enabled = True
    End Sub
    Private Sub ShowUserData()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID,Fname, Lname, Address, City, State, Zip, PhoneNum, LicenseNum, Email FROM StorageDB WHERE ID = '" & CusID & "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            Me.id_lbl.Text = Convert.ToString(Data1("ID"))
            Me.cusFname_txt.Text = Convert.ToString(Data1("Fname"))
            Me.cusLname_txt.Text = Convert.ToString(Data1("Lname"))
            Me.address_txt.Text = Convert.ToString(Data1("Address"))
            Me.city_txt.Text = Convert.ToString(Data1("City"))
            Me.state_txt.Text = Convert.ToString(Data1("State"))
            Me.zip_txt.Text = Convert.ToString(Data1("Zip"))
            Me.Phone_txt.Text = Convert.ToString(Data1("PhoneNum"))
            Me.DLSS_txt.Text = Convert.ToString(Data1("LicenseNum"))
            Me.email_txt.Text = Convert.ToString(Data1("Email"))
        End While


    End Sub

    Private Sub Save_btn_Click(sender As Object, e As EventArgs) Handles Save_btn.Click

        Dim updateQuery As String = "UPDATE StorageDB SET Fname = @Fname, Lname = @Lname, Address = @Address, City = @City, State = @State, Zip = @Zip, PhoneNum = @PhoneNum, LicenseNum = @LicenseNum, Email = @Email WHERE ID = @ID"
        Dim con As New SqlConnection()
        Dim cmd As New SqlCommand(updateQuery)
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        Try

            cmd.Parameters.AddWithValue("@ID", id_lbl.Text)
            cmd.Parameters.AddWithValue("@Fname", cusFname_txt.Text)
            cmd.Parameters.AddWithValue("@Lname", cusLname_txt.Text)
            cmd.Parameters.AddWithValue("@Address", address_txt.Text)
            cmd.Parameters.AddWithValue("@City", city_txt.Text)
            cmd.Parameters.AddWithValue("@State", state_txt.Text)
            cmd.Parameters.AddWithValue("@Zip", zip_txt.Text)
            cmd.Parameters.AddWithValue("@PhoneNum", Phone_txt.Text)
            cmd.Parameters.AddWithValue("@LicenseNum", DLSS_txt.Text)
            cmd.Parameters.AddWithValue("@Email", email_txt.Text)

            cmd.ExecuteNonQuery()

            MsgBox("Data Saved")

        Catch ex As SqlException
            MsgBox("Error has occurred!")
        Finally
            con.Close()
        End Try
        HMSMain.rentergrid1.Enabled = True
        HMSMain.StallGrid1.Enabled = True
        HMSMain.CusEdit_btn.Enabled = True
        HMSMain.CusNew_btn.Enabled = True
        HMSMain.CusDelete_btn.Enabled = True
        HMSMain.Reload()
        Me.Close()
    End Sub

    Private Sub AddNew_btn_Click(sender As Object, e As EventArgs) Handles AddNew_btn.Click
        cusFname_txt.Text = ""
        cusLname_txt.Text = ""
        address_txt.Text = ""
        city_txt.Text = ""
        state_txt.Text = ""
        zip_txt.Text = ""
        Phone_txt.Text = ""
        DLSS_txt.Text = ""
        email_txt.Text = ""
        AddNew_btn.Visible = False
        cusFname_txt.Select()
    End Sub

    Private Sub SaveNew_btn_Click(sender As Object, e As EventArgs) Handles SaveNew_btn.Click
        Dim InsertQuery1 As String = "Insert INTO dbo.StorageDB ( Fname, Lname, Address, City, State, Zip, PhoneNum, LicenseNum, Email) Values ( @Fname, @Lname, @Address, @City, @State, @Zip, @PhoneNum, @LicenseNum, @Email)"
        Dim con As New SqlConnection()
        Dim cmd As New SqlCommand(InsertQuery1)
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        Try

            cmd.Parameters.AddWithValue("@Fname", cusFname_txt.Text)
            cmd.Parameters.AddWithValue("@Lname", cusLname_txt.Text)
            cmd.Parameters.AddWithValue("@Address", address_txt.Text)
            cmd.Parameters.AddWithValue("@City", city_txt.Text)
            cmd.Parameters.AddWithValue("@State", state_txt.Text)
            cmd.Parameters.AddWithValue("@Zip", zip_txt.Text)
            cmd.Parameters.AddWithValue("@PhoneNum", Phone_txt.Text)
            cmd.Parameters.AddWithValue("@LicenseNum", DLSS_txt.Text)
            cmd.Parameters.AddWithValue("@Email", email_txt.Text)

            cmd.ExecuteNonQuery()

            MsgBox("Data Saved")

        Catch ex As SqlException
            MsgBox("Error has occurred!")
        Finally
            con.Close()
        End Try

        HMSMain.Reload()
        Me.Close()
    End Sub
End Class