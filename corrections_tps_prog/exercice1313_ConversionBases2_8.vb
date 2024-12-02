Module exercice1313_ConversionBases2_8
    Const MAX As Integer = 8

    Sub Convertir(ByVal pN As Integer, ByVal pBase As Integer)
            Dim Resultat(MAX), N, i, Temp, Quotient As Integer
            Temp = pN
            i = 0
            Do
                Resultat(i) = Temp Mod pBase 'Reste de la division entière
                Quotient = Temp \ pBase 'Division entière
                Temp = Quotient
                i = i + 1
            Loop Until Temp = 0
            N = i
        ' Affichage
        Console.WriteLine("Affichage nombre = tableau résultat.")
        For i = N - 1 To 0 Step -1
                Console.Write(Resultat(i))
            Next
            Console.WriteLine()
        End Sub

        Sub Main()
            Dim Base, Nombre As Integer
            Dim Choix As Char

            Do
                Do
                    Console.WriteLine("Entrez le nombre à convertir")
                    Nombre = Console.ReadLine
                Loop Until Nombre >= 0 And Nombre <= 255
                Do
                    Console.WriteLine("Entrez la base vers laquelle faire la conversion (2 ou 8)")
                    Base = Console.ReadLine
                Loop Until Base = 2 Or Base = 8
                Convertir(Nombre, Base)
                Do
                    Console.WriteLine("Voulez-vous refaire une conversion ? (O/N)")
                    Choix = Console.ReadLine()
                Loop Until Choix = "N" Or Choix = "O"
            Loop Until Choix = "N"
        End Sub

    End Module
