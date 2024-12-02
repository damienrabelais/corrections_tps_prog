Module exercice133_OccupationDesSalles
    Const MAXSALLES As Integer = 10  ' mis à 10 (au lieu de 50) pour test
    Const MAXJOURS As Integer = 6
        Const MAXTRANCHES As Integer = 10

        Sub initialiser(ByRef pTab(,,) As Integer)
            Dim noSalle, noJour, noTranche As Integer
            ' Parcours du tableau à 3 dimensions; toutes les cases sont mises à 0
            ' (on considère ici que toutes les salles sont libres, par défaut)
            ' Le parcours débute à 1, les cases en "0" sont perdues
            For noSalle = 0 To MAXSALLES - 1
                For noJour = 0 To MAXJOURS - 1
                    For noTranche = 0 To MAXTRANCHES - 1
                        pTab(noSalle, noJour, noTranche) = 0
                    Next
                Next
            Next
        End Sub

        Sub Main()
            Dim capalu, heurlu, jourlu, Occupation(MAXSALLES, MAXJOURS, MAXTRANCHES) As Integer
            Dim Capacité() As Integer = {20, 40, 30, 20, 10,
                   50, 10, 20, 20, 25} 'la première ne sera pas 
            Dim noSalle As Integer

            initialiser(Occupation)
            ' On place quelques cases à "occuppée", choisies arbitrairement
            Occupation(3, 2, 4) = 1
            Occupation(1, 1, 1) = 1
            Occupation(1, 2, 1) = 1
            Occupation(4, 5, 1) = 1
            Occupation(2, 2, 4) = 1
            Occupation(8, 3, 2) = 1
            Occupation(5, 3, 3) = 1
            Do
                Console.WriteLine("Jour ?")
                jourlu = Console.ReadLine()
            Loop Until jourlu >= 1 And jourlu <= MAXJOURS
            jourlu = jourlu - 1 ' 1ère case du tableau index = 0
            Do
                Console.WriteLine("Tranche horaire ?")
                heurlu = Console.ReadLine()
            Loop Until heurlu >= 1 And heurlu <= MAXTRANCHES
            heurlu = heurlu - 1
            Do
                Console.WriteLine("Capacité ?")
                capalu = Console.ReadLine()
            Loop Until capalu >= 1

            ' On fait juste "bouger" le numéro de salle (noSalle, ici),
            ' jour et tranche horaire sont fixés par l'utilisateur
            For noSalle = 0 To MAXSALLES - 1
                If Occupation(noSalle, jourlu, heurlu) = 0 And Capacité(noSalle) >= capalu Then
                    Console.WriteLine("La salle n°" + (noSalle + 1).ToString() + " est libre")
                End If
            Next
            Console.ReadLine()
        End Sub


    End Module
