<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BirdDialog
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.foodLabel = New System.Windows.Forms.Label()
        Me.speciesLabel = New System.Windows.Forms.Label()
        Me.habitatLabel = New System.Windows.Forms.Label()
        Me.HeelLabel = New System.Windows.Forms.Label()
        Me.speciesTextBox = New System.Windows.Forms.TextBox()
        Me.habitatTextBox = New System.Windows.Forms.TextBox()
        Me.foodComboBox = New System.Windows.Forms.ComboBox()
        Me.nestComboBox = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(184, 337)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(195, 36)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(4, 4)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(89, 28)
        Me.OK_Button.TabIndex = 5
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(101, 4)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(89, 28)
        Me.Cancel_Button.TabIndex = 6
        Me.Cancel_Button.Text = "Cancel"
        '
        'foodLabel
        '
        Me.foodLabel.AutoSize = True
        Me.foodLabel.Location = New System.Drawing.Point(57, 162)
        Me.foodLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.foodLabel.Name = "foodLabel"
        Me.foodLabel.Size = New System.Drawing.Size(88, 17)
        Me.foodLabel.TabIndex = 1
        Me.foodLabel.Text = "Type of food"
        '
        'speciesLabel
        '
        Me.speciesLabel.AutoSize = True
        Me.speciesLabel.Location = New System.Drawing.Point(57, 52)
        Me.speciesLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.speciesLabel.Name = "speciesLabel"
        Me.speciesLabel.Size = New System.Drawing.Size(58, 17)
        Me.speciesLabel.TabIndex = 2
        Me.speciesLabel.Text = "Species"
        '
        'habitatLabel
        '
        Me.habitatLabel.AutoSize = True
        Me.habitatLabel.Location = New System.Drawing.Point(57, 107)
        Me.habitatLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.habitatLabel.Name = "habitatLabel"
        Me.habitatLabel.Size = New System.Drawing.Size(53, 17)
        Me.habitatLabel.TabIndex = 3
        Me.habitatLabel.Text = "Habitat"
        '
        'HeelLabel
        '
        Me.HeelLabel.AutoSize = True
        Me.HeelLabel.Location = New System.Drawing.Point(43, 217)
        Me.HeelLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.HeelLabel.Name = "HeelLabel"
        Me.HeelLabel.Size = New System.Drawing.Size(113, 17)
        Me.HeelLabel.TabIndex = 5
        Me.HeelLabel.Text = "Type of nest box"
        '
        'speciesTextBox
        '
        Me.speciesTextBox.Location = New System.Drawing.Point(164, 48)
        Me.speciesTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.speciesTextBox.Name = "speciesTextBox"
        Me.speciesTextBox.Size = New System.Drawing.Size(132, 22)
        Me.speciesTextBox.TabIndex = 0
        '
        'habitatTextBox
        '
        Me.habitatTextBox.Location = New System.Drawing.Point(164, 103)
        Me.habitatTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.habitatTextBox.Name = "habitatTextBox"
        Me.habitatTextBox.Size = New System.Drawing.Size(132, 22)
        Me.habitatTextBox.TabIndex = 1
        '
        'foodComboBox
        '
        Me.foodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.foodComboBox.FormattingEnabled = True
        Me.foodComboBox.Items.AddRange(New Object() {"Seeds", "Nuts", "Insects"})
        Me.foodComboBox.Location = New System.Drawing.Point(164, 159)
        Me.foodComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.foodComboBox.Name = "foodComboBox"
        Me.foodComboBox.Size = New System.Drawing.Size(132, 24)
        Me.foodComboBox.TabIndex = 2
        '
        'nestComboBox
        '
        Me.nestComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.nestComboBox.FormattingEnabled = True
        Me.nestComboBox.Items.AddRange(New Object() {"Openfront", "Largehole", "Smallhole"})
        Me.nestComboBox.Location = New System.Drawing.Point(164, 214)
        Me.nestComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.nestComboBox.Name = "nestComboBox"
        Me.nestComboBox.Size = New System.Drawing.Size(132, 24)
        Me.nestComboBox.TabIndex = 3
        '
        'BirdDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(395, 388)
        Me.Controls.Add(Me.nestComboBox)
        Me.Controls.Add(Me.foodComboBox)
        Me.Controls.Add(Me.habitatTextBox)
        Me.Controls.Add(Me.speciesTextBox)
        Me.Controls.Add(Me.HeelLabel)
        Me.Controls.Add(Me.habitatLabel)
        Me.Controls.Add(Me.speciesLabel)
        Me.Controls.Add(Me.foodLabel)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BirdDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add a new bird"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents foodLabel As System.Windows.Forms.Label
    Friend WithEvents speciesLabel As System.Windows.Forms.Label
    Friend WithEvents habitatLabel As System.Windows.Forms.Label
    Friend WithEvents HeelLabel As System.Windows.Forms.Label
    Friend WithEvents speciesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents habitatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents foodComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents nestComboBox As System.Windows.Forms.ComboBox

End Class
