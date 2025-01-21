Module TestCompteur

    Sub Main()

        Dim a, b As Compteur

        a = New Compteur(10)
        Console.WriteLine(a.GetValeur())
        a.PlusUn()
        a.PlusUn()
        Console.WriteLine(a.GetValeur())
        a.IncrementeDe(100)
        Console.WriteLine(a.GetValeur())


        Console.WriteLine("/////////////////")
        b = New Compteur(9)
        a = b
        Console.WriteLine("a  = " + a.GetValeur().ToString())
        Console.WriteLine("b = " + b.GetValeur().ToString())
        a.IncrementeDe(1000)
        Console.WriteLine("a  = " + a.GetValeur().ToString())
        Console.WriteLine("b = " + b.GetValeur().ToString())
        b.PlusUn()
        Console.WriteLine("a  = " + a.GetValeur().ToString())
        Console.WriteLine("b = " + b.GetValeur().ToString())


        Console.ReadLine()
    End Sub

End Module
