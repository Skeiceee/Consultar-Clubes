Imports System.Data.OleDb

Public Class DaoDatos
    Dim conexion As New Conexion()

    Function Login(user As Usuario)

        Dim command As New OleDbCommand
        Dim dataset As New DataSet

        command.Connection = conexion.GetConexion()
        conexion.AbrirConexion()

        command.CommandText = "select * from Usuarios where Usuario = '" & user.User & "' and '" & user.Password & "'"

        Dim reader As New OleDbDataAdapter

        reader.SelectCommand = command
        reader.Fill(dataset)

        conexion.CerrarConexion()

        Return dataset.Tables(0)

    End Function

    Function GetClubes()

        Dim command As New OleDbCommand
        Dim dataset As New DataSet

        command.Connection = conexion.GetConexion()
        conexion.AbrirConexion()

        command.CommandText = "select * from Clubes"

        Dim reader As New OleDbDataAdapter

        reader.SelectCommand = command
        reader.Fill(dataset)

        conexion.CerrarConexion()

        Return dataset.Tables(0)

    End Function

    Function GetIngresosEgresos()

        Dim command As New OleDbCommand
        Dim dataset As New DataSet

        command.Connection = conexion.GetConexion()
        conexion.AbrirConexion()

        command.CommandText = "select * from Ingresos_Egresos"

        Dim reader As New OleDbDataAdapter

        reader.SelectCommand = command
        reader.Fill(dataset)

        conexion.CerrarConexion()

        Return dataset.Tables(0)

    End Function

    Function InsertarIngresosEgresos(IngresoEgreso As IngresoEgreso)

        Dim command As New OleDbCommand

        command.Connection = conexion.GetConexion()
        conexion.AbrirConexion()

        command.CommandText = "Insert into Ingresos_Egresos (Nombre, Detalle, Fecha, Monto, IDTipoMovimiento, IDClub) values ('" &
            IngresoEgreso.Nombre & "','" &
            IngresoEgreso.Detalle & "','" &
            IngresoEgreso.Fecha.ToString() & "', " &
            IngresoEgreso.Monto & "," &
            IngresoEgreso.IDTipoMovimiento & "," &
            IngresoEgreso.IDClub & ")"
        command.ExecuteNonQuery()

        conexion.CerrarConexion()

        Return IngresoEgreso

    End Function

    Function GetTipoMovimiento()
        Dim command As New OleDbCommand
        Dim dataset As New DataSet

        command.Connection = conexion.GetConexion()
        conexion.AbrirConexion()

        command.CommandText = "select * from Tipo_Movimiento"

        Dim reader As New OleDbDataAdapter

        reader.SelectCommand = command
        reader.Fill(dataset)

        conexion.CerrarConexion()

        Return dataset.Tables(0)
    End Function

    Function ModificarIngresoEgreso(IngresoEgreso As IngresoEgreso)

        Dim command As New OleDbCommand

        command.Connection = conexion.GetConexion()
        conexion.AbrirConexion()

        command.CommandText = "Update Ingresos_Egresos set Nombre = '" &
            IngresoEgreso.Nombre & "'," &
            " Detalle = '" & IngresoEgreso.Detalle & "'," &
            " Fecha = '" & IngresoEgreso.Fecha.ToString() & "', " &
            " Monto = '" & IngresoEgreso.Monto & "'," &
            " IDTipoMovimiento = " & IngresoEgreso.IDTipoMovimiento & "," &
            " IDClub = " & IngresoEgreso.IDClub &
            " where ID = " & IngresoEgreso.ID & ""

        command.ExecuteNonQuery()

        conexion.CerrarConexion()

        Return IngresoEgreso

    End Function

    Function EliminarIngresoEgreso(IngresoEgreso As IngresoEgreso)

        Dim command As New OleDbCommand

        command.Connection = conexion.GetConexion()
        conexion.AbrirConexion()

        command.CommandText = "Delete from Ingresos_Egresos where ID = " & IngresoEgreso.ID & ""

        command.ExecuteNonQuery()

        conexion.CerrarConexion()

        Return IngresoEgreso

    End Function

    Function GetTipoIngresoEgresos()

        Dim command As New OleDbCommand
        Dim dataset As New DataSet

        command.Connection = conexion.GetConexion()
        conexion.AbrirConexion()

        command.CommandText = "select * from Tipo_Movimiento"

        Dim reader As New OleDbDataAdapter

        reader.SelectCommand = command
        reader.Fill(dataset)

        conexion.CerrarConexion()

        Return dataset.Tables(0)

    End Function

    Function GetIngresosEgresosClub(Club As Clubes)
        Dim command As New OleDbCommand
        Dim dataset As New DataSet

        command.Connection = conexion.GetConexion()
        conexion.AbrirConexion()

        command.CommandText = "select * from Ingresos_Egresos where IDClub = " & Club.ID & ""

        Dim reader As New OleDbDataAdapter

        reader.SelectCommand = command
        reader.Fill(dataset)

        conexion.CerrarConexion()

        Return dataset.Tables(0)
    End Function
End Class
