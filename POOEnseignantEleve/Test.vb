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
        Console.WriteLine("//////// TEST CLASSE ELEVE //////////")
        ' elevePMartin est déclaré de type Eleve, puis on le créer
        ' new fait appel au constructeur, méthode Eleve 
        Dim elevePMartin As Eleve



        elevePMartin = New Eleve("112", "Martin", "Pierre",
           "7, rue de la Paix 77000 MELUN",
           "0164024532", "23/07/02", "BTSSIO1")
        ' ci-après appel des méthodes sur l'objet elevePMartin 

        Console.WriteLine("*** SORTIE méthode ToString() ***")
        Console.WriteLine(elevePMartin.toString())
        Console.WriteLine("*** FIN SORTIE méthode ToString() ***")
        If elevePMartin.Moyenne() = -1 Then
            Console.WriteLine("Aucune note: impossible de calculer la moyenne générale.")
        Else
            Console.WriteLine("Moyenne générale : " + elevePMartin.Moyenne())
        End If

        Console.WriteLine(vbNewLine + "On renseigne 10 notes - arbitrairement - pour l'élève.")
        elevePMartin.SetNote(0, 10)
        elevePMartin.SetNote(1, 11)
        elevePMartin.SetNote(2, 10)
        elevePMartin.SetNote(3, 15) ' on affecte la note 15 pour la matière 3 
        elevePMartin.SetNote(4, 16)
        elevePMartin.SetNote(5, 5.5)
        elevePMartin.SetNote(6, 12)
        elevePMartin.SetNote(7, 6.5)
        elevePMartin.SetNote(8, 16)
        elevePMartin.SetNote(9, 10)
        'affichage de la description de notre objet via les méthodes "accesseurs"
        Console.WriteLine("Moyenne générale de " + elevePMartin.GetNom() + ", " +
              elevePMartin.GetPrenom() + " : " + elevePMartin.Moyenne().ToString())
        Console.ReadLine()
    End Sub
End Module
