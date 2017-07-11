Module Funciones
    Public Sub EstiloDataGrid(ByVal dgv As DataGridView)

        With dgv

            .EnableHeadersVisualStyles = False

            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightGreen

            .RowsDefaultCellStyle.Font = New Font("MS Reference Sans Serif", 8.25F)
            .RowsDefaultCellStyle.ForeColor = Color.Black
            .RowsDefaultCellStyle.SelectionBackColor = Color.Yellow
            .RowsDefaultCellStyle.SelectionForeColor = Color.Black

            .ColumnHeadersDefaultCellStyle.Font = New Font("Verdana", 9.0F, FontStyle.Bold)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.Gold
            .ColumnHeadersDefaultCellStyle.BackColor = Color.DarkOliveGreen
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToOrderColumns = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
            .MultiSelect = False

            .RowHeadersVisible = False
            .BackgroundColor = System.Drawing.ColorTranslator.FromWin32(RGB(64, 64, 64))

            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect

            .ColumnHeadersHeight = 23

            .ReadOnly = True


        End With

    End Sub
    
End Module
'' Change ForeColor of each Cell
'                  Me.dgv.DefaultCellStyle.ForeColor = Color.Coral
'' Change back color of each row
'                  Me.dgv.RowsDefaultCellStyle.BackColor = Color.AliceBlue
'' Change GridLine Color
'                  Me.dgv.GridColor = Color.Blue
'' Change Grid Border Style
'                  Me.dgv.BorderStyle = BorderStyle.Fixed3Dç

'Private Sub btnAlternate_Click(ByVal sender As Object, ByVal e As EventArgs)
'    Me.dgv.RowsDefaultCellStyle.BackColor = Color.White
'    Me.dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.Aquamarine

'    RowsDefaultCellStyle()