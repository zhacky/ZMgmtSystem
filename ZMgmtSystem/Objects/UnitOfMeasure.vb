Imports System.Data.SqlClient
Imports System.ComponentModel

Public Class UnitOfMeasure
    Implements IDisposable
   
    Public unit_id As Integer
    Public unit_name As String
    Public unit_description As String
    Friend units As List(Of String)

    Sub New()
        units = GetAllUnits()
    End Sub

    Sub New(ByVal unitname As String)
        unit_name = unitname
        Dim result As SqlDataReader
        Dim conn As New SqlConnection(CurrentConfig.ConnectionString)
        Dim SqlQuery As String = "SELECT * FROM Units WHERE unit_of_measure='" & unit_name & "'"
        Dim cmd As New SqlCommand(SqlQuery, conn)
        Dim previousConnectionState As ConnectionState = conn.State
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            result = cmd.ExecuteReader()
            While result.Read

                unit_id = result("unit_id")
                If IsDBNull(result("unit_description")) Then
                    unit_description = ""
                Else
                    unit_description = result("unit_description")
                End If
            End While
        Finally
            If previousConnectionState = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try


    End Sub

    Function GetAllUnits() As List(Of String)

        Dim result As New List(Of String)
        Dim ConnString As String = CurrentConfig.ConnectionString
        Dim SqlConn As New SqlConnection(ConnString)
        Dim SqlQuery As String = "SELECT * FROM Units"
        Dim SqlCmd As New SqlCommand(SqlQuery, SqlConn)
        Dim data As SqlDataReader
        Dim previousConnectionState As ConnectionState = SqlConn.State
        Try
            If SqlConn.State = ConnectionState.Closed Then
                SqlConn.Open()
            End If
            data = SqlCmd.ExecuteReader()
            While data.Read
                result.Add(data("unit_of_measure"))
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            If previousConnectionState = ConnectionState.Closed Then
                SqlConn.Close()
            End If
            SqlConn.Dispose()
        End Try

        Return result
    End Function

    Sub Save(ByVal p1 As String, ByVal p2 As String)
        Dim unit As String = p1
        Dim desc As String = p2
        Dim rowCount As Integer
        Dim conn As New SqlConnection(CurrentConfig.ConnectionString)
        Dim SqlQuerySave As String = "INSERT INTO Units" & _
                      "(unit_of_measure, unit_description) VALUES(N'" & unit & "', N'" & desc & "')"
        Dim cmd As New SqlCommand(SqlQuerySave, conn)
        Dim previousConnectionState As ConnectionState
        previousConnectionState = conn.State

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            rowCount = cmd.ExecuteNonQuery()

        Finally
            If previousConnectionState = ConnectionState.Closed Then
                conn.Close()
                conn.Dispose()
            End If

        End Try

    End Sub





#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        Me.disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

    Sub Update(ByVal p1 As Integer, ByVal p2 As String, ByVal p3 As String)
        Dim id As Integer = p1
        Dim unit As String = p2
        Dim desc As String = p3
        Dim conn As New SqlConnection(CurrentConfig.ConnectionString)
        Dim SqlQueryUpdate As String = "UPDATE Units SET unit_of_measure = N'pounds', unit_description = N'Pounds' WHERE (unit_id = @param)"
        Dim cmd As New SqlCommand(SqlQueryUpdate, conn)
        cmd.Parameters.AddWithValue("@param", id)
        Dim rowCount As Integer
        Dim previousConnectionState As ConnectionState
        previousConnectionState = conn.State
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            rowCount = cmd.ExecuteNonQuery()

        Finally
            If previousConnectionState = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try

        

    End Sub

End Class
