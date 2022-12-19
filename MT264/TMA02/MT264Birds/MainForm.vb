Imports MT264BirdTypes

Public Class MainForm

    Private fbirdAdmin As BirdAdmin


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        fbirdAdmin = New BirdAdmin

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub updateBirds()
        'Updates the list of species
        speciesListBox.Items.Clear()

        For Each species As String In fbirdAdmin.BirdSpecies
            speciesListBox.Items.Add(species)
        Next
        speciesListBox.SelectedIndex = 0

    End Sub

    Private Sub updateView()
        'Displays the list of habitats for the selected species
        Dim selectedSpecies As String
        Dim habitats As List(Of String)
        selectedSpecies = speciesListBox.SelectedItem.ToString
        habitats = fbirdAdmin.getHabitats(selectedSpecies)
        habitatListBox.Items.Clear()
        For Each habitat As String In habitats
            habitatListBox.Items.Add(habitat)
        Next
        habitatListBox.SelectedIndex = 0
        descriptionTextBox.Text = ""


    End Sub

    Private Sub addSpeciesButton_Click(sender As Object, e As EventArgs) Handles addSpeciesButton.Click
        Dim aBird As NestingBird
        Dim aBirdDlg As BirdDialog
        aBird = New NestingBird
        aBirdDlg = New BirdDialog
        aBirdDlg.foodComboBox.SelectedIndex = 0
        aBirdDlg.nestComboBox.SelectedIndex = 0
        If aBirdDlg.ShowDialog() = DialogResult.OK Then
            aBird.Species = aBirdDlg.speciesTextBox.Text
            aBird.Habitat = aBirdDlg.habitatTextBox.Text
            aBird.setFood(aBirdDlg.foodComboBox.SelectedItem.ToString())
            aBird.setBox(aBirdDlg.nestComboBox.SelectedItem.ToString())
            fbirdAdmin.addBird(aBird)
            updateBirds()
            updateView()
        End If
        aBirdDlg.Dispose()

    End Sub

    Private Sub showHabitatsButton_Click(sender As Object, e As EventArgs) Handles showHabitatsButton.Click
        updateView()

    End Sub

    Private Sub showDescriptionButton_Click(sender As Object, e As EventArgs) Handles showDescriptionButton.Click
        Dim description As String
        description = fbirdAdmin.getDescription(speciesListBox.SelectedItem.ToString(), habitatListBox.SelectedItem.ToString())
        descriptionTextBox.Text = description
    End Sub
End Class
