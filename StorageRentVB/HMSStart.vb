Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient


Public Class HMSStart
    Public Property CusID As String
    Public Property StallName As String
    Private Sub CheckRenter()
        If CusID = "" Then

            Dim answer1 As MsgBoxResult
            answer1 = MsgBox("Do you wish to add new customer?", MsgBoxStyle.YesNo)
            If answer1 = MsgBoxResult.Yes Then
                CustEdit.Show()
            Else
                Dim answer2 As MsgBoxResult
                answer2 = MsgBox("Do you wish to add new stall to existing customer?", MsgBoxStyle.YesNo)
                If answer2 = MsgBoxResult.Yes Then

                    CustEdit.Show()
                End If

            End If

        Else
            HMSMain.CusID = CusID
            HMSMain.Show()
        End If
    End Sub
    Private Sub S(sender As Object, e As EventArgs) Handles StallA1.VisibleChanged
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        CusID = ""
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallA1.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While
        If CusID = "" Then
            StallA1.BackColor = Color.Blue
        Else
            If Duedate1 < Date.Today Then
                StallA1.BackColor = Color.Red
            Else
                StallA1.BackColor = Color.Green
            End If
        End If

    End Sub

    Private Sub S2(sender As Object, e As EventArgs) Handles StallA2.VisibleChanged
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        CusID = ""
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallA2.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While
        If CusID = "" Then
            StallA2.BackColor = Color.Blue
        Else
            If Duedate1 < Date.Today Then
                StallA2.BackColor = Color.Red
            Else
                StallA2.BackColor = Color.Green
            End If
        End If
    End Sub
    Private Sub S3(sender As Object, e As EventArgs) Handles StallA3.VisibleChanged
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        CusID = ""
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallA3.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While
        If CusID = "" Then
            StallA3.BackColor = Color.Blue
        Else
            If Duedate1 < Date.Today Then
                StallA3.BackColor = Color.Red
            Else
                StallA3.BackColor = Color.Green
            End If
        End If
    End Sub
    Private Sub S4(sender As Object, e As EventArgs) Handles StallA4.VisibleChanged
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        CusID = ""
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallA4.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While
        If CusID = "" Then
            StallA4.BackColor = Color.Blue
        Else
            If Duedate1 < Date.Today Then
                StallA4.BackColor = Color.Red
            Else
                StallA4.BackColor = Color.Green
            End If
        End If
    End Sub
    Private Sub S5(sender As Object, e As EventArgs) Handles StallA5.VisibleChanged
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        CusID = ""
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallA5.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While
        If CusID = "" Then
            StallA5.BackColor = Color.Blue
        Else
            If Duedate1 < Date.Today Then
                StallA5.BackColor = Color.Red
            Else
                StallA5.BackColor = Color.Green
            End If
        End If
    End Sub
    Private Sub S6(sender As Object, e As EventArgs) Handles StallA6.VisibleChanged
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        CusID = ""
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallA6.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While
        If CusID = "" Then
            StallA6.BackColor = Color.Blue
        Else
            If Duedate1 < Date.Today Then
                StallA6.BackColor = Color.Red
            Else
                StallA6.BackColor = Color.Green
            End If
        End If
    End Sub
    Private Sub S7(sender As Object, e As EventArgs) Handles StallA7.VisibleChanged
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        CusID = ""
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallA7.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While

        If CusID = "" Then
            StallA7.BackColor = Color.Blue
        Else
            If Duedate1 < Date.Today Then
                StallA7.BackColor = Color.Red
            Else
                StallA7.BackColor = Color.Green
            End If
        End If
    End Sub
    Private Sub S8(sender As Object, e As EventArgs) Handles StallA8.VisibleChanged
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        CusID = ""
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallA8.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While
        If CusID = "" Then
            StallA8.BackColor = Color.Blue
        Else
            If Duedate1 < Date.Today Then
                StallA8.BackColor = Color.Red
            Else
                StallA8.BackColor = Color.Green
            End If
        End If
    End Sub
    Private Sub S9(sender As Object, e As EventArgs) Handles StallA9.VisibleChanged
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        CusID = ""
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallA9.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While
        If CusID = "" Then
            StallA9.BackColor = Color.Blue
        Else
            If Duedate1 < Date.Today Then
                StallA9.BackColor = Color.Red
            Else
                StallA9.BackColor = Color.Green
            End If
        End If
    End Sub
    Private Sub S10(sender As Object, e As EventArgs) Handles StallA10.VisibleChanged
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        CusID = ""
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallA10.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While
        If CusID = "" Then
            StallA10.BackColor = Color.Blue
        Else
            If Duedate1 < Date.Today Then
                StallA10.BackColor = Color.Red
            Else
                StallA10.BackColor = Color.Green
            End If
        End If
    End Sub
    Private Sub S11(sender As Object, e As EventArgs) Handles StallA11.VisibleChanged
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        CusID = ""
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallA11.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While
        If CusID = "" Then
            StallA11.BackColor = Color.Blue
        Else
            If Duedate1 < Date.Today Then
                StallA11.BackColor = Color.Red
            Else
                StallA11.BackColor = Color.Green
            End If
        End If
    End Sub
    Private Sub S12(sender As Object, e As EventArgs) Handles StallB1.VisibleChanged
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        CusID = ""
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallB1.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While
        If CusID = "" Then
            StallB1.BackColor = Color.Blue
        Else
            If Duedate1 < Date.Today Then
                StallB1.BackColor = Color.Red
            Else
                StallB1.BackColor = Color.Green
            End If
        End If
    End Sub
    Private Sub S13(sender As Object, e As EventArgs) Handles StallB2.VisibleChanged
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        CusID = ""
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallB2.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While
        If CusID = "" Then
            StallB2.BackColor = Color.Blue
        Else
            If Duedate1 < Date.Today Then
                StallB2.BackColor = Color.Red
            Else
                StallB2.BackColor = Color.Green
            End If
        End If
    End Sub
    Private Sub S14(sender As Object, e As EventArgs) Handles StallB3.VisibleChanged
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        CusID = ""
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallB3.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While
        If CusID = "" Then
            StallB3.BackColor = Color.Blue
        Else
            If Duedate1 < Date.Today Then
                StallB3.BackColor = Color.Red
            Else
                StallB3.BackColor = Color.Green
            End If
        End If
    End Sub
    Private Sub S15(sender As Object, e As EventArgs) Handles StallB4.VisibleChanged
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        CusID = ""
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallB4.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While
        If CusID = "" Then
            StallB4.BackColor = Color.Blue
        Else
            If Duedate1 < Date.Today Then
                StallB4.BackColor = Color.Red
            Else
                StallB4.BackColor = Color.Green
            End If
        End If
    End Sub
    Private Sub S16(sender As Object, e As EventArgs) Handles StallB5.VisibleChanged
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        CusID = ""
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallB5.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While
        If CusID = "" Then
            StallB5.BackColor = Color.Blue
        Else
            If Duedate1 < Date.Today Then
                StallB5.BackColor = Color.Red
            Else
                StallB5.BackColor = Color.Green
            End If
        End If
    End Sub
    Private Sub S17(sender As Object, e As EventArgs) Handles StallB6.VisibleChanged
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        CusID = ""
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallB6.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While
        If CusID = "" Then
            StallB6.BackColor = Color.Blue
        Else
            If Duedate1 < Date.Today Then
                StallB6.BackColor = Color.Red
            Else
                StallB6.BackColor = Color.Green
            End If
        End If
    End Sub
    Private Sub S18(sender As Object, e As EventArgs) Handles StallB7.VisibleChanged
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        CusID = ""
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallB7.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While
        If CusID = "" Then
            StallB7.BackColor = Color.Blue
        Else
            If Duedate1 < Date.Today Then
                StallB7.BackColor = Color.Red
            Else
                StallB7.BackColor = Color.Green
            End If
        End If
    End Sub
    Private Sub S19(sender As Object, e As EventArgs) Handles StallB8.VisibleChanged
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        CusID = ""
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallB8.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While
        If CusID = "" Then
            StallB8.BackColor = Color.Blue
        Else
            If Duedate1 < Date.Today Then
                StallB8.BackColor = Color.Red
            Else
                StallB8.BackColor = Color.Green
            End If
        End If
    End Sub
    Private Sub S20(sender As Object, e As EventArgs) Handles StallB9.VisibleChanged
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        CusID = ""
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallB9.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While
        If CusID = "" Then
            StallB9.BackColor = Color.Blue
        Else
            If Duedate1 < Date.Today Then
                StallB9.BackColor = Color.Red
            Else
                StallB9.BackColor = Color.Green
            End If
        End If
    End Sub
    Private Sub S21(sender As Object, e As EventArgs) Handles StallB10.VisibleChanged
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        CusID = ""
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallB10.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While
        If CusID = "" Then
            StallB10.BackColor = Color.Blue
        Else
            If Duedate1 < Date.Today Then
                StallB10.BackColor = Color.Red
            Else
                StallB10.BackColor = Color.Green
            End If
        End If
    End Sub
    Private Sub S22(sender As Object, e As EventArgs) Handles StallB11.VisibleChanged
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        CusID = ""
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallB11.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While
        If CusID = "" Then
            StallB11.BackColor = Color.Blue
        Else
            If Duedate1 < Date.Today Then
                StallB11.BackColor = Color.Red
            Else
                StallB11.BackColor = Color.Green
            End If
        End If
    End Sub
    Private Sub S23(sender As Object, e As EventArgs) Handles StallC1.VisibleChanged
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        CusID = ""
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallC1.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While
        If CusID = "" Then
            StallC1.BackColor = Color.Blue
        Else
            If Duedate1 < Date.Today Then
                StallC1.BackColor = Color.Red
            Else
                StallC1.BackColor = Color.Green
            End If
        End If
    End Sub
    Private Sub S24(sender As Object, e As EventArgs) Handles StallC2.VisibleChanged
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        CusID = ""
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallC2.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While
        If CusID = "" Then
            StallC2.BackColor = Color.Blue
        Else
            If Duedate1 < Date.Today Then
                StallC2.BackColor = Color.Red
            Else
                StallC2.BackColor = Color.Green
            End If
        End If
    End Sub
    Private Sub S25(sender As Object, e As EventArgs) Handles StallC3.VisibleChanged
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        CusID = ""
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallC3.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While
        If CusID = "" Then
            StallC3.BackColor = Color.Blue
        Else
            If Duedate1 < Date.Today Then
                StallC3.BackColor = Color.Red
            Else
                StallC3.BackColor = Color.Green
            End If
        End If
    End Sub
    Private Sub S26(sender As Object, e As EventArgs) Handles StallC4.VisibleChanged
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        CusID = ""
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallC4.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While
        If CusID = "" Then
            StallC4.BackColor = Color.Blue
        Else
            If Duedate1 < Date.Today Then
                StallC4.BackColor = Color.Red
            Else
                StallC4.BackColor = Color.Green
            End If
        End If
    End Sub
    Private Sub S27(sender As Object, e As EventArgs) Handles StallC5.VisibleChanged
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        CusID = ""
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallC5.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While
        If CusID = "" Then
            StallC5.BackColor = Color.Blue
        Else
            If Duedate1 < Date.Today Then
                StallC5.BackColor = Color.Red
            Else
                StallC5.BackColor = Color.Green
            End If
        End If
    End Sub
    Private Sub S28(sender As Object, e As EventArgs) Handles StallC6.VisibleChanged
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        CusID = ""
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallC6.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While
        If CusID = "" Then
            StallC6.BackColor = Color.Blue
        Else
            If Duedate1 < Date.Today Then
                StallC6.BackColor = Color.Red
            Else
                StallC6.BackColor = Color.Green
            End If
        End If
    End Sub
    Private Sub S29(sender As Object, e As EventArgs) Handles StallD1.VisibleChanged
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        CusID = ""
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallD1.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While
        If CusID = "" Then
            StallD1.BackColor = Color.Blue
        Else
            If Duedate1 < Date.Today Then
                StallD1.BackColor = Color.Red
            Else
                StallD1.BackColor = Color.Green
            End If
        End If
    End Sub
    Private Sub S30(sender As Object, e As EventArgs) Handles StallD2.VisibleChanged
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        CusID = ""
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallD2.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While
        If CusID = "" Then
            StallD2.BackColor = Color.Blue
        Else
            If Duedate1 < Date.Today Then
                StallD2.BackColor = Color.Red
            Else
                StallD2.BackColor = Color.Green
            End If
        End If
    End Sub
    Private Sub S31(sender As Object, e As EventArgs) Handles StallD3.VisibleChanged
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        CusID = ""
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallD3.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While
        If CusID = "" Then
            StallD3.BackColor = Color.Blue
        Else
            If Duedate1 < Date.Today Then
                StallD3.BackColor = Color.Red
            Else
                StallD3.BackColor = Color.Green
            End If
        End If
    End Sub
    Private Sub S32(sender As Object, e As EventArgs) Handles StallD4.VisibleChanged
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        CusID = ""
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallD4.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While
        If CusID = "" Then
            StallD4.BackColor = Color.Blue
        Else
            If Duedate1 < Date.Today Then
                StallD4.BackColor = Color.Red
            Else
                StallD4.BackColor = Color.Green
            End If
        End If
    End Sub
    Private Sub S33(sender As Object, e As EventArgs) Handles StallD5.VisibleChanged
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        CusID = ""
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallD5.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While
        If CusID = "" Then
            StallD5.BackColor = Color.Blue
        Else
            If Duedate1 < Date.Today Then
                StallD5.BackColor = Color.Red
            Else
                StallD5.BackColor = Color.Green
            End If
        End If
    End Sub
    Private Sub S34(sender As Object, e As EventArgs) Handles StallD6.VisibleChanged
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        CusID = ""
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallD6.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While
        If CusID = "" Then
            StallD6.BackColor = Color.Blue
        Else
            If Duedate1 < Date.Today Then
                StallD6.BackColor = Color.Red
            Else
                StallD6.BackColor = Color.Green
            End If
        End If
    End Sub

    Private Sub HMSStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum"

    End Sub
    Private Sub StallA1_Click(sender As Object, e As EventArgs) Handles StallA1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        StallName = StallA1.Text
        CusID = ""
        'index = e.RowIndex
        ' Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'id_lbl.Text = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallA1.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While

        CheckRenter()
    End Sub

    Private Sub StallA2_Click(sender As Object, e As EventArgs) Handles StallA2.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        StallName = StallA2.Text
        CusID = ""
        'index = e.RowIndex
        ' Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'id_lbl.Text = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallA2.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While
        CheckRenter()

    End Sub

    Private Sub StallA3_Click(sender As Object, e As EventArgs) Handles StallA3.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        StallName = StallA3.Text
        CusID = ""
        'index = e.RowIndex
        ' Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'id_lbl.Text = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallA3.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While
        CheckRenter()
    End Sub

    Private Sub StallA4_Click(sender As Object, e As EventArgs) Handles StallA4.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        StallName = StallA4.Text
        'index = e.RowIndex
        ' Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'id_lbl.Text = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallA4.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            ID1 = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While
        CheckRenter()

    End Sub



    Private Sub StallA5_Click(sender As Object, e As EventArgs) Handles StallA5.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        StallName = StallA5.Text
        CusID = ""
        'index = e.RowIndex
        ' Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'id_lbl.Text = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallA5.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While
        CheckRenter()

    End Sub

    Private Sub StallA6_Click(sender As Object, e As EventArgs) Handles StallA6.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        StallName = StallA6.Text
        CusID = ""
        'index = e.RowIndex
        ' Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'id_lbl.Text = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallA6.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While

        CheckRenter()
    End Sub

    Private Sub StallA7_Click(sender As Object, e As EventArgs) Handles StallA7.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        StallName = StallA7.Text
        CusID = ""
        'index = e.RowIndex
        ' Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'id_lbl.Text = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallA7.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While

        CheckRenter()
    End Sub

    Private Sub StallA8_Click(sender As Object, e As EventArgs) Handles StallA8.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        StallName = StallA8.Text
        CusID = ""
        'index = e.RowIndex
        ' Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'id_lbl.Text = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallA8.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While

        CheckRenter()
    End Sub

    Private Sub StallA9_Click(sender As Object, e As EventArgs) Handles StallA9.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        StallName = StallA9.Text
        CusID = ""
        'index = e.RowIndex
        ' Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'id_lbl.Text = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallA9.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While

        CheckRenter()
    End Sub

    Private Sub StallA10_Click(sender As Object, e As EventArgs) Handles StallA10.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        StallName = StallA10.Text
        CusID = ""
        'index = e.RowIndex
        ' Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'id_lbl.Text = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallA10.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While

        CheckRenter()
    End Sub

    Private Sub StallA11_Click(sender As Object, e As EventArgs) Handles StallA11.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        StallName = StallA11.Text
        CusID = ""
        'index = e.RowIndex
        ' Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'id_lbl.Text = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallA11.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While

        CheckRenter()
    End Sub

    Private Sub StallB1_Click(sender As Object, e As EventArgs) Handles StallB1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        StallName = StallB1.Text
        CusID = ""
        'index = e.RowIndex
        ' Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'id_lbl.Text = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallB1.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While

        CheckRenter()
    End Sub

    Private Sub StallB2_Click(sender As Object, e As EventArgs) Handles StallB2.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        StallName = StallB2.Text
        CusID = ""
        'index = e.RowIndex
        ' Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'id_lbl.Text = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallB2.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While

        CheckRenter()
    End Sub

    Private Sub StallB3_Click(sender As Object, e As EventArgs) Handles StallB3.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        StallName = StallB3.Text
        CusID = ""
        'index = e.RowIndex
        ' Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'id_lbl.Text = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallB3.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While

        CheckRenter()
    End Sub

    Private Sub StallB4_Click(sender As Object, e As EventArgs) Handles StallB4.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        StallName = StallB4.Text
        CusID = ""
        'index = e.RowIndex
        ' Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'id_lbl.Text = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallB4.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While

        CheckRenter()
    End Sub

    Private Sub StallB5_Click(sender As Object, e As EventArgs) Handles StallB5.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        StallName = StallB5.Text
        CusID = ""
        'index = e.RowIndex
        ' Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'id_lbl.Text = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallB5.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While

        CheckRenter()
    End Sub

    Private Sub StallB6_Click(sender As Object, e As EventArgs) Handles StallB6.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        StallName = StallB6.Text
        CusID = ""
        'index = e.RowIndex
        ' Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'id_lbl.Text = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallB6.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While

        CheckRenter()
    End Sub

    Private Sub StallB7_Click(sender As Object, e As EventArgs) Handles StallB7.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        StallName = StallB7.Text
        CusID = ""
        'index = e.RowIndex
        ' Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'id_lbl.Text = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallB7.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While

        CheckRenter()
    End Sub

    Private Sub StallB8_Click(sender As Object, e As EventArgs) Handles StallB8.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        StallName = StallB8.Text
        CusID = ""
        'index = e.RowIndex
        ' Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'id_lbl.Text = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallB8.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While

        CheckRenter()
    End Sub

    Private Sub StallB9_Click(sender As Object, e As EventArgs) Handles StallB9.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        StallName = StallB9.Text
        CusID = ""
        'index = e.RowIndex
        ' Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'id_lbl.Text = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallB9.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While

        CheckRenter()
    End Sub

    Private Sub StallB10_Click(sender As Object, e As EventArgs) Handles StallB10.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        StallName = StallB10.Text
        CusID = ""
        'index = e.RowIndex
        ' Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'id_lbl.Text = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallB10.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While

        CheckRenter()
    End Sub

    Private Sub StallB11_Click(sender As Object, e As EventArgs) Handles StallB11.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        StallName = StallB11.Text
        CusID = ""
        'index = e.RowIndex
        ' Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'id_lbl.Text = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallB11.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While

        CheckRenter()
    End Sub

    Private Sub StallC1_Click(sender As Object, e As EventArgs) Handles StallC1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        StallName = StallC1.Text
        CusID = ""
        'index = e.RowIndex
        ' Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'id_lbl.Text = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallC1.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While

        CheckRenter()
    End Sub

    Private Sub StallC2_Click(sender As Object, e As EventArgs) Handles StallC2.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        StallName = StallC2.Text
        CusID = ""
        'index = e.RowIndex
        ' Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'id_lbl.Text = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallC2.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While

        CheckRenter()
    End Sub

    Private Sub StallC3_Click(sender As Object, e As EventArgs) Handles StallC3.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        StallName = StallC3.Text
        CusID = ""
        'index = e.RowIndex
        ' Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'id_lbl.Text = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallC3.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While

        CheckRenter()
    End Sub

    Private Sub StallC4_Click(sender As Object, e As EventArgs) Handles StallC4.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        StallName = StallC4.Text
        CusID = ""
        'index = e.RowIndex
        ' Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'id_lbl.Text = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallC4.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While

        CheckRenter()
    End Sub

    Private Sub StallC5_Click(sender As Object, e As EventArgs) Handles StallC5.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        StallName = StallC5.Text
        CusID = ""
        'index = e.RowIndex
        ' Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'id_lbl.Text = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallC5.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While

        CheckRenter()
    End Sub

    Private Sub StallC6_Click(sender As Object, e As EventArgs) Handles StallC6.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        StallName = StallC6.Text
        CusID = ""
        'index = e.RowIndex
        ' Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'id_lbl.Text = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallC6.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While

        CheckRenter()
    End Sub

    Private Sub StallD1_Click(sender As Object, e As EventArgs) Handles StallD1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        StallName = StallD1.Text
        CusID = ""
        'index = e.RowIndex
        ' Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'id_lbl.Text = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallD1.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While

        CheckRenter()
    End Sub

    Private Sub StallD2_Click(sender As Object, e As EventArgs) Handles StallD2.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        StallName = StallD2.Text
        CusID = ""
        'index = e.RowIndex
        ' Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'id_lbl.Text = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallD2.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While

        CheckRenter()
    End Sub

    Private Sub StallD3_Click(sender As Object, e As EventArgs) Handles StallD3.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        StallName = StallD3.Text
        CusID = ""
        'index = e.RowIndex
        ' Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'id_lbl.Text = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallD3.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While

        CheckRenter()
    End Sub

    Private Sub StallD4_Click(sender As Object, e As EventArgs) Handles StallD4.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        StallName = StallD4.Text
        CusID = ""
        'index = e.RowIndex
        ' Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'id_lbl.Text = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallD4.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While

        CheckRenter()
    End Sub

    Private Sub StallD5_Click(sender As Object, e As EventArgs) Handles StallD5.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        StallName = StallD5.Text
        CusID = ""
        'index = e.RowIndex
        ' Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'id_lbl.Text = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallD5.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While

        CheckRenter()
    End Sub

    Private Sub StallD6_Click(sender As Object, e As EventArgs) Handles StallD6.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
        StallName = StallD6.Text
        CusID = ""
        'index = e.RowIndex
        ' Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'id_lbl.Text = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallD6.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While

        CheckRenter()
    End Sub

    Private Sub end_btn_Click(sender As Object, e As EventArgs) Handles end_btn.Click
        End
    End Sub
    Private Sub ShowMainA1(sender As Object, e As EventArgs) Handles StallA1.MouseEnter

        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim Stallnum1 As String
        Dim BtnName As String
        BtnName = StallB1.Text
        'Dim Rent1 As String
        'Dim Duedate1 As String
        'Dim DateRented1 As String
        CusID = ""
        con1.ConnectionString = StringConnection
        con1.Open()
        cmd1.Connection = con1
        cmd1.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallA1.Text + "'"
        Dim Data2 As SqlDataReader = cmd1.ExecuteReader()

        While Data2.Read()
            CusID = Convert.ToString(Data2("ID"))
            Stallnum1 = Convert.ToString(Data2("StallNum"))
            'Rent1 = Convert.ToString(Data1("Rent"))
            Dim Duedate1 = Convert.ToString(Data2("DueDate"))
            'DateRented1 = Convert.ToString(Data1("DateRented"))
            Me.txtduedate.Text = Convert.ToString(Data2("DueDate"))
        End While

        'Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'StallB1.Text = CusID
        'Index = e.RowIndex
        'Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'CusID = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select (Fname + ' ' + Lname) AS Customer, Address, City, State, Zip, PhoneNum, LicenseNum, Email FROM StorageDB WHERE ID = '" & CusID & "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            Me.customer_txt.Text = Convert.ToString(Data1("Customer"))
            Me.address_txt.Text = Convert.ToString(Data1("Address"))
            Me.city_txt.Text = Convert.ToString(Data1("City"))
            Me.state_txt.Text = Convert.ToString(Data1("State"))
            Me.zip_txt.Text = Convert.ToString(Data1("Zip"))
            Me.Phone_txt.Text = Convert.ToString(Data1("PhoneNum"))
            Me.DLSS_txt.Text = Convert.ToString(Data1("LicenseNum"))
            Me.email_txt.Text = Convert.ToString(Data1("Email"))
        End While
    End Sub

    Private Sub ShowMainA2(sender As Object, e As EventArgs) Handles StallA2.MouseEnter

        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim Stallnum1 As String
        'Dim BtnName As String
        'BtnName = StallA2.Text
        'Dim Rent1 As String
        'Dim Duedate1 As String
        'Dim DateRented1 As String
        CusID = ""
        con1.ConnectionString = StringConnection
        con1.Open()
        cmd1.Connection = con1
        cmd1.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallA2.Text + "'"
        Dim Data2 As SqlDataReader = cmd1.ExecuteReader()

        While Data2.Read()
            CusID = Convert.ToString(Data2("ID"))
            Stallnum1 = Convert.ToString(Data2("StallNum"))
            'Rent1 = Convert.ToString(Data1("Rent"))
            Dim Duedate1 = Convert.ToString(Data2("DueDate"))
            'DateRented1 = Convert.ToString(Data1("DateRented"))
            Me.txtduedate.Text = Convert.ToString(Data2("DueDate"))
        End While

        'Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'StallB1.Text = CusID
        'Index = e.RowIndex
        'Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'CusID = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select (Fname + ' ' + Lname) AS Customer, Address, City, State, Zip, PhoneNum, LicenseNum, Email FROM StorageDB WHERE ID = '" & CusID & "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            Me.customer_txt.Text = Convert.ToString(Data1("Customer"))
            Me.address_txt.Text = Convert.ToString(Data1("Address"))
            Me.city_txt.Text = Convert.ToString(Data1("City"))
            Me.state_txt.Text = Convert.ToString(Data1("State"))
            Me.zip_txt.Text = Convert.ToString(Data1("Zip"))
            Me.Phone_txt.Text = Convert.ToString(Data1("PhoneNum"))
            Me.DLSS_txt.Text = Convert.ToString(Data1("LicenseNum"))
            Me.email_txt.Text = Convert.ToString(Data1("Email"))
        End While
    End Sub

    Private Sub ShowMainA3(sender As Object, e As EventArgs) Handles StallA3.MouseEnter

        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim Stallnum1 As String
        Dim BtnName As String
        BtnName = StallB1.Text
        'Dim Rent1 As String
        'Dim Duedate1 As String
        'Dim DateRented1 As String
        CusID = ""
        con1.ConnectionString = StringConnection
        con1.Open()
        cmd1.Connection = con1
        cmd1.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallA3.Text + "'"
        Dim Data2 As SqlDataReader = cmd1.ExecuteReader()

        While Data2.Read()
            CusID = Convert.ToString(Data2("ID"))
            Stallnum1 = Convert.ToString(Data2("StallNum"))
            'Rent1 = Convert.ToString(Data1("Rent"))
            Dim Duedate1 = Convert.ToString(Data2("DueDate"))
            'DateRented1 = Convert.ToString(Data1("DateRented"))
            Me.txtduedate.Text = Convert.ToString(Data2("DueDate"))
        End While

        'Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'StallB1.Text = CusID
        'Index = e.RowIndex
        'Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'CusID = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select (Fname + ' ' + Lname) AS Customer, Address, City, State, Zip, PhoneNum, LicenseNum, Email FROM StorageDB WHERE ID = '" & CusID & "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            Me.customer_txt.Text = Convert.ToString(Data1("Customer"))
            Me.address_txt.Text = Convert.ToString(Data1("Address"))
            Me.city_txt.Text = Convert.ToString(Data1("City"))
            Me.state_txt.Text = Convert.ToString(Data1("State"))
            Me.zip_txt.Text = Convert.ToString(Data1("Zip"))
            Me.Phone_txt.Text = Convert.ToString(Data1("PhoneNum"))
            Me.DLSS_txt.Text = Convert.ToString(Data1("LicenseNum"))
            Me.email_txt.Text = Convert.ToString(Data1("Email"))
        End While
    End Sub

    Private Sub ShowMainA4(sender As Object, e As EventArgs) Handles StallA4.MouseEnter

        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim Stallnum1 As String
        Dim BtnName As String
        BtnName = StallB1.Text
        'Dim Rent1 As String
        'Dim Duedate1 As String
        'Dim DateRented1 As String
        CusID = ""
        con1.ConnectionString = StringConnection
        con1.Open()
        cmd1.Connection = con1
        cmd1.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallA4.Text + "'"
        Dim Data2 As SqlDataReader = cmd1.ExecuteReader()

        While Data2.Read()
            CusID = Convert.ToString(Data2("ID"))
            Stallnum1 = Convert.ToString(Data2("StallNum"))
            'Rent1 = Convert.ToString(Data1("Rent"))
            Dim Duedate1 = Convert.ToString(Data2("DueDate"))
            'DateRented1 = Convert.ToString(Data1("DateRented"))
            Me.txtduedate.Text = Convert.ToString(Data2("DueDate"))
        End While

        'Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'StallB1.Text = CusID
        'Index = e.RowIndex
        'Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'CusID = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select (Fname + ' ' + Lname) AS Customer, Address, City, State, Zip, PhoneNum, LicenseNum, Email FROM StorageDB WHERE ID = '" & CusID & "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            Me.customer_txt.Text = Convert.ToString(Data1("Customer"))
            Me.address_txt.Text = Convert.ToString(Data1("Address"))
            Me.city_txt.Text = Convert.ToString(Data1("City"))
            Me.state_txt.Text = Convert.ToString(Data1("State"))
            Me.zip_txt.Text = Convert.ToString(Data1("Zip"))
            Me.Phone_txt.Text = Convert.ToString(Data1("PhoneNum"))
            Me.DLSS_txt.Text = Convert.ToString(Data1("LicenseNum"))
            Me.email_txt.Text = Convert.ToString(Data1("Email"))
        End While
    End Sub
    Private Sub ShowMainA5(sender As Object, e As EventArgs) Handles StallA5.MouseEnter

        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim Stallnum1 As String
        Dim BtnName As String
        BtnName = StallB1.Text
        'Dim Rent1 As String
        'Dim Duedate1 As String
        'Dim DateRented1 As String
        CusID = ""
        con1.ConnectionString = StringConnection
        con1.Open()
        cmd1.Connection = con1
        cmd1.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallA5.Text + "'"
        Dim Data2 As SqlDataReader = cmd1.ExecuteReader()

        While Data2.Read()
            CusID = Convert.ToString(Data2("ID"))
            Stallnum1 = Convert.ToString(Data2("StallNum"))
            'Rent1 = Convert.ToString(Data1("Rent"))
            Dim Duedate1 = Convert.ToString(Data2("DueDate"))
            'DateRented1 = Convert.ToString(Data1("DateRented"))
            Me.txtduedate.Text = Convert.ToString(Data2("DueDate"))
        End While

        'Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'StallB1.Text = CusID
        'Index = e.RowIndex
        'Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'CusID = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select (Fname + ' ' + Lname) AS Customer, Address, City, State, Zip, PhoneNum, LicenseNum, Email FROM StorageDB WHERE ID = '" & CusID & "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            Me.customer_txt.Text = Convert.ToString(Data1("Customer"))
            Me.address_txt.Text = Convert.ToString(Data1("Address"))
            Me.city_txt.Text = Convert.ToString(Data1("City"))
            Me.state_txt.Text = Convert.ToString(Data1("State"))
            Me.zip_txt.Text = Convert.ToString(Data1("Zip"))
            Me.Phone_txt.Text = Convert.ToString(Data1("PhoneNum"))
            Me.DLSS_txt.Text = Convert.ToString(Data1("LicenseNum"))
            Me.email_txt.Text = Convert.ToString(Data1("Email"))
        End While
    End Sub
    Private Sub ShowMainA6(sender As Object, e As EventArgs) Handles StallA6.MouseEnter

        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim Stallnum1 As String
        Dim BtnName As String
        BtnName = StallB1.Text
        'Dim Rent1 As String
        'Dim Duedate1 As String
        'Dim DateRented1 As String
        CusID = ""
        con1.ConnectionString = StringConnection
        con1.Open()
        cmd1.Connection = con1
        cmd1.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallA6.Text + "'"
        Dim Data2 As SqlDataReader = cmd1.ExecuteReader()

        While Data2.Read()
            CusID = Convert.ToString(Data2("ID"))
            Stallnum1 = Convert.ToString(Data2("StallNum"))
            'Rent1 = Convert.ToString(Data1("Rent"))
            Dim Duedate1 = Convert.ToString(Data2("DueDate"))
            'DateRented1 = Convert.ToString(Data1("DateRented"))
            Me.txtduedate.Text = Convert.ToString(Data2("DueDate"))
        End While

        'Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'StallB1.Text = CusID
        'Index = e.RowIndex
        'Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'CusID = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select (Fname + ' ' + Lname) AS Customer, Address, City, State, Zip, PhoneNum, LicenseNum, Email FROM StorageDB WHERE ID = '" & CusID & "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            Me.customer_txt.Text = Convert.ToString(Data1("Customer"))
            Me.address_txt.Text = Convert.ToString(Data1("Address"))
            Me.city_txt.Text = Convert.ToString(Data1("City"))
            Me.state_txt.Text = Convert.ToString(Data1("State"))
            Me.zip_txt.Text = Convert.ToString(Data1("Zip"))
            Me.Phone_txt.Text = Convert.ToString(Data1("PhoneNum"))
            Me.DLSS_txt.Text = Convert.ToString(Data1("LicenseNum"))
            Me.email_txt.Text = Convert.ToString(Data1("Email"))
        End While
    End Sub
    Private Sub ShowMainA7(sender As Object, e As EventArgs) Handles StallA7.MouseEnter

        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim Stallnum1 As String
        Dim BtnName As String
        BtnName = StallB1.Text
        'Dim Rent1 As String
        'Dim Duedate1 As String
        'Dim DateRented1 As String
        CusID = ""
        con1.ConnectionString = StringConnection
        con1.Open()
        cmd1.Connection = con1
        cmd1.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallA7.Text + "'"
        Dim Data2 As SqlDataReader = cmd1.ExecuteReader()

        While Data2.Read()
            CusID = Convert.ToString(Data2("ID"))
            Stallnum1 = Convert.ToString(Data2("StallNum"))
            'Rent1 = Convert.ToString(Data1("Rent"))
            Dim Duedate1 = Convert.ToString(Data2("DueDate"))
            'DateRented1 = Convert.ToString(Data1("DateRented"))
            Me.txtduedate.Text = Convert.ToString(Data2("DueDate"))
        End While

        'Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'StallB1.Text = CusID
        'Index = e.RowIndex
        'Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'CusID = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select (Fname + ' ' + Lname) AS Customer, Address, City, State, Zip, PhoneNum, LicenseNum, Email FROM StorageDB WHERE ID = '" & CusID & "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            Me.customer_txt.Text = Convert.ToString(Data1("Customer"))
            Me.address_txt.Text = Convert.ToString(Data1("Address"))
            Me.city_txt.Text = Convert.ToString(Data1("City"))
            Me.state_txt.Text = Convert.ToString(Data1("State"))
            Me.zip_txt.Text = Convert.ToString(Data1("Zip"))
            Me.Phone_txt.Text = Convert.ToString(Data1("PhoneNum"))
            Me.DLSS_txt.Text = Convert.ToString(Data1("LicenseNum"))
            Me.email_txt.Text = Convert.ToString(Data1("Email"))
        End While
    End Sub
    Private Sub ShowMainA8(sender As Object, e As EventArgs) Handles StallA8.MouseEnter

        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim Stallnum1 As String
        Dim BtnName As String
        BtnName = StallB1.Text
        'Dim Rent1 As String
        'Dim Duedate1 As String
        'Dim DateRented1 As String
        CusID = ""
        con1.ConnectionString = StringConnection
        con1.Open()
        cmd1.Connection = con1
        cmd1.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallA8.Text + "'"
        Dim Data2 As SqlDataReader = cmd1.ExecuteReader()

        While Data2.Read()
            CusID = Convert.ToString(Data2("ID"))
            Stallnum1 = Convert.ToString(Data2("StallNum"))
            'Rent1 = Convert.ToString(Data1("Rent"))
            Dim Duedate1 = Convert.ToString(Data2("DueDate"))
            'DateRented1 = Convert.ToString(Data1("DateRented"))
            Me.txtduedate.Text = Convert.ToString(Data2("DueDate"))
        End While

        'Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'StallB1.Text = CusID
        'Index = e.RowIndex
        'Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'CusID = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select (Fname + ' ' + Lname) AS Customer, Address, City, State, Zip, PhoneNum, LicenseNum, Email FROM StorageDB WHERE ID = '" & CusID & "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            Me.customer_txt.Text = Convert.ToString(Data1("Customer"))
            Me.address_txt.Text = Convert.ToString(Data1("Address"))
            Me.city_txt.Text = Convert.ToString(Data1("City"))
            Me.state_txt.Text = Convert.ToString(Data1("State"))
            Me.zip_txt.Text = Convert.ToString(Data1("Zip"))
            Me.Phone_txt.Text = Convert.ToString(Data1("PhoneNum"))
            Me.DLSS_txt.Text = Convert.ToString(Data1("LicenseNum"))
            Me.email_txt.Text = Convert.ToString(Data1("Email"))
        End While
    End Sub
    Private Sub ShowMainA9(sender As Object, e As EventArgs) Handles StallA9.MouseEnter

        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim Stallnum1 As String
        Dim BtnName As String
        BtnName = StallB1.Text
        'Dim Rent1 As String
        'Dim Duedate1 As String
        'Dim DateRented1 As String
        CusID = ""
        con1.ConnectionString = StringConnection
        con1.Open()
        cmd1.Connection = con1
        cmd1.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallA9.Text + "'"
        Dim Data2 As SqlDataReader = cmd1.ExecuteReader()

        While Data2.Read()
            CusID = Convert.ToString(Data2("ID"))
            Stallnum1 = Convert.ToString(Data2("StallNum"))
            'Rent1 = Convert.ToString(Data1("Rent"))
            Dim Duedate1 = Convert.ToString(Data2("DueDate"))
            'DateRented1 = Convert.ToString(Data1("DateRented"))
            Me.txtduedate.Text = Convert.ToString(Data2("DueDate"))
        End While

        'Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'StallB1.Text = CusID
        'Index = e.RowIndex
        'Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'CusID = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select (Fname + ' ' + Lname) AS Customer, Address, City, State, Zip, PhoneNum, LicenseNum, Email FROM StorageDB WHERE ID = '" & CusID & "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            Me.customer_txt.Text = Convert.ToString(Data1("Customer"))
            Me.address_txt.Text = Convert.ToString(Data1("Address"))
            Me.city_txt.Text = Convert.ToString(Data1("City"))
            Me.state_txt.Text = Convert.ToString(Data1("State"))
            Me.zip_txt.Text = Convert.ToString(Data1("Zip"))
            Me.Phone_txt.Text = Convert.ToString(Data1("PhoneNum"))
            Me.DLSS_txt.Text = Convert.ToString(Data1("LicenseNum"))
            Me.email_txt.Text = Convert.ToString(Data1("Email"))
        End While
    End Sub
    Private Sub ShowMainA10(sender As Object, e As EventArgs) Handles StallA10.MouseEnter

        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim Stallnum1 As String
        Dim BtnName As String
        BtnName = StallB1.Text
        'Dim Rent1 As String
        'Dim Duedate1 As String
        'Dim DateRented1 As String
        CusID = ""
        con1.ConnectionString = StringConnection
        con1.Open()
        cmd1.Connection = con1
        cmd1.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallA10.Text + "'"
        Dim Data2 As SqlDataReader = cmd1.ExecuteReader()

        While Data2.Read()
            CusID = Convert.ToString(Data2("ID"))
            Stallnum1 = Convert.ToString(Data2("StallNum"))
            'Rent1 = Convert.ToString(Data1("Rent"))
            Dim Duedate1 = Convert.ToString(Data2("DueDate"))
            'DateRented1 = Convert.ToString(Data1("DateRented"))
            Me.txtduedate.Text = Convert.ToString(Data2("DueDate"))
        End While

        'Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'StallB1.Text = CusID
        'Index = e.RowIndex
        'Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'CusID = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select (Fname + ' ' + Lname) AS Customer, Address, City, State, Zip, PhoneNum, LicenseNum, Email FROM StorageDB WHERE ID = '" & CusID & "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            Me.customer_txt.Text = Convert.ToString(Data1("Customer"))
            Me.address_txt.Text = Convert.ToString(Data1("Address"))
            Me.city_txt.Text = Convert.ToString(Data1("City"))
            Me.state_txt.Text = Convert.ToString(Data1("State"))
            Me.zip_txt.Text = Convert.ToString(Data1("Zip"))
            Me.Phone_txt.Text = Convert.ToString(Data1("PhoneNum"))
            Me.DLSS_txt.Text = Convert.ToString(Data1("LicenseNum"))
            Me.email_txt.Text = Convert.ToString(Data1("Email"))
        End While
    End Sub
    Private Sub ShowMainA11(sender As Object, e As EventArgs) Handles StallA11.MouseEnter

        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim Stallnum1 As String
        Dim BtnName As String
        BtnName = StallB1.Text
        'Dim Rent1 As String
        'Dim Duedate1 As String
        'Dim DateRented1 As String
        CusID = ""
        con1.ConnectionString = StringConnection
        con1.Open()
        cmd1.Connection = con1
        cmd1.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallA11.Text + "'"
        Dim Data2 As SqlDataReader = cmd1.ExecuteReader()

        While Data2.Read()
            CusID = Convert.ToString(Data2("ID"))
            Stallnum1 = Convert.ToString(Data2("StallNum"))
            'Rent1 = Convert.ToString(Data1("Rent"))
            Dim Duedate1 = Convert.ToString(Data2("DueDate"))
            'DateRented1 = Convert.ToString(Data1("DateRented"))
            Me.txtduedate.Text = Convert.ToString(Data2("DueDate"))
        End While

        'Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'StallB1.Text = CusID
        'Index = e.RowIndex
        'Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'CusID = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select (Fname + ' ' + Lname) AS Customer, Address, City, State, Zip, PhoneNum, LicenseNum, Email FROM StorageDB WHERE ID = '" & CusID & "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            Me.customer_txt.Text = Convert.ToString(Data1("Customer"))
            Me.address_txt.Text = Convert.ToString(Data1("Address"))
            Me.city_txt.Text = Convert.ToString(Data1("City"))
            Me.state_txt.Text = Convert.ToString(Data1("State"))
            Me.zip_txt.Text = Convert.ToString(Data1("Zip"))
            Me.Phone_txt.Text = Convert.ToString(Data1("PhoneNum"))
            Me.DLSS_txt.Text = Convert.ToString(Data1("LicenseNum"))
            Me.email_txt.Text = Convert.ToString(Data1("Email"))
        End While
    End Sub
    Private Sub ShowMainB1(sender As Object, e As EventArgs) Handles StallB1.MouseEnter

        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim Stallnum1 As String
        Dim BtnName As String
        BtnName = StallB1.Text
        'Dim Rent1 As String
        'Dim Duedate1 As String
        'Dim DateRented1 As String
        CusID = ""
        con1.ConnectionString = StringConnection
        con1.Open()
        cmd1.Connection = con1
        cmd1.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallB1.Text + "'"
        Dim Data2 As SqlDataReader = cmd1.ExecuteReader()

        While Data2.Read()
            CusID = Convert.ToString(Data2("ID"))
            Stallnum1 = Convert.ToString(Data2("StallNum"))
            'Rent1 = Convert.ToString(Data1("Rent"))
            Dim Duedate1 = Convert.ToString(Data2("DueDate"))
            'DateRented1 = Convert.ToString(Data1("DateRented"))
            Me.txtduedate.Text = Convert.ToString(Data2("DueDate"))
        End While

        'Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'StallB1.Text = CusID
        'Index = e.RowIndex
        'Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'CusID = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select (Fname + ' ' + Lname) AS Customer, Address, City, State, Zip, PhoneNum, LicenseNum, Email FROM StorageDB WHERE ID = '" & CusID & "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            Me.customer_txt.Text = Convert.ToString(Data1("Customer"))
            Me.address_txt.Text = Convert.ToString(Data1("Address"))
            Me.city_txt.Text = Convert.ToString(Data1("City"))
            Me.state_txt.Text = Convert.ToString(Data1("State"))
            Me.zip_txt.Text = Convert.ToString(Data1("Zip"))
            Me.Phone_txt.Text = Convert.ToString(Data1("PhoneNum"))
            Me.DLSS_txt.Text = Convert.ToString(Data1("LicenseNum"))
            Me.email_txt.Text = Convert.ToString(Data1("Email"))
        End While
    End Sub
    Private Sub ShowMainB2(sender As Object, e As EventArgs) Handles StallB2.MouseEnter

        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim Stallnum1 As String
        Dim BtnName As String
        BtnName = StallB1.Text
        'Dim Rent1 As String
        'Dim Duedate1 As String
        'Dim DateRented1 As String
        CusID = ""
        con1.ConnectionString = StringConnection
        con1.Open()
        cmd1.Connection = con1
        cmd1.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallB2.Text + "'"
        Dim Data2 As SqlDataReader = cmd1.ExecuteReader()

        While Data2.Read()
            CusID = Convert.ToString(Data2("ID"))
            Stallnum1 = Convert.ToString(Data2("StallNum"))
            'Rent1 = Convert.ToString(Data1("Rent"))
            Dim Duedate1 = Convert.ToString(Data2("DueDate"))
            'DateRented1 = Convert.ToString(Data1("DateRented"))
            Me.txtduedate.Text = Convert.ToString(Data2("DueDate"))
        End While

        'Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'StallB1.Text = CusID
        'Index = e.RowIndex
        'Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'CusID = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select (Fname + ' ' + Lname) AS Customer, Address, City, State, Zip, PhoneNum, LicenseNum, Email FROM StorageDB WHERE ID = '" & CusID & "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            Me.customer_txt.Text = Convert.ToString(Data1("Customer"))
            Me.address_txt.Text = Convert.ToString(Data1("Address"))
            Me.city_txt.Text = Convert.ToString(Data1("City"))
            Me.state_txt.Text = Convert.ToString(Data1("State"))
            Me.zip_txt.Text = Convert.ToString(Data1("Zip"))
            Me.Phone_txt.Text = Convert.ToString(Data1("PhoneNum"))
            Me.DLSS_txt.Text = Convert.ToString(Data1("LicenseNum"))
            Me.email_txt.Text = Convert.ToString(Data1("Email"))
        End While
    End Sub
    Private Sub ShowMainB3(sender As Object, e As EventArgs) Handles StallB3.MouseEnter

        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim Stallnum1 As String
        Dim BtnName As String
        BtnName = StallB1.Text
        'Dim Rent1 As String
        'Dim Duedate1 As String
        'Dim DateRented1 As String
        CusID = ""
        con1.ConnectionString = StringConnection
        con1.Open()
        cmd1.Connection = con1
        cmd1.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallB3.Text + "'"
        Dim Data2 As SqlDataReader = cmd1.ExecuteReader()

        While Data2.Read()
            CusID = Convert.ToString(Data2("ID"))
            Stallnum1 = Convert.ToString(Data2("StallNum"))
            'Rent1 = Convert.ToString(Data1("Rent"))
            Dim Duedate1 = Convert.ToString(Data2("DueDate"))
            'DateRented1 = Convert.ToString(Data1("DateRented"))
            Me.txtduedate.Text = Convert.ToString(Data2("DueDate"))
        End While

        'Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'StallB1.Text = CusID
        'Index = e.RowIndex
        'Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'CusID = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select (Fname + ' ' + Lname) AS Customer, Address, City, State, Zip, PhoneNum, LicenseNum, Email FROM StorageDB WHERE ID = '" & CusID & "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            Me.customer_txt.Text = Convert.ToString(Data1("Customer"))
            Me.address_txt.Text = Convert.ToString(Data1("Address"))
            Me.city_txt.Text = Convert.ToString(Data1("City"))
            Me.state_txt.Text = Convert.ToString(Data1("State"))
            Me.zip_txt.Text = Convert.ToString(Data1("Zip"))
            Me.Phone_txt.Text = Convert.ToString(Data1("PhoneNum"))
            Me.DLSS_txt.Text = Convert.ToString(Data1("LicenseNum"))
            Me.email_txt.Text = Convert.ToString(Data1("Email"))
        End While
    End Sub
    Private Sub ShowMainB4(sender As Object, e As EventArgs) Handles StallB4.MouseEnter

        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim Stallnum1 As String
        Dim BtnName As String
        BtnName = StallB1.Text
        'Dim Rent1 As String
        'Dim Duedate1 As String
        'Dim DateRented1 As String
        CusID = ""
        con1.ConnectionString = StringConnection
        con1.Open()
        cmd1.Connection = con1
        cmd1.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallB4.Text + "'"
        Dim Data2 As SqlDataReader = cmd1.ExecuteReader()

        While Data2.Read()
            CusID = Convert.ToString(Data2("ID"))
            Stallnum1 = Convert.ToString(Data2("StallNum"))
            'Rent1 = Convert.ToString(Data1("Rent"))
            Dim Duedate1 = Convert.ToString(Data2("DueDate"))
            'DateRented1 = Convert.ToString(Data1("DateRented"))
            Me.txtduedate.Text = Convert.ToString(Data2("DueDate"))
        End While

        'Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'StallB1.Text = CusID
        'Index = e.RowIndex
        'Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'CusID = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select (Fname + ' ' + Lname) AS Customer, Address, City, State, Zip, PhoneNum, LicenseNum, Email FROM StorageDB WHERE ID = '" & CusID & "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            Me.customer_txt.Text = Convert.ToString(Data1("Customer"))
            Me.address_txt.Text = Convert.ToString(Data1("Address"))
            Me.city_txt.Text = Convert.ToString(Data1("City"))
            Me.state_txt.Text = Convert.ToString(Data1("State"))
            Me.zip_txt.Text = Convert.ToString(Data1("Zip"))
            Me.Phone_txt.Text = Convert.ToString(Data1("PhoneNum"))
            Me.DLSS_txt.Text = Convert.ToString(Data1("LicenseNum"))
            Me.email_txt.Text = Convert.ToString(Data1("Email"))
        End While
    End Sub
    Private Sub ShowMainB5(sender As Object, e As EventArgs) Handles StallB5.MouseEnter

        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim Stallnum1 As String
        Dim BtnName As String
        BtnName = StallB1.Text
        'Dim Rent1 As String
        'Dim Duedate1 As String
        'Dim DateRented1 As String
        CusID = ""
        con1.ConnectionString = StringConnection
        con1.Open()
        cmd1.Connection = con1
        cmd1.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallB5.Text + "'"
        Dim Data2 As SqlDataReader = cmd1.ExecuteReader()

        While Data2.Read()
            CusID = Convert.ToString(Data2("ID"))
            Stallnum1 = Convert.ToString(Data2("StallNum"))
            'Rent1 = Convert.ToString(Data1("Rent"))
            Dim Duedate1 = Convert.ToString(Data2("DueDate"))
            'DateRented1 = Convert.ToString(Data1("DateRented"))
            Me.txtduedate.Text = Convert.ToString(Data2("DueDate"))
        End While

        'Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'StallB1.Text = CusID
        'Index = e.RowIndex
        'Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'CusID = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select (Fname + ' ' + Lname) AS Customer, Address, City, State, Zip, PhoneNum, LicenseNum, Email FROM StorageDB WHERE ID = '" & CusID & "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            Me.customer_txt.Text = Convert.ToString(Data1("Customer"))
            Me.address_txt.Text = Convert.ToString(Data1("Address"))
            Me.city_txt.Text = Convert.ToString(Data1("City"))
            Me.state_txt.Text = Convert.ToString(Data1("State"))
            Me.zip_txt.Text = Convert.ToString(Data1("Zip"))
            Me.Phone_txt.Text = Convert.ToString(Data1("PhoneNum"))
            Me.DLSS_txt.Text = Convert.ToString(Data1("LicenseNum"))
            Me.email_txt.Text = Convert.ToString(Data1("Email"))
        End While
    End Sub
    Private Sub ShowMainB6(sender As Object, e As EventArgs) Handles StallB6.MouseEnter

        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim Stallnum1 As String
        Dim BtnName As String
        BtnName = StallB1.Text
        'Dim Rent1 As String
        'Dim Duedate1 As String
        'Dim DateRented1 As String
        CusID = ""
        con1.ConnectionString = StringConnection
        con1.Open()
        cmd1.Connection = con1
        cmd1.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallB6.Text + "'"
        Dim Data2 As SqlDataReader = cmd1.ExecuteReader()

        While Data2.Read()
            CusID = Convert.ToString(Data2("ID"))
            Stallnum1 = Convert.ToString(Data2("StallNum"))
            'Rent1 = Convert.ToString(Data1("Rent"))
            Dim Duedate1 = Convert.ToString(Data2("DueDate"))
            'DateRented1 = Convert.ToString(Data1("DateRented"))
            Me.txtduedate.Text = Convert.ToString(Data2("DueDate"))
        End While

        'Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'StallB1.Text = CusID
        'Index = e.RowIndex
        'Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'CusID = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select (Fname + ' ' + Lname) AS Customer, Address, City, State, Zip, PhoneNum, LicenseNum, Email FROM StorageDB WHERE ID = '" & CusID & "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            Me.customer_txt.Text = Convert.ToString(Data1("Customer"))
            Me.address_txt.Text = Convert.ToString(Data1("Address"))
            Me.city_txt.Text = Convert.ToString(Data1("City"))
            Me.state_txt.Text = Convert.ToString(Data1("State"))
            Me.zip_txt.Text = Convert.ToString(Data1("Zip"))
            Me.Phone_txt.Text = Convert.ToString(Data1("PhoneNum"))
            Me.DLSS_txt.Text = Convert.ToString(Data1("LicenseNum"))
            Me.email_txt.Text = Convert.ToString(Data1("Email"))
        End While
    End Sub
    Private Sub ShowMainB7(sender As Object, e As EventArgs) Handles StallB7.MouseEnter

        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim Stallnum1 As String
        Dim BtnName As String
        BtnName = StallB1.Text
        'Dim Rent1 As String
        'Dim Duedate1 As String
        'Dim DateRented1 As String
        CusID = ""
        con1.ConnectionString = StringConnection
        con1.Open()
        cmd1.Connection = con1
        cmd1.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallB7.Text + "'"
        Dim Data2 As SqlDataReader = cmd1.ExecuteReader()

        While Data2.Read()
            CusID = Convert.ToString(Data2("ID"))
            Stallnum1 = Convert.ToString(Data2("StallNum"))
            'Rent1 = Convert.ToString(Data1("Rent"))
            Dim Duedate1 = Convert.ToString(Data2("DueDate"))
            'DateRented1 = Convert.ToString(Data1("DateRented"))
            Me.txtduedate.Text = Convert.ToString(Data2("DueDate"))
        End While

        'Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'StallB1.Text = CusID
        'Index = e.RowIndex
        'Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'CusID = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select (Fname + ' ' + Lname) AS Customer, Address, City, State, Zip, PhoneNum, LicenseNum, Email FROM StorageDB WHERE ID = '" & CusID & "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            Me.customer_txt.Text = Convert.ToString(Data1("Customer"))
            Me.address_txt.Text = Convert.ToString(Data1("Address"))
            Me.city_txt.Text = Convert.ToString(Data1("City"))
            Me.state_txt.Text = Convert.ToString(Data1("State"))
            Me.zip_txt.Text = Convert.ToString(Data1("Zip"))
            Me.Phone_txt.Text = Convert.ToString(Data1("PhoneNum"))
            Me.DLSS_txt.Text = Convert.ToString(Data1("LicenseNum"))
            Me.email_txt.Text = Convert.ToString(Data1("Email"))
        End While
    End Sub
    Private Sub ShowMainB8(sender As Object, e As EventArgs) Handles StallB8.MouseEnter

        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim Stallnum1 As String
        Dim BtnName As String
        BtnName = StallB1.Text
        'Dim Rent1 As String
        'Dim Duedate1 As String
        'Dim DateRented1 As String
        CusID = ""
        con1.ConnectionString = StringConnection
        con1.Open()
        cmd1.Connection = con1
        cmd1.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallB8.Text + "'"
        Dim Data2 As SqlDataReader = cmd1.ExecuteReader()

        While Data2.Read()
            CusID = Convert.ToString(Data2("ID"))
            Stallnum1 = Convert.ToString(Data2("StallNum"))
            'Rent1 = Convert.ToString(Data1("Rent"))
            Dim Duedate1 = Convert.ToString(Data2("DueDate"))
            'DateRented1 = Convert.ToString(Data1("DateRented"))
            Me.txtduedate.Text = Convert.ToString(Data2("DueDate"))
        End While

        'Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'StallB1.Text = CusID
        'Index = e.RowIndex
        'Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'CusID = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select (Fname + ' ' + Lname) AS Customer, Address, City, State, Zip, PhoneNum, LicenseNum, Email FROM StorageDB WHERE ID = '" & CusID & "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            Me.customer_txt.Text = Convert.ToString(Data1("Customer"))
            Me.address_txt.Text = Convert.ToString(Data1("Address"))
            Me.city_txt.Text = Convert.ToString(Data1("City"))
            Me.state_txt.Text = Convert.ToString(Data1("State"))
            Me.zip_txt.Text = Convert.ToString(Data1("Zip"))
            Me.Phone_txt.Text = Convert.ToString(Data1("PhoneNum"))
            Me.DLSS_txt.Text = Convert.ToString(Data1("LicenseNum"))
            Me.email_txt.Text = Convert.ToString(Data1("Email"))
        End While
    End Sub
    Private Sub ShowMainB9(sender As Object, e As EventArgs) Handles StallB9.MouseEnter

        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim Stallnum1 As String
        Dim BtnName As String
        BtnName = StallB1.Text
        'Dim Rent1 As String
        'Dim Duedate1 As String
        'Dim DateRented1 As String
        CusID = ""
        con1.ConnectionString = StringConnection
        con1.Open()
        cmd1.Connection = con1
        cmd1.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallB9.Text + "'"
        Dim Data2 As SqlDataReader = cmd1.ExecuteReader()

        While Data2.Read()
            CusID = Convert.ToString(Data2("ID"))
            Stallnum1 = Convert.ToString(Data2("StallNum"))
            'Rent1 = Convert.ToString(Data1("Rent"))
            Dim Duedate1 = Convert.ToString(Data2("DueDate"))
            'DateRented1 = Convert.ToString(Data1("DateRented"))
            Me.txtduedate.Text = Convert.ToString(Data2("DueDate"))
        End While

        'Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'StallB1.Text = CusID
        'Index = e.RowIndex
        'Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'CusID = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select (Fname + ' ' + Lname) AS Customer, Address, City, State, Zip, PhoneNum, LicenseNum, Email FROM StorageDB WHERE ID = '" & CusID & "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            Me.customer_txt.Text = Convert.ToString(Data1("Customer"))
            Me.address_txt.Text = Convert.ToString(Data1("Address"))
            Me.city_txt.Text = Convert.ToString(Data1("City"))
            Me.state_txt.Text = Convert.ToString(Data1("State"))
            Me.zip_txt.Text = Convert.ToString(Data1("Zip"))
            Me.Phone_txt.Text = Convert.ToString(Data1("PhoneNum"))
            Me.DLSS_txt.Text = Convert.ToString(Data1("LicenseNum"))
            Me.email_txt.Text = Convert.ToString(Data1("Email"))
        End While
    End Sub
    Private Sub ShowMainB10(sender As Object, e As EventArgs) Handles StallB10.MouseEnter

        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim Stallnum1 As String
        Dim BtnName As String
        BtnName = StallB1.Text
        'Dim Rent1 As String
        'Dim Duedate1 As String
        'Dim DateRented1 As String
        CusID = ""
        con1.ConnectionString = StringConnection
        con1.Open()
        cmd1.Connection = con1
        cmd1.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallB10.Text + "'"
        Dim Data2 As SqlDataReader = cmd1.ExecuteReader()

        While Data2.Read()
            CusID = Convert.ToString(Data2("ID"))
            Stallnum1 = Convert.ToString(Data2("StallNum"))
            'Rent1 = Convert.ToString(Data1("Rent"))
            Dim Duedate1 = Convert.ToString(Data2("DueDate"))
            'DateRented1 = Convert.ToString(Data1("DateRented"))
            Me.txtduedate.Text = Convert.ToString(Data2("DueDate"))
        End While

        'Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'StallB1.Text = CusID
        'Index = e.RowIndex
        'Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'CusID = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select (Fname + ' ' + Lname) AS Customer, Address, City, State, Zip, PhoneNum, LicenseNum, Email FROM StorageDB WHERE ID = '" & CusID & "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            Me.customer_txt.Text = Convert.ToString(Data1("Customer"))
            Me.address_txt.Text = Convert.ToString(Data1("Address"))
            Me.city_txt.Text = Convert.ToString(Data1("City"))
            Me.state_txt.Text = Convert.ToString(Data1("State"))
            Me.zip_txt.Text = Convert.ToString(Data1("Zip"))
            Me.Phone_txt.Text = Convert.ToString(Data1("PhoneNum"))
            Me.DLSS_txt.Text = Convert.ToString(Data1("LicenseNum"))
            Me.email_txt.Text = Convert.ToString(Data1("Email"))
        End While
    End Sub
    Private Sub ShowMainB11(sender As Object, e As EventArgs) Handles StallB11.MouseEnter

        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim Stallnum1 As String
        Dim BtnName As String
        BtnName = StallB1.Text
        'Dim Rent1 As String
        'Dim Duedate1 As String
        'Dim DateRented1 As String
        CusID = ""
        con1.ConnectionString = StringConnection
        con1.Open()
        cmd1.Connection = con1
        cmd1.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallB11.Text + "'"
        Dim Data2 As SqlDataReader = cmd1.ExecuteReader()

        While Data2.Read()
            CusID = Convert.ToString(Data2("ID"))
            Stallnum1 = Convert.ToString(Data2("StallNum"))
            'Rent1 = Convert.ToString(Data1("Rent"))
            Dim Duedate1 = Convert.ToString(Data2("DueDate"))
            'DateRented1 = Convert.ToString(Data1("DateRented"))
            Me.txtduedate.Text = Convert.ToString(Data2("DueDate"))
        End While

        'Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'StallB1.Text = CusID
        'Index = e.RowIndex
        'Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'CusID = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select (Fname + ' ' + Lname) AS Customer, Address, City, State, Zip, PhoneNum, LicenseNum, Email FROM StorageDB WHERE ID = '" & CusID & "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            Me.customer_txt.Text = Convert.ToString(Data1("Customer"))
            Me.address_txt.Text = Convert.ToString(Data1("Address"))
            Me.city_txt.Text = Convert.ToString(Data1("City"))
            Me.state_txt.Text = Convert.ToString(Data1("State"))
            Me.zip_txt.Text = Convert.ToString(Data1("Zip"))
            Me.Phone_txt.Text = Convert.ToString(Data1("PhoneNum"))
            Me.DLSS_txt.Text = Convert.ToString(Data1("LicenseNum"))
            Me.email_txt.Text = Convert.ToString(Data1("Email"))
        End While
    End Sub
    Private Sub ShowMainC1(sender As Object, e As EventArgs) Handles StallC1.MouseEnter

        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim Stallnum1 As String
        Dim BtnName As String
        BtnName = StallB1.Text
        'Dim Rent1 As String
        'Dim Duedate1 As String
        'Dim DateRented1 As String
        CusID = ""
        con1.ConnectionString = StringConnection
        con1.Open()
        cmd1.Connection = con1
        cmd1.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallC1.Text + "'"
        Dim Data2 As SqlDataReader = cmd1.ExecuteReader()

        While Data2.Read()
            CusID = Convert.ToString(Data2("ID"))
            Stallnum1 = Convert.ToString(Data2("StallNum"))
            'Rent1 = Convert.ToString(Data1("Rent"))
            Dim Duedate1 = Convert.ToString(Data2("DueDate"))
            'DateRented1 = Convert.ToString(Data1("DateRented"))
            Me.txtduedate.Text = Convert.ToString(Data2("DueDate"))
        End While

        'Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'StallB1.Text = CusID
        'Index = e.RowIndex
        'Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'CusID = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select (Fname + ' ' + Lname) AS Customer, Address, City, State, Zip, PhoneNum, LicenseNum, Email FROM StorageDB WHERE ID = '" & CusID & "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            Me.customer_txt.Text = Convert.ToString(Data1("Customer"))
            Me.address_txt.Text = Convert.ToString(Data1("Address"))
            Me.city_txt.Text = Convert.ToString(Data1("City"))
            Me.state_txt.Text = Convert.ToString(Data1("State"))
            Me.zip_txt.Text = Convert.ToString(Data1("Zip"))
            Me.Phone_txt.Text = Convert.ToString(Data1("PhoneNum"))
            Me.DLSS_txt.Text = Convert.ToString(Data1("LicenseNum"))
            Me.email_txt.Text = Convert.ToString(Data1("Email"))
        End While
    End Sub
    Private Sub ShowMainC2(sender As Object, e As EventArgs) Handles StallC2.MouseEnter

        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim Stallnum1 As String
        Dim BtnName As String
        BtnName = StallB1.Text
        'Dim Rent1 As String
        'Dim Duedate1 As String
        'Dim DateRented1 As String
        CusID = ""
        con1.ConnectionString = StringConnection
        con1.Open()
        cmd1.Connection = con1
        cmd1.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallC2.Text + "'"
        Dim Data2 As SqlDataReader = cmd1.ExecuteReader()

        While Data2.Read()
            CusID = Convert.ToString(Data2("ID"))
            Stallnum1 = Convert.ToString(Data2("StallNum"))
            'Rent1 = Convert.ToString(Data1("Rent"))
            Dim Duedate1 = Convert.ToString(Data2("DueDate"))
            'DateRented1 = Convert.ToString(Data1("DateRented"))
            Me.txtduedate.Text = Convert.ToString(Data2("DueDate"))
        End While

        'Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'StallB1.Text = CusID
        'Index = e.RowIndex
        'Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'CusID = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select (Fname + ' ' + Lname) AS Customer, Address, City, State, Zip, PhoneNum, LicenseNum, Email FROM StorageDB WHERE ID = '" & CusID & "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            Me.customer_txt.Text = Convert.ToString(Data1("Customer"))
            Me.address_txt.Text = Convert.ToString(Data1("Address"))
            Me.city_txt.Text = Convert.ToString(Data1("City"))
            Me.state_txt.Text = Convert.ToString(Data1("State"))
            Me.zip_txt.Text = Convert.ToString(Data1("Zip"))
            Me.Phone_txt.Text = Convert.ToString(Data1("PhoneNum"))
            Me.DLSS_txt.Text = Convert.ToString(Data1("LicenseNum"))
            Me.email_txt.Text = Convert.ToString(Data1("Email"))
        End While
    End Sub
    Private Sub ShowMainC3(sender As Object, e As EventArgs) Handles StallC3.MouseEnter

        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim Stallnum1 As String
        Dim BtnName As String
        BtnName = StallB1.Text
        'Dim Rent1 As String
        'Dim Duedate1 As String
        'Dim DateRented1 As String
        CusID = ""
        con1.ConnectionString = StringConnection
        con1.Open()
        cmd1.Connection = con1
        cmd1.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallC3.Text + "'"
        Dim Data2 As SqlDataReader = cmd1.ExecuteReader()

        While Data2.Read()
            CusID = Convert.ToString(Data2("ID"))
            Stallnum1 = Convert.ToString(Data2("StallNum"))
            'Rent1 = Convert.ToString(Data1("Rent"))
            Dim Duedate1 = Convert.ToString(Data2("DueDate"))
            'DateRented1 = Convert.ToString(Data1("DateRented"))
            Me.txtduedate.Text = Convert.ToString(Data2("DueDate"))
        End While

        'Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'StallB1.Text = CusID
        'Index = e.RowIndex
        'Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'CusID = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select (Fname + ' ' + Lname) AS Customer, Address, City, State, Zip, PhoneNum, LicenseNum, Email FROM StorageDB WHERE ID = '" & CusID & "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            Me.customer_txt.Text = Convert.ToString(Data1("Customer"))
            Me.address_txt.Text = Convert.ToString(Data1("Address"))
            Me.city_txt.Text = Convert.ToString(Data1("City"))
            Me.state_txt.Text = Convert.ToString(Data1("State"))
            Me.zip_txt.Text = Convert.ToString(Data1("Zip"))
            Me.Phone_txt.Text = Convert.ToString(Data1("PhoneNum"))
            Me.DLSS_txt.Text = Convert.ToString(Data1("LicenseNum"))
            Me.email_txt.Text = Convert.ToString(Data1("Email"))
        End While
    End Sub
    Private Sub ShowMainC4(sender As Object, e As EventArgs) Handles StallC4.MouseEnter

        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim Stallnum1 As String
        Dim BtnName As String
        BtnName = StallB1.Text
        'Dim Rent1 As String
        'Dim Duedate1 As String
        'Dim DateRented1 As String
        CusID = ""
        con1.ConnectionString = StringConnection
        con1.Open()
        cmd1.Connection = con1
        cmd1.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallC4.Text + "'"
        Dim Data2 As SqlDataReader = cmd1.ExecuteReader()

        While Data2.Read()
            CusID = Convert.ToString(Data2("ID"))
            Stallnum1 = Convert.ToString(Data2("StallNum"))
            'Rent1 = Convert.ToString(Data1("Rent"))
            Dim Duedate1 = Convert.ToString(Data2("DueDate"))
            'DateRented1 = Convert.ToString(Data1("DateRented"))
            Me.txtduedate.Text = Convert.ToString(Data2("DueDate"))
        End While

        'Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'StallB1.Text = CusID
        'Index = e.RowIndex
        'Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'CusID = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select (Fname + ' ' + Lname) AS Customer, Address, City, State, Zip, PhoneNum, LicenseNum, Email FROM StorageDB WHERE ID = '" & CusID & "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            Me.customer_txt.Text = Convert.ToString(Data1("Customer"))
            Me.address_txt.Text = Convert.ToString(Data1("Address"))
            Me.city_txt.Text = Convert.ToString(Data1("City"))
            Me.state_txt.Text = Convert.ToString(Data1("State"))
            Me.zip_txt.Text = Convert.ToString(Data1("Zip"))
            Me.Phone_txt.Text = Convert.ToString(Data1("PhoneNum"))
            Me.DLSS_txt.Text = Convert.ToString(Data1("LicenseNum"))
            Me.email_txt.Text = Convert.ToString(Data1("Email"))
        End While
    End Sub
    Private Sub ShowMainC5(sender As Object, e As EventArgs) Handles StallC5.MouseEnter

        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim Stallnum1 As String
        Dim BtnName As String
        BtnName = StallB1.Text
        'Dim Rent1 As String
        'Dim Duedate1 As String
        'Dim DateRented1 As String
        CusID = ""
        con1.ConnectionString = StringConnection
        con1.Open()
        cmd1.Connection = con1
        cmd1.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallC5.Text + "'"
        Dim Data2 As SqlDataReader = cmd1.ExecuteReader()

        While Data2.Read()
            CusID = Convert.ToString(Data2("ID"))
            Stallnum1 = Convert.ToString(Data2("StallNum"))
            'Rent1 = Convert.ToString(Data1("Rent"))
            Dim Duedate1 = Convert.ToString(Data2("DueDate"))
            'DateRented1 = Convert.ToString(Data1("DateRented"))
            Me.txtduedate.Text = Convert.ToString(Data2("DueDate"))
        End While

        'Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'StallB1.Text = CusID
        'Index = e.RowIndex
        'Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'CusID = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select (Fname + ' ' + Lname) AS Customer, Address, City, State, Zip, PhoneNum, LicenseNum, Email FROM StorageDB WHERE ID = '" & CusID & "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            Me.customer_txt.Text = Convert.ToString(Data1("Customer"))
            Me.address_txt.Text = Convert.ToString(Data1("Address"))
            Me.city_txt.Text = Convert.ToString(Data1("City"))
            Me.state_txt.Text = Convert.ToString(Data1("State"))
            Me.zip_txt.Text = Convert.ToString(Data1("Zip"))
            Me.Phone_txt.Text = Convert.ToString(Data1("PhoneNum"))
            Me.DLSS_txt.Text = Convert.ToString(Data1("LicenseNum"))
            Me.email_txt.Text = Convert.ToString(Data1("Email"))
        End While
    End Sub
    Private Sub ShowMainC6(sender As Object, e As EventArgs) Handles StallC6.MouseEnter

        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim Stallnum1 As String
        Dim BtnName As String
        BtnName = StallB1.Text
        'Dim Rent1 As String
        'Dim Duedate1 As String
        'Dim DateRented1 As String
        CusID = ""
        con1.ConnectionString = StringConnection
        con1.Open()
        cmd1.Connection = con1
        cmd1.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallC6.Text + "'"
        Dim Data2 As SqlDataReader = cmd1.ExecuteReader()

        While Data2.Read()
            CusID = Convert.ToString(Data2("ID"))
            Stallnum1 = Convert.ToString(Data2("StallNum"))
            'Rent1 = Convert.ToString(Data1("Rent"))
            Dim Duedate1 = Convert.ToString(Data2("DueDate"))
            'DateRented1 = Convert.ToString(Data1("DateRented"))
            Me.txtduedate.Text = Convert.ToString(Data2("DueDate"))
        End While

        'Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'StallB1.Text = CusID
        'Index = e.RowIndex
        'Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'CusID = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select (Fname + ' ' + Lname) AS Customer, Address, City, State, Zip, PhoneNum, LicenseNum, Email FROM StorageDB WHERE ID = '" & CusID & "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            Me.customer_txt.Text = Convert.ToString(Data1("Customer"))
            Me.address_txt.Text = Convert.ToString(Data1("Address"))
            Me.city_txt.Text = Convert.ToString(Data1("City"))
            Me.state_txt.Text = Convert.ToString(Data1("State"))
            Me.zip_txt.Text = Convert.ToString(Data1("Zip"))
            Me.Phone_txt.Text = Convert.ToString(Data1("PhoneNum"))
            Me.DLSS_txt.Text = Convert.ToString(Data1("LicenseNum"))
            Me.email_txt.Text = Convert.ToString(Data1("Email"))
        End While
    End Sub
    Private Sub ShowMainD1(sender As Object, e As EventArgs) Handles StallD1.MouseEnter

        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim Stallnum1 As String
        Dim BtnName As String
        BtnName = StallB1.Text
        'Dim Rent1 As String
        'Dim Duedate1 As String
        'Dim DateRented1 As String
        CusID = ""
        con1.ConnectionString = StringConnection
        con1.Open()
        cmd1.Connection = con1
        cmd1.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallD1.Text + "'"
        Dim Data2 As SqlDataReader = cmd1.ExecuteReader()

        While Data2.Read()
            CusID = Convert.ToString(Data2("ID"))
            Stallnum1 = Convert.ToString(Data2("StallNum"))
            'Rent1 = Convert.ToString(Data1("Rent"))
            Dim Duedate1 = Convert.ToString(Data2("DueDate"))
            'DateRented1 = Convert.ToString(Data1("DateRented"))
            Me.txtduedate.Text = Convert.ToString(Data2("DueDate"))
        End While

        'Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'StallB1.Text = CusID
        'Index = e.RowIndex
        'Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'CusID = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select (Fname + ' ' + Lname) AS Customer, Address, City, State, Zip, PhoneNum, LicenseNum, Email FROM StorageDB WHERE ID = '" & CusID & "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            Me.customer_txt.Text = Convert.ToString(Data1("Customer"))
            Me.address_txt.Text = Convert.ToString(Data1("Address"))
            Me.city_txt.Text = Convert.ToString(Data1("City"))
            Me.state_txt.Text = Convert.ToString(Data1("State"))
            Me.zip_txt.Text = Convert.ToString(Data1("Zip"))
            Me.Phone_txt.Text = Convert.ToString(Data1("PhoneNum"))
            Me.DLSS_txt.Text = Convert.ToString(Data1("LicenseNum"))
            Me.email_txt.Text = Convert.ToString(Data1("Email"))
        End While
    End Sub
    Private Sub ShowMainD2(sender As Object, e As EventArgs) Handles StallD2.MouseEnter

        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim Stallnum1 As String
        Dim BtnName As String
        BtnName = StallB1.Text
        'Dim Rent1 As String
        'Dim Duedate1 As String
        'Dim DateRented1 As String
        CusID = ""
        con1.ConnectionString = StringConnection
        con1.Open()
        cmd1.Connection = con1
        cmd1.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallD2.Text + "'"
        Dim Data2 As SqlDataReader = cmd1.ExecuteReader()

        While Data2.Read()
            CusID = Convert.ToString(Data2("ID"))
            Stallnum1 = Convert.ToString(Data2("StallNum"))
            'Rent1 = Convert.ToString(Data1("Rent"))
            Dim Duedate1 = Convert.ToString(Data2("DueDate"))
            'DateRented1 = Convert.ToString(Data1("DateRented"))
            Me.txtduedate.Text = Convert.ToString(Data2("DueDate"))
        End While

        'Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'StallB1.Text = CusID
        'Index = e.RowIndex
        'Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'CusID = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select (Fname + ' ' + Lname) AS Customer, Address, City, State, Zip, PhoneNum, LicenseNum, Email FROM StorageDB WHERE ID = '" & CusID & "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            Me.customer_txt.Text = Convert.ToString(Data1("Customer"))
            Me.address_txt.Text = Convert.ToString(Data1("Address"))
            Me.city_txt.Text = Convert.ToString(Data1("City"))
            Me.state_txt.Text = Convert.ToString(Data1("State"))
            Me.zip_txt.Text = Convert.ToString(Data1("Zip"))
            Me.Phone_txt.Text = Convert.ToString(Data1("PhoneNum"))
            Me.DLSS_txt.Text = Convert.ToString(Data1("LicenseNum"))
            Me.email_txt.Text = Convert.ToString(Data1("Email"))
        End While
    End Sub
    Private Sub ShowMainD3(sender As Object, e As EventArgs) Handles StallD3.MouseEnter

        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim Stallnum1 As String
        Dim BtnName As String
        BtnName = StallB1.Text
        'Dim Rent1 As String
        'Dim Duedate1 As String
        'Dim DateRented1 As String
        CusID = ""
        con1.ConnectionString = StringConnection
        con1.Open()
        cmd1.Connection = con1
        cmd1.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallD3.Text + "'"
        Dim Data2 As SqlDataReader = cmd1.ExecuteReader()

        While Data2.Read()
            CusID = Convert.ToString(Data2("ID"))
            Stallnum1 = Convert.ToString(Data2("StallNum"))
            'Rent1 = Convert.ToString(Data1("Rent"))
            Dim Duedate1 = Convert.ToString(Data2("DueDate"))
            'DateRented1 = Convert.ToString(Data1("DateRented"))
            Me.txtduedate.Text = Convert.ToString(Data2("DueDate"))
        End While

        'Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'StallB1.Text = CusID
        'Index = e.RowIndex
        'Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'CusID = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select (Fname + ' ' + Lname) AS Customer, Address, City, State, Zip, PhoneNum, LicenseNum, Email FROM StorageDB WHERE ID = '" & CusID & "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            Me.customer_txt.Text = Convert.ToString(Data1("Customer"))
            Me.address_txt.Text = Convert.ToString(Data1("Address"))
            Me.city_txt.Text = Convert.ToString(Data1("City"))
            Me.state_txt.Text = Convert.ToString(Data1("State"))
            Me.zip_txt.Text = Convert.ToString(Data1("Zip"))
            Me.Phone_txt.Text = Convert.ToString(Data1("PhoneNum"))
            Me.DLSS_txt.Text = Convert.ToString(Data1("LicenseNum"))
            Me.email_txt.Text = Convert.ToString(Data1("Email"))
        End While
    End Sub
    Private Sub ShowMainD4(sender As Object, e As EventArgs) Handles StallD4.MouseEnter

        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim Stallnum1 As String
        Dim BtnName As String
        BtnName = StallB1.Text
        'Dim Rent1 As String
        'Dim Duedate1 As String
        'Dim DateRented1 As String
        CusID = ""
        con1.ConnectionString = StringConnection
        con1.Open()
        cmd1.Connection = con1
        cmd1.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallD4.Text + "'"
        Dim Data2 As SqlDataReader = cmd1.ExecuteReader()

        While Data2.Read()
            CusID = Convert.ToString(Data2("ID"))
            Stallnum1 = Convert.ToString(Data2("StallNum"))
            'Rent1 = Convert.ToString(Data1("Rent"))
            Dim Duedate1 = Convert.ToString(Data2("DueDate"))
            'DateRented1 = Convert.ToString(Data1("DateRented"))
            Me.txtduedate.Text = Convert.ToString(Data2("DueDate"))
        End While

        'Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'StallB1.Text = CusID
        'Index = e.RowIndex
        'Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'CusID = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select (Fname + ' ' + Lname) AS Customer, Address, City, State, Zip, PhoneNum, LicenseNum, Email FROM StorageDB WHERE ID = '" & CusID & "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            Me.customer_txt.Text = Convert.ToString(Data1("Customer"))
            Me.address_txt.Text = Convert.ToString(Data1("Address"))
            Me.city_txt.Text = Convert.ToString(Data1("City"))
            Me.state_txt.Text = Convert.ToString(Data1("State"))
            Me.zip_txt.Text = Convert.ToString(Data1("Zip"))
            Me.Phone_txt.Text = Convert.ToString(Data1("PhoneNum"))
            Me.DLSS_txt.Text = Convert.ToString(Data1("LicenseNum"))
            Me.email_txt.Text = Convert.ToString(Data1("Email"))
        End While
    End Sub
    Private Sub ShowMainD5(sender As Object, e As EventArgs) Handles StallD5.MouseEnter

        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim Stallnum1 As String
        Dim BtnName As String
        BtnName = StallB1.Text
        'Dim Rent1 As String
        'Dim Duedate1 As String
        'Dim DateRented1 As String
        CusID = ""
        con1.ConnectionString = StringConnection
        con1.Open()
        cmd1.Connection = con1
        cmd1.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallD5.Text + "'"
        Dim Data2 As SqlDataReader = cmd1.ExecuteReader()

        While Data2.Read()
            CusID = Convert.ToString(Data2("ID"))
            Stallnum1 = Convert.ToString(Data2("StallNum"))
            'Rent1 = Convert.ToString(Data1("Rent"))
            Dim Duedate1 = Convert.ToString(Data2("DueDate"))
            'DateRented1 = Convert.ToString(Data1("DateRented"))
            Me.txtduedate.Text = Convert.ToString(Data2("DueDate"))
        End While

        'Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'StallB1.Text = CusID
        'Index = e.RowIndex
        'Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'CusID = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select (Fname + ' ' + Lname) AS Customer, Address, City, State, Zip, PhoneNum, LicenseNum, Email FROM StorageDB WHERE ID = '" & CusID & "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            Me.customer_txt.Text = Convert.ToString(Data1("Customer"))
            Me.address_txt.Text = Convert.ToString(Data1("Address"))
            Me.city_txt.Text = Convert.ToString(Data1("City"))
            Me.state_txt.Text = Convert.ToString(Data1("State"))
            Me.zip_txt.Text = Convert.ToString(Data1("Zip"))
            Me.Phone_txt.Text = Convert.ToString(Data1("PhoneNum"))
            Me.DLSS_txt.Text = Convert.ToString(Data1("LicenseNum"))
            Me.email_txt.Text = Convert.ToString(Data1("Email"))
        End While
    End Sub
    Private Sub ShowMainD6(sender As Object, e As EventArgs) Handles StallD6.MouseEnter

        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim Stallnum1 As String
        Dim BtnName As String
        BtnName = StallB1.Text
        'Dim Rent1 As String
        'Dim Duedate1 As String
        'Dim DateRented1 As String
        CusID = ""
        con1.ConnectionString = StringConnection
        con1.Open()
        cmd1.Connection = con1
        cmd1.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallD6.Text + "'"
        Dim Data2 As SqlDataReader = cmd1.ExecuteReader()


        While Data2.Read()
            CusID = Convert.ToString(Data2("ID"))
            Stallnum1 = Convert.ToString(Data2("StallNum"))
            'Rent1 = Convert.ToString(Data1("Rent"))
            Dim Duedate1 = Convert.ToString(Data2("DueDate"))
            'DateRented1 = Convert.ToString(Data1("DateRented"))
            Me.txtduedate.Text = Convert.ToString(Data2("DueDate"))
        End While

        'Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'StallB1.Text = CusID
        'Index = e.RowIndex
        'Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'CusID = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select (Fname + ' ' + Lname) AS Customer, Address, City, State, Zip, PhoneNum, LicenseNum, Email FROM StorageDB WHERE ID = '" & CusID & "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            Me.customer_txt.Text = Convert.ToString(Data1("Customer"))
            Me.address_txt.Text = Convert.ToString(Data1("Address"))
            Me.city_txt.Text = Convert.ToString(Data1("City"))
            Me.state_txt.Text = Convert.ToString(Data1("State"))
            Me.zip_txt.Text = Convert.ToString(Data1("Zip"))
            Me.Phone_txt.Text = Convert.ToString(Data1("PhoneNum"))
            Me.DLSS_txt.Text = Convert.ToString(Data1("LicenseNum"))
            Me.email_txt.Text = Convert.ToString(Data1("Email"))
        End While
    End Sub
End Class