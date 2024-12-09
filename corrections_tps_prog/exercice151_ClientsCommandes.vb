Imports System.Security.Cryptography.X509Certificates
Imports System.Xml.Serialization

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
        Dim i As Integer = 0
        While pTabCommandes(i).numéro <> pNuméroCommande And i < MAX
            i = i + 1
        End While
        If pTabCommandes(i).numéro = pNuméroCommande Then
            ' Si commande trouvé, on chercher le client
            ' dans le tableau de clients
            Dim codeClientTrouvé As String
            codeClientTrouvé = pTabCommandes(i).codeClient
            i = 0
            'On cherche le client
            While pTabClients(i).code <> codeClientTrouvé And i < MAX
                i = i + 1
            End While
            If pTabClients(i).code = codeClientTrouvé Then ' si client trouvé
                Return pTabClients(i)
            End If
        End If
        ' Si n° de commande absent dans pTabCommandes,
        ' ou code client non absent dans pTabClients
        Dim vide As TClient
        vide.code = "X"
        Return vide
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
        lesCommandes(1).numéro = 22
        lesCommandes(1).dateC = "02-01-02"
        lesCommandes(1).montant = 200
        lesCommandes(1).codeClient = "C01"
        lesCommandes(2).numéro = 42
        lesCommandes(2).dateC = "02-01-03"
        lesCommandes(2).montant = 300
        lesCommandes(2).codeClient = "C02"

        Dim choix As Integer
        Do
            Console.WriteLine("1. Montant total des commandes passées par un client (code client)")
            Console.WriteLine("2. Détails d'un client pour une commande (n° de commande)")
            Console.WriteLine("3. Quitter")
            Console.WriteLine("Choix ?")
            choix = Console.ReadLine()
            Select Case choix
                Case 1
                    Dim codeClientLu As String
                    Console.WriteLine("Code client ?")
                    codeClientLu = Console.ReadLine
                    Console.WriteLine("Montant commandé : " +
                    MontantCommandé(codeClientLu, lesCommandes).ToString())
                Case 2
                    Dim numéroCommandeLue As Integer
                    Dim clientTrouvé As TClient
                    Console.WriteLine("Numéro commande ?")
                    numéroCommandeLue = Console.ReadLine()
                    clientTrouvé = ClientPourUneCommande(numéroCommandeLue, lesCommandes, lesClients)
                    If clientTrouvé.code = "X" Then
                        Console.WriteLine("Client ou commande non trouvé(e)")
                    Else
                        AfficherUnClient(clientTrouvé)
                    End If
                Case 3
                    Console.WriteLine("Au revoir")
                Case Else
                    Console.WriteLine("Choix erroné.")
            End Select
        Loop Until choix = 3
        Console.ReadLine()
    End Sub
End Module
