Imports Formacion.Entidades
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Security.Cryptography
Imports MD5Managed
Imports MD5Core

Public Class LoginDAL

    Public Shared Function CargarDatosLogin(ByVal usuario As String) As EntidadLogin
        Dim login As EntidadLogin = Nothing

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_LOGIN_CargarDatosUsuario", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@usuario", usuario)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                login = New EntidadLogin
                login.Nif = CStr(reader("Nif"))
                login.NombreCompleto = CStr(reader("Info"))

                If reader("Usuario") Is DBNull.Value Then
                    login.Usuario = Nothing
                Else
                    login.Usuario = CStr(reader("Usuario"))
                End If

                If reader("Contraseña") Is DBNull.Value Then
                    login.Contraseña = Nothing
                Else
                    login.Contraseña = CStr(reader("Contraseña"))
                End If

                If reader("TipoUsuario") Is DBNull.Value Then
                    login.TipoUsuario = Nothing
                Else
                    login.TipoUsuario = CStr(reader("TipoUsuario"))
                End If

            End If

        End Using

        Return login

    End Function
    Public Shared Function CargarDatosLoginNif(ByRef NIF As String) As EntidadLogin
        Dim login As EntidadLogin = Nothing

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_LOGIN_CargarDatosLoginNIF", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@nif", NIF)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                login = New EntidadLogin
                login.Nif = CStr(reader("Nif"))
                login.NombreCompleto = CStr(reader("Info"))

                If reader("Usuario") Is DBNull.Value Then
                    login.Usuario = Nothing
                Else
                    login.Usuario = CStr(reader("Usuario"))
                End If

                If reader("Contraseña") Is DBNull.Value Then
                    login.Contraseña = Nothing
                Else
                    login.Contraseña = CStr(reader("Contraseña"))
                End If

                If reader("TipoUsuario") Is DBNull.Value Then
                    login.TipoUsuario = Nothing
                Else
                    login.TipoUsuario = CStr(reader("TipoUsuario"))
                End If

            End If

        End Using

        Return login

    End Function

    Public Shared Function EncodePassword(ByVal originalPassword As String) As String

        Return GetHashString(originalPassword)

    End Function
    Public Shared Function ComprobarLogin(ByRef user As EntidadLogin) As Boolean
        Dim numeroderegistros As Integer = 0


        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_LOGIN_ComprobarUsuarioContraseña", conn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim hash As String = EncodePassword(String.Concat(user.Usuario, user.Contraseña))
            cmd.Parameters.AddWithValue("@usuario", user.Usuario)
            cmd.Parameters.AddWithValue("@pass", hash)

            numeroderegistros = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        Return numeroderegistros > 0

    End Function
    Public Shared Function Crear(ByRef user As EntidadLogin) As EntidadLogin

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_LOGIN_CrearLogin", conn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim hash As String = EncodePassword(String.Concat(user.Usuario, user.Contraseña))

            cmd.Parameters.AddWithValue("@Nif", user.Nif)
            cmd.Parameters.AddWithValue("@usuario", user.Usuario)
            cmd.Parameters.AddWithValue("@pass", hash)
            If user.TipoUsuario = Nothing Then
                cmd.Parameters.AddWithValue("@TipoUsuario", DBNull.Value)
            Else
                cmd.Parameters.AddWithValue("@TipoUsuario", user.TipoUsuario)
            End If


            cmd.ExecuteNonQuery()
        End Using

        Return user

    End Function
    Public Shared Function Actualizar(ByRef user As EntidadLogin) As EntidadLogin

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()

            Dim cmd As New SqlCommand("PROC_LOGIN_ActualizarLogin", conn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim hash As String = EncodePassword(String.Concat(user.Usuario, user.Contraseña))

            cmd.Parameters.AddWithValue("@Nif", user.Nif)
            cmd.Parameters.AddWithValue("@usuario", user.Usuario)
            cmd.Parameters.AddWithValue("@pass", hash)
            cmd.Parameters.AddWithValue("@TipoUsuario", user.TipoUsuario)

            cmd.ExecuteNonQuery()
        End Using

        Return user

    End Function

    Public Shared Function ExisteUser(ByRef user As String) As Boolean

        Dim numeroderegistros As Integer = 0

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()


            Dim cmd As New SqlCommand("PROC_LOGIN_ExisteUser", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@usuario", user)

            numeroderegistros = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        Return numeroderegistros > 0
    End Function
    Public Shared Function ExisteNif(ByRef NIF As String) As Boolean

        Dim numeroderegistros As Integer = 0

        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("default").ToString())
            conn.Open()


            Dim cmd As New SqlCommand("PROC_LOGIN_ExisteNIF", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@nif", NIF)

            numeroderegistros = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        Return numeroderegistros > 0
    End Function

End Class
