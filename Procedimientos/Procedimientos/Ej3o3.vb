Module Ej3o3
    Function Calculo(dato As Short, potencia As Byte) As Short
        Return dato ^ potencia
    End Function

    Sub main()
        Console.WriteLine("Ingrese un Número")
        Dim numero As Short = Console.ReadLine()

        For potencia = 2 To 6
            Console.WriteLine("{0}^{1}= " & Calculo(numero, potencia), numero, potencia)
        Next
        Console.ReadKey()
    End Sub
End Module