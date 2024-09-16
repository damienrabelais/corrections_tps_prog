Module exercice72G1
    Sub main()

        Dim jours, distance As Integer
        Dim coutTotalEssence, coutTotalDiesel As Double

        Console.WriteLine("Nombre de jours de location ?")
        jours = Console.ReadLine()
        Console.WriteLine("Distance à parcourir (en kms) ?")
        distance = Console.ReadLine()

        coutTotalEssence = jours * 30 + 0.85 * distance
        coutTotalDiesel = jours * 35 + 0.65 * distance

        If coutTotalEssence > coutTotalDiesel Then
            Console.WriteLine("Meilleur choix : Diesel")
        ElseIf coutTotalEssence = coutTotalDiesel Then
            Console.WriteLine("Egalité")
        Else
            Console.WriteLine("Meilleur choix : Essence")
        End If

        Console.ReadLine()
    End Sub

End Module
