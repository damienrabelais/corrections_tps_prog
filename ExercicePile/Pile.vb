Class Pile
    Const MAX As Integer = 100
    Private tabPile(MAX) As String
    Private positionLibre As Integer

    Public Sub New() ' au début le tableau est vide, 
        ' la première case vide est donc la case 0
        positionLibre = 0
    End Sub

    Public Function Empiler(ByVal pValeur As String) As Boolean
        If positionLibre > MAX Then
            Return False
        Else
            tabPile(positionLibre) = pValeur
            positionLibre = positionLibre + 1
            Return True
        End If
    End Function

    Public Function Depiler() As String
        If positionLibre > 0 Then
            positionLibre = positionLibre - 1
            Return tabPile(positionLibre)
        End If
        Return Nothing
    End Function

    Public Function EstVide() As Boolean
        Return (positionLibre = 0)
    End Function

    Public Function NombreDElements() As Integer
        Return positionLibre
    End Function

    Public Overrides Function ToString() As String
        Dim i As Integer
        Dim Chaine As String = ""
        For i = positionLibre - 1 To 0 Step -1
            ' Afichage de "haut en bas" de la pile 
            Chaine = Chaine + vbNewLine + "-----" +
              vbNewLine + tabPile(i)
            ' ATTENTION ici le '+' = opérateur de concaténation
        Next
        Return Chaine
    End Function

End Class
