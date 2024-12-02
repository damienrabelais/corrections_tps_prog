Module exercice1314_DevisesEuro
    Sub Main()
        Dim devises() As String = {"ATS", "BEF", "DEM", "ESP", "FRF", "IEP", "ITL", "FIM",
                       "LUF", "NLG", "GRD", "SIT", "PTE", "CYP", "MTL", "SKK"}
        Dim taux() As Double = {13.76, 40.33, 1.95, 166.38, 6.55, 0.78, 1936.27, 5.94,
                    40.33, 2.2, 340.75, 239.64, 200.48, 0.58, 0.42, 30.12}

        Const MAXDEVISES As Integer = 16 ' monnaies

        Dim montantEnEuros As Double
        Dim codeDevise As String
        Dim i As Integer

        Do
            Do
                Console.WriteLine("Montant en euros ou 0 ?")
                montantEnEuros = Console.ReadLine()
                If montantEnEuros < 0 Then
                    Console.WriteLine("Montant >= 0")
                End If
            Loop Until montantEnEuros >= 0

            If montantEnEuros <> 0 Then ' Sinon on sort
                Console.WriteLine("Code devise ?")
                codeDevise = Console.ReadLine()

                ' Recherche du code devise dans le premier tableau
                i = 0 ' sinon problème lors d'un deuxième calcul... 
                While devises(i) <> codeDevise And i < MAXDEVISES - 1
                    i = i + 1
                End While
                If devises(i) = codeDevise Then
                    ' i = n° de la case correspondant à la devise entrée
                    Console.WriteLine("Montant dans l'ancienne monnaie nationale : " +
                              (montantEnEuros * taux(i)).ToString)
                Else
                    Console.WriteLine("Devise non trouvée")
                End If
            End If
            Console.WriteLine(vbNewLine + "//////////////////////" + vbNewLine)
        Loop Until montantEnEuros = 0
        Console.WriteLine("Au revoir.")
        Console.ReadLine()
    End Sub

End Module
