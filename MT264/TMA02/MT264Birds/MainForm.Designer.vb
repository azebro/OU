<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mainMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.speciesListBox = New System.Windows.Forms.ListBox()
        Me.habitatListBox = New System.Windows.Forms.ListBox()
        Me.showDescriptionButton = New System.Windows.Forms.Button()
        Me.addSpeciesButton = New System.Windows.Forms.Button()
        Me.showHabitatsButton = New System.Windows.Forms.Button()
        Me.descriptionTextBox = New System.Windows.Forms.TextBox()
        Me.mainMenu.SuspendLayout
        Me.SuspendLayout
        '
        'mainMenu
        '
        Me.mainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.mainMenu.Location = New System.Drawing.Point(0, 0)
        Me.mainMenu.Name = "mainMenu"
        Me.mainMenu.Size = New System.Drawing.Size(693, 24)
        Me.mainMenu.TabIndex = 0
        Me.mainMenu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'speciesListBox
        '
        Me.speciesListBox.FormattingEnabled = true
        Me.speciesListBox.Location = New System.Drawing.Point(37, 72)
        Me.speciesListBox.Name = "speciesListBox"
        Me.speciesListBox.Size = New System.Drawing.Size(271, 212)
        Me.speciesListBox.TabIndex = 1
        '
        'habitatListBox
        '
        Me.habitatListBox.FormattingEnabled = true
        Me.habitatListBox.Location = New System.Drawing.Point(371, 72)
        Me.habitatListBox.Name = "habitatListBox"
        Me.habitatListBox.Size = New System.Drawing.Size(271, 212)
        Me.habitatListBox.TabIndex = 2
        '
        'showDescriptionButton
        '
        Me.showDescriptionButton.Location = New System.Drawing.Point(439, 404)
        Me.showDescriptionButton.Name = "showDescriptionButton"
        Me.showDescriptionButton.Size = New System.Drawing.Size(122, 23)
        Me.showDescriptionButton.TabIndex = 3
        Me.showDescriptionButton.Text = "Show Description"
        Me.showDescriptionButton.UseVisualStyleBackColor = true
        '
        'addSpeciesButton
        '
        Me.addSpeciesButton.Location = New System.Drawing.Point(567, 404)
        Me.addSpeciesButton.Name = "addSpeciesButton"
        Me.addSpeciesButton.Size = New System.Drawing.Size(75, 23)
        Me.addSpeciesButton.TabIndex = 4
        Me.addSpeciesButton.Text = "Add Species"
        Me.addSpeciesButton.UseVisualStyleBackColor = true
        '
        'showHabitatsButton
        '
        Me.showHabitatsButton.Location = New System.Drawing.Point(324, 404)
        Me.showHabitatsButton.Name = "showHabitatsButton"
        Me.showHabitatsButton.Size = New System.Drawing.Size(109, 23)
        Me.showHabitatsButton.TabIndex = 5
        Me.showHabitatsButton.Text = "Show Habitats"
        Me.showHabitatsButton.UseVisualStyleBackColor = true
        '
        'descriptionTextBox
        '
        Me.descriptionTextBox.Location = New System.Drawing.Point(37, 302)
        Me.descriptionTextBox.Name = "descriptionTextBox"
        Me.descriptionTextBox.Size = New System.Drawing.Size(605, 20)
        Me.descriptionTextBox.TabIndex = 6
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 462)
        Me.Controls.Add(Me.descriptionTextBox)
        Me.Controls.Add(Me.showHabitatsButton)
        Me.Controls.Add(Me.addSpeciesButton)
        Me.Controls.Add(Me.showDescriptionButton)
        Me.Controls.Add(Me.habitatListBox)
        Me.Controls.Add(Me.speciesListBox)
        Me.Controls.Add(Me.mainMenu)
        Me.MainMenuStrip = Me.mainMenu
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bird List"
        Me.mainMenu.ResumeLayout(false)
        Me.mainMenu.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents mainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents speciesListBox As ListBox
    Friend WithEvents habitatListBox As ListBox
    Friend WithEvents showDescriptionButton As Button
    Friend WithEvents addSpeciesButton As Button
    Friend WithEvents showHabitatsButton As Button
    Friend WithEvents descriptionTextBox As TextBox
End Class
