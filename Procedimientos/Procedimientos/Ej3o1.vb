Module Ej3o1
    Sub Impresion(fecha, hora)
        Console.WriteLine("La fecha es: " & fecha & " la hora es: " & hora)
    End Sub
    Function Hora(x As Date) As Integer
        Return x.Hour
    End Function

    Sub Main()
        Dim fecha_actual As Date = Date.Now

        Impresion(fecha_actual.Date, Hora(fecha_actual))
        Console.ReadKey()
    End Sub

End Module
