Public Class ClsCtlMenu
    Function CekMenuDireferensi(kunci As String) As Boolean
        Dim cek As Boolean
        cek = False
        Try
            DTA = New Odbc.OdbcDataAdapter("Select count(id_Menu) from Detail_Jual " & " where id_menu = '" & kunci & "'", BUKAKONEKSI)
            DTS = New Data.DataSet
            DTA.Fill(DTS, "cek")
            If DTS.Tables("cek").Rows(0)(0).ToString > 0 Then
                cek = True
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return cek
    End Function
End Class
