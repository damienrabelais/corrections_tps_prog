Public Class Eleve
    Private Const MAXNOTES As Integer = 9
    'ci-dessous : attributs, données encapsulées dans la classe Eleve,
    'ils sont déclarés 'private', 
    'et donc non accessibles en dehors de la classe, 
    'sinon indirectement par des méthodes déclarées 'public' 
    Private numéro As String
    Private nom As String
    Private prenom As String
    Private adresse As String
    Private numTel As String
    Private dateNaiss As String
    Private numClasse As String
    Private tabNotes(MAXNOTES) As Double ' déclaration du tableau des notes

    ' Contructeur : initialisation des attributs
    Public Sub New(ByVal nouvNuméro As String, ByVal nouvNom As String,
         ByVal nouvPrenom As String, ByVal nouvAdresse As String,
         ByVal nouvNumTel As String, ByVal nouvDateNaiss As String,
         ByVal nouvNumClasse As String)
        numéro = nouvNuméro
        nom = nouvNom
        prenom = nouvPrenom
        adresse = nouvAdresse
        numTel = nouvNumTel
        dateNaiss = nouvDateNaiss
        numClasse = nouvNumClasse
        Dim i As Integer
        ' initialisation du tableau avec toutes les notes sont mises à -1
        For i = 0 To MAXNOTES
            tabNotes(i) = -1
        Next


    End Sub

    Public Function GetNuméro() As String
        Return numéro
    End Function

    Public Function GetNom() As String
        Return nom
    End Function

    Public Sub SetNom(ByVal nouvNom As String)
        nom = nouvNom
    End Sub

    Public Function GetPrenom() As String
        Return prenom
    End Function


    Public Sub SetPrenom(ByVal nouvPrenom As String)
        prenom = nouvPrenom
    End Sub

    Public Function GetNumTel() As String
        Return numTel
    End Function

    Public Sub SetNumTel(ByVal nouvNumTel As String)
        numTel = nouvNumTel
    End Sub

    Public Function GetAdresse() As String
        Return adresse
    End Function

    Public Sub SetAdresse(ByVal nouvAdresse As String)
        adresse = nouvAdresse
    End Sub

    Public Function GetDateNaiss() As String
        Return dateNaiss
    End Function

    Public Function GetNumClasse() As String
        Return numClasse
    End Function

    Public Sub SetNumClasse(ByVal nouvNumClasse As String)
        numClasse = nouvNumClasse
    End Sub

    Public Function Moyenne() As Double
        Dim somme As Double = 0
        Dim compteur As Integer = 0
        For i = 0 To MAXNOTES
            If tabNotes(i) <> -1 Then
                somme = somme + tabNotes(i)
                compteur = compteur + 1
            End If
        Next
        If compteur = 0 Then
            Return -1
        End If
        Return somme / compteur
    End Function

    Public Sub SetNote(ByVal noMatiere As Integer, ByVal note As Double)
        If note >= 0 And note <= 20 Then
            tabNotes(noMatiere) = note
        End If
    End Sub

    Public Overrides Function toString() As String
        Dim chaine As String
        Dim i As Integer
        ' renvoie une chaîne décrivant la "valeur" de l'objet
        chaine = "Numéro : " + numéro _
        + vbNewLine + "Nom: " + nom _
        + vbNewLine + "Prenom: " + prenom _
        + vbNewLine + "Adresse: " + adresse _
        + vbNewLine + "n° de telephone: " + numTel _
        + vbNewLine + "Date de naissance: " + dateNaiss _
        + vbNewLine + "n° de la Classe : " + numClasse

        chaine = chaine + vbNewLine + "Notes : "
        For i = 0 To MAXNOTES
            chaine = chaine + tabNotes(i).ToString() + " | "
        Next
        Return chaine
    End Function

End Class ' fin Eleve

