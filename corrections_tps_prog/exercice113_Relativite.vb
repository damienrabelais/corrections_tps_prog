Module exercice113_Relativite
    Const C As Double = 300000 'Vitesse de la lumière (constante, approximation ici)

    Function DuréeSurTerre(ByVal pDurée As Double,
               ByVal pVitesseFusée As Double) As Double
        Return (pDurée / Math.Sqrt(1 - (pVitesseFusée ^ 2 / C ^ 2)))
    End Function

    Function LongueurSurTerre(ByVal pLongueurFusée As Double,
                ByVal pVitesseFusée As Double) As Double
        Return (pLongueurFusée * Math.Sqrt(1 - (pVitesseFusée ^ 2 / C ^ 2)))
    End Function

    Function VitesseRepèreTerre(ByVal pVitesseRepèreFusée As Double,
                ByVal pVitesseFusée As Double) As Double
        Return ((pVitesseRepèreFusée + pVitesseFusée) /
        (1 + ((pVitesseRepèreFusée * pVitesseFusée) / C ^ 2)))
    End Function

    Sub Main()
        Dim vitesseFuséeLue, vitesseObusLue, duréeDansFusée, tailleFusée As Double
        Dim choix As Integer
        Do
            Console.WriteLine("1. La dilatation du temps")
            Console.WriteLine("2. La contraction des longueurs")
            Console.WriteLine("3. Loi de composition des vitesses")
            Console.WriteLine("4. Quitter")
            Console.WriteLine("Choix ?")
            choix = Console.ReadLine()

            Select Case choix
                Case 1
                    Do
                        Console.WriteLine("Vitesse de la fusée (en km/s) ?")
                        vitesseFuséeLue = Console.ReadLine()
                    Loop Until vitesseFuséeLue >= 0
                    Do
                        Console.WriteLine("Durée écoulée dans la fusée (en secondes) ?")
                        duréeDansFusée = Console.ReadLine()
                    Loop Until duréeDansFusée >= 0
                    Console.WriteLine("Durée écoulée sur la terre = " +
              DuréeSurTerre(duréeDansFusée, vitesseFuséeLue).ToString() + " secondes")
                Case 2
                    Do
                        Console.WriteLine("Vitesse de la fusée (en km/s) ?")
                        vitesseFuséeLue = Console.ReadLine()
                    Loop Until vitesseFuséeLue >= 0
                    Do
                        Console.WriteLine("Taille de la fusée (en kms)?")
                        tailleFusée = Console.ReadLine()
                    Loop Until tailleFusée >= 0
                    Console.WriteLine("Taille de la fusée vue de la terre = " +
              LongueurSurTerre(tailleFusée, vitesseFuséeLue).ToString() + " kms.")
                Case 3
                    Do
                        Console.WriteLine("Vitesse de la fusée (en km/s) ?")
                        vitesseFuséeLue = Console.ReadLine()
                    Loop Until vitesseFuséeLue >= 0
                    Do
                        Console.WriteLine("Vitesse de l'obus, dans le repère de la fusée (en km/s) ?")
                        vitesseObusLue = Console.ReadLine()
                    Loop Until vitesseObusLue >= 0
                    Console.WriteLine("Vitesse de l'obus par rapport à la terre = " +
              VitesseRepèreTerre(vitesseObusLue, vitesseFuséeLue).ToString)
                Case 4
                    Console.WriteLine("Au revoir.")
                Case Else
                    Console.WriteLine("Choix erroné.")
            End Select
        Loop Until choix = 4
        Console.ReadLine()
    End Sub


End Module
