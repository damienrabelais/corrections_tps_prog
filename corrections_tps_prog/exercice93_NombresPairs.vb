Module exercice93_NombresPairs
    Sub Main()
        Dim n, i, nombre As Integer

        Do
            Console.WriteLine("n ? (n > 0)")
            n = Console.ReadLine()
            If n <= 0 Then
                Console.WriteLine("n > 0")
            End If
        Loop Until n > 0

        ' SOLUTION 1
        'nombre = 0
        'For i = 1 To n
        '    nombre = nombre + 2
        '    Console.WriteLine("nombre : " + nombre.ToString())
        'Next

        ' SOLUTION 2
        For nombre = 2 To n * 2 Step 2
            Console.WriteLine("nombre : " + nombre.ToString())
        Next

        Console.ReadLine()

    End Sub

End Module
