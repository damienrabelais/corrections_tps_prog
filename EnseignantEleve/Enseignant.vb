Public Class Enseignant
    'ci-dessous : attributs, données encapsulées dans la classe Enseignant,
    'ils sont déclarés 'private', et donc non accessibles en dehors de la classe, 
    'sinon indirectement par des méthodes déclarées 'public' 
    Private Const VALEURINDICE As Double = 13.754
    Private numéro As String
    Private nom As String
    Private prenom As String
    Private adresse As String
    Private numTel As String
    Private dateNaiss As String
    Private indice As Integer
    Private nombreDHeures As Double 'nombre d'heures devant élèves

    Public Sub New(ByVal nouvNuméro As String, ByVal nouvNom As String,
     ByVal nouvPrenom As String, ByVal nouvAdresse As String,
     ByVal nouvNumTel As String, ByVal nouvDateNaiss As String,
     ByVal nouvIndice As Integer, ByVal nouvNombreDHeures As Double)
        numéro = nouvNuméro
        nom = nouvNom
        prenom = nouvPrenom
        adresse = nouvAdresse
        numTel = nouvNumTel
        dateNaiss = nouvDateNaiss
        indice = nouvIndice
        nombreDHeures = nouvNombreDHeures
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

    Public Function AugmenterIndice(ByVal nouvIndice As Integer) As Boolean
        If nouvIndice - indice > 0 Then
            indice = nouvIndice
            Return True
        Else
            Return False
        End If
    End Function

    Public Function GetIndice() As Integer
        Return indice
    End Function

    Public Sub SetNombreDHeures(ByVal nouvNombreDHeures As Integer)
        If nouvNombreDHeures > 0 Then
            nombreDHeures = nouvNombreDHeures
        Else
            Console.WriteLine("Le nombre d'heures devant élève ne peut être négatif!")
        End If
    End Sub

    Public Function GetnombreDHeures() As Integer
        Return nombreDHeures
    End Function

    Public Function SalaireMensuel() As Double
        Return (nombreDHeures * indice * VALEURINDICE)
    End Function

    Public Overrides Function ToString() As String
        Return vbNewLine + "Numéro : " + numéro + vbNewLine + "Nom : " + nom +
          vbNewLine + "Prénom : " + prenom + vbNewLine + "Adresse : " + adresse +
          vbNewLine + "n° de téléphone : " + numTel +
          vbNewLine + "Date de naissance : " + dateNaiss +
          vbNewLine + "Indice : " + indice.ToString() +
          vbNewLine + "Nombre d'heures : " + nombreDHeures.ToString
    End Function
End Class
