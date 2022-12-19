Imports System.Windows.Forms

Public Class NestingBird
    Inherits Bird

    Enum FoodType
        Seeds
        Nuts
        Insects
    End Enum

    Enum BoxType
        Largehole
        Smallhole

    End Enum

    Private _food As FoodType
    Private NestBox As BoxType
    Private speciesTextBox As TextBox
    Private habitatTextBox As TextBox
    Private foodComboBox As ComboBox
    Private nestComboBox As ComboBox

    Sub Main()
        Dim myBird = New NestingBird
        myBird.Species = speciesTextBox.Text
        myBird.Habitat = habitatTextBox.Text
        'Assuming that the indexes in the combobox correspont to values assiged to enums
        'otherwise need to read the SelectedItem and parse and cast to enums
        myBird.Food = foodComboBox.SelectedIndex
        myBird.NestBox = nestComboBox.SelectedIndex
    End Sub


    Public Property Food() As FoodType
        Get
            Return _food
        End Get
        Set(ByVal value As FoodType)
            _food = value
        End Set
    End Property

    Public Sub New()
        Species = ""
        Habitat = ""
        Food = 2

    End Sub

    Function getDescription() As String
        Dim output As String
        output = String.Format("Breeds in {0} and eats {1}. ", Habitat, Food.ToString())
        Select Case NestBox
            Case BoxType.Largehole
                output = output + "Nests in a large hole nest box."
                End
            Case BoxType.Smallhole
                output = output + "Nests in a small hole nest box."
                End
        End Select
        Return output
    End Function

End Class
