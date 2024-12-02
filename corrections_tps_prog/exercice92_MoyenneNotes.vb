Imports System.Linq.Expressions

Module exercice92_MoyenneNotes
    Sub Main()
        Dim note, somme As Double
        Dim compteur As Integer

        Do
            Do
                Console.WriteLine("Note ? (entre 0 et 20, -1 pour sortir)")
                note = Console.ReadLine()
                If (note < 0 Or note > 20) And note <> -1 Then
                    Console.WriteLine("Note entre 0 et 20, -1 pour sortir")
                End If
            Loop Until note >= 0 And note <= 20 Or note = -1
            If note <> -1 Then
                compteur = compteur + 1
                somme = somme + note
            End If

        Loop Until note = -1

        Console.WriteLine(" Somme : " + somme.ToString())
        Console.WriteLine(" Compteur : " + compteur.ToString())
        Console.WriteLine(" Moyenne : " + (somme / compteur).ToString())

        Console.ReadLine()

    End Sub
End Module
