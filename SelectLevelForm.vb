''' <remarks>
''' Asks which level to play. The number box only offers levels the player may open, so there is
''' nothing to parse and nothing out of range to reject after the fact.
''' </remarks>
Public Class SelectLevelForm

    ''' <param name="highestLevel">The highest level that may be picked; the lowest is always 1.</param>
    ''' <param name="suggestedLevel">The level the box starts on, brought into range if need be.</param>
    Public Sub New(highestLevel As Integer, suggestedLevel As Integer)
        InitializeComponent()

        LevelNumber.Maximum = Math.Max(1, highestLevel)
        LevelNumber.Value = Math.Max(LevelNumber.Minimum, Math.Min(suggestedLevel, LevelNumber.Maximum))
    End Sub

    Public ReadOnly Property SelectedLevel As Integer
        Get
            Return CInt(LevelNumber.Value)
        End Get
    End Property

    Private Sub SelectLevelForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = MessageTitle
        LabelPrompt.Text = My.Resources.LocalizableStrings.DialogSelectLevel
        ButtonOK.Text = My.Resources.LocalizableStrings.ButtonOK
        ButtonCancel.Text = My.Resources.LocalizableStrings.ButtonCancel

        ' Selected in full, so that typing a number replaces the suggestion.
        LevelNumber.Select(0, LevelNumber.Text.Length)
    End Sub
End Class
