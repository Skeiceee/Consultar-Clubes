Public Class BsnNegocio
    Dim DaoDatos As New DaoDatos()

    Function Login(user As Usuario)
        Return DaoDatos.Login(user)
    End Function

    Function GetClubes()
        Return DaoDatos.GetClubes()
    End Function

    Function GetIngresosEgresos()
        Return DaoDatos.GetIngresosEgresos()
    End Function

    Function InsertarIngresosEgresos(IngresoEgreso As IngresoEgreso)
        Return DaoDatos.InsertarIngresosEgresos(IngresoEgreso)
    End Function

    Function GetTipoMovimiento()
        Return DaoDatos.GetTipoMovimiento()
    End Function

    Function ModificarIngresoEgreso(IngresoEgreso As IngresoEgreso)
        Return DaoDatos.ModificarIngresoEgreso(IngresoEgreso)
    End Function

    Function EliminarIngresoEgreso(IngresoEgreso As IngresoEgreso)
        Return DaoDatos.EliminarIngresoEgreso(IngresoEgreso)
    End Function

    Function GetTipoIngresoEgresos()
        Return DaoDatos.GetTipoIngresoEgresos()
    End Function

    Function GetIngresosEgresosClub(Club As Clubes)
        Return DaoDatos.GetIngresosEgresosClub(Club)
    End Function

End Class
