Module exercice71G2

    Sub main()
        Dim montant, remise, montantNet As Double

        Console.WriteLine("Veuillez taper votre montant")
        montant = Console.ReadLine()
        If montant > 5000 Then
            remise = 2
        ElseIf montant >= 2000 Then ' 2000 <= montant <= 5000
            remise = 1
        Else
            remise = 0
        End If
        If remise = 0 Then
            Console.WriteLine("Pas de remise")
        Else
            Console.WriteLine("Remise de " + remise.ToString() + "%")
        End If
        montantNet = montant - (montant * remise / 100)
        Console.WriteLine("Le montant net est : " + montantNet.ToString())

        Console.ReadLine()


    End Sub

End Module
