Public Class AcessoPG
    Public cn As String
    Public servidor As String
    Public porta As Integer
    Public usuario As String
    Public senha As String
    Public database As String
    Public permissoes As Boolean
    Public StringConexao As String

    Public Sub New()
    End Sub

    Public Sub New(ByVal strconexao As String)
        cn = strconexao
    End Sub
    Protected Function getConexao() As Npgsql.NpgsqlConnection
        Dim retcon As Npgsql.NpgsqlConnection
        retcon = New Npgsql.NpgsqlConnection(cn)
        Try
            retcon.Open()
            getConexao = retcon
        Catch ex As Exception
            MessageBox.Show("A Conexão não pode ser completada. Verifique seu nome de usuário e senha" + ex.Message, "Erro")
        End Try
        getConexao = retcon
    End Function
    Protected Sub closeConexao(ByVal con As Npgsql.NpgsqlConnection)
        con.Close()
        con = Nothing
    End Sub
    Public Function testaconexao() As Boolean
        Dim estado As Boolean
        Dim cn As Npgsql.NpgsqlConnection = getConexao()
        If cn.State = ConnectionState.Open Then
            estado = True
            Return estado
        Else
            estado = False
            Return estado
        End If

    End Function
    Public Overloads Function returnDatareader(ByVal strSP As String, ByVal ParamArray cmdParametros() As Npgsql.NpgsqlParameter) As Npgsql.NpgsqlDataReader
        Dim cn As Npgsql.NpgsqlConnection = getConexao()
        Dim dr As Npgsql.NpgsqlDataReader

        Dim cmd As New Npgsql.NpgsqlCommand(strSP, cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim par As Npgsql.NpgsqlParameter

        For Each par In cmdParametros
            par = cmd.Parameters.Add(par)
            par.Direction = ParameterDirection.Input
        Next

        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        cmd.Dispose()

        Return dr
    End Function
    Public Overloads Function returnDatareader(ByVal strSP As String) As Npgsql.NpgsqlDataReader
        Dim cn As Npgsql.NpgsqlConnection = getConexao()
        Dim dr As Npgsql.NpgsqlDataReader

        Dim cmd As New Npgsql.NpgsqlCommand(strSP, cn)
        cmd.CommandType = CommandType.Text
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        cmd.Dispose()

        Return dr
    End Function
    Public Function checkconnection()
        Dim estado As Boolean
        If Me.getConexao.State = ConnectionState.Open Then
            estado = True
            Return estado
        Else
            estado = False
            Return estado
        End If
    End Function
    Public Function GetConnString(ByVal servidor As String, ByVal porta As Integer, ByVal usuario As String, ByVal senha As String, ByVal database As String)
        Dim strconexao As String
        Me.servidor = servidor
        Me.porta = porta
        Me.usuario = usuario
        Me.senha = senha
        Me.database = database
        strconexao = "server=" + Me.servidor + ";port=" + Me.porta + ";userid=" + Me.usuario + ";password=" + Me.senha + ";database=" + Me.database + ";"
        Me.cn = strconexao
        Return strconexao
    End Function
    Public Overloads Function returnDatascalar(ByVal strSP As String)
        Dim cn As Npgsql.NpgsqlConnection = getConexao()
        Dim dr
        Dim cmd As New Npgsql.NpgsqlCommand(strSP, cn)
        cmd.CommandType = CommandType.Text
        dr = cmd.ExecuteScalar()
        cmd.Dispose()
        Return dr
    End Function
    Public Overloads Function returnNonQuery(ByVal strSP As String)
        Dim cn As Npgsql.NpgsqlConnection = getConexao()
        Dim dr
        Dim cmd As New Npgsql.NpgsqlCommand(strSP, cn)
        cmd.CommandType = CommandType.Text
        dr = cmd.ExecuteNonQuery()
        cmd.Dispose()
        Return dr
    End Function
    Public Function returnDataset(ByVal strSP As String, ByVal dt As String) As DataSet
        Dim cn As Npgsql.NpgsqlConnection = getConexao()
        Dim ds As New DataSet

        Dim da As New Npgsql.NpgsqlDataAdapter(strSP, cn)

        da.SelectCommand.CommandType = CommandType.Text
        da.SelectCommand.CommandText = strSP

        'necessario implantar a verificacao do ds
        da.Fill(ds)

        closeConexao(cn)
        da.Dispose()

        Return ds

    End Function
End Class


