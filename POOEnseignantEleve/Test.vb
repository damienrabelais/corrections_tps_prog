Module Test

    Sub Main()
        Console.WriteLine("//////// TEST CLASSE ENSEIGNANT //////////")
        Dim unEnseignant As Enseignant
        unEnseignant = New Enseignant("E0112", "Dupont", "Pierre",
                    "1, rue de la Paix - 75000 PARIS",
                    "0145045540", "1/10/1980", 8, 20)
        Console.WriteLine("*** SORTIE méthode ToString() ***")
        Console.WriteLine(unEnseignant.ToString())
        Console.WriteLine("*** FIN SORTIE méthode ToString() ***" + vbNewLine)
        Console.WriteLine("Salaire Mensuel : " + unEnseignant.SalaireMensuel().ToString())

        Console.WriteLine(vbNewLine + "Au fait passer l'indice à 2 (contre 8 précédemment)")
        If unEnseignant.AugmenterIndice(2) Then
            Console.WriteLine("Augmentation d'indice enregistrée.")
        Else
            Console.WriteLine("L'indice ne peut être baissé.")
        End If
        Console.WriteLine("Au fait passer l'indice à 10 (contre 8 précédemment)")
        If unEnseignant.AugmenterIndice(10) Then
            Console.WriteLine("Augmentation d'indice enregistrée.")
        Else
            Console.WriteLine("L'indice ne peut être baissé.")
        End If
        Console.WriteLine(vbNewLine + "Indice : " + unEnseignant.GetIndice().ToString())
        Console.WriteLine("Salaire Mensuel : " + unEnseignant.SalaireMensuel().ToString())

        Console.WriteLine()
        Console.ReadLine()

    End Sub

End Module
