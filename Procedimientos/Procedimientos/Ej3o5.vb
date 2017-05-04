Module Ej3o5
    Function Comprobacion(dato As Single) As Boolean
        Return dato > 0
    End Function

    Function Calculo(rad As Single, alt As Single) As Single
        Return Math.PI * rad ^ 2 * alt
    End Function

    Sub main()
        Dim radio, altura, resultado As Single

        Do
            Console.WriteLine("Ingrese el Radio:")
            radio = Console.ReadLine()
        Loop While Comprobacion(radio) = 0

        Do
            Console.WriteLine("Ingrese la Altura:")
            altura = Console.ReadLine()
        Loop While Comprobacion(altura) = 0

        resultado = Calculo(radio, altura)

        Console.WriteLine("El Volumen del Cilindro es: " & resultado)
        Console.ReadKey()
    End Sub
End Module