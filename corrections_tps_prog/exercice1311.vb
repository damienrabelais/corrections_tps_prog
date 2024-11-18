Imports System.Net.Mail

Module exercice1311


    Sub main()
        Dim noMois As Integer

        Dim mois() As String = {"Janvier", "Février", "Mars", "Avril", "Mai", "Juin",
            "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre"}

        Do
            Console.WriteLine("Numéro mois ? (1-12)")
            noMois = Console.ReadLine()
            If noMois > 12 Or noMois < 1 Then
                Console.WriteLine("Le numéro du mois doit être compris entre 1 et 12)")
            End If
        Loop Until noMois <= 12 And noMois >= 1


        Console.WriteLine("Libellé du mois :" + mois(noMois - 1))

        Console.ReadLine()
    End Sub

End Module
