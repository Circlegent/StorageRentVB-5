Imports System.Data.SqlClient


Public Class HMSStart
    Public Property CusID As String

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

        Dim obj5 As New HMSMain

        ' obj5.RBCheck_rbtn.Visible = False
        ' obj5.RBCash_rbtn.Visible = False
        ' obj5.RBCard_rbtn.Visible = False
        ' obj5.Payment_btn.Visible = False
        ' obj5.unitNum_txt.Select()
        obj5.CusID = CusID
        obj5.Show()
    End Sub

    Private Sub StallA2_Click(sender As Object, e As EventArgs) Handles StallA2.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
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
        cmd.CommandText = "Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE StallNum = '" + StallA2.Text + "'"
        Dim Data1 As SqlDataReader = cmd.ExecuteReader()

        While Data1.Read()
            CusID = Convert.ToString(Data1("ID"))
            Stallnum1 = Convert.ToString(Data1("StallNum"))
            Rent1 = Convert.ToString(Data1("Rent"))
            Duedate1 = Convert.ToString(Data1("DueDate"))
            DateRented1 = Convert.ToString(Data1("DateRented"))
        End While

        'Dim obj5 As New HMSMain

        ' obj5.RBCheck_rbtn.Visible = False
        ' obj5.RBCash_rbtn.Visible = False
        ' obj5.RBCard_rbtn.Visible = False
        ' obj5.Payment_btn.Visible = False
        ' obj5.unitNum_txt.Select()
        HMSMain.CusID = CusID
        HMSMain.Show()
    End Sub

    Private Sub StallA3_Click(sender As Object, e As EventArgs) Handles StallA3.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
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
            answer1 = MsgBox("Do you wish to add unit to a customer?", MsgBoxStyle.YesNo)
            If answer1 = MsgBoxResult.Yes Then
                UnitInfo.Show()
            End If
        End If
        'Dim obj5 As New HMSMain

        ' obj5.RBCheck_rbtn.Visible = False
        ' obj5.RBCash_rbtn.Visible = False
        ' obj5.RBCard_rbtn.Visible = False
        ' obj5.Payment_btn.Visible = False
        ' obj5.unitNum_txt.Select()
        HMSMain.CusID = CusID
        HMSMain.Show()
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
End Class