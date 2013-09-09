Imports System.Data.SqlClient

Public Class MUnits
    Public units As List(Of String) = GetAllUnits()
    Public unit_id As Integer
    Public unit_name As String
    Public unit_group As String
    Public unit_qty As Integer
    Private _unit_name As String
    Sub New()

    End Sub
    Sub New(ByVal unitname As String)

        unit_name = unitname
        unit_id = GetUnitID(unit_name)
        unit_group = GetUnitGroup(unit_id)
        unit_qty = GetGroupQuantity(unit_id)


    End Sub

    Function GetAllUnits() As List(Of String)
        Dim result As New List(Of String)
        Dim ConnString As String = CurrentConfig.ConnectionString
        Dim SqlConn As New SqlConnection(ConnString)
        Dim SqlQuery As String = "SELECT * FROM Units"
        Dim SqlCmd As New SqlCommand(SqlQuery, SqlConn)
        Dim data As SqlDataReader

        Try
            SqlConn.Open()
            data = SqlCmd.ExecuteReader()
            While data.Read
                result.Add(data("unit_of_measure"))
            End While
            SqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            SqlConn.Dispose()
        End Try

        Return result
    End Function

    Sub Save(ByVal p1 As String, ByVal p2 As String, ByVal p3 As Integer)
        Dim unitname As String = p1
        Dim unitgroup As String = p2
        Dim unitqty As Integer = p3
        Dim unitid As Integer
        Dim SqlQuery As String
        If unitgroup = "NULL" Then
        Else
            unitid = GetUnitID(unitgroup)
        End If

        Dim ConnString As String = CurrentConfig.ConnectionString
        Dim SqlConn As New SqlConnection(ConnString)
        Dim SqlCmd As SqlCommand
        If unitgroup = "NULL" Then
            SqlQuery = "INSERT INTO Units(unit_of_measure)VALUES(N'" & unitname & "')"
            SqlCmd = New SqlCommand(SqlQuery, SqlConn)

        Else
            SqlQuery = "INSERT INTO Units (unit_of_measure,unit_group,qty_per_group) VALUES(" & unitname & "," & unitid & "," & unitqty & ")"
            SqlCmd = New SqlCommand(SqlQuery, SqlConn)
        End If


        Try
            SqlConn.Open()
            SqlCmd.ExecuteNonQuery()
            SqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            SqlConn.Dispose()
        End Try

    End Sub

    Private Function GetUnitID(ByVal unitgroup As String) As Integer
        Dim result As Integer
        Dim ConnString As String = CurrentConfig.ConnectionString
        Dim SqlConn As New SqlConnection(ConnString)
        Dim SqlQuery As String = "SELECT * FROM Units WHERE unit_of_measure =" & unitgroup
        Dim SqlCmd As New SqlCommand(SqlQuery, SqlConn)
        Dim data As SqlDataReader

        Try
            SqlConn.Open()
            data = SqlCmd.ExecuteReader()
            While data.Read
                result = data("unit_id")
            End While
            SqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            SqlConn.Dispose()
        End Try

        Return result


    End Function

    Private Function GetUnitGroup(ByVal unit_id As Integer) As String
        Dim result As String
        Dim ConnString As String = CurrentConfig.ConnectionString
        Dim SqlConn As New SqlConnection(ConnString)
        Dim SqlQuery As String = "SELECT * FROM Units WHERE unit_id =" & unit_id
        Dim SqlCmd As New SqlCommand(SqlQuery, SqlConn)
        Dim data As SqlDataReader

        Try
            SqlConn.Open()
            data = SqlCmd.ExecuteReader()
            While data.Read
                result = data("unit_of_measure")
            End While
            SqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            SqlConn.Dispose()
        End Try

        Return result
    End Function

    Private Function GetGroupQuantity(ByVal unit_id As Integer) As Integer
        Dim result As Integer
        Dim ConnString As String = CurrentConfig.ConnectionString
        Dim SqlConn As New SqlConnection(ConnString)
        Dim SqlQuery As String = "SELECT * FROM Units WHERE unit_id =" & unit_id
        Dim SqlCmd As New SqlCommand(SqlQuery, SqlConn)
        Dim data As SqlDataReader

        Try
            SqlConn.Open()
            data = SqlCmd.ExecuteReader()
            While data.Read
                result = data("qty_per_group")
            End While
            SqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            SqlConn.Dispose()
        End Try

        Return result
    End Function




End Class
