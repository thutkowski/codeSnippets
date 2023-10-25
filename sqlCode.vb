Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data.SQLite

Public Class sqlCode
    'Sql stuff
    Private Sub SQLite()
        Private dbCommand As String = ""
        Private bindingSrc As BindingSource

        Private dbName As String = "DND.db"
        Private dbPath As String = Application.StartupPath & "\" & dbName
        Private consString As String = "Data Source=" & dbPath & ";Version=3"

        Private connection As New SQLiteConnection(consString)
        Private command As New SQLiteCommand("", connection)

        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.Open()

        command.Connection = connection
        command.CommandText = "Select * from tbl1"

        Dim rdr As SQLiteDataReader = command.ExecuteReader
        Using rdr
            While (rdr.Read())
                MsgBox((rdr.GetInt32(0) & rdr.GetString(1) & rdr.GetInt32(2)))
            End While

        End Using

        connection.Close()
        If connection.State = ConnectionState.Open Then
            MsgBox("The connection is: " & connection.State.ToString)
        End If
    End Sub

    Private Sub SqlServer()
        'Stuff I globally decalred
        Public myConn As SqlConnection
        Public myCmd As SqlCommand
        Public myReader As SqlDataReader
        Public results As String


        'Form load event
        'Create a Connection object.
        myConn = New SqlConnection("Initial Catalog=tim;" &
        "server=DESKTOP-QBAILSD\SQLEXPRESS;Integrated Security=SSPI;")

        'Create a Command object.
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT * FROM characters WHERE characterName=" & characterUser

        'Open the connection.
        myConn.Open()
    End Sub

End Class
