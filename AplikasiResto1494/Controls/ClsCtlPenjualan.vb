Imports System.Data.Odbc

Public Class ClsCtlPenjualan
    Dim SQL As String
    Function kodebaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OdbcDataAdapter("select max(right(id_jual,3)) from penjualan", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "PJ" & Strings.Right("00" & kodeakhir + 1, 3)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function SIMPAN_DATA(ByVal _pbl As ClsEntPenjualan, ByVal _item As List(Of ClsEntDetailJual)) As String
        Dim IDJ As String
        Dim data As New ClsEntPenjualan
        IDJ = ""
        TUTUPKONEKSI()
        With _pbl
            SQL = "SP_INSERTPENJUALAN " & .Total & ",'" & Format(.TglJual, "yyyy/MM/dd") & "','" & .IdKasir & "'"
            MsgBox(SQL)
            Try
                DTA = New OdbcDataAdapter("insert into penjualan values('" & data.IdJual & "','" & data.Total & "','" & Format(data.TglJual, "yyyy/MM/dd") & "','" & data.IdKasir & "')", BUKAKONEKSI)
                DTS = New DataSet
                DTA.Fill(DTS, "TABEL_ID_JUAL")
                IDJ = DTS.Tables("TABEL_ID_JUAL").Rows(0)(0).ToString
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End With
        TUTUPKONEKSI()
        Dim data2 As New ClsEntDetailJual
        For i = 0 To _item.Count - 1
            With _item(i)
                SQL = "insert into Detail_Jual values ('" & data2.IdJual & "','" & data2.IdMenu & "'," & data2.HargaJual & "," & data2.Qty & ")"
                MsgBox(SQL)
                CMD = New OdbcCommand("insert into Detail_Jual values ('" & data2.IdJual & "','" & data2.IdMenu & "'," & data2.HargaJual & "," & data2.Qty & ")", BUKAKONEKSI)
                CMD.CommandType = CommandType.Text
                CMD.ExecuteNonQuery()
                CMD = New OdbcCommand("", TUTUPKONEKSI)
            End With
        Next
        Return IDJ
    End Function
End Class
