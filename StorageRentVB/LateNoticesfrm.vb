﻿Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Net.Mail

Public Class LateNoticesfrm

    Public Property CusID As String
    Public DueDateL As Date
    Public RentAmount As String
    'Public UnitNum As String
    Public RentDate As String
    Private Sub LateNoticesfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowUserData()

    End Sub
    Private Sub ShowUserData()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = StringConnection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select ID,Fname, Lname, Address, City, State, Zip, Email FROM StorageDB WHERE ID = '" & CusID & "'"
        Dim Data2 As SqlDataReader = cmd.ExecuteReader()

        While Data2.Read()
            Me.id_lbl.Text = Convert.ToString(Data2("ID"))
            Me.cusFname_txt.Text = Convert.ToString(Data2("Fname"))
            Me.cusLname_txt.Text = Convert.ToString(Data2("Lname"))
            Me.address_txt.Text = Convert.ToString(Data2("Address"))
            Me.city_txt.Text = Convert.ToString(Data2("City"))
            Me.state_txt.Text = Convert.ToString(Data2("State"))
            Me.zip_txt.Text = Convert.ToString(Data2("Zip"))
            Me.email_txt.Text = Convert.ToString(Data2("Email"))
        End While

        Dim UserData1 As DataTable = ExecuteSQL("Select ID, StallNum, Rent, DateRented, DueDate FROM StallNum WHERE ID = '" & id_lbl.Text & "'")

        With dgLate
            .DataSource = UserData1
            .Columns(0).HeaderText = "ID"
            .Columns(1).HeaderText = "StallNum"
            .Columns(2).HeaderText = "Rent"
            .Columns(3).HeaderText = "Due Date"
            .Columns(4).HeaderText = "Date Rented"
            .Columns(0).Width = 75
            .Columns(1).Width = 67
            .Columns(2).Width = 75
            .Columns(3).Width = 75
            dgLate.ColumnHeadersVisible = False
            dgLate.RowHeadersVisible = False
            dgLate.Columns("ID").Visible = False

        End With

    End Sub
    Private Sub Printrtb_btn_Click(sender As Object, e As EventArgs) Handles Printrtb_btn.Click
        'Dim Printtext As String
        'PrintPreviewDialog1.ShowDialog()
        'Printtext = rtbLateNotice.Text
        'PrintDocument1.Print()
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font1 As New Font("arial", 10, FontStyle.Regular)
        e.Graphics.DrawString(rtbLateNotice.Text, font1, Brushes.Black, 100, 100)
    End Sub

    Private Sub dgLate_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgLate.CellContentClick
        Dim index As Integer
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim UserData As DataTable = ExecuteSQL("Select ID, StallNum, Rent, DueDate, DateRented FROM StallNum WHERE ID = '" & id_lbl.Text & "'")

        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = dgLate.Rows(index)
        id_lbl.Text = selectedRow.Cells(0).Value.ToString()
        unitNumL_txt.Text = selectedRow.Cells(1).Value.ToString()
        rentamountL_txt.Text = selectedRow.Cells(2).Value.ToString()
        'rentdate_txt.Text = selectedRow.Cells(3).Value.ToString()
        duedateL_txt.Text = selectedRow.Cells(4).Value.ToString()
        DueDateL = duedateL_txt.Text

        Dim CurrentDate As Date = Date.Now
        Dim MonthsDue As Integer
        Dim AmountDue As Integer
        Dim DaysOver As Integer
        Dim DaysPast As Integer
        Dim DaysTemp As Integer
        Dim DaysTemp2 As Integer
        Dim DueDate1 As Date
        Dim Intervaltype As String
        Dim UnitNum As String = unitNumL_txt.Text
        Dim UnitNum1 As String = unitNumL_txt.Text.Trim
        currentdate_txt.Text = CurrentDate
        rtbLateNotice.Clear()
        rtbLateNotice.Update()
        ' DueDate = DueDateL
        unitNumL_txt.Text = UnitNum
        duedateL_txt.Text = DueDateL

        MonthsDue = DateDiff("m", DueDateL, CurrentDate)
        DaysOver = DateDiff("d", DueDateL, CurrentDate)
        DaysTemp = MonthsDue * 30
        DaysTemp2 = DaysOver - DaysTemp
        Test_lbl.Text = DaysOver

        If DaysTemp2 > 0 Then
            MonthsDue = MonthsDue + 1
        Else
        End If

        If DaysOver < 0 Then
            MsgBox("This Unit does not require a Late Notice", MsgBoxStyle.OkOnly)

        End If
        Intervaltype = "m"
        Dim NewDueDate As Date = DateAdd(Intervaltype, MonthsDue, DueDateL)
        AmountDue = MonthsDue * 50
        newrentdate_txt.Text = NewDueDate
        'NewDueDate = DateAdd("m", MonthsDue, )

        AmtDue_txt.Text = AmountDue
        rtbLateNotice.SelectionAlignment = HorizontalAlignment.Center
        rtbLateNotice.AppendText("                                    Huff Mini Storage" + vbNewLine)
        rtbLateNotice.AppendText("                                    3360 U.S. Hwy 60 N" + vbNewLine)
        rtbLateNotice.AppendText("                                    Billings, MO 65610" + vbNewLine)
        rtbLateNotice.AppendText("___________________________________________________________________________" + vbNewLine)
        rtbLateNotice.AppendText("" + vbNewLine)
        rtbLateNotice.AppendText("Thank you for choosing Huff Storage." + "We appreciate your business. " + vbNewLine)
        rtbLateNotice.AppendText("" + vbNewLine)
        rtbLateNotice.AppendText("Our records show that you are behind on your rent for unit " + UnitNum1 + ".  " + vbNewLine)
        rtbLateNotice.AppendText("Your due date that we have for this unit is on " + DueDateL + "." + vbNewLine)
        rtbLateNotice.AppendText("The total due to catch up this unit is $" + AmtDue_txt.Text + ".")
        rtbLateNotice.AppendText("This amount will pay all rent for this unit up to " + newrentdate_txt.Text + vbNewLine)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim SmtpServer As New SmtpClient()
            Dim mail As New MailMessage()
            SmtpServer.EnableSsl = True
            SmtpServer.Credentials = New _
        Net.NetworkCredential("seangtrf@gmail.com", "Jess05Green31")
            SmtpServer.Port = 587
            SmtpServer.Host = "smtp.gmail.com"
            mail = New MailMessage()
            mail.From = New MailAddress("seangtrf@gmail.com")
            mail.To.Add("advancedprintingllc@gmail.com")
            mail.Subject = "Test Mail"
            mail.Body = rtbLateNotice.Text
            SmtpServer.Send(mail)
            MsgBox("mail send")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class