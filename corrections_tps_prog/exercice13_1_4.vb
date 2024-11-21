Module exercice13_1_4
    Sub Main()
        Dim Devises() As String = {"ATS", "BEF", "DEM", "ESP", "FRF", "IEP", "ITL", "FIM",
                       "LUF", "NLG", "GRD", "SIT", "ATS", "PTE", "CYP", "MTL", "SKK"}
        Dim Taux() As Double = {13.76, 40.33, 1.95, 166.38, 6.55, 0.78, 1936.27, 5.94,
                    40.33, 2.2, 340.75, 239.64, 13.76, 200.48, 0.58, 0.42, 30.12}

        Const MAXDEVISES As Integer = 17 ' monnaies

        Dim MontantEnEuros As Double
        Dim CodeDevise As String
        Dim i As Integer

        Do
            Do
                Console.WriteLine("Montant en euros ou 0 ?")
                MontantEnEuros = Console.ReadLine()
                If MontantEnEuros < 0 Then
                    Console.WriteLine("Montant >= 0")
                End If
            Loop Until MontantEnEuros >= 0

            If MontantEnEuros <> 0 Then ' Sinon on sort
                Console.WriteLine("Code devise ?")
                CodeDevise = Console.ReadLine()

                ' Recherche du code devise dans le premier tableau
                i = 0 ' sinon problème lors d'un deuxième calcul... 
                While Devises(i) <> CodeDevise And i <= MAXDEVISES - 2
                    i = i + 1
                End While
                If Devises(i) = CodeDevise Then
                    ' i = n° de la case correspondant à la devise entrée
                    Console.WriteLine("Montant dans l'ancienne monnaie nationale : " +
                              (MontantEnEuros * Taux(i)).ToString)
                Else
                    Console.WriteLine("Devise non trouvée")
                End If
            End If
            Console.WriteLine(vbNewLine + "//////////////////////" + vbNewLine)
        Loop Until MontantEnEuros = 0
        Console.WriteLine("Au revoir.")
        Console.ReadLine()
    End Sub

End Module
