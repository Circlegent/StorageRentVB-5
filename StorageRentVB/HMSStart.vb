Imports System.Data.SqlClient


Public Class HMSStart
    Public Property CusID As String

    Private Sub S(sender As Object, e As EventArgs) Handles StallA1.MouseEnter
        Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
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
        Dim index As Integer
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
        Dim index As Integer
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
        Dim index As Integer
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
        Dim index As Integer
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
        Dim index As Integer
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
        Dim index As Integer
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
        Dim index As Integer
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
        Dim index As Integer
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
        Dim index As Integer
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
        Dim index As Integer
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
    Private Sub HMSStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim index As Integer
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
        Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
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

        If CusID = "" Then

            Dim answer1 As MsgBoxResult
            answer1 = MsgBox("Do you wish to add new customer?", MsgBoxStyle.YesNo)
            If answer1 = MsgBoxResult.Yes Then
                CustEdit.Show()
            Else
                CusID = 1
                HMSMain.CusID = CusID
                HMSMain.Show()
            End If

        Else
            HMSMain.CusID = CusID
            HMSMain.Show()
        End If
    End Sub

    Private Sub StallA2_Click(sender As Object, e As EventArgs) Handles StallA2.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
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
        If CusID = "" Then

            Dim answer1 As MsgBoxResult
            answer1 = MsgBox("Do you wish to add new customer?", MsgBoxStyle.YesNo)
            If answer1 = MsgBoxResult.Yes Then
                CustEdit.Show()
            Else
                CusID = 1
                HMSMain.CusID = CusID
                HMSMain.Show()
            End If

        Else

            HMSMain.CusID = CusID
            HMSMain.Show()
        End If
    End Sub

    Private Sub StallA3_Click(sender As Object, e As EventArgs) Handles StallA3.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
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
        If CusID = "" Then

            Dim answer1 As MsgBoxResult
            answer1 = MsgBox("Do you wish to add new customer?", MsgBoxStyle.YesNo)
            If answer1 = MsgBoxResult.Yes Then
                CustEdit.Show()
            Else
                CusID = 1
                HMSMain.CusID = CusID
                HMSMain.Show()
            End If

        Else
            HMSMain.CusID = CusID
            HMSMain.Show()
        End If
        'Dim obj5 As New HMSMain

        ' obj5.RBCheck_rbtn.Visible = False
        ' obj5.RBCash_rbtn.Visible = False
        ' obj5.RBCard_rbtn.Visible = False
        ' obj5.Payment_btn.Visible = False
        ' obj5.unitNum_txt.Select()

    End Sub

    Private Sub StallA4_Click(sender As Object, e As EventArgs) Handles StallA4.Click
        Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
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

        Dim obj5 As New HMSMain

        ' obj5.RBCheck_rbtn.Visible = False
        ' obj5.RBCash_rbtn.Visible = False
        ' obj5.RBCard_rbtn.Visible = False
        ' obj5.Payment_btn.Visible = False
        ' obj5.unitNum_txt.Select()
        obj5.CusID = ID1
        obj5.Show()
    End Sub



    Private Sub StallA5_Click(sender As Object, e As EventArgs) Handles StallA5.Click
        Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
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

        If CusID = "" Then

            Dim answer1 As MsgBoxResult
            answer1 = MsgBox("Do you wish to add new customer?", MsgBoxStyle.YesNo)
            If answer1 = MsgBoxResult.Yes Then
                CustEdit.Show()
            Else
                CusID = 1
                HMSMain.CusID = CusID
                HMSMain.Show()
            End If

        Else
            HMSMain.CusID = CusID
            HMSMain.Show()
        End If
    End Sub

    Private Sub StallA6_Click(sender As Object, e As EventArgs) Handles StallA6.Click
        Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
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

        If CusID = "" Then

            Dim answer1 As MsgBoxResult
            answer1 = MsgBox("Do you wish to add new customer?", MsgBoxStyle.YesNo)
            If answer1 = MsgBoxResult.Yes Then
                CustEdit.Show()
            Else
                CusID = 1
                HMSMain.CusID = CusID
                HMSMain.Show()
            End If

        Else
            HMSMain.CusID = CusID
            HMSMain.Show()
        End If
    End Sub

    Private Sub StallA7_Click(sender As Object, e As EventArgs) Handles StallA7.Click
        Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
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

        If CusID = "" Then

            Dim answer1 As MsgBoxResult
            answer1 = MsgBox("Do you wish to add new customer?", MsgBoxStyle.YesNo)
            If answer1 = MsgBoxResult.Yes Then
                CustEdit.Show()
            Else
                CusID = 1
                HMSMain.CusID = CusID
                HMSMain.Show()
            End If

        Else
            HMSMain.CusID = CusID
            HMSMain.Show()
        End If
    End Sub

    Private Sub StallA8_Click(sender As Object, e As EventArgs) Handles StallA8.Click
        Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
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

        If CusID = "" Then

            Dim answer1 As MsgBoxResult
            answer1 = MsgBox("Do you wish to add new customer?", MsgBoxStyle.YesNo)
            If answer1 = MsgBoxResult.Yes Then
                CustEdit.Show()
            Else
                CusID = 1
                HMSMain.CusID = CusID
                HMSMain.Show()
            End If

        Else
            HMSMain.CusID = CusID
            HMSMain.Show()
        End If
    End Sub

    Private Sub StallA9_Click(sender As Object, e As EventArgs) Handles StallA9.Click
        Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
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

        If CusID = "" Then

            Dim answer1 As MsgBoxResult
            answer1 = MsgBox("Do you wish to add new customer?", MsgBoxStyle.YesNo)
            If answer1 = MsgBoxResult.Yes Then
                CustEdit.Show()
            Else
                CusID = 1
                HMSMain.CusID = CusID
                HMSMain.Show()
            End If

        Else
            HMSMain.CusID = CusID
            HMSMain.Show()
        End If
    End Sub

    Private Sub StallA10_Click(sender As Object, e As EventArgs) Handles StallA10.Click
        Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
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

        If CusID = "" Then

            Dim answer1 As MsgBoxResult
            answer1 = MsgBox("Do you wish to add new customer?", MsgBoxStyle.YesNo)
            If answer1 = MsgBoxResult.Yes Then
                CustEdit.Show()
            Else
                CusID = 1
                HMSMain.CusID = CusID
                HMSMain.Show()
            End If

        Else
            HMSMain.CusID = CusID
            HMSMain.Show()
        End If
    End Sub

    Private Sub StallA11_Click(sender As Object, e As EventArgs) Handles StallA11.Click
        Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim ID1 As String
        Dim Stallnum1 As String
        Dim Rent1 As String
        Dim Duedate1 As String
        Dim DateRented1 As String
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

        If CusID = "" Then

            Dim answer1 As MsgBoxResult
            answer1 = MsgBox("Do you wish to add new customer?", MsgBoxStyle.YesNo)
            If answer1 = MsgBoxResult.Yes Then
                CustEdit.Show()
            Else
                CusID = 1
                HMSMain.CusID = CusID
                HMSMain.Show()
            End If

        Else
            HMSMain.CusID = CusID
            HMSMain.Show()
        End If
    End Sub
End Class