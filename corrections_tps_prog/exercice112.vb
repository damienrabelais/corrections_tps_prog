Module exercice112
    Function Factorielle(ByVal pN As Integer) As Long
        Dim cumul As Long
        Dim i As Integer
        cumul = 1
        For i = 1 To pN
            cumul = cumul * i
        Next
        Return cumul
    End Function

    Sub Main()
        Dim n As Integer
        Do
            Do
                Console.WriteLine("Saisir un nombre >= 0")
                n = Console.ReadLine()
                If n < 0 And n <> -1 Then
                    Console.WriteLine("n > 0")
                End If
            Loop Until n >= 0 Or n = -1
            If n >= 0 Then
                Console.WriteLine("La factorielle de ce nombre est " + Factorielle(n).ToString())
            End If
        Loop Until n = -1
        Console.WriteLine("Au revoir.")
        Console.ReadLine()
    End Sub ' Fin du main

End Module
