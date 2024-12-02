Module exercice91_MoyenneNotes
    Sub Main()
        Dim note, somme, moyenne, pourcentage As Double
        Dim nbNotes, nbNotesSup10 As Integer

        Console.WriteLine("Entrez une note (-1 pour fin) :")
        note = Console.ReadLine()
        While note <> -1
            If note > 10 Then
                nbNotesSup10 = nbNotesSup10 + 1
            End If
            somme = somme + note
            nbNotes = nbNotes + 1
            Console.WriteLine("Entrez une note (-1 pour fin) :")
            note = Console.ReadLine()
        End While
        moyenne = somme / nbNotes
        pourcentage = nbNotesSup10 / nbNotes * 100
        Console.WriteLine("Vous avez " + pourcentage.ToString() + " % de notes > à 10")
        Console.WriteLine("Votre moyenne est de  " + moyenne.ToString())
        Console.ReadLine()
    End Sub

End Module


