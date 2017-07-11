Public Module Module1
    Public Function BuscarEnDataGrid(ByVal TextoABuscar As String, ByVal Columna As String, ByRef datagrid As DataGridView) As Boolean
        Try

            Dim encontrado As Boolean = False

            datagrid.ClearSelection()

            If TextoABuscar = String.Empty Then Return False

            Dim rows As List(Of DataGridViewRow) = (From item In datagrid.Rows.Cast(Of DataGridViewRow)() _
                     Let clave = Convert.ToString(If(item.Cells(Columna).Value, String.Empty)) _
                   Where UCase(clave) = UCase(TextoABuscar) _
                   Select item).ToList


            For Each row As DataGridViewRow In rows
                row.Selected = True
                datagrid.CurrentCell = row.Cells(0)
            Next

            If rows.Count > 0 Then
                encontrado = True
            End If

            Return encontrado
        Catch ex As Exception
            MsgBox("Se ha producido la siguiente excepción: " + vbCrLf + _
                    ex.Message, CType(MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, MsgBoxStyle), "Error...")
            Return False
        End Try
    End Function
End Module
