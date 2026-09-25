''' <remarks>
''' What a single square of the board holds. The value folds two facts into one: what the square
''' itself is, and what is standing on it. LevelParser maps the characters of a level onto these,
''' and the skins number their icons by them.
''' </remarks>
Public Enum BoardItem
    Blank = 0
    Wall = 1
    Box = 2
    PlaceForBox = 3
    BoxOnPlace = 4
    Player = 5
    PlayerOnPlace = 6
    BlankOuter = 7
End Enum
