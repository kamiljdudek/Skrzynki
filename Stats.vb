Option Strict On
Option Explicit On
Module Stats

    Class LevelsetStats
        Public ReachedLevel As Integer
        Public Moves As Integer
        Public Pushes As Integer

        Sub New(Optional ByVal R As Integer = 1, Optional ByVal M As Integer = 0, Optional ByVal P As Integer = 0)
            ReachedLevel = R
            Moves = M
            Pushes = P
        End Sub
    End Class
    Structure Results
        Dim OsiagnietyEtap As Integer
        Dim Ruchy As Integer
        Dim Pchniecia As Integer
    End Structure

    Structure Player
        Dim Zestaw As String
        Dim Klasyczne As Results
        Dim SuperTrudneXS As Results
    End Structure

    Public DaneGracza As Player

    Public Sub ZapiszStatystyki()
        My.Settings.ArrivedLevelKlasyczne = DaneGracza.Klasyczne.OsiagnietyEtap
        My.Settings.MovesKlasyczne = DaneGracza.Klasyczne.Ruchy
        My.Settings.PushesKlasyczne = DaneGracza.Klasyczne.Pchniecia

        My.Settings.ArrivedLevelSupertrudne = DaneGracza.Klasyczne.OsiagnietyEtap
        My.Settings.MovesSupertrudne = DaneGracza.Klasyczne.Ruchy
        My.Settings.PushesSupertrudne = DaneGracza.Klasyczne.Pchniecia
    End Sub

    Public Sub OdczytajStatystyki()

        DaneGracza.Klasyczne.OsiagnietyEtap = My.Settings.ArrivedLevelKlasyczne
        DaneGracza.Klasyczne.Ruchy = My.Settings.MovesKlasyczne
        DaneGracza.Klasyczne.Pchniecia = My.Settings.PushesKlasyczne

        DaneGracza.Klasyczne.OsiagnietyEtap = My.Settings.ArrivedLevelSupertrudne
        DaneGracza.Klasyczne.Ruchy = My.Settings.MovesSupertrudne
        DaneGracza.Klasyczne.Pchniecia = My.Settings.PushesSupertrudne
    End Sub

End Module