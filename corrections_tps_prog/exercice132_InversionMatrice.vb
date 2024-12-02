Module exercice132_InversionMatrice

    Const MAX As Integer = 4

    Sub echanger(ByRef pA As Double, ByRef pB As Double)
            Dim temp As Double
            temp = pA
            pA = pB
            pB = temp
        End Sub

        Sub inverserLignesMatrice(ByRef pMatrice(,) As Double)
            Dim NoLigne, NoColonne As Integer
            ' Echanges
            For NoLigne = 0 To MAX - 1
                For NoColonne = 0 To NoLigne
                    echanger(pMatrice(NoLigne, NoColonne), pMatrice(NoColonne, NoLigne))
                Next
            Next
        End Sub

        Sub afficherMatrice(ByVal pMatrice(,) As Double)
            Dim NoLigne, NoColonne As Integer
            For NoLigne = 0 To MAX - 1
                For NoColonne = 0 To MAX - 1
                    Console.Write(pMatrice(NoLigne, NoColonne).ToString() + vbTab)
                Next
                Console.WriteLine()
            Next

        End Sub

        Sub Main()
            ' Matrice en dur, pour test
            Dim Matrice(,) As Double = {
      {1, 2, 3, 4},
      {5, 6, 7, 8},
      {9, 10, 11, 12},
      {13, 14, 15, 16}
    }

            Console.WriteLine("Matrice avant inversion.")
            afficherMatrice(Matrice)
            inverserLignesMatrice(Matrice)
            Console.WriteLine("Matrice après inversion.")
            afficherMatrice(Matrice)
            Console.ReadLine()
        End Sub



    End Module
