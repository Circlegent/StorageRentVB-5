Imports System.Data.SqlClient


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
    Private Sub S(sender As Object, e As EventArgs) Handles StallA1.MouseEnter
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

    Private Sub S2(sender As Object, e As EventArgs) Handles StallA2.MouseEnter, StallA2.MouseEnter
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
    Private Sub S3(sender As Object, e As EventArgs) Handles StallA3.MouseEnter, StallA3.MouseEnter
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
    Private Sub S4(sender As Object, e As EventArgs) Handles StallA4.MouseEnter, StallA4.MouseEnter
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
    Private Sub S5(sender As Object, e As EventArgs) Handles StallA5.MouseEnter, StallA5.MouseEnter
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
    Private Sub S6(sender As Object, e As EventArgs) Handles StallA6.MouseEnter, StallA6.MouseEnter
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
    Private Sub S7(sender As Object, e As EventArgs) Handles StallA7.MouseEnter, StallA7.MouseEnter
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
    Private Sub S8(sender As Object, e As EventArgs) Handles StallA8.MouseEnter, StallA8.MouseEnter
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
    Private Sub S9(sender As Object, e As EventArgs) Handles StallA9.MouseEnter, StallA9.MouseEnter
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
    Private Sub S10(sender As Object, e As EventArgs) Handles StallA10.MouseEnter, StallA10.MouseEnter
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
    Private Sub S11(sender As Object, e As EventArgs) Handles StallA11.MouseEnter, StallA11.MouseEnter
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
    Private Sub S12(sender As Object, e As EventArgs) Handles StallB1.MouseEnter, StallB1.MouseEnter
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
    Private Sub S13(sender As Object, e As EventArgs) Handles StallB2.MouseEnter, StallB2.MouseEnter
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
    Private Sub S14(sender As Object, e As EventArgs) Handles StallB3.MouseEnter, StallB3.MouseEnter
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
    Private Sub S15(sender As Object, e As EventArgs) Handles StallB4.MouseEnter, StallB4.MouseEnter
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
    Private Sub S16(sender As Object, e As EventArgs) Handles StallB5.MouseEnter, StallB5.MouseEnter
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
    Private Sub S17(sender As Object, e As EventArgs) Handles StallB6.MouseEnter, StallB6.MouseEnter
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
    Private Sub S18(sender As Object, e As EventArgs) Handles StallB7.MouseEnter, StallB7.MouseEnter
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
    Private Sub S19(sender As Object, e As EventArgs) Handles StallB8.MouseEnter, StallB8.MouseEnter
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
    Private Sub S20(sender As Object, e As EventArgs) Handles StallB9.MouseEnter, StallB9.MouseEnter
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
    Private Sub S21(sender As Object, e As EventArgs) Handles StallB10.MouseEnter, StallB10.MouseEnter
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
    Private Sub S22(sender As Object, e As EventArgs) Handles StallB11.MouseEnter, StallB11.MouseEnter
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
    Private Sub S23(sender As Object, e As EventArgs) Handles StallC1.MouseEnter, StallC1.MouseEnter
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
    Private Sub S24(sender As Object, e As EventArgs) Handles StallC2.MouseEnter, StallC2.MouseEnter
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
    Private Sub S25(sender As Object, e As EventArgs) Handles StallC3.MouseEnter, StallC3.MouseEnter
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
    Private Sub S26(sender As Object, e As EventArgs) Handles StallC4.MouseEnter, StallC4.MouseEnter
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
    Private Sub S27(sender As Object, e As EventArgs) Handles StallC5.MouseEnter, StallC5.MouseEnter
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
    Private Sub S28(sender As Object, e As EventArgs) Handles StallC6.MouseEnter, StallC6.MouseEnter
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
    Private Sub S29(sender As Object, e As EventArgs) Handles StallD1.MouseEnter, StallD1.MouseEnter
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
    Private Sub S30(sender As Object, e As EventArgs) Handles StallD2.MouseEnter, StallD2.MouseEnter
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
    Private Sub S31(sender As Object, e As EventArgs) Handles StallD3.MouseEnter, StallD3.MouseEnter
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
    Private Sub S32(sender As Object, e As EventArgs) Handles StallD4.MouseEnter, StallD4.MouseEnter
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
    Private Sub S33(sender As Object, e As EventArgs) Handles StallD5.MouseEnter, StallD5.MouseEnter
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
    Private Sub S34(sender As Object, e As EventArgs) Handles StallD6.MouseEnter, StallD6.MouseEnter
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

        'index = e.RowIndex
        ' Dim selectedRow As DataGridViewRow
        'selectedRow = rentergrid1.Rows(index)
        'id_lbl.Text = selectedRow.Cells(0).Value.ToString()
        'customer_txt.Text = selectedRow.Cells(1).Value.ToString()
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum"
        'ShowLateRenter()


        'Dim UserData1 As DataTable = ExecuteSQL("Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE ID = '" & id_lbl.Text & "'")

        'With StallGrid1
        '.DataSource = UserData1
        '.Columns(0).HeaderText = "ID"
        '.Columns(1).HeaderText = "StallNum"
        '.Columns(2).HeaderText = "Rent"
        '.Columns(3).HeaderText = "DueDate"
        '.Columns(4).HeaderText = "DateRented"
        '.Columns(0).Width = 60
        '.Columns(1).Width = 60
        '.Columns(2).Width = 58
        '.Columns(3).Width = 100
        '.Columns(4).Width = 10
        'StallGrid1.ColumnHeadersVisible = False
        'StallGrid1.RowHeadersVisible = False
        'StallGrid1.Columns("ID").Visible = False
        'StallGrid1.Columns("DateRented").Visible = False
        'End With
        'Dim strExt As String
        ' We set up the For Next loop to iterate the DataGridView rows
        'For Each row As DataGridViewRow In Me.StallGrid1.Rows
        ' Get the READY value from each row as we loop
        ' strExt = row.Cells(3).Value
        '  Apply the color formatting based on your conditions
        'If strExt < Date.Today Then
        'Row.DefaultCellStyle.ForeColor = Color.Red
        'Else
        'Row.DefaultCellStyle.ForeColor = Color.Green
        'End If
        'Next
    End Sub



    Private Sub BtnMain_Click(sender As Object, e As EventArgs) Handles BtnMain.Click
        Dim obj5 As New HMSMain

        ' obj5.RBCheck_rbtn.Visible = False
        ' obj5.RBCash_rbtn.Visible = False
        ' obj5.RBCard_rbtn.Visible = False
        ' obj5.Payment_btn.Visible = False
        ' obj5.unitNum_txt.Select()
        'obj5.CusID = id_lbl.Text
        obj5.Show()
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
End Class