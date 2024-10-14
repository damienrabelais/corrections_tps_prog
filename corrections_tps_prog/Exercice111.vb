Module Exercice111

    Function périmètreCercle(ByVal pRayon As Double) As Double
        Dim périmètre As Double  'périmètre est une variable locale à la fonction
        périmètre = 2 * Math.PI * pRayon
        Return périmètre ' valeur retournée
    End Function

    Function surfaceCercle(ByVal pRayon As Double) As Double
        Dim surface As Double 'surface est une variable locale à la fonction
        surface = Math.PI * pRayon ^ 2
        Return surface ' valeur retournée
    End Function

    Function périmètreRectangle(ByVal pLongueur As Double, ByVal pLargeur As Double) As Double
        Return (pLongueur + pLargeur) * 2 ' valeur retournée
    End Function

    Function surfaceRectangle(ByVal pLongueur As Double, ByVal pLargeur As Double) As Double
        Return (pLongueur * pLargeur) ' valeur retournée
    End Function

    Sub Main() ' Programme principal
        Dim choix As Integer
        Dim rayonSaisi, longueurSaisie, largeurSaisie As Double

        Do
            Console.WriteLine("1. Calcul du périmètre d'un cercle.")
            Console.WriteLine("2. Calcul de la surface d'un cercle.")
            Console.WriteLine("3. Calcul du périmètre d'un rectangle.")
            Console.WriteLine("4. Calcul de la surface d'un rectangle.")
            Console.WriteLine("5. Quitter.")
            Console.WriteLine("Choix ?")
            choix = Console.ReadLine()

            Select Case choix
                Case 1
                    Do
                        Console.WriteLine("Rayon du cercle ? (Rayon > 0) ")
                        rayonSaisi = Console.ReadLine()
                        If rayonSaisi <= 0 Then
                            Console.WriteLine("Rayon > 0")
                        End If
                    Loop Until rayonSaisi > 0
                    Console.WriteLine("Périmètre: " + périmètreCercle(rayonSaisi).ToString())
                Case 2
                    Console.WriteLine("Rayon du cercle ? (Rayon > 0) ")
                    rayonSaisi = Console.ReadLine()
                    If rayonSaisi <= 0 Then
                        Console.WriteLine("Rayon > 0")
                    End If
                    Console.WriteLine("Surface : " + surfaceCercle(rayonSaisi).ToString())
                Case 3
                    Do
                        Console.WriteLine("Longueur du rectangle (Longueur > 0) ")
                        longueurSaisie = Console.ReadLine()
                        If longueurSaisie <= 0 Then
                            Console.WriteLine("Longueur > 0")
                        End If
                    Loop Until longueurSaisie > 0
                    Do
                        Console.WriteLine("Largeur du rectangle (Longueur > 0) ")
                        largeurSaisie = Console.ReadLine()
                        If largeurSaisie <= 0 Then
                            Console.WriteLine("Largeur > 0")
                        End If
                    Loop Until largeurSaisie > 0
                    Console.WriteLine("Périmètre: " +
                    périmètreRectangle(longueurSaisie, largeurSaisie).ToString())
                Case 4
                    Do
                        Console.WriteLine("Longueur du rectangle (Longueur > 0) ")
                        longueurSaisie = Console.ReadLine()
                        If longueurSaisie <= 0 Then
                            Console.WriteLine("Longueur > 0")
                        End If
                    Loop Until longueurSaisie > 0
                    Do
                        Console.WriteLine("Largeur du rectangle (Longueur > 0) ")
                        largeurSaisie = Console.ReadLine()
                        If largeurSaisie <= 0 Then
                            Console.WriteLine("Largeur > 0")
                        End If
                    Loop Until largeurSaisie > 0
                    Console.WriteLine("Surface : " +
                    surfaceRectangle(longueurSaisie, largeurSaisie).ToString())
                Case 5
                    Console.WriteLine("Au revoir")
                Case Else
                    Console.WriteLine("Choix erroné.")
            End Select
        Loop Until choix = 5
        Console.ReadLine()
    End Sub

End Module
