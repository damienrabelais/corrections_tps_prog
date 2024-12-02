Module exercice151_ClientsCommandes
    Const MAX As Integer = 2

    Structure TClient
        Dim code As String
        Dim nom As String
        Dim adresse As String
    End Structure


    Structure TCommande
        Dim numéro As Integer
        Dim dateC As String
        Dim montant As Double
        Dim codeClient As String
    End Structure


    Sub AfficherUnClient(ByVal pUnClient As TClient)
        ' affiche un client
        Console.WriteLine("Code client : " + pUnClient.code)
        Console.WriteLine("Nom :" + pUnClient.nom)
        Console.WriteLine("Adresse :" + pUnClient.adresse)
    End Sub


    Function ClientPourUneCommande(ByVal pNuméroCommande As Integer,
    ByVal pTabCommandes() As TCommande,
    ByVal pTabClients() As TClient) As TClient
        ' retourne le client, de type TClient correspondant au n° de commande
        ' passé en paramètre. Si le n° de commande n'existe pas. Retourne un
        ' client, de type TClient, 'vide', à l'exception du champ code qui sera
        ' mis à X
    End Function


    Function MontantCommandé(ByVal pCodeClient As String,
                          ByVal pTabCommandes() As TCommande) As Double
        ' retourne le montant total commandé par le client ayant
        ' pour code pCodeClient
        Dim montantTotal As Double = 0

        For i = 0 To 2
            If pTabCommandes(i).codeClient = pCodeClient Then
                montantTotal = montantTotal + pTabCommandes(i).montant
            End If
        Next
        Return montantTotal
    End Function


    Sub Main()
        Dim lesClients(MAX) As TClient
        Dim lesCommandes(MAX) As TCommande
        lesClients(0).code = "C01"
        lesClients(0).nom = "NomC01"
        lesClients(0).adresse = "AdresseC01"
        lesClients(1).code = "C02"
        lesClients(1).nom = "NomC02"
        lesClients(1).adresse = "AdresseC02"
        lesClients(2).code = "C03"
        lesClients(2).nom = "NomC03"
        lesClients(2).adresse = "AdresseC03"

        lesCommandes(0).numéro = 1
        lesCommandes(0).dateC = "01-01-01"
        lesCommandes(0).montant = 100
        lesCommandes(0).codeClient = "C02"
        lesCommandes(1).numéro = 2
        lesCommandes(1).dateC = "02-01-02"
        lesCommandes(1).montant = 200
        lesCommandes(1).codeClient = "C01"
        lesCommandes(2).numéro = 3
        lesCommandes(2).dateC = "02-01-03"
        lesCommandes(2).montant = 300
        lesCommandes(2).codeClient = "C02"


        ' A COMPLETER

        AfficherUnClient(lesClients(1))

        Console.WriteLine(MontantCommandé("C02", lesCommandes))


        Console.ReadLine()

    End Sub

End Module
