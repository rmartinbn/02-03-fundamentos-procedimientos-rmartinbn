Module Ej3o4

    Function Comprobacion(dato1 As Single) As Boolean
        Return dato1 = Int(dato1) And dato1 > 0
    End Function

    Function Calculo(lado1 As UShort, lado2 As UShort) As Single
        Return Math.Sqrt(lado1 ^ 2 + lado2 ^ 2)
    End Function


    Sub main()
        Dim hipotenusa, ladoA, ladoB As Single

        Do
            Console.WriteLine("Ingrese el Lado A:")
            ladoA = Console.ReadLine()
        Loop While Comprobacion(ladoA) = 0

        Do
            Console.WriteLine("Ingrese el Lado B:")
            ladoB = Console.ReadLine()
        Loop While Comprobacion(ladoB) = 0

        hipotenusa = Calculo(ladoA, ladoB)
        Console.WriteLine("La Hipotenusa es: " & hipotenusa)
        Console.ReadKey()
    End Sub
End Module