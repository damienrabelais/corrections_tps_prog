Module exercice73G2_HeuresSup
    Sub Main()
        Dim nombreDHeuresTravaillees, tauxHoraire, salaireHebdomadaire As Double
        Console.WriteLine("Nombre d'heures travaillees hebdomadaire ?")
        nombreDHeuresTravaillees = Console.ReadLine()
        If nombreDHeuresTravaillees < 39 Then
            Console.WriteLine("Vous ne travaillez pas assez !")
            salaireHebdomadaire = 0
        Else ' >=39
            Console.WriteLine("Taux horaire ?")
            tauxHoraire = Console.ReadLine()
            If nombreDHeuresTravaillees < 47 Then
                salaireHebdomadaire = 39 * tauxHoraire +
                (nombreDHeuresTravaillees - 39) * (tauxHoraire + tauxHoraire * 25 / 100)
            Else ' >= 47
                salaireHebdomadaire = 39 * tauxHoraire +
                8 * (tauxHoraire * 1.25) +
                (nombreDHeuresTravaillees - 47) * (tauxHoraire * 1.5)
            End If
        End If
        Console.WriteLine("Salaire hebdomadaire : " + salaireHebdomadaire.ToString())
        Console.WriteLine("Au revoir.")
        Console.ReadLine()
    End Sub
End Module