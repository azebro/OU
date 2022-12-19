Module Module1

    Private aaa As FoodType
    Sub Main()

        'Dim jackRobin = New GardenBird
        'jackRobin.Species = "robin"
        'jackRobin.Habitat = "hedgerows"
        'jackRobin.Food = FoodType.Insects
        aaa = 1


    End Sub

    Function reveal(aChar As Char, word As String, hidden As String) As String
        Dim result As String
        result = ""
        Dim index As Integer
        For index = 1 To word.Length
            If word.Chars(index - 1) = aChar Then
                result = result + word.Chars(index - 1)
            End If
        Next

        Return result
    End Function

    Enum FoodType
        Seeds
        Nuts
        Insects
    End Enum


End Module
