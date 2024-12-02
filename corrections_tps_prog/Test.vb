Module Test

    Structure TVendeur
        Dim nom As String
        Dim prénom As String
        Dim dateDeNaissance As String
        Dim salaireFixe As Double
    End Structure


    Sub Main()



        ' déclaration de leVendeurA comme étant de type TVendeur
        Dim leVendeurA As TVendeur
        Dim chefVendeur As TVendeur



        ' affectation de valeur à notre vendeur leVendeurA
        ' accès aux champs d'un objet composé
        leVendeurA.nom = "Durand"
        leVendeurA.prénom = "Pierre"
        leVendeurA.dateDeNaissance = "01/01/1980"
        leVendeurA.salaireFixe = 1800.5

        Console.WriteLine(leVendeurA)

        ' accès aux champs d'un objet composé - affichage
        Console.WriteLine("Nom de leVendeurA : " + leVendeurA.nom)
        Console.WriteLine("Prénom  de leVendeurA : " + leVendeurA.prénom)
        Console.WriteLine("Date de naissance de leVendeurA : " + leVendeurA.dateDeNaissance)
        Console.WriteLine("Salaire fixe de leVendeurA = " + leVendeurA.salaireFixe.ToString())

        ' affectation d'une structure à une autre structure...
        chefVendeur = leVendeurA
        ' accès aux champs d'un objet composé - affichage
        Console.WriteLine("Nom de chefVendeur : " + chefVendeur.nom)
        Console.WriteLine("Prénom de chefVendeur : " + chefVendeur.prénom)
        Console.WriteLine("Date de naissance de chefVendeur : " + chefVendeur.dateDeNaissance)
        Console.WriteLine("Salaire fixe de chefVendeur = " + chefVendeur.salaireFixe.ToString())

        Dim lesVendeurs(2) As TVendeur

        lesVendeurs(1).nom = "toto"
        lesVendeurs(1).prénom = "Pierre"


        For i = 0 To 2
            Console.WriteLine(lesVendeurs(i).nom)
            Console.WriteLine(lesVendeurs(i).prénom)
        Next



        Console.ReadLine()
    End Sub

End Module
