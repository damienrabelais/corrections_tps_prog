Module exercice152_MiniGestionParc
    Const MAX As Integer = 9

    Structure TMatériel
            Dim noSerie As String
            Dim modèle As String
            Dim type As String
            Dim annéeDAchat As Integer
        End Structure

    Function SaisirMatériel() As TMatériel
        Dim unMatériel As TMatériel
        Console.WriteLine("n° de série ?")
        unMatériel.noSerie = Console.ReadLine()
        Console.WriteLine("Modèle ?")
        unMatériel.modèle = Console.ReadLine()
        Console.WriteLine("Type ?")
        unMatériel.type = Console.ReadLine()
        Console.WriteLine("Année d'achat ?")
        unMatériel.annéeDAchat = Console.ReadLine()
        Return unMatériel
    End Function

    Sub AfficherUnMatériel(ByVal pUnMatériel As TMatériel)
        Console.WriteLine("n° de série : " + pUnMatériel.noSerie)
        Console.WriteLine("Modèle : " + pUnMatériel.modèle)
        Console.WriteLine("Type : " + pUnMatériel.type)
        Console.WriteLine("Année d'achat : " + pUnMatériel.annéeDAchat.ToString())
    End Sub

    Sub AfficherLesMatériels(ByVal pLesMatériels() As TMatériel,
                  ByVal pPosLibre As Integer)
        Dim i As Integer
        Console.WriteLine(vbNewLine + "Listes des matériels : ")
        For i = 0 To pPosLibre - 1
            AfficherUnMatériel(pLesMatériels(i))
        Next
    End Sub

    Function AjouterUnMatériel(ByVal pMatériel As TMatériel, ByRef pLesMatériels() As TMatériel,
           ByRef pPosLibre As Integer) As Boolean
        If (pPosLibre >= MAX + 1) Then
            Return False
        Else
            pLesMatériels(pPosLibre) = pMatériel
            pPosLibre = pPosLibre + 1
            Return True
        End If
    End Function

    Function SupprimerParIndex(ByVal pIndex As Integer,
               ByRef pLesMatériels() As TMatériel,
               ByRef pPosLibre As Integer) As Boolean
        Dim i As Integer
        If (pIndex < 0 Or pIndex > pPosLibre - 1) Then
            Return False
        Else
            ' on tasse à gauche pour éviter un tableau "gruyère"
            For i = pIndex To pPosLibre - 2
                pLesMatériels(i) = pLesMatériels(i + 1)
            Next
            pPosLibre = pPosLibre - 1
            Return True
        End If
    End Function

    Function SupprimerParNoSérie(ByVal pNoSérie As String,
                     ByRef pLesMatériels() As TMatériel,
                     ByRef pPosLibre As Integer) As Boolean
        Dim index, i As Integer
        ' On recherche la case correspondant à pNoSérie
        While pNoSérie <> pLesMatériels(i).noSerie And i < pPosLibre
            i = i + 1
        End While
        ' On sort lorsqu'on a trouvé OU lorsqu'on atteind la fin du tableau
        If pNoSérie = pLesMatériels(i).noSerie Then ' Si on a bien trouvée pMatériel
            index = i 'Index de la case à supprimer
            ' on tasse à gauche pour éviter un tableau "gruyère"
            For i = index To pPosLibre - 2
                pLesMatériels(i) = pLesMatériels(i + 1)
            Next
            pPosLibre = pPosLibre - 1
            Return True
            ' On peut remplacer les lignes 79 à 83 par 
            ' Return SupprimerParIndex(index, pLesMatériels, pPosLibre)
        Else
            Return False
        End If
    End Function

    Sub main()
        Dim noSérieLu As String
        Dim LesMatériels(MAX) As TMatériel

        Dim positionLibre, index, choix As Integer
        positionLibre = 0
        Do
            Console.WriteLine("1. Ajouter un matériel dans le tableau.")
            Console.WriteLine("2. Supprimer un matériel (saisie index)")
            Console.WriteLine("3. Supprimer un matériel (saisie n° série).")
            Console.WriteLine("4. Lister à l'écran tous les matériels.")
            Console.WriteLine("5. Quitter.")
            Console.WriteLine("Choix ?")
            choix = Console.ReadLine

            Select Case choix
                Case 1 ' Ajouter un matériel dans le tableau
                    If AjouterUnMatériel(SaisirMatériel(), LesMatériels, positionLibre) Then
                        Console.WriteLine("Ajout effectué.")
                    Else
                        Console.WriteLine("Ajout impossible, tableau plein")
                        End If
                    Case 2
                        Console.WriteLine("Index du matériel à supprimer ?")
                        index = Console.ReadLine
                        If SupprimerParIndex(index, LesMatériels, positionLibre) Then
                            Console.WriteLine("Suppression réussie.")
                        Else
                            Console.WriteLine("n° série inexistant : suppression impossible.")
                        End If
                    Case 3 '
                        Console.WriteLine("n° de série du matériel à supprimer ?")
                        noSérieLu = Console.ReadLine
                        If SupprimerParNoSérie(noSérieLu, LesMatériels, positionLibre) Then
                            ' si fonction retourne True
                            Console.WriteLine("Suppression réussie.")
                        Else
                            Console.WriteLine("n° série inexistant : suppression impossible.")
                        End If
                    Case 4 ' Lister à l'écran toutes les matériels
                    AfficherLesMatériels(LesMatériels, positionLibre)
                Case 5
                    Console.WriteLine("Au revoir")
                    Case Else
                        Console.WriteLine("Choix erroné.")
                End Select
            Loop Until choix = 5
            Console.ReadLine()
        End Sub


    End Module
