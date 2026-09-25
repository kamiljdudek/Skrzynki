Imports System.Globalization

''' <remarks>What the player chose to do after solving a level.</remarks>
Public Enum LevelSolvedChoice
    NextLevel
    RepeatLevel
End Enum

''' <remarks>
''' Shown once a level is solved. Offers the next level, another attempt at the same one, and
''' writing the solution out in LURD notation. Saving does not close the dialog, so a solution can
''' be saved to several places before deciding where to go next.
''' </remarks>
Public Class LevelSolvedForm
    Private SolutionLurd As String = String.Empty
    Private SuggestedFileName As String = "solution"

    ''' <remarks>
    ''' Defaults to the next level, so closing the dialog by any other route behaves the way the
    ''' message box it replaces did.
    ''' </remarks>
    Public Property Choice As LevelSolvedChoice = LevelSolvedChoice.NextLevel

    ''' <remarks>
    ''' Hands the dialog everything it displays and saves. The solution has to be captured before
    ''' the level is advanced or restarted, because both clear the move history it comes from.
    ''' </remarks>
    Public Sub PresentSolvedLevel(solution As String,
                                  movesPerformed As Integer,
                                  pushesPerformed As Integer,
                                  levelsetName As String,
                                  levelNumber As Integer)
        SolutionLurd = If(solution, String.Empty)
        SuggestedFileName = BuildFileName(levelsetName, levelNumber)

        LabelMoves.Text = Localizer.GetString("LabelMoves") &
            movesPerformed.ToString(CultureInfo.CurrentCulture)
        LabelPushes.Text = Localizer.GetString("LabelPushes") &
            pushesPerformed.ToString(CultureInfo.CurrentCulture)
        LabelSolutionLength.Text = Localizer.GetString("LabelSolutionLength") &
            SolutionLurd.Length.ToString(CultureInfo.CurrentCulture)

        ' Nothing to write out if the level arrived already solved.
        ButtonSaveSolution.Enabled = SolutionLurd.Length > 0
    End Sub

    ''' <remarks>
    ''' A file name the player will recognise: the levelset and the level number, with anything
    ''' the file system would reject taken out.
    ''' </remarks>
    Private Shared Function BuildFileName(levelsetName As String,
                                          levelNumber As Integer) As String
        Dim Cleaned As New System.Text.StringBuilder()

        ' A set opened from a file is named after that file, extension and all; only the stem of
        ' it belongs in the name being suggested for the solution.
        For Each Character As Char In System.IO.Path.GetFileNameWithoutExtension(
            If(levelsetName, String.Empty))
            If Array.IndexOf(System.IO.Path.GetInvalidFileNameChars(), Character) < 0 Then
                Cleaned.Append(Character)
            End If
        Next

        Dim Prefix As String = Cleaned.ToString().Trim()
        If Prefix.Length = 0 Then
            Prefix = "Skrzynki"
        End If

        Return Prefix & "-" & levelNumber.ToString(CultureInfo.InvariantCulture)
    End Function

    Private Sub LevelSolvedForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Localizer.GetString("LabelLevelSolvedTitle")
        LabelCongratulation.Text = Localizer.GetString("AlertLevelSolved")
        ButtonNextLevel.Text = Localizer.GetString("ButtonNextLevel")
        ButtonRepeatLevel.Text = Localizer.GetString("ButtonRepeatLevel")
        ButtonSaveSolution.Text = Localizer.GetString("ButtonSaveSolution")

        Me.AcceptButton = ButtonNextLevel
        ButtonNextLevel.Select()
    End Sub

    Private Sub ButtonNextLevel_Click(sender As Object, e As EventArgs) Handles ButtonNextLevel.Click
        Choice = LevelSolvedChoice.NextLevel
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub ButtonRepeatLevel_Click(sender As Object, e As EventArgs) Handles ButtonRepeatLevel.Click
        Choice = LevelSolvedChoice.RepeatLevel
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub ButtonSaveSolution_Click(sender As Object, e As EventArgs) Handles ButtonSaveSolution.Click
        SaveSolutionDialog.Title = Localizer.GetString("DialogSaveSolution")
        SaveSolutionDialog.Filter = Localizer.GetString("DialogSolutionFileFilter")
        SaveSolutionDialog.FileName = SuggestedFileName

        If SaveSolutionDialog.ShowDialog(Me) <> DialogResult.OK Then
            Exit Sub
        End If

        Try
            System.IO.File.WriteAllText(SaveSolutionDialog.FileName,
                                        SolutionLurd & Environment.NewLine,
                                        System.Text.Encoding.ASCII)
        Catch ex As System.IO.IOException
            ShowSaveFailure()
        Catch ex As UnauthorizedAccessException
            ShowSaveFailure()
        Catch ex As NotSupportedException
            ShowSaveFailure()
        End Try
    End Sub

    Private Shared Sub ShowSaveFailure()
        ShowMessage(Localizer.GetString("AlertSolutionSaveFailure"), MsgBoxStyle.Critical)
    End Sub
End Class
