Module exercice1312_MinMax
    Sub MinMax(ByVal pTab() As Double)
        Dim leMax, leMin As Double
        Dim i As Integer
        leMax = pTab(0)
        leMin = pTab(0)

        For i = 1 To 9
            If pTab(i) > leMax Then
                leMax = pTab(i)
            End If
            If pTab(i) < leMin Then
                leMin = pTab(i)
            End If
        Next
        Console.WriteLine("Min : " + leMin.ToString())
        Console.WriteLine("Max : " + leMax.ToString())
    End Sub

    Sub Main()
        Dim lesNombres(9) As Double
        Dim i As Integer
        For i = 0 To 9
            Console.WriteLine("Nombre n°" + i.ToString() + " ?")
            lesNombres(i) = Console.ReadLine()
        Next
        MinMax(lesNombres)

        Console.ReadLine()
    End Sub

End Module
