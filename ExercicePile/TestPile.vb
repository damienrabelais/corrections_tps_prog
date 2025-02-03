Imports Microsoft.VisualBasic.ApplicationServices
Module TestPile
    Sub Main()
        Dim choix As Integer
        Dim unePile As Pile
        Dim ValeurSaisie As String
        unePile = New Pile()

        Do
            Console.WriteLine("1. Empiler")
            Console.WriteLine("2. Dépiler")
            Console.WriteLine("3. Tester si la Pile est vide")
            Console.WriteLine("4. Nombre d'éléments dans la Pile")
            Console.WriteLine("5. Contenu de la Pile")
            Console.WriteLine("6. Quitter")
            Console.WriteLine("Choix ?")
            choix = Console.ReadLine
            Select Case choix
                Case 1
                    Console.WriteLine("Entrer l'élément à empiler.")
                    ValeurSaisie = Console.ReadLine
                    If unePile.Empiler(ValeurSaisie) Then
                        Console.WriteLine("OK")
                    Else
                        Console.WriteLine("Pile pleine.")
                    End If
                Case 2

                    Dim valeur As String
                    valeur = unePile.Depiler()
                    If valeur <> Nothing Then
                        Console.WriteLine("Valeur extraite de la pile : " + valeur)
                    Else
                        Console.WriteLine("Pile vide.")
                    End If
                    Console.WriteLine()
                Case 3
                    If unePile.EstVide() Then 'unePile.EstVide retourne True ou False
                        Console.WriteLine("La Pile est vide.")
                    Else
                        Console.WriteLine("La Pile n'est pas vide")
                    End If
                Case 4
                    Console.WriteLine("Nombre d'élément dans la pile : " +
                    unePile.NombreDElements().ToString)
                Case 5
                    Console.WriteLine(unePile.ToString())
                Case 6
                    Console.WriteLine("Au revoir!")
            End Select
        Loop Until choix = 6
    End Sub
End Module
