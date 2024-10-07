Module exercice94
    Sub Main()
        Const TAUXCOMMISSION As Double = 0.1
        Dim cARepresentant, ventesHTHebdo As Double
        Dim i As Integer
        Dim choix, nomRepresentant As String
        Do
            Console.WriteLine("Nom du représentant ?")
            nomRepresentant = Console.ReadLine
            cARepresentant = 0
            For i = 1 To 4
                Console.WriteLine("Semaine " + i.ToString() +
                ": Ventes H.T hebdomadaires (0 pour stopper la saisie) ?")
                Do
                    ventesHTHebdo = Console.ReadLine
                    If ventesHTHebdo < 0 Then
                        Console.WriteLine("Ventes ne peuvent être < 0")
                    End If
                Loop Until ventesHTHebdo >= 0
                If ventesHTHebdo = 0 Then
                    Exit For
                End If
                cARepresentant = cARepresentant + ventesHTHebdo ' Cumul des ventes
            Next
            Console.WriteLine("Bilan pour " + nomRepresentant)
            Console.WriteLine("Total des ventes H.T. = " +
                      cARepresentant.ToString())
            Console.WriteLine("Commission = " +
                      (TAUXCOMMISSION * cARepresentant).ToString())
            Do ' Saisie avec vérification
                Console.WriteLine("Autre représentant(O/N)")
                choix = Console.ReadLine
            Loop Until choix = "o" Or choix = "O" Or choix = "n" Or choix = "N"
        Loop Until choix = "N" Or choix = "n"
        Console.WriteLine("Au revoir.")
        Console.ReadLine()
    End Sub

End Module
