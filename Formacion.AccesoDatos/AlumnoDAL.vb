
Imports Formacion.Entidades
Imports System.Data.SqlClient
Imports System.Configuration


Public NotInheritable Class AlumnoDAL

    Public Shared Function CargarDNI(ByVal dni As String) As EntidadPersona
        Dim customer As EntidadPersona = Nothing

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim sql As String = "SELECT DNI,Nombre,Apellidos,Provincia" & _
                                "FROM Alumnos " & _
                                "WHERE DNI = @dni"

            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("dni", dni)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                ' customer = CargarAlumno(reader)
            End If
        End Using

        Return customer

    End Function
End Class
