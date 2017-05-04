Module Ej3o2
    Function Calculo(fecha As Date, dato As Integer) As Date
        Return fecha.AddDays(dato)
    End Function

    Sub main()
        Console.WriteLine("Ingrese una Fecha:")
        Dim fecha_actual As Date = Console.ReadLine()
        Dim dias As UShort

        Console.WriteLine("La fecha actual es: " & fecha_actual)
        Console.WriteLine("Ingrese cantidad de Dias a sumar a la fecha actual")
        dias = Console.ReadLine()
        fecha_actual = Calculo(fecha_actual, dias)
        Console.WriteLine("La Nueva Fecha es: " & fecha_actual)
        Console.ReadKey()
    End Sub
End Module
