Imports MT264BirdTypes

Public Class BirdAdmin
    Private fBirds As List(Of NestingBird)

    'Returns a list of the species of the birds with no repetitions.
    Public ReadOnly Property BirdSpecies As List(Of String)
        Get
            Dim result As List(Of String)
            Dim aSpecies As String
            result = New List(Of String)
            For Each bird As NestingBird In fBirds
                aSpecies = bird.Species
                If Not result.Contains(aSpecies) Then
                    result.Add(aSpecies)
                End If
            Next
            Return result
        End Get
    End Property

    Public Sub New()
        'Write your code here.
        fBirds = New List(Of NestingBird)

    End Sub

    'Preconditions: none
    'Postconditions: A new nesting bird, aBird, is added to (the end of) 
    'the list of nesting birds.
    Public Sub addBird(ByVal aBird As NestingBird)
        'Write your code here.
        fBirds.Add(aBird)

    End Sub

    'Preconditions: none
    'Postconditions: A list containing the habitats (with no repetitions)
    'of all birds with species aSpecies is returned.
    Public Function getHabitats(ByVal aSpecies As String) As List(Of String)
        Dim habitats As List(Of String)
        Dim aHabitat As String
        habitats = New List(Of String)
        For Each bird As NestingBird In fBirds
            If bird.Species = aSpecies Then
                aHabitat = bird.Habitat
                If Not habitats.Contains(aHabitat) Then
                    habitats.Add(aHabitat)
                End If
            End If
        Next
        Return habitats
    End Function

    'Preconditions: none
    'Postconditions: A description of a bird with species aSpecies and habitat aHabitat
    'is returned.
    Public Function getDescription(ByVal aSpecies As String, ByVal aHabitat As String) As String
        Dim result As String
        Dim found As Boolean
        Dim index As Integer
        index = 0
        found = False
        result = ""
        While Not found And index < fBirds.Count
            If fBirds.Item(index).Species = aSpecies Then
                If fBirds.Item(index).Habitat = aHabitat Then
                    result = fBirds.Item(index).getDescription()
                    found = True
                End If
            End If
            index = index + 1
        End While
        Return result
    End Function
End Class
