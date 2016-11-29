Imports Microsoft.VisualBasic

Public Class DALCommon
    Private Const CONN_STR As String = "Server=.\SQLExpress;Database=CoBPSurvey2014;User ID=cmsuser;Password=go0gl3@123;Trusted_Connection=False;"

    Public Shared Function FormatForQuery(ByRef str As String) As String
        str = str.Replace("'", "''").Trim()
        str = str.Replace("’", "''").Trim()
        Return str
    End Function

    Public Shared Function FormatForJS(ByRef str As String) As String
        str = str.Replace("'", "/'").Trim()
        Return str
    End Function

    Public Shared Function FormatDateForQuery(ByRef str As String) As String
        Return DateTime.Parse(str).ToString("yyyy/MM/dd HH:mm:ss")
    End Function

    Public Shared ReadOnly Property ConnectionString() As String
        Get
            Return CONN_STR
        End Get
    End Property


    Public Shared Function GetNow() As String
        Return DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        'Return DateTime.Now.Format(Now, "yyyy/MM/dd HH:mm:ss")
    End Function

    Public Shared ReadOnly Property DefaultDate() As String
        Get
            Return "1900/01/01"
        End Get
    End Property
End Class
