
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub ftmBank_Load(sender As Object, e As EventArgs) Handles ftmBank.Load

        Dim todaysDate As Date = FormatDateTime(Now.Date, DateFormat.LongDate)
        Dim lastDate As Date = FormatDateTime("12/30/2016", DateFormat.GeneralDate)
        Dim days As Long = DateDiff(DateInterval.Day, todaysDate, lastDate)

        For x = days To 0 Step -1
            Dim lst As New ListItem
            Dim dateToAdd As Date = DateAdd(DateInterval.Day, x, todaysDate)
            lst.Value = dateToAdd.ToString
            lst.Text = FormatDateTime(dateToAdd.Date, DateFormat.LongDate)
            ddlDate.Items.Insert(0, lst)
        Next


        'repSlot.DataSource= 
        'For x = 0 To 4
        '    repSlot.DataBind()
        'Next

    End Sub

    

    Protected Sub slot1_Click(sender As Object, e As EventArgs) Handles slot1.Click

    End Sub
End Class
