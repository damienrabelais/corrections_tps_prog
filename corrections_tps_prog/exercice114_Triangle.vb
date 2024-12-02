Module exercice114_Triangle
    'Pour nbLignes = 5
    'Ligne 1 : 4b 1e  (5-1)b  (1*2-1)e
    'Ligne 2 : 3b 3e  (5-2)b  (2*2-1)e
    'Ligne 3 : 2b 5e  (5-3)b  (3*2-1)e
    'Ligne 4 : 1b 7e  ....  
    'Ligne 5 : 0b 9e  ...
    'Ligne noLigne :  (nbLignes-noLigne)b (noLigne*2-1)e

    Sub AfficherTriangle(ByVal pNbLignes As Integer)
        Dim i, noLigne, nombreDeBlancs, nombreDEtoiles As Integer
        nombreDeBlancs = pNbLignes - 1
        nombreDEtoiles = 1
        For noLigne = 1 To pNbLignes
            For i = 1 To nombreDeBlancs 'Affiche nombreDeBlancs blancs
                Console.Write(" ")
            Next
            For i = 1 To nombreDEtoiles 'Affiche nombreDEtoiles étoiles
                Console.Write("*")
            Next
            nombreDeBlancs = nombreDeBlancs - 1
            nombreDEtoiles = nombreDEtoiles + 2
            Console.WriteLine() ' A la ligne
        Next
    End Sub

    Sub Main()
        Dim nbLignes As Integer

        Do ' contrôle de saisie
            Console.WriteLine("Combien de lignes pour votre triangle ? (>=0) ")
            nbLignes = Console.ReadLine()
            If nbLignes < 0 Then
                Console.WriteLine("Erreur. > 0.")
            End If
        Loop Until nbLignes >= 0
        AfficherTriangle(nbLignes)
        Console.ReadLine()
    End Sub



End Module
